using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Estudiantil
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void titulo_MouseEnter(object sender, EventArgs e)
        {
            titulo.ForeColor = Color.LightBlue;
        }

        private void titulo_MouseLeave(object sender, EventArgs e)
        {
            titulo.ForeColor = Color.White;
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            panelContenido.Controls.Clear();

            Alumnoscontenedor uc = new Alumnoscontenedor();
            uc.Dock = DockStyle.Fill;

            panelContenido.Controls.Add(uc);
        }

        private void btnProfesor_Click(object sender, EventArgs e)
        {

        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {

        }

        private void btnHorarios_Click(object sender, EventArgs e)
        {

        }

        private void btnNota_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
