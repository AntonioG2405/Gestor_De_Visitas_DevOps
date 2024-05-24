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
    public class C_Data_Regular
    {
        SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Con"].ConnectionString);


        //----------------------------------------------------------------------------------------------
        //Longin and SIng-In

        //login Regular
        public void LoginRegular(C_Ent_Regular R)
        {
            string query = "sp_LoginRegular4";
            using (SqlCommand cmd = new SqlCommand(query, Conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@LoginUser", R.LoginUser);
                cmd.Parameters.AddWithValue("@password", R.Password);


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

        //singin Regular
        public void SingInRegular(C_Ent_Regular R)
        {
            string query = "AgregarUsuarioRegular1";
            using (SqlCommand cmd = new SqlCommand(query, Conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@LoginUser", R.LoginUser);
                cmd.Parameters.AddWithValue("@password", R.Password);
                cmd.Parameters.AddWithValue("@Nombre", R.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", R.Apellido);
                cmd.Parameters.AddWithValue("@Email", R.Email);
                cmd.Parameters.AddWithValue("@Puesto", R.Puesto);


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
        //---------------------------------------------------------------------------------------------

        public DataTable SearchData(string Buscar)
        {
            DataTable resultados = new DataTable();

            using (SqlCommand command = new SqlCommand("BuscarVisitante5", Conn))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Buscar", Buscar);


                try
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {

                        adapter.Fill(resultados);
                    }


                }
                catch (SqlException ex)
                {
                    // Manejar la excepción aquí según tus necesidades
                    MessageBox.Show("Error de base de datos: " + ex.Message);
                }
            }

            return resultados;
        }
        public DataTable D_listado()
        {
            DataTable dt = new DataTable();
            using (SqlCommand command = new SqlCommand("MostrarDatos3", Conn))
            {
                command.CommandType = CommandType.StoredProcedure;
                Conn.Open();
                dt.Load(command.ExecuteReader());
            }
            return dt;

        }
    }
}
