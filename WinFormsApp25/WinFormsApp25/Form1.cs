using System.Data.SqlClient;
    namespace WinFormsApp25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="siteadmin"&& textBox2.Text == "site12345")
            {
                Form2 form = new Form2();
                form.ShowDialog();
                this.Hide();
            }
        }
    }
}
