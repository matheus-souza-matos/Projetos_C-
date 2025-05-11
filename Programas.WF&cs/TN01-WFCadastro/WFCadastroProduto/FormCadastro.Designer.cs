namespace WFCadastroProduto 
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
            lblCategoria = new Label();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            lblNomeProduto = new Label();
            txtNomeProduto = new TextBox();
            cbxCategoria = new ComboBox();
            lblPreco = new Label();
            nudPreco = new NumericUpDown();
            lblDataVencimento = new Label();
            lblObservacao = new Label();
            txtObservacao = new TextBox();
            dtpDataValidade = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)nudPreco).BeginInit();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCadastrar.Image = (Image)resources.GetObject("btnCadastrar.Image");
            btnCadastrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadastrar.Location = new Point(179, 305);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(83, 29);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(123, 9);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(64, 15);
            lblCategoria.TabIndex = 8;
            lblCategoria.Text = "Categoria :";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(12, 27);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(86, 23);
            txtCodigo.TabIndex = 0;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(12, 9);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(52, 15);
            lblCodigo.TabIndex = 5;
            lblCodigo.Text = "Código :";
            // 
            // lblNomeProduto
            // 
            lblNomeProduto.AutoSize = true;
            lblNomeProduto.Location = new Point(12, 71);
            lblNomeProduto.Name = "lblNomeProduto";
            lblNomeProduto.Size = new Size(109, 15);
            lblNomeProduto.TabIndex = 11;
            lblNomeProduto.Text = "Nome do Produto :";
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(12, 89);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(250, 23);
            txtNomeProduto.TabIndex = 1;
            // 
            // cbxCategoria
            // 
            cbxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCategoria.FormattingEnabled = true;
            cbxCategoria.Items.AddRange(new object[] { "Laticínios", "Açougue", "Padaria", "Adega", "Limpeza", "Hortifruti" });
            cbxCategoria.Location = new Point(123, 27);
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(139, 23);
            cbxCategoria.TabIndex = 0;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(12, 131);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(43, 15);
            lblPreco.TabIndex = 13;
            lblPreco.Text = "Preço :";
            // 
            // nudPreco
            // 
            nudPreco.DecimalPlaces = 2;
            nudPreco.Location = new Point(13, 149);
            nudPreco.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nudPreco.Name = "nudPreco";
            nudPreco.Size = new Size(109, 23);
            nudPreco.TabIndex = 2;
            // 
            // lblDataVencimento
            // 
            lblDataVencimento.AutoSize = true;
            lblDataVencimento.Location = new Point(141, 131);
            lblDataVencimento.Name = "lblDataVencimento";
            lblDataVencimento.Size = new Size(119, 15);
            lblDataVencimento.TabIndex = 16;
            lblDataVencimento.Text = "Data de Vencimento :";
            // 
            // lblObservacao
            // 
            lblObservacao.AutoSize = true;
            lblObservacao.Location = new Point(12, 188);
            lblObservacao.Name = "lblObservacao";
            lblObservacao.Size = new Size(75, 15);
            lblObservacao.TabIndex = 17;
            lblObservacao.Text = "Observação :";
            // 
            // txtObservacao
            // 
            txtObservacao.Location = new Point(13, 210);
            txtObservacao.Multiline = true;
            txtObservacao.Name = "txtObservacao";
            txtObservacao.Size = new Size(247, 78);
            txtObservacao.TabIndex = 4;
            // 
            // dtpDataValidade
            // 
            dtpDataValidade.Format = DateTimePickerFormat.Short;
            dtpDataValidade.Location = new Point(141, 149);
            dtpDataValidade.Name = "dtpDataValidade";
            dtpDataValidade.Size = new Size(119, 23);
            dtpDataValidade.TabIndex = 3;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 346);
            Controls.Add(dtpDataValidade);
            Controls.Add(txtObservacao);
            Controls.Add(lblObservacao);
            Controls.Add(lblDataVencimento);
            Controls.Add(nudPreco);
            Controls.Add(lblPreco);
            Controls.Add(cbxCategoria);
            Controls.Add(lblNomeProduto);
            Controls.Add(txtNomeProduto);
            Controls.Add(btnCadastrar);
            Controls.Add(lblCategoria);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Produto";
            Load += FormCadastro_Load;
            ((System.ComponentModel.ISupportInitialize)nudPreco).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastrar;
        private Label lblCategoria;
        private TextBox txtCodigo;
        private Label lblCodigo;
        private Label lblNomeProduto;
        private TextBox txtNomeProduto;
        private ComboBox cbxCategoria;
        private Label lblPreco;
        private NumericUpDown nudPreco;
        private Label lblDataVencimento;
        private Label lblObservacao;
        private TextBox txtObservacao;
        private DateTimePicker dtpDataValidade;
    }
}