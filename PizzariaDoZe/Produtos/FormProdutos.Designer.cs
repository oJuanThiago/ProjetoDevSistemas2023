namespace PizzariaDoZe
{
    partial class FormProdutos
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
            labelProdutos = new Label();
            panel2 = new Panel();
            buttonCadastrar = new Button();
            label2 = new Label();
            comboBoxTipo = new ComboBox();
            textBoxID = new TextBox();
            labelID = new Label();
            labelML = new Label();
            comboBoxML = new ComboBox();
            buttonFechar = new Button();
            textBoxValor = new TextBox();
            labelValor = new Label();
            textBoxDescricao = new TextBox();
            labelDescricao = new Label();
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
            panel1.Controls.Add(labelProdutos);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(200, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(684, 100);
            panel1.TabIndex = 1;
            // 
            // labelProdutos
            // 
            labelProdutos.AutoSize = true;
            labelProdutos.Font = new Font("Yu Gothic UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelProdutos.ForeColor = SystemColors.ControlLightLight;
            labelProdutos.Location = new Point(32, 28);
            labelProdutos.Name = "labelProdutos";
            labelProdutos.Size = new Size(302, 45);
            labelProdutos.TabIndex = 0;
            labelProdutos.Text = "Cadastrar Produtos";
            labelProdutos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonCadastrar);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(comboBoxTipo);
            panel2.Controls.Add(textBoxID);
            panel2.Controls.Add(labelID);
            panel2.Controls.Add(labelML);
            panel2.Controls.Add(comboBoxML);
            panel2.Controls.Add(buttonFechar);
            panel2.Controls.Add(textBoxValor);
            panel2.Controls.Add(labelValor);
            panel2.Controls.Add(textBoxDescricao);
            panel2.Controls.Add(labelDescricao);
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
            buttonCadastrar.Location = new Point(453, 440);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(110, 38);
            buttonCadastrar.TabIndex = 87;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCadastrar.UseVisualStyleBackColor = false;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(50, 105);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 86;
            label2.Text = "Tipo";
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Items.AddRange(new object[] { "Água", "Refrigerante", "Suco", "Cerveja", "Vinho", "Outros" });
            comboBoxTipo.Location = new Point(50, 123);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(121, 23);
            comboBoxTipo.TabIndex = 85;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(50, 68);
            textBoxID.Name = "textBoxID";
            textBoxID.ReadOnly = true;
            textBoxID.Size = new Size(50, 23);
            textBoxID.TabIndex = 84;
            textBoxID.TabStop = false;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelID.Location = new Point(50, 50);
            labelID.Name = "labelID";
            labelID.Size = new Size(20, 15);
            labelID.TabIndex = 83;
            labelID.Text = "ID";
            // 
            // labelML
            // 
            labelML.AutoSize = true;
            labelML.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelML.Location = new Point(193, 105);
            labelML.Name = "labelML";
            labelML.Size = new Size(21, 15);
            labelML.TabIndex = 82;
            labelML.Text = "ml";
            // 
            // comboBoxML
            // 
            comboBoxML.FormattingEnabled = true;
            comboBoxML.Items.AddRange(new object[] { "150", "300", "350", "600", "1000", "1500", "2000", "2500" });
            comboBoxML.Location = new Point(193, 123);
            comboBoxML.Name = "comboBoxML";
            comboBoxML.Size = new Size(121, 23);
            comboBoxML.TabIndex = 81;
            // 
            // buttonFechar
            // 
            buttonFechar.BackColor = Color.Firebrick;
            buttonFechar.FlatAppearance.BorderColor = Color.Gray;
            buttonFechar.FlatStyle = FlatStyle.Flat;
            buttonFechar.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFechar.ForeColor = Color.White;
            buttonFechar.ImageAlign = ContentAlignment.MiddleLeft;
            buttonFechar.Location = new Point(569, 440);
            buttonFechar.Name = "buttonFechar";
            buttonFechar.Size = new Size(80, 38);
            buttonFechar.TabIndex = 9;
            buttonFechar.Text = "Fechar";
            buttonFechar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonFechar.UseVisualStyleBackColor = false;
            buttonFechar.Click += buttonFechar_Click;
            // 
            // textBoxValor
            // 
            textBoxValor.Location = new Point(50, 185);
            textBoxValor.Name = "textBoxValor";
            textBoxValor.Size = new Size(106, 23);
            textBoxValor.TabIndex = 7;
            // 
            // labelValor
            // 
            labelValor.AutoSize = true;
            labelValor.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelValor.Location = new Point(50, 167);
            labelValor.Name = "labelValor";
            labelValor.Size = new Size(35, 15);
            labelValor.TabIndex = 6;
            labelValor.Text = "Valor";
            // 
            // textBoxDescricao
            // 
            textBoxDescricao.Location = new Point(112, 68);
            textBoxDescricao.Name = "textBoxDescricao";
            textBoxDescricao.Size = new Size(200, 23);
            textBoxDescricao.TabIndex = 5;
            // 
            // labelDescricao
            // 
            labelDescricao.AutoSize = true;
            labelDescricao.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelDescricao.Location = new Point(112, 50);
            labelDescricao.Name = "labelDescricao";
            labelDescricao.Size = new Size(59, 15);
            labelDescricao.TabIndex = 4;
            labelDescricao.Text = "Descrição";
            // 
            // FormProdutos
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
            Name = "FormProdutos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Produtos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Menu menu1;
        private Panel panel1;
        private Label labelProdutos;
        private Panel panel2;
        private TextBox textBoxValor;
        private Label labelValor;
        private TextBox textBoxDescricao;
        private Label labelDescricao;
        private Button buttonFechar;
        private Label labelML;
        private ComboBox comboBoxML;
        private Label label2;
        private ComboBox comboBoxTipo;
        private TextBox textBoxID;
        private Label labelID;
        private Button buttonCadastrar;
    }
}