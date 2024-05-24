using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Negocio
{
    public class C_Neg_Visita
    {
        C_Data_Visita objData = new C_Data_Visita();
        public void AddVisitas(C_Ent_Visita V) => objData.AddDataVisita(V);
        public void AddAyudaVisitas(C_Ent_Ayuda V) => objData.AddAyudaVisita(V);

    }
}
