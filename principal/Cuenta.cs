using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace principal
{
    public partial class Cuenta : Form
    {
        public Cuenta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            crear_cuenta c = new crear_cuenta();
            c.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ver_cuentas vc = new ver_cuentas();
            vc.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            inicio i = new inicio(); 
            i.Show();
        }
    }
}
