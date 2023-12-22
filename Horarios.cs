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
    public partial class Horarios : Form
    {
        public static Horarios instancia = null;

        public static Horarios ComprobarVentanaUnica()
        {
            if(instancia == null)
            {
                instancia = new Horarios();
            }
            return instancia;
        }

        public Horarios()
        {
            InitializeComponent();
        }
    }
}
