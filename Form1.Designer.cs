namespace Square_chaser_summative
{
    partial class Squarechaser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Squarechaser));
            this.scorelable = new System.Windows.Forms.Label();
            this.loselable = new System.Windows.Forms.Label();
            this.gamertimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // scorelable
            // 
            this.scorelable.AutoSize = true;
            this.scorelable.ForeColor = System.Drawing.Color.LawnGreen;
            this.scorelable.Location = new System.Drawing.Point(388, 23);
            this.scorelable.Name = "scorelable";
            this.scorelable.Size = new System.Drawing.Size(14, 16);
            this.scorelable.TabIndex = 0;
            this.scorelable.Text = "0";
            this.scorelable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loselable
            // 
            this.loselable.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loselable.ForeColor = System.Drawing.Color.Red;
            this.loselable.Location = new System.Drawing.Point(318, 180);
            this.loselable.Name = "loselable";
            this.loselable.Size = new System.Drawing.Size(149, 59);
            this.loselable.TabIndex = 1;
            // 
            // gamertimer
            // 
            this.gamertimer.Enabled = true;
            this.gamertimer.Interval = 20;
            this.gamertimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Squarechaser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loselable);
            this.Controls.Add(this.scorelable);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Squarechaser";
            this.Text = "Square Chaser";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Squarechaser_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scorelable;
        private System.Windows.Forms.Label loselable;
        private System.Windows.Forms.Timer gamertimer;
    }
}

