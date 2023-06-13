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
    public partial class FormProdutos : Form
    {
        private readonly ProdutoDAO produtoDAO;
        public FormProdutos()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            produtoDAO = new ProdutoDAO(provider, strConnection);
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var produto = new Produto
            {
                ID = 0,
                Descricao = textBoxDescricao.Text,
                Valor = decimal.Parse(textBoxValor.Text),
                Tipo = comboBoxTipo.Text,
                ML = comboBoxML.Text,
            };
            try
            {
                // chama o método para inserir da camada model
                produtoDAO.Inserir(produto);
                MessageBox.Show("Dados inseridos com sucesso!");
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
    }
}
