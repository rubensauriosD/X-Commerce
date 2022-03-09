using Commerce.Servicios;
using System;
using System.Windows.Forms;

namespace Commerce
{
    public partial class FormCuentaCorriente : Form
    {
        public FormCuentaCorriente()
        {
            InitializeComponent();

            DoubleBuffered = true;
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
        }

        private void PoblarGrilla(string cadenaBuscar)
        {
            
        }

        private void FormatearGrilla(DataGridView dgv)
        {
            
        }


        private void btnNuevoPago_Click(object sender, EventArgs e)
        {
            var fPagoCtaCte = new FormPagoCtaCte();
            fPagoCtaCte.ShowDialog();
        }
    }
}
