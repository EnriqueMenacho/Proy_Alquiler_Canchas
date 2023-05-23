using Gestion_Alquiler_Canchas.ConeccionBD;
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
    public partial class form_clientes : Form
    {
        public string getBuscarPorCarnet()
        {
            return txtBuscarCi.Text;
        }

        public form_clientes()
        {
            InitializeComponent();
        }
        public void CargarTabla()
        {
            this.clienteTableAdapter1.Fill(this.alquiler_CanchasDataSet1.Cliente);
        }
        
        public void actualizar_data()
        {
            txtBuscarCi.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = clienteBindingSource2;
            CargarTabla();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void form_clientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'alquiler_CanchasDataSet1.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter1.Fill(this.alquiler_CanchasDataSet1.Cliente);
            // TODO: esta línea de código carga datos en la tabla 'alquiler_CanchasDataSet.Cliente' Puede moverla o quitarla según sea necesario.
            //this.clienteTableAdapter.Fill(this.alquiler_CanchasDataSet.Cliente);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            form_menu pantalla = new form_menu();
            pantalla.Show();
        }

        private void btnBuscarCi_Click(object sender, EventArgs e)
        {
            StoredProcuderes Buscar = new StoredProcuderes();
            Buscar.BuscarClientePorCarnet(txtBuscarCi.Text, dataGridView1);

        }

        private void ptbNuevoCliente_Click(object sender, EventArgs e)
        {
            form_nuevoCliente pantalla = new form_nuevoCliente();
            pantalla.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            
         this.actualizar_data();

        }

        private void ptbModificarCliente_Click(object sender, EventArgs e)
        {
                form_modificarCliente pantalla = new form_modificarCliente();
                pantalla.Show();
                       
        }

        private void ptbEliminarCliente_Click(object sender, EventArgs e)
        {
            if(txtBuscarCi.Text != "")
            {
                StoredProcuderes eliminar = new StoredProcuderes();
                eliminar.EliminarCliente(txtBuscarCi.Text);
            }
            else
            {
                MessageBox.Show("POR FAVOR PRIMERO BUSQUE EL CLIENTE");
            }
        }
    }
}
