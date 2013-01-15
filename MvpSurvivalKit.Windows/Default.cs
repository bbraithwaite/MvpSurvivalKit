using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MvpSurvivalKit.Windows
{
    public partial class Default : Form
    {
        public Default()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Checkout form = new Checkout("E6A621A3-E90B-4566-8E03-62D23549F9D4");
            form.Show();
        }
    }
}
