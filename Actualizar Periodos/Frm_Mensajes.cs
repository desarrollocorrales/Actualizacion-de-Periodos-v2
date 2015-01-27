using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Actualizar_Periodos
{
    public partial class Frm_Mensajes : Form
    {
        public Frm_Mensajes(string Titulo, string Mensaje)
        {
            InitializeComponent();

            this.Text = Titulo;
            this.lblMsg.Text = Mensaje;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
