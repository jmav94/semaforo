using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Semaforo
{
    public partial class Semaforos : Form
    {
        public Semaforos()
        {
            InitializeComponent();
        }

        int TiempoVerde = 10;
        int TiempoRojo = 0;
        int TiempoAmarillo = 3;
        int i;
        int x, y, a, b,c,d;
        bool Parpadear = false;
        bool Rojos = true;
        bool Parpadea = false;
        bool Cambio = true;
        bool CambioRojo = true;
        bool Rojo = true;
        bool Change = false;
        bool Change2 = false;
        int Red, Green, Yellow;
        int r = 0;
        int DireccionDePuerto = 888;
        public void ReiniciarVariables()
        {
            Parpadear = false;
            Rojos = true;
            Parpadea = false;
            Rojo = true;
            Cambio = true;
            CambioRojo = true;
            Change = false;
            Change2 = false;
            i = 0;
            x = 0;
            y = 0;
            a = 0;
            b = 0;
            c = 1;
            d = 1;
            Red = 1;
            Yellow = 1;
            Green = 1;
            r = 0;

        }
        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            
            if (btnEmpezar.Text == "Empezar")
            {
                btnEmpezar.Text = "Detener";
                PrimerSemaforo.Interval = 1000;
                if(chbAsignarTiempo.Checked == true)
                {
                    try
                    {
                        TiempoVerde = int.Parse(txtTiempoVerde.Text);
                    }catch
                    {
                        MessageBox.Show("Debe poner un numero en el tiempo Verde","Error", MessageBoxButtons.OK ,MessageBoxIcon.Error);
                        txtTiempoVerde.Text = "";
                        txtTiempoVerde.Focus();
                        btnEmpezar.Text = "Empezar";
                        return;

                    }
                    try
                    {
                        TiempoAmarillo = int.Parse(txtTiempoAmarillo.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Debe poner un numero en el tiempo Amarillo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtTiempoAmarillo.Text = "";
                        txtTiempoAmarillo.Focus();
                        btnEmpezar.Text = "Empezar";
                        return;
                        
                    }
                    
                    
                    TiempoRojo = TiempoVerde + TiempoAmarillo;
                    PrimerSemaforo.Enabled = true;
                    PrimerSemaforo.Start();

                }else
                {
                    PrimerSemaforo.Enabled = true;
                    PrimerSemaforo.Start();
                    TiempoRojo = TiempoVerde + TiempoAmarillo;
                }
               
                i = 0;
                x = 0;
                y = 0;
                a = 0;
                b = 0;
                c = 1;
                d = 1;
                Green = 1;
                Yellow = 1;
                Red = 1;
            }
            else
            {
                btnEmpezar.Text = "Empezar";
                

                //MIOS
                pbs1.Image = Semaforo.Properties.Resources.S1OFF;
                pbs2.Image = Semaforo.Properties.Resources.S2OFF;
                pbs3.Image = Semaforo.Properties.Resources.S3OFF;
                pbs4.Image = Semaforo.Properties.Resources.S4OFF;

                PuertoDeAcceso.Output(DireccionDePuerto, 0);
                PrimerSemaforo.Enabled = false;
                Rojos = true;
                pic7Seg.Image = Semaforo.Properties.Resources.CeroBlanco;

                //MIO
                pbDisplay.Image = Semaforo.Properties.Resources._0;
                ReiniciarVariables();
            }
        }
       
        private void PrimerSemaforo_Tick_1(object sender, EventArgs e)
        {
            PrimerSemaforo.Interval = 1000;
            if (i < TiempoVerde)
            {

                //MIOS
                pbs1.Image = Semaforo.Properties.Resources.S1RON;
                pbs2.Image = Semaforo.Properties.Resources.S2VON;
                pbs3.Image = Semaforo.Properties.Resources.S3RON;
                pbs4.Image = Semaforo.Properties.Resources.S4VON;

                //displayVerde(Green);

                //MIO
                Display(Green);
                PuertoDeAcceso.Output(DireccionDePuerto, 65); //Para mandar la instruccion de encender el Primer semaforo en verder
                Green++;

                i++;
            }
            else
            {
                PrimerSemaforo.Interval = 500;
                if (i == TiempoVerde)
                {
                    if (Cambio == true)
                    {
                        PrimerSemaforo.Interval = 250;//300

                        

                        //MIO
                        pbs2.Image = Semaforo.Properties.Resources.S2OFF;
                        pbs4.Image = Semaforo.Properties.Resources.S4OFF;

                        PuertoDeAcceso.Output(DireccionDePuerto, 64); // Para mandar la instruccion de poner en blanco el primer semaforo
                        Cambio = false;
                        c = 4;
                        c = 4;
                    }
                    else
                    {
                        Green = 1;

                        displayVerde(c);

                        //MIO
                        Display(c);

                        

                        //MIOS
                        pbs2.Image = Semaforo.Properties.Resources.S2VON;
                        pbs4.Image = Semaforo.Properties.Resources.S4VON;
                        PuertoDeAcceso.Output(DireccionDePuerto, 65); // Para que encienda el semaforo verde displayVerde(0);
                    }
                    if (c < 3)
                    {

                        if (Parpadear == true)
                        {
                            

                            //MIOS
                            pbs2.Image = Semaforo.Properties.Resources.S2OFF;
                            pbs4.Image = Semaforo.Properties.Resources.S4OFF;
                            PuertoDeAcceso.Output(DireccionDePuerto, 64); // Para mandar la instruccion de poner en blanco el primer semaforo
                            displayVerde(0);

                            //MIO
                            Display(0);
                            c++;
                            Parpadear = false;

                        }
                        else
                        {


                            Parpadear = true;
                        }

                    }
                    else
                    {
                        if (c != 4)
                        {
                            i++;

                        }
                        else
                        {
                            c = 1;
                        }


                    }


                }
                else
                {
                    if (CambioRojo == true)
                    {
                        

                        //MIOS
                        pbs2.Image = Semaforo.Properties.Resources.S2OFF;
                        pbs4.Image = Semaforo.Properties.Resources.S4OFF;
                        PuertoDeAcceso.Output(DireccionDePuerto, 64); // Para mandar la instruccion de poner en blanco el primer semaforo
                        CambioRojo = false;
                    }
                    else
                    {

                        PrimerSemaforo.Interval = 1000;
                        if (x < TiempoAmarillo)
                        {
                            

                            //MIOS
                            pbs2.Image = Semaforo.Properties.Resources.S2AON;
                            pbs4.Image = Semaforo.Properties.Resources.S4AON;
                            displayAmarillo(Yellow);

                            //MIO
                            Display(Yellow);
                            PuertoDeAcceso.Output(DireccionDePuerto, 66); //Para que encienda el semaforo Amarillo
                            Yellow++;
                            x++;
                            i++;
                        }
                        else
                        {
                            PrimerSemaforo.Interval = 1000;
                              if (y < TiempoRojo + 5)
                            {
                                Rojos = false;
                                
                                if (Rojos == true)
                                {
                                    Yellow = 1;                              
                                    //MIOS
                                    pbs2.Image = Semaforo.Properties.Resources.S2RON;
                                    pbs4.Image = Semaforo.Properties.Resources.S4RON;

                                    //MIO
                                    Display(Red);
                                    displayRojo(Red);
                                    PuertoDeAcceso.Output(DireccionDePuerto, 72); //Para que encienda el semaforo Rojo
                                    r = 1;
                                    Rojos = false;
                                    //if (r == 1)
                                    //{
                                    //    Rojos = false;
                                        //pbDisplay.Image = Semaforo.Properties.Resources._2;
                                        //r = 0;
                                    //}
                                    //else
                                    //{
                                    //    Rojos = true;
                                      //  pbs2.Image = Semaforo.Properties.Resources.S2RON;
                                       // pbs4.Image = Semaforo.Properties.Resources.S4RON;
                                      
                                       // Display(2);
                                    //    r++;
                                    //}
                                }
                                else
                                {
                                    y++;
                                    i++;
                                    
                                    pbs2.Image = Semaforo.Properties.Resources.S2RON;
                                    pbs4.Image = Semaforo.Properties.Resources.S4RON;
                                    PuertoDeAcceso.Output(DireccionDePuerto, 72);
                                    CambioDeSemaforo();
                                }

                            }
                            /*
                             else
                            {


                            }
                            */
                        }
                    }
                }
            }
        }
        public void CambioDeSemaforo()
        {
            PrimerSemaforo.Interval = 1000;
            if (a < TiempoVerde)
            {
                //MIO
                pbs3.Image = Semaforo.Properties.Resources.S3VON;
                pbs1.Image = Semaforo.Properties.Resources.S1VON;
                displayVerde(Green);

                //MIO
                Display(Green);
                Green++;
                PuertoDeAcceso.Output(DireccionDePuerto, 24);
                a++;
                i++;
            }
            else
            {
                PrimerSemaforo.Interval = 500;
                if (a == TiempoVerde)
                {

                    if (Change == false)
                    {
                        PrimerSemaforo.Interval = 250;//300
                        
                        //MIOS
                        pbs3.Image = Semaforo.Properties.Resources.S3OFF;
                        pbs1.Image = Semaforo.Properties.Resources.S1OFF;
                        PuertoDeAcceso.Output(DireccionDePuerto, 8);
                        Change = true;
                        d = 4;
                    }
                    else
                    {
                        
                        //MIOS
                        pbs3.Image = Semaforo.Properties.Resources.S3VON;
                        pbs1.Image = Semaforo.Properties.Resources.S1VON;
                        PuertoDeAcceso.Output(DireccionDePuerto, 24);
                        displayVerde(d);
                        //MIO
                        Display(d);
                    }



                    if (d < 3)
                    {

                        if (Parpadea == true)
                        {
                            //MIOS
                            pbs3.Image = Semaforo.Properties.Resources.S3OFF;
                            pbs1.Image = Semaforo.Properties.Resources.S1OFF;
                            //MIO
                            Display(0);
                            displayVerde(0);
                            PuertoDeAcceso.Output(DireccionDePuerto, 8);


                            d++;


                            Parpadea = false;
                            y--;

                        }
                        else
                        {
                            Parpadea = true;
                        }

                    }
                    else
                    {
                        if (d != 4)
                        {
                            a++;
                        }
                        else
                        {
                            d = 1;
                        }


                    }
                }
                else
                {
                    if (Change2 == false)
                    {
                        PrimerSemaforo.Interval = 200;//200
                        //MIOS
                        pbs3.Image = Semaforo.Properties.Resources.S3OFF;
                        pbs1.Image = Semaforo.Properties.Resources.S1OFF;
                        PuertoDeAcceso.Output(DireccionDePuerto, 8);
                        Change2 = true;

                    }
                    else
                    {
                        PrimerSemaforo.Interval = 1000;


                        if (b < TiempoAmarillo)
                        {
                            //MIOS
                            pbs3.Image = Semaforo.Properties.Resources.S3AON;
                            pbs1.Image = Semaforo.Properties.Resources.S1AON;
                            //displayAmarillo(Yellow);
                            //MIO
                            Display(Yellow - 3);
                            PuertoDeAcceso.Output(DireccionDePuerto, 40);//Para que encienda el amarillo en horizontal.
                            Yellow++;
                            b++;
                            i++;
                            y--;
                            if (b == TiempoAmarillo)
                            {
                                ReiniciarVariables();
                            }


                        }
                        
                        
                        /*else
                        {

                            //PrimerSemaforo.Interval = 1000;
                            ReiniciarVariables();
                            
                            //pbs2.Image = Semaforo.Properties.Resources.S2RON;
                            //pbs4.Image = Semaforo.Properties.Resources.S4RON;

                            //Display(2);
                            if (Rojo == true)
                            {


                                
                                //MIOS
                                pbs3.Image = Semaforo.Properties.Resources.S3RON;
                                pbs1.Image = Semaforo.Properties.Resources.S1RON;
                                //displayRojo(Red);

                                //MIO
                                Display(Red);
                                PuertoDeAcceso.Output(DireccionDePuerto, 64);//Rojo en Horizontal.
                                //if (r == 1)
                                //{
                                //    Rojo = false;
                                //    pbDisplay.Image = Semaforo.Properties.Resources._2;
                                //    ReiniciarVariables();
                                //}
                                //else
                                //{
                                //    Rojo = true;
                                    //  pbs2.Image = Semaforo.Properties.Resources.S2RON;
                                    // pbs4.Image = Semaforo.Properties.Resources.S4RON;

                                    // Display(2);
                                 //   r++;
                                //}

                            }
                            else
                            {
                                //MIOS
                                
                                //pbs3.Image = Semaforo.Properties.Resources.S3RON;
                                //pbs1.Image = Semaforo.Properties.Resources.S1RON;
                                //pbs2.Image = Semaforo.Properties.Resources.S2RON;
                                //pbs4.Image = Semaforo.Properties.Resources.S4RON;
                                //PuertoDeAcceso.Output(DireccionDePuerto, 72);
                                
                                ReiniciarVariables();


                            }

                        }*/
                        
                    }
                }
            }
        }
        private void Display(int color)
        {
            switch (color)
            {
                case 1:
                    pbDisplay.Image = Semaforo.Properties.Resources._1;
                    break;
                case 2:
                    pbDisplay.Image = Semaforo.Properties.Resources._2;
                    break;
                case 3:
                    pbDisplay.Image = Semaforo.Properties.Resources._3;
                    break;
                case 4:
                    pbDisplay.Image = Semaforo.Properties.Resources._4;
                    break;
                case 5:
                    pbDisplay.Image = Semaforo.Properties.Resources._5;
                    break;
                case 6:
                    pbDisplay.Image = Semaforo.Properties.Resources._6;
                    break;
                case 7:
                    pbDisplay.Image = Semaforo.Properties.Resources._7;
                    break;
                case 8:
                    pbDisplay.Image = Semaforo.Properties.Resources._8;
                    break;
                case 9:
                    pbDisplay.Image = Semaforo.Properties.Resources._9;
                    break;
                case 10:
                    pbDisplay.Image = Semaforo.Properties.Resources._0;
                    break;
                    //default:
                    //    pbDisplay.Image = Semaforo.Properties.Resources._0;
                    //    break;

            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void chbAsignarTiempo_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAsignarTiempo.Checked == true)
            {
                gpTiempo.Visible = true;
                txtTiempoVerde.Enabled = true;
                txtTiempoAmarillo.Enabled = true;

            }
            else
            {
                gpTiempo.Visible = false;
                txtTiempoVerde.Enabled = false;
                txtTiempoAmarillo.Enabled = false;
            }
        }

        private void btnNoche_Click(object sender, EventArgs e)
        {
            if (btnNoche.Text == "Amarillos")
            {
                btnNoche.Text = "Terminar";
                TimNoche.Interval = 250;
                if (chbAsignarTiempo.Checked == true)
                {
                    try
                    {
                        TiempoVerde = int.Parse(txtTiempoVerde.Text);
                        MessageBox.Show("Para la noche no se puede poner tiempo al led verde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtTiempoVerde.Text = "";
                        txtTiempoAmarillo.Focus();
                        btnNoche.Text = "Amarillos";
                        return;
                    }
                    catch
                    {
                        MessageBox.Show("Para la noche no se puede poner tiempo al led verde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtTiempoVerde.Text = "";
                        txtTiempoAmarillo.Focus();
                        btnNoche.Text = "Noche";
                        return;

                    }
                    try
                    {
                        TiempoAmarillo = int.Parse(txtTiempoAmarillo.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Debe poner un numero en el tiempo Amarillo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtTiempoAmarillo.Text = "";
                        txtTiempoAmarillo.Focus();
                        btnNoche.Text = "Noche";
                        return;

                    }



                    TimNoche.Enabled = true;
                    TimNoche.Start();

                }
                else
                {

                    TiempoAmarillo = 3;
                    TimNoche.Enabled = true;
                    TimNoche.Start();

                }

                i = 0;
                x = 0;
                y = 1;
            }
            else
            {
                btnNoche.Text = "Noche";

                //MIOS
                pbs3.Image = Semaforo.Properties.Resources.S3OFF;
                pbs1.Image = Semaforo.Properties.Resources.S1OFF;
                pbs2.Image = Semaforo.Properties.Resources.S2OFF;
                pbs4.Image = Semaforo.Properties.Resources.S4OFF;

                pic7Seg.Image = Semaforo.Properties.Resources.CeroBlanco;

                //MIO
                pbDisplay.Image = Semaforo.Properties.Resources._0;
                PuertoDeAcceso.Output(DireccionDePuerto, 0);
                TimNoche.Enabled = false;
            }







        }

        private void TimNoche_Tick(object sender, EventArgs e)
        {

            if (i < TiempoAmarillo)
            {

                //MIOS
                pbs3.Image = Semaforo.Properties.Resources.S3AON;
                pbs1.Image = Semaforo.Properties.Resources.S1AON;
                pbs2.Image = Semaforo.Properties.Resources.S2AON;
                pbs4.Image = Semaforo.Properties.Resources.S4AON;
                PuertoDeAcceso.Output(DireccionDePuerto, 34);
                displayAmarillo(1);

                //MIO
                Display(1);
                i++;
            }
            else
            {
                if (x < y)
                {

                    //MIOS
                    pbs3.Image = Semaforo.Properties.Resources.S3OFF;
                    pbs1.Image = Semaforo.Properties.Resources.S1OFF;
                    pbs2.Image = Semaforo.Properties.Resources.S2OFF;
                    pbs4.Image = Semaforo.Properties.Resources.S4OFF;
                    PuertoDeAcceso.Output(DireccionDePuerto, 0);
                    displayAmarillo(0);

                    //MIO
                    Display(0);
                    x++;
                }
                else
                {
                    i = 0;
                    x = 0;
                }
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //if(chbAsignarTiempo.Checked != true)
            //{
            //    gpTiempo.Visible = false;
            //}
            //try
            //{
            //    Reiniciar_Leds();
            //}catch(Exception f)
            //{
            //    MessageBox.Show("Esta fallando la libreria"+ f.Message);
            //}
            //MessageBox.Show("Version 5.7");   
        }

        private void pbDisplay_Click(object sender, EventArgs e)
        {

        }

        private void Reiniciar_Leds()
        {
            PuertoDeAcceso.Output(DireccionDePuerto,0);
        }

        private void btnprobar_Click(object sender, EventArgs e)
        {
            if(btnprobar.Text == "Probar")
            {
                btnprobar.Text = "Probar_primer_Verde";
                PuertoDeAcceso.Output(DireccionDePuerto, 255);
            }
            else
            {
                if (btnprobar.Text == "Probar_primer_Verde")
                {
                    btnprobar.Text = "Probar_primer_Amarillo";
                    PuertoDeAcceso.Output(DireccionDePuerto, 1);
                }
                else
                {
                    if(btnprobar.Text == "Probar_primer_Amarillo")
                    {
                        btnprobar.Text = "Probar_primer_Rojo";
                        PuertoDeAcceso.Output(DireccionDePuerto, 2);
                    }
                    else
                    {
                        if (btnprobar.Text == "Probar_primer_Rojo")
                        {
                            btnprobar.Text = "Probar_segundo_Verde";
                            PuertoDeAcceso.Output(DireccionDePuerto, 4);
                        }
                        else
                        {
                            if (btnprobar.Text == "Probar_segundo_Verde")
                            {
                                btnprobar.Text = "Probar_segundo_Amarillo";
                                PuertoDeAcceso.Output(DireccionDePuerto, 8);
                            }
                            else
                            {
                                if (btnprobar.Text == "Probar_segundo_Amarillo")
                                {
                                    btnprobar.Text = "Probar_segundo_Rojo";
                                    PuertoDeAcceso.Output(DireccionDePuerto, 16);
                                }
                                else
                                {
                                    if (btnprobar.Text == "Probar_segundo_Rojo")
                                    {
                                        btnprobar.Text = "Blanco";
                                        PuertoDeAcceso.Output(DireccionDePuerto, 32);
                                    }
                                    else
                                    {
                                        if(btnprobar.Text == "Blanco")
                                        {
                                            btnprobar.Text = "Probar";
                                            PuertoDeAcceso.Output(DireccionDePuerto,0);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            
        }

        private void displayVerde(int color)
        {
            switch(color)
            {
                case 1:
                    pic7Seg.Image = Semaforo.Properties.Resources.verde1;
                    break;
                case 2:
                    pic7Seg.Image = Semaforo.Properties.Resources.verde2;
                    break;
                case 3:
                    pic7Seg.Image = Semaforo.Properties.Resources.verde3;
                    break;

                case 4:
                    pic7Seg.Image = Semaforo.Properties.Resources.verde4;
                    break;
                case 5:
                    pic7Seg.Image = Semaforo.Properties.Resources.verde5;
                    break;
                case 6:
                    pic7Seg.Image = Semaforo.Properties.Resources.verde6;
                    break;

                case 7:
                    pic7Seg.Image = Semaforo.Properties.Resources.verde7;
                    break;
                case 8:
                    pic7Seg.Image = Semaforo.Properties.Resources.verde8;
                    break;
                case 9:
                    pic7Seg.Image = Semaforo.Properties.Resources.verde9;
                    break;

                default:
                    pic7Seg.Image = Semaforo.Properties.Resources.CeroBlanco;
                    break;

            }

        }

        private void displayAmarillo(int color)
        {
            switch (color)
            {
                case 1:
                    pic7Seg.Image = Semaforo.Properties.Resources.Amarillo1;
                    break;
                case 2:
                    pic7Seg.Image = Semaforo.Properties.Resources.Amarillo2;
                    break;
                case 3:
                    pic7Seg.Image = Semaforo.Properties.Resources.Amarillo3;
                    break;

                case 4:
                    pic7Seg.Image = Semaforo.Properties.Resources.Amarillo4;
                    break;
                case 5:
                    pic7Seg.Image = Semaforo.Properties.Resources.Amarillo5;
                    break;
                case 6:
                    pic7Seg.Image = Semaforo.Properties.Resources.Amarillo6;
                    break;

                case 7:
                    pic7Seg.Image = Semaforo.Properties.Resources.Amarillo7;
                    break;
                case 8:
                    pic7Seg.Image = Semaforo.Properties.Resources.Amarillo8;
                    break;
                case 9:
                    pic7Seg.Image = Semaforo.Properties.Resources.Amarillo9;
                    break;

                default:
                    pic7Seg.Image = Semaforo.Properties.Resources.CeroBlanco;
                    break;

            }
        }

        private void displayRojo(int color)
        {
            switch (color)
            {
                case 1:
                    pic7Seg.Image = Semaforo.Properties.Resources.rojo1;
                    break;
                case 2:
                    pic7Seg.Image = Semaforo.Properties.Resources.rojo2;
                    break;
                case 3:
                    pic7Seg.Image = Semaforo.Properties.Resources.rojo3;
                    break;

                case 4:
                    pic7Seg.Image = Semaforo.Properties.Resources.rojo4;
                    break;
                case 5:
                    pic7Seg.Image = Semaforo.Properties.Resources.rojo5;
                    break;
                case 6:
                    pic7Seg.Image = Semaforo.Properties.Resources.rojo6;
                    break;

            //    case 7:
            //        pic7Seg.Image = Semaforo.Properties.Resources.rojo7;
            //        break;
            //    case 8:
            //        pic7Seg.Image = Semaforo.Properties.Resources.rojo8;
            //        break;
            //case 9:
            //     pic7Seg.Image = Semaforo.Properties.Resources.rojo9;
            //        break;

                default:
                    pic7Seg.Image = Semaforo.Properties.Resources.CeroBlanco;
                    break;

            }
        }

        private void pbs2_Click(object sender, EventArgs e)
        {

        }

    }
}
