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
    public partial class ViewRegestrierung : Form
    {
        public ViewRegestrierung()
        {
            InitializeComponent();
        }

        private void buttonZurueck_Click(object sender, EventArgs e)
        {
            ViewLoggin viewLoggin = new ViewLoggin();
            viewLoggin.Show();

            this.Close();
        }

        private void buttonSpeichern_Click(object sender, EventArgs e)
        {
            ViewLoggin viewLoggin = new ViewLoggin();
            viewLoggin.Show();

            this.Close();
        }
    }
}
