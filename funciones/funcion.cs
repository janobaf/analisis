using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
namespace funciones
{
    public class funcion
    {

        #region Singleton
        private static readonly funcion _instancia = new funcion();
        public static funcion Instancia
        {
            get { return funcion._instancia; }
        }


        List<mesa> m = new List<mesa>();
        List<meseros> me = new List<meseros>();
        List<platos> p = new List<platos>();
        List<cuenta> c = new List<cuenta>();
        List<cuenta> c_eliminada = new List<cuenta>();
        public bool crear_mesa(int numero_mesa)
        {
            mesa m_aux = new mesa();
            m_aux.numero_mesa = numero_mesa;
            if(mesa_buscar(numero_mesa) ==false)
            {
                m_aux.disponibilidad = false;

                m.Add(m_aux);
                return true;
            }


            return false;
         

        }


        public void crear_meseros(string nombre, string dni, int n_mesa)
        {
            meseros m_mesero = new meseros();
            m_mesero.nombre = nombre;
            m_mesero.dni = dni;
            m_mesero.ocupado = false;
            mesa aux = new mesa();
            aux = buscar_mesa(n_mesa);
            m_mesero.Mesa_aux.Add(aux);
            me.Add(m_mesero);
        }

        public bool crear_platos(int codigo_platos, string categoria, string nombre_plato, float precio)
        {
            platos p_aux = new platos();
            p_aux.codigo_platos = codigo_platos;
            if(platos_buscar(codigo_platos)==false)
            {
                p_aux.categoria = categoria;
                p_aux.nombre_plato = nombre_plato;
                p_aux.precio = precio;
                p.Add(p_aux);
                return true;
            }
              
            return false;

        }
        public void crear_cuenta(int n_mesa, platos Platos, meseros Meseros, bool eliminar, float total)
        {
            cuenta c_aux = new cuenta();
            c_aux.n_mesa = n_mesa;
            c_aux.Platos.Add(Platos);
            c_aux.M = Meseros;
            c_aux.eliminar = false;
            c_aux.total = total;
            c.Add(c_aux);
        }

        public List<meseros> mostrar_meseros()
        {
            return me;
        }
        public List<mesa> mostrar_mesas()
        {
            
             return m;
            
        }

        public List<platos> mostrar_platos()
        {
            return p;
        }

        private bool mesa_buscar(int n_mesa)
        {
            for (int i = 0; i < m.Count(); i++)
                if (m[i].numero_mesa == n_mesa)
                    return true;
            return false;
        }
        private mesa buscar_mesa(int n_mesa)
        {
            for (int i = 0; i < m.Count(); i++)
                 if (m[i].numero_mesa == n_mesa)
                     return m[i];
            return null;
        }
        private bool platos_buscar(int codigo_plato)
        {
            for (int i = 0; i < p.Count(); i++)
                if (p[i].codigo_platos == codigo_plato)
                    return true;
            return false;
        }

        #endregion metodos

    }
}
