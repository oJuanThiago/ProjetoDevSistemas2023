using System.Data.Common;

namespace PizzariaDoZe.DAO
{
    public class Ingrediente
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Ingrediente(int id = 0, string nome = "")
        {
            Id = id;
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

            //Adiciona parâmetro (@campo e valor)
            var nome = comando.CreateParameter(); nome.ParameterName = "@nome";
            nome.Value = ingrediente.Nome; 
            comando.Parameters.Add(nome);

            conexao.Open();

            comando.CommandText = @"INSERT INTO ingrediente(nome) VALUES (@nome)";

            //Executa o script na conexão e retorna o número de linhas afetadas.
            var linhas = comando.ExecuteNonQuery();

            //using faz o Close() automático quando fecha o seu escopo
        }


    }
}