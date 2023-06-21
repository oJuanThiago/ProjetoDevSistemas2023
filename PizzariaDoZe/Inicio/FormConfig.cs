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
    public partial class FormConfig : Form
    {
        public FormConfig()
        {
            InitializeComponent();
            //seleciona no combo a cultura atual
            comboBoxIdioma.SelectedItem = ConfigurationManager.AppSettings.Get("Cultura");
            // busca os dados com nome BD
            ConnectionStringSettings connectionStringSettings =
            ConfigurationManager.ConnectionStrings["BD"];
            // obtém o providerName e atualiza em tela
            comboBoxProvider.Text = connectionStringSettings.ProviderName;
            // obtém a connectionString e atualiza em tela
            textBoxStringConexao.Text = connectionStringSettings.ConnectionString;
            Funcoes.AjustaResourcesControl(this);

        }
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            //abre o arquivo local como leitura/escrita - ControleEstoqueDoZe.exe.config
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //altera os valores de provider e da connectionStrings com nome BD
            config.ConnectionStrings.ConnectionStrings["BD"].ProviderName = comboBoxProvider.Text;
            config.ConnectionStrings.ConnectionStrings["BD"].ConnectionString = textBoxStringConexao.Text;
            //salva as alterações
            config.Save(ConfigurationSaveMode.Modified, true);
            //recarrega os dados da seção especificada
            ConfigurationManager.RefreshSection("connectionStrings");
            //fecha a tela
            Close();
            //dispara msg para usuário
            _ = MessageBox.Show("Dados alterados com sucesso!");
            if ((string)comboBoxIdioma.SelectedItem == "pt-br" && checkBoxReiniciar.Checked == true)
            {
                if (MessageBox.Show("Você quer mesmo mudar o idioma para Português(Brasil)?", "Português(BR)",
                   MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            else if ((string)comboBoxIdioma.SelectedItem == "en-us" && checkBoxReiniciar.Checked == true)
            {
                if (MessageBox.Show("Do you want to change the language to english?", "English(US)",
                   MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            else if ((string)comboBoxIdioma.SelectedItem == "es" && checkBoxReiniciar.Checked == true)
            {
                if (MessageBox.Show("¿De verdad quieres cambiar el idioma a español?", "Español(ES)",
                   MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }
    }
}
