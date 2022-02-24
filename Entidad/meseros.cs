using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class meseros
    {
        public string nombre { get; set; }
        public string dni { get; set; }
        public bool ocupado { get; set; }  // si esta disponible 
        public mesa Mesa_aux { get; set; }

    }
}
