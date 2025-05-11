namespace WFInicial
{
    partial class FormEx8
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
            lblNum1 = new Label();
            lblNum2 = new Label();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            btnSoma = new Button();
            btnSubtracao = new Button();
            btnMultiplicacao = new Button();
            btnDivisao = new Button();
            btnPotenciacao = new Button();
            btnRadiacao = new Button();
            SuspendLayout();
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Location = new Point(103, 45);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(105, 15);
            lblNum1.TabIndex = 0;
            lblNum1.Text = "Primeiro Número :";
            lblNum1.Click += label1_Click;
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Location = new Point(102, 99);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(107, 15);
            lblNum2.TabIndex = 1;
            lblNum2.Text = "Segundo Número :";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(263, 42);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 23);
            txtNum1.TabIndex = 2;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(263, 96);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 23);
            txtNum2.TabIndex = 3;
            // 
            // btnSoma
            // 
            btnSoma.Location = new Point(100, 163);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(75, 23);
            btnSoma.TabIndex = 4;
            btnSoma.Text = "Soma";
            btnSoma.UseVisualStyleBackColor = true;
            btnSoma.Click += btnSoma_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.Location = new Point(185, 163);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(75, 23);
            btnSubtracao.TabIndex = 5;
            btnSubtracao.Text = "Subtração";
            btnSubtracao.UseVisualStyleBackColor = true;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.Location = new Point(272, 163);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(92, 23);
            btnMultiplicacao.TabIndex = 6;
            btnMultiplicacao.Text = "Multiplicação";
            btnMultiplicacao.UseVisualStyleBackColor = true;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.Location = new Point(100, 212);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(75, 23);
            btnDivisao.TabIndex = 7;
            btnDivisao.Text = "Divisão";
            btnDivisao.UseVisualStyleBackColor = true;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btnPotenciacao
            // 
            btnPotenciacao.Location = new Point(184, 212);
            btnPotenciacao.Name = "btnPotenciacao";
            btnPotenciacao.Size = new Size(95, 23);
            btnPotenciacao.TabIndex = 8;
            btnPotenciacao.Text = "Potenciação";
            btnPotenciacao.UseVisualStyleBackColor = true;
            btnPotenciacao.Click += btnPotenciacao_Click;
            // 
            // btnRadiacao
            // 
            btnRadiacao.Location = new Point(288, 212);
            btnRadiacao.Name = "btnRadiacao";
            btnRadiacao.Size = new Size(75, 23);
            btnRadiacao.TabIndex = 9;
            btnRadiacao.Text = "Radiação";
            btnRadiacao.UseVisualStyleBackColor = true;
            btnRadiacao.Click += btnRadiacao_Click;
            // 
            // FormEx8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRadiacao);
            Controls.Add(btnPotenciacao);
            Controls.Add(btnDivisao);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btnSubtracao);
            Controls.Add(btnSoma);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(lblNum2);
            Controls.Add(lblNum1);
            Name = "FormEx8";
            Text = "FormEx8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNum1;
        private Label lblNum2;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private Button btnSoma;
        private Button btnSubtracao;
        private Button btnMultiplicacao;
        private Button btnDivisao;
        private Button btnPotenciacao;
        private Button btnRadiacao;
    }
}