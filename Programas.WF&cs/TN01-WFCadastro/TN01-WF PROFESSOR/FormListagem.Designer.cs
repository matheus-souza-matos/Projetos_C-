﻿namespace TN01_WFPROFESSORCadastroContato
{
    partial class FormListagem
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
            dgvListaContatos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvListaContatos).BeginInit();
            SuspendLayout();
            // 
            // dgvListaContatos
            // 
            dgvListaContatos.Location = new Point(12, 12);
            dgvListaContatos.Name = "dgvListaContatos";
            dgvListaContatos.Size = new Size(584, 220);
            dgvListaContatos.TabIndex = 0;
            // 
            // FormListagem
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 244);
            Controls.Add(dgvListaContatos);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormListagem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listagem de Contatos";
            Load += FormListagem_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListaContatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListaContatos;
    }
}