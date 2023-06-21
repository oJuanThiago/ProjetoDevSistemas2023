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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PizzariaDoZe
{
    public partial class ListaFuncionarios : Form
    {
        private readonly FuncionarioDAO funcionarioDAO;
        public ListaFuncionarios()
        {
            InitializeComponent();
            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            funcionarioDAO = new FuncionarioDAO(provider, strConnection);

            panelEditar.Visible = false;
            dataGridViewDados.CellFormatting += DataGridViewDados_CellFormatting;
            AtualizarTela();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            FormFuncionarios funcionarios = new FormFuncionarios();
            funcionarios.Show();
        }
        private void buttonEditar_Click(object sender, EventArgs e) => panelEditar.Visible = true;

        private void buttonFechar_Click(object sender, EventArgs e) => Close();

        private void AtualizarTela()
        {

            //Instância e Preenche o objeto com os dados da view
            var funcionario = new Funcionario();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = funcionarioDAO.Buscar(funcionario);
                // seta o datasouce do dataGridView com os dados retornados
                dataGridViewDados.Columns.Clear();
                dataGridViewDados.AutoGenerateColumns = true;
                dataGridViewDados.DataSource = linhas;
                dataGridViewDados.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DataGridViewDados_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == this.dataGridViewDados.NewRowIndex || e.Value!.ToString()!.Trim().Length == 0)
            {
                return;
            }
            else if (this.dataGridViewDados.Columns[e.ColumnIndex].Name.Equals("CPF"))
            {
                long value = long.Parse(e.Value!.ToString()!.Replace(" ", ""));
                e.Value = string.Format(@"{0:000\.000\.000\-00}", value);
            }
            else if (this.dataGridViewDados.Columns[e.ColumnIndex].Name.Equals("CEP"))
            {
                long value = long.Parse(e.Value!.ToString()!.Replace(" ", ""));
                e.Value = string.Format(@"{0:00\.000\-000}", value);
            }
            else if (this.dataGridViewDados.Columns[e.ColumnIndex].Name.Equals("Telefone"))
            {
                long value = long.Parse(e.Value!.ToString()!.Replace(" ", ""));
                e.Value = string.Format(@"{0:(00) 00000\-0000}", value);
            }
            else if (this.dataGridViewDados.Columns[e.ColumnIndex].Name.Equals("Valor"))
            {
                // formata valor numérico com duas casa decimais
                double d = double.Parse(e.Value!.ToString()!);
                e.Value = d.ToString("N2");
            }
        }

        private void DataGridViewDados_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridViewDados.SelectedCells.Count > 0)
            {
                //pega a primeira coluna, que esta com o ID, da linha selecionada
                DataGridViewRow selectedRow = dataGridViewDados.Rows[dataGridViewDados.SelectedCells[0].RowIndex];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                AtualizaTelaEditar(id);
                panelEditar.Visible = true;
            }
        }

        public void AtualizaTelaEditar(int id)
        {
            //Instância e Preenche o objeto com os dados da view
            var funcionario = new Funcionario
            {
                ID = id,
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = funcionarioDAO.Buscar(funcionario);
                // seta os dados na tela
                foreach (DataRow row in linhas.Rows)
                {
                    textBoxID.Text = row[0].ToString();
                    textBoxNome.Text = row[1].ToString();
                    maskedTextBoxCPF.Text = row[2].ToString();
                    textBoxMatricula.Text = row[3].ToString();
                    textBoxSenha.Text = row[4].ToString();
                    comboBoxFuncao.Text = row[5].ToString();
                    maskedTextBoxCNH.Text = row[6].ToString();
                    dateTimePickerValidade.Text = row[7].ToString();
                    textBoxObs.Text = row[8].ToString();
                    maskedTextBoxTel.Text = row[9].ToString();
                    textBoxEmail.Text = row[10].ToString();
                    maskedTextBoxCEP.Text = row[11].ToString();
                    textBoxLogradouro.Text = row[12].ToString();/*12*/
                    textBoxBairro.Text = row[13].ToString();/*13*/
                    textBoxCidade.Text = row[14].ToString();/*14*/
                    comboBoxUF.Text = row[15].ToString();/*15*/
                    textBoxNumero.Text = row[16].ToString();/*16*/
                    textBoxComplemento.Text = row[17].ToString();/*17*/
                    textBoxEnderecoID.Text = row[18].ToString();
                    textBoxPais.Text = row[19].ToString();
                }
                textBoxNome.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text.Length <= 0 || textBoxEnderecoID.Text.Length <= 0)
            {
                MessageBox.Show("Selecione um funcionário e endereço valido!");
                return;
            }
            //Instância e Preenche o objeto com os dados da view
            var funcionario = new Funcionario
            {
                ID = int.Parse(textBoxID.Text),
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
                // chama o método da model para editar
                funcionarioDAO.Editar(funcionario);
                MessageBox.Show("Dados editados com sucesso! " + textBoxID.Text);
                panelEditar.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
        
           if (textBoxID.Text.Length <= 0)
           {
               MessageBox.Show("Selecione um funcionário!");
               return;
           }
           //Instância e Preenche o objeto com os dados da view
           var funcionario = new Funcionario
           {
               ID = int.Parse(textBoxID.Text),
           };
           try
           {
               // chama o método da model para excluir
               funcionarioDAO.Excluir(funcionario);
               MessageBox.Show("Dados excluidos com sucesso! " + textBoxID.Text);
               panelEditar.Visible = false;
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
           }
        
        }

        private void buttonEditarFechar_Click(object sender, EventArgs e) => panelEditar.Visible = false;
    }
}
