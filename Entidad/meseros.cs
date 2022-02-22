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
        public bool ocupado { get; set; }
        public List<mesa> Mesa_aux = new List<mesa>();
    }
}
