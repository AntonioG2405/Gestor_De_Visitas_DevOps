using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Negocio
{
    public class C_Neg_Admin
    {
        C_Data_Admin objData = new C_Data_Admin();

        public void Login_Admin(C_Ent_Admin A) => objData.LoginAdmin(A);

        public void AddUserRegular(C_Ent_Regular R) => objData.addNewUser(R);
        public void UpdateUserRegular(C_Ent_Regular R) => objData.UpDateUser(R);
        public void UserRegular(C_Ent_Regular R) => objData.DeleteUser(R);
        public void DeleteUserRegular(C_Ent_Regular R) => objData.DeleteUser(R);

        public DataTable FiltrarUsuarios(string Buscar)
        {
            return objData.BuscarUsuarios(Buscar);
        }

        public DataTable ListarUsuarios()
        {
            return objData.D_listado();
        }
    }
}
