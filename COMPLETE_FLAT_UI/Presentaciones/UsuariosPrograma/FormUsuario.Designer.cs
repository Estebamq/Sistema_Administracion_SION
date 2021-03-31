
namespace COMPLETE_FLAT_UI.Presentaciones
{
    partial class FormUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelEditarPerfil = new System.Windows.Forms.Panel();
            this.cmbBoxCargoPersonal = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxContraseñaActual = new System.Windows.Forms.TextBox();
            this.txtBoxConfirmarContraseña = new System.Windows.Forms.TextBox();
            this.txtBoxNuevaContraseña = new System.Windows.Forms.TextBox();
            this.labelContraseñaActual = new System.Windows.Forms.Label();
            this.labelConfirmarContraseña = new System.Windows.Forms.Label();
            this.labelNuevaContraseña = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxApellido = new System.Windows.Forms.TextBox();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.txtBoxNombreUsuario = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            this.labelEditarPerfil = new System.Windows.Forms.Label();
            this.panelInformacionDelPerfil = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.btnCrearNuevoUsuario = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCrearNuevoMedioDePago = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLblEditar = new System.Windows.Forms.LinkLabel();
            this.lblInputEmail = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblInputCargo = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblInputApellido = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblinputNombre = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblInputnombreUsuario = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelEditarPerfil.SuspendLayout();
            this.panelInformacionDelPerfil.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Image = global::COMPLETE_FLAT_UI.Properties.Resources.Close;
            this.BtnCerrar.Location = new System.Drawing.Point(3, 10);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(43, 43);
            this.BtnCerrar.TabIndex = 7;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "MI PERFIL";
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.Firebrick;
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGenerar.Location = new System.Drawing.Point(11, 54);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(129, 36);
            this.btnGenerar.TabIndex = 28;
            this.btnGenerar.Text = "GENERAR";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Base de Datos";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnCerrar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 59);
            this.panel1.TabIndex = 30;
            // 
            // panelEditarPerfil
            // 
            this.panelEditarPerfil.BackColor = System.Drawing.Color.LightGray;
            this.panelEditarPerfil.Controls.Add(this.cmbBoxCargoPersonal);
            this.panelEditarPerfil.Controls.Add(this.label4);
            this.panelEditarPerfil.Controls.Add(this.txtBoxContraseñaActual);
            this.panelEditarPerfil.Controls.Add(this.txtBoxConfirmarContraseña);
            this.panelEditarPerfil.Controls.Add(this.txtBoxNuevaContraseña);
            this.panelEditarPerfil.Controls.Add(this.labelContraseñaActual);
            this.panelEditarPerfil.Controls.Add(this.labelConfirmarContraseña);
            this.panelEditarPerfil.Controls.Add(this.labelNuevaContraseña);
            this.panelEditarPerfil.Controls.Add(this.btnAceptar);
            this.panelEditarPerfil.Controls.Add(this.btnCancelar);
            this.panelEditarPerfil.Controls.Add(this.txtBoxEmail);
            this.panelEditarPerfil.Controls.Add(this.txtBoxApellido);
            this.panelEditarPerfil.Controls.Add(this.txtBoxNombre);
            this.panelEditarPerfil.Controls.Add(this.txtBoxNombreUsuario);
            this.panelEditarPerfil.Controls.Add(this.labelEmail);
            this.panelEditarPerfil.Controls.Add(this.labelApellido);
            this.panelEditarPerfil.Controls.Add(this.labelNombre);
            this.panelEditarPerfil.Controls.Add(this.labelNombreUsuario);
            this.panelEditarPerfil.Controls.Add(this.labelEditarPerfil);
            this.panelEditarPerfil.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelEditarPerfil.Location = new System.Drawing.Point(589, 59);
            this.panelEditarPerfil.Name = "panelEditarPerfil";
            this.panelEditarPerfil.Size = new System.Drawing.Size(303, 493);
            this.panelEditarPerfil.TabIndex = 31;
            this.panelEditarPerfil.Visible = false;
            // 
            // cmbBoxCargoPersonal
            // 
            this.cmbBoxCargoPersonal.FormattingEnabled = true;
            this.cmbBoxCargoPersonal.Location = new System.Drawing.Point(21, 197);
            this.cmbBoxCargoPersonal.Name = "cmbBoxCargoPersonal";
            this.cmbBoxCargoPersonal.Size = new System.Drawing.Size(255, 21);
            this.cmbBoxCargoPersonal.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(119, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 53;
            this.label4.Text = "Cargo";
            // 
            // txtBoxContraseñaActual
            // 
            this.txtBoxContraseñaActual.Location = new System.Drawing.Point(21, 383);
            this.txtBoxContraseñaActual.Name = "txtBoxContraseñaActual";
            this.txtBoxContraseñaActual.Size = new System.Drawing.Size(255, 20);
            this.txtBoxContraseñaActual.TabIndex = 52;
            // 
            // txtBoxConfirmarContraseña
            // 
            this.txtBoxConfirmarContraseña.Location = new System.Drawing.Point(21, 333);
            this.txtBoxConfirmarContraseña.Name = "txtBoxConfirmarContraseña";
            this.txtBoxConfirmarContraseña.Size = new System.Drawing.Size(255, 20);
            this.txtBoxConfirmarContraseña.TabIndex = 51;
            // 
            // txtBoxNuevaContraseña
            // 
            this.txtBoxNuevaContraseña.Location = new System.Drawing.Point(21, 287);
            this.txtBoxNuevaContraseña.Name = "txtBoxNuevaContraseña";
            this.txtBoxNuevaContraseña.Size = new System.Drawing.Size(255, 20);
            this.txtBoxNuevaContraseña.TabIndex = 50;
            // 
            // labelContraseñaActual
            // 
            this.labelContraseñaActual.AutoSize = true;
            this.labelContraseñaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContraseñaActual.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelContraseñaActual.Location = new System.Drawing.Point(76, 360);
            this.labelContraseñaActual.Name = "labelContraseñaActual";
            this.labelContraseñaActual.Size = new System.Drawing.Size(141, 20);
            this.labelContraseñaActual.TabIndex = 47;
            this.labelContraseñaActual.Text = "Contraseña Actual";
            // 
            // labelConfirmarContraseña
            // 
            this.labelConfirmarContraseña.AutoSize = true;
            this.labelConfirmarContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmarContraseña.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelConfirmarContraseña.Location = new System.Drawing.Point(45, 310);
            this.labelConfirmarContraseña.Name = "labelConfirmarContraseña";
            this.labelConfirmarContraseña.Size = new System.Drawing.Size(214, 20);
            this.labelConfirmarContraseña.TabIndex = 48;
            this.labelConfirmarContraseña.Text = "Confirmar Nueva Contraseña";
            // 
            // labelNuevaContraseña
            // 
            this.labelNuevaContraseña.AutoSize = true;
            this.labelNuevaContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNuevaContraseña.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelNuevaContraseña.Location = new System.Drawing.Point(76, 264);
            this.labelNuevaContraseña.Name = "labelNuevaContraseña";
            this.labelNuevaContraseña.Size = new System.Drawing.Size(141, 20);
            this.labelNuevaContraseña.TabIndex = 49;
            this.labelNuevaContraseña.Text = "Nueva Contraseña";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAceptar.Location = new System.Drawing.Point(156, 428);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(120, 40);
            this.btnAceptar.TabIndex = 46;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Silver;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCancelar.Location = new System.Drawing.Point(21, 428);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 40);
            this.btnCancelar.TabIndex = 41;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(21, 241);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(255, 20);
            this.txtBoxEmail.TabIndex = 45;
            // 
            // txtBoxApellido
            // 
            this.txtBoxApellido.Location = new System.Drawing.Point(21, 153);
            this.txtBoxApellido.Name = "txtBoxApellido";
            this.txtBoxApellido.Size = new System.Drawing.Size(255, 20);
            this.txtBoxApellido.TabIndex = 44;
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(21, 107);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(255, 20);
            this.txtBoxNombre.TabIndex = 43;
            // 
            // txtBoxNombreUsuario
            // 
            this.txtBoxNombreUsuario.Location = new System.Drawing.Point(21, 61);
            this.txtBoxNombreUsuario.Name = "txtBoxNombreUsuario";
            this.txtBoxNombreUsuario.Size = new System.Drawing.Size(255, 20);
            this.txtBoxNombreUsuario.TabIndex = 42;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelEmail.Location = new System.Drawing.Point(122, 218);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(48, 20);
            this.labelEmail.TabIndex = 41;
            this.labelEmail.Text = "Email";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellido.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelApellido.Location = new System.Drawing.Point(115, 130);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(65, 20);
            this.labelApellido.TabIndex = 41;
            this.labelApellido.Text = "Apellido";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelNombre.Location = new System.Drawing.Point(115, 84);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(65, 20);
            this.labelNombre.TabIndex = 41;
            this.labelNombre.Text = "Nombre";
            // 
            // labelNombreUsuario
            // 
            this.labelNombreUsuario.AutoSize = true;
            this.labelNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreUsuario.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelNombreUsuario.Location = new System.Drawing.Point(76, 38);
            this.labelNombreUsuario.Name = "labelNombreUsuario";
            this.labelNombreUsuario.Size = new System.Drawing.Size(146, 20);
            this.labelNombreUsuario.TabIndex = 41;
            this.labelNombreUsuario.Text = "Nombre de Usuario";
            // 
            // labelEditarPerfil
            // 
            this.labelEditarPerfil.AutoSize = true;
            this.labelEditarPerfil.BackColor = System.Drawing.Color.LightGray;
            this.labelEditarPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditarPerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.labelEditarPerfil.Location = new System.Drawing.Point(93, 4);
            this.labelEditarPerfil.Name = "labelEditarPerfil";
            this.labelEditarPerfil.Size = new System.Drawing.Size(104, 24);
            this.labelEditarPerfil.TabIndex = 40;
            this.labelEditarPerfil.Text = "Editar Perfil";
            // 
            // panelInformacionDelPerfil
            // 
            this.panelInformacionDelPerfil.Controls.Add(this.panel2);
            this.panelInformacionDelPerfil.Controls.Add(this.linkLblEditar);
            this.panelInformacionDelPerfil.Controls.Add(this.lblInputEmail);
            this.panelInformacionDelPerfil.Controls.Add(this.lblEmail);
            this.panelInformacionDelPerfil.Controls.Add(this.lblInputCargo);
            this.panelInformacionDelPerfil.Controls.Add(this.lblCargo);
            this.panelInformacionDelPerfil.Controls.Add(this.lblInputApellido);
            this.panelInformacionDelPerfil.Controls.Add(this.lblApellido);
            this.panelInformacionDelPerfil.Controls.Add(this.lblinputNombre);
            this.panelInformacionDelPerfil.Controls.Add(this.lblNombre);
            this.panelInformacionDelPerfil.Controls.Add(this.lblInputnombreUsuario);
            this.panelInformacionDelPerfil.Controls.Add(this.lblNombreUsuario);
            this.panelInformacionDelPerfil.Controls.Add(this.button1);
            this.panelInformacionDelPerfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInformacionDelPerfil.Location = new System.Drawing.Point(0, 59);
            this.panelInformacionDelPerfil.Name = "panelInformacionDelPerfil";
            this.panelInformacionDelPerfil.Size = new System.Drawing.Size(589, 493);
            this.panelInformacionDelPerfil.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.btnCrearNuevoUsuario);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.btnCrearNuevoMedioDePago);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnGenerar);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 393);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(589, 100);
            this.panel2.TabIndex = 41;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(180, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 20);
            this.label14.TabIndex = 45;
            this.label14.Text = "Nuevo Usuario";
            // 
            // btnCrearNuevoUsuario
            // 
            this.btnCrearNuevoUsuario.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnCrearNuevoUsuario.FlatAppearance.BorderSize = 0;
            this.btnCrearNuevoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearNuevoUsuario.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCrearNuevoUsuario.Location = new System.Drawing.Point(182, 52);
            this.btnCrearNuevoUsuario.Name = "btnCrearNuevoUsuario";
            this.btnCrearNuevoUsuario.Size = new System.Drawing.Size(111, 36);
            this.btnCrearNuevoUsuario.TabIndex = 43;
            this.btnCrearNuevoUsuario.Text = "CREAR";
            this.btnCrearNuevoUsuario.UseVisualStyleBackColor = false;
            this.btnCrearNuevoUsuario.Click += new System.EventHandler(this.btnCrearNuevoUsuario_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(316, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 20);
            this.label12.TabIndex = 42;
            this.label12.Text = "Medios de Pago";
            // 
            // btnCrearNuevoMedioDePago
            // 
            this.btnCrearNuevoMedioDePago.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnCrearNuevoMedioDePago.FlatAppearance.BorderSize = 0;
            this.btnCrearNuevoMedioDePago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearNuevoMedioDePago.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCrearNuevoMedioDePago.Location = new System.Drawing.Point(320, 52);
            this.btnCrearNuevoMedioDePago.Name = "btnCrearNuevoMedioDePago";
            this.btnCrearNuevoMedioDePago.Size = new System.Drawing.Size(111, 36);
            this.btnCrearNuevoMedioDePago.TabIndex = 40;
            this.btnCrearNuevoMedioDePago.Text = "CREAR";
            this.btnCrearNuevoMedioDePago.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(33, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Respaldo";
            // 
            // linkLblEditar
            // 
            this.linkLblEditar.AutoSize = true;
            this.linkLblEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblEditar.LinkColor = System.Drawing.Color.Turquoise;
            this.linkLblEditar.Location = new System.Drawing.Point(285, 347);
            this.linkLblEditar.Name = "linkLblEditar";
            this.linkLblEditar.Size = new System.Drawing.Size(46, 18);
            this.linkLblEditar.TabIndex = 40;
            this.linkLblEditar.TabStop = true;
            this.linkLblEditar.Text = "Editar";
            this.linkLblEditar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblEditar_LinkClicked);
            // 
            // lblInputEmail
            // 
            this.lblInputEmail.AutoSize = true;
            this.lblInputEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputEmail.ForeColor = System.Drawing.Color.White;
            this.lblInputEmail.Location = new System.Drawing.Point(285, 315);
            this.lblInputEmail.Name = "lblInputEmail";
            this.lblInputEmail.Size = new System.Drawing.Size(48, 20);
            this.lblInputEmail.TabIndex = 38;
            this.lblInputEmail.Text = "Email";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(284, 282);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 24);
            this.lblEmail.TabIndex = 37;
            this.lblEmail.Text = "Email";
            // 
            // lblInputCargo
            // 
            this.lblInputCargo.AutoSize = true;
            this.lblInputCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputCargo.ForeColor = System.Drawing.Color.White;
            this.lblInputCargo.Location = new System.Drawing.Point(285, 250);
            this.lblInputCargo.Name = "lblInputCargo";
            this.lblInputCargo.Size = new System.Drawing.Size(52, 20);
            this.lblInputCargo.TabIndex = 36;
            this.lblInputCargo.Text = "Cargo";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.ForeColor = System.Drawing.Color.White;
            this.lblCargo.Location = new System.Drawing.Point(284, 217);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(61, 24);
            this.lblCargo.TabIndex = 35;
            this.lblCargo.Text = "Cargo";
            // 
            // lblInputApellido
            // 
            this.lblInputApellido.AutoSize = true;
            this.lblInputApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputApellido.ForeColor = System.Drawing.Color.White;
            this.lblInputApellido.Location = new System.Drawing.Point(285, 186);
            this.lblInputApellido.Name = "lblInputApellido";
            this.lblInputApellido.Size = new System.Drawing.Size(65, 20);
            this.lblInputApellido.TabIndex = 34;
            this.lblInputApellido.Text = "Apellido";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.White;
            this.lblApellido.Location = new System.Drawing.Point(284, 153);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(79, 24);
            this.lblApellido.TabIndex = 33;
            this.lblApellido.Text = "Apellido";
            // 
            // lblinputNombre
            // 
            this.lblinputNombre.AutoSize = true;
            this.lblinputNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinputNombre.ForeColor = System.Drawing.Color.White;
            this.lblinputNombre.Location = new System.Drawing.Point(285, 121);
            this.lblinputNombre.Name = "lblinputNombre";
            this.lblinputNombre.Size = new System.Drawing.Size(65, 20);
            this.lblinputNombre.TabIndex = 32;
            this.lblinputNombre.Text = "Nombre";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(284, 88);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 24);
            this.lblNombre.TabIndex = 31;
            this.lblNombre.Text = "Nombre";
            // 
            // lblInputnombreUsuario
            // 
            this.lblInputnombreUsuario.AutoSize = true;
            this.lblInputnombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputnombreUsuario.ForeColor = System.Drawing.Color.White;
            this.lblInputnombreUsuario.Location = new System.Drawing.Point(285, 56);
            this.lblInputnombreUsuario.Name = "lblInputnombreUsuario";
            this.lblInputnombreUsuario.Size = new System.Drawing.Size(146, 20);
            this.lblInputnombreUsuario.TabIndex = 30;
            this.lblInputnombreUsuario.Text = "Nombre de Usuario";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.lblNombreUsuario.Location = new System.Drawing.Point(284, 23);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(175, 24);
            this.lblNombreUsuario.TabIndex = 8;
            this.lblNombreUsuario.Text = "Nombre de Usuario";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::COMPLETE_FLAT_UI.Properties.Resources.icono_cliente;
            this.button1.Location = new System.Drawing.Point(3, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 206);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(892, 552);
            this.Controls.Add(this.panelInformacionDelPerfil);
            this.Controls.Add(this.panelEditarPerfil);
            this.Controls.Add(this.panel1);
            this.Name = "FormUsuario";
            this.Text = "FormUsuario";
            this.Load += new System.EventHandler(this.FormUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelEditarPerfil.ResumeLayout(false);
            this.panelEditarPerfil.PerformLayout();
            this.panelInformacionDelPerfil.ResumeLayout(false);
            this.panelInformacionDelPerfil.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelEditarPerfil;
        private System.Windows.Forms.Panel panelInformacionDelPerfil;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelEditarPerfil;
        private System.Windows.Forms.LinkLabel linkLblEditar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblInputEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblInputCargo;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblInputApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblinputNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblInputnombreUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.TextBox txtBoxContraseñaActual;
        private System.Windows.Forms.TextBox txtBoxConfirmarContraseña;
        private System.Windows.Forms.TextBox txtBoxNuevaContraseña;
        private System.Windows.Forms.Label labelContraseñaActual;
        private System.Windows.Forms.Label labelConfirmarContraseña;
        private System.Windows.Forms.Label labelNuevaContraseña;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxApellido;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.TextBox txtBoxNombreUsuario;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelNombreUsuario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnCrearNuevoUsuario;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCrearNuevoMedioDePago;
        private System.Windows.Forms.ComboBox cmbBoxCargoPersonal;
        private System.Windows.Forms.Label label4;
    }
}