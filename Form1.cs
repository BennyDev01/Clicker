using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clicker_V1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //variables 
        public int click = 0;
        public int multiplyer = 0;
        public int pog = 0;
        public int timer = 0;
        public bool stop1 = false;
        public bool stop2 = true;
        public bool stop3 = true;
        public bool stop4 = true;
        public bool stop5 = true;



        private void Form1_Load(object sender, EventArgs e)
        {
            //start
            timer1.Start();

        }


        public void button1_Click(object sender, EventArgs e)
        {
            //click O.o
            click++;

            //shows clicks
            string clicks = click.ToString();
            label3.Text = "Total Clicks: " + clicks;

            if (click >= 100 && stop1 == false)
            {
                //change color
                Form1 form = new Form1();
                this.BackColor = System.Drawing.Color.DarkCyan;

                //1 extra cps :D
                click++;
                label4.Text = "Click Multiplayer x2";

                if (click >= 500)
                {
                    stop1 = true;
                    stop2 = false;
                }
                   
            }
            else if (click >= 500 && stop2 == false)
            {
                //increase multiplayer
                multiplyer = 2;
                label4.Text = "Click Multiplayer x3";

                //change color
                this.BackColor = System.Drawing.Color.Purple;

                for (int i = 0; i < multiplyer; i++)
                {
                    //3 extra cps :D
                    click++;
                }

                if (click >= 1000)
                {
                    stop2 = true;
                    stop3 = false;

                }
            }
            else if (click >= 1000 && stop3 == false)
            {
                //increase multiplayer
                multiplyer = 3;
                label4.Text = "Click Multiplayer x4";

                //change color
                this.BackColor = System.Drawing.Color.Green;

                for (int i = 0; i < multiplyer; i++)
                {
                    //3 extra cps :D
                    click++;
                }

                if (click >= 5000)
                {
                    stop3 = true;
                    stop4 = false;

                }


            }
            else if (click >= 5000 && stop4 == false)
            {
                //increase multiplayer
                multiplyer = 4;
                label4.Text = "Click Multiplayer x5";

                //change color
                this.BackColor = System.Drawing.Color.Orange;

                for (int i = 0; i < multiplyer; i++)
                {
                    //4 extra cps :D
                    click++;
                }

                if (click >= 10000)
                {
                    stop4 = true;
                    stop5 = false;

                }



            }
            else if (click >= 10000 && stop4 == false)
            {
                //WIN
                
                //increase multiplayer
                label4.Text = "Click Multiplayer x6";

                //change color
                this.BackColor = System.Drawing.Color.Gold;

                

                
            }


        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            //increase time
            timer++;

            //display time
            label9.Text = "Seconds Played: " + timer;
        }

        
    }
}
