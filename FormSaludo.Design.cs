using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormularioSaludo_TP_G5_2022_II
{
    partial class FormSaludo:Form
    {
        private Label lbMensaje;
        private TextBox txtbNombre;
        private Button btnSaludo;
        private void InicializarComponentes()
        {
            this.Text = "FormSaludo";
            this.Size = new Size(400, 300);

            lbMensaje = new Label();
            lbMensaje.Text = "Introduce tu nombre";
            lbMensaje.Location = new Point(20, 50);
            lbMensaje.Size = new Size(300,15);

            txtbNombre = new TextBox();
            txtbNombre.Location = new Point(100,150);
            txtbNombre.Size = new Size(50,50);

            btnSaludo = new Button();
            btnSaludo.Text = "Aceptar";
            btnSaludo.Location = new Point(100, 200);
            btnSaludo.Size = new Size(100, 50);

            this.Controls.Add(lbMensaje);
            this.Controls.Add(txtbNombre);
            this.Controls.Add(btnSaludo);

        }

    }
}
