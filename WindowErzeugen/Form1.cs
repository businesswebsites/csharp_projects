using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WindowErzeugen
{
    public partial class Form1 : Form
    {
        public Button button1;
        private Font font1small;
        private Font font1big;
        
        public Form1()
        {
            this.Size = new Size(500, 500);


            button1 = new Button();
            button1.Size = new Size(500, 500);
            button1.Location = new Point(0, 0);
            button1.Text = "Menu";
            this.Controls.Add(button1);
            button1.Click += new EventHandler(button1_Click);
            

            this.Font = SystemFonts.IconTitleFont;
            SystemEvents.UserPreferenceChanged += new
            UserPreferenceChangedEventHandler(SystemEvents_UserPreferenceChanged);
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            //wird nur gebraucht fuer vorgefertigtes fenster
            //InitializeComponent();
        }

        
        
        

        void SystemEvents_UserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
        {
            if (e.Category == UserPreferenceCategory.Window)
            {
                this.Font = SystemFonts.IconTitleFont;
            }
        }


        void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SystemEvents.UserPreferenceChanged -= new
            UserPreferenceChangedEventHandler(SystemEvents_UserPreferenceChanged);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newWindow = new Form2();
            newWindow.Show();
            //Form1_FormClosing();
            // MessageBox.Show("Hello World!");
            
        }

        private void keyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            
            if(e.KeyCode == Keys.D0)
            {

            }
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            font1small = this.Font;

            font1big = new Font("Times New Roman", 20);
        }

        private void checkFont(object sender, EventArgs e)
        {
            
        }

        [STAThread]
        public static void main()
        {
            
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }
    }
}
