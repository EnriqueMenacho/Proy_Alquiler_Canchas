﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Alquiler_Canchas.Forms.UTILITARIOS
{
    public partial class form_nuevoUsuario : Form
    {
        public form_nuevoUsuario()
        {
            InitializeComponent();
        }

        private void btnCancelar_NC_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
