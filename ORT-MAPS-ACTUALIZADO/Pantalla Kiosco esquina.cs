using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORTmaps.Apps
{
    public partial class Pantalla_Kiosco_esquina : Form
    {
        public Pantalla_Kiosco_esquina()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form Opciones_K = new Opciones_K();
            Opciones_K.Show();
            this.Hide();
        }
    }
}
