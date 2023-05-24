﻿namespace PizzariaDoZe
{
    partial class FormFuncionarios
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
            labelFuncionarios = new Label();
            panel2 = new Panel();
            buttonCadastrar = new Button();
            comboBoxFuncao = new ComboBox();
            labelFuncao = new Label();
            buttonFechar = new Button();
            textBoxCPF = new TextBox();
            labelCPF = new Label();
            textBoxMatricula = new TextBox();
            labelMatricula = new Label();
            textBoxValidade = new TextBox();
            labelValidade = new Label();
            textBoxSenha = new TextBox();
            labelSenha = new Label();
            textBox2 = new TextBox();
            labelObs = new Label();
            textBox1 = new TextBox();
            labelTel = new Label();
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
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            textBoxCNH = new TextBox();
            labelCNH = new Label();
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
            menu1.buttonFuncionarios.Enabled = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 51);
            panel1.Controls.Add(labelFuncionarios);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(200, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(684, 100);
            panel1.TabIndex = 1;
            // 
            // labelFuncionarios
            // 
            labelFuncionarios.AutoSize = true;
            labelFuncionarios.Font = new Font("Yu Gothic UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelFuncionarios.ForeColor = SystemColors.ControlLightLight;
            labelFuncionarios.Location = new Point(32, 28);
            labelFuncionarios.Name = "labelFuncionarios";
            labelFuncionarios.Size = new Size(352, 45);
            labelFuncionarios.TabIndex = 0;
            labelFuncionarios.Text = "Cadastrar Funcionários";
            labelFuncionarios.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonCadastrar);
            panel2.Controls.Add(comboBoxFuncao);
            panel2.Controls.Add(labelFuncao);
            panel2.Controls.Add(buttonFechar);
            panel2.Controls.Add(textBoxCPF);
            panel2.Controls.Add(labelCPF);
            panel2.Controls.Add(textBoxMatricula);
            panel2.Controls.Add(labelMatricula);
            panel2.Controls.Add(textBoxValidade);
            panel2.Controls.Add(labelValidade);
            panel2.Controls.Add(textBoxSenha);
            panel2.Controls.Add(labelSenha);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(labelObs);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(labelTel);
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
            panel2.Controls.Add(textBoxEmail);
            panel2.Controls.Add(labelEmail);
            panel2.Controls.Add(textBoxCNH);
            panel2.Controls.Add(labelCNH);
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
            buttonCadastrar.TabIndex = 76;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCadastrar.UseVisualStyleBackColor = false;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // comboBoxFuncao
            // 
            comboBoxFuncao.FormattingEnabled = true;
            comboBoxFuncao.Items.AddRange(new object[] { "Administrador", "Atendente", "Entregador" });
            comboBoxFuncao.Location = new Point(420, 164);
            comboBoxFuncao.Name = "comboBoxFuncao";
            comboBoxFuncao.Size = new Size(175, 23);
            comboBoxFuncao.TabIndex = 8;
            // 
            // labelFuncao
            // 
            labelFuncao.AutoSize = true;
            labelFuncao.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelFuncao.Location = new Point(420, 146);
            labelFuncao.Name = "labelFuncao";
            labelFuncao.Size = new Size(45, 15);
            labelFuncao.TabIndex = 75;
            labelFuncao.Text = "Função";
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
            buttonFechar.TabIndex = 74;
            buttonFechar.Text = "Fechar";
            buttonFechar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonFechar.UseVisualStyleBackColor = false;
            buttonFechar.Click += buttonFechar_Click;
            // 
            // textBoxCPF
            // 
            textBoxCPF.Location = new Point(117, 103);
            textBoxCPF.Name = "textBoxCPF";
            textBoxCPF.Size = new Size(133, 23);
            textBoxCPF.TabIndex = 4;
            // 
            // labelCPF
            // 
            labelCPF.AutoSize = true;
            labelCPF.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCPF.Location = new Point(117, 85);
            labelCPF.Name = "labelCPF";
            labelCPF.Size = new Size(27, 15);
            labelCPF.TabIndex = 73;
            labelCPF.Text = "CPF";
            // 
            // textBoxMatricula
            // 
            textBoxMatricula.Location = new Point(268, 48);
            textBoxMatricula.Name = "textBoxMatricula";
            textBoxMatricula.Size = new Size(134, 23);
            textBoxMatricula.TabIndex = 2;
            // 
            // labelMatricula
            // 
            labelMatricula.AutoSize = true;
            labelMatricula.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelMatricula.Location = new Point(268, 30);
            labelMatricula.Name = "labelMatricula";
            labelMatricula.Size = new Size(57, 15);
            labelMatricula.TabIndex = 71;
            labelMatricula.Text = "Matrícula";
            // 
            // textBoxValidade
            // 
            textBoxValidade.Location = new Point(268, 103);
            textBoxValidade.Name = "textBoxValidade";
            textBoxValidade.Size = new Size(134, 23);
            textBoxValidade.TabIndex = 5;
            // 
            // labelValidade
            // 
            labelValidade.AutoSize = true;
            labelValidade.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelValidade.Location = new Point(268, 85);
            labelValidade.Name = "labelValidade";
            labelValidade.Size = new Size(53, 15);
            labelValidade.TabIndex = 69;
            labelValidade.Text = "Validade";
            // 
            // textBoxSenha
            // 
            textBoxSenha.HideSelection = false;
            textBoxSenha.Location = new Point(420, 48);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.PasswordChar = '*';
            textBoxSenha.Size = new Size(176, 23);
            textBoxSenha.TabIndex = 3;
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelSenha.Location = new Point(420, 30);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(40, 15);
            labelSenha.TabIndex = 67;
            labelSenha.Text = "Senha";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(50, 164);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(352, 56);
            textBox2.TabIndex = 7;
            // 
            // labelObs
            // 
            labelObs.AutoSize = true;
            labelObs.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelObs.Location = new Point(50, 146);
            labelObs.Name = "labelObs";
            labelObs.Size = new Size(69, 15);
            labelObs.TabIndex = 63;
            labelObs.Text = "Observação";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(462, 393);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(134, 23);
            textBox1.TabIndex = 20;
            // 
            // labelTel
            // 
            labelTel.AutoSize = true;
            labelTel.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelTel.Location = new Point(462, 375);
            labelTel.Name = "labelTel";
            labelTel.Size = new Size(52, 15);
            labelTel.TabIndex = 61;
            labelTel.Text = "Telefone";
            // 
            // textBoxPais
            // 
            textBoxPais.Location = new Point(117, 393);
            textBoxPais.Name = "textBoxPais";
            textBoxPais.Size = new Size(133, 23);
            textBoxPais.TabIndex = 18;
            // 
            // labelPais
            // 
            labelPais.AutoSize = true;
            labelPais.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelPais.Location = new Point(117, 375);
            labelPais.Name = "labelPais";
            labelPais.Size = new Size(28, 15);
            labelPais.TabIndex = 59;
            labelPais.Text = "País";
            // 
            // textBoxUF
            // 
            textBoxUF.Location = new Point(50, 393);
            textBoxUF.Name = "textBoxUF";
            textBoxUF.Size = new Size(50, 23);
            textBoxUF.TabIndex = 17;
            // 
            // labelUF
            // 
            labelUF.AutoSize = true;
            labelUF.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelUF.Location = new Point(50, 375);
            labelUF.Name = "labelUF";
            labelUF.Size = new Size(21, 15);
            labelUF.TabIndex = 58;
            labelUF.Text = "UF";
            // 
            // textBoxBairro
            // 
            textBoxBairro.Location = new Point(50, 330);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(127, 23);
            textBoxBairro.TabIndex = 14;
            // 
            // labelBairro
            // 
            labelBairro.AutoSize = true;
            labelBairro.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelBairro.Location = new Point(50, 312);
            labelBairro.Name = "labelBairro";
            labelBairro.Size = new Size(38, 15);
            labelBairro.TabIndex = 57;
            labelBairro.Text = "Bairro";
            // 
            // textBoxComplemento
            // 
            textBoxComplemento.Location = new Point(194, 330);
            textBoxComplemento.Name = "textBoxComplemento";
            textBoxComplemento.Size = new Size(208, 23);
            textBoxComplemento.TabIndex = 15;
            // 
            // labelComplemento
            // 
            labelComplemento.AutoSize = true;
            labelComplemento.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelComplemento.Location = new Point(194, 312);
            labelComplemento.Name = "labelComplemento";
            labelComplemento.Size = new Size(83, 15);
            labelComplemento.TabIndex = 56;
            labelComplemento.Text = "Complemento";
            // 
            // textBoxCidade
            // 
            textBoxCidade.Location = new Point(420, 330);
            textBoxCidade.Name = "textBoxCidade";
            textBoxCidade.Size = new Size(175, 23);
            textBoxCidade.TabIndex = 16;
            // 
            // labelCidade
            // 
            labelCidade.AutoSize = true;
            labelCidade.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCidade.Location = new Point(420, 312);
            labelCidade.Name = "labelCidade";
            labelCidade.Size = new Size(43, 15);
            labelCidade.TabIndex = 55;
            labelCidade.Text = "Cidade";
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(545, 272);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(50, 23);
            textBoxNumero.TabIndex = 13;
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNumero.Location = new Point(545, 254);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(51, 15);
            labelNumero.TabIndex = 53;
            labelNumero.Text = "Número";
            // 
            // textBoxLograd
            // 
            textBoxLograd.Location = new Point(159, 272);
            textBoxLograd.Name = "textBoxLograd";
            textBoxLograd.Size = new Size(367, 23);
            textBoxLograd.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(159, 254);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 52;
            label2.Text = "Logradouro";
            // 
            // textBoxCEP
            // 
            textBoxCEP.Location = new Point(50, 272);
            textBoxCEP.Name = "textBoxCEP";
            textBoxCEP.Size = new Size(93, 23);
            textBoxCEP.TabIndex = 11;
            // 
            // labelCEP
            // 
            labelCEP.AutoSize = true;
            labelCEP.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCEP.Location = new Point(50, 254);
            labelCEP.Name = "labelCEP";
            labelCEP.Size = new Size(27, 15);
            labelCEP.TabIndex = 51;
            labelCEP.Text = "CEP";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(268, 393);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(177, 23);
            textBoxEmail.TabIndex = 19;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmail.Location = new Point(268, 375);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(41, 15);
            labelEmail.TabIndex = 49;
            labelEmail.Text = "E-mail";
            // 
            // textBoxCNH
            // 
            textBoxCNH.Location = new Point(420, 103);
            textBoxCNH.Name = "textBoxCNH";
            textBoxCNH.Size = new Size(175, 23);
            textBoxCNH.TabIndex = 6;
            // 
            // labelCNH
            // 
            labelCNH.AutoSize = true;
            labelCNH.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCNH.Location = new Point(420, 85);
            labelCNH.Name = "labelCNH";
            labelCNH.Size = new Size(32, 15);
            labelCNH.TabIndex = 46;
            labelCNH.Text = "CNH";
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(50, 103);
            textBoxID.Name = "textBoxID";
            textBoxID.ReadOnly = true;
            textBoxID.Size = new Size(50, 23);
            textBoxID.TabIndex = 54;
            textBoxID.TabStop = false;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelID.Location = new Point(50, 85);
            labelID.Name = "labelID";
            labelID.Size = new Size(20, 15);
            labelID.TabIndex = 42;
            labelID.Text = "ID";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(50, 48);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(200, 23);
            textBoxNome.TabIndex = 1;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNome.Location = new Point(50, 30);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(95, 15);
            labelNome.TabIndex = 40;
            labelNome.Text = "Nome Completo";
            // 
            // FormFuncionarios
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
            Name = "FormFuncionarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Funcionários";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Menu menu1;
        private Panel panel1;
        private Label labelFuncionarios;
        private Panel panel2;
        private TextBox textBoxPais;
        private Label labelPais;
        private TextBox textBoxUF;
        private Label labelUF;
        private TextBox textBoxBairro;
        private Label labelBairro;
        private TextBox textBoxComplemento;
        private Label labelComplemento;
        private TextBox textBoxCidade;
        private Label labelCidade;
        private TextBox textBoxNumero;
        private Label labelNumero;
        private TextBox textBoxLograd;
        private Label label2;
        private TextBox textBoxCEP;
        private Label labelCEP;
        private TextBox textBoxEmail;
        private Label labelEmail;
        private TextBox textBoxCNH;
        private Label labelCNH;
        private TextBox textBoxID;
        private Label labelID;
        private TextBox textBoxNome;
        private Label labelNome;
        private TextBox textBoxSenha;
        private Label labelSenha;
        private TextBox textBox2;
        private Label labelObs;
        private TextBox textBox1;
        private Label labelTel;
        private TextBox textBoxValidade;
        private Label labelValidade;
        private TextBox textBoxMatricula;
        private Label labelMatricula;
        private TextBox textBoxCPF;
        private Label labelCPF;
        private Button buttonFechar;
        private ComboBox comboBoxFuncao;
        private Label labelFuncao;
        private Button buttonCadastrar;
    }
}