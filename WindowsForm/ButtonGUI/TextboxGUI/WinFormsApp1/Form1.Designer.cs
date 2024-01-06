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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tb_value = new System.Windows.Forms.TextBox();
            this.lbValue = new System.Windows.Forms.Label();
            this.btnValue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 263);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(472, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '9';
            this.textBox2.Size = new System.Drawing.Size(231, 31);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "kkkkkkkkkkkkkkkk";
            // 
            // tb_value
            // 
            this.tb_value.Location = new System.Drawing.Point(118, 310);
            this.tb_value.Name = "tb_value";
            this.tb_value.Size = new System.Drawing.Size(257, 31);
            this.tb_value.TabIndex = 0;
            this.tb_value.TextChanged += new System.EventHandler(this.tb_value_TextChanged);
            // 
            // lbValue
            // 
            this.lbValue.AutoSize = true;
            this.lbValue.Location = new System.Drawing.Point(118, 361);
            this.lbValue.Name = "lbValue";
            this.lbValue.Size = new System.Drawing.Size(59, 25);
            this.lbValue.TabIndex = 3;
            this.lbValue.Text = "label1";
            // 
            // btnValue
            // 
            this.btnValue.Location = new System.Drawing.Point(391, 310);
            this.btnValue.Name = "btnValue";
            this.btnValue.Size = new System.Drawing.Size(112, 34);
            this.btnValue.TabIndex = 4;
            this.btnValue.Text = "button1";
            this.btnValue.UseVisualStyleBackColor = true;
            this.btnValue.Click += new System.EventHandler(this.btnValue_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnValue;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnValue);
            this.Controls.Add(this.lbValue);
            this.Controls.Add(this.tb_value);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox tb_value;
        private Label lbValue;
        private Button btnValue;
    }
}