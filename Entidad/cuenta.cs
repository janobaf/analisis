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
        public List<platos> Platos = new List<platos>();
        public meseros M { get; set; }
        public bool eliminar { get; set; }
        public float total { get; set; }

        public float pagar_total { get; set; }
    }

    public class cuenta_aux_platos
    {
        public string nombre_plato { get; set; }
       
    }

    public class cuenta_aux_meseros
    {
        public string nombre { get; set; }
    }
}
