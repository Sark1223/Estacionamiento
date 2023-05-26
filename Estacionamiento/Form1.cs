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
        Thread car4;
        Thread car5;

        //Metodos Carro 1
        public void EstacionarCarro1()
        {
            car1 = new Thread(new ThreadStart(Estacionar_carro1));
        }

        //Metodos Carro 2
        public void EstacionarCarro2()
        {
            car2 = new Thread(new ThreadStart(Estacionar_carro2));
        }

        ////Metodos Carro 3
        public void EstacionarCarro3()
        {
            car3 = new Thread(new ThreadStart(Estacionar_carro3));
        }
        //Metodo Carro 4
        public void EstacionarCarro4()
        {
            car4 = new Thread(new ThreadStart(Estacionar_Carro4));
        }
        //Metodo Carro 5
        public void EstacionarCarro5()
        {
            car5 = new Thread(new ThreadStart(Estacionar_Carro5));
        }
        public void DesestacionarCarro5()
        {
            car5 = new Thread(new ThreadStart(Desestacionar_Carro5));
        }
        public void Estacionar_carro1()
        {
            pbCarro1.Image = Properties.Resources.carro1___derecha;
            bool derecha1 = true, izquierda1 = true, abajo1 = true, arriba1 = true;
            while (true)
            {
                if (!Derecha(pbCarro1, pnAbajo.Location.X, derecha1))
                {
                    if (derecha1 == true)
                    {
                        pbCarro1.Size = new Size(56, 84);
                        pbCarro1.Image = Properties.Resources.carro1___abajo;
                        derecha1 = false;
                    }
                    if (!Abajo(pbCarro1, pnLimAbajo.Location.Y, abajo1))
                    {
                        if (abajo1 == true)
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
                                    pantalla.Lugar = "Ninguno";
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
                        if (!Izquierda(pbCarro1, 0 - pbCarro1.Width, true))
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

        public void Estacionar_carro2()
        {
            bool derecha = true, abajo = true, derecha2 = false; 
            while (true)
            {
                if (!Derecha(pbCarro2, pnAbajo.Location.X, derecha))
                {
                    if (derecha == true)
                    {
                        pbCarro2.Size = new Size(56, 84);
                        pbCarro2.Image = Properties.Resources.carro2___abajo;
                        derecha = false;
                    }
                    if (!Abajo(pbCarro2, 201, abajo))
                    {
                        if (abajo == true)
                        {
                            pbCarro2.Size = new Size(92, 55);
                            pbCarro2.Image = Properties.Resources.carro2___derecha;
                            pbCarro2.Location = new Point(668, 201);//690, 471
                            abajo = false;
                            derecha2 = true;
                        }
                        if (!Derecha(pbCarro2, 870, derecha2))
                        {
                            if (derecha2== true)
                            {
                                pbCarro2.Size = new Size(92, 55);
                                pbCarro2.Image = Properties.Resources.carro2___derecha;
                                derecha2 = false;
                            }
                            if (!Derecha(pbCarro2, 870, true))
                            {
                                MessageBox.Show("El se estaciono correctamente.", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cmdAplicacion.Enabled = true;
                                car2.Abort();
                            }
                        }
                    }
                }
                Thread.Sleep(20);
            }
        }


        public void DesestacionarCarro2()
        {
            car2 = new Thread(new ThreadStart(Desestacionar_carro2));
        }

        public void Desestacionar_carro2()
        {
            bool izquierda1 = true, abajo1 = true;
            while (true)
            {
                if (!Izquierda(pbCarro2, 690, izquierda1))
                {
                    if (izquierda1 == true)
                    {
                        pbCarro2.Size = new Size(56, 84);
                        pbCarro2.Image = Properties.Resources.carro2___abajo;
                        izquierda1 = false;
                    }
                    if (!Abajo(pbCarro2, pnLimAbajo.Location.Y, abajo1))
                    {
                        if (abajo1== true)
                        {
                            pbCarro2.Size = new Size(92, 55);
                            pbCarro2.Image = Properties.Resources.carro2___izquierda;
                            pbCarro2.Location = new Point(pbCarro2.Location.X - pbCarro2.Width, pbCarro2.Location.Y);
                            abajo1 = false;
                        }
                        if (!Izquierda(pbCarro2, 0 - pbCarro2.Width, true))
                        {
                            MessageBox.Show("El carro salio con exito.", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cmdAplicacion.Enabled = true;
                            car2.Abort();
                        }
                    }
                }
                Thread.Sleep(20);
            }
        }

        public void Estacionar_carro3()
        {
            bool derecha = true, abajo = true, derecha2 = false;
            while (true)
            {
                if (!Derecha(pbCarro3, pnAbajo.Location.X, derecha))
                {
                    if (derecha == true)
                    {
                        pbCarro3.Size = new Size(56, 84);
                        pbCarro3.Image = Properties.Resources.carro3___abajo;
                        derecha = false;
                    }
                    if (!Abajo(pbCarro3, 370, abajo))
                    {
                        if (abajo == true)
                        {
                            pbCarro3.Size = new Size(92, 55);
                            pbCarro3.Image = Properties.Resources.carro3___derecha;
                            pbCarro3.Location = new Point(690, 375);//690, 471
                            abajo = false;
                            derecha2 = true;
                        }
                        if (!Derecha(pbCarro3, 870, derecha2))
                        {
                            if (derecha2 == true)
                            {
                                pbCarro3.Size = new Size(92, 55);
                                pbCarro3.Image = Properties.Resources.carro3___derecha;
                                derecha2 = false;
                            }
                            if (!Derecha(pbCarro3, 870, true))
                            {
                                MessageBox.Show("El se estaciono correctamente.", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cmdAplicacion.Enabled = true;
                                car3.Abort();
                            }
                        }
                    }
                }
                Thread.Sleep(20);
            }
        }


        public void DesestacionarCarro3()
        {
            car3 = new Thread(new ThreadStart(Desestacionar_carro3));
        }

        public void Desestacionar_carro3()
        {
            bool izquierda1 = true, abajo1 = true;
            while (true)
            {
                if (!Izquierda(pbCarro3, 690, izquierda1))
                {
                    if (izquierda1 == true)
                    {
                        pbCarro3.Size = new Size(56, 84);
                        pbCarro3.Image = Properties.Resources.carro3___abajo;
                        izquierda1 = false;
                    }
                    if (!Abajo(pbCarro3, pnLimAbajo.Location.Y, abajo1))
                    {
                        if (abajo1 == true)
                        {
                            pbCarro3.Size = new Size(92, 55);
                            pbCarro3.Image = Properties.Resources.carro3___izquierda;
                            pbCarro3.Location = new Point(pbCarro3.Location.X - pbCarro3.Width, pbCarro3.Location.Y);
                            abajo1 = false;
                        }
                        if (!Izquierda(pbCarro3, 0 - pbCarro3.Width, true))
                        {
                            MessageBox.Show("El carro salio con exito.", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cmdAplicacion.Enabled = true;
                            car3.Abort();
                        }
                    }
                }
                Thread.Sleep(20);
            }
        }

        public void Estacionar_Carro4()
        {
            pbCarro4.Image = Properties.Resources.carro1___derecha;
            bool derecha = true, abajo = true, izquierda=true, arriba=true;
            while (true)
            {
                if (!Derecha(pbCarro4, pnAbajo.Location.X, derecha))
                {
                    if (derecha == true)
                    {
                        pbCarro4.Size = new Size(56, 84);
                        pbCarro4.Image = Properties.Resources.carro1___abajo;
                        derecha = false;
                    }
                    if (!Abajo(pbCarro4, pnLimAbajo.Location.Y, abajo))
                    {
                        if (abajo == true)
                        {
                            pbCarro4.Size = new Size(92, 55);
                            pbCarro4.Image = Properties.Resources.carro1__izquierda;
                            pbCarro4.Location = new Point(587, 494);//690, 471
                            abajo = false;
                           // derecha2 = true;
                        }
                        if (!Izquierda(pbCarro4, pbFlechaIzq.Location.X, izquierda))
                        {
                            if (izquierda == true)
                            {
                                pbCarro4.Size = new Size(56, 84);
                                pbCarro4.Image = Properties.Resources.carro1___arriba;
                                izquierda=false;
                            }
                            if(!Arriba(pbCarro4, 375, arriba))
                            {
                                if (arriba == true)
                                {
                                    pbCarro4.Size = new Size(92, 55);
                                    pbCarro4.Image = Properties.Resources.carro1___derecha;
                                    arriba=false;
                                }
                                if (!Derecha(pbCarro4, 486, true))
                                {
                                    MessageBox.Show("El se estaciono correctamente.", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    cmdAplicacion.Enabled = true;
                                    car4.Abort();
                                }
                            } 
                        }
                    }
                }
                Thread.Sleep(20);
            }
        }
        public void DesestacionarCarro4()
        {
            car4 = new Thread(new ThreadStart(Desestacionar_carro4));
        }
        public void Desestacionar_carro4()
        {
            bool izquierda1 = true, abajo1 = true;
            while (true)
            {
                if (!Izquierda(pbCarro4, 350, izquierda1))
                {
                    if (izquierda1 == true)
                    {
                        pbCarro4.Size = new Size(56, 84);
                        pbCarro4.Image = Properties.Resources.carro1___abajo;
                        izquierda1 = false;
                    }
                    if (!Abajo(pbCarro4, pnLimAbajo.Location.Y, abajo1))
                    {
                        if (abajo1 == true)
                        {
                            pbCarro4.Size = new Size(92, 55);
                            pbCarro4.Image = Properties.Resources.carro1__izquierda;
                            pbCarro4.Location = new Point(pbCarro4.Location.X - pbCarro4.Width, pbCarro4.Location.Y);
                            abajo1 = false;
                        }
                        if (!Izquierda(pbCarro4, 0 - pbCarro4.Width, true))
                        {
                            MessageBox.Show("El carro salio con exito.", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cmdAplicacion.Enabled = true;
                            car4.Abort();
                        }
                    }
                }
                Thread.Sleep(20);
            }
        }

        public void Estacionar_Carro5()
        {
            pbCarro5.Image = Properties.Resources.carro3___derecha;
            bool derecha1 = true, izquierda1 = true, abajo1 = true, arriba1 = true;
            while (true)
            {
                if (!Derecha(pbCarro5, pnAbajo.Location.X, derecha1))
                {
                    if (derecha1 == true)
                    {
                        pbCarro5.Size = new Size(56, 84);
                        pbCarro5.Image = Properties.Resources.carro3___abajo;
                        derecha1 = false;
                    }
                    if (!Abajo(pbCarro5, pnLimAbajo.Location.Y, abajo1))
                    {
                        if (abajo1 == true)
                        {
                            pbCarro5.Size = new Size(92, 55);
                            pbCarro5.Image = Properties.Resources.carro3___izquierda;
                            pbCarro5.Location = new Point(587, 494);//690, 471
                            abajo1 = false;
                        }
                        if (!Izquierda(pbCarro5, pbFlechaIzq.Location.X, izquierda1))
                        {
                            if (izquierda1 == true)
                            {
                                pbCarro5.Size = new Size(56, 84);
                                pbCarro5.Image = Properties.Resources.carro3___arriba;
                                izquierda1 = false;
                            }
                            if (!Arriba(pbCarro5, pbFlechaAriba.Location.Y, arriba1))
                            {
                                if (arriba1 == true)
                                {
                                    pbCarro5.Size = new Size(92, 55);
                                    pbCarro5.Image = Properties.Resources.carro3___derecha;
                                    arriba1 = false;
                                }
                                if (!Derecha(pbCarro5,511, true))
                                {
                                    MessageBox.Show("El se estaciono correctamente.", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    pantalla.Lugar = "Ninguno";
                                    cmdAplicacion.Enabled = true;
                                    car5.Abort();
                                }
                            }
                        }
                    }
                }
                Thread.Sleep(20);
            }
        }
        
        public void Desestacionar_Carro5()
        {
            bool izquierda1 = true, abajo1 = true;
            while (true)
            {
                if (!Izquierda(pbCarro5, 350, izquierda1))
                {
                    if (izquierda1 == true)
                    {
                        pbCarro5.Size = new Size(56, 84);
                        pbCarro5.Image = Properties.Resources.carro3___abajo;
                        pbCarro5.Visible = true;
                        izquierda1 = false;
                    }
                    if (!Abajo(pbCarro5, pnLimAbajo.Location.Y, abajo1))
                    {
                        if (abajo1 == true)
                        {
                            pbCarro5.Size = new Size(92, 55);
                            pbCarro5.Image = Properties.Resources.carro3___izquierda;
                            pbCarro5.Location = new Point(pbCarro5.Location.X - pbCarro5.Width, pbCarro5.Location.Y);
                            abajo1 = false;
                        }
                        if (!Izquierda(pbCarro5, 0 - pbCarro5.Width, true))
                        {
                                MessageBox.Show("El carro salio con exito.", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cmdAplicacion.Enabled = true;
                                car5.Abort();
                        }
                    }
                }
                Thread.Sleep(20);
            }
        }
        //public void Desestacionar_Carro5()
        //{
        //    bool izquierda1 = true, abajo1 = true;
        //    while (true)
        //    {
        //        if (!Izquierda(pbCarro5, 495, izquierda1))
        //        {
        //            if (izquierda1 == true)
        //            {
        //                pbCarro5.Size = new Size(56, 84);
        //                pbCarro5.Image = Properties.Resources.carro3___abajo;
        //                izquierda1 = false;
        //            }
        //            if (!Abajo(pbCarro5, pnLimAbajo.Location.Y, abajo1))
        //            {
        //                if (abajo1 == true)
        //                {
        //                    pbCarro5.Size = new Size(92, 55);
        //                    pbCarro5.Image = Properties.Resources.carro3___izquierda;
        //                    pbCarro5.Location = new Point(pbCarro5.Location.X - pbCarro5.Width, pbCarro5.Location.Y);
        //                    abajo1 = false;
        //                }
        //                if (!Izquierda(pbCarro5, 0 - pbCarro5.Width, true))
        //                {
        //                    MessageBox.Show("El carro salio con exito.", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                    cmdAplicacion.Enabled = true;
        //                    car5.Abort();
        //                }
        //            }
        //        }
        //        Thread.Sleep(20);
        //    }
        //}

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
            else if (pantalla.Lugar == pantalla.lblB1.Text)
            {
                if (pantalla.Accion == "Estacionar")
                {
                    pbCarro2.Visible = true;
                    EstacionarCarro2();
                    car2.Start();
                    cmdAplicacion.Enabled = false;

                    pantalla.B1.BackColor = Color.Crimson;
                }
            }
            else if (pantalla.Lugar == pantalla.lblB3.Text)
            {
                if (pantalla.Accion == "Estacionar")
                {
                    pbCarro3.Visible = true;
                    EstacionarCarro3();
                    car3.Start();
                    cmdAplicacion.Enabled = false;

                    pantalla.B3.BackColor = Color.Crimson;
                }
            }
            //Carro4
            else if (pantalla.Lugar == pantalla.lblA3.Text)
            {
                if (pantalla.Accion == "Estacionar")
                {
                    pbCarro4.Visible = true;
                    EstacionarCarro4();
                    car4.Start();
                    cmdAplicacion.Enabled = false;

                    pantalla.A3.BackColor = Color.Crimson;
                }
                else if (pantalla.Accion == "Descestacionar")
                {
                    DesestacionarCarro4();
                    car4.Start();
                    cmdAplicacion.Enabled = false;
                }
            }
            else if (pantalla.Lugar == pantalla.lblA1.Text)
            {
                if (pantalla.Accion == "Estacionar")
                {
                    pbCarro5.Visible = true;
                    EstacionarCarro5();
                    car5.Start();
                    cmdAplicacion.Enabled = false;

                    cmdAplicacion.Text = "" + car5.ThreadState.ToString();

                    pantalla.A1.BackColor = Color.Crimson;
                }
                else if (pantalla.Accion == "Descestacionar")
                {
                    pbCarro5.Visible = true;
                    DesestacionarCarro5();
                    car5.Start();
                    cmdAplicacion.Enabled = false;
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

            //Carro 1
            if (pantalla.Lugar == pantalla.lblA2.Text)
            {
                if(pantalla.Accion == "Estacionar")
                {
                    pbCarro1.Location = new Point(0 - pbCarro1.Width, 110);
                    pbCarro1.Visible = true;
                    EstacionarCarro1();
                    car1.Start();

                    pantalla.A2.BackColor = Color.Crimson;
                    pantalla.colorAnterior = Color.Crimson;

                    cmdAplicacion.Enabled = false;
                }
                else if(pantalla.Accion == "Descestacionar")
                {
                    DesestacionarCarro1();
                    car1.Start();
                    cmdAplicacion.Enabled = false;
                }

            }
            //Carro 2
            else if (pantalla.Lugar == pantalla.lblB1.Text)
            {
                if (pantalla.Accion == "Estacionar")
                {
                    pbCarro2.Location = new Point(0 - pbCarro2.Width, 110);
                    pbCarro2.Visible = true;
                    EstacionarCarro2();
                    car2.Start();

                    pantalla.B1.BackColor = Color.Crimson;
                    pantalla.colorAnterior = Color.Crimson;

                    cmdAplicacion.Enabled = false;
                }
                else if (pantalla.Accion == "Descestacionar")
                {
                    DesestacionarCarro2();
                    car2.Start();
                    cmdAplicacion.Enabled = false;
                }

            }

            //Carro 3
            else if(pantalla.Lugar == pantalla.lblB3.Text)
            {
                if (pantalla.Accion == "Estacionar")
                {
                    pbCarro3.Location = new Point(0 - pbCarro3.Width, 110);
                    pbCarro3.Visible = true;
                    EstacionarCarro3();
                    car3.Start();

                    pantalla.B3.BackColor = Color.Crimson;
                    pantalla.colorAnterior = Color.Crimson;

                    cmdAplicacion.Enabled = false;
                }
                else if (pantalla.Accion == "Descestacionar")
                {
                    DesestacionarCarro3();
                    car3.Start();
                    cmdAplicacion.Enabled = false;
                }

            }
            //else if (opcion == DialogResult.No)
            //{
            //    DesestacionarCarro1();
            //    car1.Start();
            //}
            //Carro 4
            else if (pantalla.Lugar == pantalla.lblA3.Text)
            {
                if (pantalla.Accion == "Estacionar")
                {
                    pbCarro4.Location = new Point(0 - pbCarro4.Width, 110);
                    pbCarro4.Visible = true;
                    EstacionarCarro4();
                    car4.Start();

                    pantalla.A3.BackColor = Color.Crimson;
                    pantalla.colorAnterior = Color.Crimson;

                    cmdAplicacion.Enabled = false;
                }
                else if (pantalla.Accion == "Descestacionar")
                {
                    DesestacionarCarro4();
                    car4.Start();
                    cmdAplicacion.Enabled = false;
                }
            }
            //carro 5
            else if (pantalla.Lugar == pantalla.lblA1.Text)
            {
                if (pantalla.Accion == "Estacionar")
                {
                    pbCarro5.Location = new Point(0 - pbCarro5.Width, 110);
                    pbCarro5.Visible = true;
                    EstacionarCarro5();
                    car5.Start();

                    pantalla.A1.BackColor = Color.Crimson;
                    pantalla.colorAnterior = Color.Crimson;

                    cmdAplicacion.Enabled = false;
                }
                else if (pantalla.Accion == "Descestacionar")
                {
                    DesestacionarCarro5();
                    car5.Start();

                    cmdAplicacion.Text = "" + car5.ThreadState.ToString();
                    cmdAplicacion.Enabled = false;
                }
            }
        }
    }
}
