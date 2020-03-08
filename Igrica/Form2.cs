using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        int otvorenapolja;
        int[] pogodjenapolja = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int[] aktuelnapolja = new int[] { 0, 0};
        int[] vrpolja = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        int sek = 0;
        int min = 0;
        int stot = 0;
        int tsek = 0;
        string[] vrijednosti = 
            { "α", "β", "γ", "δ",
               "ε", "ζ", "η", "θ",
               "θ", "η", "ζ", "ε",
               "δ", "γ", "β","α"
            };
        public Form2()
        {
            InitializeComponent();
            otvorenapolja = 0;
            

            int n = vrpolja.Length;
            Random rand = new Random((int)DateTime.Now.Ticks);
            while (n > 1)
            {
                int k = rand.Next(n--);
                int temp = vrpolja[n];
                vrpolja[n] = vrpolja[k];
                vrpolja[k] = temp;
            }
            int i;
            for (i = 1; i <= 16; i++)
            {
                switch (i)
                {
                    case 1:
                        polje1.Text = Convert.ToString(vrijednosti[vrpolja[i - 1]]);
                        break;
                    case 2:
                        polje2.Text = Convert.ToString(vrijednosti[vrpolja[i - 1]]);
                        break;
                    case 3:
                        polje3.Text = Convert.ToString(vrijednosti[vrpolja[i - 1]]);
                        break;
                    case 4:
                        polje4.Text = Convert.ToString(vrijednosti[vrpolja[i - 1]]);
                        break;
                    case 5:
                        polje5.Text = Convert.ToString(vrijednosti[vrpolja[i - 1]]);
                        break;
                    case 6:
                        polje6.Text = Convert.ToString(vrijednosti[vrpolja[i - 1]]);
                        break;
                    case 7:
                        polje7.Text = Convert.ToString(vrijednosti[vrpolja[i - 1]]);
                        break;
                    case 8:
                        polje8.Text = Convert.ToString(vrijednosti[vrpolja[i - 1]]);
                        break;
                    case 9:
                        polje9.Text = Convert.ToString(vrijednosti[vrpolja[i - 1]]);
                        break;
                    case 10:
                        polje10.Text = Convert.ToString(vrijednosti[vrpolja[i - 1]]);
                        break;
                    case 11:
                        polje11.Text = Convert.ToString(vrijednosti[vrpolja[i - 1]]);
                        break;
                    case 12:
                        polje12.Text = Convert.ToString(vrijednosti[vrpolja[i - 1]]);
                        break;
                    case 13:
                        polje13.Text = Convert.ToString(vrijednosti[vrpolja[i - 1]]);
                        break;
                    case 14:
                        polje14.Text = Convert.ToString(vrijednosti[vrpolja[i - 1]]);
                        break;
                    case 15:
                        polje15.Text = Convert.ToString(vrijednosti[vrpolja[i - 1]]);
                        break;
                    case 16:
                        polje16.Text = Convert.ToString(vrijednosti[vrpolja[i - 1]]);
                        break;

                }



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
            Form1 formaglavna = new Form1();
            formaglavna.Show();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 formaglavna = new Form1();
            formaglavna.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Start();
            }
            pictureBox1.Hide();
            otvorenapolja++;
            if (otvorenapolja == 3) { Provjera(); otvorenapolja = 1; Zatvori(1); }
            if (otvorenapolja == 2) { aktuelnapolja[0] = 1; }
            if (otvorenapolja == 1) aktuelnapolja[1] = 1;
            Pobjeda();
            tsek = 0;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Start();
            }
            pictureBox2.Hide();
            otvorenapolja++;
            if (otvorenapolja == 3) { Provjera(); aktuelnapolja[1] = 2; otvorenapolja = 1; Zatvori(2); }
            if (otvorenapolja == 2) { aktuelnapolja[0] = 2;}
            if (otvorenapolja == 1) aktuelnapolja[1] = 2;
            Pobjeda();
            tsek = 0;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Start();
            }
            pictureBox3.Hide();
            otvorenapolja++;
            if (otvorenapolja == 3) { Provjera(); aktuelnapolja[1] = 3; otvorenapolja = 1; Zatvori(3); }
            if (otvorenapolja == 2) { aktuelnapolja[0] = 3; }
            if (otvorenapolja == 1) aktuelnapolja[1] = 3;
            Pobjeda();
            tsek = 0;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Start();
            }
            pictureBox4.Hide();
            otvorenapolja++;
            if (otvorenapolja == 3) { Provjera(); aktuelnapolja[1] = 4; otvorenapolja = 1; Zatvori(4); }
            if (otvorenapolja == 2) { aktuelnapolja[0] = 4; }
            if (otvorenapolja == 1) aktuelnapolja[1] = 4;
            Pobjeda();
            tsek = 0;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Start();
            }
            pictureBox5.Hide();
            otvorenapolja++;
            if (otvorenapolja == 3) { Provjera(); aktuelnapolja[1] = 5; otvorenapolja = 1; Zatvori(5); }
            if (otvorenapolja == 2) { aktuelnapolja[0] = 5; }
            if (otvorenapolja == 1) aktuelnapolja[1] = 5;
            Pobjeda();
            tsek = 0;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Start();
            }
            pictureBox6.Hide();
            otvorenapolja++;
            if (otvorenapolja == 3) { Provjera(); aktuelnapolja[1] = 6; otvorenapolja = 1; Zatvori(6); }
            if (otvorenapolja == 2) { aktuelnapolja[0] = 6; }
            if (otvorenapolja == 1) aktuelnapolja[1] = 6;
            Pobjeda();
            tsek = 0;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Start();
            }
            pictureBox7.Hide();
            otvorenapolja++;
            if (otvorenapolja == 3) { Provjera(); aktuelnapolja[1] = 7; otvorenapolja = 1; Zatvori(7); }
            if (otvorenapolja == 2) { aktuelnapolja[0] = 7; }
            if (otvorenapolja == 1) aktuelnapolja[1] = 7;
            Pobjeda();
            tsek = 0;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Start();
            }
            pictureBox8.Hide();
            otvorenapolja++;
            if (otvorenapolja == 3) { Provjera(); aktuelnapolja[1] = 8; otvorenapolja = 1; Zatvori(8); }
            if (otvorenapolja == 2) { aktuelnapolja[0] = 8;  }
            if (otvorenapolja == 1) aktuelnapolja[1] = 8;
            Pobjeda();
            tsek = 0;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Start();
            }
            pictureBox9.Hide();
            otvorenapolja++;
            if (otvorenapolja == 3) { Provjera(); aktuelnapolja[1] = 9; otvorenapolja = 1; Zatvori(9); }
            if (otvorenapolja == 2) { aktuelnapolja[0] = 9; }
            if (otvorenapolja == 1) aktuelnapolja[1] = 9;
            Pobjeda();
            tsek = 0;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Start();
            }
            pictureBox10.Hide();
            otvorenapolja++;
            if (otvorenapolja == 3) { Provjera(); aktuelnapolja[1] = 10; otvorenapolja = 1; Zatvori(10); }
            if (otvorenapolja == 2) { aktuelnapolja[0] = 10;}
            if (otvorenapolja == 1) aktuelnapolja[1] = 10;
            Pobjeda();
            tsek = 0;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Start();
            }
            pictureBox11.Hide();
            otvorenapolja++;
            if (otvorenapolja == 3) { Provjera(); aktuelnapolja[1] = 11; otvorenapolja = 1; Zatvori(11); }
            if (otvorenapolja == 2) { aktuelnapolja[0] = 11; }
            if (otvorenapolja == 1) aktuelnapolja[1] = 11;
            Pobjeda();
            tsek = 0;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Start();
            }
            pictureBox12.Hide();
            otvorenapolja++;
            if (otvorenapolja == 3) { Provjera(); aktuelnapolja[1] = 12; otvorenapolja = 1; Zatvori(12); }
            if (otvorenapolja == 2) { aktuelnapolja[0] = 12;  }
            if (otvorenapolja == 1) aktuelnapolja[1] = 12;
            Pobjeda();
            tsek = 0;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Start();
            }
            pictureBox13.Hide();
            otvorenapolja++;
            if (otvorenapolja == 3) { Provjera(); aktuelnapolja[1] = 13; otvorenapolja = 1; Zatvori(13); }
            if (otvorenapolja == 2) { aktuelnapolja[0] = 13;  }
            if (otvorenapolja == 1) aktuelnapolja[1] = 13;
            Pobjeda();
            tsek = 0;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Start();
            }
            pictureBox14.Hide();
            otvorenapolja++;
            if (otvorenapolja == 3) { Provjera(); aktuelnapolja[1] = 14; otvorenapolja = 1; Zatvori(14); }
            if (otvorenapolja == 2) { aktuelnapolja[0] = 14;  }
            if (otvorenapolja == 1) aktuelnapolja[1] = 14;
            Pobjeda();
            tsek = 0;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Start();
            }
            pictureBox15.Hide();
            otvorenapolja++;
            if (otvorenapolja == 3) { Provjera(); aktuelnapolja[1] = 15; otvorenapolja = 1; Zatvori(15); }
            if (otvorenapolja == 2) { aktuelnapolja[0] = 15;  }
            if (otvorenapolja == 1) aktuelnapolja[1] = 15;
            Pobjeda();
            tsek = 0;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Start();
            }
            pictureBox16.Hide();
            otvorenapolja++;
            if (otvorenapolja == 3) { Provjera(); aktuelnapolja[1] = 16; otvorenapolja = 1; Zatvori(16); }
            if (otvorenapolja == 2) { aktuelnapolja[0] = 16; }
            if (otvorenapolja == 1) aktuelnapolja[1] = 16;
            Pobjeda();
            tsek = 0;
        }

        private void Zatvori(int a)
        {
            for (int i = 0; i <= 15; i++)
            {
                if (i != a - 1)
                {
                    switch (i)
                    {
                        case 0:
                            if (pogodjenapolja[0] == 0) pictureBox1.Show();
                            break;
                        case 1:
                            if (pogodjenapolja[1] == 0) pictureBox2.Show();
                            break;
                        case 2:
                            if (pogodjenapolja[2] == 0) pictureBox3.Show();
                            break;
                        case 3:
                            if (pogodjenapolja[3] == 0) pictureBox4.Show();
                            break;
                        case 4:
                            if (pogodjenapolja[4] == 0) pictureBox5.Show();
                            break;
                        case 5:
                            if (pogodjenapolja[5] == 0) pictureBox6.Show();
                            break;
                        case 6:
                            if (pogodjenapolja[6] == 0) pictureBox7.Show();
                            break;
                        case 7:
                            if (pogodjenapolja[7] == 0) pictureBox8.Show();
                            break;
                        case 8:
                            if (pogodjenapolja[8] == 0) pictureBox9.Show();
                            break;
                        case 9:
                            if (pogodjenapolja[9] == 0) pictureBox10.Show();
                            break;
                        case 10:
                            if (pogodjenapolja[10] == 0) pictureBox11.Show();
                            break;
                        case 11:
                            if (pogodjenapolja[11] == 0) pictureBox12.Show();
                            break;
                        case 12:
                            if (pogodjenapolja[12] == 0) pictureBox13.Show();
                            break;
                        case 13:
                            if (pogodjenapolja[13] == 0) pictureBox14.Show();
                            break;
                        case 14:
                            if (pogodjenapolja[14] == 0) pictureBox15.Show();
                            break;
                        case 15:
                            if (pogodjenapolja[15] == 0) pictureBox16.Show();
                            break;
                    }
                }
            }
        }

        private void Provjera()
        {
            if (vrpolja[aktuelnapolja[0] - 1] + vrpolja[aktuelnapolja[1] - 1] == 15)
            {
                pogodjenapolja[aktuelnapolja[0] - 1] = 1;
                pogodjenapolja[aktuelnapolja[1] - 1] = 1;
                
            }
            aktuelnapolja[0] = 0;
            aktuelnapolja[1] = 0;
        }
        private void Pobjeda()
        {
            if (!pictureBox1.Visible && !pictureBox2.Visible && !pictureBox3.Visible && !pictureBox4.Visible)
            {
                if (!pictureBox5.Visible && !pictureBox6.Visible && !pictureBox7.Visible && !pictureBox8.Visible)
                {
                    if (!pictureBox9.Visible && !pictureBox10.Visible && !pictureBox11.Visible && !pictureBox12.Visible)
                    {
                        if (!pictureBox13.Visible && !pictureBox14.Visible && !pictureBox15.Visible && !pictureBox16.Visible)
                        {
                            timer1.Stop();
                            MessageBox.Show("Pobjeda, vaše vrijeme je " + lvrijeme.Text);
                        }
                    }
                }
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (stot < 9)
            {
                stot++;
            }
            else
            {
                stot = 0;
                if (sek < 59)
                {
                    sek++;
                }
                else
                {
                    sek = 0;
                    min++;
                }

            }
            VrijemeUpdate();
            tsek++;
            
            if (tsek == 10)
            {
                if(aktuelnapolja[0] != 0 && aktuelnapolja[1] != 0)
                {
                    if (vrpolja[aktuelnapolja[0]-1] + vrpolja[aktuelnapolja[1]-1] != 15)
                    {
                        if (pogodjenapolja[0] == 0) pictureBox1.Show();
                        if (pogodjenapolja[1] == 0) pictureBox2.Show();
                        if (pogodjenapolja[2] == 0) pictureBox3.Show();
                        if (pogodjenapolja[3] == 0) pictureBox4.Show();
                        if (pogodjenapolja[4] == 0) pictureBox5.Show();
                        if (pogodjenapolja[5] == 0) pictureBox6.Show();
                        if (pogodjenapolja[6] == 0) pictureBox7.Show();
                        if (pogodjenapolja[7] == 0) pictureBox8.Show();
                        if (pogodjenapolja[8] == 0) pictureBox9.Show();
                        if (pogodjenapolja[9] == 0) pictureBox10.Show();
                        if (pogodjenapolja[10] == 0) pictureBox11.Show();
                        if (pogodjenapolja[11] == 0) pictureBox12.Show();
                        if (pogodjenapolja[12] == 0) pictureBox13.Show();
                        if (pogodjenapolja[13] == 0) pictureBox14.Show();
                        if (pogodjenapolja[14] == 0) pictureBox15.Show();
                        if (pogodjenapolja[15] == 0) pictureBox16.Show();
                    }
                }
            }
        }
        private void VrijemeUpdate()
        {
            string s = min + ":" + sek + ":" + stot;
            lvrijeme.Text = s;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            min = 0; sek = 0; stot = 0;
            lvrijeme.Text = "0:0:0";
            pictureBox1.Show();
            pictureBox2.Show();
            pictureBox3.Show();
            pictureBox4.Show();
            pictureBox5.Show();
            pictureBox6.Show();
            pictureBox7.Show();
            pictureBox8.Show();
            pictureBox9.Show();
            pictureBox10.Show();
            pictureBox11.Show();
            pictureBox12.Show();
            pictureBox13.Show();
            pictureBox14.Show();
            pictureBox15.Show();
            pictureBox16.Show();
            for (int i = 0; i < 16; i++)
            {
                pogodjenapolja[i] = 0;
            }
            aktuelnapolja[0] = 0;
            aktuelnapolja[1] = 0;
            otvorenapolja = 0;
            int n = vrpolja.Length;
            Random rand = new Random((int)DateTime.Now.Ticks);
            while (n > 1)
            {
                int k = rand.Next(n--);
                int temp = vrpolja[n];
                vrpolja[n] = vrpolja[k];
                vrpolja[k] = temp;
            }
            int m;
            for (m = 1; m <= 16; m++)
            {
                switch (m)
                {
                    case 1:
                        polje1.Text = Convert.ToString(vrijednosti[vrpolja[m - 1]]);
                        break;
                    case 2:
                        polje2.Text = Convert.ToString(vrijednosti[vrpolja[m - 1]]);
                        break;
                    case 3:
                        polje3.Text = Convert.ToString(vrijednosti[vrpolja[m - 1]]);
                        break;
                    case 4:
                        polje4.Text = Convert.ToString(vrijednosti[vrpolja[m - 1]]);
                        break;
                    case 5:
                        polje5.Text = Convert.ToString(vrijednosti[vrpolja[m - 1]]);
                        break;
                    case 6:
                        polje6.Text = Convert.ToString(vrijednosti[vrpolja[m - 1]]);
                        break;
                    case 7:
                        polje7.Text = Convert.ToString(vrijednosti[vrpolja[m - 1]]);
                        break;
                    case 8:
                        polje8.Text = Convert.ToString(vrijednosti[vrpolja[m - 1]]);
                        break;
                    case 9:
                        polje9.Text = Convert.ToString(vrijednosti[vrpolja[m - 1]]);
                        break;
                    case 10:
                        polje10.Text = Convert.ToString(vrijednosti[vrpolja[m - 1]]);
                        break;
                    case 11:
                        polje11.Text = Convert.ToString(vrijednosti[vrpolja[m - 1]]);
                        break;
                    case 12:
                        polje12.Text = Convert.ToString(vrijednosti[vrpolja[m - 1]]);
                        break;
                    case 13:
                        polje13.Text = Convert.ToString(vrijednosti[vrpolja[m - 1]]);
                        break;
                    case 14:
                        polje14.Text = Convert.ToString(vrijednosti[vrpolja[m - 1]]);
                        break;
                    case 15:
                        polje15.Text = Convert.ToString(vrijednosti[vrpolja[m - 1]]);
                        break;
                    case 16:
                        polje16.Text = Convert.ToString(vrijednosti[vrpolja[m - 1]]);
                        break;

                }



            }
        }
    }
}
