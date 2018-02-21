using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KolkoIkrzyzyk
{
    public partial class Form2 : Form
    {
        static char czyjaTura;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string message, string buttonText1, string buttonText2)
        {
            lblMessage.Text = message;
            button1.Text = buttonText1;
            button2.Text = buttonText2;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            czyjaTura = 'X';
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            czyjaTura = 'O';
            this.Hide();
        }
    }
}
