using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace CARD
    /* Halloween card 
     * 09/19/19
     * Jayden
     */
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //Outside of card 
            Graphics g = this.CreateGraphics();
            Font titleFont = new Font("Times New Roman", 20);
            SolidBrush titleBrush = new SolidBrush(Color.Orange);
            SolidBrush drawBrush = new SolidBrush(Color.Orange);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            Pen drawPen = new Pen(Color.Black, 5);
            SoundPlayer player = new SoundPlayer(Properties.Resources.Spooky_SoundBible_com_381353359);

            player.Play();

            g.Clear(Color.Black);
            g.DrawString("Happpy Halloween", titleFont, titleBrush, 240, 200); 

            //Drawing outside
            g.FillEllipse(drawBrush, 50, 50, 150, 150);
            Thread.Sleep(700);
            g.FillEllipse(yellowBrush, 50, 50, 150, 150);
            Thread.Sleep(700);
            g.FillEllipse(drawBrush, 50, 50, 150, 150);
            Thread.Sleep(700);
            g.FillEllipse(yellowBrush, 50, 50, 150, 150);
            g.FillEllipse(drawBrush, 50, 50, 150, 150);
            Thread.Sleep(700);
            g.FillEllipse(yellowBrush, 50, 50, 150, 150);
            g.FillEllipse(drawBrush, 50, 50, 150, 150);
            Thread.Sleep(700);
            g.FillEllipse(yellowBrush, 50, 50, 150, 150);
            Thread.Sleep(700);
            g.FillEllipse(drawBrush, 50, 50, 150, 150);
            Thread.Sleep(700);
            g.FillEllipse(yellowBrush, 50, 50, 150, 150);
            g.FillEllipse(drawBrush, 50, 50, 150, 150);
            Thread.Sleep(700);
            g.FillEllipse(yellowBrush, 50, 50, 150, 150);
            g.FillEllipse(drawBrush, 50, 50, 150, 150);
            Thread.Sleep(700);
            g.FillEllipse(yellowBrush, 50, 50, 150, 150);
            Thread.Sleep(700);
            g.FillEllipse(drawBrush, 50, 50, 150, 150);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //Inside of card 
            Graphics g = this.CreateGraphics();
            Font titleFont = new Font("Comic Sans", 20);
            SolidBrush titleBrush = new SolidBrush(Color.Black);
            SolidBrush drawBrush = new SolidBrush(Color.White);
            SolidBrush BLACKBrush = new SolidBrush(Color.Black);
            Pen drawPen = new Pen(Color.Black, 10);
            SoundPlayer player = new SoundPlayer(Properties.Resources.Evil_laugh_Male_9_Himan_1598312646);

            player.Play();
            g.Clear(Color.Orange);
            g.DrawString("Have a spookey halloween", titleFont, titleBrush, 30, 30);
            Thread.Sleep(1000);
            g.DrawString("I hope you get lots of candy", titleFont, titleBrush, 50, 50);
            Thread.Sleep(1000);
            g.DrawString("Love Dad", titleFont, titleBrush, 100, 100);

            //Drawing inside
            Thread.Sleep(1000);
            g.FillEllipse(drawBrush, 200, 200, 200, 200);
            g.FillEllipse(BLACKBrush, 250, 250, 50, 50);
            g.FillEllipse(BLACKBrush, 320, 250, 50, 50);
            g.DrawArc(drawPen, 270, 260, 90, 90, 300, 300);
        }
    }
}
