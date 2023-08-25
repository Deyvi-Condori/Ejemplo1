using System.Diagnostics.Eventing.Reader;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int edad = int.Parse(label1.Text);
            if (edad >= 18)
            {
                lblResultado.Text = "Ud es mayor de edad";
            }
            else
            {
                lblResultado.Text = "Ud es menor de edad";
            }
        }
       
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}