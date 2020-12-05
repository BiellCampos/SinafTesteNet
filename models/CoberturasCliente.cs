using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinafTeste.Models
{
    public class CoberturasCliente
    {
        public int IdCoberturascliente { get; set; }
        public int IdCliente { get; set; }
        public Cobertura Cobertura { get; set; }
        public int Valorsegurado { get; set; }
        public int Valorpremio { get; set; }
    }
}
