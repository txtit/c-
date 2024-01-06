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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tranthaocomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.freefireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shareaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.k3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tranthaocomToolStripMenuItem,
            this.k3ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tranthaocomToolStripMenuItem
            // 
            this.tranthaocomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.freefireToolStripMenuItem,
            this.shareaToolStripMenuItem,
            this.vToolStripMenuItem,
            this.toolStripComboBox1});
            this.tranthaocomToolStripMenuItem.Name = "tranthaocomToolStripMenuItem";
            this.tranthaocomToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.tranthaocomToolStripMenuItem.Text = "tranthao.com";
            // 
            // freefireToolStripMenuItem
            // 
            this.freefireToolStripMenuItem.Name = "freefireToolStripMenuItem";
            this.freefireToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.freefireToolStripMenuItem.Text = "freefire";
            // 
            // shareaToolStripMenuItem
            // 
            this.shareaToolStripMenuItem.Name = "shareaToolStripMenuItem";
            this.shareaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.shareaToolStripMenuItem.Text = "sharea";
            // 
            // vToolStripMenuItem
            // 
            this.vToolStripMenuItem.Name = "vToolStripMenuItem";
            this.vToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.vToolStripMenuItem.Text = "v";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 28);
            this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // k3ToolStripMenuItem
            // 
            this.k3ToolStripMenuItem.Name = "k3ToolStripMenuItem";
            this.k3ToolStripMenuItem.Size = new System.Drawing.Size(38, 24);
            this.k3ToolStripMenuItem.Text = "k3";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(272, 119);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(484, 232);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(203, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tranthaocomToolStripMenuItem;
        private ToolStripMenuItem freefireToolStripMenuItem;
        private ToolStripMenuItem shareaToolStripMenuItem;
        private ToolStripMenuItem k3ToolStripMenuItem;
        private ToolStripMenuItem vToolStripMenuItem;
        private ToolStripComboBox toolStripComboBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}