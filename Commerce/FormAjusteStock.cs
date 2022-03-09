using System.Windows.Forms;
using Commerce.Entidades;

namespace Commerce
{
    public partial class FormAjusteStock : Form
    {
        private Producto _producto;

        public FormAjusteStock()
        {
            InitializeComponent();
        }

        public FormAjusteStock(Producto producto)
        : this()
        {
            _producto = producto;
        }
    }
}
