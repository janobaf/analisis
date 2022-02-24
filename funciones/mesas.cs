using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
namespace funciones
{
    public class mesas
    {

        #region Singleton
        private static readonly mesas _instancia = new mesas();
        public static mesas Instancia
        {
            get { return mesas._instancia; }
        }

        private List<mesa> m = new List<mesa>();
        public bool crear_mesa(int numero_mesa)
        {
            
            if (mesa_buscar(numero_mesa) == false)
            {
                mesa m_aux = new mesa();
                m_aux.numero_mesa = numero_mesa;
                m_aux.disponibilidad = false;
                m.Add(m_aux);
                return true;
            }
            return false;

        }

        public List<mesa> mostrar_mesas()
        {
            return m;
        }


        public bool mesa_buscar(int n_mesa)
        {
            for (int i = 0; i < m.Count(); i++)
                if (m[i].numero_mesa == n_mesa)
                    return true;
            return false;
        }
        //fuerza bruta   busqueda 
        public mesa buscar_mesa(int n_mesa)
        {
            for (int i = 0; i < m.Count(); i++)
                if (m[i].numero_mesa == n_mesa)
                    return m[i];
            return null;
        }

        #endregion metodos
    }
}
