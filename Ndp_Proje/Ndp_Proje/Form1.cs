using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ndp_Proje
{
   
    public partial class Form1 : Form
    {
        int sayi;
        int sayac = 60;
        Metal _metal;
        Cam _cam;
        Kagit _kagit;
        OrganikAtık _organikAtık;
        Atik[] atik;
        Random rastgele = new Random();
        public Form1()
        {

            InitializeComponent();


            _metal = new Metal();
            _cam = new Cam();
            _kagit = new Kagit();
            _organikAtık = new OrganikAtık();
           
            atik = new Atik[8];
            atik[0] = new Atik("bardak", "Cam", 250, Image.FromFile(0 + ".jpg"));
            atik[1] = new Atik("cam şişe", "Cam", 600, Image.FromFile(1 + ".jpg"));
            atik[2] = new Atik("dergi", "Kagit", 200, Image.FromFile(2 + ".jpg"));
            atik[3] = new Atik("gazete", "Kagit", 250, Image.FromFile(3 + ".jpg"));
            atik[4] = new Atik("salça kutusu", "Metal", 550, Image.FromFile(4 + ".jpg"));
            atik[5] = new Atik("kola kutusu", "Metal", 350, Image.FromFile(5 + ".jpg"));
            atik[6] = new Atik("salatalık", "Organik", 120, Image.FromFile(6 + ".jpg"));
            atik[7] = new Atik("domates", "Organik", 150, Image.FromFile(7 + ".jpg"));


        }
        private void RastgeleResim()
        {
            sayi = rastgele.Next(0, 8);

            atikPictureBox.Image = atik[sayi].Image;
        }

        private void PuanEkle()
        {
            puanLabel.Text = Convert.ToString(Convert.ToInt32(puanLabel.Text) + atik[sayi].Hacim);
        }
        private void Sifirla()
        {
            camListBox.Items.Clear();
            kagıtListBox.Items.Clear();
            organikAtıkListBox.Items.Clear();
            metalListBox.Items.Clear();

            camProgress.Value = 0;
            kagitProgress.Value = 0;
            organikProgress.Value = 0;
            metalProgress.Value = 0;

        }
        private void Pasif()
        {
            organikAtıkGroupBox.Enabled = false;
            camGroupBox.Enabled = false;
            kagıtGroupBox.Enabled = false;
            metalGroupBox.Enabled = false;
        }

        private void Aktif()
        {
            organikAtıkGroupBox.Enabled = true;
            camGroupBox.Enabled = true;
            kagıtGroupBox.Enabled = true;
            metalGroupBox.Enabled = true;
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            Pasif();
           
        }

        private void yeniOyunButton_Click(object sender, EventArgs e)
        {
            yeniOyunButton.Enabled = false;
            timer1.Start();

            RastgeleResim();

            puanLabel.Text = "0";
            sureLabel.Text = "60";
 
            Aktif();
            
            Sifirla();

        }

        private void cikisButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void organikAtıkButton_Click(object sender, EventArgs e)
        {
            _organikAtık.DoluHacim += atik[sayi].Hacim;
            if (_organikAtık.Kapasite >= _organikAtık.DoluHacim)
            {

                if (atik[sayi].Tur == "Organik")
                {
                    _organikAtık.Ekle(atik[sayi]);

                    organikProgress.Minimum = 0;
                    organikProgress.Maximum = 700;
                    organikProgress.Value = _organikAtık.DoluHacim;

                    organikAtıkListBox.Items.Add(atik[sayi].Ad + "(" + atik[sayi].Hacim + ")");

                    PuanEkle();

                    RastgeleResim();
                }

            }

        }
  
        private void kagıtButton_Click(object sender, EventArgs e)
        {
            _kagit.DoluHacim += atik[sayi].Hacim;
            if (_kagit.Kapasite >= _kagit.DoluHacim)
            {

                if (atik[sayi].Tur == "Kagit")
                {
                    _kagit.Ekle(atik[sayi]);

                    kagitProgress.Minimum = 0;
                    kagitProgress.Maximum = 1200;
                    kagitProgress.Value = _kagit.DoluHacim;

                    kagıtListBox.Items.Add(atik[sayi].Ad + "(" + atik[sayi].Hacim + ")");
                    PuanEkle();

                    RastgeleResim();
                  
                }
            }
          
        }

        private void camButton_Click(object sender, EventArgs e)
        {
            _cam.DoluHacim += atik[sayi].Hacim;
            if (_cam.Kapasite>=_cam.DoluHacim)
            {

                 if (atik[sayi].Tur == "Cam")
                 {
                     _cam.Ekle(atik[sayi]);

                     camProgress.Minimum = 0;
                     camProgress.Maximum = 2200;
                     camProgress.Value = _cam.DoluHacim;

                     camListBox.Items.Add(atik[sayi].Ad + "(" + atik[sayi].Hacim + ")");
                     PuanEkle();

                     RastgeleResim();
                 }

            }
        }
        private void metalButton_Click(object sender, EventArgs e)
        {
            _metal.DoluHacim += atik[sayi].Hacim;
            if (_metal.Kapasite>=_metal.DoluHacim)
            {

                if (atik[sayi].Tur == "Metal")
                {
                _metal.Ekle(atik[sayi]);

                metalProgress.Minimum = 0;
                metalProgress.Maximum = 2300;
                metalProgress.Value = _metal.DoluHacim;

                metalListBox.Items.Add(atik[sayi].Ad + "(" + atik[sayi].Hacim + ")");
                PuanEkle();

                RastgeleResim();
                }
            }
        }


        private void organikAtıkBosaltButton_Click(object sender, EventArgs e)
        {
            

            if (_organikAtık.DoluHacim>= (_organikAtık.Kapasite * 75) / 100)
            {
                _organikAtık.Bosalt();
                sayac += 3;
                puanLabel.Text = (Convert.ToInt32( puanLabel.Text )+ _organikAtık.BosaltmaPuanı).ToString();
                organikProgress.Value = _organikAtık.DoluHacim;
                organikAtıkListBox.Items.Clear();
            }
            
        }

        private void kagıtBosaltButton_Click(object sender, EventArgs e)
        {
          

            if (_kagit.DoluHacim >(_kagit.Kapasite*75)/100)
            {
                _kagit.Bosalt();
                sayac += 3;
                puanLabel.Text = (Convert.ToInt32(puanLabel.Text) + _kagit.BosaltmaPuanı).ToString();
                kagitProgress.Value = _kagit.DoluHacim;
                kagıtListBox.Items.Clear();
            }
        }

        private void camBosaltButton_Click(object sender, EventArgs e)
        {
           
            if (_cam.DoluHacim >= (_cam.Kapasite * 75) / 100)
            {
                _cam.Bosalt();
                sayac += 3;
                puanLabel.Text = (Convert.ToInt32(puanLabel.Text) + _cam.BosaltmaPuanı).ToString();
                camProgress.Value = _cam.DoluHacim;
                
                camListBox.Items.Clear();
            }
        }

        private void metalBosaltButton_Click(object sender, EventArgs e)
        {
          
           
            if (_metal.DoluHacim >= (_metal.Kapasite * 75) / 100)
            {
                _metal.Bosalt();
                sayac += 3;
                puanLabel.Text = (Convert.ToInt32(puanLabel.Text) + _metal.BosaltmaPuanı).ToString();
                metalProgress.Value = _metal.DoluHacim;
                metalListBox.Items.Clear();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac = sayac - 1;
            sureLabel.Text = sayac.ToString();
            
            if(sayac==0)
            {
                timer1.Stop();

                yeniOyunButton.Enabled = true;

                Pasif();
                
                sayac = 60;
                
            }


        }

    }
    
}
