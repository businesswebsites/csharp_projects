using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowErzeugen
{
    public partial class Credits : Form
    {
        public Button slider;
        private System.Windows.Forms.TrackBar trackbar1;
        private System.Windows.Forms.TextBox textbox1;

        public Credits()
        {
            Button slider = new Button();
            slider.Size = new Size(100, 50);
            slider.Location = new Point(400, 400);
            slider.Text = "Slider";
            this.Controls.Add(slider);

            slider.Click += new EventHandler(click_Slider);


            InitializeComponent();
            bumm();
            
        }
        private void click_Slider(object sender, EventArgs e)
        {
            
            this.textbox1 = new System.Windows.Forms.TextBox();
            this.trackbar1 = new System.Windows.Forms.TrackBar();

            this.textbox1.Location = new System.Drawing.Point(500, 400);
            this.textbox1.Size = new System.Drawing.Size(48, 20);
            this.Text = "Trackbar Example";


            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.textbox1, this.trackbar1 });

            this.trackbar1.Location = new System.Drawing.Point(400, 250);
            this.trackbar1.Size = new System.Drawing.Size(224, 45);
            this.trackbar1.Scroll += new System.EventHandler(this.trackbar1_Scroll);

            trackbar1.Maximum = 80;
            trackbar1.Minimum = 40;
            trackbar1.TickFrequency = 5;
            trackbar1.LargeChange = 3;
            trackbar1.SmallChange = 2;

            //trackbar an den Point anpassen 
            
        }

        private void trackbar1_Scroll(object sender, System.EventArgs e)
        {
            textbox1.Text = "" + trackbar1.Value;
        }

        private void bumm()
        {
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.draw);
        }

        private void Credits_Load(object sender, EventArgs e)
        {
            
        }
        private void draw(object sender, System.Windows.Forms.PaintEventArgs e )
        {
            int iWidth = 150;
            //int iHeight = trackbar1.Value;
            int iHeight = 40;

            Point top = new Point(iWidth / 2, 10),
                bottomLeft = new Point(10, iHeight),
                bottomRight = new Point(iWidth, iHeight);

            Pen p = new Pen(Color.Black, 1);

            Graphics t = e.Graphics;
            
            e.Graphics.DrawLine(p, bottomLeft, bottomRight);
            e.Graphics.DrawLine(p, top, bottomRight);
            e.Graphics.DrawLine(p, top, bottomLeft);

            
        }

    }
}
