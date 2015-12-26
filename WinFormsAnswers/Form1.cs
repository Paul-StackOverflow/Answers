using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAnswers
{
    public partial class Form1 : Form
    {
        public string[] words = new string[8] { "MIS3640", "is", "called", "Problem", "Solving", "and", "Software", "Design" };
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            label1.Text = "";
            for (int i = 0; i < words.Length; i++)
            {
                addTo(words[i]);
            }
        }

        private void addTo(string words)
        {
            label1.Text += " " + words;
        }
    }
}
