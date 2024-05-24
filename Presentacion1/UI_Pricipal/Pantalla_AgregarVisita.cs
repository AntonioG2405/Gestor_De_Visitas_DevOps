using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Capa_Negocio;

namespace Presentacion1.UI_Pricipal
{
    public partial class Pantalla_AgregarVisita : Form
    {
        public Pantalla_AgregarVisita()
        {
            InitializeComponent();
        }

        private void cbEdificio_SelectedIndexChanged(object sender, EventArgs e)
        {

         // Obtener el índice seleccionado en el comboBox1
            int selectedIndex = cbEdificio.SelectedIndex;
            cbAulas.Items.Clear();

            string[] Edificio1 = { "1-1a", "1-1b", "1-1c", "1-2a", "1-2b", "1-3c","Auditorio 1" };
            string[] Edificio2 = { "2-1a", "2-1b", "2-1c", "2-2a", "2-2b", "2-3c","Enfermeria" };
            string[] Edificio3 = { "3-1a", "3-1b", "3-1c", "3-2a", "3-2b", "3-3c","Aula de mecatronica" };
            string[] Edificio4 = { "4-1a", "4-1b", "4-1c", "4-2a", "4-2b", "3-3c","Biblioteca","Auditorio 4","Caja","Atencion Al cliente","Tickets" };

            if (selectedIndex == 1)
            {
                cbAulas.Items.AddRange(Edificio1);
            }
            else if (selectedIndex == 2)
            { 
                cbAulas.Items.AddRange(Edificio2);
            }
            else if (selectedIndex == 3)
            {
                cbAulas.Items.AddRange(Edificio3);
            }
            else if (selectedIndex == 4)
            {
                cbAulas.Items.AddRange(Edificio4);

            }
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Name")
            {
                txtNombre.Text = "";
            }
        }
        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Name";
            }
        }
        private void txtApellido_Enter(object sender, EventArgs e)
        {
            if (txtApellido.Text == "Last Name")
            {
                txtApellido.Text = "";
            }
        }
        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                txtApellido.Text = "Last Name";
            }
        }
        private void txtCarrera_Enter(object sender, EventArgs e)
        {
            if (txtCarrera.Text == "Carrier (optional)")
            {
                txtCarrera.Text = "";
            }
        }
        private void txtCarrera_Leave(object sender, EventArgs e)
        {
            if (txtCarrera.Text == "")
            {
                txtCarrera.Text = "Carrier (optionalme)";
            }
        }
        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email (optional)")
            {
                txtEmail.Text = "";
            }
        }
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email (optional)";
            }
        }
        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "Phone (opcional)")
            {
                txtTelefono.Text = "";
            }
        }
        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "")
            {
                txtTelefono.Text = "Phone (optional)";
            }
        }
        private void txtRazon_Enter(object sender, EventArgs e)
        {
            if (txtRazon.Text == "Information")
            {
                txtRazon.Text = "";
            }
        }
        private void txtRazon_Leave(object sender, EventArgs e)
        {
            if (txtRazon.Text == "")
            {
                txtRazon.Text = "Information";       
            }
        }

        private void LimpiarData()
        {
            txtNombre.Text = "Name";
            txtApellido.Text = "Last Name";
            txtCarrera.Text = "Carrier (optional)";
            txtEmail.Text = "Email (optional)";
            txtTelefono.Text = "Phone (optional)";
            txtRazon.Text = "Information";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LimpiarData();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            C_Ent_Visita objEnt = new C_Ent_Visita();
            C_Neg_Visita objNeg = new C_Neg_Visita();
            try
            {
                objEnt.Nombre = txtNombre.Text;
                objEnt.Apellido = txtApellido.Text;
                objEnt.Carrera = txtCarrera.Text;
                objEnt.Email = txtEmail.Text;
                objEnt.Telefono = txtTelefono.Text;
                objEnt.Motivo = txtRazon.Text;
                objEnt.Edificio = cbEdificio.Text;
                objEnt.Aula = cbAulas.Text;
                objEnt.Fecha_Hora = DateTime.Now;

                objNeg.AddVisitas(objEnt);
                LimpiarData();
                MessageBox.Show("Bienvenido " + objEnt.Nombre + " Disfruta tu esrtadia en el ITLA");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error en la base dedatos"+ex);
            }
        }
    }
}
