namespace WFUsandoListagem
{
    partial class FormCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastro));
            btnCadastrar = new Button();
            lblSenhaNova = new Label();
            txtSenhaNova = new TextBox();
            txtUsuarioNovo = new TextBox();
            lblUsuarioNovo = new Label();
            lblConfirmarSenha = new Label();
            txtConfirmarSenha = new TextBox();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCadastrar.Image = (Image)resources.GetObject("btnCadastrar.Image");
            btnCadastrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadastrar.Location = new Point(111, 211);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(83, 29);
            btnCadastrar.TabIndex = 3;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lblSenhaNova
            // 
            lblSenhaNova.AutoSize = true;
            lblSenhaNova.Location = new Point(45, 87);
            lblSenhaNova.Name = "lblSenhaNova";
            lblSenhaNova.Size = new Size(45, 15);
            lblSenhaNova.TabIndex = 8;
            lblSenhaNova.Text = "Senha :";
            // 
            // txtSenhaNova
            // 
            txtSenhaNova.Location = new Point(45, 105);
            txtSenhaNova.Name = "txtSenhaNova";
            txtSenhaNova.PasswordChar = '*';
            txtSenhaNova.PlaceholderText = "Informe a Senha...";
            txtSenhaNova.Size = new Size(149, 23);
            txtSenhaNova.TabIndex = 1;
            // 
            // txtUsuarioNovo
            // 
            txtUsuarioNovo.Location = new Point(45, 49);
            txtUsuarioNovo.Name = "txtUsuarioNovo";
            txtUsuarioNovo.PlaceholderText = "Informe o Usuário...";
            txtUsuarioNovo.Size = new Size(149, 23);
            txtUsuarioNovo.TabIndex = 0;
            // 
            // lblUsuarioNovo
            // 
            lblUsuarioNovo.AutoSize = true;
            lblUsuarioNovo.Location = new Point(45, 31);
            lblUsuarioNovo.Name = "lblUsuarioNovo";
            lblUsuarioNovo.Size = new Size(53, 15);
            lblUsuarioNovo.TabIndex = 5;
            lblUsuarioNovo.Text = "Usuário :";
            // 
            // lblConfirmarSenha
            // 
            lblConfirmarSenha.AutoSize = true;
            lblConfirmarSenha.Location = new Point(45, 144);
            lblConfirmarSenha.Name = "lblConfirmarSenha";
            lblConfirmarSenha.Size = new Size(101, 15);
            lblConfirmarSenha.TabIndex = 11;
            lblConfirmarSenha.Text = "Confirmar senha :";
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Location = new Point(45, 162);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.PasswordChar = '*';
            txtConfirmarSenha.PlaceholderText = "Confirmar Senha...";
            txtConfirmarSenha.Size = new Size(149, 23);
            txtConfirmarSenha.TabIndex = 2;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(253, 273);
            Controls.Add(lblConfirmarSenha);
            Controls.Add(txtConfirmarSenha);
            Controls.Add(btnCadastrar);
            Controls.Add(lblSenhaNova);
            Controls.Add(txtSenhaNova);
            Controls.Add(txtUsuarioNovo);
            Controls.Add(lblUsuarioNovo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Novo Usuário";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastrar;
        private Label lblSenhaNova;
        private TextBox txtSenhaNova;
        private TextBox txtUsuarioNovo;
        private Label lblUsuarioNovo;
        private Label lblConfirmarSenha;
        private TextBox txtConfirmarSenha;
    }
}