using System;
using System.Windows.Forms;
using Actualizar_Periodos.DAL;

namespace Actualizar_Periodos
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            new Frm_Config().ShowDialog();
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            lblPeriodoCompras.Text = string.Empty;
            lblPeriodoCxP.Text = string.Empty;

            lblPeriodoCxC.Text = string.Empty;
            lblPeriodoInventarios.Text = string.Empty;
            lblPeriodoVentas.Text = string.Empty; 
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarPeriodos();
        }

        private void ActualizarPeriodos()
        {
            try
            {
                FirebirdDAL DAL = new FirebirdDAL();

                DateTime FechaHoy = DAL.obtenerFechaDelServidor();
                DateTime FechaDosDiasAtras = FechaHoy.AddDays(-2);

                DAL.ActualizarPeridoInicio(FechaDosDiasAtras, "Compras");
                DAL.ActualizarPeridoFin(FechaHoy, "Compras");

                DAL.ActualizarPeridoInicio(FechaDosDiasAtras, "Cuentas por pagar");
                DAL.ActualizarPeridoFin(FechaHoy, "Cuentas por pagar");

                DAL.ActualizarPeridos(FechaHoy, "Cuentas por cobrar");
                DAL.ActualizarPeridos(FechaHoy, "Inventarios");
                DAL.ActualizarPeridos(FechaHoy, "Ventas");

                ActualizarEtiquetas(FechaHoy);

                new Frm_Mensajes("Actualizar", "Los periodos se actualizaron con exito!!!").ShowDialog();
            }
            catch (Exception ex)
            {
                string ExType = ex.GetType().ToString();
                string ExMsg = ex.Message;

                new Frm_Mensajes(ExType, ExMsg).ShowDialog();
            }
        }

        private void ActualizarEtiquetas(DateTime Fecha)
        {
            string ActualizacionDePeriodos = 
                string.Format("Del {0} al {1}",
                               Fecha.AddDays(-2).ToString("dd-MM-yyyy"), 
                               Fecha.ToString("dd-MM-yyyy"));

            string ActualizacionDePeriodo = Fecha.ToString("dd-MM-yyyy");

            lblPeriodoCompras.Text = ActualizacionDePeriodos;
            lblPeriodoCxP.Text = ActualizacionDePeriodos;

            lblPeriodoCxC.Text = ActualizacionDePeriodo;
            lblPeriodoInventarios.Text = ActualizacionDePeriodo;
            lblPeriodoVentas.Text = ActualizacionDePeriodo;
        }

    }
}
