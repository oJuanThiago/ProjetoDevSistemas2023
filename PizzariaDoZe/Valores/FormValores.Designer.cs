namespace PizzariaDoZe
{
    partial class FormValores
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
            maskedTextBoxValor = new MaskedTextBox();
            buttonCadastrar = new Button();
            textBoxValorBorda = new TextBox();
            labelValorBorda = new Label();
            labelValor = new Label();
            labelCategoria = new Label();
            labelTamanho = new Label();
            comboBoxCategoria = new ComboBox();
            comboBoxTamanho = new ComboBox();
            textBoxID = new TextBox();
            labelID = new Label();
            buttonFechar = new Button();
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
            menu1.buttonValores.Enabled = false;
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
            label1.Size = new Size(276, 45);
            label1.TabIndex = 1;
            label1.Text = "Cadastrar Valores";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(maskedTextBoxValor);
            panel2.Controls.Add(buttonCadastrar);
            panel2.Controls.Add(textBoxValorBorda);
            panel2.Controls.Add(labelValorBorda);
            panel2.Controls.Add(labelValor);
            panel2.Controls.Add(labelCategoria);
            panel2.Controls.Add(labelTamanho);
            panel2.Controls.Add(comboBoxCategoria);
            panel2.Controls.Add(comboBoxTamanho);
            panel2.Controls.Add(textBoxID);
            panel2.Controls.Add(labelID);
            panel2.Controls.Add(buttonFechar);
            panel2.Dock = DockStyle.Fill;
            panel2.ForeColor = SystemColors.ControlText;
            panel2.Location = new Point(200, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(684, 499);
            panel2.TabIndex = 2;
            // 
            // maskedTextBoxValor
            // 
            maskedTextBoxValor.Location = new Point(124, 113);
            maskedTextBoxValor.Name = "maskedTextBoxValor";
            maskedTextBoxValor.Size = new Size(120, 23);
            maskedTextBoxValor.TabIndex = 70;
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
            buttonCadastrar.TabIndex = 69;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCadastrar.UseVisualStyleBackColor = false;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // textBoxValorBorda
            // 
            textBoxValorBorda.Location = new Point(268, 113);
            textBoxValorBorda.Name = "textBoxValorBorda";
            textBoxValorBorda.Size = new Size(120, 23);
            textBoxValorBorda.TabIndex = 68;
            // 
            // labelValorBorda
            // 
            labelValorBorda.AutoSize = true;
            labelValorBorda.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelValorBorda.Location = new Point(268, 95);
            labelValorBorda.Name = "labelValorBorda";
            labelValorBorda.Size = new Size(85, 15);
            labelValorBorda.TabIndex = 67;
            labelValorBorda.Text = "Valor da Borda";
            // 
            // labelValor
            // 
            labelValor.AutoSize = true;
            labelValor.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelValor.Location = new Point(124, 95);
            labelValor.Name = "labelValor";
            labelValor.Size = new Size(35, 15);
            labelValor.TabIndex = 65;
            labelValor.Text = "Valor";
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCategoria.Location = new Point(268, 30);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(57, 15);
            labelCategoria.TabIndex = 64;
            labelCategoria.Text = "Categoria";
            // 
            // labelTamanho
            // 
            labelTamanho.AutoSize = true;
            labelTamanho.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelTamanho.Location = new Point(124, 30);
            labelTamanho.Name = "labelTamanho";
            labelTamanho.Size = new Size(57, 15);
            labelTamanho.TabIndex = 63;
            labelTamanho.Text = "Tamanho";
            // 
            // comboBoxCategoria
            // 
            comboBoxCategoria.FormattingEnabled = true;
            comboBoxCategoria.Items.AddRange(new object[] { "Tradicional", "Especial" });
            comboBoxCategoria.Location = new Point(268, 48);
            comboBoxCategoria.Name = "comboBoxCategoria";
            comboBoxCategoria.Size = new Size(120, 23);
            comboBoxCategoria.TabIndex = 62;
            // 
            // comboBoxTamanho
            // 
            comboBoxTamanho.FormattingEnabled = true;
            comboBoxTamanho.Items.AddRange(new object[] { "Pequena", "Média", "Grande", "Família" });
            comboBoxTamanho.Location = new Point(124, 48);
            comboBoxTamanho.Name = "comboBoxTamanho";
            comboBoxTamanho.Size = new Size(120, 23);
            comboBoxTamanho.TabIndex = 61;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(50, 48);
            textBoxID.Name = "textBoxID";
            textBoxID.ReadOnly = true;
            textBoxID.Size = new Size(50, 23);
            textBoxID.TabIndex = 60;
            textBoxID.TabStop = false;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelID.Location = new Point(50, 30);
            labelID.Name = "labelID";
            labelID.Size = new Size(20, 15);
            labelID.TabIndex = 59;
            labelID.Text = "ID";
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
            buttonFechar.TabIndex = 10;
            buttonFechar.Text = "Fechar";
            buttonFechar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonFechar.UseVisualStyleBackColor = false;
            buttonFechar.Click += buttonFechar_Click;
            // 
            // FormValores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(884, 599);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menu1);
            ForeColor = SystemColors.ControlLightLight;
            Name = "FormValores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Valores";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Menu menu1;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button buttonFechar;
        private Label labelCategoria;
        private Label labelTamanho;
        private ComboBox comboBoxCategoria;
        private ComboBox comboBoxTamanho;
        private TextBox textBoxID;
        private Label labelID;
        private TextBox textBoxValorBorda;
        private Label labelValorBorda;
        private Label labelValor;
        private Button buttonCadastrar;
        private MaskedTextBox maskedTextBoxValor;
    }
}