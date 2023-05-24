namespace PizzariaDoZe
{
    partial class FormSabores
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
            labelTipo = new Label();
            labelCategoria = new Label();
            comboBoxTipo = new ComboBox();
            comboBoxCategoria = new ComboBox();
            labelIngredientes = new Label();
            buttonFechar = new Button();
            checkedListBox1 = new CheckedListBox();
            textBoxID = new TextBox();
            labelID = new Label();
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
            menu1.buttonSabores.Enabled = false;
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
            label1.Text = "Cadastrar Sabores";
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonCadastrar);
            panel2.Controls.Add(labelTipo);
            panel2.Controls.Add(labelCategoria);
            panel2.Controls.Add(comboBoxTipo);
            panel2.Controls.Add(comboBoxCategoria);
            panel2.Controls.Add(labelIngredientes);
            panel2.Controls.Add(buttonFechar);
            panel2.Controls.Add(checkedListBox1);
            panel2.Controls.Add(textBoxID);
            panel2.Controls.Add(labelID);
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
            buttonCadastrar.Location = new Point(400, 440);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(110, 38);
            buttonCadastrar.TabIndex = 81;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCadastrar.UseVisualStyleBackColor = false;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelTipo.Location = new Point(200, 102);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(31, 15);
            labelTipo.TabIndex = 80;
            labelTipo.Text = "Tipo";
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCategoria.Location = new Point(50, 102);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(57, 15);
            labelCategoria.TabIndex = 79;
            labelCategoria.Text = "Categoria";
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Items.AddRange(new object[] { "Salgado", "Doce" });
            comboBoxTipo.Location = new Point(200, 120);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(121, 23);
            comboBoxTipo.TabIndex = 78;
            // 
            // comboBoxCategoria
            // 
            comboBoxCategoria.FormattingEnabled = true;
            comboBoxCategoria.Items.AddRange(new object[] { "Tradicional", "Especial" });
            comboBoxCategoria.Location = new Point(50, 120);
            comboBoxCategoria.Name = "comboBoxCategoria";
            comboBoxCategoria.Size = new Size(131, 23);
            comboBoxCategoria.TabIndex = 77;
            // 
            // labelIngredientes
            // 
            labelIngredientes.AutoSize = true;
            labelIngredientes.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelIngredientes.Location = new Point(395, 30);
            labelIngredientes.Name = "labelIngredientes";
            labelIngredientes.Size = new Size(73, 15);
            labelIngredientes.TabIndex = 76;
            labelIngredientes.Text = "Ingredientes";
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
            buttonFechar.TabIndex = 75;
            buttonFechar.Text = "Fechar";
            buttonFechar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonFechar.UseVisualStyleBackColor = false;
            buttonFechar.Click += buttonFechar_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor = Color.FromArgb(51, 51, 51);
            checkedListBox1.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkedListBox1.ForeColor = SystemColors.ControlLightLight;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Queijo Parmesão", "Queijo Mussarela", "Orégano", "Tomate Cereja", "Cebola Roxa" });
            checkedListBox1.Location = new Point(395, 48);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(200, 346);
            checkedListBox1.TabIndex = 63;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(271, 48);
            textBoxID.Name = "textBoxID";
            textBoxID.ReadOnly = true;
            textBoxID.Size = new Size(50, 23);
            textBoxID.TabIndex = 62;
            textBoxID.TabStop = false;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelID.Location = new Point(271, 30);
            labelID.Name = "labelID";
            labelID.Size = new Size(20, 15);
            labelID.TabIndex = 61;
            labelID.Text = "ID";
            // 
            // textBoxDescricao
            // 
            textBoxDescricao.Location = new Point(50, 48);
            textBoxDescricao.Name = "textBoxDescricao";
            textBoxDescricao.Size = new Size(200, 23);
            textBoxDescricao.TabIndex = 59;
            // 
            // labelDescricao
            // 
            labelDescricao.AutoSize = true;
            labelDescricao.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelDescricao.Location = new Point(50, 30);
            labelDescricao.Name = "labelDescricao";
            labelDescricao.Size = new Size(59, 15);
            labelDescricao.TabIndex = 60;
            labelDescricao.Text = "Descrição";
            // 
            // FormSabores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(884, 599);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menu1);
            ForeColor = SystemColors.ControlText;
            Name = "FormSabores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sabores";
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
        private CheckedListBox checkedListBox1;
        private TextBox textBoxID;
        private Label labelID;
        private TextBox textBoxDescricao;
        private Label labelDescricao;
        private Button buttonFechar;
        private Label labelIngredientes;
        private Label labelTipo;
        private Label labelCategoria;
        private ComboBox comboBoxTipo;
        private ComboBox comboBoxCategoria;
        private Button buttonCadastrar;
    }
}