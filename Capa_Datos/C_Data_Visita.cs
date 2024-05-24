using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Capa_Entidad;
using System.Data;
using System.Windows.Forms;


namespace Capa_Datos
{
    public class C_Data_Visita
    {        
        SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Con"].ConnectionString);
        //---------------------------------------------------------------------------------------------------------------
        public void AddDataVisita(C_Ent_Visita V)
        {
            string query = "AgregarVisita";
            using (SqlCommand cmd = new SqlCommand(query, Conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", V.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", V.Apellido);
                cmd.Parameters.AddWithValue("@Carrera", V.Carrera);
                cmd.Parameters.AddWithValue("@Email", V.Email);
                cmd.Parameters.AddWithValue("@Telefono", V.Telefono);
                cmd.Parameters.AddWithValue("@Fecha_Hora", V.Fecha_Hora);
                cmd.Parameters.AddWithValue("@Edifico", V.Edificio);
                cmd.Parameters.AddWithValue("@Aula", V.Aula);
                cmd.Parameters.AddWithValue("@Motivo", V.Motivo);
                try
                {
                    Conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {

                    // Manejar la excepción aquí según tus necesidades
                    MessageBox.Show("Error de base de datos: " + ex.Message);
                }
            }
            Conn.Close();
        }
        //----------------------------------------------------------------------------------------------
        public void AddAyudaVisita(C_Ent_Ayuda V)
        {
            string query = "AgregarAyuda";
            using (SqlCommand cmd = new SqlCommand(query, Conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FullName", V.NombreCompleto);
                cmd.Parameters.AddWithValue("@Email", V.Email);
                cmd.Parameters.AddWithValue("@telefono", V.Telefono);
                cmd.Parameters.AddWithValue("@descripcuion", V.Descripcion);

                try
                {
                    Conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {

                    // Manejar la excepción aquí según tus necesidades
                    MessageBox.Show("Error de base de datos: " + ex.Message);
                }
            }
            Conn.Close();
        }


    }
}
