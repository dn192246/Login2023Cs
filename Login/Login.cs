﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("¡Termina la actividad! " +
                "Si necesitas ayuda, no dudes en consultar al instructor", "Alto",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
