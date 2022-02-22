using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class cuenta
    {
        public int n_mesa { get; set; }
        public List <platos> Platos { get; set; }
        public meseros M { get; set; }
        public bool eliminar { get; set; }
        public float total { get; set; }
    }
}
