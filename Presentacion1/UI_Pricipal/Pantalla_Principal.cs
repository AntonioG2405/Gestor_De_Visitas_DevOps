using Presentacion1.UI_Admin.Login;
using Presentacion1.UI_Administracion;
using Presentacion1.UI_User.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion1.UI_Pricipal
{
    public partial class Pantalla_Principal : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();

        private const int RESIZE_MARGIN = 10; // Márgen de redimensionamiento

        private bool isAdmin;
     //   private bool isUser;



        public Pantalla_Principal(bool isAdmin)
        {
            InitializeComponent();
            this.customizeDesign();
            this.DoubleBuffered = true;

            this.isAdmin = isAdmin;
           // this.isUser = isUser;
            CheckUserRole();
          //  CheckUserRole1();

        }
      
        private void CheckUserRole()
        {
            if (isAdmin)
            {
                // Habilitar todos los botones si es administrador
               btnOption.Enabled = true;
               btnOptionAdmin.Enabled = true;
            }
            else 
            {
                // Deshabilitar el botón específico para usuarios no administradores
                btnOptionAdmin.Enabled = false;
            }
           
        }
        /*
        private void CheckUserRole1()
        {
            if (isUser)
            {
                // Habilitar todos los botones si es administrador
                btnOption.Enabled = true;
                btnOptionAdmin.Enabled = false;
            }
            else 
            {
                // Deshabilitar el botón específico para usuarios no administradores
                btnOptionAdmin.Enabled = true;
            }

        }
        */
        //------------------------------------------------------------------------------------------------------------
        //FRM secundarios
        private void OpenSecondForm(object FRMsecond)
        {
            if (this.panelPrincipal.Controls.Count > 0)
                this.panelPrincipal.Controls.RemoveAt(0);
            Form SecondForm = FRMsecond as Form;
            SecondForm.TopLevel = false;
            SecondForm.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(SecondForm);
            this.panelPrincipal.Tag = SecondForm;
            SecondForm.Show();

        }

        //------------------------------------------------------------------------------------------------------------
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //--------------------------------------------------------------------------------------------------
        //metodos para la funcionalidad del subMenu

        private void customizeDesign()
        {
            panelSubMenu1.Visible = false;
            panelSubMenu2.Visible = false;
        }
        private void HideSubMenu()
        {
            if (panelSubMenu1.Visible == true )
            {
                panelSubMenu1.Visible = false;
            }
            if (panelSubMenu2.Visible == true)
            {
                panelSubMenu2.Visible = false;
            }
        }
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void panelLateral2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void PanelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
        private void Pantalla_Principal_Load(object sender, EventArgs e)
        {
            btnHome_Click(null, e);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenSecondForm(new CargarInicio());
            HideSubMenu();
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenu1);
        }

        private void btnOptionAdmin_Click(object sender, EventArgs e)
        {

                ShowSubMenu(panelSubMenu2);
        }

        private void btnAddVisits_Click(object sender, EventArgs e)
        {
            OpenSecondForm(new Pantalla_AgregarVisita());
            HideSubMenu();
        }

        private void btnEndVisits_Click(object sender, EventArgs e)
        {
            OpenSecondForm(new Pantalla_VerVisitas());

            HideSubMenu();

        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            OpenSecondForm(new Pantalla_Ayuda());

            HideSubMenu();

        }

        private void btnBuscarData_Click(object sender, EventArgs e)
        {
            OpenSecondForm(new FiltrarVisitas());

            HideSubMenu();
        }

        private void btnEditarDAta_Click(object sender, EventArgs e)
        {
            OpenSecondForm(new AdminAjustesDeDatosVisita());

            HideSubMenu();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
           LoginUser lu = new LoginUser();
            lu.Show();
            this.Hide();

        }
    }
}
