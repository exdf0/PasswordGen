using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGen
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        int buttonclick = 0;
        Random rastgele = new Random();
        Random karisiktest = new Random();
        const string karakterlerkarisik = "abcdefgğhıijklmnoöprsştuüvyzABCDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ1234567890_-?*./!@";
       
        const string karakter = "abcdefgğhıijklmnoöprsştuüvyzABCDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ";
       

        private void button1_Click(object sender, EventArgs e)
        {
            var karisik = new char[16];
                for (int i = 0; i < karisik.Length; i++)
            {
                karisik[i] = karakter[karisiktest.Next(karakter.Length)];
            }
            buttonclick++;
            var finalString = new String(karisik);
            listBox1.Items.Add("Şifre "+ buttonclick +": " + finalString);

        }
      
        private void button2_Click(object sender, EventArgs e)
        {
           
            buttonclick+=1;
            
            int rasgele2 = rastgele.Next(1,9) ;
            int rasgele3 = rastgele.Next(1, 9);
            int rasgele4 = rastgele.Next(1, 9);
            int rasgele5 = rastgele.Next(20, 99);
            int rasgele6 = rastgele.Next(49, 99);
            int rasgele7 = rastgele.Next(33, 77);
            int rasgele8 = rastgele.Next(3333, 9999);
            int rasgele9 = rastgele.Next(123, 999);

            listBox1.Items.Add("Şifre "+buttonclick+": "+rasgele2+""+rasgele3+""+rasgele4+""+rasgele5+""+rasgele6+""+rasgele7+""+rasgele8+""+rasgele9);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var karisik2 = new char[16];
            for (int i = 0; i < karisik2.Length; i++)
            {
                karisik2[i] = karakterlerkarisik[karisiktest.Next(karakterlerkarisik.Length)];
            }
            buttonclick++;
            var finalString = new String(karisik2);
            listBox1.Items.Add("Şifre " + buttonclick + ": " + finalString);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count!=0)
            {
                listBox1.Items.Clear();
                buttonclick = 0;
            }
            else
            {
                MessageBox.Show("Zaten oluşturulmuş bir şifre bulunmuyor!","Bir Hata Meydana Geldi!",MessageBoxButtons.OK);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
         DialogResult cevap =   MessageBox.Show("Programdan Çıkmak İstiyor musunuz?","Çıkış Talebi Alındı!",MessageBoxButtons.YesNo);
            if (cevap == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Çıkış İşlemi İptal Edildi!", "", MessageBoxButtons.OK);
            }
        }
    }
}
