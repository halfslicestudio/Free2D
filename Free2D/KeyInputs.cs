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
    public partial class KeyInputs : Form
    {
        public KeyInputs()
        {
            InitializeComponent();
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void formSkin1_Click(object sender, EventArgs e)
        {

        }

        public string GetValueDown()
        {
            return richTextBox1.Text;
        }
        public string GetValueUp()
        {
            return richTextBox2.Text;
        }
        public void SetValueDown(string s)
        {
            richTextBox1.Text = s;
        }
        public void SetValueUp(string s)
        {
            richTextBox2.Text = s;
        }
    }
}
