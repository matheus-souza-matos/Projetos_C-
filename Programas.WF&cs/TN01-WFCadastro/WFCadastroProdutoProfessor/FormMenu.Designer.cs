﻿namespace WFCadastroProdutoProfessor
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            picImagem = new PictureBox();
            menuStrip1 = new MenuStrip();
            mnsCadastrar = new ToolStripMenuItem();
            mnsListar = new ToolStripMenuItem();
            mnsSair = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)picImagem).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // picImagem
            // 
            picImagem.Dock = DockStyle.Fill;
            picImagem.Image = (Image)resources.GetObject("picImagem.Image");
            picImagem.Location = new Point(0, 24);
            picImagem.Name = "picImagem";
            picImagem.Size = new Size(361, 267);
            picImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            picImagem.TabIndex = 3;
            picImagem.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnsCadastrar, mnsListar, mnsSair });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(361, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnsCadastrar
            // 
            mnsCadastrar.Name = "mnsCadastrar";
            mnsCadastrar.Size = new Size(69, 20);
            mnsCadastrar.Text = "Cadastrar";
            mnsCadastrar.Click += mnsCadastrar_Click;
            // 
            // mnsListar
            // 
            mnsListar.Name = "mnsListar";
            mnsListar.Size = new Size(47, 20);
            mnsListar.Text = "Listar";
            mnsListar.Click += mnsListar_Click;
            // 
            // mnsSair
            // 
            mnsSair.Name = "mnsSair";
            mnsSair.Size = new Size(38, 20);
            mnsSair.Text = "Sair";
            mnsSair.Click += mnsSair_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 291);
            Controls.Add(picImagem);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            ((System.ComponentModel.ISupportInitialize)picImagem).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picImagem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnsCadastrar;
        private ToolStripMenuItem mnsListar;
        private ToolStripMenuItem mnsSair;
    }
}