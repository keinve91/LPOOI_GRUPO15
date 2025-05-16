using System;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas
{
    public partial class frmAltas : Form
    {
        public frmAltas()
        {
            InitializeComponent();
        }

       private void btnGuardar_Click(object sender, EventArgs e)
{
    // Validar campos obligatorios
    if (string.IsNullOrWhiteSpace(txtDNI.Text) ||
        string.IsNullOrWhiteSpace(txtApellido.Text) ||
        string.IsNullOrWhiteSpace(txtNombre.Text) ||
        string.IsNullOrWhiteSpace(txtPeriodoCodigo.Text) ||
        string.IsNullOrWhiteSpace(txtPeriodoDescripcion.Text) ||
        string.IsNullOrWhiteSpace(txtDestinoCodigo.Text) ||
        string.IsNullOrWhiteSpace(txtDestinoDescripcion.Text))
    {
        MessageBox.Show("Por favor, completá todos los campos obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
    }

    int perCodigo;
    if (!int.TryParse(txtPeriodoCodigo.Text, out perCodigo))
    {
        MessageBox.Show("El código del Periodo debe ser un número entero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        txtPeriodoCodigo.Focus();
        return;
    }

    int desCodigo;
    if (!int.TryParse(txtDestinoCodigo.Text, out desCodigo))
    {
        MessageBox.Show("El código del Destino debe ser un número entero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        txtDestinoCodigo.Focus();
        return;
    }


    // Confirmación
    DialogResult result = MessageBox.Show("¿Desea guardar los datos ingresados?", "Confirmar", MessageBoxButtons.YesNo);
    if (result == DialogResult.Yes)
    {
        Cliente oCliente = new Cliente(txtDNI.Text);
        oCliente.CLI_Apellido = txtApellido.Text;
        oCliente.CLI_Nombre = txtNombre.Text;

        Periodo oPeriodo = new Periodo(perCodigo, txtPeriodoDescripcion.Text);
        Destino oDestino = new Destino(desCodigo, txtDestinoDescripcion.Text);

        MessageBox.Show("CLIENTE:\nDNI: " + oCliente.GetDNI() +
                        "\nApellido: " + oCliente.CLI_Apellido +
                        "\nNombre: " + oCliente.CLI_Nombre +
                        "\n\nPERIODO:\nCódigo: " + oPeriodo.GetCodigo() +
                        "\nDescripción: " + oPeriodo.PER_Descripcion +
                        "\n\nDESTINO:\nCódigo: " + oDestino.GetCodigo() +
                        "\nDescripción: " + oDestino.DES_Descripcion,
                        "Datos Ingresados");

        // Limpiar campos
        txtDNI.Clear();
        txtApellido.Clear();
        txtNombre.Clear();
        txtPeriodoCodigo.Clear();
        txtPeriodoDescripcion.Clear();
        txtDestinoCodigo.Clear();
        txtDestinoDescripcion.Clear();

        txtDNI.Focus();
    }
}

    }
}
