using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PizzariaDoZe
{
    public partial class FormConfig : Form
    {
        public FormConfig()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);

        }
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if ((string)comboBoxIdioma.SelectedItem == "pt-BR" && checkBoxReiniciar.Checked == true)
            {
                if (MessageBox.Show("Você quer mesmo mudar o idioma para Português(Brasil)?", "Português(BR)",
                   MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            else if ((string)comboBoxIdioma.SelectedItem == "en-US" && checkBoxReiniciar.Checked == true)
            {
                if (MessageBox.Show("Do you want to change the language to English?", "English(US)",
                   MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            else if ((string)comboBoxIdioma.SelectedItem == "es" && checkBoxReiniciar.Checked == true)
            {
                if (MessageBox.Show("¿De verdad quieres cambiar el idioma a Español?", "Español(ES)",
                   MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }
    }
}
