namespace ButtonGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;
        void AddButton()
        {
            Random rand = new Random();
            Button btn = new Button() { Text = i.ToString(), Location = new Point(rand.Next(0,this.Size.Width) , rand.Next(0,this.Size.Height))};
            btn.AutoSize = true;
            btn.Click += Btn_Click;
            this.Controls.Add(btn);
            i++;
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            Button btn = sender as Button;
            MessageBox.Show(btn.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddButton();
        }
    }
}