namespace PizzariaDoZe
{
    partial class Menu
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            buttonSair = new Button();
            buttonValores = new Button();
            buttonProdutos = new Button();
            buttonIngredientes = new Button();
            buttonSabores = new Button();
            buttonClientes = new Button();
            buttonFuncionarios = new Button();
            buttonInicio = new Button();
            panel2 = new Panel();
            labelFuncaoUsuario = new Label();
            labelUsuario = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Firebrick;
            panel1.Controls.Add(buttonSair);
            panel1.Controls.Add(buttonValores);
            panel1.Controls.Add(buttonProdutos);
            panel1.Controls.Add(buttonIngredientes);
            panel1.Controls.Add(buttonSabores);
            panel1.Controls.Add(buttonClientes);
            panel1.Controls.Add(buttonFuncionarios);
            panel1.Controls.Add(buttonInicio);
            panel1.Controls.Add(panel2);
            panel1.ForeColor = SystemColors.ControlLightLight;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 600);
            panel1.TabIndex = 0;
            // 
            // buttonSair
            // 
            buttonSair.FlatAppearance.BorderColor = Color.Gray;
            buttonSair.FlatStyle = FlatStyle.Flat;
            buttonSair.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSair.ForeColor = Color.White;
            buttonSair.Image = Properties.Resources.logout;
            buttonSair.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSair.Location = new Point(0, 549);
            buttonSair.Name = "buttonSair";
            buttonSair.Size = new Size(200, 48);
            buttonSair.TabIndex = 8;
            buttonSair.Text = "Sair";
            buttonSair.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSair.UseVisualStyleBackColor = true;
            buttonSair.Click += buttonSair_Click;
            // 
            // buttonValores
            // 
            buttonValores.FlatAppearance.BorderSize = 0;
            buttonValores.FlatStyle = FlatStyle.Flat;
            buttonValores.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonValores.ForeColor = Color.White;
            buttonValores.Image = Properties.Resources.atividades;
            buttonValores.ImageAlign = ContentAlignment.MiddleLeft;
            buttonValores.Location = new Point(0, 460);
            buttonValores.Name = "buttonValores";
            buttonValores.Size = new Size(200, 48);
            buttonValores.TabIndex = 7;
            buttonValores.Text = "Valores";
            buttonValores.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonValores.UseVisualStyleBackColor = true;
            buttonValores.Click += buttonValores_Click;
            // 
            // buttonProdutos
            // 
            buttonProdutos.FlatAppearance.BorderSize = 0;
            buttonProdutos.FlatStyle = FlatStyle.Flat;
            buttonProdutos.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonProdutos.ForeColor = Color.White;
            buttonProdutos.Image = Properties.Resources.atividades;
            buttonProdutos.ImageAlign = ContentAlignment.MiddleLeft;
            buttonProdutos.Location = new Point(0, 412);
            buttonProdutos.Name = "buttonProdutos";
            buttonProdutos.Size = new Size(200, 48);
            buttonProdutos.TabIndex = 6;
            buttonProdutos.Text = "Produtos";
            buttonProdutos.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonProdutos.UseVisualStyleBackColor = true;
            buttonProdutos.Click += buttonProdutos_Click;
            // 
            // buttonIngredientes
            // 
            buttonIngredientes.FlatAppearance.BorderSize = 0;
            buttonIngredientes.FlatStyle = FlatStyle.Flat;
            buttonIngredientes.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonIngredientes.ForeColor = Color.White;
            buttonIngredientes.Image = Properties.Resources.atividades;
            buttonIngredientes.ImageAlign = ContentAlignment.MiddleLeft;
            buttonIngredientes.Location = new Point(0, 316);
            buttonIngredientes.Name = "buttonIngredientes";
            buttonIngredientes.Size = new Size(200, 48);
            buttonIngredientes.TabIndex = 4;
            buttonIngredientes.Text = "Ingredientes";
            buttonIngredientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonIngredientes.UseVisualStyleBackColor = true;
            buttonIngredientes.Click += buttonIngredientes_Click;
            // 
            // buttonSabores
            // 
            buttonSabores.FlatAppearance.BorderSize = 0;
            buttonSabores.FlatStyle = FlatStyle.Flat;
            buttonSabores.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSabores.ForeColor = Color.White;
            buttonSabores.Image = Properties.Resources.atividades;
            buttonSabores.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSabores.Location = new Point(0, 364);
            buttonSabores.Name = "buttonSabores";
            buttonSabores.Size = new Size(200, 48);
            buttonSabores.TabIndex = 5;
            buttonSabores.Text = "Sabores";
            buttonSabores.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSabores.UseVisualStyleBackColor = true;
            buttonSabores.Click += buttonSabores_Click;
            // 
            // buttonClientes
            // 
            buttonClientes.FlatAppearance.BorderSize = 0;
            buttonClientes.FlatStyle = FlatStyle.Flat;
            buttonClientes.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonClientes.ForeColor = Color.White;
            buttonClientes.Image = Properties.Resources.analise;
            buttonClientes.ImageAlign = ContentAlignment.MiddleLeft;
            buttonClientes.Location = new Point(0, 268);
            buttonClientes.Name = "buttonClientes";
            buttonClientes.Size = new Size(200, 48);
            buttonClientes.TabIndex = 3;
            buttonClientes.Text = "Clientes";
            buttonClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonClientes.UseVisualStyleBackColor = true;
            buttonClientes.Click += buttonClientes_Click;
            // 
            // buttonFuncionarios
            // 
            buttonFuncionarios.FlatAppearance.BorderSize = 0;
            buttonFuncionarios.FlatStyle = FlatStyle.Flat;
            buttonFuncionarios.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFuncionarios.ForeColor = Color.White;
            buttonFuncionarios.Image = Properties.Resources.equipe;
            buttonFuncionarios.ImageAlign = ContentAlignment.MiddleLeft;
            buttonFuncionarios.Location = new Point(0, 220);
            buttonFuncionarios.Name = "buttonFuncionarios";
            buttonFuncionarios.Size = new Size(200, 48);
            buttonFuncionarios.TabIndex = 2;
            buttonFuncionarios.Text = "Funcionários";
            buttonFuncionarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonFuncionarios.UseVisualStyleBackColor = true;
            buttonFuncionarios.Click += buttonFuncionarios_Click;
            // 
            // buttonInicio
            // 
            buttonInicio.FlatAppearance.BorderSize = 0;
            buttonInicio.FlatStyle = FlatStyle.Flat;
            buttonInicio.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonInicio.ForeColor = Color.White;
            buttonInicio.Image = Properties.Resources.casa;
            buttonInicio.ImageAlign = ContentAlignment.MiddleLeft;
            buttonInicio.Location = new Point(0, 172);
            buttonInicio.Name = "buttonInicio";
            buttonInicio.Size = new Size(200, 48);
            buttonInicio.TabIndex = 1;
            buttonInicio.Text = "Início";
            buttonInicio.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonInicio.UseVisualStyleBackColor = true;
            buttonInicio.Click += buttonInicio_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Firebrick;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(labelFuncaoUsuario);
            panel2.Controls.Add(labelUsuario);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 172);
            panel2.TabIndex = 0;
            // 
            // labelFuncaoUsuario
            // 
            labelFuncaoUsuario.AutoSize = true;
            labelFuncaoUsuario.Location = new Point(46, 133);
            labelFuncaoUsuario.Name = "labelFuncaoUsuario";
            labelFuncaoUsuario.Size = new Size(105, 15);
            labelFuncaoUsuario.TabIndex = 2;
            labelFuncaoUsuario.Text = "Função do usuário";
            labelFuncaoUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelUsuario.Location = new Point(69, 103);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(61, 19);
            labelUsuario.TabIndex = 1;
            labelUsuario.Text = "Usuário ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_usuário_50;
            pictureBox1.Location = new Point(60, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "Menu";
            Size = new Size(200, 600);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        internal Button buttonIngredientes;
        internal Button buttonSabores;
        internal Button buttonClientes;
        internal Button buttonFuncionarios;
        internal Button buttonInicio;
        private Panel panel2;
        internal Button buttonValores;
        internal Button buttonProdutos;
        internal Button buttonSair;
        private Label labelUsuario;
        internal PictureBox pictureBox1;
        private Label labelFuncaoUsuario;
    }
}
