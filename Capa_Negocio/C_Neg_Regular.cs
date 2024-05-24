using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Negocio
{
    public class C_Neg_Regular
    {
        C_Data_Regular objData = new C_Data_Regular();
        DataLogin dl = new DataLogin();
        public void Login_Regular (C_Ent_Regular R) => objData.LoginRegular(R);
        public void SingIn_Regular(C_Ent_Regular R) => objData.SingInRegular(R);
        public DataTable Buscar(string Buscar)
        {
            return objData.SearchData(Buscar);
        }
        public DataTable MostrarDatos()
        {
            return objData.D_listado();
        }

    }
}
