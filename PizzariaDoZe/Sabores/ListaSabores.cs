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

namespace PizzariaDoZe.Sabores
{
    public partial class ListaSabores : Form
    {
        private readonly SaborDAO saborDAO;
        public ListaSabores()
        {
            InitializeComponent();
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            saborDAO = new SaborDAO(provider, strConnection);

            panelEditar.Visible = false;
            dataGridViewDados.CellFormatting += DataGridViewDados_CellFormatting;
            AtualizarTela();
        }
        private void AtualizarTela()
        {
            //Instância e Preenche o objeto com os dados da view
            var sabor = new Sabor();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = saborDAO.Buscar(sabor);
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
            FormSabores formSabores = new FormSabores();
            formSabores.Show();
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

        public void AtualizaTelaEditar(int id)
        {
            //Instância e Preenche o objeto com os dados da view
            var sabor = new Sabor
            {
                ID = id,
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = saborDAO.Buscar(sabor);
                // seta os dados na tela
                foreach (DataRow row in linhas.Rows)
                {
                    textBoxID.Text = row[0].ToString();
                    textBoxDescricao.Text = row[1].ToString();
                    pictureBoxImagem.Image = Funcoes.ConverteByteArrayParaImagem((byte[])row[2]);
                    comboBoxCategoria.Text = row[3].ToString();
                    comboBoxTipo.Text = row[4].ToString();
                    // busca e seleciona os itens do sabor
                    DataTable linhasIngredientes = saborDAO.BuscarItensSabor(sabor);
                    foreach (DataRow dr in linhasIngredientes.Rows)
                    {
                        for (int i = 0; i < checkedListBoxIngredientes.Items.Count; i++)
                        {
                            if (dr[1].ToString() == ((Ingrediente)checkedListBoxIngredientes.Items[i]).Descricao.ToString())
                            {
                                checkedListBoxIngredientes.SetItemChecked(i, true);
                            }
                        }
                    }
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
                MessageBox.Show("Selecione um sabor!");
                return;
            }
            //Instância e Preenche o objeto com os dados da view
            var sabor = new Sabor
            {
                ID = int.Parse(textBoxID.Text),
                Descricao = textBoxDescricao.Text,
                Foto = Funcoes.ConverteImagemParaByteArray(pictureBoxImagem.Image),
                Categoria = comboBoxCategoria.Text,
                Tipo = comboBoxTipo.Text,
                SaborIngredientes = checkedListBoxIngredientes.CheckedItems.OfType<Ingrediente>().ToList(),
            };
            try
            {
                // chama o método para inserir da camada model
                saborDAO.Editar(sabor);
                MessageBox.Show("Dados editados com sucesso!");
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
                MessageBox.Show("Selecione um sabor!");
                return;
            }
            //Instância e Preenche o objeto com os dados da view
            var sabor = new Sabor
            {
                ID = int.Parse(textBoxID.Text),
            };
            try
            {
                // chama o método para inserir da camada model
                saborDAO.Excluir(sabor);
                MessageBox.Show("Dados excluidos com sucesso!");
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

