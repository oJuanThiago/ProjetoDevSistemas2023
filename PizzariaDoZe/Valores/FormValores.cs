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
    public partial class FormValores : Form
    {
        private ValorDAO valorDAO;
        public FormValores()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            valorDAO = new ValorDAO(provider, strConnection);


        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var valor = new Valor
            {
                ID = 0,
                Tamanho = comboBoxTamanho.Text,
                Categoria = comboBoxCategoria.Text,
                ValorPizza = decimal.Parse(maskedTextBoxValor.Text),
                ValorBorda = decimal.Parse(textBoxValorBorda.Text),
            };
            try
            {
                // chama o método para inserir da camada model
                valorDAO.Inserir(valor);
                MessageBox.Show("Dados inseridos com sucesso!");
                comboBoxTamanho.Text = string.Empty;
                comboBoxCategoria.Text = string.Empty;
                maskedTextBoxValor.Text = string.Empty;
                textBoxValorBorda.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonFechar_Click(object sender, EventArgs e) => Close();
    }
}
