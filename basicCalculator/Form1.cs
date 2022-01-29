
using Calculator;
namespace basicCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Calculate cal = new Calculate();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            int i = cal.Addition(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            Result.Text = i.ToString();
        }

        private void Subtraction_Click(object sender, EventArgs e)
        {
            int i = cal.Subtration(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            Result.Text = i.ToString();
        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            int i = cal.Multiplication(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            Result.Text = i.ToString();
        }

        private void Division_Click(object sender, EventArgs e)
        {
            int i = cal.Division(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            Result.Text = i.ToString();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}