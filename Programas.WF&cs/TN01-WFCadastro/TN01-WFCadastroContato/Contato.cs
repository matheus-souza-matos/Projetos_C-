﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TN01_WFCadastroContato_
{

    public enum EtipoTelefone
    {
        Pessoal = 1,
        Comercial,
        Recado
    }
    public class Contato
    {
        public Contato(int codigo, string? nome, string? sobrenome, string? ddd, string? telefone, EtipoTelefone tipoTelefone, string? email)
        {
            Codigo = codigo;
            Nome = nome;
            Sobrenome = sobrenome;
            Ddd = ddd;
            Telefone = telefone;
            TipoTelefone = tipoTelefone;
            Email = email;
        }

        public Contato() { }

        public static List<Contato> ListaContatos = new List<Contato>();

        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public string? Sobrenome { get; set; }
        public string? Ddd { get; set; }
        public string? Telefone { get; set; }
        public EtipoTelefone TipoTelefone { get; set; }
        public string? Email { get; set; }
    }

}
