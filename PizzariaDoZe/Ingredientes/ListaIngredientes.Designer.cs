namespace PizzariaDoZe.Ingredientes
{
    partial class ListaIngredientes
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
            labelIngredientes = new Label();
            menu1 = new Menu();
            panelLista = new Panel();
            buttonEditar = new Button();
            buttonFechar = new Button();
            dataGridViewDados = new DataGridView();
            panelEditar = new Panel();
            labelEditarIngrediente = new Label();
            buttonExcluir = new Button();
            buttonSalvar = new Button();
            buttonEditarFechar = new Button();
            textBoxID = new TextBox();
            labelID = new Label();
            textBoxDescricao = new TextBox();
            labelNome = new Label();
            panel1.SuspendLayout();
            panelLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).BeginInit();
            panelEditar.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 51);
            panel1.Controls.Add(buttonCadastrar);
            panel1.Controls.Add(labelIngredientes);
            panel1.Location = new Point(200, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1069, 100);
            panel1.TabIndex = 8;
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
            buttonCadastrar.TabIndex = 79;
            buttonCadastrar.Text = "Cadastrar Ingrediente";
            buttonCadastrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCadastrar.UseVisualStyleBackColor = false;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // labelIngredientes
            // 
            labelIngredientes.AutoSize = true;
            labelIngredientes.Font = new Font("Yu Gothic UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelIngredientes.ForeColor = SystemColors.ControlLightLight;
            labelIngredientes.Location = new Point(32, 28);
            labelIngredientes.Name = "labelIngredientes";
            labelIngredientes.Size = new Size(202, 45);
            labelIngredientes.TabIndex = 1;
            labelIngredientes.Text = "Ingredientes";
            // 
            // menu1
            // 
            menu1.Location = new Point(0, 0);
            menu1.Name = "menu1";
            menu1.Size = new Size(200, 687);
            menu1.TabIndex = 7;
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
            panelLista.TabIndex = 9;
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
            // 
            // panelEditar
            // 
            panelEditar.BackColor = Color.FromArgb(51, 51, 51);
            panelEditar.Controls.Add(labelEditarIngrediente);
            panelEditar.Controls.Add(buttonExcluir);
            panelEditar.Controls.Add(buttonSalvar);
            panelEditar.Controls.Add(buttonEditarFechar);
            panelEditar.Controls.Add(textBoxID);
            panelEditar.Controls.Add(labelID);
            panelEditar.Controls.Add(textBoxDescricao);
            panelEditar.Controls.Add(labelNome);
            panelEditar.Location = new Point(165, 22);
            panelEditar.Name = "panelEditar";
            panelEditar.Size = new Size(654, 535);
            panelEditar.TabIndex = 7;
            // 
            // labelEditarIngrediente
            // 
            labelEditarIngrediente.AutoSize = true;
            labelEditarIngrediente.Font = new Font("Yu Gothic UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelEditarIngrediente.ForeColor = SystemColors.ControlLightLight;
            labelEditarIngrediente.Location = new Point(51, 22);
            labelEditarIngrediente.Name = "labelEditarIngrediente";
            labelEditarIngrediente.Size = new Size(282, 45);
            labelEditarIngrediente.TabIndex = 84;
            labelEditarIngrediente.Text = "Editar Ingrediente";
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
            // ListaIngredientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(panelLista);
            Controls.Add(panel1);
            Controls.Add(menu1);
            Name = "ListaIngredientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingredientes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).EndInit();
            panelEditar.ResumeLayout(false);
            panelEditar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        internal Panel panel1;
        private Button buttonCadastrar;
        private Label labelIngredientes;
        internal Menu menu1;
        private Panel panelLista;
        private Button buttonEditar;
        private Button buttonFechar;
        internal DataGridView dataGridViewDados;
        internal Panel panelEditar;
        private Label labelEditarIngrediente;
        internal Button buttonExcluir;
        internal Button buttonSalvar;
        internal Button buttonEditarFechar;
        internal TextBox textBoxID;
        internal Label labelID;
        internal TextBox textBoxDescricao;
        internal Label labelNome;
    }
}