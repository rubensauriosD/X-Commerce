using Commerce.Entidades;
using System;
using System.Windows.Forms;

namespace Commerce
{
    public partial class FormLogin : Form
    {
        private Empleado empleadoLogin;
        public Empleado Empleado => empleadoLogin;

        public FormLogin()
        {
            InitializeComponent();

            empleadoLogin = null;
        }       

        private void linkRegistrarEmpleado_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var fNuevoEmpleado = new FormNuevoEmpleado();
            fNuevoEmpleado.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
