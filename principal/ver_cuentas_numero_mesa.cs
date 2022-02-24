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
    public partial class ver_cuentas_numero_mesa : Form
    {
        public ver_cuentas_numero_mesa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero_mes = int.Parse(numero_mesa.Text);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = cuentaf.Instancia.cuenta_mostrar_numero_mesa(numero_mes);
        }
    }
}
