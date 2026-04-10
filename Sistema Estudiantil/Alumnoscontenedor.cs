using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sistema_Estudiantil
{
    public partial class Alumnoscontenedor : UserControl
    {
        public Alumnoscontenedor()
        {
            InitializeComponent();
        }

        private void Alumnoscontenedor_Load(object sender, EventArgs e)
        {
            presentar1.Columns.Clear();

            presentar1.Columns.Add("ID", "ID");
            presentar1.Columns.Add("Nombre", "Nombre");
            presentar1.Columns.Add("Apellido", "Apellido");
            presentar1.Columns.Add("Fecha", "Fecha Nac.");
            presentar1.Columns.Add("Sexo", "Sexo");
            presentar1.Columns.Add("Telefono", "Teléfono");
            presentar1.Columns.Add("Email", "Email");
            presentar1.Columns.Add("Estado", "Estado");

            presentar1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            CargarDatos();
        }

        private void CargarDatos()
        {
            presentar1.Rows.Clear();

            using (SqlConnection conn = ConexionDB.ObtenerConexion())
            {
                conn.Open();

                string query = "SELECT * FROM Alumnos";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    presentar1.Rows.Add(
                        reader["ID_Alumno"],
                        reader["Nombre"],
                        reader["Apellido"],
                        Convert.ToDateTime(reader["FechaNacimiento"]).ToShortDateString(),
                        reader["Sexo"],
                        reader["Telefono"],
                        reader["Email"],
                        reader["Estado"]
                    );
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = ConexionDB.ObtenerConexion())
            {
                conn.Open();

                string query = "INSERT INTO Alumnos (Nombre, Apellido, FechaNacimiento, Sexo, Telefono, Email, Estado) " +
                               "VALUES (@Nombre, @Apellido, @Fecha, @Sexo, @Telefono, @Email, @Estado)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Nombre", Nombre1.Text);
                cmd.Parameters.AddWithValue("@Apellido", Apellido1.Text);
                cmd.Parameters.AddWithValue("@Fecha", FechaNacimiento.Value);
                cmd.Parameters.AddWithValue("@Sexo", sexo1.Text);
                cmd.Parameters.AddWithValue("@Telefono", Telefono1.Text);
                cmd.Parameters.AddWithValue("@Email", Email1.Text);
                cmd.Parameters.AddWithValue("@Estado", Estado1.Text);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Alumno guardado");

            CargarDatos();
            LimpiarCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (presentar1.CurrentRow != null)
            {
                int id = Convert.ToInt32(presentar1.CurrentRow.Cells[0].Value);

                using (SqlConnection conn = ConexionDB.ObtenerConexion())
                {
                    conn.Open();

                    string query = "UPDATE Alumnos SET Nombre=@Nombre, Apellido=@Apellido, FechaNacimiento=@Fecha, Sexo=@Sexo, Telefono=@Telefono, Email=@Email, Estado=@Estado WHERE ID_Alumno=@Id";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@Nombre", Nombre1.Text);
                    cmd.Parameters.AddWithValue("@Apellido", Apellido1.Text);
                    cmd.Parameters.AddWithValue("@Fecha", FechaNacimiento.Value);
                    cmd.Parameters.AddWithValue("@Sexo", sexo1.Text);
                    cmd.Parameters.AddWithValue("@Telefono", Telefono1.Text);
                    cmd.Parameters.AddWithValue("@Email", Email1.Text);
                    cmd.Parameters.AddWithValue("@Estado", Estado1.Text);
                    cmd.Parameters.AddWithValue("@Id", id);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Alumno actualizado");

                CargarDatos();
                LimpiarCampos();
            }
        }

        private void tbnEliminar_Click(object sender, EventArgs e)
        {
            if (presentar1.CurrentRow != null)
            {
                int id = Convert.ToInt32(presentar1.CurrentRow.Cells[0].Value);

                using (SqlConnection conn = ConexionDB.ObtenerConexion())
                {
                    conn.Open();

                    string query = "DELETE FROM Alumnos WHERE ID_Alumno=@Id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", id);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Alumno eliminado");

                CargarDatos();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            Nombre1.Clear();
            Apellido1.Clear();
            Telefono1.Clear();
            Email1.Clear();

            sexo1.SelectedIndex = -1;
            Estado1.SelectedIndex = -1;

            FechaNacimiento.Value = DateTime.Now;
        }

        private void presentar1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (presentar1.CurrentRow != null)
            {
                DataGridViewRow fila = presentar1.CurrentRow;

                Nombre1.Text = fila.Cells[1].Value.ToString();
                Apellido1.Text = fila.Cells[2].Value.ToString();
                FechaNacimiento.Value = Convert.ToDateTime(fila.Cells[3].Value);
                sexo1.Text = fila.Cells[4].Value.ToString();
                Telefono1.Text = fila.Cells[5].Value.ToString();
                Email1.Text = fila.Cells[6].Value.ToString();
                Estado1.Text = fila.Cells[7].Value.ToString();
            }
        }
    }
}