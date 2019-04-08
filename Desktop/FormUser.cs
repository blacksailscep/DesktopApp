using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Desktop
{
    public partial class FormUser : Desktop.FormPlantilla
    {
        public FormUser()
        {
            InitializeComponent();
        }

        private void buttonAñadir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
