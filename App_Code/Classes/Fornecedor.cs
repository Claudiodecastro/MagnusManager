﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Fornecedor
/// </summary>

namespace MagnusManager.Classes
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public long Cnpj { get; set; }
        public String NomeContato { get; set; }
        public String Endereco { get; set; }
        public String Cidade { get; set; }
        public String Estado { get; set; }
        public long Telefone { get; set; }
        public String Email { get; set; }

        public Fornecedor()
        {

        }
    }
}