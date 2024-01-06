namespace ComboBoxGUI
{
    public partial class Form1 : Form
    {
        List<Food> listItem;
        List<Student> ListClass;
        public Form1()
        {
            InitializeComponent();
            listItem = new List<Food>()
            {
                new Food(){Name = "Mực một nắng nướng sa tế", Price =200000},
                new Food(){Name = "Bia 333", Price =10000},
                new Food(){Name = "Vũ Nữ Chưng Dài", Price =150000},
            };
            comboBox1.DataSource = listItem;
            MessageBox.Show();
            comboBox1.DisplayMember = "Name";

            AddBinding();


            ListClass = new List<Student>();
            ListClass.Add(new Student()
            {
                ClassName = "12A7",
                ListStudent = new List<string>() { "K9", "Kosak" }
            });
            ListClass.Add(new Student()
            {
                ClassName = "12A8",
                ListStudent = new List<string>() { "K5", "Kocak" }
            });

            cbBranch.DataSource = ListClass;
            cbBranch.DisplayMember = "ClassName";

           // AddClassBinding();
        }

        void AddClassBinding()
        {
            cbClass.DataBindings.Add("DataSource", cbBranch.SelectedValue, "ListStudent",true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void button1_Click(object sender, EventArgs e)
        {
 
        }

        void AddBinding()
        {
            textBox1.DataBindings.Add(new Binding("Text", comboBox1.DataSource, "Price"));
        }
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            //ComboBox cbx = sender as ComboBox;
            //if(cbx.SelectedValue != null)
            //{
            //    Food foof = cbx.SelectedValue as Food;
            //    textBox1.Text = foof.Price.ToString();
            //}
        }

        private void cbBranch_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedValue != null)
            {
                Student cl = cb.SelectedValue as Student;
                cbClass.DataSource = cl.ListStudent;
            }
        }
    }
    public class Food
    {
        public string Name { get; set; }
        public float Price { get; set; }
    }

    public class Student
    {
        public string ClassName { get; set; }
        public List<string> ListStudent { get; set; }
    }
}