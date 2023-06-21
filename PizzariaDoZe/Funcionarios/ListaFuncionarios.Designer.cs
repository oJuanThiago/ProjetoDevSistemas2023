namespace PizzariaDoZe
{
    partial class ListaFuncionarios
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
            panel1 = new Panel();
            buttonCadastrar = new Button();
            labelFuncionarios = new Label();
            panelLista = new Panel();
            panelEditar = new Panel();
            buttonExcluir = new Button();
            textBoxEnderecoID = new TextBox();
            label1 = new Label();
            maskedTextBoxTel = new MaskedTextBox();
            maskedTextBoxCEP = new MaskedTextBox();
            maskedTextBoxCNH = new MaskedTextBox();
            maskedTextBoxCPF = new MaskedTextBox();
            dateTimePickerValidade = new DateTimePicker();
            comboBoxUF = new ComboBox();
            buttonSalvar = new Button();
            comboBoxFuncao = new ComboBox();
            labelFuncao = new Label();
            buttonEditarFechar = new Button();
            labelCPF = new Label();
            textBoxMatricula = new TextBox();
            labelMatricula = new Label();
            labelValidade = new Label();
            textBoxSenha = new TextBox();
            labelSenha = new Label();
            textBoxObs = new TextBox();
            labelObs = new Label();
            labelTel = new Label();
            textBoxPais = new TextBox();
            labelPais = new Label();
            labelUF = new Label();
            textBoxBairro = new TextBox();
            labelBairro = new Label();
            textBoxComplemento = new TextBox();
            labelComplemento = new Label();
            textBoxCidade = new TextBox();
            labelCidade = new Label();
            textBoxNumero = new TextBox();
            labelNumero = new Label();
            textBoxLogradouro = new TextBox();
            label2 = new Label();
            labelCEP = new Label();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            labelCNH = new Label();
            textBoxID = new TextBox();
            labelID = new Label();
            textBoxNome = new TextBox();
            labelNome = new Label();
            buttonEditar = new Button();
            buttonFechar = new Button();
            dataGridViewDados = new DataGridView();
            menu = new Menu();
            panel1.SuspendLayout();
            panelLista.SuspendLayout();
            panelEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 51);
            panel1.Controls.Add(buttonCadastrar);
            panel1.Controls.Add(labelFuncionarios);
            panel1.Location = new Point(200, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1069, 100);
            panel1.TabIndex = 6;
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
            buttonCadastrar.TabIndex = 2;
            buttonCadastrar.Text = "Cadastrar Funcionário";
            buttonCadastrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCadastrar.UseVisualStyleBackColor = false;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // labelFuncionarios
            // 
            labelFuncionarios.AutoSize = true;
            labelFuncionarios.Font = new Font("Yu Gothic UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelFuncionarios.ForeColor = SystemColors.ControlLightLight;
            labelFuncionarios.Location = new Point(32, 28);
            labelFuncionarios.Name = "labelFuncionarios";
            labelFuncionarios.Size = new Size(203, 45);
            labelFuncionarios.TabIndex = 1;
            labelFuncionarios.Text = "Funcionários";
            // 
            // panelLista
            // 
            panelLista.BackColor = Color.FromArgb(51, 51, 51);
            panelLista.Controls.Add(panelEditar);
            panelLista.Controls.Add(buttonEditar);
            panelLista.Controls.Add(buttonFechar);
            panelLista.Controls.Add(dataGridViewDados);
            panelLista.Location = new Point(200, 100);
            panelLista.Name = "panelLista";
            panelLista.Size = new Size(1069, 600);
            panelLista.TabIndex = 2;
            // 
            // panelEditar
            // 
            panelEditar.BackColor = Color.FromArgb(51, 51, 51);
            panelEditar.Controls.Add(buttonExcluir);
            panelEditar.Controls.Add(textBoxEnderecoID);
            panelEditar.Controls.Add(label1);
            panelEditar.Controls.Add(maskedTextBoxTel);
            panelEditar.Controls.Add(maskedTextBoxCEP);
            panelEditar.Controls.Add(maskedTextBoxCNH);
            panelEditar.Controls.Add(maskedTextBoxCPF);
            panelEditar.Controls.Add(dateTimePickerValidade);
            panelEditar.Controls.Add(comboBoxUF);
            panelEditar.Controls.Add(buttonSalvar);
            panelEditar.Controls.Add(comboBoxFuncao);
            panelEditar.Controls.Add(labelFuncao);
            panelEditar.Controls.Add(buttonEditarFechar);
            panelEditar.Controls.Add(labelCPF);
            panelEditar.Controls.Add(textBoxMatricula);
            panelEditar.Controls.Add(labelMatricula);
            panelEditar.Controls.Add(labelValidade);
            panelEditar.Controls.Add(textBoxSenha);
            panelEditar.Controls.Add(labelSenha);
            panelEditar.Controls.Add(textBoxObs);
            panelEditar.Controls.Add(labelObs);
            panelEditar.Controls.Add(labelTel);
            panelEditar.Controls.Add(textBoxPais);
            panelEditar.Controls.Add(labelPais);
            panelEditar.Controls.Add(labelUF);
            panelEditar.Controls.Add(textBoxBairro);
            panelEditar.Controls.Add(labelBairro);
            panelEditar.Controls.Add(textBoxComplemento);
            panelEditar.Controls.Add(labelComplemento);
            panelEditar.Controls.Add(textBoxCidade);
            panelEditar.Controls.Add(labelCidade);
            panelEditar.Controls.Add(textBoxNumero);
            panelEditar.Controls.Add(labelNumero);
            panelEditar.Controls.Add(textBoxLogradouro);
            panelEditar.Controls.Add(label2);
            panelEditar.Controls.Add(labelCEP);
            panelEditar.Controls.Add(textBoxEmail);
            panelEditar.Controls.Add(labelEmail);
            panelEditar.Controls.Add(labelCNH);
            panelEditar.Controls.Add(textBoxID);
            panelEditar.Controls.Add(labelID);
            panelEditar.Controls.Add(textBoxNome);
            panelEditar.Controls.Add(labelNome);
            panelEditar.Location = new Point(150, 15);
            panelEditar.Name = "panelEditar";
            panelEditar.Size = new Size(654, 535);
            panelEditar.TabIndex = 13;
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
            buttonExcluir.Location = new Point(429, 472);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(80, 38);
            buttonExcluir.TabIndex = 22;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonExcluir.UseVisualStyleBackColor = false;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // textBoxEnderecoID
            // 
            textBoxEnderecoID.Location = new Point(50, 304);
            textBoxEnderecoID.Name = "textBoxEnderecoID";
            textBoxEnderecoID.ReadOnly = true;
            textBoxEnderecoID.Size = new Size(50, 23);
            textBoxEnderecoID.TabIndex = 78;
            textBoxEnderecoID.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(50, 286);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 77;
            label1.Text = "ID";
            // 
            // maskedTextBoxTel
            // 
            maskedTextBoxTel.Location = new Point(462, 425);
            maskedTextBoxTel.Mask = "(00) 000-000-000";
            maskedTextBoxTel.Name = "maskedTextBoxTel";
            maskedTextBoxTel.Size = new Size(133, 23);
            maskedTextBoxTel.TabIndex = 20;
            maskedTextBoxTel.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTextBoxCEP
            // 
            maskedTextBoxCEP.Location = new Point(114, 304);
            maskedTextBoxCEP.Mask = "00000-000";
            maskedTextBoxCEP.Name = "maskedTextBoxCEP";
            maskedTextBoxCEP.Size = new Size(63, 23);
            maskedTextBoxCEP.TabIndex = 9;
            maskedTextBoxCEP.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTextBoxCNH
            // 
            maskedTextBoxCNH.Location = new Point(268, 103);
            maskedTextBoxCNH.Mask = "000000000000";
            maskedTextBoxCNH.Name = "maskedTextBoxCNH";
            maskedTextBoxCNH.Size = new Size(134, 23);
            maskedTextBoxCNH.TabIndex = 5;
            maskedTextBoxCNH.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTextBoxCPF
            // 
            maskedTextBoxCPF.Location = new Point(117, 106);
            maskedTextBoxCPF.Mask = "000.000.000-00";
            maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            maskedTextBoxCPF.Size = new Size(133, 23);
            maskedTextBoxCPF.TabIndex = 4;
            maskedTextBoxCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // dateTimePickerValidade
            // 
            dateTimePickerValidade.Location = new Point(420, 103);
            dateTimePickerValidade.Name = "dateTimePickerValidade";
            dateTimePickerValidade.Size = new Size(176, 23);
            dateTimePickerValidade.TabIndex = 6;
            // 
            // comboBoxUF
            // 
            comboBoxUF.FormattingEnabled = true;
            comboBoxUF.Location = new Point(50, 425);
            comboBoxUF.Name = "comboBoxUF";
            comboBoxUF.Size = new Size(50, 23);
            comboBoxUF.TabIndex = 17;
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
            buttonSalvar.Location = new Point(342, 472);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(81, 38);
            buttonSalvar.TabIndex = 21;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSalvar.UseVisualStyleBackColor = false;
            buttonSalvar.Click += buttonSalvar_Click;
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
            labelFuncao.BackColor = Color.Transparent;
            labelFuncao.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelFuncao.ForeColor = SystemColors.ButtonHighlight;
            labelFuncao.Location = new Point(420, 146);
            labelFuncao.Name = "labelFuncao";
            labelFuncao.Size = new Size(45, 15);
            labelFuncao.TabIndex = 75;
            labelFuncao.Text = "Função";
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
            buttonEditarFechar.Location = new Point(515, 472);
            buttonEditarFechar.Name = "buttonEditarFechar";
            buttonEditarFechar.Size = new Size(80, 38);
            buttonEditarFechar.TabIndex = 23;
            buttonEditarFechar.Text = "Fechar";
            buttonEditarFechar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonEditarFechar.UseVisualStyleBackColor = false;
            buttonEditarFechar.Click += buttonEditarFechar_Click;
            // 
            // labelCPF
            // 
            labelCPF.AutoSize = true;
            labelCPF.BackColor = Color.Transparent;
            labelCPF.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCPF.ForeColor = SystemColors.ButtonHighlight;
            labelCPF.Location = new Point(118, 85);
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
            labelMatricula.BackColor = Color.Transparent;
            labelMatricula.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelMatricula.ForeColor = SystemColors.ButtonHighlight;
            labelMatricula.Location = new Point(268, 30);
            labelMatricula.Name = "labelMatricula";
            labelMatricula.Size = new Size(57, 15);
            labelMatricula.TabIndex = 71;
            labelMatricula.Text = "Matrícula";
            // 
            // labelValidade
            // 
            labelValidade.AutoSize = true;
            labelValidade.BackColor = Color.Transparent;
            labelValidade.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelValidade.ForeColor = SystemColors.ButtonHighlight;
            labelValidade.Location = new Point(420, 85);
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
            labelSenha.BackColor = Color.Transparent;
            labelSenha.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelSenha.ForeColor = SystemColors.ButtonHighlight;
            labelSenha.Location = new Point(420, 30);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(40, 15);
            labelSenha.TabIndex = 67;
            labelSenha.Text = "Senha";
            // 
            // textBoxObs
            // 
            textBoxObs.Location = new Point(50, 164);
            textBoxObs.Multiline = true;
            textBoxObs.Name = "textBoxObs";
            textBoxObs.Size = new Size(352, 56);
            textBoxObs.TabIndex = 7;
            // 
            // labelObs
            // 
            labelObs.AutoSize = true;
            labelObs.BackColor = Color.Transparent;
            labelObs.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelObs.ForeColor = SystemColors.ButtonHighlight;
            labelObs.Location = new Point(50, 146);
            labelObs.Name = "labelObs";
            labelObs.Size = new Size(69, 15);
            labelObs.TabIndex = 63;
            labelObs.Text = "Observação";
            // 
            // labelTel
            // 
            labelTel.AutoSize = true;
            labelTel.BackColor = Color.Transparent;
            labelTel.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelTel.ForeColor = SystemColors.ButtonHighlight;
            labelTel.Location = new Point(462, 407);
            labelTel.Name = "labelTel";
            labelTel.Size = new Size(52, 15);
            labelTel.TabIndex = 61;
            labelTel.Text = "Telefone";
            // 
            // textBoxPais
            // 
            textBoxPais.Location = new Point(117, 425);
            textBoxPais.Name = "textBoxPais";
            textBoxPais.Size = new Size(133, 23);
            textBoxPais.TabIndex = 18;
            // 
            // labelPais
            // 
            labelPais.AutoSize = true;
            labelPais.BackColor = Color.Transparent;
            labelPais.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelPais.ForeColor = SystemColors.ButtonHighlight;
            labelPais.Location = new Point(117, 407);
            labelPais.Name = "labelPais";
            labelPais.Size = new Size(28, 15);
            labelPais.TabIndex = 59;
            labelPais.Text = "País";
            // 
            // labelUF
            // 
            labelUF.AutoSize = true;
            labelUF.BackColor = Color.Transparent;
            labelUF.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelUF.ForeColor = SystemColors.ButtonHighlight;
            labelUF.Location = new Point(50, 407);
            labelUF.Name = "labelUF";
            labelUF.Size = new Size(21, 15);
            labelUF.TabIndex = 58;
            labelUF.Text = "UF";
            // 
            // textBoxBairro
            // 
            textBoxBairro.Location = new Point(50, 362);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(127, 23);
            textBoxBairro.TabIndex = 14;
            // 
            // labelBairro
            // 
            labelBairro.AutoSize = true;
            labelBairro.BackColor = Color.Transparent;
            labelBairro.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelBairro.ForeColor = SystemColors.ButtonHighlight;
            labelBairro.Location = new Point(50, 344);
            labelBairro.Name = "labelBairro";
            labelBairro.Size = new Size(38, 15);
            labelBairro.TabIndex = 57;
            labelBairro.Text = "Bairro";
            // 
            // textBoxComplemento
            // 
            textBoxComplemento.Location = new Point(194, 362);
            textBoxComplemento.Name = "textBoxComplemento";
            textBoxComplemento.Size = new Size(208, 23);
            textBoxComplemento.TabIndex = 15;
            // 
            // labelComplemento
            // 
            labelComplemento.AutoSize = true;
            labelComplemento.BackColor = Color.Transparent;
            labelComplemento.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelComplemento.ForeColor = SystemColors.ButtonHighlight;
            labelComplemento.Location = new Point(194, 344);
            labelComplemento.Name = "labelComplemento";
            labelComplemento.Size = new Size(83, 15);
            labelComplemento.TabIndex = 56;
            labelComplemento.Text = "Complemento";
            // 
            // textBoxCidade
            // 
            textBoxCidade.Location = new Point(420, 362);
            textBoxCidade.Name = "textBoxCidade";
            textBoxCidade.Size = new Size(175, 23);
            textBoxCidade.TabIndex = 16;
            // 
            // labelCidade
            // 
            labelCidade.AutoSize = true;
            labelCidade.BackColor = Color.Transparent;
            labelCidade.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCidade.ForeColor = SystemColors.ButtonHighlight;
            labelCidade.Location = new Point(420, 344);
            labelCidade.Name = "labelCidade";
            labelCidade.Size = new Size(43, 15);
            labelCidade.TabIndex = 55;
            labelCidade.Text = "Cidade";
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(545, 304);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(50, 23);
            textBoxNumero.TabIndex = 13;
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.BackColor = Color.Transparent;
            labelNumero.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNumero.ForeColor = SystemColors.ButtonHighlight;
            labelNumero.Location = new Point(545, 286);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(51, 15);
            labelNumero.TabIndex = 53;
            labelNumero.Text = "Número";
            // 
            // textBoxLogradouro
            // 
            textBoxLogradouro.Location = new Point(194, 304);
            textBoxLogradouro.Name = "textBoxLogradouro";
            textBoxLogradouro.Size = new Size(332, 23);
            textBoxLogradouro.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(194, 286);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 52;
            label2.Text = "Logradouro";
            // 
            // labelCEP
            // 
            labelCEP.AutoSize = true;
            labelCEP.BackColor = Color.Transparent;
            labelCEP.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCEP.ForeColor = SystemColors.ButtonHighlight;
            labelCEP.Location = new Point(114, 286);
            labelCEP.Name = "labelCEP";
            labelCEP.Size = new Size(27, 15);
            labelCEP.TabIndex = 51;
            labelCEP.Text = "CEP";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(268, 425);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(177, 23);
            textBoxEmail.TabIndex = 19;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.BackColor = Color.Transparent;
            labelEmail.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmail.ForeColor = SystemColors.ButtonHighlight;
            labelEmail.Location = new Point(268, 407);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(41, 15);
            labelEmail.TabIndex = 49;
            labelEmail.Text = "E-mail";
            // 
            // labelCNH
            // 
            labelCNH.AutoSize = true;
            labelCNH.BackColor = Color.Transparent;
            labelCNH.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCNH.ForeColor = SystemColors.ButtonHighlight;
            labelCNH.Location = new Point(268, 85);
            labelCNH.Name = "labelCNH";
            labelCNH.Size = new Size(32, 15);
            labelCNH.TabIndex = 46;
            labelCNH.Text = "CNH";
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(50, 106);
            textBoxID.Name = "textBoxID";
            textBoxID.ReadOnly = true;
            textBoxID.Size = new Size(50, 23);
            textBoxID.TabIndex = 54;
            textBoxID.TabStop = false;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.BackColor = Color.Transparent;
            labelID.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelID.ForeColor = SystemColors.ButtonHighlight;
            labelID.Location = new Point(51, 85);
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
            labelNome.BackColor = Color.Transparent;
            labelNome.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNome.ForeColor = SystemColors.ButtonHighlight;
            labelNome.Location = new Point(50, 30);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(95, 15);
            labelNome.TabIndex = 40;
            labelNome.Text = "Nome Completo";
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
            dataGridViewDados.MouseDoubleClick += DataGridViewDados_MouseDoubleClick;
            // 
            // menu
            // 
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(200, 700);
            menu.TabIndex = 5;
            // 
            // ListaFuncionarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(panelLista);
            Controls.Add(menu);
            Controls.Add(panel1);
            Name = "ListaFuncionarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Funcionarios";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelLista.ResumeLayout(false);
            panelEditar.ResumeLayout(false);
            panelEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).EndInit();
            ResumeLayout(false);
        }

        #endregion
        internal Panel panel1;
        private Label labelFuncionarios;
        private Button buttonCadastrar;
        private Panel panelLista;
        private Button buttonEditar;
        private Button buttonFechar;
        internal DataGridView dataGridViewDados;
        private Menu menu;
        internal Panel panelEditar;
        internal Button buttonExcluir;
        internal TextBox textBoxEnderecoID;
        internal Label label1;
        internal MaskedTextBox maskedTextBoxTel;
        internal MaskedTextBox maskedTextBoxCEP;
        internal MaskedTextBox maskedTextBoxCNH;
        internal MaskedTextBox maskedTextBoxCPF;
        internal DateTimePicker dateTimePickerValidade;
        internal ComboBox comboBoxUF;
        internal Button buttonSalvar;
        internal ComboBox comboBoxFuncao;
        internal Label labelFuncao;
        internal Button buttonEditarFechar;
        internal Label labelCPF;
        internal TextBox textBoxMatricula;
        internal Label labelMatricula;
        internal Label labelValidade;
        internal TextBox textBoxSenha;
        internal Label labelSenha;
        internal TextBox textBoxObs;
        internal Label labelObs;
        internal Label labelTel;
        internal TextBox textBoxPais;
        internal Label labelPais;
        internal Label labelUF;
        internal TextBox textBoxBairro;
        internal Label labelBairro;
        internal TextBox textBoxComplemento;
        internal Label labelComplemento;
        internal TextBox textBoxCidade;
        internal Label labelCidade;
        internal TextBox textBoxNumero;
        internal Label labelNumero;
        internal TextBox textBoxLogradouro;
        internal Label label2;
        internal Label labelCEP;
        internal TextBox textBoxEmail;
        internal Label labelEmail;
        internal Label labelCNH;
        internal TextBox textBoxID;
        internal Label labelID;
        internal TextBox textBoxNome;
        internal Label labelNome;
    }
}