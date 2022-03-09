using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Commerce
{
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var fNuevoProducto = new FormNuevoProducto();
            fNuevoProducto.ShowDialog();
        }

        private void btnCargaStock_Click(object sender, EventArgs e)
        {
            var fAjusteStock = new FormAjusteStock();
            fAjusteStock.ShowDialog();
        }
    }
}
