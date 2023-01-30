using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Media;


namespace soruCevapProje
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection baglan=new SqlConnection("Data Source=DESKTOP-52MVLDJ\\SQLEXPRESS;Initial Catalog=sorularım;Integrated Security=True;TrustServerCertificate=True;");
        int sayım = 0;  //başla butonuna bastıktan sonra artık sonraki soru yazması için değişken tanımladım
        
        int puan = 0;

        void dogrusoru()
        {
            if (lbldogru.Text == button1.Text)
            {
                button1.BackColor = Color.Green;
            }else if(lbldogru.Text == button2.Text)
            {
                button2.BackColor = Color.Green;
            }else if(lbldogru.Text== button3.Text) {
                button3.BackColor = Color.Green;
            }
            else if (lbldogru.Text == button4.Text)
            {
                button4.BackColor = Color.Green;
            }
        }
        private void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\who\Documents\milyoner\ses.wav");
            simpleSound.Play();
        }

        private void BtnBasla_Click(object sender, EventArgs e)
        {
            BtnBasla.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            BtnBasla.Text = "Diğer Soruya Geç";
            sayım++;
            lblsoru.Text = sayım.ToString();
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\who\Documents\milyoner\ses.wav");
            simpleSound.Stop();
            SoundPlayer simpleSound2 = new SoundPlayer(@"C:\Users\who\Documents\milyoner\sorumusic.wav");
            simpleSound2.Play();

            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;




            if (sayım == 1)
            {
                baglan.Open(); //bağlantımızı açtık
                SqlCommand karar = new SqlCommand("SELECT * FROM soru1 ORDER BY NEWID()", baglan); //Komutumu oluşturuyorum Order by NEWID  diyerek rastgele ID oluşturup seçtiriyorum
                SqlDataReader okuma = karar.ExecuteReader(); //komutumu yazdırıyorum,Execute Reader ile ilişkilendiriyorum.
                while (okuma.Read()) //Veri tabanımızdan okudukça
                {
                    button1.Text = (okuma["a"].ToString()); //a şıkkını okuttum

                    button2.Text = (okuma["b"].ToString()); //b şıkkımı okuttum
                    button3.Text = (okuma["c"].ToString());// c şıkkımı okuttum
                    button4.Text = (okuma["d"].ToString()); // d şıkkımı okuttum
                    textBox1.Text = (okuma["soru"].ToString());
                    lbldogru.Text = (okuma["dogru"].ToString());


                }
                baglan.Close();
            }
            if (sayım == 2)
            {
                baglan.Open();
                SqlCommand karar = new SqlCommand("SELECT * FROM soru2 ORDER BY NEWID()", baglan);
                SqlDataReader okuma = karar.ExecuteReader();
                while (okuma.Read())
                {
                    button1.Text = (okuma["a"].ToString());
                    button2.Text = (okuma["b"].ToString());
                    button3.Text = (okuma["c"].ToString());// c şıkkımı okuttum
                    button4.Text = (okuma["d"].ToString()); // d şıkkımı okuttum
                    textBox1.Text = (okuma["soru"].ToString());
                    lbldogru.Text = (okuma["dogru"].ToString());
                }
                baglan.Close();
            }
            if (sayım == 3)
            {
                baglan.Open();
                SqlCommand karar = new SqlCommand("SELECT * FROM soru3 ORDER BY NEWID()", baglan);
                SqlDataReader okuma = karar.ExecuteReader();
                while (okuma.Read())
                {
                    button1.Text = (okuma["a"].ToString());
                    button2.Text = (okuma["b"].ToString());
                    button3.Text = (okuma["c"].ToString());
                    button4.Text = (okuma["d"].ToString());
                    textBox1.Text = (okuma["soru"].ToString());
                    lbldogru.Text = (okuma["dogru"].ToString());
                }
                baglan.Close();
            }
            if (sayım == 4)
            {
                baglan.Open();
                SqlCommand kar = new SqlCommand("SELECT * FROM soru4 ORDER BY NEWID()", baglan);
                SqlDataReader okuma = kar.ExecuteReader();
                while (okuma.Read())
                {
                    button1.Text = (okuma["a"].ToString());
                    button2.Text = (okuma["b"].ToString());
                    button3.Text = (okuma["c"].ToString());
                    button4.Text = (okuma["d"].ToString());
                    textBox1.Text = (okuma["soru"].ToString());
                    lbldogru.Text = (okuma["dogru"].ToString());
                }
                baglan.Close();

            }
            if (sayım == 5)
            {

                baglan.Open();
                SqlCommand kar = new SqlCommand("SELECT * FROM soru5 ORDER BY NEWID()", baglan);
                SqlDataReader okuma = kar.ExecuteReader();
                while (okuma.Read())
                {
                    button1.Text = (okuma["a"].ToString());
                    button2.Text = (okuma["b"].ToString());
                    button3.Text = (okuma["c"].ToString());
                    button4.Text = (okuma["d"].ToString());
                    textBox1.Text = (okuma["soru"].ToString());
                    lbldogru.Text = (okuma["dogru"].ToString());
                    //BtnBasla.Text = "Oyun bitti";
                    //button1.Enabled = false;
                    //button2.Enabled = false;
                    //button3.Enabled = false;
                    //button4.Enabled = false;
                }

                baglan.Close();

            }
            if (sayım == 6)
            {

                baglan.Open();
                SqlCommand kar = new SqlCommand("SELECT * FROM soru5 ORDER BY NEWID()", baglan);
                SqlDataReader okuma = kar.ExecuteReader();
                while (okuma.Read())
                {

                    SoundPlayer simpleSound3 = new SoundPlayer(@"C:\Users\who\Documents\milyoner\sorumusic.wav");
                    simpleSound.Stop();
                    lblsoru.Text = (sayım-1).ToString();
                    button1.Text = (okuma["a"].ToString());
                    button2.Text = (okuma["b"].ToString());
                    button3.Text = (okuma["c"].ToString());
                    button4.Text = (okuma["d"].ToString());
                    textBox1.Text = (okuma["soru"].ToString());
                    lbldogru.Text = (okuma["dogru"].ToString());
                    BtnBasla.Text = "Oyun bitti";
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                }

                baglan.Close();

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\who\Documents\milyoner\ses.wav");
            simpleSound.Play();
            lblsoru.Text=sayım.ToString();
            textBox1.Text = "BAŞLAMAK İÇİN BAŞLA BUTONUNA BASINIZ";
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            lbldogru.Visible=false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == lbldogru.Text )
            {
                puan = puan + 10;
                lblpuan.Text=puan.ToString();
                SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\who\Documents\milyoner\kazanma.wav");
                simpleSound.Play();
                button3.BackColor = Color.Red;
                button1.BackColor = Color.Green;
                button2.BackColor = Color.Red;
                button4.BackColor = Color.Red;






            }
            else {
                puan = puan - 10;
                lblpuan.Text = puan.ToString();
                
                SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\who\Documents\milyoner\kaybetme.wav");
                simpleSound.Play();
                button1.BackColor = Color.Red;
                dogrusoru();




            }
            
            BtnBasla.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(button2.Text == lbldogru.Text)
            {
                puan = puan + 10;
                lblpuan.Text=puan.ToString();
                SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\who\Documents\milyoner\kazanma.wav");
                simpleSound.Play();
                button3.BackColor = Color.Red;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Green;
                button4.BackColor = Color.Red;



            }
            else
            {
                puan = puan - 10;
                lblpuan.Text = puan.ToString();
             
                SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\who\Documents\milyoner\kaybetme.wav");
                simpleSound.Play();
                button2.BackColor = Color.Red;
                dogrusoru();




            }
            BtnBasla.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == lbldogru.Text)
            {
                puan = puan + 10;
                lblpuan.Text = puan.ToString();
                SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\who\Documents\milyoner\kazanma.wav");
                simpleSound.Play();
                button3.BackColor = Color.Green;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button4.BackColor = Color.Red;



            }
            else
            {
                puan = puan - 10;
                lblpuan.Text = puan.ToString();
                
                SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\who\Documents\milyoner\kaybetme.wav");
                simpleSound.Play();
                button3.BackColor = Color.Red;
                dogrusoru();


            }
            BtnBasla.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == lbldogru.Text)
            {
                puan = puan + 10;
                lblpuan.Text = puan.ToString();
                SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\who\Documents\milyoner\kazanma.wav");
                simpleSound.Play();
                button3.BackColor = Color.Red;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button4.BackColor = Color.Green;

            }
            else
            {
                puan = puan - 10;
                lblpuan.Text = puan.ToString();
                
                SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\who\Documents\milyoner\kaybetme.wav");
                simpleSound.Play();
                button4.BackColor = Color.Red;
                dogrusoru();


            }
            BtnBasla.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
