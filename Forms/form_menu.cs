using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Alquiler_Canchas.Forms
{
    public partial class form_menu : Form
    {
        public form_menu()
        {
            InitializeComponent();
        }
        public void MostrarFormulario(Form formulario) 
        {
            formulario.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureClose_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void pictureMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {

            form_clientes pantalla1 = new form_clientes();
            MostrarFormulario(pantalla1);
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            form_AlquileresReservas pantalla2 = new form_AlquileresReservas();
            MostrarFormulario(pantalla2);
        } 
        private void lblCliente_Click(object sender, EventArgs e)
        {
            form_Predios pantalla2 = new form_Predios();
            MostrarFormulario(pantalla2);
        }
         private void pnPredios_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pnPredios_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
