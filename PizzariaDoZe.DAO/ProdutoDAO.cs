using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.DAO
{
    public class Produto
    {
        public int ID { get; set; }
        public string Descricao { get; set; }
        public string ML { get; set; }
        public decimal Valor { get; set; }
        public string Tipo { get; set; }

        public Produto(int id = 0, string descricao = "", string ml = "", decimal valor = 0, string tipo = "")
        {
            ID = id;
            Descricao = descricao;
            ML = ml;
            Valor = valor;
            Tipo = tipo;
        }
        public override string ToString()
        {
            return Descricao + " " + ML + " ml/g";
        }
    }
    public class ProdutoDAO
    {
        private readonly DbProviderFactory factory;
        private string Provider { get; set; }
        private string StringConexao { get; set; }
        public ProdutoDAO(string provider, string stringConexao)
        {
            Provider = provider;
            StringConexao = stringConexao;
            factory = DbProviderFactories.GetFactory(Provider);
        }
        //MÉTODO INSERIR AQUI
        public int Inserir(Produto produto)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //Adiciona parâmetro (@campo e valor)
            var descricao = comando.CreateParameter(); descricao.ParameterName = "@descricao"; descricao.Value = produto.Descricao; 
            comando.Parameters.Add(descricao);

            var valorProduto = comando.CreateParameter(); valorProduto.ParameterName = "@valorProduto"; valorProduto.Value = produto.Valor; 
            comando.Parameters.Add(valorProduto);

            var tipo = comando.CreateParameter(); tipo.ParameterName = "@tipo"; tipo.Value = produto.Tipo; 
            comando.Parameters.Add(tipo);

            var ml = comando.CreateParameter(); ml.ParameterName = "@ml"; ml.Value = produto.ML; 
            comando.Parameters.Add(ml);

            conexao.Open();
            //ajusta o comando SQL para capturar o ID gerado tanto do MySQL como do SQLServer
            string auxSQL_ID = Provider.Contains("MySql") ? "SELECT LAST_INSERT_ID();" : "SELECT SCOPE_IDENTITY();";
            //realiza o INSERT e retorna o ID gerado, algo que vai ser necessário na sequencia
            comando.CommandText = @"" +
            "INSERT INTO cad_produtos (descricao_produto, valor, tipo, medida_unitaria) " +
            "VALUES (@descricao, @valorProduto, @tipo, @ml);" +
            auxSQL_ID;
            //executa o comando no banco de dados e captura o ID gerado
            var IdSaborGerado = comando.ExecuteScalar();

            return Convert.ToInt32(IdSaborGerado);
        }
        public (DataTable, Produto) Buscar(Produto produto)
        {

            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //verifica se tem filtro e personaliza o SQL do filtro
            string auxSqlFiltro = "";
            if (produto.ID > 0)
            {
                auxSqlFiltro = "WHERE p.id_produto = " + produto.ID + " ";
            }
            else if (produto.Descricao.Length > 0)
            {
                auxSqlFiltro = "WHERE p.descricao_produto like '%" + produto.Descricao + "%' ";
            }
            conexao.Open();
            comando.CommandText =   @" " +
                                    "SELECT id_produto AS ID, descricao_produto AS Descricao, valor AS Valor, tipo AS Tipo, medida_unitaria AS ML " +
                                    "FROM cad_produtos AS p " +
                                    auxSqlFiltro +
                                    "ORDER BY p.descricao_produto;";
            //Executa o script na conexão e retorna as linhas afetadas.
            var sdr = comando.ExecuteReader();
            while (sdr.Read())
            {
                produto.ID = int.Parse(sdr["ID"].ToString()!);
                produto.Descricao = sdr["Descricao"].ToString()!;
                produto.Valor = decimal.Parse(sdr["Valor"].ToString()!);
                produto.Tipo = sdr["Tipo"].ToString()!;
                produto.ML = sdr["ML"].ToString()!;

            }
            DataTable linhas = new();
            linhas.Load(sdr);

            return (linhas, produto);
        }

        public void Editar(Produto produto)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //Adiciona parâmetro (@campo e valor)
            var descricao = comando.CreateParameter(); descricao.ParameterName = "@descricao"; descricao.Value = produto.Descricao; 
            comando.Parameters.Add(descricao);
            
            var valorProduto = comando.CreateParameter(); valorProduto.ParameterName = "@valorProduto"; valorProduto.Value = produto.Valor; 
            comando.Parameters.Add(valorProduto);

            var tipo = comando.CreateParameter(); tipo.ParameterName = "@tipo"; tipo.Value = produto.Tipo; 
            comando.Parameters.Add(tipo);

            var ml = comando.CreateParameter(); ml.ParameterName = "@ml"; ml.Value = produto.ML; 
            comando.Parameters.Add(ml);

            conexao.Open();

            DbTransaction transacao = conexao.BeginTransaction();
            // Associa o command com o controle de Transação
            comando.Transaction = transacao;
            try
            {
                //realiza o UPDATE
                comando.CommandText = @"UPDATE cad_produtos SET descricao_produto = @descricao, valor = @valorProduto,  tipo = @tipo, ml = @ml WHERE id_produto = @id;";
                //executa o comando no banco de dados e captura o ID gerado
                _ = comando.ExecuteNonQuery();
                // Como não ocorreu nenhum erro, confirma as transações através do Commit()
                transacao.Commit();
            }
            catch (Exception ex)
            {
                // Alguns dos comandos SQL acima gerou erro, dessa forma, todos os comandos serão desfeitos através do Rollback()
                transacao.Rollback();
                // retorna uma exceção para quem chamou a execução
                throw new Exception(ex.Message);
            }
        }

        public void Excluir(Produto produto)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //Adiciona parâmetro (@campo e valor)
            var id = comando.CreateParameter();
            id.ParameterName = "@id";
            id.Value = produto.ID;
            comando.Parameters.Add(id);
            conexao.Open();
            // Inicia o controle de Transação LOCAL
            DbTransaction transacao = conexao.BeginTransaction();
            // Associa o command com o controle de Transação
            comando.Transaction = transacao;
            try
            {
                //limpa todos os ingredientes do valor
                comando.CommandText = @"DELETE FROM lista_produtos WHERE produto_id = @id;";
                _ = comando.ExecuteNonQuery();
                //realiza o UPDATE
                comando.CommandText = @"DELETE FROM cad_produtos WHERE id_produto = @id;";
                _ = comando.ExecuteNonQuery();
                // Como não ocorreu nenhum erro, confirma as transações através do Commit()
                transacao.Commit();
            }
            catch (Exception ex)
            {
                // Alguns dos comandos SQL acima gerou erro, dessa forma, todos os comandos serão desfeitos através do Rollback()
                transacao.Rollback();
                // retorna uma exceção para quem chamou a execução
                throw new Exception(ex.Message);
            }
        }

        public (DataTable, List<Produto>) BuscarTodos()
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
            conexao.Open();
            comando.CommandText = @" " +
                                    "SELECT pd.id_produto AS ID, pd.descricao_produto AS Descricao, pd.valor AS Valor, pd.tipo AS Tipo, pd.medida_unitaria AS ML FROM cad_produtos pd ORDER BY pd.descricao_produto ";

            var sdr = comando.ExecuteReader();
            var todosProdutos = new List<Produto>();
            while (sdr.Read())
            {
                var produto = new Produto();
                produto.ID = int.Parse(sdr["ID"].ToString()!);
                produto.Descricao = sdr["Descricao"].ToString()!;
                produto.Valor = decimal.Parse(sdr["Valor"].ToString()!);
                produto.Tipo = sdr["Tipo"].ToString()!;
                produto.ML = sdr["ML"].ToString()!;

                todosProdutos.Add(produto);
            }

            DataTable linhas = new();
            linhas.Load(sdr);
            return (linhas, todosProdutos);

        }
    }
}
