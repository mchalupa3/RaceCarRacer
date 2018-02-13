using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceCarRacer
{                   
    
    public partial class Form1 : Form
    {
        int redCarWins = 0;
        int yellowCarWins = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
           Random rnd = new Random();
           
                lblRaceResult.Text = "";
               

               for (int i = 1; i <= 7; i++)
                {
                int xOfYellowCar = picYellowCar.Location.X;
                int yOfYellowCar = picYellowCar.Location.Y;
                int xOfRedCar = PicRedCar.Location.X;
                int yOfRedCar = PicRedCar.Location.Y;
                System.Threading.Thread.Sleep(350);
                int redCarRandom = rnd.Next(85, 100);
                int yellowCarRandom = rnd.Next(85, 100);
                picYellowCar.Location = new Point(xOfYellowCar + yellowCarRandom, yOfYellowCar);
                PicRedCar.Location = new Point(xOfRedCar + redCarRandom, yOfRedCar);

                  
                }


               if (picYellowCar.Location.X < PicRedCar.Location.X )
               {
                   lblRaceResult.Text = "Red Car Wins!";
                   redCarWins = redCarWins + 1;
                   lblRedWins.Text = "Red Wins: " + redCarWins;
               }

               if (picYellowCar.Location.X > PicRedCar.Location.X )
               {
                   lblRaceResult.Text = "Yellow Car Wins!";
                   yellowCarWins = yellowCarWins + 1;
                   lblYellowWins.Text = "Yellow wins: " + yellowCarWins;
               }
               if (picYellowCar.Location.X ==PicRedCar.Location.X )
               {
                   lblRaceResult.Text = "Its a Tie!";
               }
           
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            picYellowCar.Location = new Point(100, 150);
            PicRedCar.Location = new Point(100, 250);
        }
    }
}
