namespace TN01_WFCadastroContato_
{
    partial class FormCadastrarContato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastrarContato));
            lblNome = new Label();
            lblSobrenome = new Label();
            txtNome = new TextBox();
            txtSobrenome = new TextBox();
            lblLinha1 = new Label();
            lblTelefone = new Label();
            mkdTelefone = new MaskedTextBox();
            gbxTipoTelefone = new GroupBox();
            rdbComercial = new RadioButton();
            rdbPessoal = new RadioButton();
            rdbRecado = new RadioButton();
            lbllinha2 = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            btnVoltar = new Button();
            btnSalvar = new Button();
            gbxTipoTelefone.SuspendLayout();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(26, 24);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(46, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome :";
            // 
            // lblSobrenome
            // 
            lblSobrenome.AutoSize = true;
            lblSobrenome.Location = new Point(268, 24);
            lblSobrenome.Name = "lblSobrenome";
            lblSobrenome.Size = new Size(74, 15);
            lblSobrenome.TabIndex = 1;
            lblSobrenome.Text = "Sobrenome :";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(27, 51);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(153, 23);
            txtNome.TabIndex = 0;
            // 
            // txtSobrenome
            // 
            txtSobrenome.Location = new Point(268, 51);
            txtSobrenome.Name = "txtSobrenome";
            txtSobrenome.Size = new Size(159, 23);
            txtSobrenome.TabIndex = 1;
            // 
            // lblLinha1
            // 
            lblLinha1.BorderStyle = BorderStyle.Fixed3D;
            lblLinha1.Location = new Point(27, 97);
            lblLinha1.Name = "lblLinha1";
            lblLinha1.Size = new Size(400, 1);
            lblLinha1.TabIndex = 4;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(26, 121);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(80, 15);
            lblTelefone.TabIndex = 5;
            lblTelefone.Text = "DDD/Telefone";
            // 
            // mkdTelefone
            // 
            mkdTelefone.Location = new Point(27, 139);
            mkdTelefone.Mask = "(99) 00000-0000";
            mkdTelefone.Name = "mkdTelefone";
            mkdTelefone.Size = new Size(100, 23);
            mkdTelefone.TabIndex = 2;
            mkdTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // gbxTipoTelefone
            // 
            gbxTipoTelefone.Controls.Add(rdbComercial);
            gbxTipoTelefone.Controls.Add(rdbPessoal);
            gbxTipoTelefone.Controls.Add(rdbRecado);
            gbxTipoTelefone.Location = new Point(168, 122);
            gbxTipoTelefone.Name = "gbxTipoTelefone";
            gbxTipoTelefone.Size = new Size(229, 55);
            gbxTipoTelefone.TabIndex = 4;
            gbxTipoTelefone.TabStop = false;
            gbxTipoTelefone.Text = "Tipo Telefone : ";
            // 
            // rdbComercial
            // 
            rdbComercial.AutoSize = true;
            rdbComercial.Location = new Point(76, 22);
            rdbComercial.Name = "rdbComercial";
            rdbComercial.Size = new Size(79, 19);
            rdbComercial.TabIndex = 1;
            rdbComercial.TabStop = true;
            rdbComercial.Text = "Comercial";
            rdbComercial.UseVisualStyleBackColor = true;
            // 
            // rdbPessoal
            // 
            rdbPessoal.AutoSize = true;
            rdbPessoal.Location = new Point(6, 22);
            rdbPessoal.Name = "rdbPessoal";
            rdbPessoal.Size = new Size(64, 19);
            rdbPessoal.TabIndex = 0;
            rdbPessoal.TabStop = true;
            rdbPessoal.Text = "Pessoal";
            rdbPessoal.UseVisualStyleBackColor = true;
            // 
            // rdbRecado
            // 
            rdbRecado.AutoSize = true;
            rdbRecado.Location = new Point(161, 22);
            rdbRecado.Name = "rdbRecado";
            rdbRecado.Size = new Size(64, 19);
            rdbRecado.TabIndex = 2;
            rdbRecado.TabStop = true;
            rdbRecado.Text = "Recado";
            rdbRecado.UseVisualStyleBackColor = true;
            // 
            // lbllinha2
            // 
            lbllinha2.BorderStyle = BorderStyle.Fixed3D;
            lbllinha2.Location = new Point(27, 207);
            lbllinha2.Name = "lbllinha2";
            lbllinha2.Size = new Size(400, 1);
            lbllinha2.TabIndex = 9;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(26, 227);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(47, 15);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "E-mail :";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(26, 245);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(401, 23);
            txtEmail.TabIndex = 5;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(214, 329);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(98, 39);
            btnVoltar.TabIndex = 7;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.Location = new Point(329, 329);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(98, 39);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FormCadastrarContato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 388);
            Controls.Add(btnSalvar);
            Controls.Add(btnVoltar);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(lbllinha2);
            Controls.Add(gbxTipoTelefone);
            Controls.Add(mkdTelefone);
            Controls.Add(lblTelefone);
            Controls.Add(lblLinha1);
            Controls.Add(txtSobrenome);
            Controls.Add(txtNome);
            Controls.Add(lblSobrenome);
            Controls.Add(lblNome);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastrarContato";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCadastrarContato";
            gbxTipoTelefone.ResumeLayout(false);
            gbxTipoTelefone.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblSobrenome;
        private TextBox txtNome;
        private TextBox txtSobrenome;
        private Label lblLinha1;
        private Label lblTelefone;
        private MaskedTextBox mkdTelefone;
        private GroupBox gbxTipoTelefone;
        private RadioButton rdbComercial;
        private RadioButton rdbPessoal;
        private RadioButton rdbRecado;
        private Label lbllinha2;
        private Label lblEmail;
        private TextBox txtEmail;
        private Button btnVoltar;
        private Button btnSalvar;
    }
}