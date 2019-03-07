using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Windows.Shell;
using System.Media;

namespace CSNDownloader
{
    public partial class Download : Form
    {
        public Download(frmMain formMain, bool rdb128, bool rdb320, bool rdbLossless, bool ckbAmBao, bool isAlbum, string TenAlbum, List<int>beatIndex)
        {
            InitializeComponent();
            _formMain = formMain;
            _rdb128 = rdb128;
            _rdb320 = rdb320;
            _rdbLossless = rdbLossless;
            _isAlbum = isAlbum;
            _ckbAmBao = ckbAmBao;
            tenAlbum = TenAlbum;
            BeatIndex = beatIndex;
            wc.DownloadProgressChanged += Wc_DownloadProgressChanged;
            wc.DownloadFileCompleted += Wc_DownloadFileCompleted;
            wc2.DownloadProgressChanged += Wc2_DownloadProgressChanged;
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            worker.WorkerSupportsCancellation = true;
        }

        #region Var
        frmMain _formMain;
        int dem = 0;
        bool _rdb128; bool _rdb320; bool _rdbLossless; bool _isAlbum; bool _ckbAmBao; bool cancelDownload=false;
        double size128; double size320; double sizeLossless; double totalSize128; double totalSize320; double totalSizeLossless;double phanTram; double totalSize; 
        string link128;
        string link320;
        string linkLossless;
        string fileName;
        string tenAlbum;
        List<string> dsLink128 = new List<string>();
        List<string> dsLink320 = new List<string>();
        List<string> dsLinkLossless = new List<string>();
        List<string> dsLink = new List<string>();
        private List<int> BeatIndex = new List<int>();
        #endregion

        #region Tien trinh download
        private void Wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if(_ckbAmBao)
            { player.Play(); }
            if (cancelDownload)
            {
                MyMessageBox.ShowMessage("Đã hủy tải file về !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MyMessageBox.ShowMessage("Đã tải về thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void Wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressbar.Value = e.ProgressPercentage;
            double receive = double.Parse(e.BytesReceived.ToString());
                labelDownloading.Invoke(new MethodInvoker(delegate { labelDownloading.Text = string.Format("{0:0.##} MB", receive / 1024 / 1024); }));
            
        }
        
        private void Wc2_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double receive = double.Parse(e.BytesReceived.ToString());
            totalSize= double.Parse(e.TotalBytesToReceive.ToString());
            phanTram = receive /totalSize*100;
                progressbar.Invoke(new MethodInvoker(delegate { progressbar.Value = int.Parse(Math.Truncate(phanTram).ToString()); }));
                labelDownloading.Invoke(new MethodInvoker(delegate { labelDownloading.Text = string.Format("{0:0.##} MB", receive / 1024 / 1024); }));
            
        }


        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(_ckbAmBao)
            { player.Play(); }
            if (cancelDownload)
            {
                MyMessageBox.ShowMessage(string.Format("Đã hủy tải {0} file về !", dem), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MyMessageBox.ShowMessage("Đã tải về thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            
            for (int i = 0; i < dsLink.Count; i++)
            {
                fileName = GetFileName(dsLink[i]);
                if (BeatIndex.Contains(i))
                {
                    fileName = fileName.Replace(".flac", "").Replace(".mp3", "") + " Beat" +
                               Path.GetExtension(txbPath.Text + "\\" + fileName);
                }
                labelFileName.Invoke(new MethodInvoker(delegate { labelFileName.Text = fileName; }));
                wc2.DownloadFileAsync(new Uri(dsLink[i]), txbPath.Text + "\\" + fileName);
                while (wc2.IsBusy)
                {
                    System.Threading.Thread.Sleep(500);
                }
            }

        }
        #endregion


        SoundPlayer player = new SoundPlayer(Properties.Resources.beep_07);
        WebClient wc = new WebClient();
        WebClient wc2 = new WebClient();
        BackgroundWorker worker = new BackgroundWorker();

        /// <summary>
        /// Load các thông tin từ bên form chính
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Download_Load(object sender, EventArgs e)
        {
            dsLink128.Clear();dsLink320.Clear();dsLinkLossless.Clear();dsLink.Clear();
            labelFileName.MaximumSize = new Size(390, 0);
            labelFileName.AutoSize = true;
            if (_isAlbum)
            {
                labelFileName.Text = tenAlbum;
                if (_rdb128)
                {
                    dsLink128 = _formMain.DsLink128;
                    totalSize128 = _formMain.TotalSize128;
                    labelFileSize.Text = string.Format("{0:##.00} MB ({1} bài hát)", totalSize128, dsLink128.Count);
                }
                if(_rdb320)
                {
                    dsLink320 = _formMain.DsLink320;
                    totalSize320 = _formMain.TotalSize320;
                    labelFileSize.Text = string.Format("{0:##.00} MB ({1} bài hát)", totalSize320, dsLink320.Count);
                }
                if(_rdbLossless)
                {
                    dsLinkLossless = _formMain.DsLinkLossless;
                    totalSizeLossless = _formMain.TotalSizeLossless;
                    labelFileSize.Text = string.Format("{0:##.00} MB ({1} bài hát)", totalSizeLossless, dsLinkLossless.Count);
                }
            }
            else
            {
                if (_rdb128)
                {
                    link128 = _formMain.Link128;
                    size128 = _formMain.Size128;
                    fileName=GetFileName(link128);
                    labelFileSize.Text = string.Format("{0:##.00} MB", size128);
                }
                if (_rdb320)
                {
                    link320 = _formMain.Link320;
                    size320 = _formMain.Size320;
                    fileName=GetFileName(link320);
                    labelFileSize.Text = string.Format("{0:##.00} MB", size320);
                }
                if (_rdbLossless)
                {
                    linkLossless = _formMain.LinkLossless;
                    sizeLossless = _formMain.SizeLossless;
                    fileName=GetFileName(linkLossless);
                    labelFileSize.Text = string.Format("{0:##.00} MB", sizeLossless);
                }
                labelFileName.Text = fileName;
            }

        }

       

        /// <summary>
        /// Lấy tên file nhạc sẽ tải
        /// </summary>
        /// <param name="link"></param>
        private string GetFileName(string link)
        {
            Uri uri = new Uri(link);
            
            return System.IO.Path.GetFileName(uri.AbsolutePath).Replace("%20"," ").Replace("%5B","[").Replace("%5D","]");
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            btnGo.Enabled = false;
            if (txbPath.Text != "")
            {
                if (_isAlbum)
                {
                    if (_rdb128)
                    {
                        dsLink = dsLink128;
                        worker.RunWorkerAsync();
                    }
                    if (_rdb320)
                    {
                        dsLink = dsLink320;
                        worker.RunWorkerAsync();
                    }
                    if (_rdbLossless)
                    {
                        dsLink = dsLinkLossless;
                        worker.RunWorkerAsync();
                    }
                }
                else
                {
                    if (_rdb128)
                    {
                        wc.DownloadFileAsync(new System.Uri(link128), txbPath.Text + "\\" + fileName);
                    }
                    if (_rdb320)
                    {
                        wc.DownloadFileAsync(new System.Uri(link320), txbPath.Text + "\\" + fileName);
                    }
                    if (_rdbLossless)
                    {
                        wc.DownloadFileAsync(new System.Uri(linkLossless), txbPath.Text + "\\" + fileName);
                    }
                }
            }
            else { MyMessageBox.ShowMessage("Bạn chưa chọn nơi lưu file !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); btnGo.Enabled = true; }
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folder = new FolderBrowserDialog() { Description = "Chọn thư mục để lưu file nhạc !" })
            {
                if(folder.ShowDialog()==DialogResult.OK)
                {
                    txbPath.Text = folder.SelectedPath;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancelDownload = true;
            if (_isAlbum)
            {
                //if(worker.IsBusy)
                worker.CancelAsync();
                wc2.CancelAsync();
                dem++;
            }
            else wc.CancelAsync();
        }
    }
    
}
