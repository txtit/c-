namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.smallimageList = new System.Windows.Forms.ImageList(this.components);
            this.largeiconImage = new System.Windows.Forms.ImageList(this.components);
            this.lwShow = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // smallimageList
            // 
            this.smallimageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.smallimageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("smallimageList.ImageStream")));
            this.smallimageList.TransparentColor = System.Drawing.Color.Transparent;
            this.smallimageList.Images.SetKeyName(0, "BZPF6587.JPG");
            this.smallimageList.Images.SetKeyName(1, "WIN_20230329_14_53_46_Pro.jpg");
            this.smallimageList.Images.SetKeyName(2, "IMG_9506.JPG");
            // 
            // largeiconImage
            // 
            this.largeiconImage.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.largeiconImage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("largeiconImage.ImageStream")));
            this.largeiconImage.TransparentColor = System.Drawing.Color.Transparent;
            this.largeiconImage.Images.SetKeyName(0, "BZPF6587.JPG");
            this.largeiconImage.Images.SetKeyName(1, "WIN_20230329_14_53_46_Pro.jpg");
            this.largeiconImage.Images.SetKeyName(2, "IMG_9506.JPG");
            // 
            // lwShow
            // 
            this.lwShow.Location = new System.Drawing.Point(10, 12);
            this.lwShow.Name = "lwShow";
            this.lwShow.Size = new System.Drawing.Size(844, 335);
            this.lwShow.TabIndex = 0;
            this.lwShow.UseCompatibleStateImageBehavior = false;
            this.lwShow.SelectedIndexChanged += new System.EventHandler(this.lwShow_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "largeicon";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(204, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "detail";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(360, 353);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 34);
            this.button3.TabIndex = 3;
            this.button3.Text = "smallicon";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lwShow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listView1;
        private ImageList largeiconImage;
        private ImageList smallimageList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ListView lwShow;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}