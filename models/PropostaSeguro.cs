using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinafTeste.models
{
    public class PropostaSeguro
    {
        public int IdPropostaSeguro { get; set; }
        public List<CoberturasCliente> CoberturasCliente { get; set; }
        public int Valortotalpremio { get; set; }
        public Cliente Cliente { get; set; }
    }
}

