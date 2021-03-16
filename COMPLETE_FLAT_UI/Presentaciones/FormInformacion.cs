﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPLETE_FLAT_UI.Presentaciones
{
    public partial class FormInformacion : Form
    {
        public FormInformacion(string mensaje)
        {
            InitializeComponent();
            lblMensaje.Text = mensaje;
        }

        private void InformatioView_Load(object sender, EventArgs e)
        {
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
