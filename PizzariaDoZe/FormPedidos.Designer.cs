namespace PizzariaDoZe
{
    partial class FormPedidos
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
            panelCadastrar = new Panel();
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
            labelObsTamanho = new Label();
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
            buttonCadastrar = new Button();
            buttonFechar = new Button();
            panel1 = new Panel();
            labelPedido = new Label();
            menu1 = new Menu();
            textBoxIDPedido = new TextBox();
            labelIDPedido = new Label();
            groupBoxProduto = new GroupBox();
            textBox1 = new TextBox();
            label2 = new Label();
            labelML = new Label();
            comboBoxML = new ComboBox();
            labelProduto = new Label();
            buttonProximoProduto = new Button();
            label1 = new Label();
            comboBoxProduto = new ComboBox();
            panelCadastrar.SuspendLayout();
            groupBoxAddPizza.SuspendLayout();
            groupBoxIngredientes.SuspendLayout();
            groupBoxSabor.SuspendLayout();
            groupBoxTamanhoPizza.SuspendLayout();
            groupBoxEndereco.SuspendLayout();
            groupBoxCliente.SuspendLayout();
            panel1.SuspendLayout();
            groupBoxProduto.SuspendLayout();
            SuspendLayout();
            // 
            // panelCadastrar
            // 
            panelCadastrar.BackColor = Color.White;
            panelCadastrar.Controls.Add(groupBoxProduto);
            panelCadastrar.Controls.Add(textBoxIDPedido);
            panelCadastrar.Controls.Add(labelIDPedido);
            panelCadastrar.Controls.Add(groupBoxAddPizza);
            panelCadastrar.Controls.Add(groupBoxEndereco);
            panelCadastrar.Controls.Add(groupBoxCliente);
            panelCadastrar.Controls.Add(buttonCadastrar);
            panelCadastrar.Controls.Add(buttonFechar);
            panelCadastrar.Dock = DockStyle.Fill;
            panelCadastrar.Location = new Point(200, 100);
            panelCadastrar.Name = "panelCadastrar";
            panelCadastrar.Size = new Size(1064, 581);
            panelCadastrar.TabIndex = 5;
            // 
            // groupBoxAddPizza
            // 
            groupBoxAddPizza.Controls.Add(buttonProximaPizza);
            groupBoxAddPizza.Controls.Add(groupBoxIngredientes);
            groupBoxAddPizza.Controls.Add(groupBoxSabor);
            groupBoxAddPizza.Controls.Add(groupBoxTamanhoPizza);
            groupBoxAddPizza.Location = new Point(358, 22);
            groupBoxAddPizza.Name = "groupBoxAddPizza";
            groupBoxAddPizza.Size = new Size(664, 415);
            groupBoxAddPizza.TabIndex = 4;
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
            labelSabor3.Location = new Point(20, 118);
            labelSabor3.Name = "labelSabor3";
            labelSabor3.Size = new Size(48, 15);
            labelSabor3.TabIndex = 83;
            labelSabor3.Text = "Sabor 3";
            // 
            // comboBoxSabor3
            // 
            comboBoxSabor3.FormattingEnabled = true;
            comboBoxSabor3.Items.AddRange(new object[] { "Pequena", "Média", "Grande", "Família" });
            comboBoxSabor3.Location = new Point(20, 136);
            comboBoxSabor3.Name = "comboBoxSabor3";
            comboBoxSabor3.Size = new Size(280, 23);
            comboBoxSabor3.TabIndex = 82;
            // 
            // labelSabor2
            // 
            labelSabor2.AutoSize = true;
            labelSabor2.BackColor = Color.Transparent;
            labelSabor2.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelSabor2.ForeColor = SystemColors.ActiveCaptionText;
            labelSabor2.Location = new Point(20, 74);
            labelSabor2.Name = "labelSabor2";
            labelSabor2.Size = new Size(48, 15);
            labelSabor2.TabIndex = 81;
            labelSabor2.Text = "Sabor 2";
            // 
            // comboBoxSabor2
            // 
            comboBoxSabor2.FormattingEnabled = true;
            comboBoxSabor2.Items.AddRange(new object[] { "Pequena", "Média", "Grande", "Família" });
            comboBoxSabor2.Location = new Point(20, 92);
            comboBoxSabor2.Name = "comboBoxSabor2";
            comboBoxSabor2.Size = new Size(280, 23);
            comboBoxSabor2.TabIndex = 80;
            // 
            // labelSabor1
            // 
            labelSabor1.AutoSize = true;
            labelSabor1.BackColor = Color.Transparent;
            labelSabor1.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelSabor1.ForeColor = SystemColors.ActiveCaptionText;
            labelSabor1.Location = new Point(20, 30);
            labelSabor1.Name = "labelSabor1";
            labelSabor1.Size = new Size(46, 15);
            labelSabor1.TabIndex = 79;
            labelSabor1.Text = "Sabor 1";
            // 
            // comboBoxSabor1
            // 
            comboBoxSabor1.FormattingEnabled = true;
            comboBoxSabor1.Items.AddRange(new object[] { "Pequena", "Média", "Grande", "Família" });
            comboBoxSabor1.Location = new Point(20, 48);
            comboBoxSabor1.Name = "comboBoxSabor1";
            comboBoxSabor1.Size = new Size(280, 23);
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
            // labelObsTamanho
            // 
            labelObsTamanho.AutoSize = true;
            labelObsTamanho.Location = new Point(168, 49);
            labelObsTamanho.Name = "labelObsTamanho";
            labelObsTamanho.Size = new Size(123, 15);
            labelObsTamanho.TabIndex = 78;
            labelObsTamanho.Text = "Pode Escolher 1 Sabor";
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
            groupBoxEndereco.Location = new Point(32, 151);
            groupBoxEndereco.Name = "groupBoxEndereco";
            groupBoxEndereco.Size = new Size(315, 248);
            groupBoxEndereco.TabIndex = 2;
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
            groupBoxCliente.Location = new Point(32, 22);
            groupBoxCliente.Name = "groupBoxCliente";
            groupBoxCliente.Size = new Size(315, 123);
            groupBoxCliente.TabIndex = 1;
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
            // buttonCadastrar
            // 
            buttonCadastrar.BackColor = Color.Green;
            buttonCadastrar.FlatAppearance.BorderColor = Color.Gray;
            buttonCadastrar.FlatAppearance.BorderSize = 0;
            buttonCadastrar.FlatStyle = FlatStyle.Flat;
            buttonCadastrar.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCadastrar.ForeColor = Color.White;
            buttonCadastrar.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCadastrar.Location = new Point(827, 497);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(104, 38);
            buttonCadastrar.TabIndex = 6;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCadastrar.UseVisualStyleBackColor = false;
            buttonCadastrar.Click += buttonCadastrar_Click;
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
            buttonFechar.TabIndex = 7;
            buttonFechar.Text = "Fechar";
            buttonFechar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonFechar.UseVisualStyleBackColor = false;
            buttonFechar.Click += buttonFechar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 51);
            panel1.Controls.Add(labelPedido);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(200, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1064, 100);
            panel1.TabIndex = 4;
            // 
            // labelPedido
            // 
            labelPedido.AutoSize = true;
            labelPedido.Font = new Font("Yu Gothic UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelPedido.ForeColor = SystemColors.ControlLightLight;
            labelPedido.Location = new Point(32, 28);
            labelPedido.Name = "labelPedido";
            labelPedido.Size = new Size(269, 45);
            labelPedido.TabIndex = 1;
            labelPedido.Text = "Cadastrar Pedido";
            labelPedido.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // menu1
            // 
            menu1.Dock = DockStyle.Left;
            menu1.Location = new Point(0, 0);
            menu1.Name = "menu1";
            menu1.Size = new Size(200, 681);
            menu1.TabIndex = 3;
            // 
            // textBoxIDPedido
            // 
            textBoxIDPedido.Location = new Point(358, 486);
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
            labelIDPedido.ForeColor = SystemColors.ActiveCaptionText;
            labelIDPedido.Location = new Point(358, 468);
            labelIDPedido.Name = "labelIDPedido";
            labelIDPedido.Size = new Size(20, 15);
            labelIDPedido.TabIndex = 79;
            labelIDPedido.Text = "ID";
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
            groupBoxProduto.Location = new Point(32, 405);
            groupBoxProduto.Name = "groupBoxProduto";
            groupBoxProduto.Size = new Size(315, 130);
            groupBoxProduto.TabIndex = 81;
            groupBoxProduto.TabStop = false;
            groupBoxProduto.Text = "Produto";
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
            // FormPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(panelCadastrar);
            Controls.Add(panel1);
            Controls.Add(menu1);
            Name = "FormPedidos";
            Text = "FormPedidos";
            panelCadastrar.ResumeLayout(false);
            panelCadastrar.PerformLayout();
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBoxProduto.ResumeLayout(false);
            groupBoxProduto.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCadastrar;
        private Button buttonFechar;
        private Panel panel1;
        private Label labelPedido;
        private Menu menu1;
        internal Button buttonCadastrar;
        private GroupBox groupBoxCliente;
        internal MaskedTextBox maskedTextBoxCPF;
        internal Label labelCPF;
        internal TextBox textBoxID;
        internal Label labelID;
        internal TextBox textBoxNome;
        internal Label labelNome;
        internal MaskedTextBox maskedTextBoxTel;
        internal Label labelTel;
        private GroupBox groupBoxEndereco;
        internal MaskedTextBox maskedTextBoxCEP;
        internal TextBox textBoxLogradouro;
        internal Label labelLogradouro;
        internal Label labelCEP;
        internal TextBox textBoxNumero;
        internal Label labelNumero;
        internal TextBox textBoxBairro;
        internal Label labelBairro;
        internal TextBox textBoxCidade;
        internal Label labelCidade;
        internal TextBox textBoxComplemento;
        internal Label labelComplemento;
        internal ComboBox comboBoxUF;
        internal Label labelUF;
        internal TextBox textBoxPais;
        internal Label labelPais;
        private GroupBox groupBoxAddPizza;
        private GroupBox groupBoxIngredientes;
        private CheckedListBox checkedListBoxIngredientes;
        private GroupBox groupBoxSabor;
        private CheckBox checkBoxInteira;
        internal Label labelSabor3;
        private ComboBox comboBoxSabor3;
        internal Label labelSabor2;
        private ComboBox comboBoxSabor2;
        internal Label labelSabor1;
        private ComboBox comboBoxSabor1;
        private GroupBox groupBoxTamanhoPizza;
        private Label labelObsTamanho;
        internal Label labelTamanho;
        private ComboBox comboBoxTamanho;
        internal Button buttonProximaPizza;
        private CheckBox checkBoxBorda;
        private CheckBox checkBoxEntregar;
        internal TextBox textBoxIDPedido;
        internal Label labelIDPedido;
        private GroupBox groupBoxProduto;
        internal TextBox textBox1;
        internal Label label2;
        internal Label labelML;
        private ComboBox comboBoxML;
        internal Label labelProduto;
        internal Button buttonProximoProduto;
        internal Label label1;
        private ComboBox comboBoxProduto;
    }
}