using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using funciones;
namespace principal
{
    public partial class crear_cuenta : Form
    {
        public crear_cuenta()
        {
            InitializeComponent();
            platosview.DataSource = null;
            platosview.DataSource = platosf.Instancia.mostrar_platos();
            
        }
        private List<Entidad.platos> p = new List<Entidad.platos>();
        private float total = 0;
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n_mesa = int.Parse(numero_mesa.Text);
            cuentaf.Instancia.crear_cuenta(n_mesa, p,total);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = cuentaf.Instancia.cuenta_mostrar();

            p.Clear();
            total = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cuenta c = new Cuenta();
            c.Show();
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            
            int codigo_p = int.Parse(codigo_txt.Text);

            int i = platosf.Instancia.buscar_pl(platosf.Instancia.mostrar_platos().Count(), codigo_p);
            if (i != -1)
            {

                List<Entidad.platos> p_aux = platosf.Instancia.mostrar_platos();
                p.Add(p_aux[i]);
                total += p_aux[i].precio;


            }

        }
    }
}
