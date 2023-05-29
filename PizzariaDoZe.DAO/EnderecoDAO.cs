using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.DAO
{
    public class Endereco
    {
        public int ID { get; set; }
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        //cidade_id
        public int IdCidade { get; set; }
        public string Cidade { get; set; }
        //uf_id
        public int IdUF { get; set; }
        public string UF { get; set; }
        //pais_id
        public int IdPais { get; set; }
        public string Pais { get; set; }
        public Endereco(int id = 0, string cep = "", string logradouro = "", string bairro = "",
        int idCidade = 0, string cidade = "",
        int idUf = 0, string uf = "",
        int idPais = 0, string pais = "")
        {
            ID = id;
            CEP = cep;
            Logradouro = logradouro;
            Bairro = bairro;
            IdCidade = idCidade;
            Cidade = cidade;
            IdUF = idUf;
            UF = uf;
            IdPais = idPais;
            Pais = pais;
        }
    }
    public class EnderecoDAO
    {
        private readonly DbProviderFactory factory;
        private string Provider { get; set; }
        private string StringConexao { get; set; }
        public EnderecoDAO(string provider, string stringConexao)
        {
            Provider = provider;
            StringConexao = stringConexao;
            factory = DbProviderFactories.GetFactory(Provider);
        }
        // MÉTODO BUSCAR AQUI
        public DataTable Buscar(Endereco endereco)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //verifica se tem filtro e personaliza o SQL do filtro
            string auxSqlFiltro = "";
            if (endereco.ID > 0)
            {
                auxSqlFiltro = "WHERE e.id = " + endereco.ID + " ";
            }
            else if (endereco.CEP.Length > 0)
            {
                auxSqlFiltro = "WHERE e.cep = '" + endereco.CEP + "' ";
            }
            conexao.Open();
            comando.CommandText = @" " +
            "SELECT e.id_endereco AS ID, e.cep AS CEP, e.logradouro AS Logradouro, e.bairro AS Bairro, " +
            "c.id_cidade AS IDCidade, c.nome_cidade AS Cidade, " +
            "u.id_uf AS IDUF, u.nome_uf AS UF, " +
            "p.id_pais AS IDPais, p.nome_pais AS Pais " +
            "FROM tb_enderecos AS e " +
            "INNER JOIN cad_cidades AS c ON c.id_cidade = e.cidade_id " +
            "INNER JOIN cad_uf AS u ON u.id_uf = c.uf_id " +
            "INNER JOIN cad_paises AS p ON p.id_pais = u.pais_id " +
            auxSqlFiltro +
            "ORDER BY e.cep;";
            //Executa o script na conexão e retorna as linhas afetadas.
            var sdr = comando.ExecuteReader();
            DataTable linhas = new();
            linhas.Load(sdr);
            return linhas;
        }
    }
}
