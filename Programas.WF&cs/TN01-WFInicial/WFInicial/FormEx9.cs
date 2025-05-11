﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFInicial
{
    public partial class FormEx9 : Form
    {
        public FormEx9()
        {
            InitializeComponent();
        }

        private void FormEx9_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Usuario us1 = new Usuario();
            bool entrou = true;
            us1.Nome = txtUsuario.Text;
            us1.Senha = txtSenha.Text;

            entrou = us1.EfetuarLogin();
            if(entrou == false)
            {
                txtUsuario.Text = "";
                txtSenha.Text = "";
            }
            else
            {
                MessageBox.Show("Bem vindo ao sistema!", "Sucesso!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Fecha a Janela do Formulário
                this.Dispose();
            }
        }
    }
}
