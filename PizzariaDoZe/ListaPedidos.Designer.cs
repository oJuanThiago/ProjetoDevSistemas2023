namespace PizzariaDoZe
{
    partial class ListaPedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelLista = new Panel();
            panelEditar = new Panel();
            buttonExcluir = new Button();
            buttonSalvar = new Button();
            buttonEditarFechar = new Button();
            buttonEditar = new Button();
            buttonFechar = new Button();
            dataGridViewDados = new DataGridView();
            panel1 = new Panel();
            buttonCadastrar = new Button();
            labelPedido = new Label();
            menu1 = new Menu();
            groupBoxProduto = new GroupBox();
            labelML = new Label();
            comboBoxML = new ComboBox();
            labelProduto = new Label();
            buttonProximoProduto = new Button();
            label1 = new Label();
            comboBoxProduto = new ComboBox();
            groupBoxAddPizza = new GroupBox();
            buttonProximaPizza = new Button();
            groupBoxIngredientes = new GroupBox();
            checkedListBoxIngredientes = new CheckedListBox();
            groupBoxSabor = new GroupBox();
            checkBoxBorda = new CheckBox();
            checkBoxInteira = new CheckBox();
            labelSabor3 = new Label();
            comboBoxSabor3 = new ComboBox();
            labelSabor2 = new Label();
            comboBoxSabor2 = new ComboBox();
            labelSabor1 = new Label();
            comboBoxSabor1 = new ComboBox();
            groupBoxTamanhoPizza = new GroupBox();
            labelTamanho = new Label();
            comboBoxTamanho = new ComboBox();
            groupBoxEndereco = new GroupBox();
            checkBoxEntregar = new CheckBox();
            textBoxPais = new TextBox();
            labelPais = new Label();
            comboBoxUF = new ComboBox();
            labelUF = new Label();
            textBoxComplemento = new TextBox();
            labelComplemento = new Label();
            textBoxCidade = new TextBox();
            labelCidade = new Label();
            textBoxBairro = new TextBox();
            labelBairro = new Label();
            textBoxNumero = new TextBox();
            labelNumero = new Label();
            maskedTextBoxCEP = new MaskedTextBox();
            textBoxLogradouro = new TextBox();
            labelLogradouro = new Label();
            labelCEP = new Label();
            groupBoxCliente = new GroupBox();
            maskedTextBoxTel = new MaskedTextBox();
            labelTel = new Label();
            maskedTextBoxCPF = new MaskedTextBox();
            labelCPF = new Label();
            textBoxID = new TextBox();
            labelID = new Label();
            textBoxNome = new TextBox();
            labelNome = new Label();
            textBoxIDPedido = new TextBox();
            labelIDPedido = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBoxIDSabor1 = new TextBox();
            label3 = new Label();
            textBoxIDSabor2 = new TextBox();
            label4 = new Label();
            textBoxIDSabor3 = new TextBox();
            label5 = new Label();
            labelObsTamanho = new Label();
            panelLista.SuspendLayout();
            panelEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).BeginInit();
            panel1.SuspendLayout();
            groupBoxProduto.SuspendLayout();
            groupBoxAddPizza.SuspendLayout();
            groupBoxIngredientes.SuspendLayout();
            groupBoxSabor.SuspendLayout();
            groupBoxTamanhoPizza.SuspendLayout();
            groupBoxEndereco.SuspendLayout();
            groupBoxCliente.SuspendLayout();
            SuspendLayout();
            // 
            // panelLista
            // 
            panelLista.BackColor = Color.FromArgb(51, 51, 51);
            panelLista.Controls.Add(panelEditar);
            panelLista.Controls.Add(buttonEditar);
            panelLista.Controls.Add(buttonFechar);
            panelLista.Controls.Add(dataGridViewDados);
            panelLista.Location = new Point(198, 90);
            panelLista.Name = "panelLista";
            panelLista.Size = new Size(1069, 600);
            panelLista.TabIndex = 12;
            // 
            // panelEditar
            // 
            panelEditar.BackColor = Color.White;
            panelEditar.Controls.Add(textBoxIDPedido);
            panelEditar.Controls.Add(labelIDPedido);
            panelEditar.Controls.Add(groupBoxProduto);
            panelEditar.Controls.Add(groupBoxAddPizza);
            panelEditar.Controls.Add(groupBoxEndereco);
            panelEditar.Controls.Add(groupBoxCliente);
            panelEditar.Controls.Add(buttonExcluir);
            panelEditar.Controls.Add(buttonSalvar);
            panelEditar.Controls.Add(buttonEditarFechar);
            panelEditar.Location = new Point(32, 3);
            panelEditar.Name = "panelEditar";
            panelEditar.Size = new Size(985, 557);
            panelEditar.TabIndex = 7;
            panelEditar.Visible = false;
            // 
            // buttonExcluir
            // 
            buttonExcluir.BackColor = Color.Firebrick;
            buttonExcluir.FlatAppearance.BorderColor = Color.Gray;
            buttonExcluir.FlatAppearance.BorderSize = 0;
            buttonExcluir.FlatStyle = FlatStyle.Flat;
            buttonExcluir.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExcluir.ForeColor = Color.White;
            buttonExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            buttonExcluir.Location = new Point(794, 497);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(80, 38);
            buttonExcluir.TabIndex = 6;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonExcluir.UseVisualStyleBackColor = false;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // buttonSalvar
            // 
            buttonSalvar.BackColor = Color.Green;
            buttonSalvar.FlatAppearance.BorderColor = Color.Gray;
            buttonSalvar.FlatAppearance.BorderSize = 0;
            buttonSalvar.FlatStyle = FlatStyle.Flat;
            buttonSalvar.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSalvar.ForeColor = Color.White;
            buttonSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSalvar.Location = new Point(707, 497);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(81, 38);
            buttonSalvar.TabIndex = 5;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSalvar.UseVisualStyleBackColor = false;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // buttonEditarFechar
            // 
            buttonEditarFechar.BackColor = Color.Gray;
            buttonEditarFechar.FlatAppearance.BorderColor = Color.Gray;
            buttonEditarFechar.FlatAppearance.BorderSize = 0;
            buttonEditarFechar.FlatStyle = FlatStyle.Flat;
            buttonEditarFechar.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEditarFechar.ForeColor = Color.White;
            buttonEditarFechar.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEditarFechar.Location = new Point(880, 497);
            buttonEditarFechar.Name = "buttonEditarFechar";
            buttonEditarFechar.Size = new Size(80, 38);
            buttonEditarFechar.TabIndex = 7;
            buttonEditarFechar.Text = "Fechar";
            buttonEditarFechar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonEditarFechar.UseVisualStyleBackColor = false;
            buttonEditarFechar.Click += buttonEditarFechar_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.BackColor = Color.DodgerBlue;
            buttonEditar.FlatAppearance.BorderColor = Color.Gray;
            buttonEditar.FlatAppearance.BorderSize = 0;
            buttonEditar.FlatStyle = FlatStyle.Flat;
            buttonEditar.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEditar.ForeColor = Color.White;
            buttonEditar.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEditar.Location = new Point(851, 497);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(80, 38);
            buttonEditar.TabIndex = 4;
            buttonEditar.Text = "Editar";
            buttonEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonEditar.UseVisualStyleBackColor = false;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // buttonFechar
            // 
            buttonFechar.BackColor = Color.Gray;
            buttonFechar.FlatAppearance.BorderColor = Color.Gray;
            buttonFechar.FlatAppearance.BorderSize = 0;
            buttonFechar.FlatStyle = FlatStyle.Flat;
            buttonFechar.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFechar.ForeColor = Color.White;
            buttonFechar.ImageAlign = ContentAlignment.MiddleLeft;
            buttonFechar.Location = new Point(937, 497);
            buttonFechar.Name = "buttonFechar";
            buttonFechar.Size = new Size(80, 38);
            buttonFechar.TabIndex = 5;
            buttonFechar.Text = "Fechar";
            buttonFechar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonFechar.UseVisualStyleBackColor = false;
            buttonFechar.Click += buttonFechar_Click;
            // 
            // dataGridViewDados
            // 
            dataGridViewDados.AllowUserToAddRows = false;
            dataGridViewDados.AllowUserToOrderColumns = true;
            dataGridViewDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDados.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewDados.Location = new Point(32, 0);
            dataGridViewDados.MultiSelect = false;
            dataGridViewDados.Name = "dataGridViewDados";
            dataGridViewDados.RowTemplate.Height = 25;
            dataGridViewDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDados.Size = new Size(985, 473);
            dataGridViewDados.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 51);
            panel1.Controls.Add(buttonCadastrar);
            panel1.Controls.Add(labelPedido);
            panel1.Location = new Point(198, -10);
            panel1.Name = "panel1";
            panel1.Size = new Size(1069, 100);
            panel1.TabIndex = 11;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.BackColor = Color.FromArgb(51, 51, 51);
            buttonCadastrar.FlatAppearance.BorderColor = Color.Gray;
            buttonCadastrar.FlatAppearance.BorderSize = 2;
            buttonCadastrar.FlatStyle = FlatStyle.Flat;
            buttonCadastrar.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCadastrar.ForeColor = Color.White;
            buttonCadastrar.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCadastrar.Location = new Point(827, 32);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(190, 38);
            buttonCadastrar.TabIndex = 79;
            buttonCadastrar.Text = "Cadastrar Pedido";
            buttonCadastrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCadastrar.UseVisualStyleBackColor = false;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // labelPedido
            // 
            labelPedido.AutoSize = true;
            labelPedido.Font = new Font("Yu Gothic UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelPedido.ForeColor = SystemColors.ControlLightLight;
            labelPedido.Location = new Point(32, 28);
            labelPedido.Name = "labelPedido";
            labelPedido.Size = new Size(134, 45);
            labelPedido.TabIndex = 1;
            labelPedido.Text = "Pedidos";
            // 
            // menu1
            // 
            menu1.Location = new Point(-2, -10);
            menu1.Name = "menu1";
            menu1.Size = new Size(200, 687);
            menu1.TabIndex = 10;
            // 
            // groupBoxProduto
            // 
            groupBoxProduto.Controls.Add(textBox1);
            groupBoxProduto.Controls.Add(label2);
            groupBoxProduto.Controls.Add(labelML);
            groupBoxProduto.Controls.Add(comboBoxML);
            groupBoxProduto.Controls.Add(labelProduto);
            groupBoxProduto.Controls.Add(buttonProximoProduto);
            groupBoxProduto.Controls.Add(label1);
            groupBoxProduto.Controls.Add(comboBoxProduto);
            groupBoxProduto.Location = new Point(0, 412);
            groupBoxProduto.Name = "groupBoxProduto";
            groupBoxProduto.Size = new Size(315, 130);
            groupBoxProduto.TabIndex = 10;
            groupBoxProduto.TabStop = false;
            groupBoxProduto.Text = "Produto";
            // 
            // labelML
            // 
            labelML.AutoSize = true;
            labelML.BackColor = Color.Transparent;
            labelML.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelML.ForeColor = SystemColors.ActiveCaptionText;
            labelML.Location = new Point(20, 66);
            labelML.Name = "labelML";
            labelML.Size = new Size(33, 15);
            labelML.TabIndex = 85;
            labelML.Text = "ml/g";
            // 
            // comboBoxML
            // 
            comboBoxML.FormattingEnabled = true;
            comboBoxML.Items.AddRange(new object[] { "Pequena", "Média", "Grande", "Família" });
            comboBoxML.Location = new Point(20, 84);
            comboBoxML.Name = "comboBoxML";
            comboBoxML.Size = new Size(67, 23);
            comboBoxML.TabIndex = 15;
            // 
            // labelProduto
            // 
            labelProduto.AutoSize = true;
            labelProduto.BackColor = Color.Transparent;
            labelProduto.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelProduto.ForeColor = SystemColors.ActiveCaptionText;
            labelProduto.Location = new Point(91, 22);
            labelProduto.Name = "labelProduto";
            labelProduto.Size = new Size(50, 15);
            labelProduto.TabIndex = 83;
            labelProduto.Text = "Produto";
            // 
            // buttonProximoProduto
            // 
            buttonProximoProduto.BackColor = Color.DodgerBlue;
            buttonProximoProduto.FlatAppearance.BorderColor = Color.Gray;
            buttonProximoProduto.FlatAppearance.BorderSize = 0;
            buttonProximoProduto.FlatStyle = FlatStyle.Flat;
            buttonProximoProduto.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonProximoProduto.ForeColor = Color.White;
            buttonProximoProduto.ImageAlign = ContentAlignment.MiddleLeft;
            buttonProximoProduto.Location = new Point(118, 78);
            buttonProximoProduto.Name = "buttonProximoProduto";
            buttonProximoProduto.Size = new Size(173, 32);
            buttonProximoProduto.TabIndex = 16;
            buttonProximoProduto.Text = "Próximo Produto >>";
            buttonProximoProduto.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonProximoProduto.UseVisualStyleBackColor = false;
            buttonProximoProduto.Click += buttonProximoProduto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(46, 37);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 81;
            // 
            // comboBoxProduto
            // 
            comboBoxProduto.FormattingEnabled = true;
            comboBoxProduto.Items.AddRange(new object[] { "Pequena", "Média", "Grande", "Família" });
            comboBoxProduto.Location = new Point(91, 40);
            comboBoxProduto.Name = "comboBoxProduto";
            comboBoxProduto.Size = new Size(200, 23);
            comboBoxProduto.TabIndex = 14;
            // 
            // groupBoxAddPizza
            // 
            groupBoxAddPizza.Controls.Add(buttonProximaPizza);
            groupBoxAddPizza.Controls.Add(groupBoxIngredientes);
            groupBoxAddPizza.Controls.Add(groupBoxSabor);
            groupBoxAddPizza.Controls.Add(groupBoxTamanhoPizza);
            groupBoxAddPizza.Location = new Point(322, 29);
            groupBoxAddPizza.Name = "groupBoxAddPizza";
            groupBoxAddPizza.Size = new Size(656, 415);
            groupBoxAddPizza.TabIndex = 11;
            groupBoxAddPizza.TabStop = false;
            groupBoxAddPizza.Text = "Adicionar Pizza";
            // 
            // buttonProximaPizza
            // 
            buttonProximaPizza.BackColor = Color.DodgerBlue;
            buttonProximaPizza.FlatAppearance.BorderColor = Color.Gray;
            buttonProximaPizza.FlatAppearance.BorderSize = 0;
            buttonProximaPizza.FlatStyle = FlatStyle.Flat;
            buttonProximaPizza.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonProximaPizza.ForeColor = Color.White;
            buttonProximaPizza.ImageAlign = ContentAlignment.MiddleLeft;
            buttonProximaPizza.Location = new Point(469, 365);
            buttonProximaPizza.Name = "buttonProximaPizza";
            buttonProximaPizza.Size = new Size(175, 32);
            buttonProximaPizza.TabIndex = 8;
            buttonProximaPizza.Text = "Próxima Pizza >>";
            buttonProximaPizza.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonProximaPizza.UseVisualStyleBackColor = false;
            buttonProximaPizza.Click += buttonProximaPizza_Click;
            // 
            // groupBoxIngredientes
            // 
            groupBoxIngredientes.Controls.Add(checkedListBoxIngredientes);
            groupBoxIngredientes.Location = new Point(344, 15);
            groupBoxIngredientes.Name = "groupBoxIngredientes";
            groupBoxIngredientes.Size = new Size(300, 330);
            groupBoxIngredientes.TabIndex = 7;
            groupBoxIngredientes.TabStop = false;
            groupBoxIngredientes.Text = "Ingredientes";
            // 
            // checkedListBoxIngredientes
            // 
            checkedListBoxIngredientes.FormattingEnabled = true;
            checkedListBoxIngredientes.Location = new Point(20, 30);
            checkedListBoxIngredientes.Name = "checkedListBoxIngredientes";
            checkedListBoxIngredientes.Size = new Size(260, 274);
            checkedListBoxIngredientes.TabIndex = 0;
            // 
            // groupBoxSabor
            // 
            groupBoxSabor.Controls.Add(textBoxIDSabor3);
            groupBoxSabor.Controls.Add(label5);
            groupBoxSabor.Controls.Add(textBoxIDSabor2);
            groupBoxSabor.Controls.Add(label4);
            groupBoxSabor.Controls.Add(textBoxIDSabor1);
            groupBoxSabor.Controls.Add(label3);
            groupBoxSabor.Controls.Add(checkBoxBorda);
            groupBoxSabor.Controls.Add(checkBoxInteira);
            groupBoxSabor.Controls.Add(labelSabor3);
            groupBoxSabor.Controls.Add(comboBoxSabor3);
            groupBoxSabor.Controls.Add(labelSabor2);
            groupBoxSabor.Controls.Add(comboBoxSabor2);
            groupBoxSabor.Controls.Add(labelSabor1);
            groupBoxSabor.Controls.Add(comboBoxSabor1);
            groupBoxSabor.Location = new Point(15, 121);
            groupBoxSabor.Name = "groupBoxSabor";
            groupBoxSabor.Size = new Size(320, 224);
            groupBoxSabor.TabIndex = 6;
            groupBoxSabor.TabStop = false;
            // 
            // checkBoxBorda
            // 
            checkBoxBorda.AutoSize = true;
            checkBoxBorda.Location = new Point(25, 197);
            checkBoxBorda.Name = "checkBoxBorda";
            checkBoxBorda.Size = new Size(89, 19);
            checkBoxBorda.TabIndex = 86;
            checkBoxBorda.Text = "Com borda.";
            checkBoxBorda.UseVisualStyleBackColor = true;
            // 
            // checkBoxInteira
            // 
            checkBoxInteira.AutoSize = true;
            checkBoxInteira.Location = new Point(25, 172);
            checkBoxInteira.Name = "checkBoxInteira";
            checkBoxInteira.Size = new Size(136, 19);
            checkBoxInteira.TabIndex = 84;
            checkBoxInteira.Text = "Pizza de único sabor.";
            checkBoxInteira.UseVisualStyleBackColor = true;
            // 
            // labelSabor3
            // 
            labelSabor3.AutoSize = true;
            labelSabor3.BackColor = Color.Transparent;
            labelSabor3.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelSabor3.ForeColor = SystemColors.ActiveCaptionText;
            labelSabor3.Location = new Point(105, 118);
            labelSabor3.Name = "labelSabor3";
            labelSabor3.Size = new Size(48, 15);
            labelSabor3.TabIndex = 83;
            labelSabor3.Text = "Sabor 3";
            // 
            // comboBoxSabor3
            // 
            comboBoxSabor3.FormattingEnabled = true;
            comboBoxSabor3.Items.AddRange(new object[] { "Pequena", "Média", "Grande", "Família" });
            comboBoxSabor3.Location = new Point(105, 136);
            comboBoxSabor3.Name = "comboBoxSabor3";
            comboBoxSabor3.Size = new Size(195, 23);
            comboBoxSabor3.TabIndex = 82;
            // 
            // labelSabor2
            // 
            labelSabor2.AutoSize = true;
            labelSabor2.BackColor = Color.Transparent;
            labelSabor2.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelSabor2.ForeColor = SystemColors.ActiveCaptionText;
            labelSabor2.Location = new Point(105, 74);
            labelSabor2.Name = "labelSabor2";
            labelSabor2.Size = new Size(48, 15);
            labelSabor2.TabIndex = 81;
            labelSabor2.Text = "Sabor 2";
            // 
            // comboBoxSabor2
            // 
            comboBoxSabor2.FormattingEnabled = true;
            comboBoxSabor2.Items.AddRange(new object[] { "Pequena", "Média", "Grande", "Família" });
            comboBoxSabor2.Location = new Point(105, 92);
            comboBoxSabor2.Name = "comboBoxSabor2";
            comboBoxSabor2.Size = new Size(195, 23);
            comboBoxSabor2.TabIndex = 80;
            // 
            // labelSabor1
            // 
            labelSabor1.AutoSize = true;
            labelSabor1.BackColor = Color.Transparent;
            labelSabor1.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelSabor1.ForeColor = SystemColors.ActiveCaptionText;
            labelSabor1.Location = new Point(105, 30);
            labelSabor1.Name = "labelSabor1";
            labelSabor1.Size = new Size(46, 15);
            labelSabor1.TabIndex = 79;
            labelSabor1.Text = "Sabor 1";
            // 
            // comboBoxSabor1
            // 
            comboBoxSabor1.FormattingEnabled = true;
            comboBoxSabor1.Items.AddRange(new object[] { "Pequena", "Média", "Grande", "Família" });
            comboBoxSabor1.Location = new Point(105, 48);
            comboBoxSabor1.Name = "comboBoxSabor1";
            comboBoxSabor1.Size = new Size(195, 23);
            comboBoxSabor1.TabIndex = 78;
            // 
            // groupBoxTamanhoPizza
            // 
            groupBoxTamanhoPizza.Controls.Add(labelObsTamanho);
            groupBoxTamanhoPizza.Controls.Add(labelTamanho);
            groupBoxTamanhoPizza.Controls.Add(comboBoxTamanho);
            groupBoxTamanhoPizza.Location = new Point(15, 15);
            groupBoxTamanhoPizza.Name = "groupBoxTamanhoPizza";
            groupBoxTamanhoPizza.Size = new Size(320, 100);
            groupBoxTamanhoPizza.TabIndex = 5;
            groupBoxTamanhoPizza.TabStop = false;
            // 
            // labelTamanho
            // 
            labelTamanho.AutoSize = true;
            labelTamanho.BackColor = Color.Transparent;
            labelTamanho.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelTamanho.ForeColor = SystemColors.ActiveCaptionText;
            labelTamanho.Location = new Point(20, 28);
            labelTamanho.Name = "labelTamanho";
            labelTamanho.Size = new Size(57, 15);
            labelTamanho.TabIndex = 77;
            labelTamanho.Text = "Tamanho";
            // 
            // comboBoxTamanho
            // 
            comboBoxTamanho.FormattingEnabled = true;
            comboBoxTamanho.Items.AddRange(new object[] { "Pequena", "Média", "Grande", "Família" });
            comboBoxTamanho.Location = new Point(20, 46);
            comboBoxTamanho.Name = "comboBoxTamanho";
            comboBoxTamanho.Size = new Size(121, 23);
            comboBoxTamanho.TabIndex = 0;
            // 
            // groupBoxEndereco
            // 
            groupBoxEndereco.Controls.Add(checkBoxEntregar);
            groupBoxEndereco.Controls.Add(textBoxPais);
            groupBoxEndereco.Controls.Add(labelPais);
            groupBoxEndereco.Controls.Add(comboBoxUF);
            groupBoxEndereco.Controls.Add(labelUF);
            groupBoxEndereco.Controls.Add(textBoxComplemento);
            groupBoxEndereco.Controls.Add(labelComplemento);
            groupBoxEndereco.Controls.Add(textBoxCidade);
            groupBoxEndereco.Controls.Add(labelCidade);
            groupBoxEndereco.Controls.Add(textBoxBairro);
            groupBoxEndereco.Controls.Add(labelBairro);
            groupBoxEndereco.Controls.Add(textBoxNumero);
            groupBoxEndereco.Controls.Add(labelNumero);
            groupBoxEndereco.Controls.Add(maskedTextBoxCEP);
            groupBoxEndereco.Controls.Add(textBoxLogradouro);
            groupBoxEndereco.Controls.Add(labelLogradouro);
            groupBoxEndereco.Controls.Add(labelCEP);
            groupBoxEndereco.Location = new Point(0, 158);
            groupBoxEndereco.Name = "groupBoxEndereco";
            groupBoxEndereco.Size = new Size(315, 248);
            groupBoxEndereco.TabIndex = 9;
            groupBoxEndereco.TabStop = false;
            groupBoxEndereco.Text = "Endereço";
            // 
            // checkBoxEntregar
            // 
            checkBoxEntregar.AutoSize = true;
            checkBoxEntregar.Location = new Point(20, 22);
            checkBoxEntregar.Name = "checkBoxEntregar";
            checkBoxEntregar.Size = new Size(95, 19);
            checkBoxEntregar.TabIndex = 4;
            checkBoxEntregar.Text = "Para entrega.";
            checkBoxEntregar.UseVisualStyleBackColor = true;
            // 
            // textBoxPais
            // 
            textBoxPais.Location = new Point(154, 204);
            textBoxPais.Name = "textBoxPais";
            textBoxPais.Size = new Size(137, 23);
            textBoxPais.TabIndex = 13;
            // 
            // labelPais
            // 
            labelPais.AutoSize = true;
            labelPais.BackColor = Color.Transparent;
            labelPais.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelPais.ForeColor = SystemColors.ActiveCaptionText;
            labelPais.Location = new Point(154, 186);
            labelPais.Name = "labelPais";
            labelPais.Size = new Size(28, 15);
            labelPais.TabIndex = 68;
            labelPais.Text = "País";
            // 
            // comboBoxUF
            // 
            comboBoxUF.FormattingEnabled = true;
            comboBoxUF.Location = new Point(20, 204);
            comboBoxUF.Name = "comboBoxUF";
            comboBoxUF.Size = new Size(51, 23);
            comboBoxUF.TabIndex = 12;
            // 
            // labelUF
            // 
            labelUF.AutoSize = true;
            labelUF.BackColor = Color.Transparent;
            labelUF.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelUF.ForeColor = SystemColors.ActiveCaptionText;
            labelUF.Location = new Point(20, 186);
            labelUF.Name = "labelUF";
            labelUF.Size = new Size(21, 15);
            labelUF.TabIndex = 66;
            labelUF.Text = "UF";
            // 
            // textBoxComplemento
            // 
            textBoxComplemento.Location = new Point(91, 116);
            textBoxComplemento.Name = "textBoxComplemento";
            textBoxComplemento.Size = new Size(200, 23);
            textBoxComplemento.TabIndex = 8;
            // 
            // labelComplemento
            // 
            labelComplemento.AutoSize = true;
            labelComplemento.BackColor = Color.Transparent;
            labelComplemento.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelComplemento.ForeColor = SystemColors.ActiveCaptionText;
            labelComplemento.Location = new Point(91, 98);
            labelComplemento.Name = "labelComplemento";
            labelComplemento.Size = new Size(83, 15);
            labelComplemento.TabIndex = 64;
            labelComplemento.Text = "Complemento";
            // 
            // textBoxCidade
            // 
            textBoxCidade.Location = new Point(20, 160);
            textBoxCidade.Name = "textBoxCidade";
            textBoxCidade.Size = new Size(116, 23);
            textBoxCidade.TabIndex = 10;
            // 
            // labelCidade
            // 
            labelCidade.AutoSize = true;
            labelCidade.BackColor = Color.Transparent;
            labelCidade.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCidade.ForeColor = SystemColors.ActiveCaptionText;
            labelCidade.Location = new Point(20, 142);
            labelCidade.Name = "labelCidade";
            labelCidade.Size = new Size(43, 15);
            labelCidade.TabIndex = 62;
            labelCidade.Text = "Cidade";
            // 
            // textBoxBairro
            // 
            textBoxBairro.Location = new Point(154, 160);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(137, 23);
            textBoxBairro.TabIndex = 11;
            // 
            // labelBairro
            // 
            labelBairro.AutoSize = true;
            labelBairro.BackColor = Color.Transparent;
            labelBairro.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelBairro.ForeColor = SystemColors.ActiveCaptionText;
            labelBairro.Location = new Point(154, 142);
            labelBairro.Name = "labelBairro";
            labelBairro.Size = new Size(38, 15);
            labelBairro.TabIndex = 60;
            labelBairro.Text = "Bairro";
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(20, 116);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(51, 23);
            textBoxNumero.TabIndex = 7;
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.BackColor = Color.Transparent;
            labelNumero.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNumero.ForeColor = SystemColors.ActiveCaptionText;
            labelNumero.Location = new Point(20, 98);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(51, 15);
            labelNumero.TabIndex = 58;
            labelNumero.Text = "Número";
            // 
            // maskedTextBoxCEP
            // 
            maskedTextBoxCEP.Location = new Point(20, 72);
            maskedTextBoxCEP.Mask = "00000-000";
            maskedTextBoxCEP.Name = "maskedTextBoxCEP";
            maskedTextBoxCEP.Size = new Size(51, 23);
            maskedTextBoxCEP.TabIndex = 5;
            maskedTextBoxCEP.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // textBoxLogradouro
            // 
            textBoxLogradouro.Location = new Point(91, 72);
            textBoxLogradouro.Name = "textBoxLogradouro";
            textBoxLogradouro.Size = new Size(200, 23);
            textBoxLogradouro.TabIndex = 6;
            // 
            // labelLogradouro
            // 
            labelLogradouro.AutoSize = true;
            labelLogradouro.BackColor = Color.Transparent;
            labelLogradouro.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelLogradouro.ForeColor = SystemColors.ActiveCaptionText;
            labelLogradouro.Location = new Point(91, 54);
            labelLogradouro.Name = "labelLogradouro";
            labelLogradouro.Size = new Size(69, 15);
            labelLogradouro.TabIndex = 56;
            labelLogradouro.Text = "Logradouro";
            // 
            // labelCEP
            // 
            labelCEP.AutoSize = true;
            labelCEP.BackColor = Color.Transparent;
            labelCEP.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCEP.ForeColor = SystemColors.ActiveCaptionText;
            labelCEP.Location = new Point(20, 54);
            labelCEP.Name = "labelCEP";
            labelCEP.Size = new Size(27, 15);
            labelCEP.TabIndex = 55;
            labelCEP.Text = "CEP";
            // 
            // groupBoxCliente
            // 
            groupBoxCliente.Controls.Add(maskedTextBoxTel);
            groupBoxCliente.Controls.Add(labelTel);
            groupBoxCliente.Controls.Add(maskedTextBoxCPF);
            groupBoxCliente.Controls.Add(labelCPF);
            groupBoxCliente.Controls.Add(textBoxID);
            groupBoxCliente.Controls.Add(labelID);
            groupBoxCliente.Controls.Add(textBoxNome);
            groupBoxCliente.Controls.Add(labelNome);
            groupBoxCliente.Location = new Point(0, 29);
            groupBoxCliente.Name = "groupBoxCliente";
            groupBoxCliente.Size = new Size(315, 123);
            groupBoxCliente.TabIndex = 8;
            groupBoxCliente.TabStop = false;
            groupBoxCliente.Text = "Cliente";
            // 
            // maskedTextBoxTel
            // 
            maskedTextBoxTel.Location = new Point(154, 92);
            maskedTextBoxTel.Mask = "(00) 000-000-000";
            maskedTextBoxTel.Name = "maskedTextBoxTel";
            maskedTextBoxTel.Size = new Size(137, 23);
            maskedTextBoxTel.TabIndex = 3;
            maskedTextBoxTel.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // labelTel
            // 
            labelTel.AutoSize = true;
            labelTel.BackColor = Color.Transparent;
            labelTel.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelTel.ForeColor = SystemColors.ActiveCaptionText;
            labelTel.Location = new Point(154, 74);
            labelTel.Name = "labelTel";
            labelTel.Size = new Size(52, 15);
            labelTel.TabIndex = 83;
            labelTel.Text = "Telefone";
            // 
            // maskedTextBoxCPF
            // 
            maskedTextBoxCPF.Location = new Point(20, 92);
            maskedTextBoxCPF.Mask = "000,000,000-00";
            maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            maskedTextBoxCPF.Size = new Size(77, 23);
            maskedTextBoxCPF.TabIndex = 2;
            maskedTextBoxCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // labelCPF
            // 
            labelCPF.AutoSize = true;
            labelCPF.BackColor = Color.Transparent;
            labelCPF.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCPF.ForeColor = SystemColors.ActiveCaptionText;
            labelCPF.Location = new Point(20, 74);
            labelCPF.Name = "labelCPF";
            labelCPF.Size = new Size(27, 15);
            labelCPF.TabIndex = 81;
            labelCPF.Text = "CPF";
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(20, 48);
            textBoxID.Name = "textBoxID";
            textBoxID.ReadOnly = true;
            textBoxID.Size = new Size(50, 23);
            textBoxID.TabIndex = 78;
            textBoxID.TabStop = false;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.BackColor = Color.Transparent;
            labelID.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelID.ForeColor = SystemColors.ActiveCaptionText;
            labelID.Location = new Point(20, 30);
            labelID.Name = "labelID";
            labelID.Size = new Size(20, 15);
            labelID.TabIndex = 77;
            labelID.Text = "ID";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(91, 48);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(200, 23);
            textBoxNome.TabIndex = 1;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.BackColor = Color.Transparent;
            labelNome.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNome.ForeColor = SystemColors.ActiveCaptionText;
            labelNome.Location = new Point(91, 30);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(95, 15);
            labelNome.TabIndex = 76;
            labelNome.Text = "Nome Completo";
            // 
            // textBoxIDPedido
            // 
            textBoxIDPedido.Location = new Point(322, 489);
            textBoxIDPedido.Name = "textBoxIDPedido";
            textBoxIDPedido.ReadOnly = true;
            textBoxIDPedido.Size = new Size(50, 23);
            textBoxIDPedido.TabIndex = 82;
            textBoxIDPedido.TabStop = false;
            // 
            // labelIDPedido
            // 
            labelIDPedido.AutoSize = true;
            labelIDPedido.BackColor = Color.Transparent;
            labelIDPedido.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelIDPedido.ForeColor = SystemColors.ActiveCaptionText;
            labelIDPedido.Location = new Point(322, 471);
            labelIDPedido.Name = "labelIDPedido";
            labelIDPedido.Size = new Size(20, 15);
            labelIDPedido.TabIndex = 81;
            labelIDPedido.Text = "ID";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(20, 40);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(50, 23);
            textBox1.TabIndex = 87;
            textBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(20, 22);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 86;
            label2.Text = "ID";
            // 
            // textBoxIDSabor1
            // 
            textBoxIDSabor1.Location = new Point(25, 48);
            textBoxIDSabor1.Name = "textBoxIDSabor1";
            textBoxIDSabor1.ReadOnly = true;
            textBoxIDSabor1.Size = new Size(50, 23);
            textBoxIDSabor1.TabIndex = 88;
            textBoxIDSabor1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(25, 30);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 87;
            label3.Text = "ID";
            // 
            // textBoxIDSabor2
            // 
            textBoxIDSabor2.Location = new Point(25, 92);
            textBoxIDSabor2.Name = "textBoxIDSabor2";
            textBoxIDSabor2.ReadOnly = true;
            textBoxIDSabor2.Size = new Size(50, 23);
            textBoxIDSabor2.TabIndex = 90;
            textBoxIDSabor2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(25, 74);
            label4.Name = "label4";
            label4.Size = new Size(20, 15);
            label4.TabIndex = 89;
            label4.Text = "ID";
            // 
            // textBoxIDSabor3
            // 
            textBoxIDSabor3.Location = new Point(25, 136);
            textBoxIDSabor3.Name = "textBoxIDSabor3";
            textBoxIDSabor3.ReadOnly = true;
            textBoxIDSabor3.Size = new Size(50, 23);
            textBoxIDSabor3.TabIndex = 92;
            textBoxIDSabor3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(25, 118);
            label5.Name = "label5";
            label5.Size = new Size(20, 15);
            label5.TabIndex = 91;
            label5.Text = "ID";
            // 
            // labelObsTamanho
            // 
            labelObsTamanho.AutoSize = true;
            labelObsTamanho.Location = new Point(168, 49);
            labelObsTamanho.Name = "labelObsTamanho";
            labelObsTamanho.Size = new Size(123, 15);
            labelObsTamanho.TabIndex = 78;
            labelObsTamanho.Text = "Pode Escolher 1 Sabor";
            // 
            // ListaPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(panelLista);
            Controls.Add(panel1);
            Controls.Add(menu1);
            Name = "ListaPedidos";
            Text = "ListaPedidos";
            panelLista.ResumeLayout(false);
            panelEditar.ResumeLayout(false);
            panelEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBoxProduto.ResumeLayout(false);
            groupBoxProduto.PerformLayout();
            groupBoxAddPizza.ResumeLayout(false);
            groupBoxIngredientes.ResumeLayout(false);
            groupBoxSabor.ResumeLayout(false);
            groupBoxSabor.PerformLayout();
            groupBoxTamanhoPizza.ResumeLayout(false);
            groupBoxTamanhoPizza.PerformLayout();
            groupBoxEndereco.ResumeLayout(false);
            groupBoxEndereco.PerformLayout();
            groupBoxCliente.ResumeLayout(false);
            groupBoxCliente.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLista;
        private Button buttonEditar;
        private Button buttonFechar;
        internal DataGridView dataGridViewDados;
        internal Panel panel1;
        private Button buttonCadastrar;
        private Label labelPedido;
        internal Menu menu1;
        internal Panel panelEditar;
        internal Button buttonExcluir;
        internal Button buttonSalvar;
        internal Button buttonEditarFechar;
        private GroupBox groupBoxProduto;
        internal Label labelML;
        private ComboBox comboBoxML;
        internal Label labelProduto;
        internal Button buttonProximoProduto;
        internal Label label1;
        private ComboBox comboBoxProduto;
        private GroupBox groupBoxAddPizza;
        internal Button buttonProximaPizza;
        private GroupBox groupBoxIngredientes;
        private CheckedListBox checkedListBoxIngredientes;
        private GroupBox groupBoxSabor;
        private CheckBox checkBoxBorda;
        private CheckBox checkBoxInteira;
        internal Label labelSabor3;
        private ComboBox comboBoxSabor3;
        internal Label labelSabor2;
        private ComboBox comboBoxSabor2;
        internal Label labelSabor1;
        private ComboBox comboBoxSabor1;
        private GroupBox groupBoxTamanhoPizza;
        internal Label labelTamanho;
        private ComboBox comboBoxTamanho;
        private GroupBox groupBoxEndereco;
        private CheckBox checkBoxEntregar;
        internal TextBox textBoxPais;
        internal Label labelPais;
        internal ComboBox comboBoxUF;
        internal Label labelUF;
        internal TextBox textBoxComplemento;
        internal Label labelComplemento;
        internal TextBox textBoxCidade;
        internal Label labelCidade;
        internal TextBox textBoxBairro;
        internal Label labelBairro;
        internal TextBox textBoxNumero;
        internal Label labelNumero;
        internal MaskedTextBox maskedTextBoxCEP;
        internal TextBox textBoxLogradouro;
        internal Label labelLogradouro;
        internal Label labelCEP;
        private GroupBox groupBoxCliente;
        internal MaskedTextBox maskedTextBoxTel;
        internal Label labelTel;
        internal MaskedTextBox maskedTextBoxCPF;
        internal Label labelCPF;
        internal TextBox textBoxID;
        internal Label labelID;
        internal TextBox textBoxNome;
        internal Label labelNome;
        internal TextBox textBoxIDPedido;
        internal Label labelIDPedido;
        internal TextBox textBox1;
        internal Label label2;
        internal TextBox textBoxIDSabor3;
        internal Label label5;
        internal TextBox textBoxIDSabor2;
        internal Label label4;
        internal TextBox textBoxIDSabor1;
        internal Label label3;
        private Label labelObsTamanho;
    }
}