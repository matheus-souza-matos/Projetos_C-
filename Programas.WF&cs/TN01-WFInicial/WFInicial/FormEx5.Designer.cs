﻿namespace WFInicial
{
    partial class FormEx5
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
            lblNum3 = new Label();
            txtNum3 = new TextBox();
            btnMaiorMenor = new Button();
            lblNum2 = new Label();
            lblNum1 = new Label();
            txtNum2 = new TextBox();
            txtNum1 = new TextBox();
            SuspendLayout();
            // 
            // lblNum3
            // 
            lblNum3.AutoSize = true;
            lblNum3.Location = new Point(39, 117);
            lblNum3.Name = "lblNum3";
            lblNum3.Size = new Size(63, 15);
            lblNum3.TabIndex = 18;
            lblNum3.Text = "Número 3:";
            // 
            // txtNum3
            // 
            txtNum3.Location = new Point(108, 109);
            txtNum3.Name = "txtNum3";
            txtNum3.Size = new Size(100, 23);
            txtNum3.TabIndex = 17;
            // 
            // btnMaiorMenor
            // 
            btnMaiorMenor.Location = new Point(39, 167);
            btnMaiorMenor.Name = "btnMaiorMenor";
            btnMaiorMenor.Size = new Size(169, 35);
            btnMaiorMenor.TabIndex = 16;
            btnMaiorMenor.Text = "Mostrar Maior e Menor";
            btnMaiorMenor.UseVisualStyleBackColor = true;
            btnMaiorMenor.Click += btnMaiorMenor_Click;
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Location = new Point(39, 72);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(63, 15);
            lblNum2.TabIndex = 15;
            lblNum2.Text = "Número 2:";
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Location = new Point(39, 26);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(63, 15);
            lblNum1.TabIndex = 14;
            lblNum1.Text = "Número 1:";
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(108, 64);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 23);
            txtNum2.TabIndex = 13;
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(108, 23);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 23);
            txtNum1.TabIndex = 12;
            // 
            // FormEx5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 261);
            Controls.Add(lblNum3);
            Controls.Add(txtNum3);
            Controls.Add(btnMaiorMenor);
            Controls.Add(lblNum2);
            Controls.Add(lblNum1);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Name = "FormEx5";
            Text = "FormEx5";
            Load += FormEx5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNum3;
        private TextBox txtNum3;
        private Button btnMaiorMenor;
        private Label lblNum2;
        private Label lblNum1;
        private TextBox txtNum2;
        private TextBox txtNum1;
    }
}