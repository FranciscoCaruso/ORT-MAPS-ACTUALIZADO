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
    public partial class Librería_JLZ : Form
    {
        public Librería_JLZ()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form Opciones_L = new Opciones_L();
            Opciones_L.Show();
            this.Hide();
        }
    }
}
