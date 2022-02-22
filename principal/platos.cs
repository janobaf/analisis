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
    public partial class platos : Form
    {
        public platos()
        {
            InitializeComponent();
        }

        private void platos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int codigo_plato = int.Parse(codigo_plato_text.Text);
            float precio = float.Parse(precio_txt.Text);
            bool verificar = funcion.Instancia.crear_platos(codigo_plato, categoria_txt.Text, nombre_plato_txt.Text, precio);
            if (verificar == true)
                MessageBox.Show("Creado correctamente");
            else
                MessageBox.Show("Codigo ya existente");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = funcion.Instancia.mostrar_platos();

            codigo_plato_text.Text = "";
            precio_txt.Text = "";
            categoria_txt.Text = "";
            nombre_plato_txt.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            inicio i = new inicio();
            i.Show();
        }
    }
}
