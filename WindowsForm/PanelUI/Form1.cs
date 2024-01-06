namespace PanelUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Text = "TranThao.com";
            btn.AutoSize = true;

            //Random rand = new Random();
            //btn.Location = new Point( rand.Next(panel1.Size.Height),rand.Next (panel1.Size.Width));
          
            panel1.Controls.Add(btn);
            fpnlButton.Controls.Add(btn);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Enabled = !panel1.Enabled;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}