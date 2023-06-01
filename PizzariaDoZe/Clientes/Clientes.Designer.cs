namespace PizzariaDoZe
{
    partial class Clientes
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
            panel2 = new Panel();
            buttonEditar = new Button();
            buttonFechar = new Button();
            dataGridViewDados = new DataGridView();
            panel1 = new Panel();
            buttonCadastrar = new Button();
            labelClientes = new Label();
            menu1 = new Menu();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonEditar);
            panel2.Controls.Add(buttonFechar);
            panel2.Controls.Add(dataGridViewDados);
            panel2.Location = new Point(200, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(684, 499);
            panel2.TabIndex = 9;
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
            buttonEditar.Location = new Point(483, 440);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(80, 38);
            buttonEditar.TabIndex = 78;
            buttonEditar.Text = "Editar";
            buttonEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonEditar.UseVisualStyleBackColor = false;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // buttonFechar
            // 
            buttonFechar.BackColor = Color.Firebrick;
            buttonFechar.FlatAppearance.BorderColor = Color.Gray;
            buttonFechar.FlatAppearance.BorderSize = 0;
            buttonFechar.FlatStyle = FlatStyle.Flat;
            buttonFechar.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFechar.ForeColor = Color.White;
            buttonFechar.ImageAlign = ContentAlignment.MiddleLeft;
            buttonFechar.Location = new Point(569, 440);
            buttonFechar.Name = "buttonFechar";
            buttonFechar.Size = new Size(80, 38);
            buttonFechar.TabIndex = 77;
            buttonFechar.Text = "Fechar";
            buttonFechar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonFechar.UseVisualStyleBackColor = false;
            buttonFechar.Click += buttonFechar_Click;
            // 
            // dataGridViewDados
            // 
            dataGridViewDados.AllowUserToOrderColumns = true;
            dataGridViewDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDados.Location = new Point(32, 28);
            dataGridViewDados.Name = "dataGridViewDados";
            dataGridViewDados.RowTemplate.Height = 25;
            dataGridViewDados.Size = new Size(617, 370);
            dataGridViewDados.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 51);
            panel1.Controls.Add(buttonCadastrar);
            panel1.Controls.Add(labelClientes);
            panel1.Location = new Point(200, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(684, 100);
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
            buttonCadastrar.Location = new Point(459, 31);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(190, 38);
            buttonCadastrar.TabIndex = 79;
            buttonCadastrar.Text = "Cadastrar Clientes";
            buttonCadastrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCadastrar.UseVisualStyleBackColor = false;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // labelClientes
            // 
            labelClientes.AutoSize = true;
            labelClientes.Font = new Font("Yu Gothic UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelClientes.ForeColor = SystemColors.ControlLightLight;
            labelClientes.Location = new Point(32, 28);
            labelClientes.Name = "labelClientes";
            labelClientes.Size = new Size(135, 45);
            labelClientes.TabIndex = 1;
            labelClientes.Text = "Clientes";
            // 
            // menu1
            // 
            menu1.Location = new Point(0, 0);
            menu1.Name = "menu1";
            menu1.Size = new Size(200, 600);
            menu1.TabIndex = 7;
            menu1.buttonClientes.Enabled = false;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 599);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menu1);
            Name = "Clientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button buttonEditar;
        private Button buttonFechar;
        internal DataGridView dataGridViewDados;
        internal Panel panel1;
        private Button buttonCadastrar;
        private Label labelClientes;
        internal Menu menu1;
    }
}