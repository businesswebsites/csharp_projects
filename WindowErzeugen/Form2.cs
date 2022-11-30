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
    public partial class Form2 : Form
    {
        public Button start;
        public Button credits;
        public Button ende;
        public Button einstellungen;
        public Button spiel;
        public Form2()
        {
            this.Size = new Size(500, 500);

            start = new Button();
            start.Text = "Start";
            start.Size = new Size(80, 50);
            start.Location = new Point(200, 30);
            this.Controls.Add(start);
            start.Click += new EventHandler(click_Start); 

            credits = new Button();
            credits.Text = "Credits";
            credits.Size = new Size(80, 50);
            credits.Location = new Point(200, 120);
            this.Controls.Add(credits);
            credits.Click += new EventHandler(click_Credits);

            einstellungen = new Button();
            einstellungen.Text = "Einstellungen";
            einstellungen.Size = new Size(80, 50);
            einstellungen.Location = new Point(200, 210);
            this.Controls.Add(einstellungen);
            einstellungen.Click += new EventHandler(click_Einstellungen);



            ende = new Button();
            ende.Text = "Ende";
            ende.Size = new Size(80, 50);
            ende.Location = new Point(200, 300);
            this.Controls.Add(ende);
            ende.Click += new EventHandler(click_Ende);

            spiel = new Button();
            spiel.Text = "Spiel";
            spiel.Size = new Size(80, 50);
            spiel.Location = new Point(200, 380);
            this.Controls.Add(spiel);
            spiel.Click += new EventHandler(click_Spiel);
            //InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void close(object sender, EventArgs e)
        {
            
        }
        private void click_Start(object sender, EventArgs e)
        {
            Start startWindow = new Start();
            startWindow.Show();

            this.Close();
        }

        private void click_Spiel(object sender, EventArgs e)
        {
            Spiel spielWindow = new Spiel();
            spielWindow.Show();
            this.Close();
        }

        private void click_Credits(object sender, EventArgs e)
        {
            Credits creditsWindow = new Credits();
            creditsWindow.Show();

            this.Close();
        }
        private void click_Ende(object sender, EventArgs e)
        {
            this.Close();
        }
        private void click_Einstellungen(object sender, EventArgs e)
        {
            Einstellungen einstellungWindow = new Einstellungen();
            einstellungWindow.Show();

            this.Close();
        }
    }
}
