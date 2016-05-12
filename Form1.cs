using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursorFollowerRandandIF1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            
            
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            var a = this.ClientSize.Width / 2;
            var b = this.ClientSize.Height / 2;

            var c = (a + e.X) / 2;
            var d = (b + e.Y) / 2;

            Point f = new Point(e.X, e.Y);

            Graphics paper = this.CreateGraphics();
            Pen pen1 = new Pen(colorDialog1.Color, 2);

            if (e.X < a && e.Y < b)  //top left
            {
                this.Refresh();
                paper.DrawRectangle(pen1, e.X , e.Y , a-e.X , b-e.Y );
            }
            if (e.X > a && e.Y < b)  //top right
            {
                //this.Refresh();
                paper.DrawRectangle(pen1, a , e.Y , e.X-a , b-e.Y );
            }
            if (e.X < a && e.Y > b)  //bottom left
            {
                this.Refresh();
                paper.DrawRectangle(pen1, e.X , b , a-e.X,  e.Y-b );
            }
            if (e.X > a && e.Y > b) //bottom right
            {
                //this.Refresh();
                paper.DrawRectangle(pen1, a, b, e.X - a, e.Y - b);
            }



            //paper.DrawArc(pen1, e.X, e.Y, a, b, 50, 50);

            paper.DrawRectangle(pen1, a, b, e.X-a, e.Y-b);

            //paper.DrawEllipse(pen1, f.X, f.Y, 50, 50);



            //paper.DrawLine(pen1, a, b, e.X, e.Y);
        }

        //        private void Form1_MouseClick(object sender, MouseEventArgs e)
        //        {
        //            var a = this.ClientSize.Width / 2;
        //            var b = this.ClientSize.Height / 2;
        //            var c = (a + e.X) / 2;
        //            var d = (b + e.Y) / 2;

        //            Graphics paper = this.CreateGraphics();
        //            Pen pen1 = new Pen(colorDialog1.Color, 2);

        //            //paper.DrawArc(pen1, a, b, e.Y, e.X, 50, 50);
        //            //paper.DrawArc(pen1, e.X, e.Y, a, b, 50, 50);
        //            paper.DrawEllipse(pen1, this.ClientSize.Width, this.ClientSize.Height, e.X, e.Y);
        //            //paper.DrawLine(pen1, a, b, e.X, e.Y);
    }
}

