using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
namespace funciones
{
    public class meserosf
    {

        #region Singleton
        private static readonly meserosf _instancia = new meserosf();
        public static meserosf Instancia
        {
            get { return meserosf._instancia; }
        }
        private List<meseros> me = new List<meseros>();


        public void crear_meseros(string nombre, string dni, int n_mesa)
        {
            meseros m_mesero = new meseros();
            m_mesero.nombre = nombre;
            m_mesero.dni = dni;
            m_mesero.ocupado = false;
            mesa aux = new mesa();
            aux = mesas.Instancia.buscar_mesa(n_mesa);
            m_mesero.Mesa_aux=aux;
            me.Add(m_mesero);
        }


        public void cambiar_estado(string dni , bool estado)
        {
            int id = retornar_id_mesero(dni);
            me[id].ocupado = estado;
        }

        private int retornar_id_mesero(string dni)
        {
            for (int i = 0; i < me.Count(); i++)
                if (me[i].dni == dni)
                    return i;
            return -1;
        }

        public meseros buscar_meseros(string dni)
        {
            for (int i = 0; i < me.Count(); i++)
                if (me[i].dni == dni)
                    return me[i];
            return null;
        }
        public List<meseros> mostrar_meseros()
        {
            return me;
        }

        public meseros buscar_meseros_libre ()
        {

            for (int i = 0; i < me.Count(); i++)
                if (me[i].ocupado == false)
                    return me[i];
            return null;
        }

        #endregion metodos
    }
}
