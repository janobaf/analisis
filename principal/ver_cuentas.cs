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
    public partial class ver_cuentas : Form
    {
        public ver_cuentas()
        {
            InitializeComponent();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ver_cuentas_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ver_cuentas_total v = new ver_cuentas_total();
            v.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ver_cuentas_numero_mesa vc = new ver_cuentas_numero_mesa();
            vc.Show();
        }
    }
}
