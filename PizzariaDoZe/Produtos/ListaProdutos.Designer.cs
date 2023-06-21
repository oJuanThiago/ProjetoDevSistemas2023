namespace PizzariaDoZe
{
    partial class ListaProdutos
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
            buttonCadastrar = new Button();
            panelLista = new Panel();
            panelEditar = new Panel();
            labelTipo = new Label();
            comboBoxTipo = new ComboBox();
            labelML = new Label();
            comboBoxML = new ComboBox();
            textBoxValor = new TextBox();
            labelValor = new Label();
            labelEditarProduto = new Label();
            buttonExcluir = new Button();
            buttonSalvar = new Button();
            buttonEditarFechar = new Button();
            textBoxID = new TextBox();
            labelID = new Label();
            textBoxDescricao = new TextBox();
            labelDescricao = new Label();
            buttonEditar = new Button();
            buttonFechar = new Button();
            dataGridViewDados = new DataGridView();
            panel1.SuspendLayout();
            panelLista.SuspendLayout();
            panelEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).BeginInit();
            SuspendLayout();
            // 
            // menu1
            // 
            menu1.Location = new Point(0, 0);
            menu1.Name = "menu1";
            menu1.Size = new Size(200, 687);
            menu1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 51);
            panel1.Controls.Add(labelProdutos);
            panel1.Controls.Add(buttonCadastrar);
            panel1.Location = new Point(200, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1069, 100);
            panel1.TabIndex = 1;
            // 
            // labelProdutos
            // 
            labelProdutos.AutoSize = true;
            labelProdutos.Font = new Font("Yu Gothic UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelProdutos.ForeColor = SystemColors.ControlLightLight;
            labelProdutos.Location = new Point(32, 28);
            labelProdutos.Name = "labelProdutos";
            labelProdutos.Size = new Size(153, 45);
            labelProdutos.TabIndex = 82;
            labelProdutos.Text = "Produtos";
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
            buttonCadastrar.Text = "Cadastrar Produtos";
            buttonCadastrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCadastrar.UseVisualStyleBackColor = false;
            buttonCadastrar.Click += buttonCadastrar_Click;
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
            panelLista.TabIndex = 10;
            // 
            // panelEditar
            // 
            panelEditar.BackColor = Color.FromArgb(51, 51, 51);
            panelEditar.Controls.Add(labelTipo);
            panelEditar.Controls.Add(comboBoxTipo);
            panelEditar.Controls.Add(labelML);
            panelEditar.Controls.Add(comboBoxML);
            panelEditar.Controls.Add(textBoxValor);
            panelEditar.Controls.Add(labelValor);
            panelEditar.Controls.Add(labelEditarProduto);
            panelEditar.Controls.Add(buttonExcluir);
            panelEditar.Controls.Add(buttonSalvar);
            panelEditar.Controls.Add(buttonEditarFechar);
            panelEditar.Controls.Add(textBoxID);
            panelEditar.Controls.Add(labelID);
            panelEditar.Controls.Add(textBoxDescricao);
            panelEditar.Controls.Add(labelDescricao);
            panelEditar.Location = new Point(150, 15);
            panelEditar.Name = "panelEditar";
            panelEditar.Size = new Size(654, 535);
            panelEditar.TabIndex = 13;
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelTipo.ForeColor = SystemColors.ButtonHighlight;
            labelTipo.Location = new Point(50, 185);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(31, 15);
            labelTipo.TabIndex = 92;
            labelTipo.Text = "Tipo";
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Items.AddRange(new object[] { "Água", "Refrigerante", "Suco", "Cerveja", "Vinho", "Outros" });
            comboBoxTipo.Location = new Point(50, 203);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(121, 23);
            comboBoxTipo.TabIndex = 2;
            // 
            // labelML
            // 
            labelML.AutoSize = true;
            labelML.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelML.ForeColor = SystemColors.ButtonHighlight;
            labelML.Location = new Point(193, 185);
            labelML.Name = "labelML";
            labelML.Size = new Size(21, 15);
            labelML.TabIndex = 90;
            labelML.Text = "ml";
            // 
            // comboBoxML
            // 
            comboBoxML.FormattingEnabled = true;
            comboBoxML.Items.AddRange(new object[] { "150", "300", "350", "600", "1000", "1500", "2000", "2500" });
            comboBoxML.Location = new Point(193, 203);
            comboBoxML.Name = "comboBoxML";
            comboBoxML.Size = new Size(121, 23);
            comboBoxML.TabIndex = 3;
            // 
            // textBoxValor
            // 
            textBoxValor.Location = new Point(50, 265);
            textBoxValor.Name = "textBoxValor";
            textBoxValor.Size = new Size(106, 23);
            textBoxValor.TabIndex = 4;
            // 
            // labelValor
            // 
            labelValor.AutoSize = true;
            labelValor.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelValor.ForeColor = SystemColors.ButtonHighlight;
            labelValor.Location = new Point(50, 247);
            labelValor.Name = "labelValor";
            labelValor.Size = new Size(35, 15);
            labelValor.TabIndex = 87;
            labelValor.Text = "Valor";
            // 
            // labelEditarProduto
            // 
            labelEditarProduto.AutoSize = true;
            labelEditarProduto.Font = new Font("Yu Gothic UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelEditarProduto.ForeColor = SystemColors.ControlLightLight;
            labelEditarProduto.Location = new Point(50, 30);
            labelEditarProduto.Name = "labelEditarProduto";
            labelEditarProduto.Size = new Size(233, 45);
            labelEditarProduto.TabIndex = 85;
            labelEditarProduto.Text = "Editar Produto";
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
            // textBoxID
            // 
            textBoxID.Location = new Point(50, 135);
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
            labelID.Location = new Point(50, 117);
            labelID.Name = "labelID";
            labelID.Size = new Size(20, 15);
            labelID.TabIndex = 42;
            labelID.Text = "ID";
            // 
            // textBoxDescricao
            // 
            textBoxDescricao.Location = new Point(117, 135);
            textBoxDescricao.Name = "textBoxDescricao";
            textBoxDescricao.Size = new Size(200, 23);
            textBoxDescricao.TabIndex = 1;
            // 
            // labelDescricao
            // 
            labelDescricao.AutoSize = true;
            labelDescricao.BackColor = Color.Transparent;
            labelDescricao.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelDescricao.ForeColor = SystemColors.ButtonHighlight;
            labelDescricao.Location = new Point(117, 117);
            labelDescricao.Name = "labelDescricao";
            labelDescricao.Size = new Size(95, 15);
            labelDescricao.TabIndex = 40;
            labelDescricao.Text = "Nome Completo";
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
            buttonFechar.Location = new Point(937, 497);
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
            // 
            // ListaProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(panelLista);
            Controls.Add(panel1);
            Controls.Add(menu1);
            Name = "ListaProdutos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListaProdutos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelLista.ResumeLayout(false);
            panelEditar.ResumeLayout(false);
            panelEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Menu menu1;
        private Panel panel1;
        private Button buttonCadastrar;
        private Label labelProdutos;
        private Panel panelLista;
        internal Panel panelEditar;
        private Label labelEditarProduto;
        internal Button buttonExcluir;
        internal Button buttonSalvar;
        internal Button buttonEditarFechar;
        internal TextBox textBoxID;
        internal Label labelID;
        internal TextBox textBoxDescricao;
        internal Label labelDescricao;
        private Button buttonEditar;
        private Button buttonFechar;
        internal DataGridView dataGridViewDados;
        private Label labelTipo;
        private ComboBox comboBoxTipo;
        private Label labelML;
        private ComboBox comboBoxML;
        private TextBox textBoxValor;
        private Label labelValor;
    }
}