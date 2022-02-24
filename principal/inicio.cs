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
    public partial class inicio : Form
    {
        private Form mesa;
        public inicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        
        private void abrirformulario( Form mesa_aux)
        {
            if(mesa!=null)
            {

                mesa.Close();
            }
            mesa = mesa_aux;
            mesa_aux.TopLevel = false;
            mesa_aux.FormBorderStyle = FormBorderStyle.None;
            mesa_aux.Dock = DockStyle.Fill;
            panelprincipal.Controls.Add(mesa_aux);
            panelprincipal.Tag = mesa_aux;
            mesa_aux.BringToFront();
            mesa_aux.Show();

        }
    

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cuenta c = new Cuenta();
            c.Show();
        }

      

        private void MESAS_Click(object sender, EventArgs e)
        {
            abrirformulario(new mesa());
        }

        private void PLATOS_Click(object sender, EventArgs e)
        {
            
            abrirformulario(new platos());
            
        }

        private void MESEROS_Click(object sender, EventArgs e)
        {
            
           abrirformulario( new Meseros());
           
        }

        private void SORTEO_Click(object sender, EventArgs e)
        {
            abrirformulario(new premio());
        }
    }
}
