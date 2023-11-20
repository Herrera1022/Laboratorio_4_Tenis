using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Funcion que al presionar el boton jugar me redirecciona al form juego.
        private void jugar_Click(object sender, EventArgs e)
        {
            Juego ventanaJuego = new Juego();
            ventanaJuego.Show(this);
            this.Hide();
        }
    }
}
