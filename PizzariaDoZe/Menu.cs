using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaDoZe
{
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {
            FormPrincipal principal = new FormPrincipal();
            principal.Show();
        }

        private void buttonFuncionarios_Click(object sender, EventArgs e)
        {
            FormFuncionarios funcionarios = new FormFuncionarios();
            funcionarios.Show();
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            FormClientes clientes = new FormClientes();
            clientes.Show();
        }

        private void buttonIngredientes_Click(object sender, EventArgs e)
        {
            FormIngredientes ingredientes = new FormIngredientes();
            ingredientes.Show();
        }

        private void buttonSabores_Click(object sender, EventArgs e)
        {
            FormSabores sabores = new FormSabores();
            sabores.Show();
        }

        private void buttonProdutos_Click(object sender, EventArgs e)
        {
            FormProdutos produtos = new FormProdutos();
            produtos.Show();
        }

        private void buttonValores_Click(object sender, EventArgs e)
        {
            FormValores valores = new FormValores();
            valores.Show();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonEnderecos_Click(object sender, EventArgs e)
        {
            Enderecos enderecos = new Enderecos();
            enderecos.Show();
        }
    }
}
