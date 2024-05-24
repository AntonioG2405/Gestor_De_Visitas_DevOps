using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using Capa_Entidad;
using System.Windows.Forms;


namespace Capa_Datos
{
    public class C_Data_Admin
    {
        SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Con"].ConnectionString);

        public void LoginAdmin(C_Ent_Admin A)
        {
            string query = "sp_LoginAdmin";
            using (SqlCommand cmd = new SqlCommand(query, Conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@LoginAdmin", A.LoginAdmin);
                cmd.Parameters.AddWithValue("@password", A.Password);
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
        //--------------------------------------------------------------------------------------------
        //Agregar datos de usuario nuevo

        public void addNewUser(C_Ent_Regular R)
        {
            string query = "AgregarUsuarioRegular1";
            using (SqlCommand cmd = new SqlCommand(query, Conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@LoginUser", R.LoginUser);
                cmd.Parameters.AddWithValue("@Password", R.Password);

                cmd.Parameters.AddWithValue("@Nombre", R.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", R.Apellido);

                cmd.Parameters.AddWithValue("@Email", R.Email);
                cmd.Parameters.AddWithValue("@Puesto", R.Puesto);

                try
                {
                    Conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error de base de datos: " + ex.Message);
                }
            }
            Conn.Close();
        }
        //-----------------------------------------------------------------------------------------
        //Actualizar usuario 
        public void UpDateUser(C_Ent_Regular R)
        {
            string query = "UpdateUserRegular5";
            using (SqlCommand cmd = new SqlCommand(query, Conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", R.ID_User);
                cmd.Parameters.AddWithValue("@LoginUser", R.LoginUser);
                cmd.Parameters.AddWithValue("@Password", R.Password);
                cmd.Parameters.AddWithValue("@Nombre", R.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", R.Apellido);
                cmd.Parameters.AddWithValue("@Email", R.Email);
                cmd.Parameters.AddWithValue("@Puesto", R.Puesto);

                try
                {
                    Conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error de base de datos: " + ex.Message);
                }
            }
        }
        //-----------------------------------------------------------------------------------------
        //Actualizar usuario 
        public void DeleteUser(C_Ent_Regular R)
        {
            string query = "deleteUser1";
            using (SqlCommand cmd = new SqlCommand(query, Conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", R.ID_User);


                try
                {
                    Conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error de base de datos: " + ex.Message);
                }
            }
            Conn.Close();
        }

        //----------------------------------------------------------------------------------------
        public DataTable D_listado()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("MostrarDatosUser", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                //llena la tabla de datos con los datos anteriormente recibidos
                da.Fill(dt);
                //retorna los datos ya almacenados en cada campo del dataTable
                return dt;
            }
            catch (System.Exception ex)
            {

                throw ex;
            }
        }
        //------------------------------------------------------------------------------------------------
        public DataTable BuscarUsuarios(string Buscar)
        {
            DataTable resultados = new DataTable();

            using (SqlCommand command = new SqlCommand("buscarUsuarios", Conn))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@BUSCAR", Buscar);


                try
                {
                    Conn.Open();

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
            Conn.Close();
            return resultados;
        }

    }
}
