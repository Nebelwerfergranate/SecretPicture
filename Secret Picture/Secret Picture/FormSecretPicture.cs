using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secret_Picture
{
    public partial class FormSecretPicture : Form
    {
        private int secret_nr = 0;

        public FormSecretPicture()
        {
            InitializeComponent();
        }

        private void Show1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources._1;
        }

        private void Show2_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources._2;
        }

        private void Show3_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources._3;
        }

        private void Show4_Click(object sender, EventArgs e)
        {
            if (secret_nr == 2)
            {
                this.BackgroundImage = Properties.Resources._5;
            }
            else
            {
                this.BackgroundImage = Properties.Resources._4;
            }
            secret_nr = 0;
        }

        private void FormSecretPicture_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                secret_nr = 1;
            }
                
        }

        private void FormSecretPicture_MouseMove(object sender, MouseEventArgs e)
        {
            if (secret_nr == 1)
                if (e.X < Show1.Location.X && e.Y < Show1.Location.Y)
                {
                    secret_nr = 2;
                }
        }
    }
}
