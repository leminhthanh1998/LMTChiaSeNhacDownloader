namespace CSNDownloader
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelTieude = new System.Windows.Forms.Panel();
            this.labelTieude = new MaterialSkin.Controls.MaterialLabel();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.txbLink = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ckbAmbao = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnGo = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnWeb = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnEmail = new Bunifu.Framework.UI.BunifuImageButton();
            this.rdbFlac = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdb320 = new MaterialSkin.Controls.MaterialRadioButton();
            this.labelChatluong = new MaterialSkin.Controls.MaterialLabel();
            this.labelLink = new MaterialSkin.Controls.MaterialLabel();
            this.rdb128 = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnPaste = new Bunifu.Framework.UI.BunifuImageButton();
            this.labelTacgia = new MaterialSkin.Controls.MaterialLabel();
            this.progressbar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTieude.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnWeb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPaste)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panelTieude
            // 
            this.panelTieude.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.panelTieude.Controls.Add(this.labelTieude);
            this.panelTieude.Controls.Add(this.btnClose);
            this.panelTieude.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTieude.Location = new System.Drawing.Point(0, 0);
            this.panelTieude.Name = "panelTieude";
            this.panelTieude.Size = new System.Drawing.Size(531, 40);
            this.panelTieude.TabIndex = 0;
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
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(493, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelTieude;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.labelTieude;
            this.bunifuDragControl2.Vertical = true;
            // 
            // txbLink
            // 
            this.txbLink.BackColor = System.Drawing.Color.White;
            this.txbLink.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.txbLink.BorderColorIdle = System.Drawing.Color.Black;
            this.txbLink.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.txbLink.BorderThickness = 2;
            this.txbLink.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbLink.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbLink.ForeColor = System.Drawing.Color.Black;
            this.txbLink.isPassword = false;
            this.txbLink.Location = new System.Drawing.Point(63, 26);
            this.txbLink.Margin = new System.Windows.Forms.Padding(4);
            this.txbLink.Name = "txbLink";
            this.txbLink.Size = new System.Drawing.Size(383, 31);
            this.txbLink.TabIndex = 0;
            this.txbLink.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbLink.OnValueChanged += new System.EventHandler(this.txbLink_OnValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ckbAmbao);
            this.panel2.Controls.Add(this.materialLabel1);
            this.panel2.Controls.Add(this.btnGo);
            this.panel2.Controls.Add(this.btnWeb);
            this.panel2.Controls.Add(this.btnEmail);
            this.panel2.Controls.Add(this.rdbFlac);
            this.panel2.Controls.Add(this.rdb320);
            this.panel2.Controls.Add(this.labelChatluong);
            this.panel2.Controls.Add(this.labelLink);
            this.panel2.Controls.Add(this.rdb128);
            this.panel2.Controls.Add(this.btnPaste);
            this.panel2.Controls.Add(this.txbLink);
            this.panel2.Controls.Add(this.labelTacgia);
            this.panel2.Controls.Add(this.progressbar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(531, 400);
            this.panel2.TabIndex = 1;
            // 
            // ckbAmbao
            // 
            this.ckbAmbao.AutoSize = true;
            this.ckbAmbao.Depth = 0;
            this.ckbAmbao.Font = new System.Drawing.Font("Roboto", 10F);
            this.ckbAmbao.Location = new System.Drawing.Point(156, 121);
            this.ckbAmbao.Margin = new System.Windows.Forms.Padding(0);
            this.ckbAmbao.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ckbAmbao.MouseState = MaterialSkin.MouseState.HOVER;
            this.ckbAmbao.Name = "ckbAmbao";
            this.ckbAmbao.Ripple = true;
            this.ckbAmbao.Size = new System.Drawing.Size(26, 30);
            this.ckbAmbao.TabIndex = 25;
            this.ckbAmbao.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 125);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(150, 19);
            this.materialLabel1.TabIndex = 23;
            this.materialLabel1.Text = "Âm báo khi tải xong: ";
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.Transparent;
            this.btnGo.Image = ((System.Drawing.Image)(resources.GetObject("btnGo.Image")));
            this.btnGo.ImageActive = null;
            this.btnGo.Location = new System.Drawing.Point(229, 146);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(60, 60);
            this.btnGo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnGo.TabIndex = 21;
            this.btnGo.TabStop = false;
            this.btnGo.Zoom = 10;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnWeb
            // 
            this.btnWeb.BackColor = System.Drawing.Color.Transparent;
            this.btnWeb.Image = ((System.Drawing.Image)(resources.GetObject("btnWeb.Image")));
            this.btnWeb.ImageActive = null;
            this.btnWeb.Location = new System.Drawing.Point(47, 369);
            this.btnWeb.Name = "btnWeb";
            this.btnWeb.Size = new System.Drawing.Size(38, 30);
            this.btnWeb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnWeb.TabIndex = 20;
            this.btnWeb.TabStop = false;
            this.btnWeb.Zoom = 10;
            this.btnWeb.Click += new System.EventHandler(this.btnWeb_Click);
            // 
            // btnEmail
            // 
            this.btnEmail.BackColor = System.Drawing.Color.Transparent;
            this.btnEmail.Image = ((System.Drawing.Image)(resources.GetObject("btnEmail.Image")));
            this.btnEmail.ImageActive = null;
            this.btnEmail.Location = new System.Drawing.Point(3, 369);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(38, 30);
            this.btnEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEmail.TabIndex = 19;
            this.btnEmail.TabStop = false;
            this.btnEmail.Zoom = 10;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // rdbFlac
            // 
            this.rdbFlac.AutoSize = true;
            this.rdbFlac.Depth = 0;
            this.rdbFlac.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdbFlac.Location = new System.Drawing.Point(360, 78);
            this.rdbFlac.Margin = new System.Windows.Forms.Padding(0);
            this.rdbFlac.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbFlac.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbFlac.Name = "rdbFlac";
            this.rdbFlac.Ripple = true;
            this.rdbFlac.Size = new System.Drawing.Size(83, 30);
            this.rdbFlac.TabIndex = 14;
            this.rdbFlac.TabStop = true;
            this.rdbFlac.Text = "Lossless";
            this.rdbFlac.UseVisualStyleBackColor = true;
            // 
            // rdb320
            // 
            this.rdb320.AutoSize = true;
            this.rdb320.Depth = 0;
            this.rdb320.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdb320.Location = new System.Drawing.Point(239, 78);
            this.rdb320.Margin = new System.Windows.Forms.Padding(0);
            this.rdb320.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdb320.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdb320.Name = "rdb320";
            this.rdb320.Ripple = true;
            this.rdb320.Size = new System.Drawing.Size(86, 30);
            this.rdb320.TabIndex = 13;
            this.rdb320.TabStop = true;
            this.rdb320.Text = "320 kbps";
            this.rdb320.UseVisualStyleBackColor = true;
            // 
            // labelChatluong
            // 
            this.labelChatluong.AutoSize = true;
            this.labelChatluong.Depth = 0;
            this.labelChatluong.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelChatluong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelChatluong.Location = new System.Drawing.Point(12, 83);
            this.labelChatluong.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelChatluong.Name = "labelChatluong";
            this.labelChatluong.Size = new System.Drawing.Size(90, 19);
            this.labelChatluong.TabIndex = 12;
            this.labelChatluong.Text = "Chất lượng: ";
            // 
            // labelLink
            // 
            this.labelLink.AutoSize = true;
            this.labelLink.Depth = 0;
            this.labelLink.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelLink.Location = new System.Drawing.Point(12, 33);
            this.labelLink.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelLink.Name = "labelLink";
            this.labelLink.Size = new System.Drawing.Size(41, 19);
            this.labelLink.TabIndex = 2;
            this.labelLink.Text = "Link:";
            // 
            // rdb128
            // 
            this.rdb128.AutoSize = true;
            this.rdb128.Depth = 0;
            this.rdb128.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdb128.Location = new System.Drawing.Point(116, 78);
            this.rdb128.Margin = new System.Windows.Forms.Padding(0);
            this.rdb128.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdb128.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdb128.Name = "rdb128";
            this.rdb128.Ripple = true;
            this.rdb128.Size = new System.Drawing.Size(86, 30);
            this.rdb128.TabIndex = 11;
            this.rdb128.TabStop = true;
            this.rdb128.Text = "128 kbps";
            this.rdb128.UseVisualStyleBackColor = true;
            // 
            // btnPaste
            // 
            this.btnPaste.BackColor = System.Drawing.Color.Transparent;
            this.btnPaste.Image = ((System.Drawing.Image)(resources.GetObject("btnPaste.Image")));
            this.btnPaste.ImageActive = null;
            this.btnPaste.Location = new System.Drawing.Point(460, 22);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(40, 40);
            this.btnPaste.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPaste.TabIndex = 3;
            this.btnPaste.TabStop = false;
            this.btnPaste.Zoom = 10;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // labelTacgia
            // 
            this.labelTacgia.AutoSize = true;
            this.labelTacgia.BackColor = System.Drawing.Color.Transparent;
            this.labelTacgia.Depth = 0;
            this.labelTacgia.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelTacgia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelTacgia.Location = new System.Drawing.Point(307, 380);
            this.labelTacgia.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelTacgia.Name = "labelTacgia";
            this.labelTacgia.Size = new System.Drawing.Size(227, 19);
            this.labelTacgia.TabIndex = 18;
            this.labelTacgia.Text = "Copyright © 2018 Le Minh Thanh";
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
            this.progressbar.LabelVisible = false;
            this.progressbar.LineProgressThickness = 8;
            this.progressbar.LineThickness = 5;
            this.progressbar.Location = new System.Drawing.Point(163, 202);
            this.progressbar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.progressbar.MaxValue = 100;
            this.progressbar.Name = "progressbar";
            this.progressbar.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.progressbar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.progressbar.Size = new System.Drawing.Size(192, 192);
            this.progressbar.TabIndex = 22;
            this.progressbar.Value = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Link bài hát hoặc album";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 440);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTieude);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LMT ChiaSeNhac Downloader";
            this.panelTieude.ResumeLayout(false);
            this.panelTieude.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnWeb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPaste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panelTieude;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton btnPaste;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbLink;
        private MaterialSkin.Controls.MaterialRadioButton rdbFlac;
        private MaterialSkin.Controls.MaterialRadioButton rdb320;
        private MaterialSkin.Controls.MaterialLabel labelChatluong;
        private MaterialSkin.Controls.MaterialLabel labelLink;
        private MaterialSkin.Controls.MaterialRadioButton rdb128;
        private MaterialSkin.Controls.MaterialLabel labelTieude;
        private Bunifu.Framework.UI.BunifuImageButton btnWeb;
        private Bunifu.Framework.UI.BunifuImageButton btnEmail;
        private Bunifu.Framework.UI.BunifuImageButton btnGo;
        private Bunifu.Framework.UI.BunifuCircleProgressbar progressbar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCheckBox ckbAmbao;
        private MaterialSkin.Controls.MaterialLabel labelTacgia;
        private System.Windows.Forms.Label label1;
    }
}

