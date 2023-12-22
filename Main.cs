using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RelojChecador
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Horarios form = Horarios.ComprobarVentanaUnica();
            form.MdiParent = this;
            //form.Show();
            AbrirFormHijo(new Horarios());
        }

        //
        private void AbrirFormHijo(object formHijo)
        {
            if (this.PanelDeContenido.Controls.Count > 0)
            {
                this.PanelDeContenido.Controls.RemoveAt(0);
            }

            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelDeContenido.Controls.Add(fh);
            this.PanelDeContenido.Tag = fh;
            fh.Show();
        }

    }
}
