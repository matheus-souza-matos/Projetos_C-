﻿namespace WFCadastroProduto
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
            dgvListaProdutos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvListaProdutos).BeginInit();
            SuspendLayout();
            // 
            // dgvListaProdutos
            // 
            dgvListaProdutos.Location = new Point(12, 12);
            dgvListaProdutos.Name = "dgvListaProdutos";
            dgvListaProdutos.Size = new Size(584, 220);
            dgvListaProdutos.TabIndex = 0;
            // 
            // FormListagem
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 244);
            Controls.Add(dgvListaProdutos);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormListagem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de produtos";
            Load += FormListagem_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListaProdutos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListaProdutos;
    }
}