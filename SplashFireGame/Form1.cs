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
    public partial class Form1 : Form
    {
        int y = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (y < 100)
            {
                y += 10;
                pbLoading.Value = y;
            }
            else {
                gameArea obj = new gameArea();

                obj.Show();
                
                this.Hide();
                timer1.Enabled = false;

            }
        }
    }
}
