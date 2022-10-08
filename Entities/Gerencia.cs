using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace consumo
{
    public class Gerencia
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Departamento { get; set; }
        public bool Verificacao { get; set; } = false;
    }
}