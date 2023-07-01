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

namespace PizzariaDoZe
{
    public partial class ListaClientes : Form
    {
        private readonly ClienteDAO clienteDAO;
        private readonly EnderecoDAO enderecoDAO;

        public ListaClientes()
        {
            InitializeComponent();
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            clienteDAO = new ClienteDAO(provider, strConnection);
            enderecoDAO = new EnderecoDAO(provider, strConnection);
            maskedTextBoxCEP.Leave += MaskedTextBoxCep_Leave;

            panelEditar.Visible = false;
            dataGridViewDados.CellFormatting += DataGridViewDados_CellFormatting;
            AtualizarTela();
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
                textBoxLogradouro.Text = "";
                textBoxBairro.Text = "";
                textBoxCidade.Text = "";
                comboBoxUF.Text = "";
                textBoxPais.Text = "";
                foreach (DataRow row in linhas.Rows)
                {
                    textBoxEnderecoID.Text = row["id"].ToString();
                    maskedTextBoxCEP.Text = row["cep"].ToString();
                    textBoxLogradouro.Text = row["logradouro"].ToString();
                    textBoxBairro.Text = row["bairro"].ToString();
                    textBoxCidade.Text = row["cidade"].ToString();
                    comboBoxUF.Text = row["uf"].ToString();
                    textBoxPais.Text = row["pais"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pizzaria do Zé", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizarTela()
        {
            //Instância e Preenche o objeto com os dados da view
            var cliente = new Cliente();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = clienteDAO.Buscar(cliente);
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

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            FormClientes clientes = new FormClientes();
            clientes.Show();
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
            }
        }

        private void AtualizaTelaEditar(int id)
        {
            var cliente = new Cliente
            {
                ID = id,
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = clienteDAO.Buscar(cliente);
                // seta os dados na tela
                foreach (DataRow row in linhas.Rows)
                {
                    textBoxID.Text = row[0].ToString();
                    textBoxNome.Text = row[1].ToString();
                    maskedTextBoxCPF.Text = row[2].ToString();
                    maskedTextBoxTel.Text = row[3].ToString();
                    textBoxEmail.Text = row[4].ToString();
                    maskedTextBoxCEP.Text = row[5].ToString();
                    textBoxLogradouro.Text = row[6].ToString();
                    textBoxBairro.Text = row[7].ToString();
                    textBoxCidade.Text = row[8].ToString();
                    comboBoxUF.Text = row[9].ToString();
                    textBoxNumero.Text = row[10].ToString();
                    textBoxComplemento.Text = row[11].ToString();
                    textBoxEnderecoID.Text = row[12].ToString();
                    textBoxPais.Text = row[13].ToString();
                }
                textBoxNome.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e) => panelEditar.Visible = true;

        private void buttonFechar_Click(object sender, EventArgs e) => Close();

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text.Length <= 0 || textBoxEnderecoID.Text.Length <= 0)
            {
                MessageBox.Show("Selecione um cliente e endereço valido!");
                return;
            }
            //Instância e Preenche o objeto com os dados da view
            var cliente = new Cliente
            {
                ID = int.Parse(textBoxID.Text),
                Nome = textBoxNome.Text,
                CPF = maskedTextBoxCPF.Text,
                Telefone = maskedTextBoxTel.Text,
                Email = textBoxEmail.Text,
                EnderecoID = int.Parse(textBoxEnderecoID.Text),
                Numero = textBoxNumero.Text,
                Complemento = textBoxComplemento.Text,
            };
            try
            {
                // chama o método da model para editar
                clienteDAO.Editar(cliente);
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
                MessageBox.Show("Selecione um cliente!");
                return;
            }
            //Instância e Preenche o objeto com os dados da view
            var cliente = new Cliente
            {
                ID = int.Parse(textBoxID.Text),
            };
            try
            {
                // chama o método da model para excluir
                clienteDAO.Excluir(cliente);
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
