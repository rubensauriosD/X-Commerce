using System.Windows.Forms;

namespace Commerce
{
    public partial class FormVentas : Form
    {
        public FormVentas()
        {
            InitializeComponent();
        }

        private void btnNuevoCliente_Click(object sender, System.EventArgs e)
        {
            var fNuevoCliente = new FormNuevoCliente();
            fNuevoCliente.ShowDialog();
        }

        private void btnBuscarCliente_Click(object sender, System.EventArgs e)
        {
            var fLookUpCliente = new FormClientesLookUp();
            fLookUpCliente.ShowDialog();
        }

        private void btnEliminarItem_Click(object sender, System.EventArgs e)
        {
            var fEliminarItem = new FormEliminarItem();
            fEliminarItem.ShowDialog();
        }

        private void btnFacturar_Click(object sender, System.EventArgs e)
        {
            var fFacturar = new FormFacturar();
            fFacturar.ShowDialog();
        }
    }
}
