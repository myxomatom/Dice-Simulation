using System;
using System.Windows.Forms;

namespace Essaye_dés
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();


        private void button1_Click(object sender, EventArgs e)
        {
            int de = random.Next(25, 101);
            MessageBox.Show(de.ToString(), "Ansewer", MessageBoxButtons.OK);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int de1 = random.Next(1, 7);
            int de2 = random.Next(1, 7);
            int Total = de1 + de2;
            MessageBox.Show("First dice: " + de1 + " Seconde dice: " + de2);
            MessageBox.Show("Total: " + Total);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
