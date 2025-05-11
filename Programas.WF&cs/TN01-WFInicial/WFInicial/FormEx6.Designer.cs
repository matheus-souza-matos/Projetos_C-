namespace WFInicial
{
    partial class FormEx6
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
            txtNome = new TextBox();
            txtHorasTrabalhadas = new TextBox();
            txtValorHora = new TextBox();
            lblNome = new Label();
            lblHorasTrabalhadas = new Label();
            lblValorHora = new Label();
            btnRendaTotal = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(138, 35);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 0;
            // 
            // txtHorasTrabalhadas
            // 
            txtHorasTrabalhadas.Location = new Point(138, 85);
            txtHorasTrabalhadas.Name = "txtHorasTrabalhadas";
            txtHorasTrabalhadas.Size = new Size(100, 23);
            txtHorasTrabalhadas.TabIndex = 1;
            // 
            // txtValorHora
            // 
            txtValorHora.Location = new Point(138, 132);
            txtValorHora.Name = "txtValorHora";
            txtValorHora.Size = new Size(100, 23);
            txtValorHora.TabIndex = 2;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(26, 43);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 3;
            lblNome.Text = "Nome:";
            // 
            // lblHorasTrabalhadas
            // 
            lblHorasTrabalhadas.AutoSize = true;
            lblHorasTrabalhadas.Location = new Point(26, 88);
            lblHorasTrabalhadas.Name = "lblHorasTrabalhadas";
            lblHorasTrabalhadas.Size = new Size(106, 15);
            lblHorasTrabalhadas.TabIndex = 4;
            lblHorasTrabalhadas.Text = "Horas Trabalhadas:";
            // 
            // lblValorHora
            // 
            lblValorHora.AutoSize = true;
            lblValorHora.Location = new Point(26, 135);
            lblValorHora.Name = "lblValorHora";
            lblValorHora.Size = new Size(79, 15);
            lblValorHora.TabIndex = 5;
            lblValorHora.Text = "Valor da hora:";
            // 
            // btnRendaTotal
            // 
            btnRendaTotal.Location = new Point(138, 174);
            btnRendaTotal.Name = "btnRendaTotal";
            btnRendaTotal.Size = new Size(100, 27);
            btnRendaTotal.TabIndex = 6;
            btnRendaTotal.Text = "Renda Total";
            btnRendaTotal.UseVisualStyleBackColor = true;
            btnRendaTotal.Click += btnRendaTotal_Click;
            // 
            // FormEx6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 261);
            Controls.Add(btnRendaTotal);
            Controls.Add(lblValorHora);
            Controls.Add(lblHorasTrabalhadas);
            Controls.Add(lblNome);
            Controls.Add(txtValorHora);
            Controls.Add(txtHorasTrabalhadas);
            Controls.Add(txtNome);
            Name = "FormEx6";
            Text = "FormEx6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtHorasTrabalhadas;
        private TextBox txtValorHora;
        private Label lblNome;
        private Label lblHorasTrabalhadas;
        private Label lblValorHora;
        private Button btnRendaTotal;
    }
}