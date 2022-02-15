using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pruebas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            movimiento();            
        }

        private int sentido=1;

       protected void movimiento()
        {
            if (snake1.activo)
            {
                if (snake1.Direccion==Serpiente.Snake.eDireccion.horizontal)
                {
                    snake1.Location= new Point( snake1.Location.X + snake1.Width*sentido,snake1.Location.Y);
                }
                else
                {
                    snake1.Location = new Point(snake1.Location.X, snake1.Location.Y + snake1.Height*sentido);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            movimiento();
        }
       


        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {           
            switch (e.KeyCode)
            {
                case Keys.Up:
                    this.Text = "Tecla arriba"+sentido;
                    snake1.Direccion = Serpiente.Snake.eDireccion.vertical;
                    sentido = -1;
                    break;
                case Keys.Down:
                    this.Text = "Tecla abajo";
                    snake1.Direccion = Serpiente.Snake.eDireccion.vertical;
                    sentido = 1;
                    break;
                case Keys.Left:
                    this.Text = "Tecla izda";
                    snake1.Direccion = Serpiente.Snake.eDireccion.horizontal;
                    sentido = -1;
                    break;
                case Keys.Right:
                    this.Text = "Tecla dcha";
                    snake1.Direccion = Serpiente.Snake.eDireccion.horizontal;
                    sentido = 1;
                    break;

                default:
                    break;
            }
        }
    }
}
