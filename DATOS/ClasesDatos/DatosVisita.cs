using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
//using ENTIDADES;

namespace DATOS.ClasesDatos
{
    internal class DatosVisita
    {
        SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Con"].ConnectionString);


        //Agregar datos de visita
        public void AgregarVisita()
        {
            string query = "sp_AgregarVisita";

        }

    }
}
