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
    public partial class FormSabores : Form
    {
        private readonly SaborDAO saborDAO;
        private readonly IngredienteDAO ingredienteDAO;

        public FormSabores()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            saborDAO = new SaborDAO(provider, strConnection);
            ingredienteDAO = new IngredienteDAO(provider, strConnection);
            CarregarCheckedListBoxIngredientes();

        }
        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            //Instancia e Preenche o objeto com os dados da view
            var sabor = new Sabor
            {
                ID = 0,
                Descricao = textBoxDescricao.Text,
                Foto = Funcoes.ConverteImagemParaByteArray(pictureBoxImagem.Image),
                Categoria = comboBoxCategoria.Text,
                Tipo = comboBoxTipo.Text,
                SaborIngredientes = checkedListBoxIngredientes.CheckedItems.OfType<Ingrediente>().ToList(),
            };
            try
            {
                // chama o método para inserir da camada model
                saborDAO.Inserir(sabor);
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

        private void CarregarCheckedListBoxIngredientes()
        {
            //Instância e Preenche o objeto com os dados da view
            var ingrediente = new Ingrediente();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = ingredienteDAO.Buscar(ingrediente);
                // carrega os dados, como objeto, no checkedListBox
                checkedListBoxIngredientes.Items.Clear();
                foreach (DataRow row in linhas.Rows)
                {
                    checkedListBoxIngredientes.Items.Add(new Ingrediente(int.Parse(row["ID"].ToString()!), row["Nome"].ToString()!));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
