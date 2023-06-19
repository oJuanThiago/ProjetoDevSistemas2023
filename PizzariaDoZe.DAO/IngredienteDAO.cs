using System.Data;
using System.Data.Common;

namespace PizzariaDoZe.DAO
{
    public class Ingrediente
    {
        public int ID { get; set; }
        public string Descricao { get; set; }

        public Ingrediente(int id = 0, string nome = "")
        {
            ID = id;
            Descricao = nome;
        }
        public override string ToString()
        {
            return Descricao;
        }
    }

    public class IngredienteDAO
    {
        /// <summary>
        /// Utilização de mais do que um provider com o mesmo script (MySQL, SQLServer, Firebird...)
        /// </summary>
        private readonly DbProviderFactory factory;
        private string Provider { get; set; }
        private string StringConexao { get; set; }

        public IngredienteDAO(string provider, string stringConexao)
        {
            Provider = provider;
            StringConexao = stringConexao;
            factory = DbProviderFactories.GetFactory(Provider);
        }

        public void InserirDbProvider(Ingrediente ingrediente)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão

            conexao.Open();
            ConverterObjetoParaSql(ingrediente, comando);

            comando.CommandText = @"INSERT INTO cad_ingredientes(descricao_ingrediente) VALUES (@descricao)";

            //Executa o script na conexão e retorna o número de linhas afetadas.
            var linhas = comando.ExecuteNonQuery();

            //using faz o Close() automático quando fecha o seu escopo
        }
        public DataTable Buscar(Ingrediente ingrediente)
        {
            using var conexao = factory.CreateConnection();
            conexao!.ConnectionString = StringConexao;
            using var comando = factory.CreateCommand();
            comando!.Connection = conexao;

            //verifica se tem filtro e personaliza o SQL do filtro
            string auxSqlFiltro = "";
            if (ingrediente.ID > 0)
            {
                auxSqlFiltro = "WHERE i.id_ingrediente = " + ingrediente.ID + " ";
            }
            else if (ingrediente.Descricao.Length > 0)
            {
                auxSqlFiltro = "WHERE i.descricao_ingrediente like '%" + ingrediente.Descricao + "%' ";
            }
            conexao.Open();
            comando.CommandText = @" " +
            "SELECT i.id_ingrediente AS ID, i.descricao_ingrediente AS Nome " +
            "FROM cad_ingredientes AS i " +
            auxSqlFiltro +
            "ORDER BY i.descricao_ingrediente;";
            //Executa o script na conexão e retorna as linhas afetadas.
            var reader = comando.ExecuteReader();
            DataTable linhas = new();
            linhas.Load(reader);

            return linhas;
        }

        public void Editar(Ingrediente ingrediente)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão

            conexao.Open();
            ConverterObjetoParaSql(ingrediente, comando);

            comando.CommandText = @"UPDATE cad_ingredientes SET descricao_ingrediente = @descricao WHERE id_ingrediente = @id";

            var linhas = comando.ExecuteNonQuery();
        }

        public void Excluir(Ingrediente ingrediente)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //Adiciona parâmetro (@campo e valor)
            var id = comando.CreateParameter();
            id.ParameterName = "@id";
            id.Value = ingrediente.ID;
            comando.Parameters.Add(id);
            conexao.Open();
            // Inicia o controle de Transação LOCAL
            DbTransaction transacao = conexao.BeginTransaction();
            // Associa o command com o controle de Transação
            comando.Transaction = transacao;
            try
            {
                //limpa todos os ingredientes do sabores
                comando.CommandText = @"DELETE FROM itens_sabores WHERE ingrediente_id = @id;";
                _ = comando.ExecuteNonQuery();
                //realiza o UPDATE
                comando.CommandText = @"DELETE FROM cad_ingredientes WHERE id_ingrediente = @id;";
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

        private Ingrediente ConverterSqlParaObjeto(DbDataReader leitor)
        {
            var Ingrediente = new Ingrediente();
            Ingrediente.ID = int.Parse(leitor["id_ingrediente"].ToString()!);
            Ingrediente.Descricao = leitor["descricao_ingrediente"].ToString()!;

            return Ingrediente;
        }
        private void ConverterObjetoParaSql(Ingrediente ingrediente, DbCommand comando)
        {
            var id = comando.CreateParameter();
            id.ParameterName = "@id";
            id.Value = ingrediente.ID;
            comando.Parameters.Add(id);

            var descricao = comando.CreateParameter();
            descricao.ParameterName = "@descricao";
            descricao.Value = ingrediente.Descricao;
            comando.Parameters.Add(descricao);
        }

    }
}