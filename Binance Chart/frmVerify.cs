using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binance_Chart
{
    public partial class frmVerify : Form
    {
        public frmVerify()
        {
            InitializeComponent();        

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVerify_Load(object sender, EventArgs e)
        {
            if (Authentication.checkMac() == true)
            {
                frmMain clientForm = new frmMain();
                clientForm.ShowDialog();
                this.Close();
            }
            else
            {
                lblVerify.Text = "Your PC is not registered. Please register then come back.";
                btnClose.Visible = true;
            }
        }
    }
}
