using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class C_Ent_Visita
    {
        public int ID_Regular { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Carrera { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public DateTime Fecha_Hora { get; set; }
        public string Edificio { get; set; }
        public string Aula { get; set; }
        public string Motivo { get; set; }
    }
}
