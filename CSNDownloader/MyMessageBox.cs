using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSNDownloader
{
    class MyMessageBox
    {
        public static System.Windows.Forms.DialogResult ShowMessage (string message, string caption, System.Windows.Forms.MessageBoxButtons button, System.Windows.Forms.MessageBoxIcon icon)
        {
            System.Windows.Forms.DialogResult dlgResult = System.Windows.Forms.DialogResult.None;
            if(button == System.Windows.Forms.MessageBoxButtons.OK)
            {
                using (frmThongBao frmOk = new frmThongBao())
                {
                    frmOk.Caption = caption;
                    frmOk.Message = message;
                    switch(icon)
                    {
                        case System.Windows.Forms.MessageBoxIcon.Information:
                            frmOk.MessageIcon = CSNDownloader.Properties.Resources.Information_100;
                            break;
                        case System.Windows.Forms.MessageBoxIcon.Error:
                            frmOk.MessageIcon = Properties.Resources.Error_100;
                            break;
                    }
                    dlgResult = frmOk.ShowDialog();
                }
            }
            return dlgResult;
        }
    }
}
