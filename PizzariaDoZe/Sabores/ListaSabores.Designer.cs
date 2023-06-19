namespace PizzariaDoZe.Sabores
{
    partial class ListaSabores
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
            label1 = new Label();
            panel1 = new Panel();
            buttonCadastrar = new Button();
            panel2 = new Panel();
            panelEditar = new Panel();
            labelEditarSabor = new Label();
            pictureBoxImagem = new PictureBox();
            labelIngredientes = new Label();
            checkedListBoxIngredientes = new CheckedListBox();
            comboBoxCategoria = new ComboBox();
            labelCategoria = new Label();
            buttonExcluir = new Button();
            buttonSalvar = new Button();
            comboBoxTipo = new ComboBox();
            labelTipo = new Label();
            buttonEditarFechar = new Button();
            labelImagem = new Label();
            textBoxID = new TextBox();
            labelID = new Label();
            textBoxDescricao = new TextBox();
            labelNome = new Label();
            buttonEditar = new Button();
            buttonFechar = new Button();
            dataGridViewDados = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panelEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).BeginInit();
            SuspendLayout();
            // 
            // menu1
            // 
            menu1.Dock = DockStyle.Left;
            menu1.Location = new Point(0, 0);
            menu1.Name = "menu1";
            menu1.Size = new Size(200, 681);
            menu1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(32, 28);
            label1.Name = "label1";
            label1.Size = new Size(135, 45);
            label1.TabIndex = 0;
            label1.Text = "Sabores";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 51);
            panel1.Controls.Add(buttonCadastrar);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(200, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1064, 100);
            panel1.TabIndex = 3;
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
            buttonCadastrar.TabIndex = 1;
            buttonCadastrar.Text = "Cadastrar Sabores";
            buttonCadastrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCadastrar.UseVisualStyleBackColor = false;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(51, 51, 51);
            panel2.Controls.Add(panelEditar);
            panel2.Controls.Add(buttonEditar);
            panel2.Controls.Add(buttonFechar);
            panel2.Controls.Add(dataGridViewDados);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(200, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(1064, 581);
            panel2.TabIndex = 4;
            // 
            // panelEditar
            // 
            panelEditar.BackColor = Color.FromArgb(51, 51, 51);
            panelEditar.Controls.Add(labelEditarSabor);
            panelEditar.Controls.Add(pictureBoxImagem);
            panelEditar.Controls.Add(labelIngredientes);
            panelEditar.Controls.Add(checkedListBoxIngredientes);
            panelEditar.Controls.Add(comboBoxCategoria);
            panelEditar.Controls.Add(labelCategoria);
            panelEditar.Controls.Add(buttonExcluir);
            panelEditar.Controls.Add(buttonSalvar);
            panelEditar.Controls.Add(comboBoxTipo);
            panelEditar.Controls.Add(labelTipo);
            panelEditar.Controls.Add(buttonEditarFechar);
            panelEditar.Controls.Add(labelImagem);
            panelEditar.Controls.Add(textBoxID);
            panelEditar.Controls.Add(labelID);
            panelEditar.Controls.Add(textBoxDescricao);
            panelEditar.Controls.Add(labelNome);
            panelEditar.Location = new Point(137, 34);
            panelEditar.Name = "panelEditar";
            panelEditar.Size = new Size(654, 535);
            panelEditar.TabIndex = 6;
            // 
            // labelEditarSabor
            // 
            labelEditarSabor.AutoSize = true;
            labelEditarSabor.Font = new Font("Yu Gothic UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelEditarSabor.ForeColor = SystemColors.ControlLightLight;
            labelEditarSabor.Location = new Point(51, 22);
            labelEditarSabor.Name = "labelEditarSabor";
            labelEditarSabor.Size = new Size(198, 45);
            labelEditarSabor.TabIndex = 84;
            labelEditarSabor.Text = "Editar Sabor";
            // 
            // pictureBoxImagem
            // 
            pictureBoxImagem.BackColor = Color.White;
            pictureBoxImagem.Location = new Point(51, 227);
            pictureBoxImagem.Name = "pictureBoxImagem";
            pictureBoxImagem.Size = new Size(200, 200);
            pictureBoxImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImagem.TabIndex = 83;
            pictureBoxImagem.TabStop = false;
            pictureBoxImagem.Tag = "";
            // 
            // labelIngredientes
            // 
            labelIngredientes.AutoSize = true;
            labelIngredientes.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelIngredientes.ForeColor = SystemColors.ButtonHighlight;
            labelIngredientes.Location = new Point(395, 85);
            labelIngredientes.Name = "labelIngredientes";
            labelIngredientes.Size = new Size(73, 15);
            labelIngredientes.TabIndex = 79;
            labelIngredientes.Text = "Ingredientes";
            // 
            // checkedListBoxIngredientes
            // 
            checkedListBoxIngredientes.BackColor = Color.White;
            checkedListBoxIngredientes.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkedListBoxIngredientes.ForeColor = SystemColors.ActiveCaptionText;
            checkedListBoxIngredientes.FormattingEnabled = true;
            checkedListBoxIngredientes.Location = new Point(395, 103);
            checkedListBoxIngredientes.Name = "checkedListBoxIngredientes";
            checkedListBoxIngredientes.Size = new Size(200, 346);
            checkedListBoxIngredientes.TabIndex = 4;
            // 
            // comboBoxCategoria
            // 
            comboBoxCategoria.FormattingEnabled = true;
            comboBoxCategoria.Items.AddRange(new object[] { "Especial", "Tradicional" });
            comboBoxCategoria.Location = new Point(218, 162);
            comboBoxCategoria.Name = "comboBoxCategoria";
            comboBoxCategoria.Size = new Size(145, 23);
            comboBoxCategoria.TabIndex = 3;
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.BackColor = Color.Transparent;
            labelCategoria.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCategoria.ForeColor = SystemColors.ButtonHighlight;
            labelCategoria.Location = new Point(218, 144);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(57, 15);
            labelCategoria.TabIndex = 77;
            labelCategoria.Text = "Categoria";
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
            buttonSalvar.Location = new Point(342, 472);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(81, 38);
            buttonSalvar.TabIndex = 5;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSalvar.UseVisualStyleBackColor = false;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Items.AddRange(new object[] { "Doce", "Salgado" });
            comboBoxTipo.Location = new Point(51, 162);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(145, 23);
            comboBoxTipo.TabIndex = 2;
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.BackColor = Color.Transparent;
            labelTipo.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelTipo.ForeColor = SystemColors.ButtonHighlight;
            labelTipo.Location = new Point(51, 144);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(31, 15);
            labelTipo.TabIndex = 75;
            labelTipo.Text = "Tipo";
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
            buttonEditarFechar.TabIndex = 7;
            buttonEditarFechar.Text = "Fechar";
            buttonEditarFechar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonEditarFechar.UseVisualStyleBackColor = false;
            buttonEditarFechar.Click += buttonEditarFechar_Click;
            // 
            // labelImagem
            // 
            labelImagem.AutoSize = true;
            labelImagem.BackColor = Color.Transparent;
            labelImagem.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelImagem.ForeColor = SystemColors.ButtonHighlight;
            labelImagem.Location = new Point(51, 209);
            labelImagem.Name = "labelImagem";
            labelImagem.Size = new Size(52, 15);
            labelImagem.TabIndex = 63;
            labelImagem.Text = "Imagem";
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(51, 103);
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
            // textBoxDescricao
            // 
            textBoxDescricao.Location = new Point(123, 103);
            textBoxDescricao.Name = "textBoxDescricao";
            textBoxDescricao.Size = new Size(240, 23);
            textBoxDescricao.TabIndex = 1;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.BackColor = Color.Transparent;
            labelNome.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNome.ForeColor = SystemColors.ButtonHighlight;
            labelNome.Location = new Point(123, 85);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(59, 15);
            labelNome.TabIndex = 40;
            labelNome.Text = "Descrição";
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
            buttonEditar.Location = new Point(851, 498);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(80, 38);
            buttonEditar.TabIndex = 3;
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
            buttonFechar.Location = new Point(937, 498);
            buttonFechar.Name = "buttonFechar";
            buttonFechar.Size = new Size(80, 38);
            buttonFechar.TabIndex = 4;
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
            dataGridViewDados.TabIndex = 2;
            dataGridViewDados.MouseDoubleClick += DataGridViewDados_MouseDoubleClick;
            // 
            // ListaSabores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menu1);
            Name = "ListaSabores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sabores";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panelEditar.ResumeLayout(false);
            panelEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagem).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Menu menu1;
        private Label label1;
        private Panel panel1;
        private Button buttonCadastrar;
        private Panel panel2;
        internal DataGridView dataGridViewDados;
        private Button buttonEditar;
        private Button buttonFechar;
        internal Panel panelEditar;
        private Label labelEditarSabor;
        private PictureBox pictureBoxImagem;
        private Label labelIngredientes;
        private CheckedListBox checkedListBoxIngredientes;
        internal ComboBox comboBoxCategoria;
        internal Label labelCategoria;
        internal Button buttonExcluir;
        internal Button buttonSalvar;
        internal ComboBox comboBoxTipo;
        internal Label labelTipo;
        internal Button buttonEditarFechar;
        internal Label labelImagem;
        internal TextBox textBoxID;
        internal Label labelID;
        internal TextBox textBoxDescricao;
        internal Label labelNome;
    }
}