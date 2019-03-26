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
    public partial class FormLoginMsg : Form
    {
        private bool msg;

        public FormLoginMsg(bool msg)
        {
            InitializeComponent();
            this.msg = msg;
            setText();
            timer1.Enabled = true;
            timer1.Interval = 3000;
        }

        public void setText()
        {
            if (msg)
            {
                labelMsg.Text = "  Acceso aceptado";
                labelMsg.ForeColor = Color.Green;
            }
            else
            {
                labelMsg.Text = "  Acceso denegado";
                labelMsg.ForeColor = Color.Red;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
