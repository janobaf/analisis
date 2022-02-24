using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
namespace funciones
{
    public class premios
    {

        #region Singleton
        private static readonly premios _instancia = new premios();
        public static premios Instancia
        {
            get { return premios._instancia; }
        }
        private List<cuenta> c = new List<cuenta>();
        private bool priimera = false;
        public List<cuenta>mostrar_5_ganadores()

        {

              
            if(priimera == false)
            {
                List<cuenta> c_aux = new List<cuenta>();
                cuentaf.Instancia.ordener_cuenta_mayor_menor();
                c_aux = cuentaf.Instancia.cuenta_mostrar();
                for (int i = 0; i < 5; i++)
                    c.Add(c_aux[i]);
                priimera = true;
            }


            return c;
        }

        public meseros mostrar_ganador()
        {
            meseros m = new meseros();
            Random random = new Random();
            int numeor=-1;
            for (int i=0;i<1;i++)
                numeor = random.Next(0, 5);
            m = c[numeor].M;
            for (int i = 0;i<5;i++)
                Console.WriteLine(c[i].M.nombre);
            return m; 
        }



        #endregion metodos
    }
}
