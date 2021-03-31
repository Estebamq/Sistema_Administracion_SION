
namespace COMPLETE_FLAT_UI.Presentaciones.UsuariosPrograma
{
    partial class FormNuevoUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.cmbBoxCargoPersonal = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxContraseña = new System.Windows.Forms.TextBox();
            this.labelContraseñaActual = new System.Windows.Forms.Label();
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
            this.txtBoxConfirmarContraseña = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.dataGridViewUsuariosActivos = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuariosActivos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(384, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "NUEVO USUARIO";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Image = global::COMPLETE_FLAT_UI.Properties.Resources.Close;
            this.BtnCerrar.Location = new System.Drawing.Point(933, 2);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(43, 43);
            this.BtnCerrar.TabIndex = 11;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.BarraTitulo.Controls.Add(this.BtnCerrar);
            this.BarraTitulo.Controls.Add(this.label1);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(984, 49);
            this.BarraTitulo.TabIndex = 12;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // cmbBoxCargoPersonal
            // 
            this.cmbBoxCargoPersonal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxCargoPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBoxCargoPersonal.FormattingEnabled = true;
            this.cmbBoxCargoPersonal.Location = new System.Drawing.Point(28, 244);
            this.cmbBoxCargoPersonal.Name = "cmbBoxCargoPersonal";
            this.cmbBoxCargoPersonal.Size = new System.Drawing.Size(255, 21);
            this.cmbBoxCargoPersonal.TabIndex = 73;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Honeydew;
            this.label4.Location = new System.Drawing.Point(126, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 72;
            this.label4.Text = "Cargo";
            // 
            // txtBoxContraseña
            // 
            this.txtBoxContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxContraseña.Location = new System.Drawing.Point(28, 332);
            this.txtBoxContraseña.Name = "txtBoxContraseña";
            this.txtBoxContraseña.PasswordChar = '●';
            this.txtBoxContraseña.Size = new System.Drawing.Size(255, 21);
            this.txtBoxContraseña.TabIndex = 71;
            // 
            // labelContraseñaActual
            // 
            this.labelContraseñaActual.AutoSize = true;
            this.labelContraseñaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContraseñaActual.ForeColor = System.Drawing.Color.Honeydew;
            this.labelContraseñaActual.Location = new System.Drawing.Point(108, 309);
            this.labelContraseñaActual.Name = "labelContraseñaActual";
            this.labelContraseñaActual.Size = new System.Drawing.Size(92, 20);
            this.labelContraseñaActual.TabIndex = 66;
            this.labelContraseñaActual.Text = "Contraseña";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAceptar.Location = new System.Drawing.Point(163, 424);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(120, 40);
            this.btnAceptar.TabIndex = 65;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Silver;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCancelar.Location = new System.Drawing.Point(28, 424);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 40);
            this.btnCancelar.TabIndex = 59;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(28, 288);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(255, 20);
            this.txtBoxEmail.TabIndex = 64;
            // 
            // txtBoxApellido
            // 
            this.txtBoxApellido.Location = new System.Drawing.Point(28, 200);
            this.txtBoxApellido.Name = "txtBoxApellido";
            this.txtBoxApellido.Size = new System.Drawing.Size(255, 20);
            this.txtBoxApellido.TabIndex = 63;
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(28, 154);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(255, 20);
            this.txtBoxNombre.TabIndex = 62;
            // 
            // txtBoxNombreUsuario
            // 
            this.txtBoxNombreUsuario.Location = new System.Drawing.Point(28, 108);
            this.txtBoxNombreUsuario.Name = "txtBoxNombreUsuario";
            this.txtBoxNombreUsuario.Size = new System.Drawing.Size(255, 20);
            this.txtBoxNombreUsuario.TabIndex = 61;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.Honeydew;
            this.labelEmail.Location = new System.Drawing.Point(129, 265);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(48, 20);
            this.labelEmail.TabIndex = 58;
            this.labelEmail.Text = "Email";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellido.ForeColor = System.Drawing.Color.Honeydew;
            this.labelApellido.Location = new System.Drawing.Point(122, 177);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(65, 20);
            this.labelApellido.TabIndex = 57;
            this.labelApellido.Text = "Apellido";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.Honeydew;
            this.labelNombre.Location = new System.Drawing.Point(122, 131);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(65, 20);
            this.labelNombre.TabIndex = 60;
            this.labelNombre.Text = "Nombre";
            // 
            // labelNombreUsuario
            // 
            this.labelNombreUsuario.AutoSize = true;
            this.labelNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreUsuario.ForeColor = System.Drawing.Color.Honeydew;
            this.labelNombreUsuario.Location = new System.Drawing.Point(83, 85);
            this.labelNombreUsuario.Name = "labelNombreUsuario";
            this.labelNombreUsuario.Size = new System.Drawing.Size(146, 20);
            this.labelNombreUsuario.TabIndex = 56;
            this.labelNombreUsuario.Text = "Nombre de Usuario";
            // 
            // txtBoxConfirmarContraseña
            // 
            this.txtBoxConfirmarContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxConfirmarContraseña.Location = new System.Drawing.Point(28, 378);
            this.txtBoxConfirmarContraseña.Name = "txtBoxConfirmarContraseña";
            this.txtBoxConfirmarContraseña.PasswordChar = '●';
            this.txtBoxConfirmarContraseña.Size = new System.Drawing.Size(255, 21);
            this.txtBoxConfirmarContraseña.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Honeydew;
            this.label2.Location = new System.Drawing.Point(69, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 74;
            this.label2.Text = "Confirmar Contraseña ";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(984, 508);
            this.shapeContainer1.TabIndex = 76;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 310;
            this.lineShape1.X2 = 310;
            this.lineShape1.Y1 = 75;
            this.lineShape1.Y2 = 468;
            // 
            // dataGridViewUsuariosActivos
            // 
            this.dataGridViewUsuariosActivos.AllowUserToAddRows = false;
            this.dataGridViewUsuariosActivos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewUsuariosActivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewUsuariosActivos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.dataGridViewUsuariosActivos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewUsuariosActivos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewUsuariosActivos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUsuariosActivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewUsuariosActivos.ColumnHeadersHeight = 30;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewUsuariosActivos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewUsuariosActivos.EnableHeadersVisualStyles = false;
            this.dataGridViewUsuariosActivos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.dataGridViewUsuariosActivos.Location = new System.Drawing.Point(334, 108);
            this.dataGridViewUsuariosActivos.Name = "dataGridViewUsuariosActivos";
            this.dataGridViewUsuariosActivos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUsuariosActivos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewUsuariosActivos.Size = new System.Drawing.Size(625, 290);
            this.dataGridViewUsuariosActivos.TabIndex = 78;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEliminar.Location = new System.Drawing.Point(839, 424);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 40);
            this.btnEliminar.TabIndex = 79;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Honeydew;
            this.label3.Location = new System.Drawing.Point(524, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 20);
            this.label3.TabIndex = 80;
            this.label3.Text = "LISTA DE USUARIOS ACTIVOS";
            // 
            // FormNuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(984, 508);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dataGridViewUsuariosActivos);
            this.Controls.Add(this.txtBoxConfirmarContraseña);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBoxCargoPersonal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxContraseña);
            this.Controls.Add(this.labelContraseñaActual);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.txtBoxApellido);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.txtBoxNombreUsuario);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelNombreUsuario);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNuevoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNuevoUsuario";
            this.Load += new System.EventHandler(this.FormNuevoUsuario_Load);
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuariosActivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.ComboBox cmbBoxCargoPersonal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxContraseña;
        private System.Windows.Forms.Label labelContraseñaActual;
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
        private System.Windows.Forms.TextBox txtBoxConfirmarContraseña;
        private System.Windows.Forms.Label label2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.DataGridView dataGridViewUsuariosActivos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label3;
    }
}