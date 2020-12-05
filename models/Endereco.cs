using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinafTeste.Models
{
    public class Endereco
    {
        public int IdEndereco { get; set; }
        public int IdCliente { get; set; }
        public string Cep { get; set; }
        public string EnderecoLog { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
    }
}
