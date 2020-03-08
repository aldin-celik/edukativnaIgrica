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
    public partial class Form4 : Form
    {
        int tacanodg;
        int bodovi = 0;
        int[] postavljenap = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        string[] pitanja =
        {"Koja se mjerna jedinica koristi za napon?",
        "Formula I=U/R je data kojim zakonom?",
        "Koje godine je Ivo Andrić dobio Nobelovu nagradu za književnost?",
        "Kako se zove programski jezik koji služi za pravljenje upita nad bazom podataka?",
        "Kako se zove najviši planinski vrh na svijetu?",
        "Šta je Wolfgang Amadeus Mozart bio po zanimanju?",
        "Koliko ima osnovnih jedinica SI sistema?",
        "Koje godine je Bosna i Hercegovina aneksirana od strane Austro-Ugarske monarhije?",
        "Koje je najdublje jezero na svijetu?",
        "Koliko elektroda ima bipolarni tranzistor?",
        "Koja funkcija je inverzna funkcija eksponencijalne funkcije?",
        "Od koliko saveznih država se sastoje Sjedinjene američke države?",
        "Koja je od ovih elektronskih komponenti aktivna?",
        "Koji je glavni grad Finske?",
        "U koju vrstu jezika spada Engleski jezik?"
         };
        string[] odgovor1 =
        {
        "Amper",
        "Prvim Kirhofovim",
        "1960.",
        "SQL",
        "Maglić",
        "Slikar",
        "5",
        "1764",
        "Bajkalsko",
        "1",
        "Kubna",
        "30",
        "Tranzistor",
        "Helsinki",
        "Romanski"
        };
        string[] odgovor2 =
        {
        "Volt",
        "Drugim Kirhofovim",
        "1961.",
        "Java",
        "Kilmandžaro",
        "Kompozitor",
        "6",
        "1802",
        "Kaspijsko",
        "2",
        "Trigonometrijska",
        "40",
        "Zavojnica",
        "Beč",
        "Germanski"
        };
        string[] odgovor3=
        {
        "Kulon",
        "Ohmovim",
        "1962.",
        "Python",
        "Mont Blan",
        "Zidar",
        "7",
        "1834",
        "Tahoe",
        "3",
        "Linearna",
        "50",
        "Kondenzator",
        "Riga",
        "Keltski"
        };
        string[] odgovor4 =
        {
        "Henri",
        "Faradejovim",
        "1963.",
        "Ruby",
        "Mont Everest",
        "Ribar",
        "8",
        "1878",
        "Boračko",
        "4",
        "Logaritamska",
        "60",
        "Otpornik",
        "Buidmpešta",
        "Slavenski"
        };
        int[] tacanodgovor = {2,3,2,1,4,2,3,4,1,3,4,3,1,1,2 };


        
        public Form4()
        {
            InitializeComponent();
            Ucitajpitanje();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 formaglavna = new Form1();
            formaglavna.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tacanodg == 1)
            {
                bodovi++;
                Ucitajpitanje();
                Azuriraj();
                if (bodovi == 10) Pobjeda();
            }
            else
            {
                MessageBox.Show("Izgubili ste, vaš rezultat je " + bodovi.ToString());
                this.Hide();
                Form1 formaglavna = new Form1();
                formaglavna.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tacanodg == 2)
            {
                bodovi++;
                Ucitajpitanje();
                Azuriraj();
                if (bodovi == 10) Pobjeda();
            }
            else
            {
                MessageBox.Show("Izgubili ste, vas rezultat je " + bodovi.ToString());
                this.Hide();
                Form1 formaglavna = new Form1();
                formaglavna.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tacanodg == 3)
            {
                bodovi++;
                Ucitajpitanje();
                Azuriraj();
                if (bodovi == 10) Pobjeda();
            }
            else
            {
                MessageBox.Show("Izgubili ste, vas rezultat je " + bodovi.ToString());
                this.Hide();
                Form1 formaglavna = new Form1();
                formaglavna.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tacanodg == 4)
            {
                bodovi++;
                Ucitajpitanje();
                Azuriraj();
                if (bodovi == 10) Pobjeda();
            }
            else
            {
                MessageBox.Show("Izgubili ste, vas rezultat je " + bodovi.ToString());
                this.Hide();
                Form1 formaglavna = new Form1();
                formaglavna.Show();
            }
        }

        private void Ucitajpitanje()
        {
           
            Random rnd = new Random((int)DateTime.Now.Ticks);
            int a = 0;
            int z = 0;
            while (z==0)
            {
                a = rnd.Next();
                a = a % 15;
                if (postavljenap[a] == 0)
                {
                    z = 1;
                    postavljenap[a] = 1;
                }
            } 
            
                label1.Text = pitanja[a];
                button1.Text = odgovor1[a]; 
                button2.Text = odgovor2[a]; 
                button3.Text = odgovor3[a]; 
                button4.Text = odgovor4[a];
                tacanodg = tacanodgovor[a];   
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 formaglavna = new Form1();
            formaglavna.Show();
        }
        private void Azuriraj()
        {
            label3.Text = bodovi.ToString();
        }
        private void Pobjeda()
        {
            MessageBox.Show("Pobjedili ste, tačno ste odgovorili na 10 pitanja.");
            this.Hide();
            Form1 formaglavna = new Form1();
            formaglavna.Show();
        }
    }

}

/*
private void Ucitajpitanje()
        {
            String konekcioniString = "Server=localhost; Port=3306; Database=igrica; " +  "Uid=root; Pwd=" ;
            Random rnd = new Random();
            int id = rnd.Next(1, 10);

            string query = "SELECT * FROM Pitanja WHERE ID = " + id;
            MySqlConnection konekcija = new MySqlConnection(konekcioniString);
            konekcija.Open();

            MySqlCommand cmd = new MySqlCommand(query, konekcija);

            MySqlDataReader reader;
            reader = cmd.ExecuteReader();
            reader.Read();
            if (!reader.HasRows)
            {
                MessageBox.Show("Greska");
            }
            else
            {
                label1.Text = Convert.ToString(reader[1]);
                button1.Text = Convert.ToString(reader[2]);
                button2.Text = Convert.ToString(reader[3]);
                button3.Text = Convert.ToString(reader[4]);
                button4.Text = Convert.ToString(reader[5]);
                tacanodg = Convert.ToInt32(reader[6]);
                konekcija.Close();
            }
        } */