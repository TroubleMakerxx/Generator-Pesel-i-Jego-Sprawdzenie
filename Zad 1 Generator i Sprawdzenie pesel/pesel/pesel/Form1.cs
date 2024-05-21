using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pesel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void kontrolaLabeli()
        {
            labelSprawdzenie.Text = "";
            labelData.Text = "";
            labelPlec.Text = "";
        }
        public void wyswietl()
        {
            labelSprawdzenie.Visible = true;
            labelData.Visible = true;
            labelPlec.Visible = true;
            panelPesel.Visible = true;
            labelpesel2.Visible = true;
        }
        public void schowaj()
        {
            labelSprawdzenie.Visible = false;
            labelData.Visible = false;
            labelPlec.Visible = false;
            panelPesel.Visible = false;
            labelpesel2.Visible = false;
        }
        
        

        private void buttonSprawdz_Click(object sender, EventArgs e)
        {
            kontrolaLabeli();
            schowaj();
            if (textBoxPesel.Text.Length != 11)
            {
                MessageBox.Show("Wpisz 11 cyfr");
                return;
            }
            else
            {
                string pesel = textBoxPesel.Text;
                for (int i = 0; i < pesel.Length; i++)
                {
                    if (!Char.IsDigit(pesel[i]))
                    {
                        MessageBox.Show("Wpisz tylko cyfry");
                        return;
                    }
                }
                wyswietl();

                int[] wagi = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
                int suma = 0;

                for (int i = 0; i < pesel.Length-1; i++)
                {
                    suma += int.Parse(pesel[i].ToString()) * wagi[i];
                }

                suma = suma % 10;
                suma = 10 - suma;
                suma = suma % 10;
                if (suma == int.Parse(pesel[10].ToString()))
                {
                    labelSprawdzenie.Text="Pesel Prawidłowy";
                    labelSprawdzenie.ForeColor = Color.Green;
                    labelpesel2.Visible = false;

                    if (int.Parse(pesel[9].ToString()) % 2 == 0)
                    {
                        labelPlec.Text = "Kobieta";
                    }
                    else
                    {
                        labelPlec.Text = "Mężczyzna";
                    }

                    int rok = int.Parse(pesel.Substring(0, 2));
                    int miesiac = int.Parse(pesel.Substring(2, 2));
                    int dzien = int.Parse(pesel.Substring(4, 2));
                    if (miesiac > 80)
                    {
                        rok += 1800;
                        miesiac -= 80;
                    }
                    else if (miesiac > 60)
                    {
                        rok += 2200;
                        miesiac -= 60;
                    }
                    else if (miesiac > 40)
                    {
                        rok += 2100;
                        miesiac -= 40;
                    }
                    else if (miesiac > 20)
                    {
                        rok += 2000;
                        miesiac -= 20;
                    }
                    else
                    {
                        rok += 1900;
                    }

                    if (miesiac < 1 || miesiac > 12 || dzien < 1 || dzien > 31)
                    {
                        labelpesel2.ForeColor = Color.Red;
                        labelpesel2.Text = "Pesel Nie prawidłowy";
                        labelpesel2.Visible = true;
                        labelSprawdzenie.Visible = false;
                        labelPlec.Visible = false;
                    }
                    else {
                        bool sprawdz = true;
                        if (miesiac == 2)
                        {
                            if (DateTime.IsLeapYear(rok))
                            {
                                if (dzien > 29)
                                {
                                    labelpesel2.ForeColor = Color.Red;
                                    labelpesel2.Text = "Pesel Nie prawidłowy";
                                    labelpesel2.Visible = true;
                                    labelSprawdzenie.Visible = false;
                                    labelPlec.Visible = false;
                                    sprawdz = false;
                                }
                            }
                            else
                            {
                                if (dzien > 28)
                                {
                                    labelpesel2.ForeColor = Color.Red;
                                    labelpesel2.Text = "Pesel Nie prawidłowy";
                                    labelpesel2.Visible = true;
                                    labelSprawdzenie.Visible = false;
                                    labelPlec.Visible = false;
                                    sprawdz = false;
                                }
                            }
                        } 
                        else if (miesiac == 4 || miesiac == 6 || miesiac == 9 || miesiac == 11)
                        {
                            if (dzien > 30)
                            {
                                labelpesel2.ForeColor = Color.Red;
                                labelpesel2.Text = "Pesel Nie prawidłowy";
                                labelpesel2.Visible = true;
                                labelSprawdzenie.Visible = false;
                                labelPlec.Visible = false;
                                sprawdz = false;
                            }
                        }
                        if (sprawdz)
                        {
                            labelPlec.Text = "Płeć: " + labelPlec.Text;
                            if (miesiac < 10 && dzien < 10)
                            {
                                labelData.Text = "Data urodzenia: " + "0" + dzien + "." + "0" + miesiac + "." + rok;
                            }
                            else if (miesiac < 10)
                            {
                                labelData.Text = "Data urodzenia: " + dzien + "." + "0" + miesiac + "." + rok;
                            }
                            else if (dzien < 10)
                            {
                                labelData.Text = "Data urodzenia: " + "0" + dzien + "." + miesiac + "." + rok;
                            }
                            else
                            {
                                labelData.Text = "Data urodzenia: " + dzien + "." + miesiac + "." + rok;
                            }
                        }
                    }

                    
                }
                else
                {
                    labelpesel2.ForeColor = Color.Red;
                    labelpesel2.Text = "Pesel Nie prawidłowy";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kontrolaLabeli();
            schowaj();
            labelOpis.BackColor = Color.Transparent;
            labelData.BackColor = Color.Transparent;
            labelPlec.BackColor = Color.Transparent;
        }

        private void labelSprawdzenie_Click(object sender, EventArgs e)
        {

        }

        private void labelOpis_Click(object sender, EventArgs e)
        {

        }

        private void labelPlec_Click(object sender, EventArgs e)
        {

        }

        private void paneldolny_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxPesel_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
