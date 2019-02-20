using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplashFireGame
{
    public partial class gameArea : Form
    {

        int ct = 1,y=1;

        public gameArea()
        {
            InitializeComponent();
            fireBtn.Enabled = false;
            btnSpin.Enabled = false;
        }

        private void gameArea_Load(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (nmBullet.Value == 0)
            {
                MessageBox.Show("First Fill the No of Bullet to load in the Gun");
            }
            else if (nmBullet.Value == 1)
            {
                pbGun.ImageLocation = "img/one.jpg";
                btnSpin.Enabled = true;
            }
            else if (nmBullet.Value == 2)
            {
                pbGun.ImageLocation = "img/two.jpg";
                btnSpin.Enabled = true;
            }
            else {

            }
            
        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            if (nmBullet.Value > 0) {
                pbGun.ImageLocation = "img/fullloaded.jpg";
                fireBtn.Enabled = true;
            }


        }

        private void btnPlyAgain_Click(object sender, EventArgs e)
        {
            pbGun.ImageLocation = "img/emptyGun.jpg";
            ct = 1;
            y = 1;
            btnSpin.Enabled = false;
            fireBtn.Enabled = false;
            nmBullet.Value = 0;
        }

        private void fireBtn_Click(object sender, EventArgs e)
        {

            if (ct <= nmBullet.Value && y == ct)
            {
                ct++;
                pbGun.ImageLocation = "img/fire.jpg";
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("img/sund.wav");
                player.Play();
                Random rd = new Random();
                y = rd.Next(2, 4);
            }
            else {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("img/Empty.wav");
                player.Play();

            }
        }
    }
}
