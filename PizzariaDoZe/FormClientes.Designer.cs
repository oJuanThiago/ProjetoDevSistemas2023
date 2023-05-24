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
            label1 = new Label();
            panel2 = new Panel();
            buttonCadastrar = new Button();
            buttonFechar = new Button();
            textBoxPais = new TextBox();
            labelPais = new Label();
            textBoxUF = new TextBox();
            labelUF = new Label();
            textBoxBairro = new TextBox();
            labelBairro = new Label();
            textBoxComplemento = new TextBox();
            labelComplemento = new Label();
            textBoxCidade = new TextBox();
            labelCidade = new Label();
            textBoxNumero = new TextBox();
            labelNumero = new Label();
            textBoxLograd = new TextBox();
            label2 = new Label();
            textBoxCEP = new TextBox();
            labelCEP = new Label();
            textBoxTel = new TextBox();
            labelTel = new Label();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            textBoxCPF = new TextBox();
            labelCPF = new Label();
            textBoxID = new TextBox();
            labelID = new Label();
            textBoxNome = new TextBox();
            labelNome = new Label();
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
            menu1.buttonClientes.Enabled = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 51);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(200, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(684, 100);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(32, 28);
            label1.Name = "label1";
            label1.Size = new Size(284, 45);
            label1.TabIndex = 0;
            label1.Text = "Cadastrar Clientes";
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonCadastrar);
            panel2.Controls.Add(buttonFechar);
            panel2.Controls.Add(textBoxPais);
            panel2.Controls.Add(labelPais);
            panel2.Controls.Add(textBoxUF);
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
            panel2.Controls.Add(textBoxCEP);
            panel2.Controls.Add(labelCEP);
            panel2.Controls.Add(textBoxTel);
            panel2.Controls.Add(labelTel);
            panel2.Controls.Add(textBoxEmail);
            panel2.Controls.Add(labelEmail);
            panel2.Controls.Add(textBoxCPF);
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
            // textBoxPais
            // 
            textBoxPais.Location = new Point(343, 305);
            textBoxPais.Name = "textBoxPais";
            textBoxPais.Size = new Size(145, 23);
            textBoxPais.TabIndex = 12;
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
            // textBoxUF
            // 
            textBoxUF.Location = new Point(194, 305);
            textBoxUF.Name = "textBoxUF";
            textBoxUF.Size = new Size(128, 23);
            textBoxUF.TabIndex = 11;
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
            // textBoxBairro
            // 
            textBoxBairro.Location = new Point(116, 242);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(134, 23);
            textBoxBairro.TabIndex = 8;
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
            // textBoxComplemento
            // 
            textBoxComplemento.Location = new Point(268, 242);
            textBoxComplemento.Name = "textBoxComplemento";
            textBoxComplemento.Size = new Size(220, 23);
            textBoxComplemento.TabIndex = 9;
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
            // textBoxCidade
            // 
            textBoxCidade.Location = new Point(50, 305);
            textBoxCidade.Name = "textBoxCidade";
            textBoxCidade.Size = new Size(127, 23);
            textBoxCidade.TabIndex = 10;
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
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(50, 242);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(50, 23);
            textBoxNumero.TabIndex = 7;
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
            // textBoxLograd
            // 
            textBoxLograd.Location = new Point(159, 184);
            textBoxLograd.Name = "textBoxLograd";
            textBoxLograd.Size = new Size(329, 23);
            textBoxLograd.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(159, 166);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 17;
            label2.Text = "Logradouro";
            // 
            // textBoxCEP
            // 
            textBoxCEP.Location = new Point(50, 184);
            textBoxCEP.Name = "textBoxCEP";
            textBoxCEP.Size = new Size(93, 23);
            textBoxCEP.TabIndex = 5;
            // 
            // labelCEP
            // 
            labelCEP.AutoSize = true;
            labelCEP.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCEP.Location = new Point(50, 166);
            labelCEP.Name = "labelCEP";
            labelCEP.Size = new Size(27, 15);
            labelCEP.TabIndex = 15;
            labelCEP.Text = "CEP";
            // 
            // textBoxTel
            // 
            textBoxTel.Location = new Point(288, 103);
            textBoxTel.Name = "textBoxTel";
            textBoxTel.Size = new Size(200, 23);
            textBoxTel.TabIndex = 4;
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
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(288, 48);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(200, 23);
            textBoxEmail.TabIndex = 1;
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
            // textBoxCPF
            // 
            textBoxCPF.Location = new Point(116, 103);
            textBoxCPF.Name = "textBoxCPF";
            textBoxCPF.Size = new Size(134, 23);
            textBoxCPF.TabIndex = 3;
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
            // textBoxID
            // 
            textBoxID.Location = new Point(50, 103);
            textBoxID.Name = "textBoxID";
            textBoxID.ReadOnly = true;
            textBoxID.Size = new Size(50, 23);
            textBoxID.TabIndex = 20;
            textBoxID.TabStop = false;
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
            // textBoxNome
            // 
            textBoxNome.Location = new Point(50, 48);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(200, 23);
            textBoxNome.TabIndex = 0;
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
        private Label label1;
        private Panel panel2;
        private TextBox textBoxID;
        private Label labelID;
        private TextBox textBoxNome;
        private Label labelNome;
        private TextBox textBoxTel;
        private Label labelTel;
        private TextBox textBoxEmail;
        private Label labelEmail;
        private TextBox textBoxCPF;
        private Label labelCPF;
        private TextBox textBoxCEP;
        private Label labelCEP;
        private TextBox textBoxCidade;
        private Label labelCidade;
        private TextBox textBoxNumero;
        private Label labelNumero;
        private TextBox textBoxLograd;
        private Label label2;
        private TextBox textBoxBairro;
        private Label labelBairro;
        private TextBox textBoxComplemento;
        private Label labelComplemento;
        private TextBox textBoxPais;
        private Label labelPais;
        private TextBox textBoxUF;
        private Label labelUF;
        private Button buttonFechar;
        private Button buttonCadastrar;
    }
}