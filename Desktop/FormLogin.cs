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
        private int imageNumber = 2;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = string.Format(@"..\Images\1.jpg");
        }

        private void loadNextImage()
        {
            if (imageNumber > 4)
            {
                imageNumber = 1;
            }
            pictureBox2.ImageLocation = string.Format(@"..\Images\" + imageNumber + ".jpg");
            imageNumber++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           loadNextImage();
        }

        private void buttonSigin_Click(object sender, EventArgs e)
        {
            FormLoginMsg f;

            if (ORM.ORMUsuarios.UserExist(textBoxUsername.Text, textBoxPassword.Text))
            {
                f = new FormLoginMsg(true);
                f.ShowDialog();
                FormLandingPage landing = new FormLandingPage();
                landing.Show();
                this.Close();

            }
            else
            {
                f = new FormLoginMsg(false);
                f.ShowDialog();
            }
        }
    }      
}
