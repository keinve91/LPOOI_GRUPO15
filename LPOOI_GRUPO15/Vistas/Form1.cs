using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas
{
    public partial class Form1 : Form
    {
        private List<Usuario> listaUsuarios;
        private Label lblUsuario;
        private Label lblContraseña;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button btnIngresar;

        public Form1()
        {
            InitializeComponent();
            InicializarComponentes();
            InicializarUsuarios();
        }

        private void InicializarComponentes()
        {
            this.Text = "Pantalla de Bienvenida";
            this.Size = new Size(350, 200);
            this.StartPosition = FormStartPosition.CenterScreen;

            lblUsuario = new Label();
            lblUsuario.Text = "Usuario:";
            lblUsuario.Location = new Point(30, 30);
            lblUsuario.AutoSize = true;

            txtUsuario = new TextBox();
            txtUsuario.Location = new Point(120, 30);
            txtUsuario.Size = new Size(150, 22);

            lblContraseña = new Label();
            lblContraseña.Text = "Contraseña:";
            lblContraseña.Location = new Point(30, 70);
            lblContraseña.AutoSize = true;

            txtContraseña = new TextBox();
            txtContraseña.Location = new Point(120, 70);
            txtContraseña.Size = new Size(150, 22);
            txtContraseña.UseSystemPasswordChar = true;

            btnIngresar = new Button();
            btnIngresar.Text = "Ingresar";
            btnIngresar.Location = new Point(120, 110);
            btnIngresar.Click += new EventHandler(btnIngresar_Click);

            this.Controls.Add(lblUsuario);
            this.Controls.Add(txtUsuario);
            this.Controls.Add(lblContraseña);
            this.Controls.Add(txtContraseña);
            this.Controls.Add(btnIngresar);
        }

        private void InicializarUsuarios()
        {
            listaUsuarios = new List<Usuario>();

            Usuario admin = new Usuario(1, "ADM");
            admin.USU_NombreUsuario = "admin";
            admin.USU_Contraseña = "1234";
            admin.USU_ApellidoNombre = "Administrador";

            Usuario operador = new Usuario(2, "OPE");
            operador.USU_NombreUsuario = "operador";
            operador.USU_Contraseña = "5678";
            operador.USU_ApellidoNombre = "Operador";

            Usuario auditor = new Usuario(3, "AUD");
            auditor.USU_NombreUsuario = "auditor";
            auditor.USU_Contraseña = "9012";
            auditor.USU_ApellidoNombre = "Auditor";

            listaUsuarios.Add(admin);
            listaUsuarios.Add(operador);
            listaUsuarios.Add(auditor);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombre = txtUsuario.Text.Trim();
            string pass = txtContraseña.Text;

            Usuario usuario = listaUsuarios.FirstOrDefault(u => u.USU_NombreUsuario == nombre && u.USU_Contraseña == pass);

            if (usuario != null)
            {
                MessageBox.Show(
                    string.Format("Bienvenido {0}\nRol: {1}", usuario.USU_ApellidoNombre, ObtenerRol(usuario)),
                    "Acceso Concedido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // Como ROL_Codigo es protected, usamos reflexión para obtenerlo
        private string ObtenerRol(Usuario u)
        {
            var campo = typeof(Usuario).GetField("ROL_Codigo", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            return campo != null ? campo.GetValue(u).ToString() : "Rol desconocido";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
