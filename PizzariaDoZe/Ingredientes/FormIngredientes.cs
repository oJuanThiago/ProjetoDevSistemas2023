using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PizzariaDoZe.DAO;

namespace PizzariaDoZe
{
    public partial class FormIngredientes : Form
    {
        private readonly IngredienteDAO dao;
        private DataGridView dataGridViewDados;
        public FormIngredientes()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);

            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string stringConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;

            dao = new IngredienteDAO(provider, stringConnection);
            dataGridViewDados = new DataGridView();
            AtualizarTela();
        }

        private void AtualizarTela()
        {
            //Instância e Preenche o objeto com os dados da view
            var ingrediente = new Ingrediente();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = dao.Buscar(ingrediente);
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
            Ingrediente ingrediente = new Ingrediente();

            if (!String.IsNullOrEmpty(textBoxDescricao.Text))
            {
                ingrediente.Nome = textBoxDescricao.Text;
            }
            else
            {
                
            }

            dao.InserirDbProvider(ingrediente);
            AtualizarTela();
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
