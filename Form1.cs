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
using System.Media;
using System.Windows.Forms;

namespace Square_chaser_summative
{
    public partial class Squarechaser : Form
    {
        int playerScore = 0;
        int playerSpeed = 4;

        SoundPlayer sp;


        bool wDown = false;
        bool sDown = false;
        bool upArrowDown = false;
        bool downArrowDown = false;
        bool dDown = false;
        bool aDown = false;
        bool leftarrowDown = false;
        bool rightarrowDown = false;

        Rectangle player = new Rectangle(280, 200, 30, 30);

        Rectangle red1 = new Rectangle(110, 195, 15, 15);
        Rectangle red2 = new Rectangle(-15,-15,15,15);
        Rectangle red3 = new Rectangle(-15, -15, 15,15);
        Rectangle red4 = new Rectangle(-15, -15, 15, 15);
        Rectangle red5 = new Rectangle(-15, -15, 15, 15);

        Rectangle green1 = new Rectangle(200, 110, 10, 10);
        Rectangle green2 = new Rectangle(-10, -10, 10, 10);
        Rectangle green3 = new Rectangle(-10, -10, 10, 10);
        Rectangle green4 = new Rectangle(-10, -10, 10, 10);
        Rectangle green5 = new Rectangle(-10, -10, 10, 10);


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
        private void Squarechaser_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(lightblueBrush, player);

            e.Graphics.FillRectangle(redBrush, red1);
            e.Graphics.FillRectangle(redBrush, red2);
            e.Graphics.FillRectangle(redBrush, red3);
            e.Graphics.FillRectangle(redBrush, red4);
            e.Graphics.FillRectangle(redBrush, red5);

            e.Graphics.FillRectangle(greenyBrush, green1);
            e.Graphics.FillRectangle(greenyBrush, green2);
            e.Graphics.FillRectangle(greenyBrush, green3);
            e.Graphics.FillRectangle(greenyBrush, green4);
            e.Graphics.FillRectangle(greenyBrush, green5);

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

            //check if player has intersected with green squares
            if (player.IntersectsWith(green1))
            {
                playerScore++;
                scorelable.Text = $"{playerScore}";

                green1.X = randGen.Next(10, 580);
                green1.Y = randGen.Next(10, 340);

                NewGreen();
                NewRed();

                sp = new SoundPlayer(Properties.Resources.coins_1);
                sp.Play();

            }
            if (player.IntersectsWith(green2))
            {
                playerScore++;
                scorelable.Text = $"{playerScore}";

                green2.X = randGen.Next(10, 580);
                green2.Y = randGen.Next(10, 340);

                NewGreen();
                NewRed();

                sp = new SoundPlayer(Properties.Resources.coins_1);
                sp.Play();
            }
            if (player.IntersectsWith(green3))
            {
                playerScore++;
                scorelable.Text = $"{playerScore}";

                green3.X = randGen.Next(10, 580);
                green3.Y = randGen.Next(10, 340);

                NewGreen();
                NewRed();

                sp = new SoundPlayer(Properties.Resources.coins_1);
                sp.Play();
            }
            if (player.IntersectsWith(green4))
            {
                playerScore++;
                scorelable.Text = $"{playerScore}";

                green4.X = randGen.Next(10, 580);
                green4.Y = randGen.Next(10, 340);

                NewGreen();
                NewRed();

                sp = new SoundPlayer(Properties.Resources.coins_1);
                sp.Play();
            }
            if (player.IntersectsWith(green5))
            {
                playerScore++;
                scorelable.Text = $"{playerScore}";

                green5.X = randGen.Next(10, 580);
                green5.Y = randGen.Next(10, 340);

                NewGreen();
                NewRed();

                sp = new SoundPlayer(Properties.Resources.coins_1);
                sp.Play();
            }
            //check intersection with red squares 
            if (player.IntersectsWith(red1))
            {
                playerScore--;
                scorelable.Text = $"{playerScore}";

                red1.X = randGen.Next(10, 580);
                red1.Y = randGen.Next(10, 340);

                NewRed();
                NewGreen();

            }
            if (player.IntersectsWith(red2))
            {
                playerScore--;
                scorelable.Text = $"{playerScore}";

                red2.X = randGen.Next(10, 580);
                red2.Y = randGen.Next(10, 340);

                NewRed();
                NewGreen();
            }
            if (player.IntersectsWith(red3))
            {
                playerScore--;
                scorelable.Text = $"{playerScore}";

                red3.X = randGen.Next(10, 580);
                red3.Y = randGen.Next(10, 340);

                NewRed();
                NewGreen();

                
            }
            if (player.IntersectsWith(red4))
            {
                playerScore--;
                scorelable.Text = $"{playerScore}";

                red4.X = randGen.Next(10, 580);
                red4.Y = randGen.Next(10, 340);

                NewRed();
                NewGreen();
            }
            if (player.IntersectsWith(red5))
            {
                playerScore--;
                scorelable.Text = $"{playerScore}";

                red5.X = randGen.Next(10, 580);
                red5.Y = randGen.Next(10, 340);

                NewRed();
                NewGreen();
            }
            
            //win or lose
            if (playerScore < 0)
            {
                gamertimer.Enabled = false;
                loselable.Visible = true;
                loselable.ForeColor = Color.Red;
                loselable.Text = "You Lose";
                sp = new SoundPlayer(Properties.Resources.power_down);
                sp.Play();
            }
            if (playerScore == 15)
            {
                gamertimer.Enabled = false;
                loselable.Visible = true;
                loselable.ForeColor = Color.Green;
                loselable.Text = "You  Win!!";
            }

            Refresh();

        }
        //pop up green squares
        private void NewGreen()
        {
            if (playerScore == 2)
            {
                green2.X = randGen.Next(10, 580);
                green2.Y = randGen.Next(10, 340);
            }
            if (playerScore == 6)
            {
                green3.X = randGen.Next(10, 580);
                green3.Y = randGen.Next(10, 340);
            }
            if (playerScore == 10)
            {
                green4.X = randGen.Next(10, 580);
                green4.Y = randGen.Next(10, 340);
            }
            if (playerScore == 12)
            {
                green5.X = randGen.Next(10, 580);
                green5.Y = randGen.Next(10, 340);
            }
        }

        //pop up red squares 
        private void NewRed()
        {
            if (playerScore == 3)
            {
                red2.X = randGen.Next(10, 580);
                red2.Y = randGen.Next(10, 340);
            }
            if (playerScore == 6)
            {
                red3.X = randGen.Next(10, 580);
                red3.Y = randGen.Next(10, 340);
            }
            if (playerScore == 9)
            {
                red4.X = randGen.Next(10, 580);
                red4.Y = randGen.Next(10, 340);
            }
            if (playerScore == 12)
            {
                red5.X = randGen.Next(10, 580);
                red5.Y = randGen.Next(10, 340);
            }
        }
    }
}
