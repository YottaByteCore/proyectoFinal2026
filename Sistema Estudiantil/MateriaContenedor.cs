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
    public partial class MateriaContenedor : UserControl
    {
        public MateriaContenedor()
        {
            InitializeComponent();
        }

        //  MÉTODOS

        private void CargarProfesores()
        {
            using (SqlConnection con = ConexionDB.ObtenerConexion())
            {
                string query = "SELECT ID_Profesor, Nombre + ' ' + Apellido AS NombreCompleto FROM Profesores";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbProfesor.DataSource = dt;
                cbProfesor.DisplayMember = "NombreCompleto";
                cbProfesor.ValueMember = "ID_Profesor";
                cbProfesor.SelectedIndex = -1;
            }
        }

        private void CargarEstado()
        {
            cbEstado.Items.Clear();

            cbEstado.Items.Add("Activo");
            cbEstado.Items.Add("Inactivo");

            cbEstado.SelectedIndex = -1;
        }

        private void CargarMaterias()
        {
            using (SqlConnection con = ConexionDB.ObtenerConexion())
            {
                string query = @"SELECT 
                                Materias.ID_Materia,
                                Materias.Nombre,
                                Materias.Descripcion,
                                Profesores.Nombre + ' ' + Profesores.Apellido AS Profesor,
                                Materias.Estado
                                FROM Materias
                                INNER JOIN Profesores 
                                ON Materias.ID_Profesor = Profesores.ID_Profesor";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                presentar7.DataSource = dt;
            }
        }

        private void LimpiarCampos()
        {
            txtMateria.Clear();
            txtDescripcion.Clear();
            cbProfesor.SelectedIndex = -1;
            cbEstado.SelectedIndex = -1;
        }

        

        private void MateriaContenedor_Load(object sender, EventArgs e)
        {
            CargarProfesores();
            CargarEstado();
            CargarMaterias();
        }

        

        private void txtMateria_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbProfesor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar7_Click(object sender, EventArgs e)
        {
            // VALIDACIÓN 
            if (cbProfesor.SelectedValue == null || cbProfesor.SelectedValue is DataRowView)
            {
                MessageBox.Show("Selecciona un profesor");
                return;
            }

            using (SqlConnection con = ConexionDB.ObtenerConexion())
            {
                string query = @"INSERT INTO Materias 
                                (Nombre, Descripcion, ID_Profesor, Estado)
                                VALUES (@Nombre, @Descripcion, @Profesor, @Estado)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Nombre", txtMateria.Text);
                cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                cmd.Parameters.AddWithValue("@Profesor", Convert.ToInt32(cbProfesor.SelectedValue));
                cmd.Parameters.AddWithValue("@Estado", cbEstado.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            CargarMaterias();
            LimpiarCampos();
        }

        private void btnEditar7_Click(object sender, EventArgs e)
        {
            if (presentar7.CurrentRow != null)
            {
                // VALIDACIÓN CLAVE
                if (cbProfesor.SelectedValue == null || cbProfesor.SelectedValue is DataRowView)
                {
                    MessageBox.Show("Selecciona un profesor");
                    return;
                }

                int id = Convert.ToInt32(presentar7.CurrentRow.Cells["ID_Materia"].Value);

                using (SqlConnection con = ConexionDB.ObtenerConexion())
                {
                    string query = @"UPDATE Materias SET
                                    Nombre=@Nombre,
                                    Descripcion=@Descripcion,
                                    ID_Profesor=@Profesor,
                                    Estado=@Estado
                                    WHERE ID_Materia=@ID";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@Nombre", txtMateria.Text);
                    cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                    cmd.Parameters.AddWithValue("@Profesor", Convert.ToInt32(cbProfesor.SelectedValue));
                    cmd.Parameters.AddWithValue("@Estado", cbEstado.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                CargarMaterias();
                LimpiarCampos();
            }
        }

        private void btnEliminar7_Click(object sender, EventArgs e)
        {
            if (presentar7.CurrentRow != null)
            {
                int id = Convert.ToInt32(presentar7.CurrentRow.Cells["ID_Materia"].Value);

                using (SqlConnection con = ConexionDB.ObtenerConexion())
                {
                    con.Open();

                    // BORRAR NOTAS
                    string queryNotas = @"DELETE FROM Notas 
                                 WHERE ID_Inscripcion IN 
                                 (SELECT ID_Inscripcion FROM Inscripciones WHERE ID_Materia=@ID)";
                    SqlCommand cmdNotas = new SqlCommand(queryNotas, con);
                    cmdNotas.Parameters.AddWithValue("@ID", id);
                    cmdNotas.ExecuteNonQuery();

                    // BORRAR INSCRIPCIONES
                    string queryInscripciones = "DELETE FROM Inscripciones WHERE ID_Materia=@ID";
                    SqlCommand cmdIns = new SqlCommand(queryInscripciones, con);
                    cmdIns.Parameters.AddWithValue("@ID", id);
                    cmdIns.ExecuteNonQuery();

                    // BORRAR HORARIOS 
                    string queryHorarios = "DELETE FROM Horarios WHERE ID_Materia=@ID";
                    SqlCommand cmdHor = new SqlCommand(queryHorarios, con);
                    cmdHor.Parameters.AddWithValue("@ID", id);
                    cmdHor.ExecuteNonQuery();

                    // BORRAR MATERIA
                    string queryMateria = "DELETE FROM Materias WHERE ID_Materia=@ID";
                    SqlCommand cmdMat = new SqlCommand(queryMateria, con);
                    cmdMat.Parameters.AddWithValue("@ID", id);
                    cmdMat.ExecuteNonQuery();

                    con.Close();
                }

                CargarMaterias();
                LimpiarCampos();
            }
        }

        private void btnLimpiar7_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void presentar7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = presentar7.Rows[e.RowIndex];

                txtMateria.Text = row.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = row.Cells["Descripcion"].Value.ToString();
                cbProfesor.Text = row.Cells["Profesor"].Value.ToString();
                cbEstado.Text = row.Cells["Estado"].Value.ToString();
            }
        }
    }
}