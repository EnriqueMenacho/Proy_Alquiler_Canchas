using Gestion_Alquiler_Canchas.ConeccionBD;
using Gestion_Alquiler_Canchas.Forms.GESTION_PREDIOS;
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
    public partial class form_Predios : Form
    {
        public form_Predios()
        {
            InitializeComponent();
        }
        
        private void form_Predios_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }

        public void CargarTabla()
        {
            StoredProcuderes storedProcuderes = new StoredProcuderes();
            storedProcuderes.CargarTablasCanchas_Activos(dataGridView1);
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Close();
            form_menu pantalla = new form_menu();
            pantalla.Show();
        }

        private void ptbNuevoCliente_Click(object sender, EventArgs e)
        {
            form_agregarPredio pantalla = new form_agregarPredio();
            pantalla.ShowDialog();

        }

        private void ptbModificarCliente_Click(object sender, EventArgs e)
        {
            form_modificarPredios pantalla = new form_modificarPredios();
            pantalla.ShowDialog();
        }

      
    }
}
