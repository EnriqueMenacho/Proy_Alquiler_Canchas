using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Alquiler_Canchas.Forms.GESTION_PREDIOS
{
    public partial class form_agregarPredio : Form
    {
        public form_agregarPredio()
        {
            InitializeComponent();
        }

        private void btnCancelar_NC_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
