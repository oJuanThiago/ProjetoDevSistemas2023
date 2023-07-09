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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PizzariaDoZe
{
    public partial class ListaValores : Form
    {
        private readonly PizzaDAO pizzaDAO;
        public ListaValores()
        {
            InitializeComponent();
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            pizzaDAO = new PizzaDAO(provider, strConnection);
            panelEditar.Visible = false;

            dataGridViewDados.CellFormatting += DataGridViewDados_CellFormatting;
            AtualizarTela();
        }
        private void AtualizarTela()
        {
            //Instância e Preenche o objeto com os dados da view
            var pizza = new Pizza();

            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                (DataTable linhas, Pizza pizzaBuscada) = pizzaDAO.Buscar(pizza);
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
            FormValores formValores = new FormValores();
            formValores.Show();
        }
        private void buttonEditar_Click(object sender, EventArgs e) => panelEditar.Visible = true;

        private void buttonFechar_Click(object sender, EventArgs e) => Close();

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
            var pizza = new Pizza
            {
                ID = id,
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                (DataTable linhas, Pizza pizzaBuscada) = pizzaDAO.Buscar(pizza);
                // seta os dados na tela
                foreach (DataRow row in linhas.Rows)
                {
                    textBoxID.Text = row[0].ToString();
                    comboBoxTamanho.Text = row[1].ToString();
                    comboBoxCategoria.Text = row[2].ToString();
                    checkBoxComBorda.Checked = bool.Parse(row[3].ToString()!);
                    textBoxValorBorda.Text = row[4].ToString();
                    textBoxValor.Text = row[5].ToString();
                }
                comboBoxTamanho.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text.Length <= 0)
            {
                MessageBox.Show("Selecione um valor válido!");
                return;
            }
            //Instância e Preenche o objeto com os dados da view
            var pizza = new Pizza
            {
                ID = int.Parse(textBoxID.Text),
                Tamanho = comboBoxTamanho.Text,
                Categoria = comboBoxCategoria.Text,
                ComBorda = checkBoxComBorda.Checked ? true : false,
                ValorBorda = decimal.Parse(textBoxValorBorda.Text),
                ValorTotal = decimal.Parse(textBoxValor.Text),

            };
            try
            {
                // chama o método da model para editar
                pizzaDAO.Editar(pizza);
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
                MessageBox.Show("Selecione um valor!");
                return;
            }
            //Instância e Preenche o objeto com os dados da view
            var pizza = new Pizza
            {
                ID = int.Parse(textBoxID.Text),
            };
            try
            {
                // chama o método da model para excluir
                pizzaDAO.Excluir(pizza);
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
