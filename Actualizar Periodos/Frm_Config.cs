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
    public partial class Frm_Config : Form
    {
        public Frm_Config()
        {
            InitializeComponent();
        }

        private void Frm_Config_Load(object sender, EventArgs e)
        {
            Iniciar();
        }
        private void Iniciar()
        {
            txbServidor.Text = Properties.Settings.Default.Servidor;
            txbBaseDeDatos.Text = Properties.Settings.Default.BaseDeDatos;
            txbUsuario.Text = Properties.Settings.Default.Usuario;
            txbContrasenia.Text = Properties.Settings.Default.Password;
            nudPuerto.Value = Properties.Settings.Default.Puerto;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        private void Guardar()
        {
            Properties.Settings.Default.Servidor = txbServidor.Text;
            Properties.Settings.Default.BaseDeDatos = txbBaseDeDatos.Text;
            Properties.Settings.Default.Usuario = txbUsuario.Text;
            Properties.Settings.Default.Password = txbContrasenia.Text;
            Properties.Settings.Default.Puerto = Convert.ToInt32(nudPuerto.Value);

            Properties.Settings.Default.Save();

            new Frm_Mensajes("Guardar", "Los datos fueron guardados con exito...").ShowDialog();
            //MessageBox.Show("Los datos fueron guardados con exito...", "Guardar", 
            //                 MessageBoxButtons.OK , MessageBoxIcon.Information);
            
            this.Close();
        }
    }
}
