using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinafTeste.Models
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public List<string> Telefones { get; set; }
        public List<Endereco> Enderecos { get; set; }
        public List<DependenteAgregado> DependenteAgregado { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string DtNascimento { get; set; }
        public string Sexo { get; set; }
    }
}
