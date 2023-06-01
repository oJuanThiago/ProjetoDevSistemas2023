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

namespace PizzariaDoZe.Ingredientes
{
    public partial class Ingredientes : Form
    {
        private readonly IngredienteDAO ingredienteDAO;
        public Ingredientes()
        {
            InitializeComponent();
            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;

            // cria a instancia da classe da model
            ingredienteDAO = new(provider, strConnection);
            dataGridViewDados.CellFormatting += DataGridViewDados_CellFormatting;
            AtualizarTela();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            FormIngredientes ingredientes = new FormIngredientes();
            ingredientes.Show();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {

        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void AtualizarTela()
        {

            //Instância e Preenche o objeto com os dados da view
            var ingrediente = new Ingrediente();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = ingredienteDAO.Buscar(ingrediente);
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


    }
}
