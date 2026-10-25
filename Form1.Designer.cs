namespace S12360872
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenu_OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenu_SaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenu_CloseFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.FileMenu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageProcessing = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageProcessing_GrayLevel = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageProcessingGL_Average = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageProcessingGL_Luminance = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageProcessing_Fliter = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageProcessingFLT_Red = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageProcessingFLT_Green = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageProcessingFLT_Blue = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageProcessing_CPMT = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageProcessing_BlackWhite = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageProcessing_Text = new System.Windows.Forms.ToolStripMenuItem();
            this.EMGUProcessing = new System.Windows.Forms.ToolStripMenuItem();
            this.EMGUProcessing_GrayLevel = new System.Windows.Forms.ToolStripMenuItem();
            this.EMGUProcessingGL_8bit = new System.Windows.Forms.ToolStripMenuItem();
            this.EMGUProcessingGL_24bit = new System.Windows.Forms.ToolStripMenuItem();
            this.EMGUProcessing_Fliter = new System.Windows.Forms.ToolStripMenuItem();
            this.EMGUProcessingFLT_Red = new System.Windows.Forms.ToolStripMenuItem();
            this.EMGUProcessingFLT_Green = new System.Windows.Forms.ToolStripMenuItem();
            this.EMGUProcessingFLT_Blue = new System.Windows.Forms.ToolStripMenuItem();
            this.EMGUProcessing_CPMT = new System.Windows.Forms.ToolStripMenuItem();
            this.EMGUProcessing_BlackWhite = new System.Windows.Forms.ToolStripMenuItem();
            this.EMGUProcessing_Text = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewMenu_Histogram = new System.Windows.Forms.ToolStripMenuItem();
            this.tMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStrip_OpenFile = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_SaveFile = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_CloseFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip_FitImage = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_Large = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_Small = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_Full = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip_Exit = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusStrip_Pixel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip_Percent = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip_PixelFormat = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip_FilePath = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelRT = new System.Windows.Forms.Panel();
            this.lv_num = new System.Windows.Forms.Label();
            this.lv_bri = new System.Windows.Forms.Label();
            this.lv_tot = new System.Windows.Forms.Label();
            this.lv_std = new System.Windows.Forms.Label();
            this.lv_mid = new System.Windows.Forms.Label();
            this.lv_avg = new System.Windows.Forms.Label();
            this.lv_max = new System.Windows.Forms.Label();
            this.tabControl_Histogram = new System.Windows.Forms.TabControl();
            this.tabPageLuminance = new System.Windows.Forms.TabPage();
            this.tabPageRed = new System.Windows.Forms.TabPage();
            this.tabPageGreen = new System.Windows.Forms.TabPage();
            this.tabPageBlue = new System.Windows.Forms.TabPage();
            this.panelRD = new System.Windows.Forms.Panel();
            this.panelL = new System.Windows.Forms.Panel();
            this.tabControl_Image = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.panelRT.SuspendLayout();
            this.tabControl_Histogram.SuspendLayout();
            this.panelL.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.ImageProcessing,
            this.EMGUProcessing,
            this.ViewMenu,
            this.tMenuItemAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu_OpenFile,
            this.FileMenu_SaveFile,
            this.FileMenu_CloseFile,
            this.toolStripSeparator1,
            this.FileMenu_Exit});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(57, 20);
            this.FileMenu.Text = "檔案(&F)";
            // 
            // FileMenu_OpenFile
            // 
            this.FileMenu_OpenFile.Image = ((System.Drawing.Image)(resources.GetObject("FileMenu_OpenFile.Image")));
            this.FileMenu_OpenFile.Name = "FileMenu_OpenFile";
            this.FileMenu_OpenFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.FileMenu_OpenFile.Size = new System.Drawing.Size(215, 22);
            this.FileMenu_OpenFile.Text = "開啟檔案(&O)";
            this.FileMenu_OpenFile.Click += new System.EventHandler(this.FileMenu_OpenFile_Click);
            // 
            // FileMenu_SaveFile
            // 
            this.FileMenu_SaveFile.Image = ((System.Drawing.Image)(resources.GetObject("FileMenu_SaveFile.Image")));
            this.FileMenu_SaveFile.Name = "FileMenu_SaveFile";
            this.FileMenu_SaveFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.FileMenu_SaveFile.Size = new System.Drawing.Size(215, 22);
            this.FileMenu_SaveFile.Text = "儲存圖檔(&S)";
            this.FileMenu_SaveFile.Click += new System.EventHandler(this.FileMenu_SaveFile_Click);
            // 
            // FileMenu_CloseFile
            // 
            this.FileMenu_CloseFile.Image = ((System.Drawing.Image)(resources.GetObject("FileMenu_CloseFile.Image")));
            this.FileMenu_CloseFile.Name = "FileMenu_CloseFile";
            this.FileMenu_CloseFile.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.FileMenu_CloseFile.Size = new System.Drawing.Size(215, 22);
            this.FileMenu_CloseFile.Text = "關閉圖檔(&C)";
            this.FileMenu_CloseFile.Click += new System.EventHandler(this.FileMenu_CloseFile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(212, 6);
            // 
            // FileMenu_Exit
            // 
            this.FileMenu_Exit.Image = ((System.Drawing.Image)(resources.GetObject("FileMenu_Exit.Image")));
            this.FileMenu_Exit.Name = "FileMenu_Exit";
            this.FileMenu_Exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.FileMenu_Exit.Size = new System.Drawing.Size(215, 22);
            this.FileMenu_Exit.Text = "離開(&X)";
            this.FileMenu_Exit.Click += new System.EventHandler(this.FileMenu_Exit_Click);
            // 
            // ImageProcessing
            // 
            this.ImageProcessing.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImageProcessing_GrayLevel,
            this.ImageProcessing_Fliter,
            this.ImageProcessing_CPMT,
            this.ImageProcessing_BlackWhite,
            this.ImageProcessing_Text});
            this.ImageProcessing.Name = "ImageProcessing";
            this.ImageProcessing.Size = new System.Drawing.Size(67, 20);
            this.ImageProcessing.Text = "影像處理";
            // 
            // ImageProcessing_GrayLevel
            // 
            this.ImageProcessing_GrayLevel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImageProcessingGL_Average,
            this.ImageProcessingGL_Luminance});
            this.ImageProcessing_GrayLevel.Image = ((System.Drawing.Image)(resources.GetObject("ImageProcessing_GrayLevel.Image")));
            this.ImageProcessing_GrayLevel.Name = "ImageProcessing_GrayLevel";
            this.ImageProcessing_GrayLevel.Size = new System.Drawing.Size(134, 22);
            this.ImageProcessing_GrayLevel.Text = "灰階";
            // 
            // ImageProcessingGL_Average
            // 
            this.ImageProcessingGL_Average.Image = ((System.Drawing.Image)(resources.GetObject("ImageProcessingGL_Average.Image")));
            this.ImageProcessingGL_Average.Name = "ImageProcessingGL_Average";
            this.ImageProcessingGL_Average.Size = new System.Drawing.Size(110, 22);
            this.ImageProcessingGL_Average.Text = "平均法";
            this.ImageProcessingGL_Average.Click += new System.EventHandler(this.ImageProcessingGL_Average_Click);
            // 
            // ImageProcessingGL_Luminance
            // 
            this.ImageProcessingGL_Luminance.Image = ((System.Drawing.Image)(resources.GetObject("ImageProcessingGL_Luminance.Image")));
            this.ImageProcessingGL_Luminance.Name = "ImageProcessingGL_Luminance";
            this.ImageProcessingGL_Luminance.Size = new System.Drawing.Size(110, 22);
            this.ImageProcessingGL_Luminance.Text = "亮度法";
            this.ImageProcessingGL_Luminance.Click += new System.EventHandler(this.ImageProcessingGL_Luminance_Click);
            // 
            // ImageProcessing_Fliter
            // 
            this.ImageProcessing_Fliter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImageProcessingFLT_Red,
            this.ImageProcessingFLT_Green,
            this.ImageProcessingFLT_Blue});
            this.ImageProcessing_Fliter.Image = ((System.Drawing.Image)(resources.GetObject("ImageProcessing_Fliter.Image")));
            this.ImageProcessing_Fliter.Name = "ImageProcessing_Fliter";
            this.ImageProcessing_Fliter.Size = new System.Drawing.Size(134, 22);
            this.ImageProcessing_Fliter.Text = "彩色濾鏡";
            // 
            // ImageProcessingFLT_Red
            // 
            this.ImageProcessingFLT_Red.Image = ((System.Drawing.Image)(resources.GetObject("ImageProcessingFLT_Red.Image")));
            this.ImageProcessingFLT_Red.Name = "ImageProcessingFLT_Red";
            this.ImageProcessingFLT_Red.Size = new System.Drawing.Size(98, 22);
            this.ImageProcessingFLT_Red.Text = "紅色";
            this.ImageProcessingFLT_Red.Click += new System.EventHandler(this.ImageProcessingFLT_Red_Click);
            // 
            // ImageProcessingFLT_Green
            // 
            this.ImageProcessingFLT_Green.Image = ((System.Drawing.Image)(resources.GetObject("ImageProcessingFLT_Green.Image")));
            this.ImageProcessingFLT_Green.Name = "ImageProcessingFLT_Green";
            this.ImageProcessingFLT_Green.Size = new System.Drawing.Size(98, 22);
            this.ImageProcessingFLT_Green.Text = "綠色";
            this.ImageProcessingFLT_Green.Click += new System.EventHandler(this.ImageProcessingFLT_Green_Click);
            // 
            // ImageProcessingFLT_Blue
            // 
            this.ImageProcessingFLT_Blue.Image = ((System.Drawing.Image)(resources.GetObject("ImageProcessingFLT_Blue.Image")));
            this.ImageProcessingFLT_Blue.Name = "ImageProcessingFLT_Blue";
            this.ImageProcessingFLT_Blue.Size = new System.Drawing.Size(98, 22);
            this.ImageProcessingFLT_Blue.Text = "藍色";
            this.ImageProcessingFLT_Blue.Click += new System.EventHandler(this.ImageProcessingFLT_Blue_Click);
            // 
            // ImageProcessing_CPMT
            // 
            this.ImageProcessing_CPMT.Image = ((System.Drawing.Image)(resources.GetObject("ImageProcessing_CPMT.Image")));
            this.ImageProcessing_CPMT.Name = "ImageProcessing_CPMT";
            this.ImageProcessing_CPMT.Size = new System.Drawing.Size(134, 22);
            this.ImageProcessing_CPMT.Text = "補色";
            this.ImageProcessing_CPMT.Click += new System.EventHandler(this.ImageProcessing_CPMT_Click);
            // 
            // ImageProcessing_BlackWhite
            // 
            this.ImageProcessing_BlackWhite.Image = ((System.Drawing.Image)(resources.GetObject("ImageProcessing_BlackWhite.Image")));
            this.ImageProcessing_BlackWhite.Name = "ImageProcessing_BlackWhite";
            this.ImageProcessing_BlackWhite.Size = new System.Drawing.Size(134, 22);
            this.ImageProcessing_BlackWhite.Text = "轉黑白";
            this.ImageProcessing_BlackWhite.Click += new System.EventHandler(this.ImageProcessing_BlackWhite_Click);
            // 
            // ImageProcessing_Text
            // 
            this.ImageProcessing_Text.Image = ((System.Drawing.Image)(resources.GetObject("ImageProcessing_Text.Image")));
            this.ImageProcessing_Text.Name = "ImageProcessing_Text";
            this.ImageProcessing_Text.Size = new System.Drawing.Size(134, 22);
            this.ImageProcessing_Text.Text = "圖中放文字";
            this.ImageProcessing_Text.Click += new System.EventHandler(this.ImageProcessing_Text_Click);
            // 
            // EMGUProcessing
            // 
            this.EMGUProcessing.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EMGUProcessing_GrayLevel,
            this.EMGUProcessing_Fliter,
            this.EMGUProcessing_CPMT,
            this.EMGUProcessing_BlackWhite,
            this.EMGUProcessing_Text});
            this.EMGUProcessing.Name = "EMGUProcessing";
            this.EMGUProcessing.Size = new System.Drawing.Size(80, 20);
            this.EMGUProcessing.Text = "EMGU處理";
            // 
            // EMGUProcessing_GrayLevel
            // 
            this.EMGUProcessing_GrayLevel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EMGUProcessingGL_8bit,
            this.EMGUProcessingGL_24bit});
            this.EMGUProcessing_GrayLevel.Image = ((System.Drawing.Image)(resources.GetObject("EMGUProcessing_GrayLevel.Image")));
            this.EMGUProcessing_GrayLevel.Name = "EMGUProcessing_GrayLevel";
            this.EMGUProcessing_GrayLevel.Size = new System.Drawing.Size(134, 22);
            this.EMGUProcessing_GrayLevel.Text = "轉灰階";
            // 
            // EMGUProcessingGL_8bit
            // 
            this.EMGUProcessingGL_8bit.Image = ((System.Drawing.Image)(resources.GetObject("EMGUProcessingGL_8bit.Image")));
            this.EMGUProcessingGL_8bit.Name = "EMGUProcessingGL_8bit";
            this.EMGUProcessingGL_8bit.Size = new System.Drawing.Size(103, 22);
            this.EMGUProcessingGL_8bit.Text = "8bit";
            this.EMGUProcessingGL_8bit.Click += new System.EventHandler(this.EMGUProcessingGL_8bit_Click);
            // 
            // EMGUProcessingGL_24bit
            // 
            this.EMGUProcessingGL_24bit.Image = ((System.Drawing.Image)(resources.GetObject("EMGUProcessingGL_24bit.Image")));
            this.EMGUProcessingGL_24bit.Name = "EMGUProcessingGL_24bit";
            this.EMGUProcessingGL_24bit.Size = new System.Drawing.Size(103, 22);
            this.EMGUProcessingGL_24bit.Text = "24bit";
            this.EMGUProcessingGL_24bit.Click += new System.EventHandler(this.EMGUProcessingGL_24bit_Click);
            // 
            // EMGUProcessing_Fliter
            // 
            this.EMGUProcessing_Fliter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EMGUProcessingFLT_Red,
            this.EMGUProcessingFLT_Green,
            this.EMGUProcessingFLT_Blue});
            this.EMGUProcessing_Fliter.Image = ((System.Drawing.Image)(resources.GetObject("EMGUProcessing_Fliter.Image")));
            this.EMGUProcessing_Fliter.Name = "EMGUProcessing_Fliter";
            this.EMGUProcessing_Fliter.Size = new System.Drawing.Size(134, 22);
            this.EMGUProcessing_Fliter.Text = "彩色濾鏡";
            // 
            // EMGUProcessingFLT_Red
            // 
            this.EMGUProcessingFLT_Red.Image = ((System.Drawing.Image)(resources.GetObject("EMGUProcessingFLT_Red.Image")));
            this.EMGUProcessingFLT_Red.Name = "EMGUProcessingFLT_Red";
            this.EMGUProcessingFLT_Red.Size = new System.Drawing.Size(98, 22);
            this.EMGUProcessingFLT_Red.Text = "紅色";
            this.EMGUProcessingFLT_Red.Click += new System.EventHandler(this.EMGUProcessingFLT_Red_Click);
            // 
            // EMGUProcessingFLT_Green
            // 
            this.EMGUProcessingFLT_Green.Image = ((System.Drawing.Image)(resources.GetObject("EMGUProcessingFLT_Green.Image")));
            this.EMGUProcessingFLT_Green.Name = "EMGUProcessingFLT_Green";
            this.EMGUProcessingFLT_Green.Size = new System.Drawing.Size(98, 22);
            this.EMGUProcessingFLT_Green.Text = "綠色";
            this.EMGUProcessingFLT_Green.Click += new System.EventHandler(this.EMGUProcessingFLT_Green_Click);
            // 
            // EMGUProcessingFLT_Blue
            // 
            this.EMGUProcessingFLT_Blue.Image = ((System.Drawing.Image)(resources.GetObject("EMGUProcessingFLT_Blue.Image")));
            this.EMGUProcessingFLT_Blue.Name = "EMGUProcessingFLT_Blue";
            this.EMGUProcessingFLT_Blue.Size = new System.Drawing.Size(98, 22);
            this.EMGUProcessingFLT_Blue.Text = "藍色";
            this.EMGUProcessingFLT_Blue.Click += new System.EventHandler(this.EMGUProcessingFLT_Blue_Click);
            // 
            // EMGUProcessing_CPMT
            // 
            this.EMGUProcessing_CPMT.Image = ((System.Drawing.Image)(resources.GetObject("EMGUProcessing_CPMT.Image")));
            this.EMGUProcessing_CPMT.Name = "EMGUProcessing_CPMT";
            this.EMGUProcessing_CPMT.Size = new System.Drawing.Size(134, 22);
            this.EMGUProcessing_CPMT.Text = "補色";
            this.EMGUProcessing_CPMT.Click += new System.EventHandler(this.EMGUProcessing_CPMT_Click);
            // 
            // EMGUProcessing_BlackWhite
            // 
            this.EMGUProcessing_BlackWhite.Image = ((System.Drawing.Image)(resources.GetObject("EMGUProcessing_BlackWhite.Image")));
            this.EMGUProcessing_BlackWhite.Name = "EMGUProcessing_BlackWhite";
            this.EMGUProcessing_BlackWhite.Size = new System.Drawing.Size(134, 22);
            this.EMGUProcessing_BlackWhite.Text = "轉黑白";
            this.EMGUProcessing_BlackWhite.Click += new System.EventHandler(this.EMGUProcessing_BlackWhite_Click);
            // 
            // EMGUProcessing_Text
            // 
            this.EMGUProcessing_Text.Image = ((System.Drawing.Image)(resources.GetObject("EMGUProcessing_Text.Image")));
            this.EMGUProcessing_Text.Name = "EMGUProcessing_Text";
            this.EMGUProcessing_Text.Size = new System.Drawing.Size(134, 22);
            this.EMGUProcessing_Text.Text = "圖中放文字";
            this.EMGUProcessing_Text.Click += new System.EventHandler(this.EMGUProcessing_Text_Click);
            // 
            // ViewMenu
            // 
            this.ViewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewMenu_Histogram});
            this.ViewMenu.Name = "ViewMenu";
            this.ViewMenu.Size = new System.Drawing.Size(43, 20);
            this.ViewMenu.Text = "檢視";
            // 
            // ViewMenu_Histogram
            // 
            this.ViewMenu_Histogram.Name = "ViewMenu_Histogram";
            this.ViewMenu_Histogram.Size = new System.Drawing.Size(110, 22);
            this.ViewMenu_Histogram.Text = "直方圖";
            this.ViewMenu_Histogram.Click += new System.EventHandler(this.ViewMenu_Histogram_Click);
            // 
            // tMenuItemAbout
            // 
            this.tMenuItemAbout.Name = "tMenuItemAbout";
            this.tMenuItemAbout.Size = new System.Drawing.Size(60, 20);
            this.tMenuItemAbout.Text = "說明(&H)";
            this.tMenuItemAbout.Click += new System.EventHandler(this.tMenuItemAbout_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(502, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_OpenFile,
            this.toolStrip_SaveFile,
            this.toolStrip_CloseFile,
            this.toolStripSeparator2,
            this.toolStrip_FitImage,
            this.toolStrip_Large,
            this.toolStrip_Small,
            this.toolStrip_Full,
            this.toolStripSeparator3,
            this.toolStrip_Exit});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(800, 25);
            this.toolStrip.TabIndex = 7;
            this.toolStrip.Text = "toolStrip";
            // 
            // toolStrip_OpenFile
            // 
            this.toolStrip_OpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_OpenFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_OpenFile.Image")));
            this.toolStrip_OpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_OpenFile.Name = "toolStrip_OpenFile";
            this.toolStrip_OpenFile.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_OpenFile.Text = "toolStrip_OpenFile";
            this.toolStrip_OpenFile.ToolTipText = "開啟檔案";
            this.toolStrip_OpenFile.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStrip_SaveFile
            // 
            this.toolStrip_SaveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_SaveFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_SaveFile.Image")));
            this.toolStrip_SaveFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_SaveFile.Name = "toolStrip_SaveFile";
            this.toolStrip_SaveFile.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_SaveFile.Text = "toolStrip_SaveFile";
            this.toolStrip_SaveFile.ToolTipText = "儲存圖檔";
            this.toolStrip_SaveFile.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStrip_CloseFile
            // 
            this.toolStrip_CloseFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_CloseFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_CloseFile.Image")));
            this.toolStrip_CloseFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_CloseFile.Name = "toolStrip_CloseFile";
            this.toolStrip_CloseFile.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_CloseFile.Text = "toolStrip_CloseFile";
            this.toolStrip_CloseFile.ToolTipText = "關閉圖檔";
            this.toolStrip_CloseFile.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStrip_FitImage
            // 
            this.toolStrip_FitImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_FitImage.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_FitImage.Image")));
            this.toolStrip_FitImage.ImageTransparentColor = System.Drawing.Color.MediumAquamarine;
            this.toolStrip_FitImage.Name = "toolStrip_FitImage";
            this.toolStrip_FitImage.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_FitImage.Text = "toolStripButton1";
            this.toolStrip_FitImage.ToolTipText = "大小最佳化";
            this.toolStrip_FitImage.Click += new System.EventHandler(this.toolStrip_FitImage_Click);
            // 
            // toolStrip_Large
            // 
            this.toolStrip_Large.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_Large.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_Large.Image")));
            this.toolStrip_Large.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_Large.Name = "toolStrip_Large";
            this.toolStrip_Large.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_Large.Text = "toolStripButton2";
            this.toolStrip_Large.ToolTipText = "放大";
            this.toolStrip_Large.Click += new System.EventHandler(this.toolStrip_Large_Click);
            // 
            // toolStrip_Small
            // 
            this.toolStrip_Small.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_Small.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_Small.Image")));
            this.toolStrip_Small.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_Small.Name = "toolStrip_Small";
            this.toolStrip_Small.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_Small.Text = "toolStripButton3";
            this.toolStrip_Small.ToolTipText = "縮小";
            this.toolStrip_Small.Click += new System.EventHandler(this.toolStrip_Small_Click);
            // 
            // toolStrip_Full
            // 
            this.toolStrip_Full.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_Full.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_Full.Image")));
            this.toolStrip_Full.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_Full.Name = "toolStrip_Full";
            this.toolStrip_Full.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_Full.Text = "toolStripButton4";
            this.toolStrip_Full.ToolTipText = "滿版";
            this.toolStrip_Full.Click += new System.EventHandler(this.toolStrip_Full_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStrip_Exit
            // 
            this.toolStrip_Exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_Exit.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_Exit.Image")));
            this.toolStrip_Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_Exit.Name = "toolStrip_Exit";
            this.toolStrip_Exit.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_Exit.Text = "toolStrip_Exit";
            this.toolStrip_Exit.ToolTipText = "離開";
            this.toolStrip_Exit.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStrip_Pixel,
            this.statusStrip_Percent,
            this.statusStrip_PixelFormat,
            this.statusStrip_FilePath});
            this.statusStrip.Location = new System.Drawing.Point(0, 426);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 24);
            this.statusStrip.TabIndex = 8;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusStrip_Pixel
            // 
            this.statusStrip_Pixel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.statusStrip_Pixel.Name = "statusStrip_Pixel";
            this.statusStrip_Pixel.Size = new System.Drawing.Size(100, 19);
            this.statusStrip_Pixel.Text = "statusStrip_Pixel";
            // 
            // statusStrip_Percent
            // 
            this.statusStrip_Percent.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.statusStrip_Percent.Name = "statusStrip_Percent";
            this.statusStrip_Percent.Size = new System.Drawing.Size(116, 19);
            this.statusStrip_Percent.Text = "statusStrip_Percent";
            // 
            // statusStrip_PixelFormat
            // 
            this.statusStrip_PixelFormat.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.statusStrip_PixelFormat.Name = "statusStrip_PixelFormat";
            this.statusStrip_PixelFormat.Size = new System.Drawing.Size(140, 19);
            this.statusStrip_PixelFormat.Text = "statusStrip_PixelFormat";
            // 
            // statusStrip_FilePath
            // 
            this.statusStrip_FilePath.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.statusStrip_FilePath.Name = "statusStrip_FilePath";
            this.statusStrip_FilePath.Size = new System.Drawing.Size(118, 19);
            this.statusStrip_FilePath.Text = "statusStrip_FilePath";
            // 
            // panelRT
            // 
            this.panelRT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelRT.Controls.Add(this.lv_num);
            this.panelRT.Controls.Add(this.lv_bri);
            this.panelRT.Controls.Add(this.lv_tot);
            this.panelRT.Controls.Add(this.lv_std);
            this.panelRT.Controls.Add(this.lv_mid);
            this.panelRT.Controls.Add(this.lv_avg);
            this.panelRT.Controls.Add(this.lv_max);
            this.panelRT.Controls.Add(this.tabControl_Histogram);
            this.panelRT.Location = new System.Drawing.Point(530, 52);
            this.panelRT.Name = "panelRT";
            this.panelRT.Size = new System.Drawing.Size(258, 265);
            this.panelRT.TabIndex = 9;
            // 
            // lv_num
            // 
            this.lv_num.AutoSize = true;
            this.lv_num.Location = new System.Drawing.Point(5, 249);
            this.lv_num.Name = "lv_num";
            this.lv_num.Size = new System.Drawing.Size(41, 12);
            this.lv_num.TabIndex = 6;
            this.lv_num.Text = "數    量";
            // 
            // lv_bri
            // 
            this.lv_bri.AutoSize = true;
            this.lv_bri.Location = new System.Drawing.Point(5, 233);
            this.lv_bri.Name = "lv_bri";
            this.lv_bri.Size = new System.Drawing.Size(41, 12);
            this.lv_bri.TabIndex = 5;
            this.lv_bri.Text = "亮度值";
            // 
            // lv_tot
            // 
            this.lv_tot.AutoSize = true;
            this.lv_tot.Location = new System.Drawing.Point(5, 217);
            this.lv_tot.Name = "lv_tot";
            this.lv_tot.Size = new System.Drawing.Size(41, 12);
            this.lv_tot.TabIndex = 4;
            this.lv_tot.Text = "總像素";
            // 
            // lv_std
            // 
            this.lv_std.AutoSize = true;
            this.lv_std.Location = new System.Drawing.Point(5, 201);
            this.lv_std.Name = "lv_std";
            this.lv_std.Size = new System.Drawing.Size(41, 12);
            this.lv_std.TabIndex = 3;
            this.lv_std.Text = "標準差";
            // 
            // lv_mid
            // 
            this.lv_mid.AutoSize = true;
            this.lv_mid.Location = new System.Drawing.Point(5, 185);
            this.lv_mid.Name = "lv_mid";
            this.lv_mid.Size = new System.Drawing.Size(41, 12);
            this.lv_mid.TabIndex = 2;
            this.lv_mid.Text = "中位數";
            // 
            // lv_avg
            // 
            this.lv_avg.AutoSize = true;
            this.lv_avg.Location = new System.Drawing.Point(5, 169);
            this.lv_avg.Name = "lv_avg";
            this.lv_avg.Size = new System.Drawing.Size(41, 12);
            this.lv_avg.TabIndex = 1;
            this.lv_avg.Text = "平均數";
            // 
            // lv_max
            // 
            this.lv_max.AutoSize = true;
            this.lv_max.Location = new System.Drawing.Point(5, 153);
            this.lv_max.Name = "lv_max";
            this.lv_max.Size = new System.Drawing.Size(41, 12);
            this.lv_max.TabIndex = 0;
            this.lv_max.Text = "最大值";
            // 
            // tabControl_Histogram
            // 
            this.tabControl_Histogram.Controls.Add(this.tabPageLuminance);
            this.tabControl_Histogram.Controls.Add(this.tabPageRed);
            this.tabControl_Histogram.Controls.Add(this.tabPageGreen);
            this.tabControl_Histogram.Controls.Add(this.tabPageBlue);
            this.tabControl_Histogram.Location = new System.Drawing.Point(3, 3);
            this.tabControl_Histogram.Name = "tabControl_Histogram";
            this.tabControl_Histogram.SelectedIndex = 0;
            this.tabControl_Histogram.Size = new System.Drawing.Size(248, 147);
            this.tabControl_Histogram.TabIndex = 0;
            this.tabControl_Histogram.SelectedIndexChanged += new System.EventHandler(this.tabControl_Histogram_SelectedIndexChanged);
            // 
            // tabPageLuminance
            // 
            this.tabPageLuminance.Location = new System.Drawing.Point(4, 22);
            this.tabPageLuminance.Name = "tabPageLuminance";
            this.tabPageLuminance.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLuminance.Size = new System.Drawing.Size(240, 121);
            this.tabPageLuminance.TabIndex = 0;
            this.tabPageLuminance.Text = "亮度";
            this.tabPageLuminance.UseVisualStyleBackColor = true;
            // 
            // tabPageRed
            // 
            this.tabPageRed.Location = new System.Drawing.Point(4, 22);
            this.tabPageRed.Name = "tabPageRed";
            this.tabPageRed.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRed.Size = new System.Drawing.Size(240, 121);
            this.tabPageRed.TabIndex = 1;
            this.tabPageRed.Text = "紅色";
            this.tabPageRed.UseVisualStyleBackColor = true;
            // 
            // tabPageGreen
            // 
            this.tabPageGreen.Location = new System.Drawing.Point(4, 22);
            this.tabPageGreen.Name = "tabPageGreen";
            this.tabPageGreen.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGreen.Size = new System.Drawing.Size(240, 121);
            this.tabPageGreen.TabIndex = 2;
            this.tabPageGreen.Text = "綠色";
            this.tabPageGreen.UseVisualStyleBackColor = true;
            // 
            // tabPageBlue
            // 
            this.tabPageBlue.Location = new System.Drawing.Point(4, 22);
            this.tabPageBlue.Name = "tabPageBlue";
            this.tabPageBlue.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBlue.Size = new System.Drawing.Size(240, 121);
            this.tabPageBlue.TabIndex = 3;
            this.tabPageBlue.Text = "藍色";
            this.tabPageBlue.UseVisualStyleBackColor = true;
            // 
            // panelRD
            // 
            this.panelRD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelRD.Location = new System.Drawing.Point(530, 323);
            this.panelRD.Name = "panelRD";
            this.panelRD.Size = new System.Drawing.Size(258, 100);
            this.panelRD.TabIndex = 0;
            // 
            // panelL
            // 
            this.panelL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelL.Controls.Add(this.tabControl_Image);
            this.panelL.Controls.Add(this.pictureBox1);
            this.panelL.Location = new System.Drawing.Point(0, 52);
            this.panelL.Name = "panelL";
            this.panelL.Size = new System.Drawing.Size(524, 371);
            this.panelL.TabIndex = 0;
            // 
            // tabControl_Image
            // 
            this.tabControl_Image.Location = new System.Drawing.Point(-2, -2);
            this.tabControl_Image.Name = "tabControl_Image";
            this.tabControl_Image.SelectedIndex = 0;
            this.tabControl_Image.Size = new System.Drawing.Size(524, 371);
            this.tabControl_Image.TabIndex = 10;
            this.tabControl_Image.SelectedIndexChanged += new System.EventHandler(this.tabControl_Image_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelRD);
            this.Controls.Add(this.panelL);
            this.Controls.Add(this.panelRT);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "12360872 陳瑋傑";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panelRT.ResumeLayout(false);
            this.panelRT.PerformLayout();
            this.tabControl_Histogram.ResumeLayout(false);
            this.panelL.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tMenuItemAbout;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem FileMenu_OpenFile;
        private System.Windows.Forms.ToolStripMenuItem FileMenu_SaveFile;
        private System.Windows.Forms.ToolStripMenuItem FileMenu_CloseFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem FileMenu_Exit;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStrip_OpenFile;
        private System.Windows.Forms.ToolStripButton toolStrip_SaveFile;
        private System.Windows.Forms.ToolStripButton toolStrip_CloseFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStrip_Exit;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusStrip_FilePath;
        private System.Windows.Forms.ToolStripStatusLabel statusStrip_Pixel;
        private System.Windows.Forms.ToolStripStatusLabel statusStrip_Percent;
        private System.Windows.Forms.ToolStripStatusLabel statusStrip_PixelFormat;
        private System.Windows.Forms.ToolStripMenuItem ImageProcessing;
        private System.Windows.Forms.ToolStripMenuItem ImageProcessing_GrayLevel;
        private System.Windows.Forms.ToolStripMenuItem ImageProcessingGL_Average;
        private System.Windows.Forms.ToolStripMenuItem ImageProcessingGL_Luminance;
        private System.Windows.Forms.ToolStripMenuItem ImageProcessing_Fliter;
        private System.Windows.Forms.ToolStripMenuItem ImageProcessingFLT_Red;
        private System.Windows.Forms.ToolStripMenuItem ImageProcessingFLT_Green;
        private System.Windows.Forms.ToolStripMenuItem ImageProcessingFLT_Blue;
        private System.Windows.Forms.ToolStripMenuItem ImageProcessing_CPMT;
        private System.Windows.Forms.ToolStripMenuItem ImageProcessing_BlackWhite;
        private System.Windows.Forms.ToolStripMenuItem ImageProcessing_Text;
        private System.Windows.Forms.ToolStripMenuItem EMGUProcessing;
        private System.Windows.Forms.ToolStripMenuItem EMGUProcessing_GrayLevel;
        private System.Windows.Forms.ToolStripMenuItem EMGUProcessing_Fliter;
        private System.Windows.Forms.ToolStripMenuItem EMGUProcessing_CPMT;
        private System.Windows.Forms.ToolStripMenuItem EMGUProcessing_BlackWhite;
        private System.Windows.Forms.ToolStripMenuItem EMGUProcessing_Text;
        private System.Windows.Forms.ToolStripMenuItem EMGUProcessingGL_8bit;
        private System.Windows.Forms.ToolStripMenuItem EMGUProcessingGL_24bit;
        private System.Windows.Forms.ToolStripMenuItem EMGUProcessingFLT_Red;
        private System.Windows.Forms.ToolStripMenuItem EMGUProcessingFLT_Green;
        private System.Windows.Forms.ToolStripMenuItem EMGUProcessingFLT_Blue;
        private System.Windows.Forms.Panel panelRT;
        private System.Windows.Forms.Panel panelRD;
        private System.Windows.Forms.Panel panelL;
        private System.Windows.Forms.ToolStripButton toolStrip_FitImage;
        private System.Windows.Forms.ToolStripButton toolStrip_Large;
        private System.Windows.Forms.ToolStripButton toolStrip_Small;
        private System.Windows.Forms.ToolStripButton toolStrip_Full;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.TabControl tabControl_Histogram;
        private System.Windows.Forms.TabPage tabPageLuminance;
        private System.Windows.Forms.TabPage tabPageRed;
        private System.Windows.Forms.TabPage tabPageGreen;
        private System.Windows.Forms.TabPage tabPageBlue;
        private System.Windows.Forms.TabControl tabControl_Image;
        private System.Windows.Forms.ToolStripMenuItem ViewMenu;
        private System.Windows.Forms.ToolStripMenuItem ViewMenu_Histogram;
        private System.Windows.Forms.Label lv_num;
        private System.Windows.Forms.Label lv_bri;
        private System.Windows.Forms.Label lv_tot;
        private System.Windows.Forms.Label lv_std;
        private System.Windows.Forms.Label lv_mid;
        private System.Windows.Forms.Label lv_avg;
        private System.Windows.Forms.Label lv_max;
    }
}

