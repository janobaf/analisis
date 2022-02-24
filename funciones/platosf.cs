using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
namespace funciones
{
    public class platosf
    {
        #region Singleton
        private static readonly platosf _instancia = new platosf();
        public static platosf Instancia
        {
            get { return platosf._instancia; }
        }
        private List<platos> p = new List<platos>();

        public bool crear_platos(int codigo_platos, string categoria, string nombre_plato, float precio)
        {
            platos p_aux = new platos();
            p_aux.codigo_platos = codigo_platos;
            if (platos_buscar(codigo_platos) == false)
            {
                p_aux.categoria = categoria;
                p_aux.nombre_plato = nombre_plato;
                p_aux.precio = precio;  
                p.Add(p_aux);
                return true;
            }

            return false;

        }

        //metodo quick sort => recursividad  y divide y venceras 
        public void ordenar_platos()
        {
            platos aux = new platos();
            for (int i = 0; i < p.Count(); i++)
            {
                for (int j = i + 1; j < p.Count(); j++)
                {
                    if (p[i].precio > p[j].precio)
                    {
                        aux.nombre_plato = p[i].nombre_plato;
                        p[i].nombre_plato = p[j].nombre_plato;
                        p[j].nombre_plato = aux.nombre_plato;

                        aux.codigo_platos = p[i].codigo_platos;
                        p[i].codigo_platos = p[j].codigo_platos;
                        p[j].codigo_platos = aux.codigo_platos;

                        aux.categoria = p[i].categoria;
                        p[i].categoria = p[j].categoria;
                        p[j].categoria = aux.categoria;

                        aux.precio = p[i].precio;
                        p[i].precio = p[j].precio;
                        p[j].precio = aux.precio;


                    }
                }
            }
        }

        //  busqueda binaria  metodo divide y vernceras 
        public int buscar_pl(int n, int codigo_platos)
        {
            int mitad, izq, der;
            izq = 0;
            der = n - 1;
            while (izq <= der)
            {
                mitad = (izq + der) / 2;
                if (codigo_platos > p[mitad].codigo_platos) izq = mitad + 1;
                else if (codigo_platos < p[mitad].codigo_platos) der = mitad - 1;
                else return mitad;
            }
            return -1;
        }

        //fuerza bruta buscar platos 
        public platos buscar_platos(int codigo_platos)
        {
            for (int i = 0; i < p.Count(); i++)
                if (p[i].codigo_platos == codigo_platos)
                    return p[i];

            return null;
        }

        public List<platos> mostrar_platos()
        {
            return p;
        }
        
        public bool platos_buscar(int codigo_plato)
        {
            for (int i = 0; i < p.Count(); i++)
                if (p[i].codigo_platos == codigo_plato)
                    return true;
            return false;
        }
        #endregion metodos 
    }
}
