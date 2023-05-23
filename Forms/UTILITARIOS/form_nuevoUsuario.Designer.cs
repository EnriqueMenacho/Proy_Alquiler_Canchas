namespace Gestion_Alquiler_Canchas.Forms.UTILITARIOS
{
    partial class form_nuevoUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNombre_NC = new System.Windows.Forms.Label();
            this.btnCancelar_NC = new System.Windows.Forms.Button();
            this.lblNuevoCliente = new System.Windows.Forms.Label();
            this.btnGuardar_NC = new System.Windows.Forms.Button();
            this.lblApellido_NC = new System.Windows.Forms.Label();
            this.lblCarnet_NC = new System.Windows.Forms.Label();
            this.txtCarnet_NC = new System.Windows.Forms.TextBox();
            this.txtApellido_NC = new System.Windows.Forms.TextBox();
            this.txtNombre_NC = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.lblNombre_NC);
            this.panel1.Controls.Add(this.btnCancelar_NC);
            this.panel1.Controls.Add(this.lblNuevoCliente);
            this.panel1.Controls.Add(this.btnGuardar_NC);
            this.panel1.Controls.Add(this.lblApellido_NC);
            this.panel1.Controls.Add(this.lblCarnet_NC);
            this.panel1.Controls.Add(this.txtCarnet_NC);
            this.panel1.Controls.Add(this.txtApellido_NC);
            this.panel1.Controls.Add(this.txtNombre_NC);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 6;
            // 
            // lblNombre_NC
            // 
            this.lblNombre_NC.AutoSize = true;
            this.lblNombre_NC.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold);
            this.lblNombre_NC.ForeColor = System.Drawing.Color.White;
            this.lblNombre_NC.Location = new System.Drawing.Point(146, 125);
            this.lblNombre_NC.Name = "lblNombre_NC";
            this.lblNombre_NC.Size = new System.Drawing.Size(149, 19);
            this.lblNombre_NC.TabIndex = 0;
            this.lblNombre_NC.Text = "NUEVO USUARIO:";
            // 
            // btnCancelar_NC
            // 
            this.btnCancelar_NC.BackColor = System.Drawing.Color.Khaki;
            this.btnCancelar_NC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar_NC.Font = new System.Drawing.Font("Unispace", 14F, System.Drawing.FontStyle.Bold);
            this.btnCancelar_NC.Location = new System.Drawing.Point(404, 344);
            this.btnCancelar_NC.Name = "btnCancelar_NC";
            this.btnCancelar_NC.Size = new System.Drawing.Size(119, 34);
            this.btnCancelar_NC.TabIndex = 7;
            this.btnCancelar_NC.Text = "CANCELAR";
            this.btnCancelar_NC.UseVisualStyleBackColor = false;
            this.btnCancelar_NC.Click += new System.EventHandler(this.btnCancelar_NC_Click);
            // 
            // lblNuevoCliente
            // 
            this.lblNuevoCliente.AutoSize = true;
            this.lblNuevoCliente.Font = new System.Drawing.Font("Stencil", 25F, System.Drawing.FontStyle.Bold);
            this.lblNuevoCliente.ForeColor = System.Drawing.Color.White;
            this.lblNuevoCliente.Location = new System.Drawing.Point(241, 29);
            this.lblNuevoCliente.Name = "lblNuevoCliente";
            this.lblNuevoCliente.Size = new System.Drawing.Size(293, 40);
            this.lblNuevoCliente.TabIndex = 0;
            this.lblNuevoCliente.Text = "NUEVO USUARIO";
            // 
            // btnGuardar_NC
            // 
            this.btnGuardar_NC.BackColor = System.Drawing.Color.Khaki;
            this.btnGuardar_NC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar_NC.Font = new System.Drawing.Font("Unispace", 14F, System.Drawing.FontStyle.Bold);
            this.btnGuardar_NC.Location = new System.Drawing.Point(248, 344);
            this.btnGuardar_NC.Name = "btnGuardar_NC";
            this.btnGuardar_NC.Size = new System.Drawing.Size(119, 34);
            this.btnGuardar_NC.TabIndex = 6;
            this.btnGuardar_NC.Text = "GUARDAR";
            this.btnGuardar_NC.UseVisualStyleBackColor = false;
            // 
            // lblApellido_NC
            // 
            this.lblApellido_NC.AutoSize = true;
            this.lblApellido_NC.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold);
            this.lblApellido_NC.ForeColor = System.Drawing.Color.White;
            this.lblApellido_NC.Location = new System.Drawing.Point(116, 183);
            this.lblApellido_NC.Name = "lblApellido_NC";
            this.lblApellido_NC.Size = new System.Drawing.Size(179, 19);
            this.lblApellido_NC.TabIndex = 0;
            this.lblApellido_NC.Text = "NUEVA CONTRASEÑA:";
            // 
            // lblCarnet_NC
            // 
            this.lblCarnet_NC.AutoSize = true;
            this.lblCarnet_NC.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold);
            this.lblCarnet_NC.ForeColor = System.Drawing.Color.White;
            this.lblCarnet_NC.Location = new System.Drawing.Point(96, 247);
            this.lblCarnet_NC.Name = "lblCarnet_NC";
            this.lblCarnet_NC.Size = new System.Drawing.Size(199, 19);
            this.lblCarnet_NC.TabIndex = 0;
            this.lblCarnet_NC.Text = "REPETIR CONTRASEÑA:";
            // 
            // txtCarnet_NC
            // 
            this.txtCarnet_NC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.txtCarnet_NC.Location = new System.Drawing.Point(301, 247);
            this.txtCarnet_NC.Name = "txtCarnet_NC";
            this.txtCarnet_NC.PasswordChar = '*';
            this.txtCarnet_NC.Size = new System.Drawing.Size(367, 26);
            this.txtCarnet_NC.TabIndex = 3;
            // 
            // txtApellido_NC
            // 
            this.txtApellido_NC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.txtApellido_NC.Location = new System.Drawing.Point(301, 180);
            this.txtApellido_NC.Name = "txtApellido_NC";
            this.txtApellido_NC.PasswordChar = '*';
            this.txtApellido_NC.Size = new System.Drawing.Size(367, 26);
            this.txtApellido_NC.TabIndex = 2;
            // 
            // txtNombre_NC
            // 
            this.txtNombre_NC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.txtNombre_NC.Location = new System.Drawing.Point(301, 118);
            this.txtNombre_NC.Name = "txtNombre_NC";
            this.txtNombre_NC.Size = new System.Drawing.Size(367, 26);
            this.txtNombre_NC.TabIndex = 1;
            // 
            // form_nuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_nuevoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_nuevoUsuario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNombre_NC;
        private System.Windows.Forms.Button btnCancelar_NC;
        private System.Windows.Forms.Label lblNuevoCliente;
        private System.Windows.Forms.Button btnGuardar_NC;
        private System.Windows.Forms.Label lblApellido_NC;
        private System.Windows.Forms.Label lblCarnet_NC;
        private System.Windows.Forms.TextBox txtCarnet_NC;
        private System.Windows.Forms.TextBox txtApellido_NC;
        private System.Windows.Forms.TextBox txtNombre_NC;
    }
}