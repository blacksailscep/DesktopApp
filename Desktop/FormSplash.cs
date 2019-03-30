using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public partial class FormSplash : Form
    {
        public FormSplash()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Interval = 1000;    
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.DialogResult = DialogResult.OK;
            FormLogin f = new FormLogin();
            f.Show();
            this.Hide();
        }
    }
}
