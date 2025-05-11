namespace WFCadastroProduto
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        public void LimparFormulario()
        {
            txtUsuario.Clear();
            txtSenha.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Usuario us1 = new Usuario();
            us1.Codigo = 1;
            us1.Login = "admin";
            us1.Senha = "123456";
            us1.DataCadastro = Convert.ToDateTime("18/03/2025 18:30");
            Usuario.ListaUsuarios.Add(us1);
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            foreach (Usuario user in Usuario.ListaUsuarios)
            {
                if (user.Login == txtUsuario.Text && user.Senha == txtSenha.Text)
                {
                    FormMenu form = new FormMenu();
                    form.ShowDialog();
                    LimparFormulario();
                    return;
                }
            }
            MessageBox.Show("Senha e/ou Usuário incorreto(s)!",
                            "Erro!", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            LimparFormulario();
            return;
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAcessar_Click(sender, e);
                txtUsuario.Focus();
            }
        }

        private void btnLogar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtUsuario.Focus();
            }
        }
    }
}
