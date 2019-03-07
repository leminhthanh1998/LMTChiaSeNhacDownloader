using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSNDownloader
{
    public partial class frmThongBao : Form
    {
        public frmThongBao()
        {
            InitializeComponent();
            
        }
        public Image MessageIcon
        {
            get { return pictureBoxIcon.Image; }
            set { pictureBoxIcon.Image = value; }
        }
        public string Message
        {
            
            get { return labelThongBao.Text; }
            set { labelThongBao.Text = value; }
        }

        public string Caption
        { get { return labelTieude.Text; }
            set { labelTieude.Text = value; }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
