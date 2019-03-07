using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CSNDownloader
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            worker1.DoWork += Worker1_DoWork;
            worker1.RunWorkerCompleted += Worker1_RunWorkerCompleted;
            worker2.DoWork += Worker2_DoWork;
            worker2.RunWorkerCompleted += Worker2_RunWorkerCompleted;
            Disable();
        }
        
        
        private void Worker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressbar.animated = false;
            progressbar.Value = 0;
            rdb128.Checked = rdb320.Checked = rdbFlac.Checked = false;
            if (downloader.CheckMang)
            {
                if (downloader.CheckLink)
                {
                    if (downloader.Link128 != null)
                    {
                        rdb128.Enabled = true; Link128 = downloader.Link128; Size128 = downloader.Size128;
                    }

                    if (downloader.Link320 != null)
                    {
                        rdb320.Enabled = true; Link320 = downloader.Link320; Size320 = downloader.Size320;
                    }

                    if (downloader.Lossless != null)
                    {
                        rdbFlac.Enabled = true; LinkLossless = downloader.Lossless; SizeLossless = downloader.SizeLossLess;
                    }
                    if (downloader.Link128 != null || downloader.Link320 != null || downloader.Lossless != null) btnGo.Enabled = true;
                }
                else MyMessageBox.ShowMessage("Link bạn nhập đã bị lỗi, hãy kiểm tra lại !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                

            }
            else { MyMessageBox.ShowMessage("Hãy kiểm tra lại kết nối mạng của bạn !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            
        }

        private void Worker2_DoWork(object sender, DoWorkEventArgs e)
        {
            downloader.GetLinkBaiHat();
        }

        private void Worker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (downloader.CheckMang)
            {
                if (downloader.CheckLink)
                {
                    if (downloader.DsLink128.Count > 0)
                    {
                        rdb128.Enabled = true; DsLink128 = downloader.DsLink128; TotalSize128 = downloader.TotalSize128;
                    }

                    if (downloader.DsLink320.Count > 0)
                    {
                        rdb320.Enabled = true; DsLink320 = downloader.DsLink320; TotalSize320 = downloader.TotalSize320;
                    }

                    if (downloader.DsLinkLossLess.Count > 0)
                    {
                        rdbFlac.Enabled = true; DsLinkLossless = downloader.DsLinkLossLess; TotalSizeLossless = downloader.TotalSizeLossLess;
                    }
                    if (downloader.DsLink128.Count > 0 || downloader.DsLink320.Count > 0 || downloader.DsLinkLossLess.Count > 0)
                    {
                        btnGo.Enabled = true; TenAlbum = downloader.TenAlbum;
                    }
                }
                else MyMessageBox.ShowMessage("Link bạn nhập đã bị lỗi, hãy kiểm tra lại !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else { MyMessageBox.ShowMessage("Hãy kiểm tra lại kết nối mạng của bạn !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            progressbar.animated = false;
            progressbar.Value = 0;
        }

        private void Worker1_DoWork(object sender, DoWorkEventArgs e)
        {
            downloader.GetLinkAlbum();
        }
        #region Biến
        ChiaSeNhacDownloader downloader = new ChiaSeNhacDownloader();
        BackgroundWorker worker1 = new BackgroundWorker();
        BackgroundWorker worker2 = new BackgroundWorker();
        string link128;
        string link320;
        string linkLossless;
        string tenAlbum;
        double size128; double size320; double sizeLossless; double totalSize128; double totalSize320; double totalSizeLossless;
        bool isAlbum = true;
        List<string> dsLink128 = new List<string>();
        List<string> dsLink320 = new List<string>();
        List<string> dsLinkLossless = new List<string>();
        public string Link128 { get => link128; set => link128 = value; }
        public string Link320 { get => link320; set => link320 = value; }
        public string LinkLossless { get => linkLossless; set => linkLossless = value; }
        public double Size128 { get => size128; set => size128 = value; }
        public double Size320 { get => size320; set => size320 = value; }
        public double SizeLossless { get => sizeLossless; set => sizeLossless = value; }
        public double TotalSize128 { get => totalSize128; set => totalSize128 = value; }
        public double TotalSize320 { get => totalSize320; set => totalSize320 = value; }
        public double TotalSizeLossless { get => totalSizeLossless; set => totalSizeLossless = value; }
        public List<string> DsLink128 { get => dsLink128; set => dsLink128 = value; }
        public List<string> DsLink320 { get => dsLink320; set => dsLink320 = value; }
        public List<string> DsLinkLossless { get => dsLinkLossless; set => dsLinkLossless = value; }
        public bool IsAlbum { get => isAlbum; set => isAlbum = value; }
        public string TenAlbum { get => tenAlbum; set => tenAlbum = value; }
        #endregion

        private void btnPaste_Click(object sender, EventArgs e)
        {
            txbLink.ResetText();
            txbLink.Text = Clipboard.GetText();
            downloader.Link = txbLink.Text;
            Disable();
            DsLink128.Clear(); DsLink320.Clear(); DsLinkLossless.Clear();
            if (txbLink.Text.Contains("nghe-album") && txbLink.Text.Contains("chiasenhac.vn") )
            {
                progressbar.animated = true;
                progressbar.Value = 20;
                IsAlbum = true;
                worker1.RunWorkerAsync();
            }
            else if((txbLink.Text.Contains("mp3") || txbLink.Text.Contains("nhac-hot")) && txbLink.Text.Contains("chiasenhac.vn") )
            {
                progressbar.animated = true;
                progressbar.Value = 20;
                IsAlbum = false;
                worker2.RunWorkerAsync();
            }
            else MyMessageBox.ShowMessage("Link bạn nhập không đúng, hãy kiểm tra lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (rdb128.Checked || rdb320.Checked || rdbFlac.Checked)
            {
                Download download = new Download(this, rdb128.Checked, rdb320.Checked, rdbFlac.Checked, ckbAmbao.Checked, IsAlbum, TenAlbum, downloader.BeatIndex);
                download.ShowDialog();
            }
            else MyMessageBox.ShowMessage("Bạn chưa chọn chất lượng file tải !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Disable()
        {
            btnGo.Enabled=rdb128.Enabled = rdb320.Enabled = rdbFlac.Enabled = false;
            
        }

        private void txbLink_OnValueChanged(object sender, EventArgs e)
        {
            Disable();
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            Process.Start("mailto:leminhthanh1998@outlook.com");
        }

        private void btnWeb_Click(object sender, EventArgs e)
        {
            Process.Start("http://lêminhthành.vn");
        }
    }
}
