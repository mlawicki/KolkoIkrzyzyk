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



    public partial class Form1 : Form
    {
        char a1 = 'z'; //z-nieoznaczony
        char a2 = 'z';
        char a3 = 'z';
        char b1 = 'z';
        char b2 = 'z';
        char b3 = 'z';
        char c1 = 'z';
        char c2 = 'z';
        char c3 = 'z';

        char czyjaTura = 'X'; //o-kolko,x-krzyżyk

        public Form1()
        {
            InitializeComponent();
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

 

        private void Form1_Load(object sender, EventArgs e)
        {

            turaLabel.Text = czyjaTura.ToString();

        }
     //   void sprawdzeniePola()
     //   {
     //       if (a1=a2&&a2=a3)||(b1=b2=b3)||(c1=c2=c3)||(a1=b1=c1)||(a2=b2=c2)||(a3=b3=c3)||(a1=b2=c3)||(a3=b2=c3)
     //               {
     //               }
     //   }
        void zmianaTury()
        {
            if (czyjaTura == 'X')
            { czyjaTura = 'O'; }
            else 
            { czyjaTura = 'X'; }
            turaLabel.Text = czyjaTura.ToString();
        }
        void oznaczenie()
        {
            Text = czyjaTura.ToString();
            Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = czyjaTura.ToString();
            char a1 = czyjaTura;
            zmianaTury();
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = czyjaTura.ToString();
            char a2 = czyjaTura;
            zmianaTury();
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = czyjaTura.ToString();
            char a3 = czyjaTura;
            zmianaTury();
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = czyjaTura.ToString();
            char a4 = czyjaTura;
            zmianaTury();
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = czyjaTura.ToString();
            char a5 = czyjaTura;
            zmianaTury();
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = czyjaTura.ToString();
            char a6 = czyjaTura;
            zmianaTury();
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = czyjaTura.ToString();
            char a7 = czyjaTura;
            zmianaTury();
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = czyjaTura.ToString();
            char a8 = czyjaTura;
            zmianaTury();
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = czyjaTura.ToString();
            char a9 = czyjaTura;
            zmianaTury();
            button9.Enabled = false;
        }
    }
}
