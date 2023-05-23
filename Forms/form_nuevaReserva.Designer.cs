namespace Gestion_Alquiler_Canchas.Forms
{
    partial class form_nuevaReserva
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cb_HoraInicio = new System.Windows.Forms.ComboBox();
            this.Cal_FechaParaAlquilar = new System.Windows.Forms.MonthCalendar();
            this.cb_ElegirCancha = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Observaciones = new System.Windows.Forms.Label();
            this.lblNombre_NC = new System.Windows.Forms.Label();
            this.txt_Observaciones = new System.Windows.Forms.TextBox();
            this.txtNombre_NC = new System.Windows.Forms.TextBox();
            this.btnCancelar_NC = new System.Windows.Forms.Button();
            this.btnGuardar_NC = new System.Windows.Forms.Button();
            this.lbl_tituloReserva = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.cb_HoraInicio);
            this.panel1.Controls.Add(this.Cal_FechaParaAlquilar);
            this.panel1.Controls.Add(this.cb_ElegirCancha);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_Observaciones);
            this.panel1.Controls.Add(this.lblNombre_NC);
            this.panel1.Controls.Add(this.txt_Observaciones);
            this.panel1.Controls.Add(this.txtNombre_NC);
            this.panel1.Controls.Add(this.btnCancelar_NC);
            this.panel1.Controls.Add(this.btnGuardar_NC);
            this.panel1.Controls.Add(this.lbl_tituloReserva);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 548);
            this.panel1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.textBox2.Location = new System.Drawing.Point(850, 279);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(215, 26);
            this.textBox2.TabIndex = 37;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Khaki;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Unispace", 14F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(778, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 30);
            this.button2.TabIndex = 36;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Khaki;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Unispace", 14F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(636, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 30);
            this.button1.TabIndex = 35;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(681, 281);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(99, 26);
            this.textBox1.TabIndex = 34;
            this.textBox1.Text = "01:00";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cb_HoraInicio
            // 
            this.cb_HoraInicio.DropDownHeight = 200;
            this.cb_HoraInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_HoraInicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_HoraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb_HoraInicio.FormattingEnabled = true;
            this.cb_HoraInicio.IntegralHeight = false;
            this.cb_HoraInicio.ItemHeight = 20;
            this.cb_HoraInicio.Items.AddRange(new object[] {
            "07:00",
            "07:30",
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00",
            "20:30",
            "21:00",
            "21:30",
            "22:00",
            "22:30",
            "23:00"});
            this.cb_HoraInicio.Location = new System.Drawing.Point(390, 279);
            this.cb_HoraInicio.Name = "cb_HoraInicio";
            this.cb_HoraInicio.Size = new System.Drawing.Size(215, 28);
            this.cb_HoraInicio.TabIndex = 33;
            // 
            // Cal_FechaParaAlquilar
            // 
            this.Cal_FechaParaAlquilar.Location = new System.Drawing.Point(79, 279);
            this.Cal_FechaParaAlquilar.Name = "Cal_FechaParaAlquilar";
            this.Cal_FechaParaAlquilar.TabIndex = 32;
            // 
            // cb_ElegirCancha
            // 
            this.cb_ElegirCancha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ElegirCancha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_ElegirCancha.FormattingEnabled = true;
            this.cb_ElegirCancha.Location = new System.Drawing.Point(440, 149);
            this.cb_ElegirCancha.Name = "cb_ElegirCancha";
            this.cb_ElegirCancha.Size = new System.Drawing.Size(367, 21);
            this.cb_ElegirCancha.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(113, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "FECHA PARA ALQUILAR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(904, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 19);
            this.label4.TabIndex = 26;
            this.label4.Text = "HORA FINAL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(640, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "CANTIDAD DE HORAS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(426, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "HORA DE INICIO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(285, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "CANCHA PREDIO:";
            // 
            // lbl_Observaciones
            // 
            this.lbl_Observaciones.AutoSize = true;
            this.lbl_Observaciones.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Observaciones.ForeColor = System.Drawing.Color.White;
            this.lbl_Observaciones.Location = new System.Drawing.Point(400, 346);
            this.lbl_Observaciones.Name = "lbl_Observaciones";
            this.lbl_Observaciones.Size = new System.Drawing.Size(149, 19);
            this.lbl_Observaciones.TabIndex = 23;
            this.lbl_Observaciones.Text = "OBSERVACIONES:";
            // 
            // lblNombre_NC
            // 
            this.lblNombre_NC.AutoSize = true;
            this.lblNombre_NC.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold);
            this.lblNombre_NC.ForeColor = System.Drawing.Color.White;
            this.lblNombre_NC.Location = new System.Drawing.Point(305, 109);
            this.lblNombre_NC.Name = "lblNombre_NC";
            this.lblNombre_NC.Size = new System.Drawing.Size(129, 19);
            this.lblNombre_NC.TabIndex = 22;
            this.lblNombre_NC.Text = "CI. CLIENTE:";
            // 
            // txt_Observaciones
            // 
            this.txt_Observaciones.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.txt_Observaciones.Location = new System.Drawing.Point(555, 346);
            this.txt_Observaciones.Multiline = true;
            this.txt_Observaciones.Name = "txt_Observaciones";
            this.txt_Observaciones.Size = new System.Drawing.Size(510, 132);
            this.txt_Observaciones.TabIndex = 29;
            // 
            // txtNombre_NC
            // 
            this.txtNombre_NC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.txtNombre_NC.Location = new System.Drawing.Point(440, 106);
            this.txtNombre_NC.Name = "txtNombre_NC";
            this.txtNombre_NC.Size = new System.Drawing.Size(367, 26);
            this.txtNombre_NC.TabIndex = 30;
            // 
            // btnCancelar_NC
            // 
            this.btnCancelar_NC.BackColor = System.Drawing.Color.Khaki;
            this.btnCancelar_NC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar_NC.Font = new System.Drawing.Font("Unispace", 14F, System.Drawing.FontStyle.Bold);
            this.btnCancelar_NC.Location = new System.Drawing.Point(586, 508);
            this.btnCancelar_NC.Name = "btnCancelar_NC";
            this.btnCancelar_NC.Size = new System.Drawing.Size(119, 34);
            this.btnCancelar_NC.TabIndex = 21;
            this.btnCancelar_NC.Text = "CANCELAR";
            this.btnCancelar_NC.UseVisualStyleBackColor = false;
            this.btnCancelar_NC.Click += new System.EventHandler(this.btnCancelar_NC_Click);
            // 
            // btnGuardar_NC
            // 
            this.btnGuardar_NC.BackColor = System.Drawing.Color.Khaki;
            this.btnGuardar_NC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar_NC.Font = new System.Drawing.Font("Unispace", 14F, System.Drawing.FontStyle.Bold);
            this.btnGuardar_NC.Location = new System.Drawing.Point(430, 508);
            this.btnGuardar_NC.Name = "btnGuardar_NC";
            this.btnGuardar_NC.Size = new System.Drawing.Size(119, 34);
            this.btnGuardar_NC.TabIndex = 20;
            this.btnGuardar_NC.Text = "GUARDAR";
            this.btnGuardar_NC.UseVisualStyleBackColor = false;
            // 
            // lbl_tituloReserva
            // 
            this.lbl_tituloReserva.AutoSize = true;
            this.lbl_tituloReserva.Font = new System.Drawing.Font("Stencil", 40.25F, System.Drawing.FontStyle.Bold);
            this.lbl_tituloReserva.ForeColor = System.Drawing.Color.White;
            this.lbl_tituloReserva.Location = new System.Drawing.Point(330, 6);
            this.lbl_tituloReserva.Name = "lbl_tituloReserva";
            this.lbl_tituloReserva.Size = new System.Drawing.Size(510, 64);
            this.lbl_tituloReserva.TabIndex = 19;
            this.lbl_tituloReserva.Text = "GESTION RESERVA";
            // 
            // form_nuevaReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1168, 572);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_nuevaReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_nuevaReserva";
            this.Load += new System.EventHandler(this.form_nuevaReserva_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cb_HoraInicio;
        private System.Windows.Forms.MonthCalendar Cal_FechaParaAlquilar;
        private System.Windows.Forms.ComboBox cb_ElegirCancha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Observaciones;
        private System.Windows.Forms.Label lblNombre_NC;
        private System.Windows.Forms.TextBox txt_Observaciones;
        private System.Windows.Forms.TextBox txtNombre_NC;
        private System.Windows.Forms.Button btnCancelar_NC;
        private System.Windows.Forms.Button btnGuardar_NC;
        private System.Windows.Forms.Label lbl_tituloReserva;
    }
}