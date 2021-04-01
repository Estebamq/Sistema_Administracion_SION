
namespace COMPLETE_FLAT_UI.Presentaciones
{
    partial class FormPlanillas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.InstructorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AlumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteClaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewInstructores = new System.Windows.Forms.DataGridView();
            this.dateTimePickerPlanillas = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarClasesInstructor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerarPlanillaPorFecha = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.InstructorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlumnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteClaseBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInstructores)).BeginInit();
            this.SuspendLayout();
            // 
            // InstructorBindingSource
            // 
            this.InstructorBindingSource.DataSource = typeof(Logic.Instructor);
            // 
            // AlumnoBindingSource
            // 
            this.AlumnoBindingSource.DataSource = typeof(Logic.Alumno);
            // 
            // ClaseBindingSource
            // 
            this.ClaseBindingSource.DataSource = typeof(Logic.Clase);
            // 
            // ReporteClaseBindingSource
            // 
            this.ReporteClaseBindingSource.DataSource = typeof(Logic.Domain.ReporteClase);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1168, 55);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "PLANILLAS";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Image = global::COMPLETE_FLAT_UI.Properties.Resources.Close;
            this.BtnCerrar.Location = new System.Drawing.Point(12, 13);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(43, 43);
            this.BtnCerrar.TabIndex = 11;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1168, 492);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.dataGridViewInstructores);
            this.panel3.Controls.Add(this.dateTimePickerPlanillas);
            this.panel3.Controls.Add(this.btnBuscarClasesInstructor);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnGenerarPlanillaPorFecha);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(803, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(365, 492);
            this.panel3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Elegir instructor";
            // 
            // dataGridViewInstructores
            // 
            this.dataGridViewInstructores.AllowUserToAddRows = false;
            this.dataGridViewInstructores.AllowUserToDeleteRows = false;
            this.dataGridViewInstructores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewInstructores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.dataGridViewInstructores.Location = new System.Drawing.Point(16, 89);
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
            this.dataGridViewInstructores.Size = new System.Drawing.Size(328, 231);
            this.dataGridViewInstructores.TabIndex = 41;
            this.dataGridViewInstructores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInstructores_CellClick_1);
            this.dataGridViewInstructores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInstructores_CellDoubleClick_1);
            // 
            // dateTimePickerPlanillas
            // 
            this.dateTimePickerPlanillas.CalendarForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dateTimePickerPlanillas.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.dateTimePickerPlanillas.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerPlanillas.Location = new System.Drawing.Point(72, 422);
            this.dateTimePickerPlanillas.Name = "dateTimePickerPlanillas";
            this.dateTimePickerPlanillas.Size = new System.Drawing.Size(224, 20);
            this.dateTimePickerPlanillas.TabIndex = 40;
            // 
            // btnBuscarClasesInstructor
            // 
            this.btnBuscarClasesInstructor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarClasesInstructor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnBuscarClasesInstructor.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBuscarClasesInstructor.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnBuscarClasesInstructor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnBuscarClasesInstructor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnBuscarClasesInstructor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarClasesInstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarClasesInstructor.ForeColor = System.Drawing.Color.Silver;
            this.btnBuscarClasesInstructor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarClasesInstructor.Location = new System.Drawing.Point(72, 372);
            this.btnBuscarClasesInstructor.Name = "btnBuscarClasesInstructor";
            this.btnBuscarClasesInstructor.Size = new System.Drawing.Size(224, 30);
            this.btnBuscarClasesInstructor.TabIndex = 31;
            this.btnBuscarClasesInstructor.Text = "GENERAR PLANILLA PARA MAÑANA";
            this.btnBuscarClasesInstructor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarClasesInstructor.UseVisualStyleBackColor = false;
            this.btnBuscarClasesInstructor.Click += new System.EventHandler(this.btnBuscarClasesInstructor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(117, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "INSTRUCTORES";
            // 
            // btnGenerarPlanillaPorFecha
            // 
            this.btnGenerarPlanillaPorFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerarPlanillaPorFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnGenerarPlanillaPorFecha.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGenerarPlanillaPorFecha.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnGenerarPlanillaPorFecha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnGenerarPlanillaPorFecha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnGenerarPlanillaPorFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarPlanillaPorFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarPlanillaPorFecha.ForeColor = System.Drawing.Color.Silver;
            this.btnGenerarPlanillaPorFecha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarPlanillaPorFecha.Location = new System.Drawing.Point(72, 458);
            this.btnGenerarPlanillaPorFecha.Name = "btnGenerarPlanillaPorFecha";
            this.btnGenerarPlanillaPorFecha.Size = new System.Drawing.Size(224, 30);
            this.btnGenerarPlanillaPorFecha.TabIndex = 30;
            this.btnGenerarPlanillaPorFecha.Text = "GENERAR PLANILLA POR FECHA";
            this.btnGenerarPlanillaPorFecha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerarPlanillaPorFecha.UseVisualStyleBackColor = false;
            this.btnGenerarPlanillaPorFecha.Click += new System.EventHandler(this.btnGenerarPlanillaPorFecha_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Left;
            reportDataSource1.Name = "Instructor";
            reportDataSource1.Value = this.InstructorBindingSource;
            reportDataSource2.Name = "Alumno";
            reportDataSource2.Value = this.AlumnoBindingSource;
            reportDataSource3.Name = "Clases";
            reportDataSource3.Value = this.ClaseBindingSource;
            reportDataSource4.Name = "Reporte_Clase";
            reportDataSource4.Value = this.ReporteClaseBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "COMPLETE_FLAT_UI.Presentaciones.reportes.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(797, 492);
            this.reportViewer1.TabIndex = 0;
            // 
            // FormPlanillas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1168, 547);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormPlanillas";
            this.Text = "FormPlanillas";
            this.Load += new System.EventHandler(this.FormPlanillas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InstructorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlumnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteClaseBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInstructores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCerrar;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource InstructorBindingSource;
        private System.Windows.Forms.BindingSource AlumnoBindingSource;
        private System.Windows.Forms.BindingSource ClaseBindingSource;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBuscarClasesInstructor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerarPlanillaPorFecha;
        private System.Windows.Forms.DateTimePicker dateTimePickerPlanillas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewInstructores;
        private System.Windows.Forms.BindingSource ReporteClaseBindingSource;
    }
}