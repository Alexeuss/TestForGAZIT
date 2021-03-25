using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TestForGAZIT
{
    public partial class fEdAddressForm : Form
    {
        public fEdAddressForm()
        {
            InitializeComponent();
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fEdAddressForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("В разработке :)");
        }
    }
}
