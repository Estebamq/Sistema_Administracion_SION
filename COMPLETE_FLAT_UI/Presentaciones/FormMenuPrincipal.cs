using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using COMPLETE_FLAT_UI.Presentaciones;
using COMPLETE_FLAT_UI.Presentaciones.alumno;
using COMPLETE_FLAT_UI.Presentaciones.instructor;
using Logic.Cache;
using Logic.Domain;


namespace COMPLETE_FLAT_UI
{
    public partial class FormMenuPrincipal : Form
    {


        //Constructor
        public FormMenuPrincipal()
        {
            InitializeComponent();
            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
            CustomizeDesing();
        }


        //METODO PARA OCULTAR SUBMENU DE LOS PANELES
        private void CustomizeDesing()
        {
            pnlSubmenuInstructor.Visible = false;
            pnlSubmenuAlumno.Visible = false;
        }

        private void HideSubMenu()
        {
            if (pnlSubmenuInstructor.Visible == true)
            {
                pnlSubmenuInstructor.Visible = false;
            }

            if (pnlSubmenuAlumno.Visible == true)
            {
                pnlSubmenuAlumno.Visible = false;
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

        //METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO  TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelContenedorPrincipal.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {

            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(55, 61, 69));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #region METODOS CERRAR/MAXIMIZAR/MINIMIZAR FORMULARIO
        //METODOS PARA CERRAR,MAXIMIZAR, MINIMIZAR FORMULARIO------------------------------------------------------
        int lx, ly;
        int sw, sh;
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnMaximizar.Visible = false;
            btnNormal.Visible = true;

        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            btnNormal.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            FormInformacion frm = new FormInformacion("¿ESTAS SEGURO QUE DESEAS SALIR?");
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        #endregion



        //METODOS PARA ANIMACION DE MENU SLIDING--
        private void btnMenu_Click(object sender, EventArgs e)
        {
            //-------CON EFECTO SLIDING
            // if (panelMenu.Width == 230)
            //{
            //  this.tmContraerMenu.Start();
            //}
            //else if (panelMenu.Width == 55)
            //{
            //  this.tmExpandirMenu.Start();
            //}

            //-------SIN EFECTO 
            if (panelMenu.Width == 55)
            {
                panelMenu.Width = 230;
            }
            else
            {
                panelMenu.Width = 55;
            }
        }

        private void tmExpandirMenu_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width >= 230)
                this.tmExpandirMenu.Stop();
            else
                panelMenu.Width = panelMenu.Width + 5;

        }

        private void tmContraerMenu_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width <= 55)
                this.tmContraerMenu.Stop();
            else
                panelMenu.Width = panelMenu.Width - 5;
        }

        //METODO PARA ABRIR FORM DENTRO DE PANEL-----------------------------------------------------
        private void AbrirFormEnPanel(object formHijo)
        {
            if (this.panelContenedorForm.Controls.Count > 0)
                this.panelContenedorForm.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelContenedorForm.Controls.Add(fh);
            this.panelContenedorForm.Tag = fh;
            fh.Show();
        }
        //METODO PARA MOSTRAR FORMULARIO DE LOGO Al INICIAR ----------------------------------------------------------
        private void MostrarFormLogo()
        {
            AbrirFormEnPanel(new FormLogo());
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            MostrarFormLogo();
            LoadUserData();
            ManejoDePermisos();
            
            this.Opacity = 0.0;
            timerMenuPrincipal.Start();

        }

        private void LoadUserData()
        {
            Cargo cargo = new Cargo();
            lblUser.Text = UserLoginCache.nombre + ", " + UserLoginCache.apellido;
            lblCargo.Text = cargo.ListingCargosPersonalId(UserLoginCache.cargo).NombreCargo;
        }



        //ANIMACION CON OPACIDAD DEL MENU PRINCIPAL
        int contador = 0;
        private void timerMenuPrincipal_Tick(object sender, EventArgs e)
        {

            if (this.Opacity < 1)
            {
                this.Opacity += 0.05;
            }
            contador++;
            if (contador == 100)
            {
                timerMenuPrincipal.Stop();
            }
        }

        //PERMISOS
        void ManejoDePermisos()
        { Cargo cargoUsuario = new Cargo();
            cargoUsuario = cargoUsuario.ListingCargosPersonalId(UserLoginCache.cargo);
            if (CargoEstructura.Recepcionista == cargoUsuario.NombreCargo) 
            {
                btnUsuarios.Enabled = false;
            }

            if (CargoEstructura.AgenteDeConsulta == cargoUsuario.NombreCargo)
            {
                btnUsuarios.Enabled = false;
                btnInstructores.Enabled = false;
                btnAltaEditarInstructor.Enabled = false;
            }


        }

        //METODO PARA MOSTRAR FORMULARIO DE LOGO Al CERRAR OTROS FORM ----------------------------------------------------------
        private void MostrarFormLogoAlCerrarForms(object sender, FormClosedEventArgs e)
        {
            MostrarFormLogo();
        }

        #region BOTONES PANEL IZQUIERDO
        //METODOS PARA ABRIR OTROS FORMULARIOS Y MOSTRAR FORM DE LOGO Al CERRAR ----------------------------------------------------------

        // BOTONES INSTRUCTOR-----------
        private void btnInstructores_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSubmenuInstructor);
        }


        private void btnAltaEditarInstructor_Click_1(object sender, EventArgs e)
        {
            FormListaInstructores fm = new FormListaInstructores();
            IniciarForm(fm);
        }



        private void btnBajaInstructor_Click(object sender, EventArgs e)
        {
            FormListaInstructoresBaja fm = new FormListaInstructoresBaja();
            IniciarForm(fm);
        }


        // BOTONES ALUMNO---------
        private void btnListaClientes_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSubmenuAlumno);
        }
         
        private void btnAltaEditarAlunmo_Click(object sender, EventArgs e)
        {
            FormListaAlumnos fm = new FormListaAlumnos();
            IniciarForm(fm);
        }



        private void btnBajaAlumno_Click(object sender, EventArgs e)
        {
            FormListaClientesBaja fm = new FormListaClientesBaja();
            IniciarForm(fm);

        }

        

        // BOTON BUSCAR CLASE-------------
        private void btnBuscarClase_Click(object sender, EventArgs e)
        {
            FormBuscarClases fm = new FormBuscarClases();
            IniciarForm(fm);
        }

        // BOTON PLANILLAS---------------
        private void btnPlanillas_Click(object sender, EventArgs e)
        {

            FormPlanillas fm = new FormPlanillas();
            IniciarForm(fm);
        }

        // BOTON DASHBOARD----INFORMACION DE LA ESCUELA DE MANEJO
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FormDashboard fm = new FormDashboard();
            IniciarForm(fm);

        }


        // BOTON USUARIO-----------------
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FormUsuario fm = new FormUsuario();
            IniciarForm(fm);
        }

        /// <summary>
        /// Metodo que inicia los formularios que recibe
        /// </summary>
        /// <param name="fm"></param>
        private void IniciarForm(Form fm)
        {
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
            HideSubMenu();
        }

       

        //BOTON DE CERRAR SESION
        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormInformacion frm = new FormInformacion("¿DESEA CERRAR SESION?");
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Close();
            }

        }
        #endregion

        #region HORA DEL PANEL PRINCIPAL
        //METODO PARA HORA Y FECHA ACTUAL ----------------------------------------------------------
        private void tmFechaHora_Tick(object sender, EventArgs e)
        {
            lbFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ssss");
        }
        #endregion

    }
}
