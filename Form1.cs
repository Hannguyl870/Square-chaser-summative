//Hannah Guylee
//square chasing video game
//Nov ,2023
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Square_chaser_summative
{
    public partial class Squarechaser : Form
    {
        int playerScore = 0;
        int playerSpeed = 4;

        int counter = 0;
       

        bool wDown = false;
        bool sDown = false;
        bool upArrowDown = false;
        bool downArrowDown = false;
        bool dDown = false;
        bool aDown = false;
        bool leftarrowDown = false;
        bool rightarrowDown = false;

        Rectangle player = new Rectangle(280, 200, 30, 30);
        Rectangle redsquare = new Rectangle(110, 195, 15, 15);
        Rectangle greensquare = new Rectangle(200, 110, 10, 10);

        SolidBrush lightblueBrush = new SolidBrush(Color.LightBlue);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush greenyBrush = new SolidBrush(Color.GreenYellow);

        Random randGen = new Random();
        Stopwatch mywatch = new Stopwatch();



        public Squarechaser()
        {
            InitializeComponent();
            loselable.Visible = false;


        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Left:
                    leftarrowDown = true;
                    break;
                case Keys.Right:
                    rightarrowDown = true;
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Right:
                    rightarrowDown = false;
                    break;
                case Keys.Left:
                    leftarrowDown = false;
                    break;
            }
        }

        private void Squarechaser_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(lightblueBrush, player);
            e.Graphics.FillRectangle(redBrush, redsquare);
            e.Graphics.FillRectangle(greenyBrush, greensquare);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //move player 
            if (wDown == true && player.Y > 0)
            {
                player.Y -= playerSpeed;
            }

            if (sDown == true && player.Y < this.Height - player.Height)
            {
                player.Y += playerSpeed;
            }

            if (aDown == true && player.X > 0)
            {
                player.X -= playerSpeed;
            }

            if (dDown == true && player.X < this.Width - player.Width)
            {
                player.X += playerSpeed;
            }

            if (upArrowDown == true && player.Y > 0)
            {
                player.Y -= playerSpeed;
            }
            if (downArrowDown == true && player.Y < this.Height - player.Height)
            {
                player.Y += playerSpeed;
            }

            if (leftarrowDown == true && player.X > 0)
            {
                player.X -= playerSpeed;
            }

            if (rightarrowDown == true && player.X < this.Width - player.Width)
            {
                player.X += playerSpeed;
            }

            //check if player has intersected with anything 
            if (player.IntersectsWith(greensquare))
            {
                playerScore++;
                scorelable.Text = $"{playerScore}";

                greensquare.X = randGen.Next(10, 580);
                greensquare.Y = randGen.Next(10, 340);

            }
            if (player.IntersectsWith(redsquare))
            {
                playerScore--;
                scorelable.Text = $"{playerScore}";

                redsquare.X = randGen.Next(10, 580);
                redsquare.Y = randGen.Next(10, 340);

            }
            //genertate random red squares every 100
            //if ( % 100 == 0)
            //{

            //}

            //win or lose
            if (playerScore < 0)
            {
                gamertimer.Enabled = false;
                loselable.Visible = true;
                loselable.Text = "You Lose";
            }
            if (playerScore == 10)
            {
                gamertimer.Enabled = false;
                loselable.Visible = true;
                loselable.Text = "You  Win!!";
            }

            Refresh();  

        }

       
    }
}
