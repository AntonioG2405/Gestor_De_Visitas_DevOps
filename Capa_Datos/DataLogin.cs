using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace Capa_Datos
{
    public class DataLogin
    {
        SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Con"].ConnectionString);

        public void ValidateLogin(C_Ent_Admin A)
        {
            Conn.Open();
            string query = "loginAdmin";
            using (SqlCommand command = new SqlCommand(query, Conn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@LoginAdmin", A.LoginAdmin);
                command.Parameters.AddWithValue("@Password", A.Password);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string result = reader["Result"].ToString();
                        if (result == "Login successful")
                        {
                            MessageBox.Show("Bienvenido");
                        }
                        else
                        {
                            // Mostrar un mensaje emergente de error
                            MessageBox.Show("Invalid username or password");
                        }
                    }
                    else
                    {
                        // Mostrar un mensaje emergente de error
                        MessageBox.Show("Invalid username or password");
                    }
                }
            }

        }   //-----------------------------------------------------------------------------------------
        public void ValidateLogin1(C_Ent_Regular R)
        {
            Conn.Open();
            string query = "loginUser";
            using (SqlCommand command = new SqlCommand(query, Conn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@LU", R.LoginUser);
                command.Parameters.AddWithValue("@pass", R.Password);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string result = reader["Result"].ToString();
                        if (result == "Login successful")
                        {
                            MessageBox.Show("Bienvenido");
                        }
                        else
                        {
                            // Mostrar un mensaje emergente de error
                            MessageBox.Show("Invalid username or password");
                        }
                    }
                    else
                    {
                        // Mostrar un mensaje emergente de error
                        MessageBox.Show("Invalid username or password");
                    }
                }
            }

        }




    }
}
