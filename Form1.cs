using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        bool wDown = false;
        bool sDown = false;
        bool upArrowDown = false;
        bool downArrowDown = false;
        bool LDown = false;
        bool RDown = false;
        bool leftarrowdown = false;
        bool rightarrowdown = false;

        Rectangle player = new Rectangle(280, 200, 30, 30);
        Rectangle redsquare = new Rectangle(110, 195, 15, 15);
        Rectangle greensquare = new Rectangle(200, 110, 10, 10);

        SolidBrush lightblueBrush = new SolidBrush(Color.LightBlue);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush greenyBrush = new SolidBrush(Color.GreenYellow);

        Random randsquares = new Random();

        public Squarechaser()
        {
            InitializeComponent();
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
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.L:
                    LDown = true;
                    break;
                case Keys.R:
                    RDown = true;
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
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.R:
                    RDown = false;
                    break;
                case Keys.L:
                    LDown = false;
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
            //move ball 
            
            
            if (upArrowDown == true)
            {
                player.Y -= playerSpeed;
            }
            else if (downArrowDown == false)
            {
                player.Y += playerSpeed;
            }

            //check if ball hit top or bottom wall and change direction if it does 
            if (player.X < 0 || player.X > this.Height - player.Height)
            {
                playerSpeed *= -1;  // or: ballYSpeed = -ballYSpeed; 
            }
            //move player 
            if (wDown == true && player.X > 0)
            {
                player.X -= playerSpeed;
            }

            if (sDown == true && player.X < this.Height - player.Height)
            {
                player.X += playerSpeed;
            }
            if (playerScore < 0)
            {
                gamertimer.Enabled = false;
                loselable.Visible = true;
                loselable.Text = "You lose";

            }

            Refresh();  

        }
    }
}
