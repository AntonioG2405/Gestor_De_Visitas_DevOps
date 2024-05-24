using Capa_Datos;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class C_Neg_Login
    {
        DataLogin objDL = new DataLogin();

        public void LoginUser(C_Ent_Regular R) => objDL.ValidateLogin1(R);
        public void LoginAdmin(C_Ent_Admin A) => objDL.ValidateLogin(A);
    }
}
