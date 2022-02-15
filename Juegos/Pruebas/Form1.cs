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
            grupoSegmentos = new Serpiente.Snake[] { snake1, snake2, snake3, snake4, snake5, snake6, snake7, snake8, snake9, snake10, snake11, snake12, snake13, snake14, snake15, snake16, snake17, snake18, snake19, snake20, snake21, snake22 };
            Random rdn = new Random();
            objetivo.Location = new Point(rdn.Next(this.Width - 50), rdn.Next(this.Height - 50));
            snake1.Location= new Point(rdn.Next(this.Width - 50), rdn.Next(this.Height - 50));

        }

        // private int sentido = 1;
        private Serpiente.Snake[] grupoSegmentos;
        public static int pos = 1;
        static Point posAux, posAuxAnterior;


        protected void moverSegmentos()
        {

            for (int i = 1; i < snake1.Segmentos + 1; i++)
            {
                if (i == 1)
                {
                    posAux = snake1.Location;
                }
                grupoSegmentos[i].Visible = true;

                posAuxAnterior = grupoSegmentos[i].Location;
                grupoSegmentos[i].Location = posAux;
                posAux = posAuxAnterior;

            }            
        }

        protected bool colision(Control rect1, Control rect2)
        {
            if (((Serpiente.Snake)rect1).Location.X < ((Serpiente.Snake)rect2).Location.X + ((Serpiente.Snake)rect2).Width &&
                ((Serpiente.Snake)rect1).Location.X + ((Serpiente.Snake)rect1).Width > ((Serpiente.Snake)rect2).Location.X &&
                 ((Serpiente.Snake)rect1).Location.Y < ((Serpiente.Snake)rect2).Location.Y + ((Serpiente.Snake)rect2).Height &&
                 ((Serpiente.Snake)rect1).Height + ((Serpiente.Snake)rect1).Location.Y > ((Serpiente.Snake)rect2).Location.Y)
            {
                return true;
            }
            else
            {
                return false;
            }

        }



        public void recolocar()
        {
            for (int i = 1; i < snake1.Segmentos + 1; i++)
            {
                grupoSegmentos[i].Visible = true;
                if (grupoSegmentos[i - 1].Direccion == Serpiente.Snake.eDireccion.vertical)
                {
                    if (grupoSegmentos[i - 1].Sentido == 1)
                    {
                        grupoSegmentos[i].Location = new Point(grupoSegmentos[i - 1].Location.X, grupoSegmentos[i - 1].Location.Y - grupoSegmentos[i - 1].Height);
                    }
                    else
                    {
                        grupoSegmentos[i].Location = new Point(grupoSegmentos[i - 1].Location.X, grupoSegmentos[i - 1].Location.Y + grupoSegmentos[i - 1].Height);
                    }

                }

                if (grupoSegmentos[i - 1].Direccion == Serpiente.Snake.eDireccion.horizontal)
                {
                    if (grupoSegmentos[i - 1].Sentido == 1)
                    {
                        grupoSegmentos[i].Location = new Point(grupoSegmentos[i - 1].Location.X - snake1.Width, grupoSegmentos[i - 1].Location.Y);
                    }
                    else
                    {
                        grupoSegmentos[i].Location = new Point(grupoSegmentos[i - 1].Location.X + snake1.Width, grupoSegmentos[i - 1].Location.Y);
                    }
                }
            }
        }

        protected void movimiento()
        {
            if (snake1.activo)
            {
                if (snake1.Direccion == Serpiente.Snake.eDireccion.horizontal)
                {
                    snake1.Location = new Point(snake1.Location.X + snake1.Width * snake1.Sentido, snake1.Location.Y);
                }
                else
                {
                    snake1.Location = new Point(snake1.Location.X, snake1.Location.Y + snake1.Height * snake1.Sentido);
                }
            }

            if (snake1.Location.X <= 0)
            {
                snake1.Location = new Point(this.Width, snake1.Location.Y);
            }
            if (snake1.Location.Y <= 0)
            {
                snake1.Location = new Point(snake1.Location.X, this.Height);
            }
            if (snake1.Location.X > this.Width)
            {
                snake1.Location = new Point(0, snake1.Location.Y);
            }
            if (snake1.Location.Y > this.Height)
            {
                snake1.Location = new Point(snake1.Location.X, 0);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = "X:" + snake1.Location.X + " Y:" + snake1.Location.Y + " Tamaño array:" + grupoSegmentos.Length;
            label2.Text = "X:" + objetivo.Location.X + " Y:" + objetivo.Location.Y;
            label1.Text = " W:" + this.Width+" H:" + this.Height;
            movimiento();

            if (pos > 5)
            {
                moverSegmentos();
                for (int i = 2; i < grupoSegmentos.Length; i++)
                {
                    if (colision(snake1, grupoSegmentos[i]))
                    {
                        snake1.activo = false;
                        this.Text = "GAME OVER";
                    }

                }
            }
            pos++;

            if (colision(snake1, objetivo))
            {
                Random rdn = new Random();
                snake1.Segmentos++;
                objetivo.Location = new Point(rdn.Next(this.Width - 50), rdn.Next(this.Height - 50));
                if (timer1.Interval > 20)
                {
                    timer1.Interval -= 10;
                }
            }


        }


        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    this.Text = "Tecla arriba" + snake1.Sentido;
                    if (snake1.Direccion != Serpiente.Snake.eDireccion.vertical)
                    {
                        snake1.Direccion = Serpiente.Snake.eDireccion.vertical;
                        snake1.Sentido = -1;
                    }
                    break;
                case Keys.Down:
                    this.Text = "Tecla abajo";
                    if (snake1.Direccion != Serpiente.Snake.eDireccion.vertical)
                    {
                        snake1.Direccion = Serpiente.Snake.eDireccion.vertical;
                        snake1.Sentido = 1;

                    }
                    break;
                case Keys.Left:
                    this.Text = "Tecla izda";
                    if (snake1.Direccion != Serpiente.Snake.eDireccion.horizontal)
                    {
                        snake1.Direccion = Serpiente.Snake.eDireccion.horizontal;
                        snake1.Sentido = -1;

                    }
                    break;
                case Keys.Right:
                    this.Text = "Tecla dcha";
                    if (snake1.Direccion != Serpiente.Snake.eDireccion.horizontal)
                    {
                        snake1.Direccion = Serpiente.Snake.eDireccion.horizontal;
                        snake1.Sentido = 1;

                    }
                    break;
                default:
                    break;
            }
        }
    }
}
