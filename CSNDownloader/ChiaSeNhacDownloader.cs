using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Text.RegularExpressions;
using System.Net.Http;
using System.IO;

namespace CSNDownloader
{
    class ChiaSeNhacDownloader
    {
        #region Biến
        private string link;
        private string link128;
        private string link320;
        private string lossless;
        private string tenAlbum;
        private double size128;
        private double size320;
        private double sizeLossLess;
        private double totalSize128 = 0;
        private double totalSize320 = 0;
        private double totalSizeLossLess = 0;
        private List<string> dsLinkBaiHatCSN = new List<string>();
        private List<string> dsLink128 = new List<string>();
        private List<string> dsLink320 = new List<string>();
        private List<string> dsLinkLossLess = new List<string>();
        private bool checkMang = true;
        private bool checkLink = true;

        public string Link128 { get => link128; set => link128 = value; }
        public string Link320 { get => link320; set => link320 = value; }
        public string Lossless { get => lossless; set => lossless = value; }
        public bool CheckMang { get => checkMang; set => checkMang = value; }
        public bool CheckLink { get => checkLink; set => checkLink = value; }
        public string Link { get => link; set => link = value; }
        public double Size128 { get => size128; set => size128 = value; }
        public double Size320 { get => size320; set => size320 = value; }
        public double SizeLossLess { get => sizeLossLess; set => sizeLossLess = value; }
        public List<string> DsLinkBaiHatCSN { get => dsLinkBaiHatCSN; set => dsLinkBaiHatCSN = value; }
        public List<string> DsLink128 { get => dsLink128; set => dsLink128 = value; }
        public List<string> DsLink320 { get => dsLink320; set => dsLink320 = value; }
        public List<string> DsLinkLossLess { get => dsLinkLossLess; set => dsLinkLossLess = value; }
        public double TotalSize128 { get => totalSize128; set => totalSize128 = value; }
        public double TotalSize320 { get => totalSize320; set => totalSize320 = value; }
        public double TotalSizeLossLess { get => totalSizeLossLess; set => totalSizeLossLess = value; }
        public string TenAlbum { get => tenAlbum; set => tenAlbum = value; }
        WebClient wc = new WebClient();
        public List<int> BeatIndex { get; set; }
        #endregion

        /// <summary>
        /// Lấy link download bài hát trên chiasenhac
        /// </summary>
        public void GetLinkBaiHat()
        {
            CheckLink = CheckMang = true;
            string text = "";
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                try
                {
                    text = wc.DownloadString(Link);
                }
                catch (Exception)
                {
                    CheckLink = false;
                }
                MatchCollection linkdownload = Regex.Matches(text, "(?i)\\s*http://chiasenhac.vn/mp3\\s*\\s*(\"([^\"]*\")|'[^']*'|([^'\">]+))");
                string linkTai = "";
                try
                {
                    if (linkdownload[0].Value.Contains("_download"))
                    {
                        linkTai = linkdownload[0].Value;
                    }
                }
                catch (Exception)
                {
                    CheckLink = false;
                }
                if (linkTai != "")
                {
                    GetDirectLink(linkTai);
                }
                else CheckLink = false;
            }
            else CheckMang = false;
        }

        /// <summary>
        /// Lấy link tải trực tiếp bài hát với các chất lượng như 128, 320 và lossless
        /// </summary>
        /// <param name="linkTai"></param>
        private void GetDirectLink(string linkTai)
        {
            string linkMau128 = ""; string linkMau320 = ""; string linkMauLossless = "";
            string text2 = wc.DownloadString(linkTai);
            MatchCollection link = Regex.Matches(text2, "(?i)\\s*http://data\\s*\\s*(\"([^\"]*\")|'[^']*'|([^'\">]+))");
            foreach (Match item in link)
            {
                if (item.Value.Contains("download"))
                {
                    linkMau128 = item.Value;
                    break;
                }
            }
            linkMau320 = linkMau128.Replace("[128kbps_MP3].mp3", "[320kbps_mp3].mp3").Replace("/128", "/320");
            linkMauLossless = linkMau320.Replace("[320kbps_mp3].mp3", "[Lossless_FLAC].flac").Replace("/320", "/flac");

            if (CheckLinkExist(ChuanHoaLink(linkMau128)))
            {
                Link128 = ChuanHoaLink(linkMau128);
                Size128 = GetFileSize(Link128) / 1024 / 1024;
                if (Size128 == 0) Link128 = null;
            }
            if (CheckLinkExist(ChuanHoaLink(linkMau320)))
            {
                Link320 = ChuanHoaLink(linkMau320);
                Size320 = GetFileSize(Link320) / 1024 / 1024;
                if (Size320 == 0) Link320 = null;
            }
            if (CheckLinkExist(ChuanHoaLink(linkMauLossless)))
            {
                Lossless = ChuanHoaLink(linkMauLossless);
                SizeLossLess = GetFileSize(Lossless) / 1024 / 1024;
                if (SizeLossLess == 0) Lossless = null;
            }
        }

        /// <summary>
        /// Lấy link tải các bài hát trong album của chia se nhac 
        /// </summary>
        public void GetLinkAlbum()
        {
            CheckLink = CheckMang = true;
            DsLink128.Clear(); DsLink320.Clear(); DsLinkLossLess.Clear(); DsLinkBaiHatCSN.Clear();
            BeatIndex = new List<int>();
            TotalSize128 = TotalSize320 = TotalSizeLossLess = 0;
            string text = "";
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                try
                {
                    WebClient wc = new WebClient();
                    wc.Encoding = UTF8Encoding.UTF8;
                    text = wc.DownloadString(Link);
                }
                catch (Exception)
                {
                    CheckLink = false;
                }
                if (CheckMang)
                {
                    try
                    {
                        MatchCollection linkdownload = Regex.Matches(text, "(?i)\\s*http://chiasenhac.vn/nghe-album\\s*\\s*(\"([^\"]*\")|'[^']*'|([^'\">]+))");
                        foreach (Match item in linkdownload)
                        {
                            dsLinkBaiHatCSN.Add(GetLinkDownload(item.Value));
                        }
                        dsLinkBaiHatCSN = xoaTrungLap(dsLinkBaiHatCSN);
                        if (dsLinkBaiHatCSN.Count == 0) CheckLink = false;
                    }
                    catch (Exception)
                    {
                        CheckLink = false;
                    }
                    try
                    {
                        MatchCollection tenalbum = Regex.Matches(text, "(?i)\\s*Album:\\s*\\s*(\"([^\"]*\")|'[^']*'|([^'\">]+))");
                        TenAlbum = tenalbum[1].Value.Replace("</span", "");
                    }
                    catch (Exception)
                    { }
                }
                if (CheckLink)
                {
                    try
                    {
                        MatchCollection sobaihat = Regex.Matches(text, "(?i)\\s*playlist-\\s*\\s*(\"([^\"]*\")|'[^']*'|([^'\">]+))");
                        if (sobaihat.Count == 0) CheckLink = false;
                        for (int i = 0; i < sobaihat.Count - 2; i++)
                        {
                            GetDirectLink(DsLinkBaiHatCSN[i]);
                            DsLink128.Add(Link128);
                            DsLink320.Add(Link320);
                            DsLinkLossLess.Add(Lossless);
                            if(dsLinkBaiHatCSN[i].Contains("beat-playback")) BeatIndex.Add(i);
                            TotalSize128 += Size128;
                            TotalSize320 += Size320;
                            TotalSizeLossLess += SizeLossLess;
                        }

                    }
                    catch (Exception) { CheckLink = false; }
                }
            }
            else CheckMang = false;
        }

        /// <summary>
        /// Lấy link download có dạng _download
        /// </summary>
        /// <param name="link"></param>
        /// <returns></returns>
        private string GetLinkDownload(string link)
        {
            WebClient wc = new WebClient();
            string text = wc.DownloadString(link);
            MatchCollection linkdownload = Regex.Matches(text, "(?i)\\s*http://chiasenhac.vn/mp3\\s*\\s*(\"([^\"]*\")|'[^']*'|([^'\">]+))");
            if (linkdownload[0].Value.Contains("_download"))
            {
                return linkdownload[0].Value;
            }
            return null;
        }




        /// <summary>
        /// Xuất ra danh sách đã loại bỏ hết các link trùng lập
        /// </summary>
        /// <param name="ds"></param>
        /// <returns></returns>
        public static List<string> xoaTrungLap(List<string> ds)
        {
            List<string> list = new List<string>();
            foreach (string item in ds)
            {
                if (!Contains(list, item))
                {
                    list.Add(item);
                }
            }
            return list;
        }
        private static bool Contains(List<string> list, string comparedValue)
        {
            bool result;
            foreach (string current in list)
            {
                if (current == comparedValue)
                {
                    result = true;
                    return result;
                }
            }
            result = false;
            return result;
        }


        /// <summary>
        /// Kiểm tra xem link có tồn tại hay không
        /// </summary>
        /// <param name="link"></param>
        /// <returns></returns>
        private bool CheckLinkExist(string link)
        {
            WebRequest webRequest = WebRequest.Create(link);
            WebResponse webResponse;
            try
            {
                webResponse = webRequest.GetResponse();
                webResponse.Close();
            }
            catch //If exception thrown then couldn't get response from address
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Trả về link đã được chuẩn hóa
        /// </summary>
        /// <param name="link"></param>
        /// <returns></returns>
        private string ChuanHoaLink(string link)
        {
            return  link.Replace(" ", "%20").Replace("[", "%5B").Replace("]", "%5D");
        }

        /// <summary>
        /// Lấy kích thước của file sẽ tải
        /// </summary>
        /// <param name="link"></param>
        /// <returns></returns>
        private double GetFileSize(string link)
        {
            System.Net.WebRequest req = System.Net.HttpWebRequest.Create(link);
            req.Method = "HEAD";
            using (System.Net.WebResponse resp = req.GetResponse())
            {
                double ContentLength;
                if (double.TryParse(resp.Headers.Get("Content-Length"), out ContentLength))
                {
                    return ContentLength;
                }
            }
            return 0;
        }

        
    }
}
