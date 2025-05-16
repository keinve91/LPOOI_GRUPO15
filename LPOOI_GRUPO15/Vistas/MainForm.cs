using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vistas
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InicializarMenu();
        }

        private void InicializarMenu()
        {
            MenuStrip menuStrip = new MenuStrip();

            // Crear los ítems del menú
            ToolStripMenuItem sistemaItem = new ToolStripMenuItem("Sistema");
            ToolStripMenuItem clientesItem = new ToolStripMenuItem("Clientes");
            ToolStripMenuItem prestamosItem = new ToolStripMenuItem("Préstamos");

            // Agregar ítems al menú
            menuStrip.Items.Add(sistemaItem);
            menuStrip.Items.Add(clientesItem);
            menuStrip.Items.Add(prestamosItem);

            // Asociar el menú principal al formulario
            this.MainMenuStrip = menuStrip;

            // Agregar el control MenuStrip al formulario y acomodarlo arriba
            this.Controls.Add(menuStrip);
            menuStrip.Dock = DockStyle.Top;

            // Eventos para cada módulo (por ahora solo un mensaje)
            sistemaItem.Click += (s, e) =>
            {
                frmAltas fa = new frmAltas();
                fa.ShowDialog();
            };
            clientesItem.Click += (s, e) =>
            {
                frmAltas fa = new frmAltas();
                fa.ShowDialog(); 
            };
            prestamosItem.Click += (s, e) =>
            {
                frmAltas fa = new frmAltas();
                fa.ShowDialog();
            };
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Opcional, si querés hacer algo cuando se carga el formulario
        }
    }
}
