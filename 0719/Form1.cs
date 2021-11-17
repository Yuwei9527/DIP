using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Diagnostics;
using System.IO;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace _0719
{


    public partial class Form1 : Form
    {

        Image<Bgr, byte> _Imginput;
        public Form1()
        {
            InitializeComponent();
        }
        //定義sobel運算元函式
        public static Bitmap sobelfilter(Bitmap a)
        {
            int w = a.Width;
            int h = a.Height;
            try
            {
                Bitmap dstBitmap = new Bitmap(w, h, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                System.Drawing.Imaging.BitmapData srcData = a.LockBits(new Rectangle
                 (0, 0, w, h), System.Drawing.Imaging.ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                System.Drawing.Imaging.BitmapData dstData = dstBitmap.LockBits(new Rectangle
                 (0, 0, w, h), System.Drawing.Imaging.ImageLockMode.WriteOnly, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                unsafe
                {
                    byte* pIn = (byte*)srcData.Scan0.ToPointer();
                    byte* pOut = (byte*)dstData.Scan0.ToPointer();
                    byte* p;
                    int stride = srcData.Stride;

                    Bitmap d = new Bitmap(w, h);



                    for (int y = 0; y < h; y++)
                    {
                        for (int x = 0; x < w; x++)
                        {
                            //邊緣八個點畫素不變
                            if (x == 0 || x == w - 1 || y == 0 || y == h - 1)
                            {
                                pOut[0] = pIn[0];
                                pOut[1] = pIn[1];
                                pOut[2] = pIn[2];
                            }
                            else
                            {
                                int r0, r1, r2, r3, r4, r5, r6, r7, r8;
                                int g1, g2, g3, g4, g5, g6, g7, g8, g0;
                                int b1, b2, b3, b4, b5, b6, b7, b8, b0;
                                double vR, vG, vB;
                                //左上
                                p = pIn - stride - 3;
                                r1 = p[2];
                                g1 = p[1];
                                b1 = p[0];
                                //正上
                                p = pIn - stride;
                                r2 = p[2];
                                g2 = p[1];
                                b2 = p[0];
                                //右上
                                p = pIn - stride + 3;
                                r3 = p[2];
                                g3 = p[1];
                                b3 = p[0];
                                //左
                                p = pIn - 3;
                                r4 = p[2];
                                g4 = p[1];
                                b4 = p[0];
                                //右
                                p = pIn + 3;
                                r5 = p[2];
                                g5 = p[1];
                                b5 = p[0];
                                //左下
                                p = pIn + stride - 3;
                                r6 = p[2];
                                g6 = p[1];
                                b6 = p[0];
                                //正下
                                p = pIn + stride;
                                r7 = p[2];
                                g7 = p[1];
                                b7 = p[0];
                                // 右下
                                p = pIn + stride + 3;
                                r8 = p[2];
                                g8 = p[1];
                                b8 = p[0];
                                //中心點
                                p = pIn;
                                r0 = p[2];
                                g0 = p[1];
                                b0 = p[0];
                                //使用模板
                                vR = (double)(Math.Abs(r1 + 2 * r4 + r6 - r3 - 2 * r5 - r8) + Math.Abs(r1 + 2 * r2 + r3 - r6 - 2 * r7 - r8));
                                vG = (double)(Math.Abs(g1 + 2 * g4 + g6 - g3 - 2 * g5 - g8) + Math.Abs(g1 + 2 * g2 + g3 - g6 - 2 * g7 - g8));
                                vB = (double)(Math.Abs(b1 + 2 * b4 + b6 - b3 - 2 * b5 - b8) + Math.Abs(b1 + 2 * b2 + b3 - b6 - 2 * b7 - b8));


                                if (vR > 0)
                                {
                                    vR = Math.Min(255, vR);
                                }
                                else
                                {
                                    vR = Math.Max(0, vR);
                                }
                                if (vG > 0)
                                {
                                    vG = Math.Min(255, vG);
                                }
                                else
                                {
                                    vG = Math.Max(0, vG);
                                }
                                if (vB > 0)
                                {
                                    vB = Math.Min(255, vB);
                                }
                                else
                                {
                                    vB = Math.Max(0, vB);
                                }

                                pOut[0] = (byte)vB;
                                pOut[1] = (byte)vG;
                                pOut[2] = (byte)vR;
                            }
                            pIn += 3;
                            pOut += 3;
                        }
                        pIn += srcData.Stride - w * 3;
                        pOut += srcData.Stride - w * 3;
                    }
                }
                a.UnlockBits(srcData);
                dstBitmap.UnlockBits(dstData);

                return dstBitmap;

            }
            catch
            {
                return null;
            }
        }


        public void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }




        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否離開?", "system Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("歡迎使用Sobel_批次");
            MessageBox.Show("版本v1.0");
        }



        List<string> m_fileName = new List<string>();

        List<Bitmap> imgList = new List<Bitmap>();

        int num = new int();

        int SAVE = new int();






        private void 函式庫ToolStripMenuItem_Click(object sender, EventArgs e) //sobel函式庫
        {
            imgList.Clear();
            m_fileName.Clear();
            double result3, result4 = 0;

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image|*.bmp;*.png;*.jpg;*.jpeg";
            ofd.Multiselect = true;//允許選擇多個檔案

            if (ofd.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                num = ofd.FileNames.Length;

                for (int x = 0; x < num; x++)
                {
                    m_fileName.Add(ofd.FileNames[x]);//List路徑
                }

                int y = 0;
                while (y < m_fileName.Count)
                {
                    //load
                    _Imginput = new Image<Bgr, byte>(m_fileName[y]);
                    pictureBox2.Image = _Imginput.Bitmap;

                    System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                    sw.Reset();
                    sw.Start();
                    //sobel_library process
                    Image<Gray, float> _imgGray = _Imginput.Convert<Gray, float>();
                    Image<Gray, float> _imgsobel = _imgGray.Sobel(1, 0, 3);

                    //_imgsobel._ThresholdBinary(new Gray(20), new Gray(200));

                    imgList.Add(_imgsobel.Bitmap);//add funtion_sobel

                    this.pictureBox1.Image = imgList[y];

                    sw.Stop();

                    result3 = sw.Elapsed.TotalMilliseconds;
                    result4 += result3;
                    textBox2.Text = result4 + "毫秒";


                    y = y + 1;
                    SAVE = 0;
                }
                MessageBox.Show("Sobel_函式庫，已執行完成");
            }
        }

        private void 記憶體ToolStripMenuItem_Click(object sender, EventArgs e)  //sobel記憶體_改一下
        {
            imgList.Clear();
            m_fileName.Clear();


            double result1, result2 = 0;

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image|*.bmp;*.png;*.jpg;*.jpeg";
            ofd.Multiselect = true;//允許選擇多個檔案


            if (ofd.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {

                num = ofd.FileNames.Length;
                for (int x = 0; x < num; x++)
                {
                    m_fileName.Add(ofd.FileNames[x]);//List路徑
                }


                int y = 0;
                while (y < m_fileName.Count)
                {
                    //load pictire
                    _Imginput = new Image<Bgr, byte>(m_fileName[y]);
                    pictureBox2.Image = _Imginput.Bitmap;

                    System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                    sw.Reset();
                    sw.Start();

                    //sobel_pixel process
                    Bitmap a = new Bitmap(m_fileName[y]);
                    Bitmap _imgsobel = sobelfilter(a);



                    Image<Gray, byte> _Imgsobel2 = new Image<Gray, byte>(_imgsobel);

                    imgList.Add(_Imgsobel2.Bitmap);
                    //pictureBox1.Image = _Imgsobel2.Bitmap;
                    this.pictureBox1.Image = imgList[y];


                    sw.Stop();

                    result1 = sw.Elapsed.TotalMilliseconds;
                    double result3 = result1;
                    result2 += result1;

                    textBox1.Text = result2 + "毫秒";


                    y = y + 1;
                    SAVE = 0;
                }
                MessageBox.Show("Sobel_記憶體，已執行完成");

            }
        }
        private void 儲存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null || pictureBox2.Image != null)
            {
                FolderBrowserDialog path = new FolderBrowserDialog();
                path.Description = "Please select one folder";
                path.ShowNewFolderButton = true;




                DialogResult save_result = MessageBox.Show("是否要將檔次存在預設路徑", "存檔", MessageBoxButtons.YesNo);
                try
                {
                    if (save_result == DialogResult.Yes)//是_載入圖片圖一個資料夾
                    {
                        int aabb = 0;
                        textBox3.Text = Path.GetDirectoryName(m_fileName[0]);
                        while (aabb < num)
                        {
                            if (SAVE == 5)
                            {
                                string NAME = Path.GetDirectoryName(m_fileName[aabb]) + "\\" + Path.GetFileNameWithoutExtension((m_fileName[aabb])) + "_USM.jpg";
                                imgList[aabb].Save(NAME);
                                aabb = aabb + 1;
                            }
                            if (SAVE == 0)
                            {
                                string NAME = Path.GetDirectoryName(m_fileName[aabb]) + "\\" + Path.GetFileNameWithoutExtension((m_fileName[aabb])) + "_Sobel.jpg";
                                imgList[aabb].Save(NAME);
                                aabb = aabb + 1;
                            }
                            if (SAVE == 1)
                            {
                                string NAME = Path.GetDirectoryName(m_fileName[aabb]) + "\\" + Path.GetFileNameWithoutExtension((m_fileName[aabb])) + "_Canny.jpg";
                                imgList[aabb].Save(NAME);
                                aabb = aabb + 1;
                            }
                            if (SAVE == 2)
                            {
                                string NAME = Path.GetDirectoryName(m_fileName[aabb]) + "\\" + Path.GetFileNameWithoutExtension((m_fileName[aabb])) + "_HisEqual.jpg";
                                imgList[aabb].Save(NAME);
                                aabb = aabb + 1;
                            }
                            if (SAVE == 3)
                            {
                                string NAME = Path.GetDirectoryName(m_fileName[aabb]) + "\\" + Path.GetFileNameWithoutExtension((m_fileName[aabb])) + "Rotate.jpg";
                                imgList[aabb].Save(NAME);
                                aabb = aabb + 1;
                            }
                            if (SAVE == 4)
                            {
                                string NAME = Path.GetDirectoryName(m_fileName[aabb]) + "\\" + Path.GetFileNameWithoutExtension((m_fileName[aabb])) + "Gray.jpg";
                                imgList[aabb].Save(NAME);
                                aabb = aabb + 1;
                            }
                        }
                        MessageBox.Show("儲存完畢");
                    }
                    else
                    {
                        if (path.ShowDialog() == DialogResult.OK)
                        {
                            int bbcc = 0;
                            textBox3.Text = path.SelectedPath;
                            while (bbcc < num)
                            {
                                if (SAVE == 0)
                                {
                                    string NAME = path.SelectedPath + "\\" + Path.GetFileNameWithoutExtension((m_fileName[bbcc])) + "_Sobel.jpg";
                                    imgList[bbcc].Save(NAME);
                                    bbcc = bbcc + 1;
                                }
                                if (SAVE == 4)
                                {
                                    string NAME = path.SelectedPath + "\\" + Path.GetFileNameWithoutExtension((m_fileName[bbcc])) + "Gray.jpg";
                                    imgList[bbcc].Save(NAME);
                                    bbcc = bbcc + 1;
                                }
                            }
                        }
                        MessageBox.Show("儲存完畢");
                    }
                }
                catch
                {
                    MessageBox.Show("ERROR");
                }
            }

        }

        private void cannyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double result5, result6 = 0;

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image|*.bmp;*.png;*.jpg;*.jpeg";
            ofd.Multiselect = true;//允許選擇多個檔案

            if (ofd.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                imgList.Clear();
                m_fileName.Clear();

                num = ofd.FileNames.Length;
                for (int x = 0; x < num; x++)
                {
                    m_fileName.Add(ofd.FileNames[x]);//List路徑
                }

                int y = 0;
                while (y < m_fileName.Count)
                {
                    //load
                    _Imginput = new Image<Bgr, byte>(m_fileName[y]);
                    pictureBox2.Image = _Imginput.Bitmap;

                    System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                    sw.Reset();
                    sw.Start();
                    //sobel_library process
                    Image<Gray, byte> _imgGray = _Imginput.Convert<Gray, byte>();
                    Image<Gray, byte> _imgCanny = _imgGray.Canny(50, 20);


                    imgList.Add(_imgCanny.Bitmap);

                    this.pictureBox1.Image = imgList[y];

                    sw.Stop();

                    result5 = sw.Elapsed.TotalMilliseconds;
                    result6 += result5;
                    textBox2.Text = result6 + "毫秒";


                    y = y + 1;
                    SAVE = 1;
                }
                MessageBox.Show("Canny_函式庫，已執行完成");
            }
        }

        private Bitmap picequalization(Bitmap basemap, int width, int height)
        {
            Bitmap retmap = new Bitmap(basemap, width, height);
            int size = width * height;
            int[] gray = new int[256];
            double[] graydense = new double[256];
            for (int i = 0; i < width; ++i)
                for (int j = 0; j < height; ++j)
                {
                    Color pixel = basemap.GetPixel(i, j);
                    gray[Convert.ToInt16(pixel.R)] += 1;
                }
            for (int i = 0; i < 256; i++)
            {
                graydense[i] = (gray[i] * 1.0) / size;
            }

            for (int i = 1; i < 256; i++)
            {
                graydense[i] += graydense[i - 1];
            }

            for (int i = 0; i < width; ++i)
                for (int j = 0; j < height; ++j)
                {
                    Color pixel = basemap.GetPixel(i, j);
                    int gg = Convert.ToInt16(pixel.R);
                    int g = 0;
                    if (gg == 0)
                        g = 0;
                    else
                        g = Convert.ToInt16(graydense[Convert.ToInt16(pixel.R)] * Convert.ToInt16(pixel.R));

                    pixel = Color.FromArgb(g, g, g);
                    retmap.SetPixel(i, j, pixel);
                    //gray[Convert.ToInt16(pixel.R)] += 1;
                }
            return retmap;
        }

        private void 直方圖等化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double result5, result6 = 0;

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image|*.bmp;*.png;*.jpg;*.jpeg";
            ofd.Multiselect = true;//允許選擇多個檔案

            if (ofd.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                imgList.Clear();
                m_fileName.Clear();

                num = ofd.FileNames.Length;
                for (int x = 0; x < num; x++)
                {
                    m_fileName.Add(ofd.FileNames[x]);//List路徑
                }

                int y = 0;
                while (y < m_fileName.Count)
                {
                    //load
                    _Imginput = new Image<Bgr, byte>(m_fileName[y]);
                    pictureBox2.Image = _Imginput.Bitmap;

                    System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                    sw.Reset();
                    sw.Start();

                    Image<Gray, byte> _imgGray = _Imginput.Convert<Gray, byte>();

                    imgList.Add(picequalization(_imgGray.Bitmap, _imgGray.Width, _imgGray.Height));
                    this.pictureBox1.Image = imgList[y];

                    sw.Stop();

                    result5 = sw.Elapsed.TotalMilliseconds;
                    result6 += result5;
                    textBox2.Text = result6 + "毫秒";


                    y = y + 1;
                    SAVE = 2;
                }
                MessageBox.Show("直方圖等化，已執行完成");
            }

        }

        public Bitmap RotateImage(Bitmap bmp, int angle)
        {
            if (angle != 90 && angle != 180 && angle != 270)
            {
                return null;
            }
            int width = bmp.Width;
            int height = bmp.Height;

            if (angle == 90)
            {
                Bitmap newbmp = new Bitmap(height, width);
                using (Graphics g = Graphics.FromImage(newbmp))
                {
                    Point[] destinationPoints = {
                        new Point(height, 0), // destination for upper-left point of original
                        new Point(height, width),// destination for upper-right point of original
                        new Point(0, 0)}; // destination for lower-left point of original
                    g.DrawImage(bmp, destinationPoints);
                }
                return newbmp;
            }

            if (angle == 180)
            {
                Bitmap newbmp = new Bitmap(width, height);
                using (Graphics g = Graphics.FromImage(newbmp))
                {
                    Point[] destinationPoints = {
                        new Point(width, height), // destination for upper-left point of original
                        new Point(0, height),// destination for upper-right point of original
                        new Point(width, 0)}; // destination for lower-left point of original
                    g.DrawImage(bmp, destinationPoints);
                }
                return newbmp;
            }

            if (angle == 270)
            {
                Bitmap newbmp = new Bitmap(height, width);
                using (Graphics g = Graphics.FromImage(newbmp))
                {
                    Point[] destinationPoints = {
                        new Point(0, width), // destination for upper-left point of original
                        new Point(0, 0),// destination for upper-right point of original
                        new Point(height, width)}; // destination for lower-left point of original
                    g.DrawImage(bmp, destinationPoints);
                }
                return newbmp;
            }
            return null;
        }


        private void rotateImage90ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            double result5, result6 = 0;

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image|*.bmp;*.png;*.jpg;*.jpeg";
            ofd.Multiselect = true;//允許選擇多個檔案

            if (ofd.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                imgList.Clear();
                m_fileName.Clear();

                num = ofd.FileNames.Length;
                for (int x = 0; x < num; x++)
                {
                    m_fileName.Add(ofd.FileNames[x]);//List路徑
                }

                int y = 0;
                while (y < m_fileName.Count)
                {
                    //load
                    _Imginput = new Image<Bgr, byte>(m_fileName[y]);
                    pictureBox2.Image = _Imginput.Bitmap;

                    System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                    sw.Reset();
                    sw.Start();

                    Image<Bgr, byte> _imgBgr = _Imginput.Convert<Bgr, byte>();

                    imgList.Add(RotateImage(_imgBgr.Bitmap, 90));
                    this.pictureBox1.Image = imgList[y];

                    sw.Stop();

                    result5 = sw.Elapsed.TotalMilliseconds;
                    result6 += result5;
                    textBox2.Text = result6 + "毫秒";


                    y = y + 1;
                    SAVE = 3;
                }
                MessageBox.Show("選轉90度，已執行完成");
            }
        }

        private void rotateImage180ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double result5, result6 = 0;

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image|*.bmp;*.png;*.jpg;*.jpeg";
            ofd.Multiselect = true;//允許選擇多個檔案

            if (ofd.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                imgList.Clear();
                m_fileName.Clear();

                num = ofd.FileNames.Length;
                for (int x = 0; x < num; x++)
                {
                    m_fileName.Add(ofd.FileNames[x]);//List路徑
                }

                int y = 0;
                while (y < m_fileName.Count)
                {
                    //load
                    _Imginput = new Image<Bgr, byte>(m_fileName[y]);
                    pictureBox2.Image = _Imginput.Bitmap;

                    System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                    sw.Reset();
                    sw.Start();

                    Image<Bgr, byte> _imgBgr = _Imginput.Convert<Bgr, byte>();

                    imgList.Add(RotateImage(_imgBgr.Bitmap, 180));
                    this.pictureBox1.Image = imgList[y];

                    sw.Stop();

                    result5 = sw.Elapsed.TotalMilliseconds;
                    result6 += result5;
                    textBox2.Text = result6 + "毫秒";


                    y = y + 1;
                    SAVE = 3;
                }
                MessageBox.Show("選轉180度，已執行完成");
            }
        }

        private void rotateImage270ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double result5, result6 = 0;

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image|*.bmp;*.png;*.jpg;*.jpeg";
            ofd.Multiselect = true;//允許選擇多個檔案

            if (ofd.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                imgList.Clear();
                m_fileName.Clear();

                num = ofd.FileNames.Length;
                for (int x = 0; x < num; x++)
                {
                    m_fileName.Add(ofd.FileNames[x]);//List路徑
                }

                int y = 0;
                while (y < m_fileName.Count)
                {
                    //load
                    _Imginput = new Image<Bgr, byte>(m_fileName[y]);
                    pictureBox2.Image = _Imginput.Bitmap;

                    System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                    sw.Reset();
                    sw.Start();

                    Image<Bgr, byte> _imgBgr = _Imginput.Convert<Bgr, byte>();

                    imgList.Add(RotateImage(_imgBgr.Bitmap, 270));
                    this.pictureBox1.Image = imgList[y];

                    sw.Stop();

                    result5 = sw.Elapsed.TotalMilliseconds;
                    result6 += result5;
                    textBox2.Text = result6 + "毫秒";


                    y = y + 1;
                    SAVE = 3;
                }
                MessageBox.Show("選轉270度，已執行完成");
            }
        }

        private void grayscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {


            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image|*.bmp;*.png;*.jpg;*.jpeg";
            ofd.Multiselect = true;//允許選擇多個檔案

            if (ofd.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                imgList.Clear();
                m_fileName.Clear();

                num = ofd.FileNames.Length;
                for (int x = 0; x < num; x++)
                {
                    m_fileName.Add(ofd.FileNames[x]);//List路徑
                }

                int y = 0;
                while (y < m_fileName.Count)
                {
                    //load
                    _Imginput = new Image<Bgr, byte>(m_fileName[y]);
                    pictureBox2.Image = _Imginput.Bitmap;

                    System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                    sw.Reset();
                    sw.Start();

                    Image<Gray, byte> _imgGray = _Imginput.Convert<Gray, byte>();

                    imgList.Add(_imgGray.Bitmap);
                    this.pictureBox1.Image = imgList[y];

                    sw.Stop();



                    y = y + 1;
                    SAVE = 4;
                }
            }
        }

        private void uSMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image|*.bmp;*.png;*.jpg;*.jpeg";
            ofd.Multiselect = true;//允許選擇多個檔案

            if (ofd.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                imgList.Clear();
                m_fileName.Clear();

                num = ofd.FileNames.Length;
                int y = 0;
                for (int x = 0; x < num; x++)
                {
                    m_fileName.Add(ofd.FileNames[x]);//List路徑
                

                
                
                    //load
                    _Imginput = new Image<Bgr, byte>(m_fileName[x]);
                    pictureBox2.Image = _Imginput.Bitmap;
                }
                
                while (y < m_fileName.Count)
                {
                    //load
                    _Imginput = new Image<Bgr, byte>(m_fileName[y]);
                    Bitmap myBitmap = _Imginput.Bitmap;
                    


                    int[] Laplacian = { -1, -1, -1, -1, 9, -1, -1, -1, -1 };
                    Color pixel;
                    //这里注意边界的像素暂不处理，否则超出数组范围
                    for (int i = 1; i < myBitmap.Width - 1; i++)
                    {
                        for (int j = 1; j < myBitmap.Height - 1; j++)
                        {
                            int red = 0, green = 0, blue = 0;
                            int index = 0;
                            for (int col = -1; col <= 1; col++) //3*3处理
                            {
                                for (int row = -1; row <= 1; row++)
                                {
                                    pixel = myBitmap.GetPixel(i + row, j + col);
                                    red += pixel.R * Laplacian[index];
                                    green += pixel.G * Laplacian[index];
                                    blue += pixel.B * Laplacian[index];
                                    index++;
                                }
                            }
                            if (red > 255) red = 255;
                            if (red < 0) red = 0;
                            if (green > 255) green = 255;
                            if (green < 0) green = 0;
                            if (blue > 255) blue = 255;
                            if (blue < 0) blue = 0;
                            myBitmap.SetPixel(i - 1, j - 1, Color.FromArgb((int)red, (int)green, (int)blue)); //这里注意是i-1,j-1，否则效果很糟糕


                        }
                        
                    }

                    imgList.Add(myBitmap);
                    this.pictureBox1.Image = myBitmap; 
                    y = y + 1;
                    SAVE = 5;
                }

            }
            
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}


