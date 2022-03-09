using Commerce.Servicios;
using System;
using System.Windows.Forms;

namespace Commerce
{
    public partial class FormClientesLookUp : Form
    {
        public FormClientesLookUp()
        {
            InitializeComponent();

            DoubleBuffered = true;
        }

        private void PoblarGrilla(string cadenaBuscar)
        {
            dgv.DataSource = ClienteServicio
                .Obtener(!string.IsNullOrEmpty(cadenaBuscar) ? cadenaBuscar : string.Empty);

            FormatearGrilla(dgv);
        }

        private void FormatearGrilla(DataGridView dgv)
        {
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                dgv.Columns[i].Visible = false;
            }

            dgv.Columns["Codigo"].Visible = true;
            dgv.Columns["Codigo"].HeaderText = "Código";
            dgv.Columns["Codigo"].Width = 100;
            
            dgv.Columns["ApyNomCompleto"].Visible = true;
            dgv.Columns["ApyNomCompleto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns["ApyNomCompleto"].HeaderText = "Apellido y Nombre";

            dgv.Columns["Dni"].Visible = true;
            dgv.Columns["Dni"].Width = 100;
            dgv.Columns["Dni"].HeaderText = "DNI";
        }

        private void FormClientesLookUp_Load(object sender, EventArgs e)
        {
            PoblarGrilla(!string.IsNullOrEmpty(txtBuscar.Text) ? txtBuscar.Text : string.Empty);
        }
    }
}
