using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
namespace funciones
{
    public class cuentaf
    {
        #region Singleton
        private static readonly cuentaf _instancia = new cuentaf();
        public static cuentaf Instancia
        {
            get { return cuentaf._instancia; }
        }


        private List<cuenta> c = new List<cuenta>();
        private List<cuenta> c_eliminada = new List<cuenta>();

        public bool buscar_cuenta(int n_mesa)
        {


            return false;
        }
        public void crear_cuenta(int n_mesa, List <platos> p,float total )
        {
            cuenta c_aux = new cuenta();
            bool verificar = mesas.Instancia.mesa_buscar(n_mesa);
            if (verificar == true)
            {
                meseros m = meserosf.Instancia.buscar_meseros_libre();
                c_aux.n_mesa = n_mesa;
                c_aux.Platos = p;
                c_aux.M =m ;
                c_aux.eliminar = false;
                c_aux.total = total;
                meserosf.Instancia.cambiar_estado(m.dni, true);
                c.Add(c_aux);
            }

        }
        public List<platos> mostrar_platos_cuenta(int n_mesa)
        {
            if (c.Count() > 0)
            {
                cuenta aux = buscar_cuenta(n_mesa, 0, c.Count() - 1);
                return aux.Platos;

            }
            return null;
        }
        public void modificar_cuenta(int n_mesa, int codigo_plato)
        {
            if (c.Count() > 0)
            {
                cuenta aux = buscar_cuenta(n_mesa, 0, c.Count() - 1);
                aux.Platos.Add(platosf.Instancia.buscar_platos(codigo_plato));

            }
        }

        public cuenta cuenta_mostrar_numero_mesa(int numero_mesa)
        {

            if(c.Count()>0)
            {
                for (int i = 0; i < c.Count(); i++)
                    if (c[i].n_mesa == numero_mesa)
                        return c[i];
            }
            return null; 
        }
        public List<cuenta> cuenta_mostrar()
        {

            return c;
        }

        public List<cuenta> cuenta_mostrar_ordenada()
        {
            ordenar_cuenta(0, c.Count() - 1);
            return c;
        }
        // metodo ordenamiento quick sort  divide y venceras y recursivididad 
        private void ordenar_cuenta(int inicio, int final)
        {
            int i = inicio;
            int j = final;
            cuenta central = c[(inicio + final) / 2];
            cuenta aux = new cuenta();
            do
            {
                while (central.total > c[i].total) i = i + 1;
                while (central.total < c[j].total) j = j - 1;
                if (i <= j)
                {
                    aux.n_mesa = c[i].n_mesa;
                    c[i].n_mesa = c[j].n_mesa;
                    c[j].n_mesa = aux.n_mesa;

                    aux.Platos = c[i].Platos;
                    c[i].Platos = c[j].Platos;
                    c[j].Platos = aux.Platos;

                    aux.M = c[i].M;
                    c[i].M = c[j].M;
                    c[j].M = aux.M;

                    aux.total = c[i].total;
                    c[i].total = c[j].total;
                    c[j].total = aux.total;

                    aux.eliminar = c[i].eliminar;
                    c[i].eliminar = c[j].eliminar;
                    c[j].eliminar = aux.eliminar;


                    i++;
                    j--;
                }

            } while (i <= j);
        }

        public void ordener_cuenta_mayor_menor()
        {
            cuenta aux = new cuenta();
            for (int i = 0; i < c.Count(); i++)
            {
                for (int j = i + 1; j < c.Count(); j++)
                {
                    if(c[i].total<c[j].total)
                    {
                        aux.n_mesa = c[i].n_mesa;
                        c[i].n_mesa = c[j].n_mesa;
                        c[j].n_mesa = aux.n_mesa;

                        aux.Platos = c[i].Platos;
                        c[i].Platos = c[j].Platos;
                        c[j].Platos = aux.Platos;


                        aux.M = c[i].M;
                        c[i].M = c[j].M;
                        c[j].M = aux.M;

                        aux.eliminar = c[i].eliminar;
                        c[i].eliminar = c[j].eliminar;
                        c[j].eliminar = aux.eliminar;

                        aux.total = c[i].total;
                        c[i].total = c[j].total;
                        c[j].total = aux.total;

                        aux.pagar_total = c[i].pagar_total;
                        c[i].pagar_total = c[j].pagar_total;
                        c[j].pagar_total = aux.pagar_total;
                    }
                }
            }
        }

        //divide y venceras Y recursividad    metodo busqueda 
        private cuenta buscar_cuenta(int n_mesa, int inicio, int final)
        {
            cuenta mitad = c[(inicio + final) / 2];
            if (mitad.n_mesa == n_mesa) return mitad;
            else if (n_mesa > c[inicio].n_mesa) buscar_cuenta(n_mesa, inicio + 1, final);
            else if (n_mesa < c[final].n_mesa) buscar_cuenta(n_mesa, inicio, final - 1);
            return null;

        }
        #endregion metodos 
    }
}
