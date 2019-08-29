using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Free2D
{
    public partial class GlobalVars : Form
    {
        public GlobalVars()
        {
            InitializeComponent();
        }

        private void formSkin1_Click(object sender, EventArgs e)
        {

        }
        public string GetValue()
        {
            return richTextBox1.Text;
        }
        public void SetValue(string s)
        {
            richTextBox1.Text = s;
        }

        private void flatClose1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
