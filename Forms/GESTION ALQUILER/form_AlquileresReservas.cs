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
    public partial class form_AlquileresReservas : Form
    {
        public form_AlquileresReservas()
        {
            InitializeComponent();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Close();
            form_menu pantalla = new form_menu();
            pantalla.Show();
        }

        private void pnl_NuevaReserva_Click(object sender, EventArgs e)
        {
            form_nuevaReserva pantalla = new form_nuevaReserva();
            pantalla.Show();
        }
    }
}
