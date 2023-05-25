using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Estacionamiento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        Thread car1;
        Thread car2;
        Thread car3;


        //Metodos Carro 1
        public void EstacionarCarro1()
        {
            car1 = new Thread(new ThreadStart(Estacionar_carro1));
        }

        public void Estacionar_carro1()
        {
            bool derecha1 = true, izquierda1 = true, abajo1 = true, arriba1 = true;
            while (true)
            {
                if (!Derecha(pbCarro1, pnAbajo.Location.X, derecha1))
                { 
                    if(derecha1 == true)
                    {
                        pbCarro1.Size = new Size(56, 84);
                        pbCarro1.Image = Properties.Resources.carro1___abajo;
                        derecha1 = false;
                    }
                    if (!Abajo(pbCarro1, pnLimAbajo.Location.Y, abajo1))
                    {
                        if(abajo1 == true)
                        {
                            pbCarro1.Size = new Size(92, 55);
                            pbCarro1.Image = Properties.Resources.carro1__izquierda;
                            pbCarro1.Location = new Point(587, 494);//690, 471
                            abajo1 = false;
                        }
                        if (!Izquierda(pbCarro1, pbFlechaIzq.Location.X, izquierda1))
                        {
                            if (izquierda1 == true)
                            {
                                pbCarro1.Size = new Size(56, 84);
                                pbCarro1.Image = Properties.Resources.carro1___arriba;
                                izquierda1 = false;
                            }
                            if (!Arriba(pbCarro1, pbFlechaAriba.Location.Y, arriba1))
                            {
                                if (arriba1 == true)
                                {
                                    pbCarro1.Size = new Size(92, 55);
                                    pbCarro1.Image = Properties.Resources.carro1___derecha;
                                    arriba1 = false;
                                }
                                if (!Derecha(pbCarro1, 486, true))
                                {
                                    MessageBox.Show("El se estaciono correctamente.", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    cmdAplicacion.Enabled = true;
                                    car1.Abort();
                                }
                            }
                        }
                    }
                }

                Thread.Sleep(20);
            }
        }

        public void DesestacionarCarro1()
        {
            car1 = new Thread(new ThreadStart(Desestacionar_carro1));
        }

        public void Desestacionar_carro1()
        {
            bool izquierda1 = true, abajo1 = true;
            while (true)
            {
                if (!Izquierda(pbCarro1, pbFlechaAriba.Location.X, izquierda1))
                {
                    if (izquierda1 == true)
                    {
                        pbCarro1.Size = new Size(56, 84);
                        pbCarro1.Image = Properties.Resources.carro1___abajo;
                        izquierda1 = false;
                    }
                    if (!Abajo(pbCarro1, pnLimAbajo.Location.Y, abajo1))
                    {
                        if (abajo1 == true)
                        {
                            pbCarro1.Size = new Size(92, 55);
                            pbCarro1.Image = Properties.Resources.carro1__izquierda;
                            pbCarro1.Location = new Point(pbCarro1.Location.X - pbCarro1.Width, pbCarro1.Location.Y);
                            abajo1 = false;
                        }
                        if (!Izquierda(pbCarro1, 0 - pbCarro1.Width , true))
                        {
                            MessageBox.Show("El carro salio con exito.", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cmdAplicacion.Enabled = true;
                            car1.Abort();
                        }
                    }
                }
                Thread.Sleep(20);
            }

        }


        public void EstacionarCarro2()
        {

        }

        public void EstacionarCarro3()
        {

        }


        public bool Izquierda(PictureBox carro, int posicionMax, bool izquierda)
        {
            if (carro.Location.X > posicionMax && izquierda == true)
            {
                carro.Location = new Point(carro.Location.X - 7, carro.Location.Y);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Derecha(PictureBox carro, int posicionMax, bool derecha)
        {
            if (carro.Location.X < posicionMax && derecha == true)
            {
                carro.Location = new Point(carro.Location.X + 7, carro.Location.Y);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Abajo(PictureBox carro, int posicionMax, bool abajo)
        {
            if (carro.Location.Y < posicionMax && abajo == true)
            {
                carro.Location = new Point(carro.Location.X, carro.Location.Y + 7);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Arriba(PictureBox carro, int posicionMax, bool arriba)
        {
            if (carro.Location.Y > posicionMax && arriba == true)
            {
                carro.Location = new Point(carro.Location.X, carro.Location.Y - 7);
                return true;
            }
            else
            {
                return false;
            }
        }


        Pantalla pantalla = new Pantalla();
        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            pantalla.ShowDialog();

            if (pantalla.Lugar == pantalla.lblA2.Text)
            {
                if (pantalla.Accion == "Estacionar")
                {
                    pbCarro1.Visible = true;
                    EstacionarCarro1();
                    car1.Start();
                    cmdAplicacion.Enabled = false;

                    pantalla.A2.BackColor = Color.Crimson;
                }
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pantalla.ShowDialog();

            if (pantalla.Lugar == pantalla.lblA2.Text)
            {
                if(pantalla.Accion == "Estacionar")
                {
                    pbCarro1.Location = new Point(0 - pbCarro1.Width, 110);
                    pbCarro1.Visible = true;
                    EstacionarCarro1();
                    car1.Start();

                    pantalla.A2.BackColor = Color.Crimson;

                    cmdAplicacion.Enabled = false;
                }
                else if(pantalla.Accion == "Descestacionar")
                {
                    DesestacionarCarro1();
                    car1.Start();
                    cmdAplicacion.Enabled = false;
                }

            }
            //else if (opcion == DialogResult.No)
            //{
            //    DesestacionarCarro1();
            //    car1.Start();
            //}
        }
    }
}
