namespace Gestion_Alquiler_Canchas.Forms
{
    partial class form_AlquileresReservas
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
            this.lbl_tituloReserva = new System.Windows.Forms.Label();
            this.pnl_NuevaReserva = new System.Windows.Forms.Panel();
            this.lbl_NuevaReserva = new System.Windows.Forms.Label();
            this.ptbNuevaReserva = new System.Windows.Forms.PictureBox();
            this.pnl_buscarReserva = new System.Windows.Forms.Panel();
            this.txtBuscarCi = new System.Windows.Forms.TextBox();
            this.btnBuscarCi = new System.Windows.Forms.Button();
            this.lblBuscarReserva = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_home = new System.Windows.Forms.PictureBox();
            this.pnl_NuevaReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNuevaReserva)).BeginInit();
            this.pnl_buscarReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_home)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_tituloReserva
            // 
            this.lbl_tituloReserva.AutoSize = true;
            this.lbl_tituloReserva.Font = new System.Drawing.Font("Stencil", 40.25F, System.Drawing.FontStyle.Bold);
            this.lbl_tituloReserva.ForeColor = System.Drawing.Color.White;
            this.lbl_tituloReserva.Location = new System.Drawing.Point(345, 9);
            this.lbl_tituloReserva.Name = "lbl_tituloReserva";
            this.lbl_tituloReserva.Size = new System.Drawing.Size(510, 64);
            this.lbl_tituloReserva.TabIndex = 7;
            this.lbl_tituloReserva.Text = "GESTION RESERVA";
            // 
            // pnl_NuevaReserva
            // 
            this.pnl_NuevaReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(36)))));
            this.pnl_NuevaReserva.Controls.Add(this.lbl_NuevaReserva);
            this.pnl_NuevaReserva.Controls.Add(this.ptbNuevaReserva);
            this.pnl_NuevaReserva.Location = new System.Drawing.Point(47, 94);
            this.pnl_NuevaReserva.Name = "pnl_NuevaReserva";
            this.pnl_NuevaReserva.Size = new System.Drawing.Size(318, 505);
            this.pnl_NuevaReserva.TabIndex = 8;
            this.pnl_NuevaReserva.Click += new System.EventHandler(this.pnl_NuevaReserva_Click);
            // 
            // lbl_NuevaReserva
            // 
            this.lbl_NuevaReserva.AutoSize = true;
            this.lbl_NuevaReserva.Font = new System.Drawing.Font("Stencil", 35.25F, System.Drawing.FontStyle.Bold);
            this.lbl_NuevaReserva.ForeColor = System.Drawing.Color.White;
            this.lbl_NuevaReserva.Location = new System.Drawing.Point(44, 353);
            this.lbl_NuevaReserva.Name = "lbl_NuevaReserva";
            this.lbl_NuevaReserva.Size = new System.Drawing.Size(236, 112);
            this.lbl_NuevaReserva.TabIndex = 2;
            this.lbl_NuevaReserva.Text = "NUEVA\r\nRESERVA";
            this.lbl_NuevaReserva.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_NuevaReserva.Click += new System.EventHandler(this.pnl_NuevaReserva_Click);
            // 
            // ptbNuevaReserva
            // 
            this.ptbNuevaReserva.Image = global::Gestion_Alquiler_Canchas.Properties.Resources.new_reserva;
            this.ptbNuevaReserva.Location = new System.Drawing.Point(-15, 11);
            this.ptbNuevaReserva.Name = "ptbNuevaReserva";
            this.ptbNuevaReserva.Size = new System.Drawing.Size(342, 353);
            this.ptbNuevaReserva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbNuevaReserva.TabIndex = 3;
            this.ptbNuevaReserva.TabStop = false;
            this.ptbNuevaReserva.Click += new System.EventHandler(this.pnl_NuevaReserva_Click);
            // 
            // pnl_buscarReserva
            // 
            this.pnl_buscarReserva.Controls.Add(this.txtBuscarCi);
            this.pnl_buscarReserva.Controls.Add(this.btnBuscarCi);
            this.pnl_buscarReserva.Controls.Add(this.lblBuscarReserva);
            this.pnl_buscarReserva.Location = new System.Drawing.Point(394, 94);
            this.pnl_buscarReserva.Name = "pnl_buscarReserva";
            this.pnl_buscarReserva.Size = new System.Drawing.Size(757, 85);
            this.pnl_buscarReserva.TabIndex = 10;
            // 
            // txtBuscarCi
            // 
            this.txtBuscarCi.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.txtBuscarCi.Location = new System.Drawing.Point(58, 39);
            this.txtBuscarCi.Name = "txtBuscarCi";
            this.txtBuscarCi.Size = new System.Drawing.Size(489, 35);
            this.txtBuscarCi.TabIndex = 7;
            // 
            // btnBuscarCi
            // 
            this.btnBuscarCi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(36)))));
            this.btnBuscarCi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarCi.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnBuscarCi.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCi.Location = new System.Drawing.Point(567, 36);
            this.btnBuscarCi.Name = "btnBuscarCi";
            this.btnBuscarCi.Size = new System.Drawing.Size(123, 38);
            this.btnBuscarCi.TabIndex = 8;
            this.btnBuscarCi.Text = "BUSCAR";
            this.btnBuscarCi.UseVisualStyleBackColor = false;
            // 
            // lblBuscarReserva
            // 
            this.lblBuscarReserva.AutoSize = true;
            this.lblBuscarReserva.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblBuscarReserva.ForeColor = System.Drawing.Color.White;
            this.lblBuscarReserva.Location = new System.Drawing.Point(64, 11);
            this.lblBuscarReserva.Name = "lblBuscarReserva";
            this.lblBuscarReserva.Size = new System.Drawing.Size(311, 25);
            this.lblBuscarReserva.TabIndex = 6;
            this.lblBuscarReserva.Text = "BUSCAR RESERVA POR C.I.";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(394, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(757, 404);
            this.dataGridView1.TabIndex = 11;
            // 
            // btn_home
            // 
            this.btn_home.Image = global::Gestion_Alquiler_Canchas.Properties.Resources.homeWhite;
            this.btn_home.Location = new System.Drawing.Point(12, 12);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(79, 64);
            this.btn_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_home.TabIndex = 6;
            this.btn_home.TabStop = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // form_AlquileresReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnl_buscarReserva);
            this.Controls.Add(this.pnl_NuevaReserva);
            this.Controls.Add(this.lbl_tituloReserva);
            this.Controls.Add(this.btn_home);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_AlquileresReservas";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_AlquileresReservas";
            this.pnl_NuevaReserva.ResumeLayout(false);
            this.pnl_NuevaReserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNuevaReserva)).EndInit();
            this.pnl_buscarReserva.ResumeLayout(false);
            this.pnl_buscarReserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_home)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_home;
        private System.Windows.Forms.Label lbl_tituloReserva;
        private System.Windows.Forms.Panel pnl_NuevaReserva;
        private System.Windows.Forms.Panel pnl_buscarReserva;
        private System.Windows.Forms.TextBox txtBuscarCi;
        private System.Windows.Forms.Button btnBuscarCi;
        private System.Windows.Forms.Label lblBuscarReserva;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox ptbNuevaReserva;
        private System.Windows.Forms.Label lbl_NuevaReserva;
    }
}