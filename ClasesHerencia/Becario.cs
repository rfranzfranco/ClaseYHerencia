using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesHerencia
{
    internal class Becario : Usuario
    {
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Tipo_beca { get; set; }
        public DateTime f_inicio { get; set; }
        public DateTime f_final { get; set; }
        public decimal Monto { get; set; }
    }
}
