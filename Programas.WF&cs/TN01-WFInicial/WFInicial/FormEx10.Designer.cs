namespace WFInicial
{
    partial class FormEx10
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
            lblNome = new Label();
            txtNumero = new TextBox();
            txtResultado = new TextBox();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(24, 37);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(51, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Número";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(122, 34);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(50, 23);
            txtNumero.TabIndex = 1;
            txtNumero.Leave += txtNumero_Leave;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(25, 78);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(148, 189);
            txtResultado.TabIndex = 2;
            // 
            // FormEx10
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(200, 278);
            Controls.Add(txtResultado);
            Controls.Add(txtNumero);
            Controls.Add(lblNome);
            Name = "FormEx10";
            Text = "FormEx10";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNumero;
        private TextBox txtResultado;
    }
}