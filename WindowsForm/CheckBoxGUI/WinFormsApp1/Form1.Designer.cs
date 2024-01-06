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
            this.ckbValue = new System.Windows.Forms.CheckBox();
            this.txbValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ckbValue
            // 
            this.ckbValue.AutoSize = true;
            this.ckbValue.Location = new System.Drawing.Point(190, 151);
            this.ckbValue.Name = "ckbValue";
            this.ckbValue.Size = new System.Drawing.Size(237, 29);
            this.ckbValue.TabIndex = 0;
            this.ckbValue.Text = "Bạn có phải là spiderman";
            this.ckbValue.ThreeState = true;
            this.ckbValue.UseVisualStyleBackColor = true;
            this.ckbValue.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.ckbValue.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            this.ckbValue.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // txbValue
            // 
            this.txbValue.Location = new System.Drawing.Point(190, 114);
            this.txbValue.Name = "txbValue";
            this.txbValue.Size = new System.Drawing.Size(150, 31);
            this.txbValue.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên bạn";
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(190, 205);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(112, 34);
            this.btnClick.TabIndex = 3;
            this.btnClick.Text = "Click";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbValue);
            this.Controls.Add(this.ckbValue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox ckbValue;
        private TextBox txbValue;
        private Label label1;
        private Button btnClick;
    }
}