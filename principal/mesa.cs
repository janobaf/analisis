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
    public partial class mesa : Form
    {
        public mesa()
        {
           
            InitializeComponent();
        }

        private void registrar_Click(object sender, EventArgs e)
        {
           
        }
        
     
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            inicio i = new inicio();
            i.Show();
        }

        private void mesa_Load(object sender, EventArgs e)
        {

        }

        private void saliir_Click(object sender, EventArgs e)
        {
            bool verificar = mesas.Instancia.crear_mesa(int.Parse(numero_mesa_text.Text));
            if (verificar == true)
                MessageBox.Show("Registrado Correctamente");
            else
                MessageBox.Show("numero mesa existente");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = mesas.Instancia.mostrar_mesas();
            numero_mesa_text.Text = " ";
        }
    }
}

