using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)//przycisk otwórz
        {
            openFileDialog1.Title = "Otwórz";//tytuł okna #1
            openFileDialog1.Filter = "bmp (*.bmp)|*.bmp";//format pliku do odczytu #2
            //openFileDialog1.ShowDialog();//Otwarcie okna #3

            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    groupBox1.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    label9.Visible = true;
                    label10.Visible = true;
                    

                    //Pobieranie danych zdjęcia
                    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    System.Drawing.Image zdjecie = System.Drawing.Image.FromFile(openFileDialog1.FileName);

                    label3.Text = zdjecie.Width + " x " + zdjecie.Height;
                    label7.Text = zdjecie.Width + " pikseli";
                    label9.Text = zdjecie.Height + " pikseli";

                    string sciezka = openFileDialog1.FileName.ToString();//wyciągnięcie lokalizacji pliku, zamian na string i przypisanie do zmiennej
                    double len = (new System.IO.FileInfo(sciezka)).Length;//biblioteka IO wyciąga wielkość pliku w bajtach
                    double RozmiarPliku = len / 1000;//dzieląc przez 1000 przeliczamy bajty na kilobajty
                    label5.Text = (Math.Round(RozmiarPliku, 1).ToString()) + " KB";//zaokrągla wynik do jednego miejsca po przecinku
                    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                    pictureBox1.ImageLocation = openFileDialog1.FileName;
                    label10.Text = openFileDialog1.SafeFileName;
                }
            }
            catch(Exception wiadomosc)
            {
                MessageBox.Show(wiadomosc.Message);
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
