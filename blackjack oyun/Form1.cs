using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blackjack_oyun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int sayac = 0;
        int oyuncutoplam, pctoplam;
        int oyuncupuan = 0;
        int pcpuan = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            sayac++;
            if(sayac == 1) 
            { 
            int o1,o2,toplam;
            o1 = rastgele.Next(1,11);
            o2 = rastgele.Next(1, 11);
            toplam=o1 + o2;
            lbloyuncu1.Text=o1.ToString();
            lbloyuncu2.Text=o2.ToString();
            lbloyuncutoplam.Text=toplam.ToString();
            }
            if (sayac== 2)
            {
                int o3,toplam;
                o3 = rastgele.Next(1, 11);
                lbloyuncu3.Text=o3.ToString();
                toplam= Convert.ToInt32(lbloyuncu1.Text)+ Convert.ToInt32(lbloyuncu2.Text) + o3;
                lbloyuncutoplam.Text =toplam.ToString();
            }
            if(sayac== 3)
            {
                int o4,toplam;
                o4 = rastgele.Next(1, 11);
                lbloyuncu4.Text=o4.ToString();
                toplam = Convert.ToInt32(lbloyuncutoplam.Text) + o4;
                lbloyuncutoplam.Text=toplam.ToString() ;
                button1.Enabled = false;
                
            }
            if (lbloyuncu1.Text == "1")
            {
                pictureBox1.ImageLocation= "C:\\Users\\edanu\\Desktop\\kart1.png";
            }
            if(lbloyuncu1.Text == "2")
            {
                pictureBox1.ImageLocation= "C:\\Users\\edanu\\Desktop\\kart2.png";
            }
            if (lbloyuncu1.Text == "3") 
            {
                pictureBox1.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart3.jpg";
            }
            if (lbloyuncu1.Text == "4")
            {
                pictureBox1.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart4.jpg";
            }
            if (lbloyuncu1.Text == "5")
            {
                pictureBox1.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart5.jpg";
            }
            if (lbloyuncu1.Text == "6")
            {
                pictureBox1.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart6.jpg";
            }
            if (lbloyuncu1.Text == "7")
            {
                pictureBox1.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart7.png";
            }
            if (lbloyuncu1.Text == "8")
            {
                pictureBox1.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart8.jpg";
            }
            if (lbloyuncu1.Text == "9")
            {
                pictureBox1.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart9.jpg";
            }
            if (lbloyuncu1.Text == "10")
            {
                pictureBox1.ImageLocation = "C:\\Users\\edanu\\Desktop\\kartjoker.png";
            }
            if (lbloyuncu2.Text == "1")
            {
                pictureBox2.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart1.png";
            }
            if (lbloyuncu2.Text == "2")
            {
                pictureBox2.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart2.png";
            }
            if (lbloyuncu2.Text == "3")
            {
                pictureBox2.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart3.jpg";
            }
            if (lbloyuncu2.Text == "4")
            {
                pictureBox2.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart4.jpg";
            }
            if (lbloyuncu2.Text == "5")
            {
                pictureBox2.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart5.jpg";
            }
            if (lbloyuncu2.Text == "6")
            {
                pictureBox2.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart6.jpg";
            }
            if (lbloyuncu2.Text == "7")
            {
                pictureBox2.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart7.png";
            }
            if (lbloyuncu2.Text == "8")
            {
                pictureBox2.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart8.jpg";
            }
            if (lbloyuncu2.Text == "9")
            {
                pictureBox2.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart9.jpg";
            }
            if (lbloyuncu2.Text == "10")
            {
                pictureBox2.ImageLocation = "C:\\Users\\edanu\\Desktop\\kartjoker.png";
            }
            if (lbloyuncu3.Text == "1")
            {
                pictureBox3.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart1.png";
            }
            if (lbloyuncu3.Text == "2")
            {
                pictureBox3.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart2.png";
            }
            if (lbloyuncu3.Text == "3")
            {
                pictureBox3.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart3.jpg";
            }
            if (lbloyuncu3.Text == "4")
            {
                pictureBox3.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart4.jpg";
            }
            if (lbloyuncu3.Text == "5")
            {
                pictureBox3.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart5.jpg";
            }
            if (lbloyuncu3.Text == "6")
            {
                pictureBox3.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart6.jpg";
            }
            if (lbloyuncu3.Text == "7")
            {
                pictureBox3.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart7.png";
            }
            if (lbloyuncu3.Text == "8")
            {
                pictureBox3.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart8.jpg";
            }
            if (lbloyuncu3.Text == "9")
            {
                pictureBox3.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart9.jpg";
            }
            if (lbloyuncu3.Text == "10")
            {
                pictureBox3.ImageLocation = "C:\\Users\\edanu\\Desktop\\kartjoker.png";
            }
            if (lbloyuncu4.Text == "1")
            {
                pictureBox4.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart1.png";
            }
            if (lbloyuncu4.Text == "2")
            {
                pictureBox4.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart2.png";
            }
            if (lbloyuncu4.Text == "3")
            {
                pictureBox4.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart3.jpg";
            }
            if (lbloyuncu4.Text == "4")
            {
                pictureBox4.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart4.jpg";
            }
            if (lbloyuncu4.Text == "5")
            {
                pictureBox4.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart5.jpg";
            }
            if (lbloyuncu4.Text == "6")
            {
                pictureBox4.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart6.jpg";
            }
            if (lbloyuncu4.Text == "7")
            {
                pictureBox4.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart7.png";
            }
            if (lbloyuncu4.Text == "8")
            {
                pictureBox4.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart8.jpg";
            }
            if (lbloyuncu4.Text == "9")
            {
                pictureBox4.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart9.jpg";
            }
            if (lbloyuncu4.Text == "10")
            {
                pictureBox4.ImageLocation = "C:\\Users\\edanu\\Desktop\\kartjoker.png";
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            int p1,p2,toplam;
            p1 = rastgele.Next(1, 11);
            p2 = rastgele.Next(1, 11);
            toplam=p1 + p2;
            lblpc1.Text=p1.ToString();
            lblpc2.Text=p2.ToString();
            lblpctoplam.Text = toplam.ToString();
            if (toplam < 16)
            {
                int p3;
                p3 = rastgele.Next(1, 11);
                toplam=toplam + p3;
                lblpc3.Text=p3.ToString();
                lblpctoplam.Text = toplam.ToString();
            }
            if(toplam < 16)
            {
                int p4;
                p4 = rastgele.Next(1, 11);
                toplam=toplam + p4;
                lblpc4.Text=p4.ToString();
                lblpctoplam.Text=toplam.ToString();
                button2.Enabled = false;
                
            }
            if (lblpc1.Text == "1")
            {
                pictureBox5.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart1.png";
            }
            if (lblpc1.Text == "2")
            {
                pictureBox5.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart2.png";
            }
            if (lblpc1.Text == "3")
            {
                pictureBox5.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart3.jpg";
            }
            if (lblpc1.Text == "4")
            {
                pictureBox5.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart4.jpg";
            }
            if (lblpc1.Text == "5")
            {
                pictureBox5.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart5.jpg";
            }
            if (lblpc1.Text == "6")
            {
                pictureBox5.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart6.jpg";
            }
            if (lblpc1.Text == "7")
            {
                pictureBox5.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart7.png";
            }
            if (lblpc1.Text == "8")
            {
                pictureBox5.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart8.jpg";
            }
            if (lblpc1.Text == "9")
            {
                pictureBox5.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart9.jpg";
            }
            if (lblpc1.Text == "10")
            {
                pictureBox5.ImageLocation = "C:\\Users\\edanu\\Desktop\\kartjoker.png";
            }
            if (lblpc2.Text == "1")
            {
                pictureBox6.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart1.png";
            }
            if (lblpc2.Text == "2")
            {
                pictureBox6.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart2.png";
            }
            if (lblpc2.Text == "3")
            {
                pictureBox6.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart3.jpg";
            }
            if (lblpc2.Text == "4")
            {
                pictureBox6.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart4.jpg";
            }
            if (lblpc2.Text == "5")
            {
                pictureBox6.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart5.jpg";
            }
            if (lblpc2.Text == "6")
            {
                pictureBox6.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart6.jpg";
            }
            if (lblpc2.Text == "7")
            {
                pictureBox6.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart7.png";
            }
            if (lblpc2.Text == "8")
            {
                pictureBox6.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart8.jpg";
            }
            if (lblpc2.Text == "9")
            {
                pictureBox6.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart9.jpg";
            }
            if (lblpc2.Text == "10")
            {
                pictureBox6.ImageLocation = "C:\\Users\\edanu\\Desktop\\kartjoker.png";
            }
            if (lblpc3.Text == "1")
            {
                pictureBox7.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart1.png";
            }
            if (lblpc3.Text == "2")
            {
                pictureBox7.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart2.png";
            }
            if (lblpc3.Text == "3")
            {
                pictureBox7.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart3.jpg";
            }
            if (lblpc3.Text == "4")
            {
                pictureBox7.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart4.jpg";
            }
            if (lblpc3.Text == "5")
            {
                pictureBox7.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart5.jpg";
            }
            if (lblpc3.Text == "6")
            {
                pictureBox7.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart6.jpg";
            }
            if (lblpc3.Text == "7")
            {
                pictureBox7.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart7.png";
            }
            if (lblpc3.Text == "8")
            {
                pictureBox7.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart8.jpg";
            }
            if (lblpc3.Text == "9")
            {
                pictureBox7.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart9.jpg";
            }
            if (lblpc3.Text == "10")
            {
                pictureBox7.ImageLocation = "C:\\Users\\edanu\\Desktop\\kartjoker.png";
            }
            if (lblpc4.Text == "1")
            {
                pictureBox8.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart1.png";
            }
            if (lblpc4.Text == "2")
            {
                pictureBox8.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart2.png";
            }
            if (lblpc4.Text == "3")
            {
                pictureBox8.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart3.jpg";
            }
            if (lblpc4.Text == "4")
            {
                pictureBox8.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart4.jpg";
            }
            if (lblpc4.Text == "5")
            {
                pictureBox8.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart5.jpg";
            }
            if (lblpc4.Text == "6")
            {
                pictureBox8.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart6.jpg";
            }
            if (lblpc4.Text == "7")
            {
                pictureBox8.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart7.png";
            }
            if (lblpc4.Text == "8")
            {
                pictureBox8.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart8.jpg";
            }
            if (lblpc4.Text == "9")
            {
                pictureBox8.ImageLocation = "C:\\Users\\edanu\\Desktop\\kart9.jpg";
            }
            if (lblpc4.Text == "10")
            {
                pictureBox8.ImageLocation = "C:\\Users\\edanu\\Desktop\\kartjoker.png";
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
           
            oyuncutoplam = Convert.ToInt32(lbloyuncutoplam.Text);
            pctoplam=Convert.ToInt32(lblpctoplam.Text);
            if (pctoplam < oyuncutoplam && oyuncutoplam <= 21)
            {
                oyuncupuan = oyuncupuan + 10;
                lbloyuncupuan.Text = oyuncupuan.ToString();

            }
            if(oyuncutoplam<pctoplam && pctoplam <= 21)
            {
                pcpuan = pcpuan + 10;
                lblpcpuan.Text=pcpuan.ToString();
            }
            if(oyuncutoplam>=21 && pctoplam >= 21)
            {
                MessageBox.Show("Değerler 21'den Büyük Kazanan Yok Beraberlik:)");
            }
            if(oyuncutoplam==pctoplam && oyuncutoplam<=21 && pctoplam <= 21)
            {
                pcpuan = pcpuan+10;
                oyuncupuan = oyuncupuan + 10;
                lbloyuncupuan.Text= oyuncupuan.ToString();
                lblpcpuan.Text=pcpuan.ToString() ;
            }
           
            if(pctoplam > 21 && oyuncutoplam < 21)
            {
                oyuncupuan = oyuncupuan + 10;
                lbloyuncupuan.Text = oyuncupuan.ToString();
            }
            if (oyuncutoplam > 21 && pctoplam < 21)
            {
                pcpuan = pcpuan + 10;
                lblpcpuan.Text = pcpuan.ToString();
            }
            if (oyuncupuan == 50)
            {
                MessageBox.Show("1.Oyuncu Galip Geldi!");
            }
            if (pcpuan == 50)
            {
                MessageBox.Show("Bilgisayar Galip Geldi!");
            }
            lbloyuncu1.Text = "0";
            lbloyuncu2.Text = "0";
            lbloyuncu3.Text = "0";
            lbloyuncu4.Text = "0";
            lblpc1.Text = "0";
            lblpc2.Text = "0";
            lblpc3.Text = "0";
            lblpc4.Text = "0";
            pictureBox1.ImageLocation = "C:\\Users\\edanu\\Desktop\\kartkapalı.jpg";
            pictureBox2.ImageLocation = "C:\\Users\\edanu\\Desktop\\kartkapalı.jpg";
            pictureBox3.ImageLocation = "C:\\Users\\edanu\\Desktop\\kartkapalı.jpg";
            pictureBox4.ImageLocation = "C:\\Users\\edanu\\Desktop\\kartkapalı.jpg";
            pictureBox5.ImageLocation = "C:\\Users\\edanu\\Desktop\\kartkapalı.jpg";
            pictureBox6.ImageLocation = "C:\\Users\\edanu\\Desktop\\kartkapalı.jpg";
            pictureBox7.ImageLocation = "C:\\Users\\edanu\\Desktop\\kartkapalı.jpg";
            pictureBox8.ImageLocation = "C:\\Users\\edanu\\Desktop\\kartkapalı.jpg";
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sayac = 0;
            lbloyuncutoplam.Text = "0";
            lblpctoplam.Text = "0";
            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
    }
}
