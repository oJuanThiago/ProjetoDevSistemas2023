namespace PizzariaDoZe
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            menu1 = new Menu();
            panel1 = new Panel();
            labelInicio = new Label();
            buttonConfig = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menu1
            // 
            menu1.Dock = DockStyle.Left;
            menu1.Location = new Point(0, 0);
            menu1.Name = "menu1";
            menu1.Size = new Size(200, 599);
            menu1.TabIndex = 0;
            menu1.buttonInicio.Enabled = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 51);
            panel1.Controls.Add(buttonConfig);
            panel1.Controls.Add(labelInicio);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(200, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(684, 100);
            panel1.TabIndex = 1;
            // 
            // labelInicio
            // 
            labelInicio.AutoSize = true;
            labelInicio.Font = new Font("Yu Gothic UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelInicio.ForeColor = SystemColors.ControlLightLight;
            labelInicio.Location = new Point(32, 28);
            labelInicio.Name = "labelInicio";
            labelInicio.Size = new Size(98, 45);
            labelInicio.TabIndex = 1;
            labelInicio.Text = "Início";
            labelInicio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonConfig
            // 
            buttonConfig.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonConfig.BackColor = Color.Transparent;
            buttonConfig.FlatAppearance.BorderSize = 0;
            buttonConfig.FlatStyle = FlatStyle.Flat;
            buttonConfig.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonConfig.ForeColor = Color.White;
            buttonConfig.Image = (Image)resources.GetObject("buttonConfig.Image");
            buttonConfig.ImageAlign = ContentAlignment.MiddleLeft;
            buttonConfig.Location = new Point(624, 28);
            buttonConfig.Name = "buttonConfig";
            buttonConfig.Size = new Size(48, 48);
            buttonConfig.TabIndex = 8;
            buttonConfig.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonConfig.UseVisualStyleBackColor = false;
            buttonConfig.Click += buttonConfig_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(884, 599);
            Controls.Add(panel1);
            Controls.Add(menu1);
            ForeColor = SystemColors.ControlText;
            MaximizeBox = false;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Principal";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Menu menu1;
        private Panel panel1;
        private Label labelInicio;
        private Button buttonConfig;

        
    }
}