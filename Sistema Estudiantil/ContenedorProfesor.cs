using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Estudiantil
{
    public partial class ContenedorProfesor : UserControl
    {
        public ContenedorProfesor()
        {
            InitializeComponent();
        }

        private void ContenedorProfesor_Load(object sender, EventArgs e)
        {
            CargarProfesores();
        }

        private void CargarProfesores()
        {
            using (SqlConnection con = ConexionDB.ObtenerConexion())
            {
                string query = "SELECT * FROM Profesores";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                presentar2.DataSource = dt;
            }
        }

        private void btnGuardar1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = ConexionDB.ObtenerConexion())
            {
                string query = @"INSERT INTO Profesores 
                (Nombre, Apellido, Especialidad, Telefono, Email, Estado)
                VALUES (@Nombre, @Apellido, @Especialidad, @Telefono, @Email, @Estado)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Nombre", Nombre2.Text);
                cmd.Parameters.AddWithValue("@Apellido", Apellido2.Text);
                cmd.Parameters.AddWithValue("@Especialidad", txtEspecial.Text);
                cmd.Parameters.AddWithValue("@Telefono", Telefono2.Text);
                cmd.Parameters.AddWithValue("@Email", Email2.Text);
                cmd.Parameters.AddWithValue("@Estado", Estado2.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            CargarProfesores();

            Nombre2.Clear();
            Apellido2.Clear();
            Telefono2.Clear();
            txtEspecial.Clear();
            Email2.Clear();
            Estado2.SelectedIndex = -1;
        }

        private void btnEditar1_Click(object sender, EventArgs e)
        {
            if (presentar2.CurrentRow != null)
            {
                int id = Convert.ToInt32(presentar2.CurrentRow.Cells["ID_Profesor"].Value);

                using (SqlConnection con = ConexionDB.ObtenerConexion())
                {
                    string query = @"UPDATE Profesores SET
                    Nombre=@Nombre,
                    Apellido=@Apellido,
                    Especialidad=@Especialidad,
                    Telefono=@Telefono,
                    Email=@Email,
                    Estado=@Estado
                    WHERE ID_Profesor=@ID";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@Nombre", Nombre2.Text);
                    cmd.Parameters.AddWithValue("@Apellido", Apellido2.Text);
                    cmd.Parameters.AddWithValue("@Especialidad", txtEspecial.Text);
                    cmd.Parameters.AddWithValue("@Telefono", Telefono2.Text);
                    cmd.Parameters.AddWithValue("@Email", Email2.Text);
                    cmd.Parameters.AddWithValue("@Estado", Estado2.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                CargarProfesores();

                Nombre2.Clear();
                Apellido2.Clear();
                Telefono2.Clear();
                txtEspecial.Clear();
                Email2.Clear();
                Estado2.SelectedIndex = -1;
            }
        }

        private void btnEliminar1_Click(object sender, EventArgs e)
        {
            if (presentar2.CurrentRow != null)
            {
                int id = Convert.ToInt32(presentar2.CurrentRow.Cells["ID_Profesor"].Value);

                using (SqlConnection con = ConexionDB.ObtenerConexion())
                {
                    string query = "DELETE FROM Profesores WHERE ID_Profesor=@ID";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ID", id);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Profesor eliminado");

                        CargarProfesores();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("No puedes eliminar este profesor porque tiene materias asignadas. Elimina primero las materias.");
                    }
                }

                Nombre2.Clear();
                Apellido2.Clear();
                Telefono2.Clear();
                txtEspecial.Clear();
                Email2.Clear();
                Estado2.SelectedIndex = -1;
            }
        }

        private void btnLimpiar1_Click(object sender, EventArgs e)
        {
            Nombre2.Clear();
            Apellido2.Clear();
            Telefono2.Clear();
            txtEspecial.Clear();
            Email2.Clear();
            Estado2.SelectedIndex = -1;
        }

        private void presentar2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = presentar2.Rows[e.RowIndex];

                Nombre2.Text = row.Cells["Nombre"].Value.ToString();
                Apellido2.Text = row.Cells["Apellido"].Value.ToString();
                txtEspecial.Text = row.Cells["Especialidad"].Value.ToString();
                Telefono2.Text = row.Cells["Telefono"].Value.ToString();
                Email2.Text = row.Cells["Email"].Value.ToString();

                // ComboBox (Estado)
                Estado2.Text = row.Cells["Estado"].Value.ToString();
            }
        }
    }
}
