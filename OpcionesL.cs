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
    public partial class Opciones_L : Form
    {
        public Opciones_L()
        {
            InitializeComponent();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Form Librería_JLZ = new Librería_JLZ();
            Librería_JLZ.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form Forum_libreria = new Forum_libreria();
            Forum_libreria.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form Lunaria_Libros = new Lunaria_Libros();
            Lunaria_Libros.Show();
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form MapaExterior = new MapaExterior();
            MapaExterior.Show();
            this.Hide();
        }
    }
}
