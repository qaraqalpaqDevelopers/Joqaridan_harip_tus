using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WMPLib;

namespace Joqaridan_harip_tus
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer player=new WindowsMediaPlayer();
        WindowsMediaPlayer player2=new WindowsMediaPlayer();
        WindowsMediaPlayer player3=new WindowsMediaPlayer();


        public Form1()
        {
            InitializeComponent();

        }
        Random xr=new Random();
        Random yr=new Random();
        Random yk=new Random();
        char b = 'f';
        int x=0,y=0,sekund=0,latin=0,kirill=0,duris=0;
        private void manis_beriw()
        {
            x=xr.Next(0,700);
            label1.Location=new Point(x,0);
            if(latin==1&&kirill==0)
            b = (char)yr.Next('a', 'z');
            else
                b = (char)yr.Next('а', 'я');
            label1.Text = b.ToString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            sekund++;
           


            y += 1;
                label1.Location = new Point(x, y);
            
           
            if(label1.Location.Y>405)
            {
                player2.URL = @"zvonok.wav";
                manis_beriw();
                y = 0;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            player.URL = @"tanaka.Mp3";
            panel1.Visible=false;
            manis_beriw();
            label1.Visible = true;
            waqit.Start();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            latin++;
            koriniw();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            kirill++;
            koriniw();
        }
        private void koriniw()
        {
            guna2Button3.Visible = false;
            guna2Button2.Visible = false;
            baslaw.Visible = true;
            label2.Visible = false;
        }
        private void guna2Button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == label1.Text)
            {
                duris++;
                manis_beriw();
                y = 0;
                

            }
            else
            {
                player3.URL = @"wrong.wav";

            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void a_Click(object sender, EventArgs e)
        {

        }
    }
}
