using Capa_Entidad;
using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion1.UI_Pricipal
{
    public partial class Pantalla_Ayuda : Form
    {
        public Pantalla_Ayuda()
        {
            InitializeComponent();
        }

        private void btnEnviarAuuda_Click(object sender, EventArgs e)
        {
            C_Ent_Ayuda objEnt = new C_Ent_Ayuda();
            C_Neg_Visita objNeg = new C_Neg_Visita();
            try
            {
                objEnt.NombreCompleto = txtFullNameAyuda.Text.ToUpper();
                objEnt.Email = txtEmailAyuda.Text.ToUpper();
                objEnt.Telefono = txtTelefonoAyuda.Text.ToUpper();
                objEnt.Descripcion = txtDescripcion.Text.ToUpper();


                objNeg.AddAyudaVisitas(objEnt);
                Limpiar();
                MessageBox.Show("Gracias por enviarnos tu solicitud Sr/Srt. "+ objEnt.NombreCompleto + " la misma sera Rencuanto antes ");

            }
            catch (SqlException ex)
            {

                // Manejar la excepción aquí según tus necesidades
                MessageBox.Show("Error de base de datos: " + ex.Message);
            }
        }

        private void txtFullNameAyuda_Enter(object sender, EventArgs e)
        {
            if (txtFullNameAyuda.Text == "Full Name")
            {
                txtFullNameAyuda.Text = "";
            }
        }

        private void txtFullNameAyuda_Leave(object sender, EventArgs e)
        {
            if (txtFullNameAyuda.Text == "")
            {
                txtFullNameAyuda.Text = "Full Name";
            }
        }

        private void txtEmailAyuda_Enter(object sender, EventArgs e)
        {
            if (txtEmailAyuda.Text == "Email")
            {
                txtEmailAyuda.Text = "";
            }
        }

        private void txtEmailAyuda_Leave(object sender, EventArgs e)
        {
            if (txtEmailAyuda.Text == "")
            {
                txtEmailAyuda.Text = "Email";
            }
        }

        private void txtTelefonoAyuda_Enter(object sender, EventArgs e)
        {
            if (txtTelefonoAyuda.Text == "Phone")
            {
                txtTelefonoAyuda.Text = "";
            }
        }

        private void txtTelefonoAyuda_Leave(object sender, EventArgs e)
        {
            if (txtTelefonoAyuda.Text == "")
            {
                txtTelefonoAyuda.Text = "Phone";
            }
        }

        private void txtDescripcion_Enter(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "Description")
            {
                txtDescripcion.Text = "";
            }
        }

        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "")
            {
                txtDescripcion.Text = "Description";
            }
        }

        private void Limpiar()
        {
            txtFullNameAyuda.Text = "Full Name";
            txtEmailAyuda.Text = "Email";
            txtTelefonoAyuda.Text = "Phone";
            txtDescripcion.Text = "Description";
        }

        private void btnLimpiarAyuda_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


    }
}
