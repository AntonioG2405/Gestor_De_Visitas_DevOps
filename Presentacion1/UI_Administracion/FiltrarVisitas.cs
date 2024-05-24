using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion1.UI_Administracion
{
    public partial class FiltrarVisitas : Form
    {
        public FiltrarVisitas()
        {
            InitializeComponent();
        }

        public void accionestTabla()
        {
            DGV_Filtro.Columns[0].Width = 80;
            DGV_Filtro.Columns[1].Width = 120;
            DGV_Filtro.Columns[2].Width = 120;
            DGV_Filtro.Columns[3].Width = 100;
            DGV_Filtro.Columns[4].Width = 100;
            DGV_Filtro.Columns[5].Width = 120;
            DGV_Filtro.Columns[6].Width = 100;
        }
        private void MostrarInfo()
        {
            C_Neg_Admin objNeg = new C_Neg_Admin();
            DataTable dt = objNeg.ListarUsuarios();
            DGV_Filtro.DataSource = dt;
        }

        private void FiltrarVisitas_Load(object sender, EventArgs e)
        {
            MostrarInfo();
            accionestTabla();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            C_Neg_Admin objNeg = new C_Neg_Admin();

            DGV_Filtro.DataSource = objNeg.FiltrarUsuarios(txtFiltro.Text);
            txtFiltro.Text = "";
        }
    }
}
