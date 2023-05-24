using System.Data;
using System.Data.Common;

namespace PizzariaDoZe.DAO
{
    public class Ingrediente
    {
        public int ID { get; set; }
        public string Nome { get; set; }

        public Ingrediente(int id = 0, string nome = "")
        {
            ID = id;
            Nome = nome;
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

            comando.CommandText = @"INSERT INTO ingrediente(nome) VALUES (@nome)";

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
                auxSqlFiltro = "WHERE i.id = " + ingrediente.ID + " ";
            }
            else if (ingrediente.Nome.Length > 0)
            {
                auxSqlFiltro = "WHERE i.nome like '%" + ingrediente.Nome + "%' ";
            }
            conexao.Open();
            comando.CommandText = @" " +
            "SELECT i.id AS ID, i.nome AS Nome " +
            "FROM tb_ingrediente AS i " +
            auxSqlFiltro +
            "ORDER BY i.nome;";
            //Executa o script na conexão e retorna as linhas afetadas.
            var reader = comando.ExecuteReader();
            DataTable linhas = new();
            linhas.Load(reader);

            return linhas;
        }

        private Ingrediente ConverterSqlParaObjeto(DbDataReader leitor)
        {
            var Ingrediente = new Ingrediente();
            Ingrediente.ID = int.Parse(leitor["id_ingrediente"].ToString()!);
            Ingrediente.Nome = leitor["nome"].ToString()!;

            return Ingrediente;
        }
        private void ConverterObjetoParaSql(Ingrediente ingrediente, DbCommand comando)
        {
            var nome = comando.CreateParameter();
            nome.ParameterName = "@nome";
            nome.Value = ingrediente.Nome;
            comando.Parameters.Add(nome);
        }
    }
}