using PizzariaDoZe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PizzariaDoZe.DAO.Funcionario;

namespace PizzariaDoZe
{
    public partial class FormFuncionarios : Form
    {
        private readonly FuncionarioDAO funcionarioDAO;
        private readonly EnderecoDAO enderecoDAO;
        public FormFuncionarios()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            funcionarioDAO = new FuncionarioDAO(provider, strConnection);
            enderecoDAO = new EnderecoDAO(provider, strConnection);
            maskedTextBoxCEP.Leave += MaskedTextBoxCep_Leave;
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if (textBoxEnderecoID.Text.Length <= 0)
            {
                MessageBox.Show("Selecione um endereço valido!");
                return;
            }
            //Instância e Preenche o objeto com os dados da view
            var funcionario = new Funcionario
            {
                ID = 0,
                Nome = textBoxNome.Text,
                CPF = maskedTextBoxCPF.Text,
                Matricula = textBoxMatricula.Text,
                Senha = Funcoes.Sha256Hash(textBoxSenha.Text),
                Grupo = comboBoxFuncao.Text,
                CNH = maskedTextBoxCNH.Text,
                Validade = dateTimePickerValidade.Value,
                Observacao = textBoxObs.Text,
                Telefone = maskedTextBoxTel.Text,
                Email = textBoxEmail.Text,
                EnderecoID = int.Parse(textBoxEnderecoID.Text),
                Numero = textBoxNumero.Text,
                Complemento = textBoxComplemento.Text,
            };
            try
            {
                // chama o método da model para inserir e capturar o ID do cliente
                int IdFuncionarioGerado = funcionarioDAO.Inserir(funcionario);
                MessageBox.Show("Dados inseridos com sucesso! " + IdFuncionarioGerado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MaskedTextBoxCep_Leave(object? sender, EventArgs e)
        {
            if (maskedTextBoxCEP.Text.Trim().Length <= 0)
            {
                return;
            }
            var endereco = new Endereco
            {
                CEP = maskedTextBoxCEP.Text.Trim(),
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = enderecoDAO.Buscar(endereco);
                // seta os dados na tela
                maskedTextBoxCEP.Text = "";
                textBoxLograd.Text = "";
                textBoxBairro.Text = "";
                textBoxCidade.Text = "";
                comboBoxUF.Text = "";
                textBoxPais.Text = "";
                foreach (DataRow row in linhas.Rows)
                {
                    textBoxEnderecoID.Text = row["id"].ToString(); ;
                    maskedTextBoxCEP.Text = row["cep"].ToString(); ;
                    textBoxLograd.Text = row["logradouro"].ToString(); ;
                    textBoxBairro.Text = row["bairro"].ToString(); ;
                    textBoxCidade.Text = row["cidade"].ToString(); ;
                    comboBoxUF.Text = row["uf"].ToString(); ;
                    textBoxPais.Text = row["pais"].ToString(); ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pizzaria do Zé", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
