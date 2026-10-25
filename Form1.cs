using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PixelProcessing;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using Emgu.CV.CvEnum;
using System.Security;
using static System.Net.Mime.MediaTypeNames;

namespace S12360872
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Initial_File();
            Initial_Status();
            iPanelRBLy = panelRT.Location.Y;
            iFH_PRTH = this.Height - panelRT.Size.Height;
            iFH_PLH = this.Height - panelL.Height;
            ipanelLeftW_picW = panelL.Width - pictureBox1.Width;
            Close_Histogram();
        }


        private void tMenuItemAbout_Click(object sender, EventArgs e)
        {
            AboutBox aboutbox = new AboutBox();
            aboutbox.StartPosition = FormStartPosition.CenterScreen;
            aboutbox.ShowDialog();
        }


        private void FileMenu_OpenFile_Click(object sender, EventArgs e)  //開檔
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "BMP(*.BMP)|*.BMP|JPEG(*.JPG)|*.JPG|PNG(*.PNG)|*.PNG";
            openFileDialog1.Title = "開啟影像檔";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tabControl_Image.Visible = true;
                Bitmap Image = new Bitmap(openFileDialog1.FileName);
                string title = openFileDialog1.FileName;
                CreateTabPage newTabPage = new CreateTabPage(Image, title);
                tabControl_Image.TabPages.Add(newTabPage);
                tabControl_Image.SelectTab(newTabPage);
                openFileDialog1.Dispose();
                SelectedTabPage = (CreateTabPage)tabControl_Image.SelectedTab;
                originalbmp = new Bitmap(SelectedTabPage.pic1.Image);
                tabControl_Image.Visible = true;
                //  pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                Show_Status();
                Enable_AllButton();
                toolStrip_FitImage_Click(sender,e);
                if(ViewMenu_Histogram.Checked)
                    tabControl_Histogram_SelectedIndexChanged(sender, e);
                else
                    Close_Histogram();
            }
        }

        private void FileMenu_SaveFile_Click(object sender, EventArgs e)  //存檔 
        {
            if (currentImage == 0)
            {
                MessageBox.Show("尚未開啟檔案");
            }
            else
            {
                saveFileDialog1.Filter = "JPEG(*.JPG)|*.JPG|PNG(*.PNG)|*.PNG|BMP(*.BMP)|*.BMP";
                saveFileDialog1.Title = "儲存影像檔";
                SelectedTabPage = (CreateTabPage)tabControl_Image.SelectedTab;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK) SelectedTabPage.pic1.Image.Save(saveFileDialog1.FileName);
            }
        }

        private void FileMenu_CloseFile_Click(object sender, EventArgs e)  //關檔
        {
            if (tabControl_Image.SelectedTab != null)
            {
                var result = MessageBox.Show("你確定要關閉圖檔嗎", "提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    currentImage--;
                    tabControl_Image.TabPages.Remove(tabControl_Image.SelectedTab);
                    if (tabControl_Image.SelectedTab == null)
                    {
                        tabControl_Image.Visible = false;
                        Initial_File();
                        Initial_Status();
                        Close_Histogram();
                    }
                    else tabControl_Image.SelectedTab = tabControl_Image.TabPages[tabControl_Image.TabPages.Count - 1];
                }
            }
        }
        ////狀態變更
        private void Enable_AllButton()  //開檔時顯示按鈕
        {
            FileMenu_SaveFile.Enabled = true;
            FileMenu_CloseFile.Enabled = true;
            toolStrip_SaveFile.Enabled = true;
            toolStrip_CloseFile.Enabled = true;
            ImageProcessing.Enabled = true;
            EMGUProcessing.Enabled = true;
            ViewMenu.Enabled = true;
            toolStrip_FitImage.Enabled = true;
            toolStrip_Large.Enabled = true;
            toolStrip_Small.Enabled = true;
            toolStrip_Full.Enabled = true;
        }
        private void Initial_File()  //關檔時關閉按鈕選項
        {
            FileMenu_SaveFile.Enabled = false;
            FileMenu_CloseFile.Enabled = false;
            toolStrip_SaveFile.Enabled = false;
            toolStrip_CloseFile.Enabled = false;
            ImageProcessing.Enabled = false;
            EMGUProcessing.Enabled = false;
            ViewMenu.Enabled = false;
            toolStrip_FitImage.Enabled = false;
            toolStrip_Large.Enabled = false;
            toolStrip_Small.Enabled = false;
            toolStrip_Full.Enabled = false;
        }
        private void Show_Status()  //顯示下方狀態列
        {
            if (tabControl_Image.SelectedTab != null)
            {
                SelectedTabPage = (CreateTabPage)tabControl_Image.SelectedTab;
                statusStrip_FilePath.Text = SelectedTabPage.path;
                statusStrip_Pixel.Text = SelectedTabPage.pic1.Image.Width + "x" + SelectedTabPage.pic1.Image.Height;
                statusStrip_Percent.Text = (int)((double)(SelectedTabPage.pic1.Width) / (double)(SelectedTabPage.pic1.Image.Width) * 100) + "%";
                statusStrip_PixelFormat.Text = SelectedTabPage.pic1.Image.PixelFormat.ToString();

            }
            //statusStrip_FilePath.Text = statusStrip_FilePath.Text = openFileDialog1.FileName;
            //statusStrip_Pixel.Text = pictureBox1.Image.Width + "x" + pictureBox1.Image.Height;
            //statusStrip_Percent.Text = (int)((double)(pictureBox1.Width) / (double)(pictureBox1.Image.Width) * 100) + "%";
            //statusStrip_PixelFormat.Text = pictureBox1.Image.PixelFormat.ToString();
        }
        private void Initial_Status()  //初始下方狀態列
        {
            statusStrip_FilePath.Text = "";
            statusStrip_Pixel.Text = "";
            statusStrip_Percent.Text = "";
            statusStrip_PixelFormat.Text = "";
        }

        private void FileMenu_Exit_Click(object sender, EventArgs e)  //離開
        {
            Close();
        }
        ////工具列按鈕
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FileMenu_OpenFile_Click(sender, e);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FileMenu_SaveFile_Click(sender, e);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FileMenu_CloseFile_Click(sender, e);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStrip_FitImage_Click(object sender, EventArgs e)
        {
            Adjust_Image_Show(0);
        }

        private void toolStrip_Large_Click(object sender, EventArgs e)
        {
            Adjust_Image_Show(1);
        }

        private void toolStrip_Small_Click(object sender, EventArgs e)
        {
            Adjust_Image_Show(2);
        }

        private void toolStrip_Full_Click(object sender, EventArgs e)
        {
            Adjust_Image_Show(3);
        }

        ////影像處理
        //灰階
        /*
        private Bitmap bmpOut;
        private BitmapData dataIn;
        private BitmapData dataOut;
        private void GrayLevelProcessing(int flag)  
        {
            Bitmap tempImage = new Bitmap(pictureBox1.Image);
            int h = tempImage.Height;
            int w = tempImage.Width;
            bmpOut = new Bitmap(w,h,PixelFormat.Format24bppRgb);
            dataIn = tempImage.LockBits(new Rectangle(0, 0, w, h), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            dataOut = bmpOut.LockBits(new Rectangle(0, 0, w, h), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
            unsafe 
            {
                double gray;
                byte* pIn = (byte*)(dataIn.Scan0.ToPointer());
                byte* pOut = (byte*)(dataOut.Scan0.ToPointer());
                for (int y = 0; y < dataIn.Height; y++)
                {
                    for (int x = 0; x < dataIn.Width; x++)
                    {
                        if (flag == 1)
                            gray = (pIn[0] + pIn[1] + pIn[2]) / 3;
                        else
                            gray = 0.114*pIn[0] + 0.587*pIn[1] + 0.299*pIn[2];
                        pOut[0] = (byte) gray;
                        pOut[1] = (byte) gray;
                        pOut[2] = (byte) gray;
                        pIn += 3;
                        pOut += 3;
                    }
                    pIn += dataIn.Stride - dataIn.Width * 3;
                    pOut += dataOut.Stride - dataOut.Width * 3;
                }
            }
            bmpOut.UnlockBits(dataOut);
            tempImage.UnlockBits(dataIn);
            pictureBox1.Image = bmpOut;
        }*/

        private void ImageProcessingGL_Average_Click(object sender, EventArgs e)
        {
            SelectedTabPage = (CreateTabPage)tabControl_Image.SelectedTab;
            statusStrip_FilePath.Text = "灰階(平均法)";
            //SelectedTabPage.path = statusStrip_FilePath.Text;
            NewPage(f.rgb2gray(new Bitmap(SelectedTabPage.pic1.Image), 1), statusStrip_FilePath.Text);
            // GrayLevelProcessing(1);
            Adjust_Image_Show(0);
        }

        private void ImageProcessingGL_Luminance_Click(object sender, EventArgs e)
        {
            SelectedTabPage = (CreateTabPage)tabControl_Image.SelectedTab;
            statusStrip_FilePath.Text = "灰階(亮度法)";
            //SelectedTabPage.path = statusStrip_FilePath.Text;
            NewPage(f.rgb2gray(new Bitmap(SelectedTabPage.pic1.Image), 2), statusStrip_FilePath.Text);
            //GrayLevelProcessing(2);
            Adjust_Image_Show(0);
        }
        //彩色濾鏡
        PixelProcess f = new PixelProcess();
        private void ImageProcessingFLT_Red_Click(object sender, EventArgs e)
        {
            SelectedTabPage = (CreateTabPage)tabControl_Image.SelectedTab;
            statusStrip_FilePath.Text = "紅色濾鏡";
            //SelectedTabPage.path = statusStrip_FilePath.Text;
            NewPage(f.rgb2ColorFilter(new Bitmap(SelectedTabPage.pic1.Image), 1), statusStrip_FilePath.Text);
            Adjust_Image_Show(0);

        }

        private void ImageProcessingFLT_Green_Click(object sender, EventArgs e)
        {
            SelectedTabPage = (CreateTabPage)tabControl_Image.SelectedTab;
            statusStrip_FilePath.Text = "綠色濾鏡";
            //SelectedTabPage.path = statusStrip_FilePath.Text;
            NewPage(f.rgb2ColorFilter(new Bitmap(SelectedTabPage.pic1.Image), 2), statusStrip_FilePath.Text);
            Adjust_Image_Show(0);
        }

        private void ImageProcessingFLT_Blue_Click(object sender, EventArgs e)
        {
            SelectedTabPage = (CreateTabPage)tabControl_Image.SelectedTab;
            statusStrip_FilePath.Text = "藍色濾鏡";
            //SelectedTabPage.path = statusStrip_FilePath.Text;
            NewPage(f.rgb2ColorFilter(new Bitmap(SelectedTabPage.pic1.Image), 3), statusStrip_FilePath.Text);
            Adjust_Image_Show(0);
        }
        //補色
        private void ImageProcessing_CPMT_Click(object sender, EventArgs e)
        {
            SelectedTabPage = (CreateTabPage)tabControl_Image.SelectedTab;
            statusStrip_FilePath.Text = "補色處理";
            //SelectedTabPage.path = statusStrip_FilePath.Text;
            NewPage(f.rgb2Complement(new Bitmap(SelectedTabPage.pic1.Image)), statusStrip_FilePath.Text);
            Adjust_Image_Show(0);
        }

        private void ImageProcessing_BlackWhite_Click(object sender, EventArgs e)
        {
            SelectedTabPage = (CreateTabPage)tabControl_Image.SelectedTab;
            statusStrip_FilePath.Text = "轉黑白處理";
            //SelectedTabPage.path = statusStrip_FilePath.Text;
            NewPage(f.gray2binarization(new Bitmap(SelectedTabPage.pic1.Image), 128), statusStrip_FilePath.Text);
            Adjust_Image_Show(0);
        }

        private void ImageProcessing_Text_Click(object sender, EventArgs e)
        {
            SelectedTabPage = (CreateTabPage)tabControl_Image.SelectedTab;
            statusStrip_FilePath.Text = "圖中放文字";
            //SelectedTabPage.path = statusStrip_FilePath.Text;
            NewPage(new Bitmap(SelectedTabPage.pic1.Image), statusStrip_FilePath.Text);
            SolidBrush brush = new SolidBrush(Color.Red);
            f.ColorPlane((Bitmap)SelectedTabPage.pic1.Image);
            Bitmap tempbmp = f.ColorPlane2Gray(f.G);
            Graphics graphics = Graphics.FromImage(SelectedTabPage.pic1.Image);
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            string str = "Hello,World!";
            PointF P = new PointF(10, 100);
            Font font = new Font(this.Font.Name, 80);
            graphics.DrawString(str, font, brush, P);
            Adjust_Image_Show(0);
        }
        //Emgu
        Mat InMat;   //global Image Matrix for EmguCV
        private void EMGUProcessingGL_8bit_Click(object sender, EventArgs e)
        {
            SelectedTabPage = (CreateTabPage)tabControl_Image.SelectedTab;
            statusStrip_FilePath.Text = "灰階處理 - 8bits(Emgu.CV.Mat)";
            //SelectedTabPage.path = statusStrip_FilePath.Text;
            InMat = Emgu.CV.BitmapExtension.ToMat((Bitmap)SelectedTabPage.pic1.Image);
            Mat myMat = new Mat();
            CvInvoke.CvtColor(InMat, myMat,
            Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
            NewPage(myMat.ToBitmap(), statusStrip_FilePath.Text);
            Adjust_Image_Show(0);
            myMat.Dispose();
            InMat.Dispose();
        }

        private void EMGUProcessingGL_24bit_Click(object sender, EventArgs e)
        {
            SelectedTabPage = (CreateTabPage)tabControl_Image.SelectedTab;
            statusStrip_FilePath.Text = "灰階處理 - 24bits(Emgu.CV.Mat)";
            //SelectedTabPage.path = statusStrip_FilePath.Text;
            InMat = Emgu.CV.BitmapExtension.ToMat((Bitmap)SelectedTabPage.pic1.Image);
            VectorOfMat vectorOfMat = new VectorOfMat();
            Emgu.CV.Image<Bgr, Byte> myImage =
            new Bitmap(InMat.ToBitmap()).ToImage<Bgr, Byte>();
            Emgu.CV.Image<Gray, Byte> tempImage =
            myImage.Convert<Gray, Byte>().Clone();
            vectorOfMat.Push(tempImage);
            vectorOfMat.Push(tempImage);
            vectorOfMat.Push(tempImage);
            CvInvoke.Merge(vectorOfMat, InMat);
            NewPage(InMat.ToBitmap(), statusStrip_FilePath.Text);
            Adjust_Image_Show(0);
            InMat.Dispose();
        }
        public enum EcolorType
        {
            RedChannel = 0,
            GreenChannel,
            BlueChannel
        } //列舉

        private Emgu.CV.Image<Bgr, Byte> ChannelConvert(Emgu.CV.Image<Bgr, Byte> bitmap, EcolorType type)

        {
            Emgu.CV.Image<Bgr, Byte> ConvertImage;
            // 顏色轉換
            switch (type)
            {
                case EcolorType.RedChannel:
                    ConvertImage = bitmap.Sub(new Bgr(255, 255, 0)).Clone();
                    break;
                case EcolorType.GreenChannel:
                    ConvertImage = bitmap.Sub(new Bgr(255, 0, 255)).Clone();
                    break;
                case EcolorType.BlueChannel:
                    ConvertImage = bitmap.Sub(new Bgr(0, 255, 255)).Clone();
                    break;
                default:
                    throw new NullReferenceException("其他類型");
            }
            return ConvertImage;
        }

        private void EMGUProcessingFLT_Red_Click(object sender, EventArgs e)
        {
            SelectedTabPage = (CreateTabPage)tabControl_Image.SelectedTab;
            statusStrip_FilePath.Text = "紅色濾鏡(Emgu.CV.Image)_enum";
            //SelectedTabPage.path = statusStrip_FilePath.Text;
            Emgu.CV.Image<Bgr, Byte> myImage = new Bitmap(SelectedTabPage.pic1.Image).ToImage<Bgr, Byte>();
            NewPage((Bitmap)ChannelConvert(myImage, EcolorType.RedChannel).ToBitmap().Clone(), statusStrip_FilePath.Text);
            Adjust_Image_Show(0);
            myImage.Dispose();
        }

        private void EMGUProcessingFLT_Green_Click(object sender, EventArgs e)
        {
            SelectedTabPage = (CreateTabPage)tabControl_Image.SelectedTab;
            statusStrip_FilePath.Text = "綠色濾鏡(Emgu.CV.Image)_enum";
            //SelectedTabPage.path = statusStrip_FilePath.Text;
            Emgu.CV.Image<Bgr, Byte> myImage = new Bitmap(SelectedTabPage.pic1.Image).ToImage<Bgr, Byte>();
            NewPage((Bitmap)ChannelConvert(myImage, EcolorType.GreenChannel).ToBitmap().Clone(), statusStrip_FilePath.Text);
            Adjust_Image_Show(0);
            myImage.Dispose();
        }

        private void EMGUProcessingFLT_Blue_Click(object sender, EventArgs e)
        {
            SelectedTabPage = (CreateTabPage)tabControl_Image.SelectedTab;
            statusStrip_FilePath.Text = "藍色濾鏡(Emgu.CV.Image)_enum";
            //SelectedTabPage.path = statusStrip_FilePath.Text;
            Emgu.CV.Image<Bgr, Byte> myImage = new Bitmap(SelectedTabPage.pic1.Image).ToImage<Bgr, Byte>();
            NewPage((Bitmap)ChannelConvert(myImage, EcolorType.BlueChannel).ToBitmap().Clone(), statusStrip_FilePath.Text);
            Adjust_Image_Show(0);
            myImage.Dispose();
        }

        private void EMGUProcessing_CPMT_Click(object sender, EventArgs e)
        {
            SelectedTabPage = (CreateTabPage)tabControl_Image.SelectedTab;
            statusStrip_FilePath.Text = "補色處理(Emgu.CV.Image)";
            //SelectedTabPage.path = statusStrip_FilePath.Text;
            Emgu.CV.Image<Bgr, Byte> myImage = new Bitmap(SelectedTabPage.pic1.Image).ToImage<Bgr, Byte>();
            NewPage((~myImage).ToBitmap(), statusStrip_FilePath.Text);
            Adjust_Image_Show(0);
            myImage.Dispose();
        }

        private void EMGUProcessing_BlackWhite_Click(object sender, EventArgs e)
        {
            SelectedTabPage = (CreateTabPage)tabControl_Image.SelectedTab;
            statusStrip_FilePath.Text = "二值化處理(Emgu.CV.Mat)";
            //SelectedTabPage.path = statusStrip_FilePath.Text;
            EMGUProcessingGL_24bit_Click(sender, e);//先改成24bits灰階
            InMat = Emgu.CV.BitmapExtension.ToMat((Bitmap)SelectedTabPage.pic1.Image);
            Mat[] channels = InMat.Split();
            VectorOfMat vectorOfMat = new VectorOfMat();
            CvInvoke.Threshold(channels[1], channels[1], 128, 255, ThresholdType.Binary);
            for (int i = 0; i < 3; i++) vectorOfMat.Push(channels[1]);
            CvInvoke.Merge(vectorOfMat, InMat);
            NewPage(InMat.ToBitmap(), statusStrip_FilePath.Text); //顯示處理過後的圖檔
            Adjust_Image_Show(0);
            InMat.Dispose();
        }

        private void EMGUProcessing_Text_Click(object sender, EventArgs e)
        {
            SelectedTabPage = (CreateTabPage)tabControl_Image.SelectedTab;
            statusStrip_FilePath.Text = "圖中放文字(Emgu.CV.Mat)";
            //SelectedTabPage.path = statusStrip_FilePath.Text;
            InMat = Emgu.CV.BitmapExtension.ToMat((Bitmap)SelectedTabPage.pic1.Image);
            Emgu.CV.CvInvoke.PutText(InMat, "Hello, World", new System.Drawing.Point(10, InMat.Height / 2), //(x,y)座標
                    Emgu.CV.CvEnum.FontFace.HersheyScriptComplex, //設定字型
                    4.0,  //大小
                    new Emgu.CV.Structure.Bgr(255, 0, 0).MCvScalar); //表示使用藍色
            NewPage(InMat.ToBitmap(), statusStrip_FilePath.Text); //顯示處理過後的圖檔
            Adjust_Image_Show(0);
            InMat.Dispose();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            panelRT.Location = new Point(this.Width - 18 - panelRT.Size.Width, panelRT.Location.Y);
            panelRT.Height = this.Height - iFH_PRTH;
            panelL.Height = this.Height - iFH_PLH;
            panelL.Width = panelRT.Location.X - 7;
            if (currentImage != 0) toolStrip_FitImage_Click(sender, e);
            panelRD.Location = new System.Drawing.Point(panelRT.Location.X, panelRT.Height + iPanelRBLy + 6);
            tabControl_Image.Height = panelL.Height - 5;
            tabControl_Image.Width = panelL.Width - 4;
        }
        double percent;
        int iPanelRBLy, iFH_PRTH, iFH_PLH, ipanelLeftW_picW;

        private void Adjust_Image_Show(int adjustflags)
        {
            SelectedTabPage = (CreateTabPage)tabControl_Image.SelectedTab;
            Bitmap tempImage = new Bitmap(SelectedTabPage.pic1.Image);
            double ratioI = (double)tempImage.Height / (double)tempImage.Width;
            double ratioP = (double)(tabControl_Image.Height - 30) / (double)(tabControl_Image.Width - 12);
            switch (adjustflags)
            {
                case 0:
                    if (ratioI > ratioP)
                    {
                        SelectedTabPage.pic1.Height = (int)(tabControl_Image.Height - 30);
                        SelectedTabPage.pic1.Width = (int)(double)(SelectedTabPage.pic1.Height / ratioI);
                    }
                    else
                    {
                        SelectedTabPage.pic1.Width = (int)(tabControl_Image.Width - 12);
                        SelectedTabPage.pic1.Height = (int)(SelectedTabPage.pic1.Width / ratioI);
                    }
                    SelectedTabPage.AutoScroll = false;
                    percent = (double)(SelectedTabPage.pic1.Width) / (double)(SelectedTabPage.pic1.Image.Width);
                    break;
                case 1:
                    if (percent < 8)
                    {
                        percent = (double)(SelectedTabPage.pic1.Width) / (double)(SelectedTabPage.pic1.Image.Width) * 1.5;
                        if (percent > 8) percent = 8;
                        SelectedTabPage.pic1.Width = (int)((SelectedTabPage.pic1.Image.Width) * percent);
                        SelectedTabPage.pic1.Height = (int)((double)(SelectedTabPage.pic1.Width) * ratioI);
                    }
                    SelectedTabPage.AutoScroll = true;
                    break;
                case 2:
                    if (percent > 0.08)
                    {
                        percent = (double)(SelectedTabPage.pic1.Width) / (double)(SelectedTabPage.pic1.Image.Width) / 1.5;
                        if (percent < 0.08) percent = 0.08;
                        SelectedTabPage.pic1.Width = (int)((SelectedTabPage.pic1.Image.Width) * percent);
                        SelectedTabPage.pic1.Height = (int)((double)(SelectedTabPage.pic1.Width) * ratioI);
                    }
                    break;
                case 3:
                    percent = 1;
                    SelectedTabPage.pic1.Width = SelectedTabPage.pic1.Image.Width;
                    SelectedTabPage.pic1.Height = SelectedTabPage.pic1.Image.Height;
                    SelectedTabPage.AutoScroll = true;
                    break;
            }
            Show_Status();
        }

        static Bitmap originalbmp;
        static int currentImage = 0;
        static CreateTabPage SelectedTabPage;

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (SelectedTabPage.Image != null) toolStrip_FitImage_Click(sender, e);
        }


        public partial class CreateTabPage : TabPage
        {
            public PictureBox pic1;
            public Bitmap Image;
            public string path = "";
            public CreateTabPage(Bitmap Image, string filename)
            {
                this.AutoScroll = false;
                this.Text = filename.Remove(0, filename.LastIndexOf("\\") + 1);
                path = filename;
                pic1 = new PictureBox();
                this.pic1.Location = new System.Drawing.Point(1, 1);
                this.pic1.SizeMode = PictureBoxSizeMode.Zoom;
                pic1.Width = Image.Width;
                pic1.Height = Image.Height;
                this.pic1.BorderStyle = BorderStyle.FixedSingle;
                pic1.Image = Image;
                this.Controls.Add(pic1);
                currentImage++;
            }

        }
        private void NewPage(Bitmap newMap, string title)
        {
            tabControl_Image.Visible = true;
            SelectedTabPage = (CreateTabPage)tabControl_Image.SelectedTab;
            //string title = SelectedTabPage.path;
            CreateTabPage NewTabPage = new CreateTabPage(newMap, title);
            tabControl_Image.TabPages.Add(NewTabPage);
            tabControl_Image.SelectTab(NewTabPage);
        }
        private void tabControl_Image_SelectedIndexChanged(object sender, EventArgs e)
        {
            Show_Status();
            if (ViewMenu_Histogram.Checked) 
                tabControl_Histogram_SelectedIndexChanged(sender, e);
            else
                Close_Histogram();
        }

        private void ViewMenu_Histogram_Click(object sender, EventArgs e)
        {
            if (ViewMenu_Histogram.Checked == false)
            {
                tabControl_Histogram.Visible = true;
                tabControl_Histogram_SelectedIndexChanged(sender, e);
            }
            else
                Close_Histogram();
            ViewMenu_Histogram.Checked = !ViewMenu_Histogram.Checked;
        }

        private void tabControl_Histogram_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentImage != 0)
            {
                SelectedTabPage = (CreateTabPage)tabControl_Image.SelectedTab;
                f.histogram(new Bitmap(SelectedTabPage.pic1.Image), this.tabControl_Histogram.SelectedTab.Text);
                int width = SelectedTabPage.pic1.Image.Width;
                int height = SelectedTabPage.pic1.Image.Height;
                PictureBox MyPictureBox1 = new PictureBox();
                MyPictureBox1.MouseMove += new MouseEventHandler(MyPictureBox1MouseMove);
                MyPictureBox1.MouseLeave += new EventHandler(MyPictureBox1MouseLeave);
                MyPictureBox1.Image = null;
                MyPictureBox1.Location = new System.Drawing.Point(0, 0);
                MyPictureBox1.Size = new System.Drawing.Size(256, 140);
                MyPictureBox1.Anchor = (AnchorStyles)(Top | Bottom | Left | Right);
                MyPictureBox1.Dock = DockStyle.Top;
                MyPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                MyPictureBox1.BorderStyle = BorderStyle.FixedSingle;
                PictureBox MyPictureBox2 = new PictureBox();
                MyPictureBox2.Location = new System.Drawing.Point(0, 141);
                MyPictureBox2.Size = new System.Drawing.Size(256, 10);
                MyPictureBox2.Anchor = (AnchorStyles)(Top | Bottom | Left | Right);
                MyPictureBox2.Dock = DockStyle.Bottom;
                MyPictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                MyPictureBox2.BorderStyle = BorderStyle.FixedSingle;
                switch (this.tabControl_Histogram.SelectedTab.Text)
                {
                    case "亮度":
                        tabPageLuminance.Controls.Clear();
                        break;
                    case "紅色":
                        tabPageRed.Controls.Clear();
                        break;
                    case "綠色":
                        tabPageGreen.Controls.Clear();
                        break;
                    case "藍色":
                        tabPageBlue.Controls.Clear();
                        break;
                }
                lv_max.Text = "最大值:" + f.maxValue.ToString();
                lv_avg.Text = "平均值:" + ((float)f.average).ToString();
                lv_mid.Text = "中位數:" + f.middle_judge.ToString();
                lv_std.Text = "標準差:" + ((float)Math.Sqrt(f.stand)).ToString();
                lv_tot.Text = "總像素:" + (height * width).ToString();
                MyPictureBox1.Image = f.Array2Bitmap(f.tmpData, this.tabControl_Histogram.SelectedTab.Text);
                MyPictureBox2.Image = f.gradientColor(256, 10, this.tabControl_Histogram.SelectedTab.Text);
                switch(this.tabControl_Histogram.SelectedTab.Text)
                {
                    case "亮度":
                        tabPageLuminance.Controls.Add(MyPictureBox1);
                        tabPageLuminance.Controls.Add(MyPictureBox2);
                        break;
                    case "紅色":
                        tabPageRed.Controls.Add(MyPictureBox1);
                        tabPageRed.Controls.Add(MyPictureBox2);
                        break;
                    case "綠色":
                        tabPageGreen.Controls.Add(MyPictureBox1);
                        tabPageGreen.Controls.Add(MyPictureBox2);
                        break;
                    case "藍色":
                        tabPageBlue.Controls.Add(MyPictureBox1);
                        tabPageBlue.Controls.Add(MyPictureBox2);
                        break;
                }
            }
        }
        private void MyPictureBox1MouseLeave(object sender, EventArgs e)
        {
            lv_bri.Text = "";
            lv_num.Text = "";
        }
        private void MyPictureBox1MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Y >= 0 && e.Y <= 140)
            {
                lv_bri.Text = "亮度值:" + (e.X).ToString();
                switch (this.tabControl_Histogram.SelectedTab.Text)
                {
                    case "亮度":
                        lv_num.Text = "數    量:" + f.Grayhis[e.X].ToString();
                        break;
                    case "紅色":
                        lv_num.Text = "數    量:" + f.Rhis[e.X].ToString();
                        break;
                    case "綠色":
                        lv_num.Text = "數    量:" + f.Ghis[e.X].ToString();
                        break;
                    case "藍色":
                        lv_num.Text = "數    量:" + f.Bhis[e.X].ToString();
                        break;
                }
            }
            else
                MyPictureBox1MouseLeave(sender, e);
        }
        private void Close_Histogram()
        {
            tabControl_Histogram.Visible = false;
            tabPageLuminance.Controls.Clear();
            tabPageRed.Controls.Clear();
            tabPageGreen.Controls.Clear();
            tabPageBlue.Controls.Clear();
            lv_max.Text = "";
            lv_avg.Text = "";
            lv_mid.Text = "";
            lv_std.Text = "";
            lv_tot.Text = "";
            lv_bri.Text = "";
            lv_num.Text = "";
        }
    }
}
