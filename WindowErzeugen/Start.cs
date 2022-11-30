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
    public partial class Start : Form
    {
        public Button eins;
        public Button zwei;
        public Button drei;
        public Start()
        {
            int i = 30;
            this.Size = new Size(500, 500);

            Button eins = new Button();
            eins.Text = "Grundriss";
            eins.Location = new Point(200, i);
            eins.Size = new Size(80, 50);
            this.Controls.Add(eins); 

            Button zwei = new Button();
            zwei.Text = "Innenarchitektur";
            i = i + 90;
            zwei.Location = new Point(200, i);
            zwei.Size = new Size(80, 50);
            this.Controls.Add(zwei);


            Button drei = new Button();
            drei.Text = "Gartenbau";
            i = i + 90;
            drei.Location = new Point(200, i);
            this.Controls.Add(drei);
            drei.Size = new Size(80, 50);
            //InitializeComponent();
            change();

            //groeße anpassen an den Bildschirm
            if (ClientSize != Size)
            {
                //eins.Size = new Size(300, 300);
            }
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }

        private void change()
        {
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Text = "Startseite";
            this.Resize += new System.EventHandler(this.Start_Resize);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Start_Paint);
        }
        private void Start_Resize(object sender, System.EventArgs e)
        {
            Invalidate();
            Console.WriteLine("Resize");
        }
        private void Start_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawString("Home", new Font("Arial", 20), new SolidBrush(Color.Black), this.DisplayRectangle);
            
        }
        private void click_Home(object sender, EventArgs e)
        {
            
        }
        private void createImage() { 
        
            //hier Bild raussuchen und einfuegen
           // Bitmap myBitmap = new Bitmap();
           // Graphics g = Graphics.FromImage(myBitmap);
        }
    }
}
