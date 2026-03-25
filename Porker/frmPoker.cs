using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Porker
{
    public partial class frmPoker : Form
    {
        public frmPoker()
        {
            InitializeComponent();
        }

        private void picTest_Click(object sender, EventArgs e)
        {

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            this.picTest.Image = picTest.Properties.Resources.pic39;
        }
    }
}
