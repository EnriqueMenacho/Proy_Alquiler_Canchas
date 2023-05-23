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
    public partial class form_nuevaReserva : Form
    {
        public form_nuevaReserva()
        {
            InitializeComponent();
        }

        private void btnGuardar_NC_Click(object sender, EventArgs e)
        {
            //MessageBox.Show();
            //Cal_FechaParaAlquilar.SelectionRange.Start.ToString()
        }

        private void form_nuevaReserva_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_NC_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
