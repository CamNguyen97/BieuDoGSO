namespace SoSanhGia
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
			this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.lblStatus = new DevExpress.XtraBars.BarStaticItem();
			this.lblSystemTime = new DevExpress.XtraBars.BarStaticItem();
			this.btnSoSanh = new DevExpress.XtraBars.BarButtonItem();
			this.btnDSWebsite = new DevExpress.XtraBars.BarButtonItem();
			this.btnInfoApp = new DevExpress.XtraBars.BarButtonItem();
			this.btnInfoAuthor = new DevExpress.XtraBars.BarButtonItem();
			this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.Information = new DevExpress.XtraBars.BarHeaderItem();
			this.barWorkspaceMenuItem1 = new DevExpress.XtraBars.BarWorkspaceMenuItem();
			this.ribbonPageCategory1 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
			this.nhapKhau1 = new SoSanhGia.UC.nhapKhau();
			this.xuatKhau1 = new SoSanhGia.UC.XuatKhau();
			((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
			this.SuspendLayout();
			// 
			// ribbonPage1
			// 
			this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
			this.ribbonPage1.Name = "ribbonPage1";
			this.ribbonPage1.Text = "THAO TÁC";
			// 
			// ribbonPageGroup3
			// 
			this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem1);
			this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem2);
			this.ribbonPageGroup3.ItemLinks.Add(this.barButtonGroup1);
			this.ribbonPageGroup3.Name = "ribbonPageGroup3";
			// 
			// barButtonItem1
			// 
			this.barButtonItem1.Caption = "Information";
			this.barButtonItem1.Id = 7;
			this.barButtonItem1.Name = "barButtonItem1";
			// 
			// barButtonItem2
			// 
			this.barButtonItem2.Caption = "Author";
			this.barButtonItem2.Id = 9;
			this.barButtonItem2.Name = "barButtonItem2";
			// 
			// barButtonGroup1
			// 
			this.barButtonGroup1.Caption = "barButtonGroup1";
			this.barButtonGroup1.Id = 11;
			this.barButtonGroup1.Name = "barButtonGroup1";
			// 
			// ribbonPageGroup2
			// 
			this.ribbonPageGroup2.AllowTextClipping = false;
			this.ribbonPageGroup2.Name = "ribbonPageGroup2";
			this.ribbonPageGroup2.ShowCaptionButton = false;
			this.ribbonPageGroup2.Text = "THÔNG TIN";
			// 
			// ribbonPageGroup1
			// 
			this.ribbonPageGroup1.AllowTextClipping = false;
			this.ribbonPageGroup1.Name = "ribbonPageGroup1";
			this.ribbonPageGroup1.ShowCaptionButton = false;
			this.ribbonPageGroup1.Text = "THAO TÁC";
			// 
			// lblStatus
			// 
			this.lblStatus.Caption = "lblStatus";
			this.lblStatus.Id = 1;
			this.lblStatus.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lblStatus.ImageOptions.Image")));
			this.lblStatus.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("lblStatus.ImageOptions.LargeImage")));
			this.lblStatus.Name = "lblStatus";
			// 
			// lblSystemTime
			// 
			this.lblSystemTime.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
			this.lblSystemTime.Caption = "lblSystemTime";
			this.lblSystemTime.Id = 2;
			this.lblSystemTime.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lblSystemTime.ImageOptions.Image")));
			this.lblSystemTime.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("lblSystemTime.ImageOptions.LargeImage")));
			this.lblSystemTime.Name = "lblSystemTime";
			// 
			// btnSoSanh
			// 
			this.btnSoSanh.Caption = "So Sánh";
			this.btnSoSanh.Id = 3;
			this.btnSoSanh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSoSanh.ImageOptions.Image")));
			this.btnSoSanh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSoSanh.ImageOptions.LargeImage")));
			this.btnSoSanh.Name = "btnSoSanh";
			// 
			// btnDSWebsite
			// 
			this.btnDSWebsite.Caption = "DS WEBSITE";
			this.btnDSWebsite.Id = 4;
			this.btnDSWebsite.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDSWebsite.ImageOptions.Image")));
			this.btnDSWebsite.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDSWebsite.ImageOptions.LargeImage")));
			this.btnDSWebsite.Name = "btnDSWebsite";
			// 
			// btnInfoApp
			// 
			this.btnInfoApp.Caption = "Chương trình";
			this.btnInfoApp.Id = 5;
			this.btnInfoApp.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnInfoApp.ImageOptions.LargeImage")));
			this.btnInfoApp.Name = "btnInfoApp";
			// 
			// btnInfoAuthor
			// 
			this.btnInfoAuthor.Caption = "Tác giả";
			this.btnInfoAuthor.Id = 6;
			this.btnInfoAuthor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInfoAuthor.ImageOptions.Image")));
			this.btnInfoAuthor.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnInfoAuthor.ImageOptions.LargeImage")));
			this.btnInfoAuthor.Name = "btnInfoAuthor";
			// 
			// ribbon
			// 
			this.ribbon.ExpandCollapseItem.Id = 0;
			this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.lblStatus,
            this.lblSystemTime,
            this.btnSoSanh,
            this.btnDSWebsite,
            this.btnInfoApp,
            this.btnInfoAuthor,
            this.barButtonItem1,
            this.Information,
            this.barButtonItem2,
            this.barWorkspaceMenuItem1,
            this.barButtonGroup1});
			this.ribbon.Location = new System.Drawing.Point(0, 0);
			this.ribbon.MaxItemId = 12;
			this.ribbon.Name = "ribbon";
			this.ribbon.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.ribbonPageCategory1});
			this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
			this.ribbon.Size = new System.Drawing.Size(1051, 143);
			// 
			// Information
			// 
			this.Information.Caption = "Program";
			this.Information.Id = 8;
			this.Information.Name = "Information";
			// 
			// barWorkspaceMenuItem1
			// 
			this.barWorkspaceMenuItem1.Caption = "barWorkspaceMenuItem1";
			this.barWorkspaceMenuItem1.Id = 10;
			this.barWorkspaceMenuItem1.Name = "barWorkspaceMenuItem1";
			// 
			// ribbonPageCategory1
			// 
			this.ribbonPageCategory1.Name = "ribbonPageCategory1";
			this.ribbonPageCategory1.Text = "ribbonPageCategory1";
			// 
			// nhapKhau1
			// 
			this.nhapKhau1.Dock = System.Windows.Forms.DockStyle.Left;
			this.nhapKhau1.Location = new System.Drawing.Point(0, 143);
			this.nhapKhau1.Name = "nhapKhau1";
			this.nhapKhau1.Size = new System.Drawing.Size(715, 550);
			this.nhapKhau1.TabIndex = 5;
			// 
			// xuatKhau1
			// 
			this.xuatKhau1.Dock = System.Windows.Forms.DockStyle.Right;
			this.xuatKhau1.Location = new System.Drawing.Point(336, 143);
			this.xuatKhau1.Name = "xuatKhau1";
			this.xuatKhau1.Size = new System.Drawing.Size(715, 550);
			this.xuatKhau1.TabIndex = 6;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1051, 693);
			this.Controls.Add(this.xuatKhau1);
			this.Controls.Add(this.nhapKhau1);
			this.Controls.Add(this.ribbon);
			this.Name = "frmMain";
			this.Ribbon = this.ribbon;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MỐI QUAN HỆ GIỮA TỶ GIÁ XUẤT NHẬP KHẨU VỚI TỶ GIÁ USD";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmMain_Load);
			((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarStaticItem lblStatus;
        private DevExpress.XtraBars.BarStaticItem lblSystemTime;
        private DevExpress.XtraBars.BarButtonItem btnSoSanh;
        private DevExpress.XtraBars.BarButtonItem btnDSWebsite;
        private DevExpress.XtraBars.BarButtonItem btnInfoApp;
        private DevExpress.XtraBars.BarButtonItem btnInfoAuthor;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarHeaderItem Information;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarWorkspaceMenuItem barWorkspaceMenuItem1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
		private UC.nhapKhau nhapKhau1;
		private UC.XuatKhau xuatKhau1;
	}
}