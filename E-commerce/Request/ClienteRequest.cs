﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_commerce.Request
{
    public class ClienteRequest
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string CPFCNPJ { get; set; }
        public string Endereco { get; set; }
        public string DataDeNascimento { get; set; }
        public string Sexo { get; set; }

    }
}
