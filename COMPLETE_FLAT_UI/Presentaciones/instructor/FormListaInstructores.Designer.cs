namespace COMPLETE_FLAT_UI
{
    partial class FormListaInstructores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaInstructores));
            this.btnNuevoInstructor = new System.Windows.Forms.Button();
            this.btnBajaInstructor = new System.Windows.Forms.Button();
            this.btnEditarInstructor = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.dataGridViewInstructores = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBuscar = new System.Windows.Forms.Panel();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtSearchInstructorDni = new System.Windows.Forms.TextBox();
            this.txtSearchInstructorId = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtSearchInstructorNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtSearchInstructorApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblInstructor = new System.Windows.Forms.Label();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInstructores)).BeginInit();
            this.panelBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNuevoInstructor
            // 
            this.btnNuevoInstructor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoInstructor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnNuevoInstructor.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnNuevoInstructor.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnNuevoInstructor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnNuevoInstructor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnNuevoInstructor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoInstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoInstructor.ForeColor = System.Drawing.Color.Silver;
            this.btnNuevoInstructor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoInstructor.Location = new System.Drawing.Point(756, 61);
            this.btnNuevoInstructor.Name = "btnNuevoInstructor";
            this.btnNuevoInstructor.Size = new System.Drawing.Size(100, 30);
            this.btnNuevoInstructor.TabIndex = 1;
            this.btnNuevoInstructor.Text = "Nuevo";
            this.btnNuevoInstructor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoInstructor.UseVisualStyleBackColor = false;
            this.btnNuevoInstructor.Click += new System.EventHandler(this.btnNuevoInstructor_Click);
            // 
            // btnBajaInstructor
            // 
            this.btnBajaInstructor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBajaInstructor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnBajaInstructor.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBajaInstructor.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnBajaInstructor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnBajaInstructor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnBajaInstructor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBajaInstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajaInstructor.ForeColor = System.Drawing.Color.Silver;
            this.btnBajaInstructor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBajaInstructor.Location = new System.Drawing.Point(756, 133);
            this.btnBajaInstructor.Name = "btnBajaInstructor";
            this.btnBajaInstructor.Size = new System.Drawing.Size(100, 30);
            this.btnBajaInstructor.TabIndex = 3;
            this.btnBajaInstructor.Text = "Baja";
            this.btnBajaInstructor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBajaInstructor.UseVisualStyleBackColor = false;
            this.btnBajaInstructor.Click += new System.EventHandler(this.btnBajaInstructor_Click);
            // 
            // btnEditarInstructor
            // 
            this.btnEditarInstructor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarInstructor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnEditarInstructor.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEditarInstructor.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnEditarInstructor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnEditarInstructor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnEditarInstructor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarInstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarInstructor.ForeColor = System.Drawing.Color.Silver;
            this.btnEditarInstructor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarInstructor.Location = new System.Drawing.Point(756, 97);
            this.btnEditarInstructor.Name = "btnEditarInstructor";
            this.btnEditarInstructor.Size = new System.Drawing.Size(100, 30);
            this.btnEditarInstructor.TabIndex = 2;
            this.btnEditarInstructor.Text = "Editar";
            this.btnEditarInstructor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarInstructor.UseVisualStyleBackColor = false;
            this.btnEditarInstructor.Click += new System.EventHandler(this.btnEditarInstructor_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Image = global::COMPLETE_FLAT_UI.Properties.Resources.Close;
            this.BtnCerrar.Location = new System.Drawing.Point(0, 2);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(43, 43);
            this.BtnCerrar.TabIndex = 8;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // dataGridViewInstructores
            // 
            this.dataGridViewInstructores.AllowUserToAddRows = false;
            this.dataGridViewInstructores.AllowUserToDeleteRows = false;
            this.dataGridViewInstructores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewInstructores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewInstructores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.dataGridViewInstructores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewInstructores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewInstructores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewInstructores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewInstructores.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewInstructores.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewInstructores.EnableHeadersVisualStyles = false;
            this.dataGridViewInstructores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.dataGridViewInstructores.Location = new System.Drawing.Point(12, 62);
            this.dataGridViewInstructores.Name = "dataGridViewInstructores";
            this.dataGridViewInstructores.ReadOnly = true;
            this.dataGridViewInstructores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewInstructores.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewInstructores.Size = new System.Drawing.Size(738, 288);
            this.dataGridViewInstructores.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lista de Instructores";
            // 
            // panelBuscar
            // 
            this.panelBuscar.Controls.Add(this.lblBusqueda);
            this.panelBuscar.Controls.Add(this.lblDni);
            this.panelBuscar.Controls.Add(this.txtSearchInstructorDni);
            this.panelBuscar.Controls.Add(this.txtSearchInstructorId);
            this.panelBuscar.Controls.Add(this.lblApellido);
            this.panelBuscar.Controls.Add(this.txtSearchInstructorNombre);
            this.panelBuscar.Controls.Add(this.lblNombre);
            this.panelBuscar.Controls.Add(this.txtSearchInstructorApellido);
            this.panelBuscar.Controls.Add(this.label3);
            this.panelBuscar.Controls.Add(this.lblInstructor);
            this.panelBuscar.Controls.Add(this.shapeContainer2);
            this.panelBuscar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBuscar.Location = new System.Drawing.Point(0, 358);
            this.panelBuscar.Name = "panelBuscar";
            this.panelBuscar.Size = new System.Drawing.Size(868, 114);
            this.panelBuscar.TabIndex = 21;
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.ForeColor = System.Drawing.Color.White;
            this.lblBusqueda.Location = new System.Drawing.Point(387, 17);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(82, 20);
            this.lblBusqueda.TabIndex = 8;
            this.lblBusqueda.Text = "Busqueda";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.ForeColor = System.Drawing.Color.White;
            this.lblDni.Location = new System.Drawing.Point(639, 52);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(37, 20);
            this.lblDni.TabIndex = 19;
            this.lblDni.Text = "DNI";
            // 
            // txtSearchInstructorDni
            // 
            this.txtSearchInstructorDni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.txtSearchInstructorDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchInstructorDni.ForeColor = System.Drawing.SystemColors.Window;
            this.txtSearchInstructorDni.Location = new System.Drawing.Point(692, 51);
            this.txtSearchInstructorDni.Multiline = true;
            this.txtSearchInstructorDni.Name = "txtSearchInstructorDni";
            this.txtSearchInstructorDni.Size = new System.Drawing.Size(132, 23);
            this.txtSearchInstructorDni.TabIndex = 7;
            this.txtSearchInstructorDni.TextChanged += new System.EventHandler(this.txtSearchInstructorDni_TextChanged);
            // 
            // txtSearchInstructorId
            // 
            this.txtSearchInstructorId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.txtSearchInstructorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchInstructorId.ForeColor = System.Drawing.SystemColors.Window;
            this.txtSearchInstructorId.Location = new System.Drawing.Point(71, 51);
            this.txtSearchInstructorId.Multiline = true;
            this.txtSearchInstructorId.Name = "txtSearchInstructorId";
            this.txtSearchInstructorId.Size = new System.Drawing.Size(54, 23);
            this.txtSearchInstructorId.TabIndex = 4;
            this.txtSearchInstructorId.TextChanged += new System.EventHandler(this.txtSearchInstructorId_TextChanged);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.White;
            this.lblApellido.Location = new System.Drawing.Point(376, 52);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(88, 20);
            this.lblApellido.TabIndex = 17;
            this.lblApellido.Text = "APELLIDO";
            // 
            // txtSearchInstructorNombre
            // 
            this.txtSearchInstructorNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.txtSearchInstructorNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchInstructorNombre.ForeColor = System.Drawing.SystemColors.Window;
            this.txtSearchInstructorNombre.Location = new System.Drawing.Point(225, 51);
            this.txtSearchInstructorNombre.Multiline = true;
            this.txtSearchInstructorNombre.Name = "txtSearchInstructorNombre";
            this.txtSearchInstructorNombre.Size = new System.Drawing.Size(132, 23);
            this.txtSearchInstructorNombre.TabIndex = 5;
            this.txtSearchInstructorNombre.TextChanged += new System.EventHandler(this.txtSearchInstructorNombre_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(140, 52);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 20);
            this.lblNombre.TabIndex = 16;
            this.lblNombre.Text = "NOMBRE";
            // 
            // txtSearchInstructorApellido
            // 
            this.txtSearchInstructorApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.txtSearchInstructorApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchInstructorApellido.ForeColor = System.Drawing.SystemColors.Window;
            this.txtSearchInstructorApellido.Location = new System.Drawing.Point(469, 51);
            this.txtSearchInstructorApellido.Multiline = true;
            this.txtSearchInstructorApellido.Name = "txtSearchInstructorApellido";
            this.txtSearchInstructorApellido.Size = new System.Drawing.Size(132, 23);
            this.txtSearchInstructorApellido.TabIndex = 6;
            this.txtSearchInstructorApellido.TextChanged += new System.EventHandler(this.txtSearchInstructorApellido_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(259, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 15;
            // 
            // lblInstructor
            // 
            this.lblInstructor.AutoSize = true;
            this.lblInstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructor.ForeColor = System.Drawing.Color.White;
            this.lblInstructor.Location = new System.Drawing.Point(39, 52);
            this.lblInstructor.Name = "lblInstructor";
            this.lblInstructor.Size = new System.Drawing.Size(26, 20);
            this.lblInstructor.TabIndex = 14;
            this.lblInstructor.Text = "ID";
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer2.Size = new System.Drawing.Size(868, 114);
            this.shapeContainer2.TabIndex = 0;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.SystemColors.Window;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 17;
            this.lineShape4.X2 = 17;
            this.lineShape4.Y1 = 27;
            this.lineShape4.Y2 = 94;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.SystemColors.Window;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 846;
            this.lineShape3.X2 = 846;
            this.lineShape3.Y1 = 27;
            this.lineShape3.Y2 = 94;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.SystemColors.Window;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 17;
            this.lineShape2.X2 = 846;
            this.lineShape2.Y1 = 94;
            this.lineShape2.Y2 = 94;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.Window;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 18;
            this.lineShape1.X2 = 845;
            this.lineShape1.Y1 = 27;
            this.lineShape1.Y2 = 27;
            // 
            // FormListaInstructores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(868, 472);
            this.Controls.Add(this.panelBuscar);
            this.Controls.Add(this.btnNuevoInstructor);
            this.Controls.Add(this.btnBajaInstructor);
            this.Controls.Add(this.btnEditarInstructor);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.dataGridViewInstructores);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormListaInstructores";
            this.Text = "FormListarInstructores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInstructores)).EndInit();
            this.panelBuscar.ResumeLayout(false);
            this.panelBuscar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoInstructor;
        private System.Windows.Forms.Button btnBajaInstructor;
        private System.Windows.Forms.Button btnEditarInstructor;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.DataGridView dataGridViewInstructores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelBuscar;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtSearchInstructorDni;
        private System.Windows.Forms.TextBox txtSearchInstructorId;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtSearchInstructorNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtSearchInstructorApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblInstructor;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}