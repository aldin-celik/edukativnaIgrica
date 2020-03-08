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
    public partial class Form3 : Form
    {
        int lijevoakt = 0;
        int desnoakt = 0;
        int[] lijevob = { 0, 1, 2, 3, 4, 5, 6, 7 };
        int[] desnob = { 8, 9, 10, 11, 12, 13, 14, 15 };
        int greske = 0;
        string[] lijevo = { "A", "B", "C", "D", "E", "F", "G", "H" };
        string[] desno = { "a", "b", "c", "d", "e", "f", "g", "h" };
        
        int[] pogpolja = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public Form3()
        {
            InitializeComponent();
            
            int n = lijevob.Length;
            Random rand = new Random((int)DateTime.Now.Ticks);
            while (n > 1)
            {
                int k = rand.Next(n--);
                int temp = lijevob[n];
                lijevob[n] = lijevob[k];
                lijevob[k] = temp;
            }
            n = desnob.Length;
            while (n > 1)
            {
                int k = rand.Next(n--);
                int temp = desnob[n];
                desnob[n] = desnob[k];
                desnob[k] = temp;
            }
            for (int i = 0; i < 8; i++)
            {
                if (lijevob[i] == 0) lijevo[i] = "Sila[F]";
                else if (lijevob[i] == 1) lijevo[i] = "Jačina struje[I]";
                else if (lijevob[i] == 2) lijevo[i] = "Napon[U]";
                else if (lijevob[i] == 3) lijevo[i] = "Dužina[s/l]";
                else if (lijevob[i] == 4) lijevo[i] = "Vrijeme[t]";
                else if (lijevob[i] == 5) lijevo[i] = "Pritisak[P]";
                else if (lijevob[i] == 6) lijevo[i] = "Električni otpor[R]";
                else if (lijevob[i] == 7) lijevo[i] = "Masa[m]";
            }
            for (int i = 0; i < 8; i++)
            {
                if (desnob[i] == 8) desno[i] = "Kilogram[kg]";
                else if (desnob[i] == 9) desno[i] = "Ohm[Ω]";
                else if (desnob[i] == 10) desno[i] = "Paskal[Pa]";
                else if (desnob[i] == 11) desno[i] = "Sekunda[s]";
                else if (desnob[i] == 12) desno[i] = "Metar[m]";
                else if (desnob[i] == 13) desno[i] = "Volt[V]";
                else if (desnob[i] == 14) desno[i] = "Amper[A]";
                else if (desnob[i] == 15) desno[i] = "Njutn[N]";
            }
            button1.Text = lijevo[0];
            button2.Text = lijevo[1];
            button3.Text = lijevo[2];
            button4.Text = lijevo[3];
            button5.Text = lijevo[4];
            button6.Text = lijevo[5];
            button7.Text = lijevo[6];
            button8.Text = lijevo[7];
            button9.Text = desno[0];
            button10.Text = desno[1];
            button11.Text = desno[2];
            button12.Text = desno[3];
            button13.Text = desno[4];
            button14.Text = desno[5];
            button15.Text = desno[6];
            button16.Text = desno[7];

            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 formaglavna = new Form1();
            formaglavna.Show();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 formaglavna = new Form1();
            formaglavna.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lijevoakt = 1;
            button1.BackColor = Color.Yellow;
            if (desnoakt != 0) Provjera();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lijevoakt = 2;
            button2.BackColor = Color.Yellow;
            if (desnoakt != 0) Provjera();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lijevoakt = 3;
            button3.BackColor = Color.Yellow;
            if (desnoakt != 0) Provjera();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lijevoakt = 4;
            button4.BackColor = Color.Yellow;
            if (desnoakt != 0) Provjera();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lijevoakt = 5;
            button5.BackColor = Color.Yellow;
            if (desnoakt != 0) Provjera();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lijevoakt = 6;
            button6.BackColor = Color.Yellow;
            if (desnoakt != 0) Provjera();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lijevoakt = 7;
            button7.BackColor = Color.Yellow;
            if (desnoakt != 0) Provjera();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            lijevoakt = 8;
            button8.BackColor = Color.Yellow;
            if (desnoakt != 0) Provjera();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            desnoakt = 1;
            button9.BackColor = Color.Yellow;
            if (lijevoakt != 0) Provjera();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            desnoakt = 2;
            button10.BackColor = Color.Yellow;
            if (lijevoakt != 0) Provjera();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            desnoakt = 3;
            button11.BackColor = Color.Yellow;
            if (lijevoakt != 0) Provjera();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            desnoakt = 4;
            button12.BackColor = Color.Yellow;
            if (lijevoakt != 0) Provjera();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            desnoakt = 5;
            button13.BackColor = Color.Yellow;
            if (lijevoakt != 0) Provjera();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            desnoakt = 6;
            button14.BackColor = Color.Yellow;
            if (lijevoakt != 0) Provjera();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            desnoakt = 7;
            button15.BackColor = Color.Yellow;
            if (lijevoakt != 0) Provjera();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            desnoakt = 8;
            button16.BackColor = Color.Yellow;
            if (lijevoakt != 0) Provjera();
        }

        private void Provjera()
        {
            if (lijevob[lijevoakt - 1] + desnob[desnoakt - 1] == 15)
            {
                pogpolja[lijevoakt - 1] = 1;
                pogpolja[desnoakt + 7] = 1;
                if (lijevoakt == 1) button1.BackColor = Color.Green;
                else if (lijevoakt == 2) button2.BackColor = Color.Green;
                else if (lijevoakt == 3) button3.BackColor = Color.Green;
                else if (lijevoakt == 4) button4.BackColor = Color.Green;
                else if (lijevoakt == 5) button5.BackColor = Color.Green;
                else if (lijevoakt == 6) button6.BackColor = Color.Green;
                else if (lijevoakt == 7) button7.BackColor = Color.Green;
                else if (lijevoakt == 8) button8.BackColor = Color.Green;
                if (desnoakt == 1) button9.BackColor = Color.Green;
                else if (desnoakt == 2) button10.BackColor = Color.Green;
                else if (desnoakt == 3) button11.BackColor = Color.Green;
                else if (desnoakt == 4) button12.BackColor = Color.Green;
                else if (desnoakt == 5) button13.BackColor = Color.Green;
                else if (desnoakt == 6) button14.BackColor = Color.Green;
                else if (desnoakt == 7) button15.BackColor = Color.Green;
                else if (desnoakt == 8) button16.BackColor = Color.Green;
                int pr = 0;
                for (int i = 0; i < 16; i++)
                {
                    if (pogpolja[i] == 0) pr = 1;
                }
                if (pr == 0) Pobjeda();
            }
            else
            {
                greske++;
                label3.Text = greske.ToString();
                if (pogpolja[0] == 0) button1.BackColor = Color.Transparent;
                if (pogpolja[1] == 0) button2.BackColor = Color.Transparent;
                if (pogpolja[2] == 0) button3.BackColor = Color.Transparent;
                if (pogpolja[3] == 0) button4.BackColor = Color.Transparent;
                if (pogpolja[4] == 0) button5.BackColor = Color.Transparent;
                if (pogpolja[5] == 0) button6.BackColor = Color.Transparent;
                if (pogpolja[6] == 0) button7.BackColor = Color.Transparent;
                if (pogpolja[7] == 0) button8.BackColor = Color.Transparent;
                if (pogpolja[8] == 0) button9.BackColor = Color.Transparent;
                if (pogpolja[9] == 0) button10.BackColor = Color.Transparent;
                if (pogpolja[10] == 0) button11.BackColor = Color.Transparent;
                if (pogpolja[11] == 0) button12.BackColor = Color.Transparent;
                if (pogpolja[12] == 0) button13.BackColor = Color.Transparent;
                if (pogpolja[13] == 0) button14.BackColor = Color.Transparent;
                if (pogpolja[14] == 0) button15.BackColor = Color.Transparent;
                if (pogpolja[15] == 0) button16.BackColor = Color.Transparent;
            }
            lijevoakt = 0;
            desnoakt = 0;
            
            
        }
        private void Pobjeda()
        {
            MessageBox.Show("Pobjedili ste, broj grešaka: "+greske);
            this.Hide();
            Form1 formaglavna = new Form1();
            formaglavna.Show();
        }

      
    }
}
