namespace _0719
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.記憶體ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.函式庫ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cannyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.直方圖等化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.儲存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.其他功能ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateImage90ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateImage180ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateImage270ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.其他功能ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(879, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.cannyToolStripMenuItem,
            this.直方圖等化ToolStripMenuItem,
            this.uSMToolStripMenuItem,
            this.儲存ToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(51, 23);
            this.fileToolStripMenuItem.Text = "功能";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.記憶體ToolStripMenuItem,
            this.函式庫ToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.openToolStripMenuItem.Text = "Sobel";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // 記憶體ToolStripMenuItem
            // 
            this.記憶體ToolStripMenuItem.Name = "記憶體ToolStripMenuItem";
            this.記憶體ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.記憶體ToolStripMenuItem.Text = "記憶體";
            this.記憶體ToolStripMenuItem.Click += new System.EventHandler(this.記憶體ToolStripMenuItem_Click);
            // 
            // 函式庫ToolStripMenuItem
            // 
            this.函式庫ToolStripMenuItem.Name = "函式庫ToolStripMenuItem";
            this.函式庫ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.函式庫ToolStripMenuItem.Text = "函式庫";
            this.函式庫ToolStripMenuItem.Click += new System.EventHandler(this.函式庫ToolStripMenuItem_Click);
            // 
            // cannyToolStripMenuItem
            // 
            this.cannyToolStripMenuItem.Name = "cannyToolStripMenuItem";
            this.cannyToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.cannyToolStripMenuItem.Text = "Canny";
            this.cannyToolStripMenuItem.Click += new System.EventHandler(this.cannyToolStripMenuItem_Click);
            // 
            // 直方圖等化ToolStripMenuItem
            // 
            this.直方圖等化ToolStripMenuItem.Name = "直方圖等化ToolStripMenuItem";
            this.直方圖等化ToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.直方圖等化ToolStripMenuItem.Text = "HistogramEqualization";
            this.直方圖等化ToolStripMenuItem.Click += new System.EventHandler(this.直方圖等化ToolStripMenuItem_Click);
            // 
            // uSMToolStripMenuItem
            // 
            this.uSMToolStripMenuItem.Name = "uSMToolStripMenuItem";
            this.uSMToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.uSMToolStripMenuItem.Text = "USM";
            this.uSMToolStripMenuItem.Click += new System.EventHandler(this.uSMToolStripMenuItem_Click);
            // 
            // 儲存ToolStripMenuItem
            // 
            this.儲存ToolStripMenuItem.Name = "儲存ToolStripMenuItem";
            this.儲存ToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.儲存ToolStripMenuItem.Text = "儲存";
            this.儲存ToolStripMenuItem.Click += new System.EventHandler(this.儲存ToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.exitToolStripMenuItem.Text = "離開";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // 其他功能ToolStripMenuItem
            // 
            this.其他功能ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotateImageToolStripMenuItem,
            this.grayscaleToolStripMenuItem});
            this.其他功能ToolStripMenuItem.Name = "其他功能ToolStripMenuItem";
            this.其他功能ToolStripMenuItem.Size = new System.Drawing.Size(81, 23);
            this.其他功能ToolStripMenuItem.Text = "其他功能";
            // 
            // rotateImageToolStripMenuItem
            // 
            this.rotateImageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotateImage90ToolStripMenuItem,
            this.rotateImage180ToolStripMenuItem,
            this.rotateImage270ToolStripMenuItem});
            this.rotateImageToolStripMenuItem.Name = "rotateImageToolStripMenuItem";
            this.rotateImageToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.rotateImageToolStripMenuItem.Text = "RotateImage";
            // 
            // rotateImage90ToolStripMenuItem
            // 
            this.rotateImage90ToolStripMenuItem.Name = "rotateImage90ToolStripMenuItem";
            this.rotateImage90ToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.rotateImage90ToolStripMenuItem.Text = "RotateImage90";
            this.rotateImage90ToolStripMenuItem.Click += new System.EventHandler(this.rotateImage90ToolStripMenuItem_Click_1);
            // 
            // rotateImage180ToolStripMenuItem
            // 
            this.rotateImage180ToolStripMenuItem.Name = "rotateImage180ToolStripMenuItem";
            this.rotateImage180ToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.rotateImage180ToolStripMenuItem.Text = "RotateImage180";
            this.rotateImage180ToolStripMenuItem.Click += new System.EventHandler(this.rotateImage180ToolStripMenuItem_Click);
            // 
            // rotateImage270ToolStripMenuItem
            // 
            this.rotateImage270ToolStripMenuItem.Name = "rotateImage270ToolStripMenuItem";
            this.rotateImage270ToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.rotateImage270ToolStripMenuItem.Text = "RotateImage270";
            this.rotateImage270ToolStripMenuItem.Click += new System.EventHandler(this.rotateImage270ToolStripMenuItem_Click);
            // 
            // grayscaleToolStripMenuItem
            // 
            this.grayscaleToolStripMenuItem.Name = "grayscaleToolStripMenuItem";
            this.grayscaleToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.grayscaleToolStripMenuItem.Text = "Grayscale";
            this.grayscaleToolStripMenuItem.Click += new System.EventHandler(this.grayscaleToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(621, 76);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 38);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(617, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "函式(t/毫秒)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(299, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 379);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox2.Location = new System.Drawing.Point(621, 152);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(185, 38);
            this.textBox2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(617, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "記憶體(t/毫秒)";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(-1, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(279, 379);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 430);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "存檔位置：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(95, 430);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(483, 25);
            this.textBox3.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 522);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "影像處理";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem 記憶體ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 函式庫ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 儲存ToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ToolStripMenuItem cannyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 直方圖等化ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 其他功能ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateImage90ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateImage180ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateImage270ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayscaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSMToolStripMenuItem;
    }
}

