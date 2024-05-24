using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES.ENTITY
{
    public class EntVisitas
    {
        private int      ID_Regular { get; set; }
        private string   Nombre     { get; set; }
        private string   Apellido   { get; set; }
        private string   Carrera    { get; set; }
        private string   Email      { get; set; }
        private string   Telefono   { get; set; }
        private DateTime Fecha_Hora { get; set; } 
        private string   Edificio   { get; set; }
        private string   Aula       { get; set; }
        private string   Motivo     { get; set; }
    }
}
