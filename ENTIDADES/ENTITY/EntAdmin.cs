using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES.ENTITY
{
    public class EntAdmin
    {
        int    ID_Admin    { get; set; }
        string LoginAdmin  { get; set; }
        string Password    { get; set; }
        string Nombre      { get; set; }
        string Apellido    { get; set; }
        string Puesto      { get; set; }
        string Email       { get; set; }

    }
}
