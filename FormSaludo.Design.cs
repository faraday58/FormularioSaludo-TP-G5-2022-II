using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormularioSaludo_TP_G5_2022_II
{
    partial class FormSaludo:Form
    {
        private Label lbMensaje;
        private void InicializarComponentes()
        {
            this.Text = "FormSaludo";
            this.Size = new Size(400, 300);

            lbMensaje = new Label();
            lbMensaje.Text = "Introduce tu nombre";
            lbMensaje.Location = new Point(20, 50);
            lbMensaje.Size = new Size(300,15);

            this.Controls.Add(lbMensaje);

        }

    }
}
