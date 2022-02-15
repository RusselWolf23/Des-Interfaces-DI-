
namespace Pruebas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.objetivo = new Serpiente.Snake();
            this.snake13 = new Serpiente.Snake();
            this.snake14 = new Serpiente.Snake();
            this.snake15 = new Serpiente.Snake();
            this.snake16 = new Serpiente.Snake();
            this.snake17 = new Serpiente.Snake();
            this.snake18 = new Serpiente.Snake();
            this.snake19 = new Serpiente.Snake();
            this.snake20 = new Serpiente.Snake();
            this.snake21 = new Serpiente.Snake();
            this.snake22 = new Serpiente.Snake();
            this.snake12 = new Serpiente.Snake();
            this.snake11 = new Serpiente.Snake();
            this.snake10 = new Serpiente.Snake();
            this.snake9 = new Serpiente.Snake();
            this.snake8 = new Serpiente.Snake();
            this.snake7 = new Serpiente.Snake();
            this.snake6 = new Serpiente.Snake();
            this.snake5 = new Serpiente.Snake();
            this.snake4 = new Serpiente.Snake();
            this.snake3 = new Serpiente.Snake();
            this.snake2 = new Serpiente.Snake();
            this.snake1 = new Serpiente.Snake();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 230;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 24;
            // 
            // objetivo
            // 
            this.objetivo.Cuadrado = ((System.Drawing.Icon)(resources.GetObject("objetivo.Cuadrado")));
            this.objetivo.Direccion = Serpiente.Snake.eDireccion.horizontal;
            this.objetivo.Location = new System.Drawing.Point(249, 83);
            this.objetivo.Name = "objetivo";
            this.objetivo.Segmentos = 1;
            this.objetivo.Sentido = -1;
            this.objetivo.Size = new System.Drawing.Size(15, 15);
            this.objetivo.TabIndex = 22;
            this.objetivo.Text = "snake23";
            // 
            // snake13
            // 
            this.snake13.Cuadrado = ((System.Drawing.Icon)(resources.GetObject("snake13.Cuadrado")));
            this.snake13.Direccion = Serpiente.Snake.eDireccion.horizontal;
            this.snake13.Enabled = false;
            this.snake13.Location = new System.Drawing.Point(1159, 385);
            this.snake13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.snake13.Name = "snake13";
            this.snake13.Segmentos = 1;
            this.snake13.Sentido = -1;
            this.snake13.Size = new System.Drawing.Size(15, 15);
            this.snake13.TabIndex = 21;
            this.snake13.Text = "snake13";
            this.snake13.Visible = false;
            // 
            // snake14
            // 
            this.snake14.Cuadrado = ((System.Drawing.Icon)(resources.GetObject("snake14.Cuadrado")));
            this.snake14.Direccion = Serpiente.Snake.eDireccion.horizontal;
            this.snake14.Enabled = false;
            this.snake14.Location = new System.Drawing.Point(1151, 377);
            this.snake14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.snake14.Name = "snake14";
            this.snake14.Segmentos = 1;
            this.snake14.Sentido = -1;
            this.snake14.Size = new System.Drawing.Size(15, 15);
            this.snake14.TabIndex = 20;
            this.snake14.Text = "snake14";
            this.snake14.Visible = false;
            // 
            // snake15
            // 
            this.snake15.Cuadrado = ((System.Drawing.Icon)(resources.GetObject("snake15.Cuadrado")));
            this.snake15.Direccion = Serpiente.Snake.eDireccion.horizontal;
            this.snake15.Enabled = false;
            this.snake15.Location = new System.Drawing.Point(1143, 369);
            this.snake15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.snake15.Name = "snake15";
            this.snake15.Segmentos = 1;
            this.snake15.Sentido = -1;
            this.snake15.Size = new System.Drawing.Size(15, 15);
            this.snake15.TabIndex = 19;
            this.snake15.Text = "snake15";
            this.snake15.Visible = false;
            // 
            // snake16
            // 
            this.snake16.Cuadrado = ((System.Drawing.Icon)(resources.GetObject("snake16.Cuadrado")));
            this.snake16.Direccion = Serpiente.Snake.eDireccion.horizontal;
            this.snake16.Enabled = false;
            this.snake16.Location = new System.Drawing.Point(1135, 361);
            this.snake16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.snake16.Name = "snake16";
            this.snake16.Segmentos = 1;
            this.snake16.Sentido = -1;
            this.snake16.Size = new System.Drawing.Size(15, 15);
            this.snake16.TabIndex = 18;
            this.snake16.Text = "snake16";
            this.snake16.Visible = false;
            // 
            // snake17
            // 
            this.snake17.Cuadrado = ((System.Drawing.Icon)(resources.GetObject("snake17.Cuadrado")));
            this.snake17.Direccion = Serpiente.Snake.eDireccion.horizontal;
            this.snake17.Enabled = false;
            this.snake17.Location = new System.Drawing.Point(1127, 353);
            this.snake17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.snake17.Name = "snake17";
            this.snake17.Segmentos = 1;
            this.snake17.Sentido = -1;
            this.snake17.Size = new System.Drawing.Size(15, 15);
            this.snake17.TabIndex = 17;
            this.snake17.Text = "snake17";
            this.snake17.Visible = false;
            // 
            // snake18
            // 
            this.snake18.Cuadrado = ((System.Drawing.Icon)(resources.GetObject("snake18.Cuadrado")));
            this.snake18.Direccion = Serpiente.Snake.eDireccion.horizontal;
            this.snake18.Enabled = false;
            this.snake18.Location = new System.Drawing.Point(1119, 345);
            this.snake18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.snake18.Name = "snake18";
            this.snake18.Segmentos = 1;
            this.snake18.Sentido = -1;
            this.snake18.Size = new System.Drawing.Size(15, 15);
            this.snake18.TabIndex = 16;
            this.snake18.Text = "snake18";
            this.snake18.Visible = false;
            // 
            // snake19
            // 
            this.snake19.Cuadrado = ((System.Drawing.Icon)(resources.GetObject("snake19.Cuadrado")));
            this.snake19.Direccion = Serpiente.Snake.eDireccion.horizontal;
            this.snake19.Enabled = false;
            this.snake19.Location = new System.Drawing.Point(1111, 337);
            this.snake19.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.snake19.Name = "snake19";
            this.snake19.Segmentos = 1;
            this.snake19.Sentido = -1;
            this.snake19.Size = new System.Drawing.Size(15, 15);
            this.snake19.TabIndex = 15;
            this.snake19.Text = "snake19";
            this.snake19.Visible = false;
            // 
            // snake20
            // 
            this.snake20.Cuadrado = ((System.Drawing.Icon)(resources.GetObject("snake20.Cuadrado")));
            this.snake20.Direccion = Serpiente.Snake.eDireccion.horizontal;
            this.snake20.Enabled = false;
            this.snake20.Location = new System.Drawing.Point(1103, 329);
            this.snake20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.snake20.Name = "snake20";
            this.snake20.Segmentos = 1;
            this.snake20.Sentido = -1;
            this.snake20.Size = new System.Drawing.Size(15, 15);
            this.snake20.TabIndex = 14;
            this.snake20.Text = "snake20";
            this.snake20.Visible = false;
            // 
            // snake21
            // 
            this.snake21.Cuadrado = ((System.Drawing.Icon)(resources.GetObject("snake21.Cuadrado")));
            this.snake21.Direccion = Serpiente.Snake.eDireccion.horizontal;
            this.snake21.Enabled = false;
            this.snake21.Location = new System.Drawing.Point(1095, 321);
            this.snake21.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.snake21.Name = "snake21";
            this.snake21.Segmentos = 1;
            this.snake21.Sentido = -1;
            this.snake21.Size = new System.Drawing.Size(15, 15);
            this.snake21.TabIndex = 13;
            this.snake21.Text = "snake21";
            this.snake21.Visible = false;
            // 
            // snake22
            // 
            this.snake22.Cuadrado = ((System.Drawing.Icon)(resources.GetObject("snake22.Cuadrado")));
            this.snake22.Direccion = Serpiente.Snake.eDireccion.horizontal;
            this.snake22.Enabled = false;
            this.snake22.Location = new System.Drawing.Point(1087, 313);
            this.snake22.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.snake22.Name = "snake22";
            this.snake22.Segmentos = 1;
            this.snake22.Sentido = -1;
            this.snake22.Size = new System.Drawing.Size(15, 15);
            this.snake22.TabIndex = 12;
            this.snake22.Text = "snake22";
            this.snake22.Visible = false;
            // 
            // snake12
            // 
            this.snake12.Cuadrado = ((System.Drawing.Icon)(resources.GetObject("snake12.Cuadrado")));
            this.snake12.Direccion = Serpiente.Snake.eDireccion.horizontal;
            this.snake12.Enabled = false;
            this.snake12.Location = new System.Drawing.Point(1177, 367);
            this.snake12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.snake12.Name = "snake12";
            this.snake12.Segmentos = 1;
            this.snake12.Sentido = -1;
            this.snake12.Size = new System.Drawing.Size(15, 15);
            this.snake12.TabIndex = 11;
            this.snake12.Text = "snake12";
            this.snake12.Visible = false;
            // 
            // snake11
            // 
            this.snake11.Cuadrado = ((System.Drawing.Icon)(resources.GetObject("snake11.Cuadrado")));
            this.snake11.Direccion = Serpiente.Snake.eDireccion.horizontal;
            this.snake11.Enabled = false;
            this.snake11.Location = new System.Drawing.Point(1169, 359);
            this.snake11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.snake11.Name = "snake11";
            this.snake11.Segmentos = 1;
            this.snake11.Sentido = -1;
            this.snake11.Size = new System.Drawing.Size(15, 15);
            this.snake11.TabIndex = 10;
            this.snake11.Text = "snake11";
            this.snake11.Visible = false;
            // 
            // snake10
            // 
            this.snake10.Cuadrado = ((System.Drawing.Icon)(resources.GetObject("snake10.Cuadrado")));
            this.snake10.Direccion = Serpiente.Snake.eDireccion.horizontal;
            this.snake10.Enabled = false;
            this.snake10.Location = new System.Drawing.Point(1161, 351);
            this.snake10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.snake10.Name = "snake10";
            this.snake10.Segmentos = 1;
            this.snake10.Sentido = -1;
            this.snake10.Size = new System.Drawing.Size(15, 15);
            this.snake10.TabIndex = 9;
            this.snake10.Text = "snake10";
            this.snake10.Visible = false;
            // 
            // snake9
            // 
            this.snake9.Cuadrado = ((System.Drawing.Icon)(resources.GetObject("snake9.Cuadrado")));
            this.snake9.Direccion = Serpiente.Snake.eDireccion.horizontal;
            this.snake9.Enabled = false;
            this.snake9.Location = new System.Drawing.Point(1153, 343);
            this.snake9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.snake9.Name = "snake9";
            this.snake9.Segmentos = 1;
            this.snake9.Sentido = -1;
            this.snake9.Size = new System.Drawing.Size(15, 15);
            this.snake9.TabIndex = 8;
            this.snake9.Text = "snake9";
            this.snake9.Visible = false;
            // 
            // snake8
            // 
            this.snake8.Cuadrado = ((System.Drawing.Icon)(resources.GetObject("snake8.Cuadrado")));
            this.snake8.Direccion = Serpiente.Snake.eDireccion.horizontal;
            this.snake8.Enabled = false;
            this.snake8.Location = new System.Drawing.Point(1145, 335);
            this.snake8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.snake8.Name = "snake8";
            this.snake8.Segmentos = 1;
            this.snake8.Sentido = -1;
            this.snake8.Size = new System.Drawing.Size(15, 15);
            this.snake8.TabIndex = 7;
            this.snake8.Text = "snake8";
            this.snake8.Visible = false;
            // 
            // snake7
            // 
            this.snake7.Cuadrado = ((System.Drawing.Icon)(resources.GetObject("snake7.Cuadrado")));
            this.snake7.Direccion = Serpiente.Snake.eDireccion.horizontal;
            this.snake7.Enabled = false;
            this.snake7.Location = new System.Drawing.Point(1137, 327);
            this.snake7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.snake7.Name = "snake7";
            this.snake7.Segmentos = 1;
            this.snake7.Sentido = -1;
            this.snake7.Size = new System.Drawing.Size(15, 15);
            this.snake7.TabIndex = 6;
            this.snake7.Text = "snake7";
            this.snake7.Visible = false;
            // 
            // snake6
            // 
            this.snake6.Cuadrado = ((System.Drawing.Icon)(resources.GetObject("snake6.Cuadrado")));
            this.snake6.Direccion = Serpiente.Snake.eDireccion.horizontal;
            this.snake6.Enabled = false;
            this.snake6.Location = new System.Drawing.Point(1129, 319);
            this.snake6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.snake6.Name = "snake6";
            this.snake6.Segmentos = 1;
            this.snake6.Sentido = -1;
            this.snake6.Size = new System.Drawing.Size(15, 15);
            this.snake6.TabIndex = 5;
            this.snake6.Text = "snake6";
            this.snake6.Visible = false;
            // 
            // snake5
            // 
            this.snake5.Cuadrado = ((System.Drawing.Icon)(resources.GetObject("snake5.Cuadrado")));
            this.snake5.Direccion = Serpiente.Snake.eDireccion.horizontal;
            this.snake5.Enabled = false;
            this.snake5.Location = new System.Drawing.Point(1121, 311);
            this.snake5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.snake5.Name = "snake5";
            this.snake5.Segmentos = 1;
            this.snake5.Sentido = -1;
            this.snake5.Size = new System.Drawing.Size(15, 15);
            this.snake5.TabIndex = 4;
            this.snake5.Text = "snake5";
            this.snake5.Visible = false;
            // 
            // snake4
            // 
            this.snake4.Cuadrado = ((System.Drawing.Icon)(resources.GetObject("snake4.Cuadrado")));
            this.snake4.Direccion = Serpiente.Snake.eDireccion.horizontal;
            this.snake4.Enabled = false;
            this.snake4.Location = new System.Drawing.Point(1113, 303);
            this.snake4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.snake4.Name = "snake4";
            this.snake4.Segmentos = 1;
            this.snake4.Sentido = -1;
            this.snake4.Size = new System.Drawing.Size(15, 15);
            this.snake4.TabIndex = 3;
            this.snake4.Text = "snake4";
            this.snake4.Visible = false;
            // 
            // snake3
            // 
            this.snake3.Cuadrado = ((System.Drawing.Icon)(resources.GetObject("snake3.Cuadrado")));
            this.snake3.Direccion = Serpiente.Snake.eDireccion.horizontal;
            this.snake3.Enabled = false;
            this.snake3.Location = new System.Drawing.Point(1105, 295);
            this.snake3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.snake3.Name = "snake3";
            this.snake3.Segmentos = 1;
            this.snake3.Sentido = -1;
            this.snake3.Size = new System.Drawing.Size(15, 15);
            this.snake3.TabIndex = 2;
            this.snake3.Text = "snake3";
            this.snake3.Visible = false;
            // 
            // snake2
            // 
            this.snake2.Cuadrado = ((System.Drawing.Icon)(resources.GetObject("snake2.Cuadrado")));
            this.snake2.Direccion = Serpiente.Snake.eDireccion.horizontal;
            this.snake2.Enabled = false;
            this.snake2.Location = new System.Drawing.Point(1107, 132);
            this.snake2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.snake2.Name = "snake2";
            this.snake2.Segmentos = 1;
            this.snake2.Sentido = -1;
            this.snake2.Size = new System.Drawing.Size(15, 15);
            this.snake2.TabIndex = 1;
            this.snake2.Text = "snake2";
            this.snake2.Visible = false;
            // 
            // snake1
            // 
            this.snake1.Cuadrado = ((System.Drawing.Icon)(resources.GetObject("snake1.Cuadrado")));
            this.snake1.Direccion = Serpiente.Snake.eDireccion.vertical;
            this.snake1.Location = new System.Drawing.Point(153, 99);
            this.snake1.Margin = new System.Windows.Forms.Padding(4);
            this.snake1.Name = "snake1";
            this.snake1.Segmentos = 1;
            this.snake1.Sentido = -1;
            this.snake1.Size = new System.Drawing.Size(15, 15);
            this.snake1.TabIndex = 0;
            this.snake1.Text = "snake1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 433);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.objetivo);
            this.Controls.Add(this.snake13);
            this.Controls.Add(this.snake14);
            this.Controls.Add(this.snake15);
            this.Controls.Add(this.snake16);
            this.Controls.Add(this.snake17);
            this.Controls.Add(this.snake18);
            this.Controls.Add(this.snake19);
            this.Controls.Add(this.snake20);
            this.Controls.Add(this.snake21);
            this.Controls.Add(this.snake22);
            this.Controls.Add(this.snake12);
            this.Controls.Add(this.snake11);
            this.Controls.Add(this.snake10);
            this.Controls.Add(this.snake9);
            this.Controls.Add(this.snake8);
            this.Controls.Add(this.snake7);
            this.Controls.Add(this.snake6);
            this.Controls.Add(this.snake5);
            this.Controls.Add(this.snake4);
            this.Controls.Add(this.snake3);
            this.Controls.Add(this.snake2);
            this.Controls.Add(this.snake1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Serpiente.Snake snake1;
        private System.Windows.Forms.Timer timer1;
        private Serpiente.Snake snake2;
        private Serpiente.Snake snake3;
        private Serpiente.Snake snake4;
        private Serpiente.Snake snake5;
        private Serpiente.Snake snake6;
        private Serpiente.Snake snake7;
        private Serpiente.Snake snake8;
        private Serpiente.Snake snake9;
        private Serpiente.Snake snake10;
        private Serpiente.Snake snake11;
        private Serpiente.Snake snake12;
        private Serpiente.Snake snake13;
        private Serpiente.Snake snake14;
        private Serpiente.Snake snake15;
        private Serpiente.Snake snake16;
        private Serpiente.Snake snake17;
        private Serpiente.Snake snake18;
        private Serpiente.Snake snake19;
        private Serpiente.Snake snake20;
        private Serpiente.Snake snake21;
        private Serpiente.Snake snake22;
        private Serpiente.Snake objetivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

