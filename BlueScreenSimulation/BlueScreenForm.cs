using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueScreenSimulation
{
    public partial class BlueScreenForm : Form
    {
        public BlueScreenForm()
        {
            //InitializeComponent();
            // Configuración de la ventana
            this.Text = "Blue Screen of Death";
            this.BackColor = Color.FromArgb(0, 0, 139); // Azul oscuro
            this.WindowState = FormWindowState.Maximized; // Pantalla completa
            this.FormBorderStyle = FormBorderStyle.None; // Sin bordes
            this.KeyDown += (sender, e) =>
            {
                // Cerrar la simulación al presionar Escape
                if (e.KeyCode == Keys.Escape) Application.Exit();
            };

            // Configurar el texto
            Label errorLabel = new Label
            {
                Text = ":(\n\nSe ha encontrado un problema y el sistema debe reiniciarse.\n\n" +
                       "Si desea obtener más información, visite https://support.microsoft.com \n\n" +
                       "Se acabo, es hora de salida. :)",
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                Font = new Font("Consolas", 18, FontStyle.Bold), // Fuente similar a la de la BSOD
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };

            // Agregar el texto a la ventana
            this.Controls.Add(errorLabel);
        }

    }
}
