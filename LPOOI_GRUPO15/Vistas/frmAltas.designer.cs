namespace Vistas
{
    partial class frmAltas
    {
        private System.ComponentModel.IContainer components = null;

        // Controles
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPeriodoCodigo;
        private System.Windows.Forms.TextBox txtPeriodoDescripcion;
        private System.Windows.Forms.TextBox txtDestinoCodigo;
        private System.Windows.Forms.TextBox txtDestinoDescripcion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPeriodoCodigo;
        private System.Windows.Forms.Label lblPeriodoDescripcion;
        private System.Windows.Forms.Label lblDestinoCodigo;
        private System.Windows.Forms.Label lblDestinoDescripcion;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPeriodoCodigo = new System.Windows.Forms.TextBox();
            this.txtPeriodoDescripcion = new System.Windows.Forms.TextBox();
            this.txtDestinoCodigo = new System.Windows.Forms.TextBox();
            this.txtDestinoDescripcion = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();

            this.lblDNI = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPeriodoCodigo = new System.Windows.Forms.Label();
            this.lblPeriodoDescripcion = new System.Windows.Forms.Label();
            this.lblDestinoCodigo = new System.Windows.Forms.Label();
            this.lblDestinoDescripcion = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // Labels
            this.lblDNI.Text = "DNI:";
            this.lblDNI.Location = new System.Drawing.Point(20, 20);

            this.lblApellido.Text = "Apellido:";
            this.lblApellido.Location = new System.Drawing.Point(20, 60);

            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Location = new System.Drawing.Point(20, 100);

            this.lblPeriodoCodigo.Text = "Código Periodo:";
            this.lblPeriodoCodigo.Location = new System.Drawing.Point(20, 140);

            this.lblPeriodoDescripcion.Text = "Descripción Periodo:";
            this.lblPeriodoDescripcion.Location = new System.Drawing.Point(20, 180);

            this.lblDestinoCodigo.Text = "Código Destino:";
            this.lblDestinoCodigo.Location = new System.Drawing.Point(20, 220);

            this.lblDestinoDescripcion.Text = "Descripción Destino:";
            this.lblDestinoDescripcion.Location = new System.Drawing.Point(20, 260);

            // TextBoxes
            this.txtDNI.Location = new System.Drawing.Point(180, 20);
            this.txtDNI.Size = new System.Drawing.Size(200, 20);

            this.txtApellido.Location = new System.Drawing.Point(180, 60);
            this.txtApellido.Size = new System.Drawing.Size(200, 20);

            this.txtNombre.Location = new System.Drawing.Point(180, 100);
            this.txtNombre.Size = new System.Drawing.Size(200, 20);

            this.txtPeriodoCodigo.Location = new System.Drawing.Point(180, 140);
            this.txtPeriodoCodigo.Size = new System.Drawing.Size(200, 20);

            this.txtPeriodoDescripcion.Location = new System.Drawing.Point(180, 180);
            this.txtPeriodoDescripcion.Size = new System.Drawing.Size(200, 20);

            this.txtDestinoCodigo.Location = new System.Drawing.Point(180, 220);
            this.txtDestinoCodigo.Size = new System.Drawing.Size(200, 20);

            this.txtDestinoDescripcion.Location = new System.Drawing.Point(180, 260);
            this.txtDestinoDescripcion.Size = new System.Drawing.Size(200, 20);

            // Botón Guardar
            this.btnGuardar.Location = new System.Drawing.Point(180, 300);
            this.btnGuardar.Size = new System.Drawing.Size(200, 30);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // Formulario
            this.ClientSize = new System.Drawing.Size(420, 360);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblPeriodoCodigo);
            this.Controls.Add(this.txtPeriodoCodigo);
            this.Controls.Add(this.lblPeriodoDescripcion);
            this.Controls.Add(this.txtPeriodoDescripcion);
            this.Controls.Add(this.lblDestinoCodigo);
            this.Controls.Add(this.txtDestinoCodigo);
            this.Controls.Add(this.lblDestinoDescripcion);
            this.Controls.Add(this.txtDestinoDescripcion);
            this.Controls.Add(this.btnGuardar);
            this.Name = "frmAltas";
            this.Text = "Altas de Cliente, Periodo y Destino";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
