using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Desktop
{
    public partial class FormEquipo : Desktop.FormPlantilla
    {
        bool mod;
        Equipo equipo;

        public FormEquipo()
        {
            InitializeComponent();
        }
        public FormEquipo(Equipo equipo, bool mod)
        {
            InitializeComponent();
            this.equipo = equipo;
            this.mod = mod;
        }
    }
}
