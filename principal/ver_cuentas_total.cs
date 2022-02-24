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
    public partial class ver_cuentas_total : Form
    {
        public ver_cuentas_total()
        {
            InitializeComponent();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = cuentaf.Instancia.cuenta_mostrar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
