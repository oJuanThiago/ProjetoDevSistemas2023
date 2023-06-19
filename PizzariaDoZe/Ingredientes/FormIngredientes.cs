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
        public FormIngredientes()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);

            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string stringConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;

            dao = new IngredienteDAO(provider, stringConnection);
        }



        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            Ingrediente ingrediente = new Ingrediente();

            if (!String.IsNullOrEmpty(textBoxDescricao.Text))
            {
                ingrediente.Descricao = textBoxDescricao.Text;
                try
                {
                    // chama o método para inserir da camada model
                    dao.InserirDbProvider(ingrediente);
                    MessageBox.Show("Dados inseridos com sucesso!");
                    textBoxDescricao.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void buttonFechar_Click(object sender, EventArgs e) => Close();
    }
}
