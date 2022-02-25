using System;
using System.Windows.Forms;

namespace FormularioSaludo_TP_G5_2022_II
{
    partial class FormSaludo
    {
        //Métodos de la Clase FormSualudo
        public FormSaludo()
        {
            InicializarComponentes();
        }

        public void Click_Saludo(object sender, EventArgs e )
        {
            MessageBox.Show("Hola " + txtbNombre.Text);
        }

        public void Click_LimpiarPantalla(object sender, EventArgs e)
        {
            txtbNombre.Clear();
        }
    }
}
