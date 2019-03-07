namespace CSNDownloader
{
    partial class Download
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Download));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.labelTieude = new MaterialSkin.Controls.MaterialLabel();
            this.panelTieude = new System.Windows.Forms.Panel();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.labelTen = new MaterialSkin.Controls.MaterialLabel();
            this.labelFileName = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.labelFileSize = new MaterialSkin.Controls.MaterialLabel();
            this.labelPath = new MaterialSkin.Controls.MaterialLabel();
            this.txbPath = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnPath = new Bunifu.Framework.UI.BunifuImageButton();
            this.progressbar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnGo = new Bunifu.Framework.UI.BunifuImageButton();
            this.labelDownloading = new MaterialSkin.Controls.MaterialLabel();
            this.btnCancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.panelTieude.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGo)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // labelTieude
            // 
            this.labelTieude.AutoSize = true;
            this.labelTieude.Depth = 0;
            this.labelTieude.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelTieude.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelTieude.Location = new System.Drawing.Point(3, 12);
            this.labelTieude.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelTieude.Name = "labelTieude";
            this.labelTieude.Size = new System.Drawing.Size(233, 19);
            this.labelTieude.TabIndex = 1;
            this.labelTieude.Text = "LMT ChiaSeNhac Downloader 1.0";
            // 
            // panelTieude
            // 
            this.panelTieude.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.panelTieude.Controls.Add(this.btnClose);
            this.panelTieude.Controls.Add(this.labelTieude);
            this.panelTieude.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTieude.Location = new System.Drawing.Point(0, 0);
            this.panelTieude.Name = "panelTieude";
            this.panelTieude.Size = new System.Drawing.Size(465, 40);
            this.panelTieude.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(426, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelTen
            // 
            this.labelTen.AutoSize = true;
            this.labelTen.Depth = 0;
            this.labelTen.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelTen.Location = new System.Drawing.Point(4, 53);
            this.labelTen.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelTen.Name = "labelTen";
            this.labelTen.Size = new System.Drawing.Size(38, 19);
            this.labelTen.TabIndex = 2;
            this.labelTen.Text = "Tên:";
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Depth = 0;
            this.labelFileName.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelFileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelFileName.Location = new System.Drawing.Point(95, 53);
            this.labelFileName.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(0, 19);
            this.labelFileName.TabIndex = 3;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(4, 97);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(85, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Kích thước:";
            // 
            // labelFileSize
            // 
            this.labelFileSize.AutoSize = true;
            this.labelFileSize.Depth = 0;
            this.labelFileSize.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelFileSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelFileSize.Location = new System.Drawing.Point(95, 97);
            this.labelFileSize.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelFileSize.Name = "labelFileSize";
            this.labelFileSize.Size = new System.Drawing.Size(0, 19);
            this.labelFileSize.TabIndex = 5;
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Depth = 0;
            this.labelPath.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelPath.Location = new System.Drawing.Point(4, 134);
            this.labelPath.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(62, 19);
            this.labelPath.TabIndex = 6;
            this.labelPath.Text = "Nơi lưu:";
            // 
            // txbPath
            // 
            this.txbPath.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.txbPath.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbPath.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.txbPath.BorderThickness = 2;
            this.txbPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbPath.Enabled = false;
            this.txbPath.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbPath.isPassword = false;
            this.txbPath.Location = new System.Drawing.Point(99, 126);
            this.txbPath.Margin = new System.Windows.Forms.Padding(4);
            this.txbPath.Name = "txbPath";
            this.txbPath.Size = new System.Drawing.Size(320, 31);
            this.txbPath.TabIndex = 7;
            this.txbPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnPath
            // 
            this.btnPath.BackColor = System.Drawing.Color.Transparent;
            this.btnPath.Image = ((System.Drawing.Image)(resources.GetObject("btnPath.Image")));
            this.btnPath.ImageActive = null;
            this.btnPath.Location = new System.Drawing.Point(424, 127);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(30, 30);
            this.btnPath.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPath.TabIndex = 8;
            this.btnPath.TabStop = false;
            this.btnPath.Zoom = 10;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // progressbar
            // 
            this.progressbar.animated = false;
            this.progressbar.animationIterval = 5;
            this.progressbar.animationSpeed = 50;
            this.progressbar.BackColor = System.Drawing.Color.Transparent;
            this.progressbar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progressbar.BackgroundImage")));
            this.progressbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.progressbar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.progressbar.LabelVisible = true;
            this.progressbar.LineProgressThickness = 8;
            this.progressbar.LineThickness = 5;
            this.progressbar.Location = new System.Drawing.Point(134, 231);
            this.progressbar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.progressbar.MaxValue = 100;
            this.progressbar.Name = "progressbar";
            this.progressbar.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.progressbar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.progressbar.Size = new System.Drawing.Size(201, 201);
            this.progressbar.TabIndex = 9;
            this.progressbar.Value = 0;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.labelTieude;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.panelTieude;
            this.bunifuDragControl2.Vertical = true;
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.Transparent;
            this.btnGo.Image = ((System.Drawing.Image)(resources.GetObject("btnGo.Image")));
            this.btnGo.ImageActive = null;
            this.btnGo.Location = new System.Drawing.Point(205, 174);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(60, 60);
            this.btnGo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnGo.TabIndex = 22;
            this.btnGo.TabStop = false;
            this.btnGo.Zoom = 10;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // labelDownloading
            // 
            this.labelDownloading.AutoSize = true;
            this.labelDownloading.Depth = 0;
            this.labelDownloading.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelDownloading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelDownloading.Location = new System.Drawing.Point(207, 358);
            this.labelDownloading.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelDownloading.Name = "labelDownloading";
            this.labelDownloading.Size = new System.Drawing.Size(43, 19);
            this.labelDownloading.TabIndex = 23;
            this.labelDownloading.Text = "0 MB";
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Depth = 0;
            this.btnCancel.Location = new System.Drawing.Point(211, 429);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = false;
            this.btnCancel.Size = new System.Drawing.Size(39, 36);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Download
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 470);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.labelDownloading);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.progressbar);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.txbPath);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.labelFileSize);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.labelTen);
            this.Controls.Add(this.panelTieude);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Download";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Download";
            this.Load += new System.EventHandler(this.Download_Load);
            this.panelTieude.ResumeLayout(false);
            this.panelTieude.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panelTieude;
        private MaterialSkin.Controls.MaterialLabel labelTieude;
        private MaterialSkin.Controls.MaterialLabel labelPath;
        private MaterialSkin.Controls.MaterialLabel labelFileSize;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel labelFileName;
        private MaterialSkin.Controls.MaterialLabel labelTen;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbPath;
        private Bunifu.Framework.UI.BunifuCircleProgressbar progressbar;
        private Bunifu.Framework.UI.BunifuImageButton btnPath;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuImageButton btnGo;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private MaterialSkin.Controls.MaterialLabel labelDownloading;
        private MaterialSkin.Controls.MaterialFlatButton btnCancel;
    }
}