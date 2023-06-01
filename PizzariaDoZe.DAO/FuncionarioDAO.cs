using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.DAO
{
    public class Funcionario
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Matricula { get; set; }
        public string Senha { get; set; }
        public string Grupo { get; set; }
        public string CNH { get; set; }
        public DateTime Validade { get; set; }
        public string Observacao { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public int EnderecoID { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public Funcionario(int id = 0, string nome = "", string cpf = "", string matricula = "", string senha = "", string grupo = "", string
        motorista = "", DateTime validade_motorista = default, string observacao = "", string telefone = "", string email = "", int endereco_id = 0,
        string numero = "", string complemento = "")
        {
            ID = id;
            Nome = nome;
            CPF = cpf;
            Matricula = matricula;
            Senha = senha;
            Grupo = grupo;
            CNH = motorista;
            Validade = validade_motorista;
            Observacao = observacao;
            Telefone = telefone;
            Email = email;
            EnderecoID = endereco_id;
            Numero = numero;
            Complemento = complemento;
        }
        public class FuncionarioDAO
        {
            /// <summary>
            /// Utilização de mais do que um provider com o mesmo script (MySQL, SQLServer, Firebird...)
            /// </summary>
            private readonly DbProviderFactory factory;
            private string Provider { get; set; }
            private string StringConexao { get; set; }
            public FuncionarioDAO(string provider, string stringConexao)
            {
                Provider = provider;
                StringConexao = stringConexao;
                factory = DbProviderFactories.GetFactory(Provider);
            }
            // MÉTODO INSERIR AQUI
            public int Inserir(Funcionario funcionario)
            {
                using var conexao = factory.CreateConnection(); //Cria conexão
                conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
                using var comando = factory.CreateCommand(); //Cria comando
                comando!.Connection = conexao; //Atribui conexão
                                               //Adiciona parâmetro (@campo e valor)
                var nome = comando.CreateParameter(); nome.ParameterName = "@nome";
                nome.Value = funcionario.Nome; comando.Parameters.Add(nome);

                var cpf = comando.CreateParameter(); cpf.ParameterName = "@cpf";
                cpf.Value = funcionario.CPF; comando.Parameters.Add(cpf);

                var matricula = comando.CreateParameter(); matricula.ParameterName = "@matricula";
                matricula.Value = funcionario.Matricula; comando.Parameters.Add(matricula);

                var senha = comando.CreateParameter(); senha.ParameterName = "@senha";
                senha.Value = funcionario.Senha; comando.Parameters.Add(senha);

                var grupo = comando.CreateParameter(); grupo.ParameterName = "@grupo";
                grupo.Value = funcionario.Grupo; comando.Parameters.Add(grupo);

                var motorista = comando.CreateParameter(); motorista.ParameterName = "@motorista";
                motorista.Value = funcionario.CNH; comando.Parameters.Add(motorista);

                var validade_motorista = comando.CreateParameter(); validade_motorista.ParameterName = "@validade_motorista";
                validade_motorista.Value = funcionario.Validade; comando.Parameters.Add(validade_motorista);

                var observacao = comando.CreateParameter(); observacao.ParameterName = "@observacao";
                observacao.Value = funcionario.Observacao; comando.Parameters.Add(observacao);

                var telefone = comando.CreateParameter(); telefone.ParameterName = "@telefone";
                telefone.Value = funcionario.Telefone; comando.Parameters.Add(telefone);

                var email = comando.CreateParameter(); email.ParameterName = "@email";
                email.Value = funcionario.Email; comando.Parameters.Add(email);

                var endereco_id = comando.CreateParameter(); endereco_id.ParameterName = "@endereco_id";
                endereco_id.Value = funcionario.EnderecoID; comando.Parameters.Add(endereco_id);

                var numero = comando.CreateParameter(); numero.ParameterName = "@numero";
                numero.Value = funcionario.Numero; comando.Parameters.Add(numero);

                var complemento = comando.CreateParameter(); complemento.ParameterName = "@complemento";
                complemento.Value = funcionario.Complemento; comando.Parameters.Add(complemento);

                conexao.Open();
                //ajusta o comando SQL para capturar o ID gerado tanto do MySQL como do SQLServer
                string auxSQL_ID = Provider.Contains("MySql") ? "SELECT LAST_INSERT_ID();" : "SELECT SCOPE_IDENTITY();";
                //realiza o INSERT e retorna o ID gerado, algo que vai ser necessário na sequencia
                comando.CommandText = @"INSERT INTO tb_funcionarios (nome_funcionario, cpf, matricula, senha, grupo, motorista, validade_motorista, observacao, telefone, email, endereco_id, numero, complemento)
                                        VALUES (@nome, @cpf, @matricula, @senha, @grupo, @motorista, @validade_motorista, @observacao, @telefone, @email, @endereco_id, @numero, @complemento);" + auxSQL_ID;
                //executa o comando no banco de dados e captura o ID gerado
                var IdGerado = comando.ExecuteScalar();
                return Convert.ToInt32(IdGerado);
            }

            public DataTable Buscar(Funcionario funcionario)
            {
                using var conexao = factory.CreateConnection(); //Cria conexão
                conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
                using var comando = factory.CreateCommand(); //Cria comando
                comando!.Connection = conexao; //Atribui conexão
                                               //verifica se tem filtro e personaliza o SQL do filtro
                string auxSqlFiltro = "";
                if (funcionario.ID > 0)
                {
                    auxSqlFiltro = "WHERE f.id_funcionario = " + funcionario.ID + " ";
                }
                else if (funcionario.Nome.Length > 0)
                {
                    auxSqlFiltro = "WHERE f.nome_funcionario like '%" + funcionario.Nome + "%' ";
                }
                conexao.Open();
                comando.CommandText =   @" " +
                                        "SELECT f.id_funcionario AS ID, f.nome_funcionario AS Nome, f.cpf AS CPF, f.matricula AS Matrícula, f.senha AS Senha, f.grupo AS Grupo, " +
                                        "f.motorista AS Carteira, f.validade_motorista AS Validade, f.observacao AS Observação, f.telefone AS Telefone, f.email AS 'E-Mail', " +
                                        "e.cep AS CEP, e.logradouro AS Logradouro, e.bairro AS Bairro, " +
                                        "c.nome_cidade AS Cidade, " +
                                        "u.nome_uf AS UF, " +
                                        "f.numero AS Número, f.complemento AS Complemento " +
                                        "FROM tb_funcionarios AS f " +
                                        "INNER JOIN tb_enderecos AS e ON e.id_endereco = f.endereco_id " +
                                        "INNER JOIN cad_cidades AS c ON c.id_cidade = e.cidade_id " +
                                        "INNER JOIN cad_uf AS u ON u.id_uf = c.uf_id " +
                                        "INNER JOIN cad_paises AS p ON p.id_pais = u.pais_id " +
                                        auxSqlFiltro +
                                        "ORDER BY f.nome_funcionario;";
                //Executa o script na conexão e retorna as linhas afetadas.
                var sdr = comando.ExecuteReader();
                DataTable linhas = new();
                linhas.Load(sdr);
                return linhas;
            }
        }
    }
}
