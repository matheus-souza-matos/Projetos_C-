namespace WFCadastroEndereco
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
            lblNomeCompleto = new Label();
            txtNomeCompleto = new TextBox();
            btnSalvar = new Button();
            lblCep = new Label();
            lblLinha = new Label();
            mtbCep = new MaskedTextBox();
            lblLogradouro = new Label();
            txtLogradouro = new TextBox();
            txtComplemento = new TextBox();
            lblComplemento = new Label();
            lblNumero = new Label();
            txtNumero = new TextBox();
            txtBairro = new TextBox();
            lblBairro = new Label();
            txtCidade = new TextBox();
            lblCidade = new Label();
            lblUf = new Label();
            cbxUf = new ComboBox();
            chkSemNumero = new CheckBox();
            SuspendLayout();
            // 
            // lblNomeCompleto
            // 
            lblNomeCompleto.AutoSize = true;
            lblNomeCompleto.Location = new Point(26, 24);
            lblNomeCompleto.Name = "lblNomeCompleto";
            lblNomeCompleto.Size = new Size(102, 15);
            lblNomeCompleto.TabIndex = 0;
            lblNomeCompleto.Text = "Nome Completo :";
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Location = new Point(26, 42);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(450, 23);
            txtNomeCompleto.TabIndex = 0;
            // 
            // btnSalvar
            // 
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.Location = new Point(361, 413);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(107, 38);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Location = new Point(24, 118);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(34, 15);
            lblCep.TabIndex = 9;
            lblCep.Text = "Cep :";
            // 
            // lblLinha
            // 
            lblLinha.BorderStyle = BorderStyle.Fixed3D;
            lblLinha.Location = new Point(26, 84);
            lblLinha.Name = "lblLinha";
            lblLinha.Size = new Size(450, 1);
            lblLinha.TabIndex = 11;
            // 
            // mtbCep
            // 
            mtbCep.Location = new Point(26, 140);
            mtbCep.Mask = "00000-999";
            mtbCep.Name = "mtbCep";
            mtbCep.Size = new Size(100, 23);
            mtbCep.TabIndex = 1;
            // 
            // lblLogradouro
            // 
            lblLogradouro.AutoSize = true;
            lblLogradouro.Location = new Point(26, 186);
            lblLogradouro.Name = "lblLogradouro";
            lblLogradouro.Size = new Size(75, 15);
            lblLogradouro.TabIndex = 19;
            lblLogradouro.Text = "Logradouro :";
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(26, 204);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(237, 23);
            txtLogradouro.TabIndex = 2;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(26, 266);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(202, 23);
            txtComplemento.TabIndex = 5;
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Location = new Point(26, 248);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(90, 15);
            lblComplemento.TabIndex = 21;
            lblComplemento.Text = "Complemento :";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(269, 186);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(57, 15);
            lblNumero.TabIndex = 23;
            lblNumero.Text = "Número :";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(269, 204);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(107, 23);
            txtNumero.TabIndex = 3;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(234, 266);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(234, 23);
            txtBairro.TabIndex = 6;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(234, 248);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(44, 15);
            lblBairro.TabIndex = 25;
            lblBairro.Text = "Bairro :";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(26, 331);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(315, 23);
            txtCidade.TabIndex = 7;
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(26, 313);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(50, 15);
            lblCidade.TabIndex = 27;
            lblCidade.Text = "Cidade :";
            // 
            // lblUf
            // 
            lblUf.AutoSize = true;
            lblUf.Location = new Point(347, 313);
            lblUf.Name = "lblUf";
            lblUf.Size = new Size(27, 15);
            lblUf.TabIndex = 29;
            lblUf.Text = "UF :";
            // 
            // cbxUf
            // 
            cbxUf.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxUf.FormattingEnabled = true;
            cbxUf.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cbxUf.Location = new Point(347, 331);
            cbxUf.Name = "cbxUf";
            cbxUf.Size = new Size(121, 23);
            cbxUf.TabIndex = 8;
            // 
            // chkSemNumero
            // 
            chkSemNumero.AutoSize = true;
            chkSemNumero.Location = new Point(382, 208);
            chkSemNumero.Name = "chkSemNumero";
            chkSemNumero.Size = new Size(94, 19);
            chkSemNumero.TabIndex = 4;
            chkSemNumero.Text = "Sem número";
            chkSemNumero.UseVisualStyleBackColor = true;
            chkSemNumero.CheckedChanged += chkSemNumero_CheckedChanged;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 478);
            Controls.Add(chkSemNumero);
            Controls.Add(cbxUf);
            Controls.Add(lblUf);
            Controls.Add(txtCidade);
            Controls.Add(lblCidade);
            Controls.Add(txtBairro);
            Controls.Add(lblBairro);
            Controls.Add(txtNumero);
            Controls.Add(lblNumero);
            Controls.Add(txtComplemento);
            Controls.Add(lblComplemento);
            Controls.Add(txtLogradouro);
            Controls.Add(lblLogradouro);
            Controls.Add(mtbCep);
            Controls.Add(lblLinha);
            Controls.Add(lblCep);
            Controls.Add(btnSalvar);
            Controls.Add(txtNomeCompleto);
            Controls.Add(lblNomeCompleto);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeCompleto;
        private TextBox txtNomeCompleto;
        private Button btnSalvar;
        private Label lblCep;
        private Label lblLinha;
        private MaskedTextBox mtbCep;
        private Label lblLogradouro;
        private TextBox txtLogradouro;
        private TextBox txtComplemento;
        private Label lblComplemento;
        private Label lblNumero;
        private TextBox txtNumero;
        private TextBox txtBairro;
        private Label lblBairro;
        private TextBox txtCidade;
        private Label lblCidade;
        private Label lblUf;
        private ComboBox cbxUf;
        private CheckBox chkSemNumero;
    }
}