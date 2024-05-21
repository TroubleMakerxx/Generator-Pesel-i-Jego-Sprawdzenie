using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generator_Pesel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void SetMyCustomFormat()
        {
            dateTimePickerDataUrodzenia.Format = DateTimePickerFormat.Custom;
            dateTimePickerDataUrodzenia.CustomFormat = "dd/MM/yyyy";
        }

        private void buttonWstaw_Click(object sender, EventArgs e)
        {
            DateTime data = dateTimePickerDataUrodzenia.Value;
            string plec = comboBoxPlec.Text;
            if(plec == "") {
                MessageBox.Show("Wybierz płeć");
                return;
            }
            int plecInt = 0;
            if (plec == "Kobieta")
            {
                plecInt = 1;
            }
            if (plec == "Mężczyzna")
            {
                plecInt = 2;
            }
            int rok = data.Year;
            int miesiac = data.Month;
            int dzien = data.Day;
            int rok2 = rok % 100;
            if (rok < 1800)
            {
                MessageBox.Show("Data jest z byt odległa!");
                return;
            }
            if (rok >= 1800 && rok <= 1899)
            {
                miesiac += 80;
            }
            else if (rok >= 2000 && rok <= 2099)
            {
                miesiac += 20;
            }
            else if (rok >= 2100 && rok <= 2199)
            {
                miesiac += 40;
            }
            else if (rok >= 2200 && rok <= 2299)
            {
                miesiac += 60;
            }

            string pesel = "";
            pesel += rok2.ToString("00");
            pesel += miesiac.ToString("00");
            pesel += dzien.ToString("00");
            
            if (plecInt == 1)
            {
                Random rnd = new Random();
                int losowa = rnd.Next(0, 10);
                for (int i = 0; i < 3; i++)
                {
                    losowa = rnd.Next(0, 10);
                    pesel += losowa.ToString();
                }
                if (losowa % 2 == 0)
                {
                    pesel += losowa.ToString();
                }
                else
                {
                    while (losowa % 2 != 0)
                    {
                        losowa = rnd.Next(0, 10);
                    }
                    pesel += losowa.ToString();
                }

            }
            else
            {
                Random rnd = new Random();
                int losowa = rnd.Next(0, 10);
                for (int i = 0; i < 3; i++)
                {
                    losowa = rnd.Next(0, 10);
                    pesel += losowa.ToString();
                }
                if (losowa % 2 != 0)
                {
                    pesel += losowa.ToString();
                }
                else
                {
                    while (losowa % 2 == 0)
                    {
                        losowa = rnd.Next(0, 10);
                    }
                    pesel += losowa.ToString();
                }
            }

                int[] wagi = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            int suma = 0;

            for (int i = 0; i < pesel.Length; i++)
            {
                suma += int.Parse(pesel[i].ToString()) * wagi[i];
            }

            suma = suma % 10;
            suma = 10 - suma;
            suma = suma % 10;
            pesel += suma.ToString();
            textBoxPesel.Text = pesel;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetMyCustomFormat();
        }
    }
}
