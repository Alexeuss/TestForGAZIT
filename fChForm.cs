using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TestForGAZIT
{
    public partial class fChForm : Form
    {
        public DataGridViewRow dgvDRRet;
        public fChForm()
        {
            InitializeComponent();
        }

        private void tsbChoose_click(object sender, EventArgs e)
        {
            if (dgChRef.SelectedRows.Count > 0)
            {
                dgvDRRet = dgChRef.SelectedRows[0];
                this.Close();
            }
        }

        public DataGridViewRow getSelectedRow()
        {
            return dgvDRRet;
        }

        private void dgChRef_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbChoose_click(sender, e);
        }
    }

}
