﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notenplana23
{
    public partial class ViewFachBearbeitenHj2 : Form
    {
        public ViewFachBearbeitenHj2()
        {
            InitializeComponent();
        }

        private void buttonZurueck_Click(object sender, EventArgs e)
        {
            ViewFachHj2 viewFachHj2 = new ViewFachHj2();
            viewFachHj2.Show();

            this.Close();
        }

        private void buttonSpeichern_Click(object sender, EventArgs e)
        {

        }

        private void buttonLoeschen_Click(object sender, EventArgs e)
        {

        }
    }
}
