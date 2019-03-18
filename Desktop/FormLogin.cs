using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private int imageNumber = 2;

        private void loadNextImage()
        {
            if (imageNumber > 2)
            {
                imageNumber = 1;
            }
            pictureBox2.ImageLocation = string.Format(@"Images/" + imageNumber + ".jpg");
            imageNumber++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loadNextImage();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = string.Format(@"Images/1.jpg");
        }
    }      
}
