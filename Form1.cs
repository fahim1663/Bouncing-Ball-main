using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bouncing_bal1
{
    public partial class Form1 : Form
    {
        private int ballwidth = 60;
        private int ballheight = 60;
        private int ballposX = 0;
        private int ballposY = 0;
        private int movestepX = 4;
        private int movestepY = 4;
        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            this.UpdateStyles();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void paintcircle(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = 
                System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.Clear(this.BackColor);

            e.Graphics.FillEllipse(Brushes.Brown,
                ballposX,ballposY,
                ballwidth,ballheight);
            e.Graphics.DrawEllipse(Pens.Black,
                ballposX, ballposY,
                ballwidth, ballheight);
        }

        private void moveball(object sender, EventArgs e)
        {
            //update coordinates
            ballposX += movestepX;
            if(
                ballposX < 0 ||
                ballposX + ballwidth >this.ClientSize.Width
                )
            {
                movestepX = -movestepY;

            }
            ballposY += movestepY;
            if (
                ballposY < 0 ||
                ballposY + ballheight > this.ClientSize.Height
                )
            {
                movestepY = -movestepY;

            }
            //update painting
            this.Refresh();


        }
    }
}
