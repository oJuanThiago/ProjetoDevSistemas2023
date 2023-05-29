namespace PizzariaDoZe
{
    partial class Enderecos
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
            dataGridViewDados = new DataGridView();
            menu1 = new Menu();
            panel1 = new Panel();
            labelEnderecos = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewDados
            // 
            dataGridViewDados.AllowUserToOrderColumns = true;
            dataGridViewDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDados.Location = new Point(32, 28);
            dataGridViewDados.Name = "dataGridViewDados";
            dataGridViewDados.RowTemplate.Height = 25;
            dataGridViewDados.Size = new Size(622, 229);
            dataGridViewDados.TabIndex = 0;
            // 
            // menu1
            // 
            menu1.Location = new Point(0, 0);
            menu1.Name = "menu1";
            menu1.Size = new Size(200, 600);
            menu1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 51);
            panel1.Controls.Add(labelEnderecos);
            panel1.Location = new Point(200, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(684, 100);
            panel1.TabIndex = 2;
            // 
            // labelEnderecos
            // 
            labelEnderecos.AutoSize = true;
            labelEnderecos.Font = new Font("Yu Gothic UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelEnderecos.ForeColor = SystemColors.ControlLightLight;
            labelEnderecos.Location = new Point(32, 28);
            labelEnderecos.Name = "labelEnderecos";
            labelEnderecos.Size = new Size(169, 45);
            labelEnderecos.TabIndex = 1;
            labelEnderecos.Text = "Endereços";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridViewDados);
            panel2.Location = new Point(200, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(684, 499);
            panel2.TabIndex = 3;
            // 
            // Enderecos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 599);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menu1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Enderecos";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        internal DataGridView dataGridViewDados;
        internal Menu menu1;
        internal Panel panel1;
        private Label labelEnderecos;
        private Panel panel2;
    }
}
