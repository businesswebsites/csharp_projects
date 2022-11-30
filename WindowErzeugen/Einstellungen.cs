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
    public partial class Einstellungen : Form
    {
        private System.Windows.Forms.TrackBar trackbar1;
        private System.Windows.Forms.TextBox textbox1;
        public Einstellungen()
        {
            this.textbox1 = new System.Windows.Forms.TextBox();
            this.trackbar1 = new System.Windows.Forms.TrackBar();

            this.textbox1.Location = new System.Drawing.Point(240, 16);
            this.textbox1.Size = new System.Drawing.Size(48, 20);
            this.Text = "Trackbar Example";


            this.ClientSize = new System.Drawing.Size(296, 62);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.textbox1, this.trackbar1 });

            this.trackbar1.Location = new System.Drawing.Point(8, 8);
            this.trackbar1.Size = new System.Drawing.Size(224, 45);
            this.trackbar1.Scroll += new System.EventHandler(this.trackbar1_Scroll);

            trackbar1.Maximum = 30;
            trackbar1.TickFrequency = 5;
            trackbar1.LargeChange = 3;
            trackbar1.SmallChange = 2;
            //InitializeComponent();
        }

        private void Einstellungen_Load(object sender, EventArgs e)
        {

        }
        private void trackbar1_Scroll(object sender,System.EventArgs e)
        {
            textbox1.Text = "" + trackbar1.Value;
        }
    }
}
