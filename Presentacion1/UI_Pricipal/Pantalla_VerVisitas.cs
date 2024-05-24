using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;

namespace Presentacion1.UI_Pricipal
{
    public partial class Pantalla_VerVisitas : Form
    {
        C_Neg_Regular objNeg = new C_Neg_Regular();
        public Pantalla_VerVisitas()
        {
            InitializeComponent();
        }

        public Guna.UI2.WinForms.Guna2DataGridView GetDGV_Principal()
        {
            return DGV_Principal;
        }

        public void accionesTabla()
        {
            DGV_Principal.Columns[0].Visible = false;
            DGV_Principal.Columns[1].Width = 120;
            DGV_Principal.Columns[2].Width = 120;
            DGV_Principal.Columns[3].Width = 100;
            DGV_Principal.Columns[4].Width = 400;

            DGV_Principal.ClearSelection();
        }
        private void MostrarInfo()
        {
            DataTable dt = objNeg.MostrarDatos();
            DGV_Principal.DataSource = dt;

        }
        private void Pantalla_FinalizarVisita_Load(object sender, EventArgs e)
        {
            //accionesTabla();
            MostrarInfo();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DGV_Principal.DataSource = objNeg.Buscar(txtBuscarDatos.Text);
            txtBuscarDatos.Text = "";
        }

        private void txtBuscarDatos_Enter(object sender, EventArgs e)
        {
            if (txtBuscarDatos.Text == "Sersh")
            {
                txtBuscarDatos.Text = "";
            }
        }

        private void txtBuscarDatos_Leave(object sender, EventArgs e)
        {
            if (txtBuscarDatos.Text == "")
            {
                txtBuscarDatos.Text = "Sersh";
            }
        }

       

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
