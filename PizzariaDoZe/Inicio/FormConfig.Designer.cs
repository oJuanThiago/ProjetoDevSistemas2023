﻿namespace PizzariaDoZe
{
    partial class FormConfig
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
            groupBoxIdioma = new GroupBox();
            checkBoxReiniciar = new CheckBox();
            labelIdioma = new Label();
            comboBoxIdioma = new ComboBox();
            buttonSalvar = new Button();
            groupBoxBD = new GroupBox();
            labelStringConexao = new Label();
            textBoxStringConexao = new TextBox();
            labelProvider = new Label();
            comboBoxProvider = new ComboBox();
            buttonFechar = new Button();
            groupBoxIdioma.SuspendLayout();
            groupBoxBD.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxIdioma
            // 
            groupBoxIdioma.Controls.Add(checkBoxReiniciar);
            groupBoxIdioma.Controls.Add(labelIdioma);
            groupBoxIdioma.Controls.Add(comboBoxIdioma);
            groupBoxIdioma.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxIdioma.Location = new Point(95, 80);
            groupBoxIdioma.Name = "groupBoxIdioma";
            groupBoxIdioma.Size = new Size(684, 99);
            groupBoxIdioma.TabIndex = 0;
            groupBoxIdioma.TabStop = false;
            groupBoxIdioma.Text = "Linguagem/Cultura";
            // 
            // checkBoxReiniciar
            // 
            checkBoxReiniciar.AutoSize = true;
            checkBoxReiniciar.ForeColor = SystemColors.ActiveCaptionText;
            checkBoxReiniciar.Location = new Point(186, 49);
            checkBoxReiniciar.Name = "checkBoxReiniciar";
            checkBoxReiniciar.Size = new Size(236, 19);
            checkBoxReiniciar.TabIndex = 1;
            checkBoxReiniciar.Text = "Desejo mudar o idioma imediatamente.";
            checkBoxReiniciar.UseVisualStyleBackColor = true;
            // 
            // labelIdioma
            // 
            labelIdioma.AutoSize = true;
            labelIdioma.ForeColor = SystemColors.ActiveCaptionText;
            labelIdioma.Location = new Point(36, 30);
            labelIdioma.Name = "labelIdioma";
            labelIdioma.Size = new Size(45, 15);
            labelIdioma.TabIndex = 1;
            labelIdioma.Text = "Idioma";
            // 
            // comboBoxIdioma
            // 
            comboBoxIdioma.FormattingEnabled = true;
            comboBoxIdioma.Items.AddRange(new object[] { "pt-BR", "en-US", "es" });
            comboBoxIdioma.Location = new Point(36, 48);
            comboBoxIdioma.Name = "comboBoxIdioma";
            comboBoxIdioma.Size = new Size(118, 23);
            comboBoxIdioma.TabIndex = 0;
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
            buttonSalvar.Location = new Point(613, 424);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(80, 38);
            buttonSalvar.TabIndex = 71;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSalvar.UseVisualStyleBackColor = false;
            // 
            // groupBoxBD
            // 
            groupBoxBD.Controls.Add(labelStringConexao);
            groupBoxBD.Controls.Add(textBoxStringConexao);
            groupBoxBD.Controls.Add(labelProvider);
            groupBoxBD.Controls.Add(comboBoxProvider);
            groupBoxBD.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxBD.Location = new Point(95, 200);
            groupBoxBD.Name = "groupBoxBD";
            groupBoxBD.Size = new Size(684, 188);
            groupBoxBD.TabIndex = 2;
            groupBoxBD.TabStop = false;
            groupBoxBD.Text = "Banco de Dados";
            // 
            // labelStringConexao
            // 
            labelStringConexao.AutoSize = true;
            labelStringConexao.ForeColor = SystemColors.ActiveCaptionText;
            labelStringConexao.Location = new Point(36, 92);
            labelStringConexao.Name = "labelStringConexao";
            labelStringConexao.Size = new Size(104, 15);
            labelStringConexao.TabIndex = 3;
            labelStringConexao.Text = "String de Conexão";
            // 
            // textBoxStringConexao
            // 
            textBoxStringConexao.Location = new Point(36, 110);
            textBoxStringConexao.Name = "textBoxStringConexao";
            textBoxStringConexao.Size = new Size(500, 23);
            textBoxStringConexao.TabIndex = 2;
            // 
            // labelProvider
            // 
            labelProvider.AutoSize = true;
            labelProvider.ForeColor = SystemColors.ActiveCaptionText;
            labelProvider.Location = new Point(36, 30);
            labelProvider.Name = "labelProvider";
            labelProvider.Size = new Size(51, 15);
            labelProvider.TabIndex = 1;
            labelProvider.Text = "Provider";
            // 
            // comboBoxProvider
            // 
            comboBoxProvider.FormattingEnabled = true;
            comboBoxProvider.Items.AddRange(new object[] { "MySql.Data.MySqlClient", "System.Data.SqlClient" });
            comboBoxProvider.Location = new Point(36, 48);
            comboBoxProvider.Name = "comboBoxProvider";
            comboBoxProvider.Size = new Size(118, 23);
            comboBoxProvider.TabIndex = 0;
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
            buttonFechar.Location = new Point(699, 424);
            buttonFechar.Name = "buttonFechar";
            buttonFechar.Size = new Size(80, 38);
            buttonFechar.TabIndex = 72;
            buttonFechar.Text = "Fechar";
            buttonFechar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonFechar.UseVisualStyleBackColor = false;
            // 
            // FormConfig
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(881, 533);
            Controls.Add(buttonFechar);
            Controls.Add(groupBoxBD);
            Controls.Add(buttonSalvar);
            Controls.Add(groupBoxIdioma);
            Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlLightLight;
            MaximizeBox = false;
            Name = "FormConfig";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configurações";
            groupBoxIdioma.ResumeLayout(false);
            groupBoxIdioma.PerformLayout();
            groupBoxBD.ResumeLayout(false);
            groupBoxBD.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxIdioma;
        private Label labelIdioma;
        private ComboBox comboBoxIdioma;
        private CheckBox checkBoxReiniciar;
        private Button buttonSalvar;
        private GroupBox groupBoxBD;
        private Label labelStringConexao;
        private TextBox textBoxStringConexao;
        private Label labelProvider;
        private ComboBox comboBoxProvider;
        private Button buttonFechar;
    }
}