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
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
