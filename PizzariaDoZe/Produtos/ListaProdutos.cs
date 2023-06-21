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
    public partial class ListaProdutos : Form
    {
        private readonly ProdutoDAO produtoDAO;
        public ListaProdutos()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            panelEditar.Visible = false;

            dataGridViewDados.CellFormatting += DataGridViewDados_CellFormatting;
            produtoDAO = new ProdutoDAO(provider, strConnection);
            AtualizarTela();
        }

        // Ações
        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            FormProdutos formProdutos = new FormProdutos();
            formProdutos.Show();
        }
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            panelEditar.Visible = true;
        }

        private void buttonFechar_Click(object sender, EventArgs e) => Close();

        // Tela Editar
        private void AtualizaTelaEditar(int id)
        {
            var produto = new Produto
            {
                ID = id,
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = produtoDAO.Buscar(produto);
                // seta os dados na tela
                foreach (DataRow row in linhas.Rows)
                {
                    textBoxID.Text = row[0].ToString();
                    textBoxDescricao.Text = row[1].ToString();
                    textBoxValor.Text = row[2].ToString();
                    comboBoxTipo.Text = row[3].ToString();
                    comboBoxML.Text = row[4].ToString();
                }
                textBoxDescricao.Focus();
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
                MessageBox.Show("Selecione um produto válido!");
                return;
            }
            //Instância e Preenche o objeto com os dados da view
            var produto = new Produto
            {
                ID = int.Parse(textBoxID.Text),
                Descricao = textBoxDescricao.Text,
                Valor = decimal.Parse(textBoxValor.Text),
                Tipo = comboBoxTipo.Text,
                ML = comboBoxML.Text,
            };
            try
            {
                // chama o método da model para editar
                produtoDAO.Editar(produto);
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
                MessageBox.Show("Selecione um produto!");
                return;
            }
            //Instância e Preenche o objeto com os dados da view
            var produto = new Produto
            {
                ID = int.Parse(textBoxID.Text),
            };
            try
            {
                // chama o método da model para excluir
                produtoDAO.Excluir(produto);
                MessageBox.Show("Dados excluidos com sucesso! " + textBoxID.Text);
                panelEditar.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonEditarFechar_Click(object sender, EventArgs e) => panelEditar.Visible = false;

        // Lista
        private void AtualizarTela()
        {
            //Instância e Preenche o objeto com os dados da view
            var produto = new Produto();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = produtoDAO.Buscar(produto);
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
            else if (this.dataGridViewDados.Columns[e.ColumnIndex].Name.Equals("Tipo Produto"))
            {
                e.Value = e.Value.ToString();
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
            else if (this.dataGridViewDados.Columns[e.ColumnIndex].Name.Equals("Valor") || this.dataGridViewDados.Columns[e.ColumnIndex].Name.Equals("Valor Borda"))
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
    }
}
