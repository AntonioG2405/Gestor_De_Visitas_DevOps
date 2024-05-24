using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES.ENTITY
{
    public class EntUser
    {
        int ID_User      { get; set; }
        string LoginUser { get; set; }
        string Password  { get; set; }
        string Nombre    { get; set; }
        string Apellido  { get; set; } 
        string Email     { get; set; }

    }
}
