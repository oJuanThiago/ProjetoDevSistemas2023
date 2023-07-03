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
            maskedTextBoxValorPedido = new MaskedTextBox();
            label3 = new Label();
            groupBoxProduto = new GroupBox();
            buttonEditarProdutos = new Button();
            labelValorProduto = new Label();
            textBoxValorProduto = new TextBox();
            comboBoxML = new ComboBox();
            labelML = new Label();
            textBoxIDProduto = new TextBox();
            label2 = new Label();
            labelProduto = new Label();
            buttonAddProduto = new Button();
            label1 = new Label();
            comboBoxProduto = new ComboBox();
            textBoxIDPedido = new TextBox();
            labelIDPedido = new Label();
            groupBoxAddPizza = new GroupBox();
            buttoneditarPizzas = new Button();
            label5 = new Label();
            label4 = new Label();
            textBoxValorBorda = new TextBox();
            textBoxValorPizza = new TextBox();
            buttonAddPizza = new Button();
            groupBoxIngredientes = new GroupBox();
            checkedListBoxIngredientes = new CheckedListBox();
            groupBoxSabor = new GroupBox();
            comboBoxSaborBorda = new ComboBox();
            checkBoxBorda = new CheckBox();
            checkBoxUnicoSabor = new CheckBox();
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
            textBoxEnderecoID = new TextBox();
            label6 = new Label();
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
            buttonSalvar = new Button();
            groupBoxCliente = new GroupBox();
            maskedTextBoxTel = new MaskedTextBox();
            labelTel = new Label();
            maskedTextBoxCPF = new MaskedTextBox();
            labelCPF = new Label();
            textBoxIDCliente = new TextBox();
            labelID = new Label();
            textBoxNome = new TextBox();
            labelNome = new Label();
            buttonEditarFechar = new Button();
            buttonEditar = new Button();
            buttonFechar = new Button();
            dataGridViewDados = new DataGridView();
            panel1 = new Panel();
            buttonCadastrar = new Button();
            labelPedido = new Label();
            menu1 = new Menu();
            panelEditarItens = new Panel();
            checkedListBoxProdutos = new CheckedListBox();
            comboBoxPizzas = new ComboBox();
            groupBoxProdutos = new GroupBox();
            groupBoxPizzas = new GroupBox();
            labelPizzas = new Label();
            comboBox1 = new ComboBox();
            label7 = new Label();
            buttonEditarItensFechar = new Button();
            panelLista.SuspendLayout();
            panelEditar.SuspendLayout();
            groupBoxProduto.SuspendLayout();
            groupBoxAddPizza.SuspendLayout();
            groupBoxIngredientes.SuspendLayout();
            groupBoxSabor.SuspendLayout();
            groupBoxTamanhoPizza.SuspendLayout();
            groupBoxEndereco.SuspendLayout();
            groupBoxCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).BeginInit();
            panel1.SuspendLayout();
            panelEditarItens.SuspendLayout();
            groupBoxProdutos.SuspendLayout();
            groupBoxPizzas.SuspendLayout();
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
            panelEditar.BackColor = Color.FromArgb(51, 51, 51);
            panelEditar.Controls.Add(panelEditarItens);
            panelEditar.Controls.Add(buttonExcluir);
            panelEditar.Controls.Add(maskedTextBoxValorPedido);
            panelEditar.Controls.Add(label3);
            panelEditar.Controls.Add(groupBoxProduto);
            panelEditar.Controls.Add(textBoxIDPedido);
            panelEditar.Controls.Add(labelIDPedido);
            panelEditar.Controls.Add(groupBoxAddPizza);
            panelEditar.Controls.Add(groupBoxEndereco);
            panelEditar.Controls.Add(buttonSalvar);
            panelEditar.Controls.Add(groupBoxCliente);
            panelEditar.Controls.Add(buttonEditarFechar);
            panelEditar.Location = new Point(6, 6);
            panelEditar.Name = "panelEditar";
            panelEditar.Size = new Size(1064, 581);
            panelEditar.TabIndex = 6;
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
            buttonExcluir.Location = new Point(851, 497);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(80, 38);
            buttonExcluir.TabIndex = 86;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonExcluir.UseVisualStyleBackColor = false;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // maskedTextBoxValorPedido
            // 
            maskedTextBoxValorPedido.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            maskedTextBoxValorPedido.Location = new Point(566, 493);
            maskedTextBoxValorPedido.Name = "maskedTextBoxValorPedido";
            maskedTextBoxValorPedido.Size = new Size(80, 35);
            maskedTextBoxValorPedido.TabIndex = 84;
            maskedTextBoxValorPedido.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(471, 503);
            label3.Name = "label3";
            label3.Size = new Size(89, 21);
            label3.TabIndex = 85;
            label3.Text = "Valor total:";
            // 
            // groupBoxProduto
            // 
            groupBoxProduto.Controls.Add(buttonEditarProdutos);
            groupBoxProduto.Controls.Add(labelValorProduto);
            groupBoxProduto.Controls.Add(textBoxValorProduto);
            groupBoxProduto.Controls.Add(comboBoxML);
            groupBoxProduto.Controls.Add(labelML);
            groupBoxProduto.Controls.Add(textBoxIDProduto);
            groupBoxProduto.Controls.Add(label2);
            groupBoxProduto.Controls.Add(labelProduto);
            groupBoxProduto.Controls.Add(buttonAddProduto);
            groupBoxProduto.Controls.Add(label1);
            groupBoxProduto.Controls.Add(comboBoxProduto);
            groupBoxProduto.ForeColor = SystemColors.ControlLightLight;
            groupBoxProduto.Location = new Point(75, 402);
            groupBoxProduto.Name = "groupBoxProduto";
            groupBoxProduto.Size = new Size(268, 167);
            groupBoxProduto.TabIndex = 81;
            groupBoxProduto.TabStop = false;
            groupBoxProduto.Text = "Adicionar Produto";
            // 
            // buttonEditarProdutos
            // 
            buttonEditarProdutos.BackColor = Color.Gray;
            buttonEditarProdutos.FlatAppearance.BorderColor = Color.Gray;
            buttonEditarProdutos.FlatAppearance.BorderSize = 0;
            buttonEditarProdutos.FlatStyle = FlatStyle.Flat;
            buttonEditarProdutos.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEditarProdutos.ForeColor = Color.White;
            buttonEditarProdutos.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEditarProdutos.Location = new Point(165, 113);
            buttonEditarProdutos.Name = "buttonEditarProdutos";
            buttonEditarProdutos.Size = new Size(80, 32);
            buttonEditarProdutos.TabIndex = 92;
            buttonEditarProdutos.Text = "Editar";
            buttonEditarProdutos.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonEditarProdutos.UseVisualStyleBackColor = false;
            buttonEditarProdutos.Click += buttonEditarProdutos_Click;
            // 
            // labelValorProduto
            // 
            labelValorProduto.AutoSize = true;
            labelValorProduto.BackColor = Color.Transparent;
            labelValorProduto.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelValorProduto.ForeColor = SystemColors.ButtonHighlight;
            labelValorProduto.Location = new Point(118, 87);
            labelValorProduto.Name = "labelValorProduto";
            labelValorProduto.Size = new Size(38, 15);
            labelValorProduto.TabIndex = 91;
            labelValorProduto.Text = "Valor:";
            // 
            // textBoxValorProduto
            // 
            textBoxValorProduto.Location = new Point(162, 84);
            textBoxValorProduto.Name = "textBoxValorProduto";
            textBoxValorProduto.Size = new Size(83, 23);
            textBoxValorProduto.TabIndex = 90;
            // 
            // comboBoxML
            // 
            comboBoxML.FormattingEnabled = true;
            comboBoxML.Items.AddRange(new object[] { "100", "150", "300", "350", "500", "600", "1000", "1500", "2000", "2500" });
            comboBoxML.Location = new Point(19, 84);
            comboBoxML.Name = "comboBoxML";
            comboBoxML.Size = new Size(51, 23);
            comboBoxML.TabIndex = 88;
            // 
            // labelML
            // 
            labelML.AutoSize = true;
            labelML.BackColor = Color.Transparent;
            labelML.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelML.ForeColor = SystemColors.ControlLightLight;
            labelML.Location = new Point(19, 66);
            labelML.Name = "labelML";
            labelML.Size = new Size(33, 15);
            labelML.TabIndex = 89;
            labelML.Text = "ml/g";
            // 
            // textBoxIDProduto
            // 
            textBoxIDProduto.Location = new Point(20, 40);
            textBoxIDProduto.Name = "textBoxIDProduto";
            textBoxIDProduto.ReadOnly = true;
            textBoxIDProduto.Size = new Size(50, 23);
            textBoxIDProduto.TabIndex = 87;
            textBoxIDProduto.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(20, 22);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 86;
            label2.Text = "ID";
            // 
            // labelProduto
            // 
            labelProduto.AutoSize = true;
            labelProduto.BackColor = Color.Transparent;
            labelProduto.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelProduto.ForeColor = SystemColors.ButtonHighlight;
            labelProduto.Location = new Point(79, 22);
            labelProduto.Name = "labelProduto";
            labelProduto.Size = new Size(50, 15);
            labelProduto.TabIndex = 83;
            labelProduto.Text = "Produto";
            // 
            // buttonAddProduto
            // 
            buttonAddProduto.BackColor = Color.DodgerBlue;
            buttonAddProduto.FlatAppearance.BorderColor = Color.Gray;
            buttonAddProduto.FlatAppearance.BorderSize = 0;
            buttonAddProduto.FlatStyle = FlatStyle.Flat;
            buttonAddProduto.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddProduto.ForeColor = Color.White;
            buttonAddProduto.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddProduto.Location = new Point(69, 113);
            buttonAddProduto.Name = "buttonAddProduto";
            buttonAddProduto.Size = new Size(91, 32);
            buttonAddProduto.TabIndex = 16;
            buttonAddProduto.Text = "Adicionar";
            buttonAddProduto.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAddProduto.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(46, 37);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 81;
            // 
            // comboBoxProduto
            // 
            comboBoxProduto.FormattingEnabled = true;
            comboBoxProduto.Items.AddRange(new object[] { "Pequena", "Média", "Grande", "Família" });
            comboBoxProduto.Location = new Point(79, 40);
            comboBoxProduto.Name = "comboBoxProduto";
            comboBoxProduto.Size = new Size(166, 23);
            comboBoxProduto.TabIndex = 14;
            // 
            // textBoxIDPedido
            // 
            textBoxIDPedido.Location = new Point(407, 504);
            textBoxIDPedido.Name = "textBoxIDPedido";
            textBoxIDPedido.ReadOnly = true;
            textBoxIDPedido.Size = new Size(50, 23);
            textBoxIDPedido.TabIndex = 80;
            textBoxIDPedido.TabStop = false;
            // 
            // labelIDPedido
            // 
            labelIDPedido.AutoSize = true;
            labelIDPedido.BackColor = Color.Transparent;
            labelIDPedido.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelIDPedido.ForeColor = SystemColors.ControlLightLight;
            labelIDPedido.Location = new Point(407, 486);
            labelIDPedido.Name = "labelIDPedido";
            labelIDPedido.Size = new Size(20, 15);
            labelIDPedido.TabIndex = 79;
            labelIDPedido.Text = "ID";
            // 
            // groupBoxAddPizza
            // 
            groupBoxAddPizza.Controls.Add(buttoneditarPizzas);
            groupBoxAddPizza.Controls.Add(label5);
            groupBoxAddPizza.Controls.Add(label4);
            groupBoxAddPizza.Controls.Add(textBoxValorBorda);
            groupBoxAddPizza.Controls.Add(textBoxValorPizza);
            groupBoxAddPizza.Controls.Add(buttonAddPizza);
            groupBoxAddPizza.Controls.Add(groupBoxIngredientes);
            groupBoxAddPizza.Controls.Add(groupBoxSabor);
            groupBoxAddPizza.Controls.Add(groupBoxTamanhoPizza);
            groupBoxAddPizza.ForeColor = SystemColors.ControlLightLight;
            groupBoxAddPizza.Location = new Point(392, 19);
            groupBoxAddPizza.Name = "groupBoxAddPizza";
            groupBoxAddPizza.Size = new Size(552, 415);
            groupBoxAddPizza.TabIndex = 4;
            groupBoxAddPizza.TabStop = false;
            groupBoxAddPizza.Text = "Adicionar Pizza";
            // 
            // buttoneditarPizzas
            // 
            buttoneditarPizzas.BackColor = Color.Gray;
            buttoneditarPizzas.FlatAppearance.BorderColor = Color.Gray;
            buttoneditarPizzas.FlatAppearance.BorderSize = 0;
            buttoneditarPizzas.FlatStyle = FlatStyle.Flat;
            buttoneditarPizzas.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttoneditarPizzas.ForeColor = Color.White;
            buttoneditarPizzas.ImageAlign = ContentAlignment.MiddleLeft;
            buttoneditarPizzas.Location = new Point(459, 353);
            buttoneditarPizzas.Name = "buttoneditarPizzas";
            buttoneditarPizzas.Size = new Size(80, 32);
            buttoneditarPizzas.TabIndex = 82;
            buttoneditarPizzas.Text = "Editar";
            buttoneditarPizzas.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttoneditarPizzas.UseVisualStyleBackColor = false;
            buttoneditarPizzas.Click += buttoneditarPizzas_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(165, 335);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 81;
            label5.Text = "Valor da borda";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(35, 336);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 80;
            label4.Text = "Valor da Pizza";
            // 
            // textBoxValorBorda
            // 
            textBoxValorBorda.Location = new Point(165, 353);
            textBoxValorBorda.Name = "textBoxValorBorda";
            textBoxValorBorda.ReadOnly = true;
            textBoxValorBorda.Size = new Size(89, 23);
            textBoxValorBorda.TabIndex = 10;
            // 
            // textBoxValorPizza
            // 
            textBoxValorPizza.Location = new Point(35, 353);
            textBoxValorPizza.Name = "textBoxValorPizza";
            textBoxValorPizza.ReadOnly = true;
            textBoxValorPizza.Size = new Size(89, 23);
            textBoxValorPizza.TabIndex = 9;
            // 
            // buttonAddPizza
            // 
            buttonAddPizza.BackColor = Color.DodgerBlue;
            buttonAddPizza.FlatAppearance.BorderColor = Color.Gray;
            buttonAddPizza.FlatAppearance.BorderSize = 0;
            buttonAddPizza.FlatStyle = FlatStyle.Flat;
            buttonAddPizza.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddPizza.ForeColor = Color.White;
            buttonAddPizza.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddPizza.Location = new Point(362, 353);
            buttonAddPizza.Name = "buttonAddPizza";
            buttonAddPizza.Size = new Size(91, 32);
            buttonAddPizza.TabIndex = 8;
            buttonAddPizza.Text = "Adicionar";
            buttonAddPizza.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAddPizza.UseVisualStyleBackColor = false;
            buttonAddPizza.Click += ButtonAddPizza_Click;
            // 
            // groupBoxIngredientes
            // 
            groupBoxIngredientes.Controls.Add(checkedListBoxIngredientes);
            groupBoxIngredientes.ForeColor = SystemColors.ControlLightLight;
            groupBoxIngredientes.Location = new Point(289, 15);
            groupBoxIngredientes.Name = "groupBoxIngredientes";
            groupBoxIngredientes.Size = new Size(248, 315);
            groupBoxIngredientes.TabIndex = 7;
            groupBoxIngredientes.TabStop = false;
            groupBoxIngredientes.Text = "Ingredientes";
            // 
            // checkedListBoxIngredientes
            // 
            checkedListBoxIngredientes.FormattingEnabled = true;
            checkedListBoxIngredientes.Location = new Point(20, 30);
            checkedListBoxIngredientes.Name = "checkedListBoxIngredientes";
            checkedListBoxIngredientes.Size = new Size(208, 256);
            checkedListBoxIngredientes.TabIndex = 0;
            // 
            // groupBoxSabor
            // 
            groupBoxSabor.Controls.Add(comboBoxSaborBorda);
            groupBoxSabor.Controls.Add(checkBoxBorda);
            groupBoxSabor.Controls.Add(checkBoxUnicoSabor);
            groupBoxSabor.Controls.Add(labelSabor3);
            groupBoxSabor.Controls.Add(comboBoxSabor3);
            groupBoxSabor.Controls.Add(labelSabor2);
            groupBoxSabor.Controls.Add(comboBoxSabor2);
            groupBoxSabor.Controls.Add(labelSabor1);
            groupBoxSabor.Controls.Add(comboBoxSabor1);
            groupBoxSabor.ForeColor = SystemColors.ControlLightLight;
            groupBoxSabor.Location = new Point(15, 95);
            groupBoxSabor.Name = "groupBoxSabor";
            groupBoxSabor.Size = new Size(268, 235);
            groupBoxSabor.TabIndex = 6;
            groupBoxSabor.TabStop = false;
            // 
            // comboBoxSaborBorda
            // 
            comboBoxSaborBorda.Enabled = false;
            comboBoxSaborBorda.FormattingEnabled = true;
            comboBoxSaborBorda.Items.AddRange(new object[] { "Catupiry", "Cheddar", "Requeijão", "Chocolate Branco", "Chocolate Preto" });
            comboBoxSaborBorda.Location = new Point(118, 194);
            comboBoxSaborBorda.Name = "comboBoxSaborBorda";
            comboBoxSaborBorda.Size = new Size(121, 23);
            comboBoxSaborBorda.TabIndex = 87;
            // 
            // checkBoxBorda
            // 
            checkBoxBorda.AutoSize = true;
            checkBoxBorda.Location = new Point(20, 196);
            checkBoxBorda.Name = "checkBoxBorda";
            checkBoxBorda.Size = new Size(89, 19);
            checkBoxBorda.TabIndex = 86;
            checkBoxBorda.Text = "Com borda.";
            checkBoxBorda.UseVisualStyleBackColor = true;
            // 
            // checkBoxUnicoSabor
            // 
            checkBoxUnicoSabor.AutoSize = true;
            checkBoxUnicoSabor.Checked = true;
            checkBoxUnicoSabor.CheckState = CheckState.Checked;
            checkBoxUnicoSabor.Location = new Point(20, 22);
            checkBoxUnicoSabor.Name = "checkBoxUnicoSabor";
            checkBoxUnicoSabor.Size = new Size(136, 19);
            checkBoxUnicoSabor.TabIndex = 84;
            checkBoxUnicoSabor.Text = "Pizza de único sabor.";
            checkBoxUnicoSabor.UseVisualStyleBackColor = true;
            // 
            // labelSabor3
            // 
            labelSabor3.AutoSize = true;
            labelSabor3.BackColor = Color.Transparent;
            labelSabor3.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelSabor3.ForeColor = SystemColors.ButtonHighlight;
            labelSabor3.Location = new Point(20, 132);
            labelSabor3.Name = "labelSabor3";
            labelSabor3.Size = new Size(48, 15);
            labelSabor3.TabIndex = 83;
            labelSabor3.Text = "Sabor 3";
            // 
            // comboBoxSabor3
            // 
            comboBoxSabor3.Enabled = false;
            comboBoxSabor3.FormattingEnabled = true;
            comboBoxSabor3.Items.AddRange(new object[] { "Pequena", "Média", "Grande", "Família" });
            comboBoxSabor3.Location = new Point(20, 150);
            comboBoxSabor3.Name = "comboBoxSabor3";
            comboBoxSabor3.Size = new Size(219, 23);
            comboBoxSabor3.TabIndex = 82;
            // 
            // labelSabor2
            // 
            labelSabor2.AutoSize = true;
            labelSabor2.BackColor = Color.Transparent;
            labelSabor2.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelSabor2.ForeColor = SystemColors.ControlLightLight;
            labelSabor2.Location = new Point(20, 88);
            labelSabor2.Name = "labelSabor2";
            labelSabor2.Size = new Size(48, 15);
            labelSabor2.TabIndex = 81;
            labelSabor2.Text = "Sabor 2";
            // 
            // comboBoxSabor2
            // 
            comboBoxSabor2.Enabled = false;
            comboBoxSabor2.FormattingEnabled = true;
            comboBoxSabor2.Items.AddRange(new object[] { "Pequena", "Média", "Grande", "Família" });
            comboBoxSabor2.Location = new Point(20, 106);
            comboBoxSabor2.Name = "comboBoxSabor2";
            comboBoxSabor2.Size = new Size(219, 23);
            comboBoxSabor2.TabIndex = 80;
            // 
            // labelSabor1
            // 
            labelSabor1.AutoSize = true;
            labelSabor1.BackColor = Color.Transparent;
            labelSabor1.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelSabor1.ForeColor = SystemColors.ControlLightLight;
            labelSabor1.Location = new Point(20, 44);
            labelSabor1.Name = "labelSabor1";
            labelSabor1.Size = new Size(46, 15);
            labelSabor1.TabIndex = 79;
            labelSabor1.Text = "Sabor 1";
            // 
            // comboBoxSabor1
            // 
            comboBoxSabor1.FormattingEnabled = true;
            comboBoxSabor1.Items.AddRange(new object[] { "Pequena", "Média", "Grande", "Família" });
            comboBoxSabor1.Location = new Point(20, 62);
            comboBoxSabor1.Name = "comboBoxSabor1";
            comboBoxSabor1.Size = new Size(219, 23);
            comboBoxSabor1.TabIndex = 78;
            comboBoxSabor1.SelectedIndexChanged += ComboBoxSabor1_SelectedIndexChanged;
            // 
            // groupBoxTamanhoPizza
            // 
            groupBoxTamanhoPizza.Controls.Add(labelTamanho);
            groupBoxTamanhoPizza.Controls.Add(comboBoxTamanho);
            groupBoxTamanhoPizza.ForeColor = SystemColors.ControlLightLight;
            groupBoxTamanhoPizza.Location = new Point(15, 15);
            groupBoxTamanhoPizza.Name = "groupBoxTamanhoPizza";
            groupBoxTamanhoPizza.Size = new Size(268, 74);
            groupBoxTamanhoPizza.TabIndex = 5;
            groupBoxTamanhoPizza.TabStop = false;
            // 
            // labelTamanho
            // 
            labelTamanho.AutoSize = true;
            labelTamanho.BackColor = Color.Transparent;
            labelTamanho.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelTamanho.ForeColor = SystemColors.ControlLightLight;
            labelTamanho.Location = new Point(20, 15);
            labelTamanho.Name = "labelTamanho";
            labelTamanho.Size = new Size(57, 15);
            labelTamanho.TabIndex = 77;
            labelTamanho.Text = "Tamanho";
            // 
            // comboBoxTamanho
            // 
            comboBoxTamanho.FormattingEnabled = true;
            comboBoxTamanho.Items.AddRange(new object[] { "Pequena", "Média", "Grande", "Família" });
            comboBoxTamanho.Location = new Point(20, 33);
            comboBoxTamanho.Name = "comboBoxTamanho";
            comboBoxTamanho.Size = new Size(105, 23);
            comboBoxTamanho.TabIndex = 0;
            comboBoxTamanho.Leave += ComboBoxTamanho_Leave;
            // 
            // groupBoxEndereco
            // 
            groupBoxEndereco.Controls.Add(textBoxEnderecoID);
            groupBoxEndereco.Controls.Add(label6);
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
            groupBoxEndereco.ForeColor = SystemColors.ControlLightLight;
            groupBoxEndereco.Location = new Point(75, 148);
            groupBoxEndereco.Name = "groupBoxEndereco";
            groupBoxEndereco.Size = new Size(268, 248);
            groupBoxEndereco.TabIndex = 2;
            groupBoxEndereco.TabStop = false;
            groupBoxEndereco.Text = "Endereço";
            // 
            // textBoxEnderecoID
            // 
            textBoxEnderecoID.Location = new Point(195, 37);
            textBoxEnderecoID.Name = "textBoxEnderecoID";
            textBoxEnderecoID.ReadOnly = true;
            textBoxEnderecoID.Size = new Size(50, 23);
            textBoxEnderecoID.TabIndex = 80;
            textBoxEnderecoID.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(195, 19);
            label6.Name = "label6";
            label6.Size = new Size(20, 15);
            label6.TabIndex = 79;
            label6.Text = "ID";
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
            textBoxPais.Location = new Point(121, 204);
            textBoxPais.Name = "textBoxPais";
            textBoxPais.Size = new Size(124, 23);
            textBoxPais.TabIndex = 13;
            // 
            // labelPais
            // 
            labelPais.AutoSize = true;
            labelPais.BackColor = Color.Transparent;
            labelPais.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelPais.ForeColor = SystemColors.ControlLightLight;
            labelPais.Location = new Point(121, 186);
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
            labelUF.ForeColor = SystemColors.ControlLightLight;
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
            textBoxComplemento.Size = new Size(154, 23);
            textBoxComplemento.TabIndex = 8;
            // 
            // labelComplemento
            // 
            labelComplemento.AutoSize = true;
            labelComplemento.BackColor = Color.Transparent;
            labelComplemento.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelComplemento.ForeColor = SystemColors.ControlLightLight;
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
            textBoxCidade.Size = new Size(95, 23);
            textBoxCidade.TabIndex = 10;
            // 
            // labelCidade
            // 
            labelCidade.AutoSize = true;
            labelCidade.BackColor = Color.Transparent;
            labelCidade.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCidade.ForeColor = SystemColors.ControlLightLight;
            labelCidade.Location = new Point(20, 142);
            labelCidade.Name = "labelCidade";
            labelCidade.Size = new Size(43, 15);
            labelCidade.TabIndex = 62;
            labelCidade.Text = "Cidade";
            // 
            // textBoxBairro
            // 
            textBoxBairro.Location = new Point(121, 160);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(124, 23);
            textBoxBairro.TabIndex = 11;
            // 
            // labelBairro
            // 
            labelBairro.AutoSize = true;
            labelBairro.BackColor = Color.Transparent;
            labelBairro.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelBairro.ForeColor = SystemColors.ControlLightLight;
            labelBairro.Location = new Point(121, 142);
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
            labelNumero.ForeColor = SystemColors.ControlLightLight;
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
            textBoxLogradouro.Size = new Size(154, 23);
            textBoxLogradouro.TabIndex = 6;
            // 
            // labelLogradouro
            // 
            labelLogradouro.AutoSize = true;
            labelLogradouro.BackColor = Color.Transparent;
            labelLogradouro.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelLogradouro.ForeColor = SystemColors.ControlLightLight;
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
            labelCEP.ForeColor = SystemColors.ControlLightLight;
            labelCEP.Location = new Point(20, 54);
            labelCEP.Name = "labelCEP";
            labelCEP.Size = new Size(27, 15);
            labelCEP.TabIndex = 55;
            labelCEP.Text = "CEP";
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
            buttonSalvar.Location = new Point(765, 497);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(80, 38);
            buttonSalvar.TabIndex = 6;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSalvar.UseVisualStyleBackColor = false;
            // 
            // groupBoxCliente
            // 
            groupBoxCliente.Controls.Add(maskedTextBoxTel);
            groupBoxCliente.Controls.Add(labelTel);
            groupBoxCliente.Controls.Add(maskedTextBoxCPF);
            groupBoxCliente.Controls.Add(labelCPF);
            groupBoxCliente.Controls.Add(textBoxIDCliente);
            groupBoxCliente.Controls.Add(labelID);
            groupBoxCliente.Controls.Add(textBoxNome);
            groupBoxCliente.Controls.Add(labelNome);
            groupBoxCliente.ForeColor = SystemColors.ControlLightLight;
            groupBoxCliente.Location = new Point(75, 19);
            groupBoxCliente.Name = "groupBoxCliente";
            groupBoxCliente.Size = new Size(268, 123);
            groupBoxCliente.TabIndex = 1;
            groupBoxCliente.TabStop = false;
            groupBoxCliente.Text = "Cliente";
            // 
            // maskedTextBoxTel
            // 
            maskedTextBoxTel.Location = new Point(108, 92);
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
            labelTel.ForeColor = SystemColors.ControlLightLight;
            labelTel.Location = new Point(108, 74);
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
            labelCPF.ForeColor = SystemColors.ControlLightLight;
            labelCPF.Location = new Point(20, 74);
            labelCPF.Name = "labelCPF";
            labelCPF.Size = new Size(27, 15);
            labelCPF.TabIndex = 81;
            labelCPF.Text = "CPF";
            // 
            // textBoxIDCliente
            // 
            textBoxIDCliente.Location = new Point(20, 48);
            textBoxIDCliente.Name = "textBoxIDCliente";
            textBoxIDCliente.ReadOnly = true;
            textBoxIDCliente.Size = new Size(50, 23);
            textBoxIDCliente.TabIndex = 78;
            textBoxIDCliente.TabStop = false;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.BackColor = Color.Transparent;
            labelID.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelID.ForeColor = SystemColors.ControlLightLight;
            labelID.Location = new Point(20, 30);
            labelID.Name = "labelID";
            labelID.Size = new Size(20, 15);
            labelID.TabIndex = 77;
            labelID.Text = "ID";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(79, 48);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(166, 23);
            textBoxNome.TabIndex = 1;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.BackColor = Color.Transparent;
            labelNome.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNome.ForeColor = SystemColors.ControlLightLight;
            labelNome.Location = new Point(79, 30);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(95, 15);
            labelNome.TabIndex = 76;
            labelNome.Text = "Nome Completo";
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
            buttonEditarFechar.Location = new Point(937, 497);
            buttonEditarFechar.Name = "buttonEditarFechar";
            buttonEditarFechar.Size = new Size(80, 38);
            buttonEditarFechar.TabIndex = 7;
            buttonEditarFechar.Text = "Fechar";
            buttonEditarFechar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonEditarFechar.UseVisualStyleBackColor = false;
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
            menu1.Size = new Size(200, 700);
            menu1.TabIndex = 10;
            // 
            // panelEditarItens
            // 
            panelEditarItens.Controls.Add(buttonEditarItensFechar);
            panelEditarItens.Controls.Add(groupBoxPizzas);
            panelEditarItens.Controls.Add(groupBoxProdutos);
            panelEditarItens.Location = new Point(38, 19);
            panelEditarItens.Name = "panelEditarItens";
            panelEditarItens.Size = new Size(750, 500);
            panelEditarItens.TabIndex = 87;
            // 
            // checkedListBoxProdutos
            // 
            checkedListBoxProdutos.FormattingEnabled = true;
            checkedListBoxProdutos.Location = new Point(23, 37);
            checkedListBoxProdutos.Name = "checkedListBoxProdutos";
            checkedListBoxProdutos.Size = new Size(177, 256);
            checkedListBoxProdutos.TabIndex = 0;
            // 
            // comboBoxPizzas
            // 
            comboBoxPizzas.FormattingEnabled = true;
            comboBoxPizzas.Location = new Point(19, 37);
            comboBoxPizzas.Name = "comboBoxPizzas";
            comboBoxPizzas.Size = new Size(121, 23);
            comboBoxPizzas.TabIndex = 1;
            // 
            // groupBoxProdutos
            // 
            groupBoxProdutos.Controls.Add(checkedListBoxProdutos);
            groupBoxProdutos.ForeColor = SystemColors.ControlLightLight;
            groupBoxProdutos.Location = new Point(27, 15);
            groupBoxProdutos.Name = "groupBoxProdutos";
            groupBoxProdutos.Size = new Size(225, 405);
            groupBoxProdutos.TabIndex = 84;
            groupBoxProdutos.TabStop = false;
            groupBoxProdutos.Text = "Produtos";
            // 
            // groupBoxPizzas
            // 
            groupBoxPizzas.Controls.Add(label7);
            groupBoxPizzas.Controls.Add(comboBox1);
            groupBoxPizzas.Controls.Add(labelPizzas);
            groupBoxPizzas.Controls.Add(comboBoxPizzas);
            groupBoxPizzas.ForeColor = SystemColors.ControlLightLight;
            groupBoxPizzas.Location = new Point(269, 15);
            groupBoxPizzas.Name = "groupBoxPizzas";
            groupBoxPizzas.Size = new Size(457, 405);
            groupBoxPizzas.TabIndex = 85;
            groupBoxPizzas.TabStop = false;
            groupBoxPizzas.Text = "Pizzas";
            // 
            // labelPizzas
            // 
            labelPizzas.AutoSize = true;
            labelPizzas.BackColor = Color.Transparent;
            labelPizzas.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelPizzas.ForeColor = SystemColors.ControlLightLight;
            labelPizzas.Location = new Point(19, 19);
            labelPizzas.Name = "labelPizzas";
            labelPizzas.Size = new Size(40, 15);
            labelPizzas.TabIndex = 82;
            labelPizzas.Text = "Pizzas";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(169, 37);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 83;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(169, 19);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 84;
            label7.Text = "Pizzas";
            // 
            // buttonEditarItensFechar
            // 
            buttonEditarItensFechar.BackColor = Color.Gray;
            buttonEditarItensFechar.FlatAppearance.BorderColor = Color.Gray;
            buttonEditarItensFechar.FlatAppearance.BorderSize = 0;
            buttonEditarItensFechar.FlatStyle = FlatStyle.Flat;
            buttonEditarItensFechar.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEditarItensFechar.ForeColor = Color.White;
            buttonEditarItensFechar.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEditarItensFechar.Location = new Point(646, 444);
            buttonEditarItensFechar.Name = "buttonEditarItensFechar";
            buttonEditarItensFechar.Size = new Size(80, 38);
            buttonEditarItensFechar.TabIndex = 86;
            buttonEditarItensFechar.Text = "Fechar";
            buttonEditarItensFechar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonEditarItensFechar.UseVisualStyleBackColor = false;
            buttonEditarItensFechar.Click += buttonEditarItensFechar_Click;
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
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListaPedidos";
            panelLista.ResumeLayout(false);
            panelEditar.ResumeLayout(false);
            panelEditar.PerformLayout();
            groupBoxProduto.ResumeLayout(false);
            groupBoxProduto.PerformLayout();
            groupBoxAddPizza.ResumeLayout(false);
            groupBoxAddPizza.PerformLayout();
            groupBoxIngredientes.ResumeLayout(false);
            groupBoxSabor.ResumeLayout(false);
            groupBoxSabor.PerformLayout();
            groupBoxTamanhoPizza.ResumeLayout(false);
            groupBoxTamanhoPizza.PerformLayout();
            groupBoxEndereco.ResumeLayout(false);
            groupBoxEndereco.PerformLayout();
            groupBoxCliente.ResumeLayout(false);
            groupBoxCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelEditarItens.ResumeLayout(false);
            groupBoxProdutos.ResumeLayout(false);
            groupBoxPizzas.ResumeLayout(false);
            groupBoxPizzas.PerformLayout();
            ResumeLayout(false);
        }

        private void ComboBoxSabor1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonAddPizza_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
        private Panel panelEditar;
        internal MaskedTextBox maskedTextBoxValorPedido;
        internal Label label3;
        private GroupBox groupBoxProduto;
        internal Label labelValorProduto;
        internal TextBox textBoxValorProduto;
        internal ComboBox comboBoxML;
        internal Label labelML;
        internal TextBox textBoxIDProduto;
        internal Label label2;
        internal Label labelProduto;
        internal Button buttonAddProduto;
        internal Label label1;
        private ComboBox comboBoxProduto;
        internal TextBox textBoxIDPedido;
        internal Label labelIDPedido;
        private GroupBox groupBoxAddPizza;
        internal Label label5;
        internal Label label4;
        internal TextBox textBoxValorBorda;
        internal TextBox textBoxValorPizza;
        internal Button buttonAddPizza;
        private GroupBox groupBoxIngredientes;
        private CheckedListBox checkedListBoxIngredientes;
        private GroupBox groupBoxSabor;
        private ComboBox comboBoxSaborBorda;
        private CheckBox checkBoxBorda;
        private CheckBox checkBoxUnicoSabor;
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
        internal TextBox textBoxEnderecoID;
        internal Label label6;
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
        internal TextBox textBoxIDCliente;
        internal Label labelID;
        internal TextBox textBoxNome;
        internal Label labelNome;
        internal Button buttonSalvar;
        private Button buttonEditarFechar;
        private Button buttonExcluir;
        private Button buttonEditarProdutos;
        private Button buttoneditarPizzas;
        private Panel panelEditarItens;
        private ComboBox comboBoxPizzas;
        private CheckedListBox checkedListBoxProdutos;
        private GroupBox groupBoxPizzas;
        internal Label labelPizzas;
        private GroupBox groupBoxProdutos;
        private ComboBox comboBox1;
        private Button buttonEditarItensFechar;
        internal Label label7;
    }
}