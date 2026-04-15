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
    public partial class HorarioContenedor : UserControl
    {
        public HorarioContenedor()
        {
            InitializeComponent();
        }

        // 🔹 MÉTODOS

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

        private void CargarDias()
        {
            cbDia.Items.Clear();

            cbDia.Items.Add("Lunes");
            cbDia.Items.Add("Martes");
            cbDia.Items.Add("Miércoles");
            cbDia.Items.Add("Jueves");
            cbDia.Items.Add("Viernes");
            cbDia.Items.Add("Sábado");

            cbDia.SelectedIndex = -1;
        }

        private void CargarHorarios()
        {
            using (SqlConnection con = ConexionDB.ObtenerConexion())
            {
                string query = @"SELECT 
                                Horarios.ID_Horario,
                                Materias.Nombre AS Materia,
                                Horarios.Dia,
                                Horarios.HoraInicio,
                                Horarios.HoraFin,
                                Horarios.Aula
                                FROM Horarios
                                INNER JOIN Materias 
                                ON Horarios.ID_Materia = Materias.ID_Materia";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                presentar3.DataSource = dt;
            }
        }

        private void LimpiarCampos()
        {
            cbMateria.SelectedIndex = -1;
            cbDia.SelectedIndex = -1;
            txtHoraInicial.Clear();
            txtHoraFin.Clear();
            txtAula.Clear();
        }

        // 🔹 EVENTOS

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HorarioContenedor_Load(object sender, EventArgs e)
        {
            CargarMaterias();
            CargarDias();
            CargarHorarios();
        }

        private void cbMateria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtHoraInicial_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHoraFin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAula_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar3_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = ConexionDB.ObtenerConexion())
            {
                string query = @"INSERT INTO Horarios 
                (ID_Materia, Dia, HoraInicio, HoraFin, Aula)
                VALUES (@Materia, @Dia, @HoraInicio, @HoraFin, @Aula)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Materia", cbMateria.SelectedValue);
                cmd.Parameters.AddWithValue("@Dia", cbDia.Text);
                cmd.Parameters.AddWithValue("@HoraInicio", txtHoraInicial.Text);
                cmd.Parameters.AddWithValue("@HoraFin", txtHoraFin.Text);
                cmd.Parameters.AddWithValue("@Aula", txtAula.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            CargarHorarios();
            LimpiarCampos();
        }

        private void btnEditar3_Click(object sender, EventArgs e)
        {
            if (presentar3.CurrentRow != null)
            {
                int id = Convert.ToInt32(presentar3.CurrentRow.Cells["ID_Horario"].Value);

                using (SqlConnection con = ConexionDB.ObtenerConexion())
                {
                    string query = @"UPDATE Horarios SET
                    ID_Materia=@Materia,
                    Dia=@Dia,
                    HoraInicio=@HoraInicio,
                    HoraFin=@HoraFin,
                    Aula=@Aula
                    WHERE ID_Horario=@ID";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@Materia", cbMateria.SelectedValue);
                    cmd.Parameters.AddWithValue("@Dia", cbDia.Text);
                    cmd.Parameters.AddWithValue("@HoraInicio", txtHoraInicial.Text);
                    cmd.Parameters.AddWithValue("@HoraFin", txtHoraFin.Text);
                    cmd.Parameters.AddWithValue("@Aula", txtAula.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                CargarHorarios();
                LimpiarCampos();
            }
        }

        private void btnEliminar3_Click(object sender, EventArgs e)
        {
            if (presentar3.CurrentRow != null)
            {
                int id = Convert.ToInt32(presentar3.CurrentRow.Cells["ID_Horario"].Value);

                using (SqlConnection con = ConexionDB.ObtenerConexion())
                {
                    string query = "DELETE FROM Horarios WHERE ID_Horario=@ID";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ID", id);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                CargarHorarios();
                LimpiarCampos();
            }
        }

        private void btnLimpiar3_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void presentar3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = presentar3.Rows[e.RowIndex];

                cbMateria.Text = row.Cells["Materia"].Value.ToString();
                cbDia.Text = row.Cells["Dia"].Value.ToString();
                txtHoraInicial.Text = row.Cells["HoraInicio"].Value.ToString();
                txtHoraFin.Text = row.Cells["HoraFin"].Value.ToString();
                txtAula.Text = row.Cells["Aula"].Value.ToString();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}