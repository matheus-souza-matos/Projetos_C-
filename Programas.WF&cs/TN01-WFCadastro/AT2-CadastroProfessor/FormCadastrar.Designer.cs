namespace AT2_CadastroProfessor
{
    partial class FormCadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastrar));
            mtbCodigo = new MaskedTextBox();
            lblCodigo = new Label();
            lblCategria = new Label();
            txtNomeCategoria = new TextBox();
            gbxStatus = new GroupBox();
            rdbInativo = new RadioButton();
            rdbAtivo = new RadioButton();
            lblDescricao = new Label();
            rtbDescricao = new RichTextBox();
            btnSalvar = new Button();
            gbxStatus.SuspendLayout();
            SuspendLayout();
            // 
            // mtbCodigo
            // 
            mtbCodigo.Enabled = false;
            mtbCodigo.Location = new Point(12, 34);
            mtbCodigo.Mask = "0000";
            mtbCodigo.Name = "mtbCodigo";
            mtbCodigo.Size = new Size(100, 23);
            mtbCodigo.TabIndex = 0;
            mtbCodigo.ValidatingType = typeof(int);
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(12, 16);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(49, 15);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Código:";
            // 
            // lblCategria
            // 
            lblCategria.AutoSize = true;
            lblCategria.Location = new Point(12, 87);
            lblCategria.Name = "lblCategria";
            lblCategria.Size = new Size(61, 15);
            lblCategria.TabIndex = 2;
            lblCategria.Text = "Categoria:";
            // 
            // txtNomeCategoria
            // 
            txtNomeCategoria.Location = new Point(14, 105);
            txtNomeCategoria.Name = "txtNomeCategoria";
            txtNomeCategoria.Size = new Size(229, 23);
            txtNomeCategoria.TabIndex = 3;
            // 
            // gbxStatus
            // 
            gbxStatus.Controls.Add(rdbInativo);
            gbxStatus.Controls.Add(rdbAtivo);
            gbxStatus.Location = new Point(127, 12);
            gbxStatus.Name = "gbxStatus";
            gbxStatus.Size = new Size(116, 77);
            gbxStatus.TabIndex = 4;
            gbxStatus.TabStop = false;
            gbxStatus.Text = "Status";
            // 
            // rdbInativo
            // 
            rdbInativo.AutoSize = true;
            rdbInativo.Location = new Point(26, 47);
            rdbInativo.Name = "rdbInativo";
            rdbInativo.Size = new Size(61, 19);
            rdbInativo.TabIndex = 1;
            rdbInativo.TabStop = true;
            rdbInativo.Text = "Inativo";
            rdbInativo.UseVisualStyleBackColor = true;
            // 
            // rdbAtivo
            // 
            rdbAtivo.AutoSize = true;
            rdbAtivo.Location = new Point(26, 22);
            rdbAtivo.Name = "rdbAtivo";
            rdbAtivo.Size = new Size(53, 19);
            rdbAtivo.TabIndex = 0;
            rdbAtivo.TabStop = true;
            rdbAtivo.Text = "Ativo";
            rdbAtivo.UseVisualStyleBackColor = true;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(12, 153);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(61, 15);
            lblDescricao.TabIndex = 5;
            lblDescricao.Text = "Descrição:";
            // 
            // rtbDescricao
            // 
            rtbDescricao.Location = new Point(14, 171);
            rtbDescricao.Name = "rtbDescricao";
            rtbDescricao.Size = new Size(229, 96);
            rtbDescricao.TabIndex = 6;
            rtbDescricao.Text = "";
            // 
            // btnSalvar
            // 
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.Location = new Point(158, 286);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(85, 46);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FormCadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(260, 348);
            Controls.Add(btnSalvar);
            Controls.Add(rtbDescricao);
            Controls.Add(lblDescricao);
            Controls.Add(gbxStatus);
            Controls.Add(txtNomeCategoria);
            Controls.Add(lblCategria);
            Controls.Add(lblCodigo);
            Controls.Add(mtbCodigo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Categorias";
            Load += FormCadastrar_Load;
            gbxStatus.ResumeLayout(false);
            gbxStatus.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox mtbCodigo;
        private Label lblCodigo;
        private Label lblCategria;
        private TextBox txtNomeCategoria;
        private GroupBox gbxStatus;
        private RadioButton rdbInativo;
        private RadioButton rdbAtivo;
        private Label lblDescricao;
        private RichTextBox rtbDescricao;
        private Button btnSalvar;
    }
}