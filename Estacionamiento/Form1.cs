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

        bool entrada = true, izquierda=true, abajo =true, arriba = true;
        public void Funcion_carro1()
        {
            while (true)
            {
                if (pbCarro1.Location.X < pnAbajo.Location.X && entrada == true)
                {
                    pbCarro1.Location = new Point(pbCarro1.Location.X + 7, pbCarro1.Location.Y);
                    button1.Text = "DEre";
                }
                else
                {
                    if(entrada == true)
                    {
                        pbCarro1.Size = new Size(56, 84);
                        pbCarro1.Image = Properties.Resources.carro1___abajo;
                        entrada = false;
                    }
                    

                    if (pbCarro1.Location.Y < 471 && abajo == true)
                    {
                        pbCarro1.Location = new Point(pbCarro1.Location.X, pbCarro1.Location.Y + 7);
                        button1.Text = "abajo";
                    }
                    else
                    {
                        if(abajo == true)
                        {
                            pbCarro1.Size = new Size(92, 55);
                            pbCarro1.Image = Properties.Resources.carro1__izquierda;
                            pbCarro1.Location = new Point(587, 494);
                            abajo = false;
                        } 

                        if (pbCarro1.Location.X > pbFlechaIzq.Location.X && izquierda == true)
                        {
                            button1.Text = "" + pbFlechaIzq.Location;
                            pbCarro1.Location = new Point(pbCarro1.Location.X - 7, pbCarro1.Location.Y);
                        }
                        else
                        {
                            if (izquierda == true)
                            {
                                pbCarro1.Size = new Size(56, 84);
                                pbCarro1.Image = Properties.Resources.carro1___arriba;
                                izquierda = false;
                            }

                            if (pbCarro1.Location.Y > pbFlechaAriba.Location.Y && arriba == true)
                            {
                                pbCarro1.Location = new Point(pbCarro1.Location.X, pbCarro1.Location.Y -7);
                            }
                            else
                            {
                                if (arriba == true)
                                {
                                    pbCarro1.Size = new Size(92, 55);
                                    pbCarro1.Image = Properties.Resources.carro1___arriba;
                                    arriba = false;
                                }

                                button1.Text = "Abortado";
                                car1.Abort();
                            }

                            
                        }
                        
                    }
                    //Abortar1 = false;
                    //sobrevivientes++;
                    //lblCaracol.Visible = true;
                    //lblCaracol.Text = "Pepe el caracol SOBREVIVIO";
                    

                }

                Thread.Sleep(20);
            }
        }

        public void UpdateCarro1()
        {
            car1 = new Thread(new ThreadStart(Funcion_carro1));
        }

        public void UpdateCarro2()
        {

        }

        public void UpdateCarro3()
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            pbCarro1.Visible = true;
            
            UpdateCarro1();
            car1.Start();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
