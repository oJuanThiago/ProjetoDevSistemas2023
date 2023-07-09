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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PizzariaDoZe
{
    public partial class ListaPedidos : Form
    {
        private readonly PedidoDAO pedidoDAO;
        private readonly ProdutoDAO produtoDAO;
        private readonly ClienteDAO clienteDAO;
        private readonly EnderecoDAO enderecoDAO;
        private readonly SaborDAO saborDAO;


        private List<Produto> listaProdutos;
        private List<Pizza> listaPizzas;
        private List<Sabor> listaSabores;

        public ListaPedidos()
        {
            InitializeComponent();
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            pedidoDAO = new PedidoDAO(provider, strConnection);
            clienteDAO = new ClienteDAO(provider, strConnection);
            enderecoDAO = new EnderecoDAO(provider, strConnection);
            saborDAO = new SaborDAO(provider, strConnection);
            produtoDAO = new ProdutoDAO(provider, strConnection);

            listaProdutos = new List<Produto>();
            listaPizzas = new List<Pizza>();
            listaSabores = new List<Sabor>();

            panelEditar.Visible = false;
            panelEditarItens.Visible = false;
            dataGridViewDados.CellFormatting += DataGridViewDados_CellFormatting;
            buttonSalvar.Click += ButtonSalvar_Click;
            CarregarSabores();
            CarregarProdutos();

            AtualizarTela();

        }

        private void ButtonSalvar_Click(object? sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(textBoxNome.Text) && !String.IsNullOrEmpty(maskedTextBoxCPF.Text) &&
                    !String.IsNullOrEmpty(comboBoxSabor1.Text) && !String.IsNullOrEmpty(comboBoxTamanho.Text))
                {
                    var pedido = new Pedido
                    {
                        ID = int.Parse(textBoxIDPedido.Text),
                        Status = "Cadastrado",
                        Entrega = checkBoxEntregar.Checked,
                        Pago = false,
                        ListaPizzas = listaPizzas,
                        ListaProdutos = listaProdutos
                    };
                    pedido.AtribuirValorTotal(AtualizarValorTotal());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            listaProdutos.Clear();
            listaPizzas.Clear();
        }
        private void AtualizarTela()
        {
            //Instância e Preenche o objeto com os dados da view
            var pedido = new Pedido();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                (DataTable linhas, Pedido pedidoBuscado) = pedidoDAO.Buscar(pedido);
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
        private void CarregarSabores()
        {
            DataTable linhas = saborDAO.BuscarDescricaoTodos();
            comboBoxSabor1.Items.Clear();
            comboBoxSabor2.Items.Clear();
            comboBoxSabor3.Items.Clear();
            foreach (DataRow row in linhas.Rows)
            {
                comboBoxSabor1.Items.Add(row["Descricao"].ToString()!);
                comboBoxSabor2.Items.Add(row["Descricao"].ToString()!);
                comboBoxSabor3.Items.Add(row["Descricao"].ToString()!);
            }
        }
        private void CarregarProdutos()
        {
            (DataTable linhas, List<Produto> produtosBuscados) = produtoDAO.BuscarTodos();
            comboBoxProduto.Items.Clear();
            foreach (Produto produto in produtosBuscados)
            {
                comboBoxProduto.Items.Add(produto.Descricao);
            }
        }
        private string VerificarCategoria()
        {
            foreach (var sabor in listaSabores)
            {
                if (sabor.Categoria == "Especial")
                {
                    return "Especial";
                }
            }
            return "Tradicional";
        }
        private decimal AtualizarValorTotal()
        {
            decimal ValorTotal = 0;

            foreach (var produto in listaProdutos)
            {
                ValorTotal += produto.Valor;
            }
            foreach (var pizza in listaPizzas)
            {
                ValorTotal += pizza.ValorTotal;

                if (pizza.ComBorda && ValorTotal < 100)
                {
                    ValorTotal += pizza.ValorBorda;
                }
            }
            maskedTextBoxValorPedido.Text = ValorTotal.ToString();
            return ValorTotal;
        }


        private void buttonEditar_Click(object sender, EventArgs e)
        {

        }

        private void buttonFechar_Click(object sender, EventArgs e) => Close();

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

        private void DataGridViewDados_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridViewDados.SelectedCells.Count > 0)
            {
                //pega a primeira coluna, que esta com o ID, da linha selecionada
                DataGridViewRow selectedRow = dataGridViewDados.Rows[dataGridViewDados.SelectedCells[0].RowIndex];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                AtualizaTelaEditar(id);
            }
        }

        public void AtualizaTelaEditar(int id)
        {
            var pedido = new Pedido
            {
                ID = id,
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                (DataTable linhas, Pedido pedidoBuscado) = pedidoDAO.Buscar(pedido);
                // seta os dados na tela
                foreach (DataRow row in linhas.Rows)
                {
                    textBoxIDPedido.Text = row[0].ToString();
                    maskedTextBoxValorPedido.Text = row[3].ToString();
                    checkBoxEntregar.Checked = bool.Parse(row[4].ToString()!);
                    maskedTextBoxCEP.Text = row[7].ToString();
                    textBoxLogradouro.Text = row[8].ToString();
                    textBoxBairro.Text = row[9].ToString();
                    textBoxCidade.Text = row[10].ToString();
                    comboBoxUF.Text = row[11].ToString();
                    textBoxPais.Text = row[12].ToString();
                    textBoxIDCliente.Text = row[13].ToString();
                    textBoxNome.Text = row[14].ToString();
                    maskedTextBoxCPF.Text = row[15].ToString();
                    maskedTextBoxTel.Text = row[16].ToString();
                    textBoxNumero.Text = row[17].ToString();
                    textBoxComplemento.Text = row[18].ToString();
                    textBoxEnderecoID.Text = row[19].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (textBoxIDPedido.Text.Length <= 0)
            {
                MessageBox.Show("Selecione um pedido!");
                return;
            }
            //Instância e Preenche o objeto com os dados da view
            var pedido = new Pedido
            {
                ID = int.Parse(textBoxIDPedido.Text),
            };
            try
            {
                // chama o método para inserir da camada model
                pedidoDAO.Excluir(pedido);
                MessageBox.Show("Dados excluidos com sucesso!");
                panelEditar.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonEditarFechar_Click(object sender, EventArgs e) => panelEditar.Visible = false;

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            FormPedidos formPedidos = new FormPedidos();
            formPedidos.Show();
        }

        private void buttonAddProduto_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddPizza_Click(object sender, EventArgs e)
        {
            var pizza = new Pizza
            {
                Tamanho = comboBoxTamanho.Text,
                Categoria = VerificarCategoria(),
                ListaSabores = listaSabores,
                ComBorda = checkBoxBorda.Checked,
                SaborBorda = comboBoxSaborBorda.Text
            };
            if (!String.IsNullOrEmpty(comboBoxTamanho.Text) && !String.IsNullOrEmpty(comboBoxSabor1.Text))
            {
                try
                {
                    this.listaPizzas.Add(pizza);
                    MessageBox.Show("Pizza adicionada com sucesso!");
                    comboBoxTamanho.Text = string.Empty;
                    comboBoxSabor1.Text = string.Empty;
                    comboBoxSabor2.Text = string.Empty;
                    comboBoxSabor3.Text = string.Empty;
                    checkedListBoxIngredientes.Items.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                listaSabores.Clear();
                comboBoxSabor2.Enabled = false;
                comboBoxSabor3.Enabled = false;
                comboBoxTamanho.Text = string.Empty;
                AtualizarValorTotal();
            }
        }
        private void AdicionarSabor(Sabor saborBuscado)
        {
            try
            {
                (DataTable linhas, Sabor sabor) = saborDAO.Buscar(saborBuscado);

                DataTable linhasItens = saborDAO.BuscarItensSabor(sabor);

                checkedListBoxIngredientes.Items.Clear();
                foreach (DataRow row in linhasItens.Rows)
                {
                    checkedListBoxIngredientes.Items.Add(new Ingrediente(int.Parse(row["ID"].ToString()!), row["Nome"].ToString()!));
                    for (int i = 0; i < checkedListBoxIngredientes.Items.Count; i++)
                    {
                        if (row[1].ToString() == ((Ingrediente)checkedListBoxIngredientes.Items[i]).Descricao.ToString())
                        {
                            checkedListBoxIngredientes.SetItemChecked(i, true);
                        }
                    }
                }
                sabor.SaborIngredientes = checkedListBoxIngredientes.CheckedItems.OfType<Ingrediente>().ToList();

                this.listaSabores.Add(sabor);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void ComboBoxTamanho_Leave(object? sender, EventArgs e)
        {
            if (comboBoxTamanho.Text == "Pequena")
            {
                comboBoxSabor2.Enabled = false;
                comboBoxSabor3.Enabled = false;
            }
            else if (comboBoxTamanho.Text == "Média")
            {
                comboBoxSabor2.Enabled = true;
                comboBoxSabor3.Enabled = false;
            }
        }

        private void comboBoxSabor1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sabor = new Sabor
            {
                Descricao = comboBoxSabor1.Text
            };
            AdicionarSabor(sabor);
        }
        private void checkBoxUnicoSabor_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUnicoSabor.Checked == false && comboBoxTamanho.Text != "Pequena" && comboBoxTamanho.Text != "Média")
            {
                comboBoxSabor2.Enabled = true;
                comboBoxSabor3.Enabled = true;
            }
            else if (checkBoxUnicoSabor.Checked == false && comboBoxTamanho.Text == "Média")
            {
                comboBoxSabor2.Enabled = true;
            }
        }
        private void comboBoxSabor2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sabor = new Sabor
            {
                Descricao = comboBoxSabor2.Text
            };
            AdicionarSabor(sabor);
        }
        private void comboBoxSabor3_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sabor = new Sabor
            {
                Descricao = comboBoxSabor3.Text
            };
            AdicionarSabor(sabor);
        }

        private void comboBoxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            var produto = new Produto
            {
                Descricao = comboBoxProduto.Text
            };
            if (!String.IsNullOrEmpty(comboBoxProduto.Text))
            {
                try
                {
                    (DataTable linhas, Produto produtoBuscado) = produtoDAO.Buscar(produto);
                    textBoxIDProduto.Text = produtoBuscado.ID.ToString();
                    comboBoxML.Text = produtoBuscado.ML;
                    textBoxValorProduto.Text = produtoBuscado.Valor.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonEditarProdutos_Click(object sender, EventArgs e)
        {

        }

        private void buttoneditarPizzas_Click(object sender, EventArgs e)
        {

        }

        private void buttonEditarItensFechar_Click(object sender, EventArgs e) => panelEditarItens.Visible = false;
    }
}
