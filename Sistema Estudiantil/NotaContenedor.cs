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
    public partial class NotaContenedor : UserControl
    {
        public NotaContenedor()
        {
            InitializeComponent();
        }

        // MÉTODOS

        private void CargarAlumnos()
        {
            using (SqlConnection con = ConexionDB.ObtenerConexion())
            {
                string query = "SELECT ID_Alumno, Nombre + ' ' + Apellido AS NombreCompleto FROM Alumnos";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbAlumnos.DataSource = dt;
                cbAlumnos.DisplayMember = "NombreCompleto";
                cbAlumnos.ValueMember = "ID_Alumno";
                cbAlumnos.SelectedIndex = -1;
            }
        }

        private void CargarMaterias()
        {
            using (SqlConnection con = ConexionDB.ObtenerConexion())
            {
                string query = "SELECT ID_Materia, Nombre FROM Materias";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbMateria.DataSource = dt;
                cbMateria.DisplayMember = "Nombre";
                cbMateria.ValueMember = "ID_Materia";
                cbMateria.SelectedIndex = -1;
            }
        }

        private void CargarNotas()
        {
            
            if (cbAlumnos.SelectedValue == null || cbAlumnos.SelectedValue is DataRowView)
                return;

            using (SqlConnection con = ConexionDB.ObtenerConexion())
            {
                string query = @"SELECT 
                                Notas.ID_Nota,
                                Materias.Nombre AS Materia,
                                Notas.Nota,
                                Notas.Periodo,
                                Notas.Fecha
                                FROM Notas
                                INNER JOIN Inscripciones ON Notas.ID_Inscripcion = Inscripciones.ID_Inscripcion
                                INNER JOIN Materias ON Inscripciones.ID_Materia = Materias.ID_Materia
                                WHERE Inscripciones.ID_Alumno = @Alumno";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Alumno", Convert.ToInt32(cbAlumnos.SelectedValue));

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                presentar4.DataSource = dt;
            }
        }

        private int ObtenerOCrearInscripcion(int idAlumno, int idMateria)
        {
            using (SqlConnection con = ConexionDB.ObtenerConexion())
            {
                con.Open();

                string queryBuscar = @"SELECT ID_Inscripcion 
                                      FROM Inscripciones 
                                      WHERE ID_Alumno=@Alumno AND ID_Materia=@Materia";

                SqlCommand cmdBuscar = new SqlCommand(queryBuscar, con);
                cmdBuscar.Parameters.AddWithValue("@Alumno", idAlumno);
                cmdBuscar.Parameters.AddWithValue("@Materia", idMateria);

                object resultado = cmdBuscar.ExecuteScalar();

                if (resultado != null)
                    return Convert.ToInt32(resultado);

                string queryInsert = @"INSERT INTO Inscripciones (ID_Alumno, ID_Materia, FechaInscripcion)
                                      VALUES (@Alumno, @Materia, GETDATE());
                                      SELECT SCOPE_IDENTITY();";

                SqlCommand cmdInsert = new SqlCommand(queryInsert, con);
                cmdInsert.Parameters.AddWithValue("@Alumno", idAlumno);
                cmdInsert.Parameters.AddWithValue("@Materia", idMateria);

                return Convert.ToInt32(cmdInsert.ExecuteScalar());
            }
        }

        private void LimpiarCampos()
        {
            cbAlumnos.SelectedIndex = -1;
            cbMateria.SelectedIndex = -1;
            txtNota.Clear();
            txtPeriodo.Clear();
            dtFecha.Value = DateTime.Now;
        }

        // 🔹 LOAD

        private void NotaContenedor_Load(object sender, EventArgs e)
        {
            CargarAlumnos();
            CargarMaterias();
        }

        // eventos

        private void cbAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cbAlumnos.SelectedValue == null || cbAlumnos.SelectedValue is DataRowView)
                return;

            CargarNotas();
        }

        private void cbMateria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNota_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPeriodo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar4_Click(object sender, EventArgs e)
        {
            if (cbAlumnos.SelectedValue == null || cbAlumnos.SelectedValue is DataRowView ||
                cbMateria.SelectedValue == null || cbMateria.SelectedValue is DataRowView)
                return;

            int idAlumno = Convert.ToInt32(cbAlumnos.SelectedValue);
            int idMateria = Convert.ToInt32(cbMateria.SelectedValue);

            int idInscripcion = ObtenerOCrearInscripcion(idAlumno, idMateria);

            using (SqlConnection con = ConexionDB.ObtenerConexion())
            {
                string query = @"INSERT INTO Notas 
                                (ID_Inscripcion, Nota, Periodo, Fecha)
                                VALUES (@Inscripcion, @Nota, @Periodo, @Fecha)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Inscripcion", idInscripcion);
                cmd.Parameters.AddWithValue("@Nota", Convert.ToDecimal(txtNota.Text));
                cmd.Parameters.AddWithValue("@Periodo", txtPeriodo.Text);
                cmd.Parameters.AddWithValue("@Fecha", dtFecha.Value);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            CargarNotas();
            LimpiarCampos();
        }

        private void btnEditar4_Click(object sender, EventArgs e)
        {
            if (presentar4.CurrentRow != null)
            {
                int id = Convert.ToInt32(presentar4.CurrentRow.Cells["ID_Nota"].Value);

                using (SqlConnection con = ConexionDB.ObtenerConexion())
                {
                    string query = @"UPDATE Notas SET
                                    Nota=@Nota,
                                    Periodo=@Periodo,
                                    Fecha=@Fecha
                                    WHERE ID_Nota=@ID";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@Nota", Convert.ToDecimal(txtNota.Text));
                    cmd.Parameters.AddWithValue("@Periodo", txtPeriodo.Text);
                    cmd.Parameters.AddWithValue("@Fecha", dtFecha.Value);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                CargarNotas();
                LimpiarCampos();
            }
        }

        private void btnEliminar4_Click(object sender, EventArgs e)
        {
            if (presentar4.CurrentRow != null)
            {
                int id = Convert.ToInt32(presentar4.CurrentRow.Cells["ID_Nota"].Value);

                using (SqlConnection con = ConexionDB.ObtenerConexion())
                {
                    string query = "DELETE FROM Notas WHERE ID_Nota=@ID";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ID", id);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                CargarNotas();
                LimpiarCampos();
            }
        }

        private void btnLimpiar4_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void presentar4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = presentar4.Rows[e.RowIndex];

                txtNota.Text = row.Cells["Nota"].Value.ToString();
                txtPeriodo.Text = row.Cells["Periodo"].Value.ToString();
                dtFecha.Value = Convert.ToDateTime(row.Cells["Fecha"].Value);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}