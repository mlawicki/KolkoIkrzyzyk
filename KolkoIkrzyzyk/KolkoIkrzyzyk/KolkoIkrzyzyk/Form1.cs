using System;
using System.Windows.Forms;

namespace KolkoIkrzyzyk
{



    public partial class Form1 : Form
    {

        public char czyjaTura = 'X'; //o-kolko,x-krzyżyk
        int iloscTur;
        bool wygrana = false;

        public Form1()
        {
            InitializeComponent();
        }

 

        private void Form1_Load(object sender, EventArgs e)
        {
            turaLabel.Text = czyjaTura.ToString();
            iloscTurLabel.Text = iloscTur.ToString();
            poczatek();
        }
        void poczatek()
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
            czyjaTura = frm.czyjaTura1;
        }
        void sprawdzenie()
        {


            if ((A1.Text == A2.Text) && (A2.Text == A3.Text)&&!A1.Enabled&&!A2.Enabled&&!A3.Enabled) { wygrana = true; MessageBox.Show("Wygrał gracz: " + A1.Text); }
            if ((B1.Text == B2.Text) && (B2.Text == B3.Text)&&!B1.Enabled&&!B2.Enabled&&!B3.Enabled) { wygrana = true; MessageBox.Show("Wygrał gracz: " + A1.Text); }
            if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && !C1.Enabled && !C2.Enabled && !C3.Enabled) { wygrana = true; MessageBox.Show("Wygrał gracz: " + A1.Text); }
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && !A1.Enabled && !B1.Enabled && !C1.Enabled) { wygrana = true; MessageBox.Show("Wygrał gracz: " + A1.Text); }
            if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && !A2.Enabled && !B2.Enabled && !C2.Enabled) { wygrana = true; MessageBox.Show("Wygrał gracz: " + A1.Text); }
            if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && !A3.Enabled && !B3.Enabled && !C3.Enabled) { wygrana = true; MessageBox.Show("Wygrał gracz: " + A1.Text); }
            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && !A1.Enabled && !B2.Enabled && !C3.Enabled) { wygrana = true; MessageBox.Show("Wygrał gracz: " + A1.Text); }
            if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && !A3.Enabled && !B2.Enabled && !C1.Enabled) { wygrana = true; MessageBox.Show("Wygrał gracz: " + A1.Text); }
            else { remis(); }
        }
        void zmianaTury()
        {
            sprawdzenie();
            if (czyjaTura == 'X')
            { czyjaTura = 'O'; }
            else 
            { czyjaTura = 'X'; }
            turaLabel.Text = czyjaTura.ToString();

            iloscTur += 1;
            iloscTurLabel.Text = iloscTur.ToString();


        }
     //   void oznaczenie()
     //   {
     //       this.Text = czyjaTura.ToString();
     //       this.Enabled = false;
     //       sprawdzenie();
     //   }

        void remis()
        {
            if (iloscTur == 9&&!wygrana) { MessageBox.Show("Nikt nie wygrał"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            A1.Text = czyjaTura.ToString();
            zmianaTury();
            A1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            A2.Text = czyjaTura.ToString();
            zmianaTury();
            A2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            A3.Text = czyjaTura.ToString();
            zmianaTury();
            A3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            B1.Text = czyjaTura.ToString();
            zmianaTury();
            B1.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            B2.Text = czyjaTura.ToString();
            zmianaTury();
            B2.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            B3.Text = czyjaTura.ToString();
            zmianaTury();
            B3.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            C1.Text = czyjaTura.ToString();
            zmianaTury();
            C1.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            C2.Text = czyjaTura.ToString();
            zmianaTury();
            C2.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            C3.Text = czyjaTura.ToString();
            zmianaTury();
            C3.Enabled = false;
        }
    }
}
