using Commerce.Servicios;
using System;
using System.Windows.Forms;

namespace Commerce
{
    public partial class FormEmpleados : Form
    {
        public FormEmpleados()
        {
            InitializeComponent();

            DoubleBuffered = true;
        }

        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            PoblarGrilla(txtBuscar.Text);
        }

        private void PoblarGrilla(string cadenaBuscar)
        {
            dgv.DataSource = EmpleadoServicio
                .Obtener(!string.IsNullOrEmpty(cadenaBuscar) ? cadenaBuscar : string.Empty);

            FormatearGrilla(dgv);
        }

        private void FormatearGrilla(DataGridView dgv)
        {
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                dgv.Columns[i].Visible = false;
            }

            dgv.Columns["Legajo"].Visible = true;
            dgv.Columns["Legajo"].HeaderText = "Legajo";
            dgv.Columns["Legajo"].Width = 100;
            
            dgv.Columns["ApyNomCompleto"].Visible = true;
            dgv.Columns["ApyNomCompleto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns["ApyNomCompleto"].HeaderText = "Apellido y Nombre";

            dgv.Columns["DireccionCompleta"].Visible = true;
            dgv.Columns["DireccionCompleta"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns["DireccionCompleta"].HeaderText = "Domicilio";

            dgv.Columns["Dni"].Visible = true;
            dgv.Columns["Dni"].Width = 100;
            dgv.Columns["Dni"].HeaderText = "DNI";

            dgv.Columns["FechaNacimientoStr"].Visible = true;
            dgv.Columns["FechaNacimientoStr"].HeaderText = "Fecha Nac.";
            dgv.Columns["FechaNacimientoStr"].Width = 150;
            dgv.Columns["FechaNacimientoStr"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var fNuevoEmpleado = new FormNuevoEmpleado();
            fNuevoEmpleado.ShowDialog();
        }
    }
}
