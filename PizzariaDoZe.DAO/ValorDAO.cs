using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.DAO
{
    public class Valor
    {
        public int ID { get; set; }
        public string Tamanho { get; set; }
        public string Categoria { get; set; }
        public decimal ValorPizza { get; set; }
        public decimal ValorBorda { get; set; }

        public Valor(int id = 0, string tamanho = " ", string categoria = " ", decimal valorPizza = 0,
        decimal valorBorda = 0)
        {
            ID = id;
            Tamanho = tamanho;
            Categoria = categoria;
            ValorPizza = valorPizza;
            ValorBorda = valorBorda;
        }
    }
    public class ValorDAO
    {
        private readonly DbProviderFactory factory;
        private string Provider { get; set; }
        private string StringConexao { get; set; }
        public ValorDAO(string provider, string stringConexao)
        {
            Provider = provider;
            StringConexao = stringConexao;
            factory = DbProviderFactories.GetFactory(Provider);
        }

        public int Inserir(Valor valor)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //Adiciona parâmetro (@campo e valor)
            var tamanho = comando.CreateParameter(); tamanho.ParameterName = "@tamanho"; tamanho.Value = valor.Tamanho; 
            comando.Parameters.Add(tamanho);

            var categoria = comando.CreateParameter(); categoria.ParameterName = "@categoria"; categoria.Value = valor.Categoria; 
            comando.Parameters.Add(categoria);

            var valorPizza = comando.CreateParameter(); valorPizza.ParameterName = "@valorPizza"; valorPizza.Value = valor.ValorPizza; 
            comando.Parameters.Add(valorPizza);

            var valorBorda = comando.CreateParameter(); valorBorda.ParameterName = "@valorBorda"; valorBorda.Value = valor.ValorBorda; 
            comando.Parameters.Add(valorBorda);

            conexao.Open();
            //ajusta o comando SQL para capturar o ID gerado tanto do MySQL como do SQLServer
            string auxSQL_ID = Provider.Contains("MySql") ? "SELECT LAST_INSERT_ID();" : "SELECT SCOPE_IDENTITY();";
            //realiza o INSERT e retorna o ID gerado, algo que vai ser necessário na sequencia
            comando.CommandText = @"" +
            "INSERT INTO tb_valor (tamanho, categoria, valor, valor_borda) " +
            "VALUES (@tamanho, @categoria, @valorPizza, @valorBorda);" +
            auxSQL_ID;
            //executa o comando no banco de dados e captura o ID gerado
            var IdvalorGerado = comando.ExecuteScalar();

            return Convert.ToInt32(IdvalorGerado);
        }

        public DataTable Buscar(Valor valor)
        {

            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //verifica se tem filtro e personaliza o SQL do filtro
            string auxSqlFiltro = "";

            if (valor.ID > 0)
            {
                auxSqlFiltro = "WHERE s.id_valor = " + valor.ID + " ";
            }
            conexao.Open();
            comando.CommandText =   @" " +
                                    "SELECT id_valor AS ID, " +
                                    "tamanho AS Tamanho, " +
                                    "categoria AS Categoria, " +
                                    "valor AS 'Valor Pizza', " +
                                    "valor_borda AS 'Valor Borda' " +
                                    "FROM tb_valor AS v " +
                                    auxSqlFiltro +
                                    ";";
            //Executa o script na conexão e retorna as linhas afetadas.
            var sdr = comando.ExecuteReader();
            DataTable linhas = new();
            linhas.Load(sdr);

            return linhas;
        }

        public void Editar(Valor valor)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //Adiciona parâmetro (@campo e valor)
            var id = comando.CreateParameter(); id.ParameterName = "@id"; id.Value = valor.ID; 
            comando.Parameters.Add(id);

            var tamanho = comando.CreateParameter(); tamanho.ParameterName = "@tamanho"; tamanho.Value = valor.Tamanho; 
            comando.Parameters.Add(tamanho);

            var categoria = comando.CreateParameter(); categoria.ParameterName = "@categoria"; categoria.Value = valor.Categoria; 
            comando.Parameters.Add(categoria);

            var valorPizza = comando.CreateParameter(); valorPizza.ParameterName = "@valor"; valorPizza.Value = valor.ValorPizza; 
            comando.Parameters.Add(valor);

            var valorBorda = comando.CreateParameter(); valorBorda.ParameterName = "@valor_borda"; valorBorda.Value = valor.ValorBorda; 
            comando.Parameters.Add(valor);
            conexao.Open();
            // Inicia o controle de Transação LOCAL
            DbTransaction transacao = conexao.BeginTransaction();
            // Associa o command com o controle de Transação
            comando.Transaction = transacao;
            try
            {
                //realiza o UPDATE
                comando.CommandText = @"UPDATE tb_valor SET tamanho = @tamanho, categoria = @categoria,  valor = @valor, valor_borda = @valor_borda WHERE id_valor = @id;";
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

        public void Excluir(Valor valor)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //Adiciona parâmetro (@campo e valor)
            var id = comando.CreateParameter();
            id.ParameterName = "@id";
            id.Value = valor.ID;
            comando.Parameters.Add(id);
            conexao.Open();
            // Inicia o controle de Transação LOCAL
            DbTransaction transacao = conexao.BeginTransaction();
            // Associa o command com o controle de Transação
            comando.Transaction = transacao;
            try
            {
                //limpa todos os ingredientes do valor
                comando.CommandText = @"DELETE FROM tb_pizza WHERE valor_id = @id;";
                _ = comando.ExecuteNonQuery();
                //realiza o UPDATE
                comando.CommandText = @"DELETE FROM tb_valor WHERE id_valor = @id;";
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
    }
}
