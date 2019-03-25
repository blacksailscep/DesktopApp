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
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(1000);
            InitializeComponent();
            t.Abort();
        }

        public void StartForm()
        {
            Application.Run(new FormLandingPage());
        }
    }
}
