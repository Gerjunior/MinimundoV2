﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Minimundo.Domain.Entities
{
    public class Endereco : BaseEntity
    {
        public int EnderecoID { get; set; }
        public int UsuarioID { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
    }
}
