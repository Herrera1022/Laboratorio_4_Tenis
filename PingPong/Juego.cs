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
    public partial class Juego : Form
    {
        public Juego()
        {
            InitializeComponent();
        }

        //Funcion que permite regresar al primer form cuando se cierre el form juego.
        private void Juego_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }
        //Aplicando lógica de movimiento de la raquetas izquierda del juego.
        private void Juego_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                raquetaIzq.Top = raquetaIzq.Top - 30;
            }

            if (e.KeyCode == Keys.S)
            {
                raquetaIzq.Top = raquetaIzq.Top + 30;
            }
        }

        //Aplicando lógica de movimiento de la raquetas derecha del juego.
        private void Juego_MouseMove(object sender, MouseEventArgs e)
        {
            raquetaDer.Top = e.Location.Y;
        }

        int velocidadx = 3;
        int velocidady = 3;      // Variables globales que permite el movimiento de la pelota y la acumulación de puntos.
        int jug1 = 0;
        int jug2 = 0;


        private void colision()
        {
            // Variables que nos ayudan a crear la lógica de movimiento de la pelota con respecto a la colision con las raquetas.
            int raquetaIzqArriba=raquetaIzq.Top;
            int raquetaIzqDerecha=raquetaIzq.Left+raquetaIzq.Width;
            int raquetaIzqAbajo=raquetaIzq.Top+raquetaIzq.Height;
            int raquetaIzqIzquierda = raquetaIzq.Left;

            int raquetaDerArriba = raquetaDer.Top;
            int raquetaDerDerecha = raquetaDer.Left + raquetaDer.Width;
            int raquetaDerAbajo = raquetaDer.Top + raquetaDer.Height;
            int raquetaDerIzquierda = raquetaDer.Left;

            int pelotaArriba = pelota.Top;
            int pelotaDerecha = pelota.Left + pelota.Width;
            int pelotaAbajo = pelota.Top + pelota.Height;
            int pelotaIzquierda = pelota.Left;

            // Movimiento inicial de la pelota.
            pelota.Top = pelota.Top + velocidady;
            pelota.Left = pelota.Left + velocidadx;


            int arriba = 0;
            int derecha = this.Size.Width-pelota.Width;
            int abajo=this.Size.Height-pelota.Height-37;
            int izquierda = 0;

            //Logica de colision de la pelota contra las raquetas.
            if (pelotaAbajo >= raquetaIzqArriba && pelotaArriba <= raquetaIzqAbajo && pelotaIzquierda <= raquetaIzqDerecha && pelotaDerecha >= raquetaIzqIzquierda)
            {
                velocidadx = 3;
            }
            if (pelotaAbajo >= raquetaDerArriba && pelotaArriba <= raquetaDerAbajo && pelotaIzquierda <= raquetaDerDerecha && pelotaDerecha >= raquetaDerIzquierda)
            {
                velocidadx = -3;
            }

            
            if (pelota.Top <= arriba)
            {
                velocidady = 3;                   //Condicional que permite que la pelota se mueva hacia abajo si toca el extremo superior.
            }
            if (pelota.Left >= derecha)
            {
                timer1.Enabled = false;
                MessageBox.Show("Punto jugador 1");    //Condicional que agrega puntos al jugador 1 ,si la pelota toca el extremo derecho. 
                jug1++;
                reset();
            }
            if (pelota.Top >= abajo)
            {
                velocidady = -3;                     //Condicional que permite que la pelota se mueva hacia arriba si toca el extremo inferior.
            }
            if (pelota.Left <= izquierda)
            {
                timer1.Enabled=false;
                MessageBox.Show("Punto jugador 2");              //Condicional que agrega puntos al jugador 2 ,si la pelota toca el extremo izquierdo.
                jug2++;
                reset();
            }
            if (jug1 == 10)
            {
                this.Close();
                MessageBox.Show("El jugador 1 ha ganado");    //Condicional que termina el juego si el jugador 1 acumula 10 puntos.
                timer1.Enabled = false;
            }
            if (jug2 == 10)
            {
                this.Close();
                MessageBox.Show("El jugador 2 ha ganado");      //Condicional que termina el juego si el jugador 2 acumula 10 puntos.
                timer1.Enabled = false;
            }

        }
        //Función que muestra el puntaje que se va acumulando despues de que la pelota toca un extremo,
        //ya se derecho o izquierdo y reinicia la posición de la pelota para continuar jugando.
        private void reset()
        {
            pelota.Top = 173;
            pelota.Left = 388;
            lblJugador1.Text = jug1.ToString();
            lblJugador2.Text = jug2.ToString();
            timer1.Enabled = Enabled;
        }
        //Función que permite iniciar el juego.
        private void timer1_Tick(object sender, EventArgs e)
        {
            colision();
        }
    }
}
