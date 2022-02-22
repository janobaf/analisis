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
    public partial class Meseros : Form
    {
        public Meseros()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            funcion.Instancia.crear_meseros(nombre_text.Text, dni_text.Text, int.Parse(numero_mesa_txt.Text));
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = funcion.Instancia.mostrar_meseros();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            inicio i = new inicio();
            i.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
