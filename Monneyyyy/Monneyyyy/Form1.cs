namespace Monneyyyy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void addDataGribView(User user)
        {
            this.dataGridView1.DataSource = user;
        }
        
        private void openToolStripMenuOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV (*.csv) | *.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] readAllLine = File.ReadAllLines(openFileDialog.FileName);
                for (int i = 0; i < readAllLine.Length; i++)
                {
                    string userRAW = readAllLine[i];
                    string[] userSplited = userRAW.Split(',');
                    User user = new User(userSplited[0], userSplited[11], userSplited[2]);
                    addDataGribView(userSplited[0], userSplited[1], userSplited[2]);
                }

            }
        }
        private void addDataGribView(string incomemoney, string outmoney, string inorout)
        {
            this.dataGridView1.Rows.Add(new string[] { incomemoney, outmoney, inorout });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, comboBox1.Text);
            textBox1.Text = "";
            textBox2.Text = "";
            //คำนวนเงิน
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox3.Text);
            int b = int.Parse(textBox4.Text);
            int sum = a - b;
            textBox5.Text = sum.ToString();
            textBox3.Text = "";
            textBox4.Text = "";
            
        }
    }
}