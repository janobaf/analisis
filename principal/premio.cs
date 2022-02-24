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
    public partial class premio : Form
    {
        public premio()
        {
            InitializeComponent();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = premios.Instancia.mostrar_5_ganadores();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add();
            dataGridView2[0, 0].Value = premios.Instancia.mostrar_ganador().nombre;
        }
    }
}
