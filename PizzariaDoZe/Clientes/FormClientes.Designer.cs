namespace PizzariaDoZe
{
    partial class FormClientes
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
            menu1 = new Menu();
            panel1 = new Panel();
            labelClientes = new Label();
            labelNome = new Label();
            textBoxNome = new TextBox();
            labelID = new Label();
            textBoxID = new TextBox();
            labelCPF = new Label();
            maskedTextBoxCPF = new MaskedTextBox();
            labelEmail = new Label();
            textBoxEmail = new TextBox();
            labelTel = new Label();
            maskedTextBoxTel = new MaskedTextBox();
            labelCEP = new Label();
            maskedTextBoxCEP = new MaskedTextBox();
            label2 = new Label();
            textBoxLograd = new TextBox();
            labelNumero = new Label();
            textBoxNumero = new TextBox();
            labelCidade = new Label();
            textBoxCidade = new TextBox();
            labelComplemento = new Label();
            textBoxComplemento = new TextBox();
            labelBairro = new Label();
            textBoxBairro = new TextBox();
            labelUF = new Label();
            labelPais = new Label();
            textBoxPais = new TextBox();
            buttonFechar = new Button();
            buttonCadastrar = new Button();
            comboBoxUF = new ComboBox();
            labelEnderecoID = new Label();
            textBoxEnderecoID = new TextBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // menu1
            // 
            menu1.Dock = DockStyle.Left;
            menu1.Location = new Point(0, 0);
            menu1.Name = "menu1";
            menu1.Size = new Size(200, 599);
            menu1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 51);
            panel1.Controls.Add(labelClientes);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(200, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(684, 100);
            panel1.TabIndex = 1;
            // 
            // labelClientes
            // 
            labelClientes.AutoSize = true;
            labelClientes.Font = new Font("Yu Gothic UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelClientes.ForeColor = SystemColors.ControlLightLight;
            labelClientes.Location = new Point(32, 28);
            labelClientes.Name = "labelClientes";
            labelClientes.Size = new Size(284, 45);
            labelClientes.TabIndex = 0;
            labelClientes.Text = "Cadastrar Clientes";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNome.Location = new Point(50, 30);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(95, 15);
            labelNome.TabIndex = 6;
            labelNome.Text = "Nome Completo";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(50, 48);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(200, 23);
            textBoxNome.TabIndex = 0;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelID.Location = new Point(50, 85);
            labelID.Name = "labelID";
            labelID.Size = new Size(20, 15);
            labelID.TabIndex = 8;
            labelID.Text = "ID";
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(50, 103);
            textBoxID.Name = "textBoxID";
            textBoxID.ReadOnly = true;
            textBoxID.Size = new Size(50, 23);
            textBoxID.TabIndex = 20;
            textBoxID.TabStop = false;
            // 
            // labelCPF
            // 
            labelCPF.AutoSize = true;
            labelCPF.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCPF.Location = new Point(116, 85);
            labelCPF.Name = "labelCPF";
            labelCPF.Size = new Size(27, 15);
            labelCPF.TabIndex = 10;
            labelCPF.Text = "CPF";
            // 
            // maskedTextBoxCPF
            // 
            maskedTextBoxCPF.Location = new Point(116, 103);
            maskedTextBoxCPF.Mask = "000.000.000-00";
            maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            maskedTextBoxCPF.Size = new Size(134, 23);
            maskedTextBoxCPF.TabIndex = 3;
            maskedTextBoxCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmail.Location = new Point(288, 30);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(41, 15);
            labelEmail.TabIndex = 12;
            labelEmail.Text = "E-mail";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(288, 48);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(200, 23);
            textBoxEmail.TabIndex = 1;
            // 
            // labelTel
            // 
            labelTel.AutoSize = true;
            labelTel.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelTel.Location = new Point(288, 85);
            labelTel.Name = "labelTel";
            labelTel.Size = new Size(52, 15);
            labelTel.TabIndex = 14;
            labelTel.Text = "Telefone";
            // 
            // maskedTextBoxTel
            // 
            maskedTextBoxTel.Location = new Point(288, 103);
            maskedTextBoxTel.Mask = "(00) 000-000-000";
            maskedTextBoxTel.Name = "maskedTextBoxTel";
            maskedTextBoxTel.Size = new Size(200, 23);
            maskedTextBoxTel.TabIndex = 4;
            maskedTextBoxTel.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // labelCEP
            // 
            labelCEP.AutoSize = true;
            labelCEP.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCEP.Location = new Point(116, 166);
            labelCEP.Name = "labelCEP";
            labelCEP.Size = new Size(27, 15);
            labelCEP.TabIndex = 15;
            labelCEP.Text = "CEP";
            // 
            // maskedTextBoxCEP
            // 
            maskedTextBoxCEP.Location = new Point(116, 184);
            maskedTextBoxCEP.Mask = "00000-000";
            maskedTextBoxCEP.Name = "maskedTextBoxCEP";
            maskedTextBoxCEP.Size = new Size(61, 23);
            maskedTextBoxCEP.TabIndex = 5;
            maskedTextBoxCEP.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(194, 166);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 17;
            label2.Text = "Logradouro";
            // 
            // textBoxLograd
            // 
            textBoxLograd.Location = new Point(194, 184);
            textBoxLograd.Name = "textBoxLograd";
            textBoxLograd.Size = new Size(294, 23);
            textBoxLograd.TabIndex = 6;
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNumero.Location = new Point(50, 224);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(51, 15);
            labelNumero.TabIndex = 19;
            labelNumero.Text = "Número";
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(50, 242);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(50, 23);
            textBoxNumero.TabIndex = 7;
            // 
            // labelCidade
            // 
            labelCidade.AutoSize = true;
            labelCidade.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCidade.Location = new Point(50, 287);
            labelCidade.Name = "labelCidade";
            labelCidade.Size = new Size(43, 15);
            labelCidade.TabIndex = 21;
            labelCidade.Text = "Cidade";
            // 
            // textBoxCidade
            // 
            textBoxCidade.Location = new Point(50, 305);
            textBoxCidade.Name = "textBoxCidade";
            textBoxCidade.Size = new Size(127, 23);
            textBoxCidade.TabIndex = 10;
            // 
            // labelComplemento
            // 
            labelComplemento.AutoSize = true;
            labelComplemento.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelComplemento.Location = new Point(268, 224);
            labelComplemento.Name = "labelComplemento";
            labelComplemento.Size = new Size(83, 15);
            labelComplemento.TabIndex = 27;
            labelComplemento.Text = "Complemento";
            // 
            // textBoxComplemento
            // 
            textBoxComplemento.Location = new Point(268, 242);
            textBoxComplemento.Name = "textBoxComplemento";
            textBoxComplemento.Size = new Size(220, 23);
            textBoxComplemento.TabIndex = 9;
            // 
            // labelBairro
            // 
            labelBairro.AutoSize = true;
            labelBairro.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelBairro.Location = new Point(116, 224);
            labelBairro.Name = "labelBairro";
            labelBairro.Size = new Size(38, 15);
            labelBairro.TabIndex = 29;
            labelBairro.Text = "Bairro";
            // 
            // textBoxBairro
            // 
            textBoxBairro.Location = new Point(116, 242);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(134, 23);
            textBoxBairro.TabIndex = 8;
            // 
            // labelUF
            // 
            labelUF.AutoSize = true;
            labelUF.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelUF.Location = new Point(194, 287);
            labelUF.Name = "labelUF";
            labelUF.Size = new Size(21, 15);
            labelUF.TabIndex = 31;
            labelUF.Text = "UF";
            // 
            // labelPais
            // 
            labelPais.AutoSize = true;
            labelPais.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelPais.Location = new Point(343, 287);
            labelPais.Name = "labelPais";
            labelPais.Size = new Size(28, 15);
            labelPais.TabIndex = 33;
            labelPais.Text = "País";
            // 
            // textBoxPais
            // 
            textBoxPais.Location = new Point(343, 305);
            textBoxPais.Name = "textBoxPais";
            textBoxPais.Size = new Size(145, 23);
            textBoxPais.TabIndex = 12;
            // 
            // buttonFechar
            // 
            buttonFechar.BackColor = Color.Firebrick;
            buttonFechar.FlatAppearance.BorderColor = Color.Gray;
            buttonFechar.FlatStyle = FlatStyle.Flat;
            buttonFechar.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFechar.ForeColor = Color.White;
            buttonFechar.ImageAlign = ContentAlignment.MiddleLeft;
            buttonFechar.Location = new Point(515, 440);
            buttonFechar.Name = "buttonFechar";
            buttonFechar.Size = new Size(80, 38);
            buttonFechar.TabIndex = 34;
            buttonFechar.Text = "Fechar";
            buttonFechar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonFechar.UseVisualStyleBackColor = false;
            buttonFechar.Click += buttonFechar_Click;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.BackColor = Color.DarkGreen;
            buttonCadastrar.FlatAppearance.BorderColor = Color.Gray;
            buttonCadastrar.FlatStyle = FlatStyle.Flat;
            buttonCadastrar.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCadastrar.ForeColor = Color.White;
            buttonCadastrar.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCadastrar.Location = new Point(400, 440);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(110, 38);
            buttonCadastrar.TabIndex = 70;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCadastrar.UseVisualStyleBackColor = false;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // comboBoxUF
            // 
            comboBoxUF.FormattingEnabled = true;
            comboBoxUF.Location = new Point(194, 305);
            comboBoxUF.Name = "comboBoxUF";
            comboBoxUF.Size = new Size(128, 23);
            comboBoxUF.TabIndex = 71;
            // 
            // labelEnderecoID
            // 
            labelEnderecoID.AutoSize = true;
            labelEnderecoID.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelEnderecoID.Location = new Point(50, 166);
            labelEnderecoID.Name = "labelEnderecoID";
            labelEnderecoID.Size = new Size(20, 15);
            labelEnderecoID.TabIndex = 72;
            labelEnderecoID.Text = "ID";
            // 
            // textBoxEnderecoID
            // 
            textBoxEnderecoID.Location = new Point(50, 184);
            textBoxEnderecoID.Name = "textBoxEnderecoID";
            textBoxEnderecoID.ReadOnly = true;
            textBoxEnderecoID.Size = new Size(50, 23);
            textBoxEnderecoID.TabIndex = 73;
            textBoxEnderecoID.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBoxEnderecoID);
            panel2.Controls.Add(labelEnderecoID);
            panel2.Controls.Add(comboBoxUF);
            panel2.Controls.Add(buttonCadastrar);
            panel2.Controls.Add(buttonFechar);
            panel2.Controls.Add(textBoxPais);
            panel2.Controls.Add(labelPais);
            panel2.Controls.Add(labelUF);
            panel2.Controls.Add(textBoxBairro);
            panel2.Controls.Add(labelBairro);
            panel2.Controls.Add(textBoxComplemento);
            panel2.Controls.Add(labelComplemento);
            panel2.Controls.Add(textBoxCidade);
            panel2.Controls.Add(labelCidade);
            panel2.Controls.Add(textBoxNumero);
            panel2.Controls.Add(labelNumero);
            panel2.Controls.Add(textBoxLograd);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(maskedTextBoxCEP);
            panel2.Controls.Add(labelCEP);
            panel2.Controls.Add(maskedTextBoxTel);
            panel2.Controls.Add(labelTel);
            panel2.Controls.Add(textBoxEmail);
            panel2.Controls.Add(labelEmail);
            panel2.Controls.Add(maskedTextBoxCPF);
            panel2.Controls.Add(labelCPF);
            panel2.Controls.Add(textBoxID);
            panel2.Controls.Add(labelID);
            panel2.Controls.Add(textBoxNome);
            panel2.Controls.Add(labelNome);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(200, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(684, 499);
            panel2.TabIndex = 2;
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(884, 599);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menu1);
            ForeColor = SystemColors.ControlText;
            MaximizeBox = false;
            Name = "FormClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Menu menu1;
        private Panel panel1;
        private Label labelClientes;
        private Label labelNome;
        private TextBox textBoxNome;
        private Label labelID;
        private TextBox textBoxID;
        private Label labelCPF;
        private MaskedTextBox maskedTextBoxCPF;
        private Label labelEmail;
        private TextBox textBoxEmail;
        private Label labelTel;
        private MaskedTextBox maskedTextBoxTel;
        private Label labelCEP;
        private MaskedTextBox maskedTextBoxCEP;
        private Label label2;
        private TextBox textBoxLograd;
        private Label labelNumero;
        private TextBox textBoxNumero;
        private Label labelCidade;
        private TextBox textBoxCidade;
        private Label labelComplemento;
        private TextBox textBoxComplemento;
        private Label labelBairro;
        private TextBox textBoxBairro;
        private Label labelUF;
        private Label labelPais;
        private TextBox textBoxPais;
        private Button buttonFechar;
        private Button buttonCadastrar;
        private ComboBox comboBoxUF;
        private Label labelEnderecoID;
        private TextBox textBoxEnderecoID;
        private Panel panel2;
    }
}