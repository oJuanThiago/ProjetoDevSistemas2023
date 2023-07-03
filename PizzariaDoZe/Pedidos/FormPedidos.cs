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
    public partial class FormPedidos : Form
    {
        private readonly PedidoDAO pedidoDAO;
        private readonly ProdutoDAO produtoDAO;
        private readonly ClienteDAO clienteDAO;
        private readonly EnderecoDAO enderecoDAO;
        private readonly SaborDAO saborDAO;


        private List<Produto> listaProdutos;
        private List<Pizza> listaPizzas;
        private List<Sabor> listaSabores;



        public FormPedidos()
        {
            InitializeComponent();
            panelCadastrarCliente.Visible = false;

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

            textBoxNome.Leave += TextBoxNome_Leave;
            maskedTextBoxCPF.Leave += MaskedTextBoxCPF_Leave;
            maskedTextBoxTel.Leave += MaskedTextBoxTel_Leave;
            comboBoxTamanho.Leave += ComboBoxTamanho_Leave;

            CarregarSabores();
            CarregarProdutos();

        }

        private void MaskedTextBoxTel_Leave(object? sender, EventArgs e)
        {
            var cliente = new Cliente
            {
                Telefone = maskedTextBoxTel.Text.Trim()
            };
            BuscarCliente(cliente);
        }

        private void TextBoxNome_Leave(object? sender, EventArgs e)
        {
            var cliente = new Cliente
            {
                Nome = textBoxNome.Text
            };
            BuscarCliente(cliente);
        }

        private void MaskedTextBoxCPF_Leave(object? sender, EventArgs e)
        {
            var cliente = new Cliente
            {
                CPF = maskedTextBoxCPF.Text.Trim()
            };
            BuscarCliente(cliente);
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
        private void buttonCadastrar_Click(object sender, EventArgs e)
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

                    pedidoDAO.Inserir(pedido);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            listaProdutos.Clear();
            listaPizzas.Clear();
        }

        private void buttonFechar_Click(object sender, EventArgs e) => Close();

        private void buttonAddProduto_Click(object sender, EventArgs e)
        {
            var produto = new Produto
            {
                ID = int.Parse(textBoxIDProduto.Text),
                Descricao = comboBoxProduto.Text,
                ML = comboBoxML.Text,
                Valor = decimal.Parse(textBoxValorProduto.Text)
            };
            if (!String.IsNullOrEmpty(comboBoxProduto.Text))
            {
                try
                {
                    (DataTable linhas, Produto produtoBuscado) = produtoDAO.Buscar(produto);
                    this.listaProdutos.Add(produtoBuscado);
                    MessageBox.Show("Produto adicionado com sucesso!");
                    textBoxIDProduto.Text = string.Empty;
                    comboBoxProduto.Text = string.Empty;
                    comboBoxML.Text = string.Empty;
                    textBoxValorProduto.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                AtualizarValorTotal();
            }
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
        private void MaskedTextBoxCEP_Leave(object? sender, EventArgs e)
        {
            if (maskedTextBoxCEP.Text.Trim().Length <= 0)
            {
                return;
            }
            var endereco = new Endereco
            {
                ID = int.Parse(textBoxEnderecoID.Text),
                CEP = maskedTextBoxCEP.Text.Trim(),
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = enderecoDAO.Buscar(endereco);
                // seta os dados na tela
                maskedTextBoxCEP.Text = "";
                textBoxLogradouro.Text = "";
                textBoxBairro.Text = "";
                textBoxCidade.Text = "";
                comboBoxUF.Text = "";
                textBoxPais.Text = "";
                foreach (DataRow row in linhas.Rows)
                {
                    maskedTextBoxCEP.Text = row["cep"].ToString();
                    textBoxLogradouro.Text = row["logradouro"].ToString();
                    textBoxBairro.Text = row["bairro"].ToString();
                    textBoxCidade.Text = row["cidade"].ToString();
                    comboBoxUF.Text = row["uf"].ToString();
                    textBoxPais.Text = row["pais"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pizzaria do Zé", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MaskedTextBoxClienteCEP_Leave(object? sender, EventArgs e)
        {
            if (maskedTextBoxClienteCEP.Text.Trim().Length <= 0)
            {
                return;
            }
            var endereco = new Endereco
            {
                ID = int.Parse(textBoxEnderecoID.Text),
                CEP = maskedTextBoxClienteCEP.Text.Trim(),
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = enderecoDAO.Buscar(endereco);
                // seta os dados na tela
                maskedTextBoxCEP.Text = "";
                textBoxLogradouro.Text = "";
                textBoxBairro.Text = "";
                textBoxCidade.Text = "";
                comboBoxUF.Text = "";
                textBoxPais.Text = "";
                foreach (DataRow row in linhas.Rows)
                {
                    maskedTextBoxCEP.Text = row["cep"].ToString();
                    textBoxLogradouro.Text = row["logradouro"].ToString();
                    textBoxBairro.Text = row["bairro"].ToString();
                    textBoxCidade.Text = row["cidade"].ToString();
                    comboBoxUF.Text = row["uf"].ToString();
                    textBoxPais.Text = row["pais"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pizzaria do Zé", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        private void BuscarCliente(Cliente cliente)
        {
            try
            {
                (DataTable linhas, Cliente clienteBuscado) = clienteDAO.Buscar(cliente);
                if (!String.IsNullOrEmpty(clienteBuscado.Nome) &&
                    !String.IsNullOrEmpty(clienteBuscado.CPF) &&
                    !String.IsNullOrEmpty(clienteBuscado.Telefone) &&
                    !String.IsNullOrEmpty(clienteBuscado.EnderecoID.ToString()))
                {
                    textBoxIDCliente.Text = clienteBuscado.ID.ToString();
                    textBoxNome.Text = clienteBuscado.Nome;
                    maskedTextBoxCPF.Text = clienteBuscado.CPF;
                    maskedTextBoxTel.Text = clienteBuscado.Telefone;
                    textBoxEnderecoID.Text = clienteBuscado.EnderecoID.ToString();
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pizzaria do Zé", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text.Length <= 0 || textBoxEnderecoID.Text.Length <= 0)
            {
                MessageBox.Show("Selecione um cliente e endereço valido!");
                return;
            }
            //Instância e Preenche o objeto com os dados da view
            var cliente = new Cliente
            {
                Nome = textBoxNome.Text,
                CPF = maskedTextBoxCPF.Text,
                Telefone = maskedTextBoxTel.Text,
                EnderecoID = int.Parse(textBoxEnderecoID.Text),
                Numero = textBoxNumero.Text,
                Complemento = textBoxComplemento.Text,
            };
            try
            {
                // chama o método da model para editar
                clienteDAO.Editar(cliente);
                MessageBox.Show("Dados cadastrados com sucesso! " + textBoxID.Text);
                panelCadastrarCliente.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void buttonClienteFechar_Click(object sender, EventArgs e) => panelCadastrarCliente.Visible = false;
    }
}
