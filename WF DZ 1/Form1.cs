using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_DZ_1
{
    public partial class Form1 : Form
    {
        int verh = 100;
        int niz = 1;
        int value;
        int i = 0;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            value = rnd.Next(niz, verh);
            label1.Text = value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Я ж казав що вгадаю вашe число))\nКількість спроб: {i}", "Легкооооо");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            niz = Convert.ToInt32(label1.Text);
            value = rnd.Next(niz, verh);
            label1.Text = value.ToString();
            ++i;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            verh = Convert.ToInt32(label1.Text);
            value = rnd.Next(niz, verh);
            label1.Text = value.ToString();
            ++i;
        }
    }
}
