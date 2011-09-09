using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace URGE
{
    public partial class Enter_PIN : Form
    {
        public Enter_PIN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPin.Text == "")
            {
                MessageBox.Show("PIN must not be empty!");
            }
            else {
                Properties.Settings.Default.pin = txtPin.Text;
                Properties.Settings.Default.Save();
                Close();
            }
        }
    }
}
