using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamiento
{
    public partial class Pantalla : Form
    {
        public Pantalla()
        {
            InitializeComponent();
        }

        private void Pantalla_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdEstacionar_Click(object sender, EventArgs e)
        {
            if(Lugar == "Ninguno")
            {
                MessageBox.Show($"Primero debe elegir un lugar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Accion = "";
            }
            else if( estado == "Ocupado")
            {
                MessageBox.Show($"Lo sentimos, el lugar {pnAnterior.Name} ya esta ocupado, intente elegir otro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                Accion = "Estacionar";
                if (Lugar == "A1")
                {
                    //A2.BackColor = Color.Crimson;
                    carro5 = "Estacionado";
                }
                else if (Lugar == "A2")
                {
                    //A2.BackColor = Color.Crimson;
                    carro1 = "Estacionado";
                }
                else if (Lugar == "A3")
                {
                    //A2.BackColor = Color.Crimson;
                    carro4 = "Estacionado";
                }
                else if (Lugar == "B1")
                {
                    //A2.BackColor = Color.Crimson;
                    carro2 = "Estacionado";
                }
                else if (Lugar == "B3")
                {
                    //A2.BackColor = Color.Crimson;
                    carro3 = "Estacionado";
                }
                this.Close();
            }
        }

        string carro1 = "Descestacionado", carro2 = "Descestacionado", carro3 = "Descestacionado", carro4="Descestacionado",carro5="Descestacionado";
        private void cmdDesestacionar_Click(object sender, EventArgs e)
        {
            if (Lugar == "Ninguno")
            {
                MessageBox.Show($"Primero debe elegir un lugar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Accion = "";
            }
            else if (estado == "Vacio")
            {
                MessageBox.Show($"Lo sentimos, el lugar {pnAnterior.Name} no tiene ningun carro, intente elegir otro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                Accion = "Descestacionar";

                if (Lugar == "A2")
                {
                    //A2.BackColor = Color.Crimson;
                    carro1 = "Descestacionado";
                }
                else if(Lugar == "B1")
                {
                    carro2 = "Descestacionado";
                }
                else if (Lugar == "B3")
                {
                    carro3 = "Descestacionado";
                }
                else if (Lugar == "A3")
                {
                    carro4 = "Descestacionado";
                }
                else if (Lugar == "A1")
                {
                    carro5 = "Descestacionado";
                }
                this.Close();
            }
        }

        public string Lugar = "Ninguno";
        public string Accion = "", estado = "";

        public bool Ocupado(Label lbl, Panel panel)
        {
            if(panel.BackColor == Color.Crimson)
            {
                Lugar = lbl.Text;
                estado = "Ocupado";
                return true;
            }
            else
            {
                estado = "Vacio";
                Lugar = lbl.Text;
                return false;
            }
        }

        private void A1_Click(object sender, EventArgs e)
        {
            if (!Ocupado(lblA1, A1))
            { CambiarFoco(pnAnterior);
                colorAnterior = A1.BackColor;
               
                PonerFoco(A1);
                pnAnterior = pnActual;
            }
            else
            {CambiarFoco(pnAnterior);
                colorAnterior = A1.BackColor;
                PonerFocoOcupado(A1);
                
                pnAnterior = pnActual;
            }
        }
        private void A2_Click(object sender, EventArgs e)
        {
           if(!Ocupado(lblA2, A2))
            {
                CambiarFoco(pnAnterior);
                colorAnterior = A2.BackColor;
                PonerFoco(A2);
                pnAnterior = pnActual;
            }
            else
            {
                CambiarFoco(pnAnterior);
                colorAnterior = A2.BackColor;
                PonerFocoOcupado(A2);
                pnAnterior = pnActual;
            }
        }
        private void A3_Click(object sender, EventArgs e)
        {
            if (!Ocupado(lblA3, A3))
            {
                CambiarFoco(pnAnterior);
                colorAnterior = A3.BackColor; 
                PonerFoco(A3);
                pnAnterior = pnActual;
            }
            else
            {
                CambiarFoco(pnAnterior);
                colorAnterior = A3.BackColor;
                PonerFocoOcupado(A3);
                pnAnterior = pnActual;
            }
        }
        private void B1_Click(object sender, EventArgs e)
        {
            //CambiarFoco();            
            if (!Ocupado(lblB1, B1))
            {
                CambiarFoco(pnAnterior);
                colorAnterior = B1.BackColor;
                PonerFoco(B1);
                pnAnterior = pnActual;
            }
            else
            {
                CambiarFoco(pnAnterior);
                colorAnterior = B1.BackColor;
                PonerFocoOcupado(B1);
                pnAnterior = pnActual;
            }
        }
        private void B2_Click(object sender, EventArgs e)
        {
            if (!Ocupado(lblB2, B2))
            {
                CambiarFoco(pnAnterior);
                colorAnterior = B2.BackColor;
                PonerFoco(B2);
                pnAnterior = pnActual;
            }
            else
            {
                CambiarFoco(pnAnterior);
                colorAnterior = B2.BackColor;
                PonerFocoOcupado(B2);
                pnAnterior = pnActual;
            }
        }
        private void B3_Click(object sender, EventArgs e)
        {
            //CambiarFoco();
            if (!Ocupado(lblB3, B3))
            {
                CambiarFoco(pnAnterior);
                colorAnterior = B3.BackColor;
                PonerFoco(B3);
                pnAnterior = pnActual;
            }
            else
            {
                CambiarFoco(pnAnterior);
                colorAnterior = B3.BackColor;
                PonerFocoOcupado(B3);
                pnAnterior = pnActual;
            }
        }

        Panel pnAnterior, pnActual;

        private void A1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void A2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void B1_Paint(object sender, PaintEventArgs e)
        {

        }

        public Color colorAnterior;
        public void CambiarFoco(Panel panelAN)
        {
            if (panelAN != null)
            {
                panelAN.BackColor = colorAnterior;
            }
        }

        public void PonerFoco(Panel panel)
        {
            pnActual = panel;
            panel.BackColor = Color.YellowGreen;
        }
        public void PonerFocoOcupado(Panel panel)
        {
            pnActual = panel;
            panel.BackColor = Color.HotPink;
        }
    }
}
