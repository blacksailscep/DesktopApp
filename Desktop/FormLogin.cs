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
            if (ORM.ORMUsuarios.UserExist(textBoxUsername.Text, textBoxPassword.Text))
            {
                MessageBox.Show("Acceso aceptado");
                //System.Threading.Thread.Sleep(10);

            }
            else
            {
                MessageBox.Show("Acceso denegado");
                //System.Threading.Thread.Sleep(10);
            }
        }
    }      
}
