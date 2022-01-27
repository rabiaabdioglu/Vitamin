using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Vitamin
{




    public partial class Form1 : Form
    {
        Random random = new Random();
        private double _toplamVitaminA=0.0, _toplamVitaminC=0.0;
        private double _siviGram = 0.0, _pureGram = 0.0;
        private int _meyveIndex;
        private int _saniye = 0;
        DialogResult tekrarOynama = new DialogResult();
        
        //MEYVE NESNESİ OLUŞTURULDU
            Meyve meyve;

        public Form1()
        {
            InitializeComponent();
        }

        public void FotografDegis()
        {
            //image listte bulunan 6 görselden rastgele biri gelir.
            _meyveIndex = random.Next(6);
            //pictureBoxa seçilen görsel atılır.
            MeyveKutusu.Image = MeyveKutusuFotograf.Images[_meyveIndex];

            

        }


        //Bu fonksiyon picturebox taki meyvenin hangi sıkacağa ait olduğuna bakar 
        //Narenciye ise true dondurur. String ile de yapılabilirdi.
        public bool SikacakBul()
        {
            MeyveSikacagi dogruMu = new Narenciye();

            foreach (string item in dogruMu.Meyveler)
            {
                if (item== MeyveKutusuFotograf.Images.Keys[_meyveIndex])
                {
                    return true;
                    //eğer doğruysa meyve narenciye ile sıkılmalı
                }
            }
            return false;


        }
        //Bu fonksiyon  gerekli olan sınıftan  nesne türetiliyor
        public IMeyveSikacagi  SikacakOlustur()
        {   

            //sonradan atama yapılacak 
            IMeyveSikacagi islem;
       
            //true ise Narenciye seçilmiştir ve  interface den nesneler oluşturuluyor 
            // sebebi tekrar tekrar hangi meyve sıkma aracının kullanıldığını bulmamak

            if (SikacakBul()== true) { islem = new Narenciye(); }
            else { islem = new KatiMeyveSikacagi(); }

           return islem;

        }

        //Bu fonksiyon sıkacak argümanı alıp 
        //eğer gelen nesne narenciye den oluşturulmuş ise o sınıftaki verimbul fonksiyonunu
        //değilse diğer sınıftan oluşan fonksiyonu kullanır verim hesabını döndürür.
        public double VerimAta(IMeyveSikacagi meyveSikacagi)
        {

          return meyveSikacagi.VerimBul();

        }

        //Bu fonksiyon Meyve nesnesinin tüm özelliklerini atar 
        // Form 1 tasarımında ki labela özellikleri yazar.
        public void MeyveOzellikAta()
        {



            //Meyve adi pictureBox ta bulunan fotoğrafın dosya adından alınır
            string meyveAdi = MeyveKutusuFotograf.Images.Keys[_meyveIndex];

            //Fotografın adı meyve adı olduğundan  doğru eşleşmeye göre nesne oluşturuluyor.
            if (meyveAdi == "Portakal") meyve = new Portakal();
            else if (meyveAdi == "Armut") meyve = new Armut();
            else if (meyveAdi == "Cilek") meyve = new Cilek();
            else if (meyveAdi == "Mandalina") meyve = new Mandalina();
            else if (meyveAdi == "Greyfurt") meyve = new Greyfurt();
            else if (meyveAdi == "Elma") meyve = new Elma();
            else { meyve = null; }


            //meyvenin verim değeri alındı atandı
            meyve.Verim =  VerimAta(SikacakOlustur());
           
            //70-120 arası rastegele değer alınır
            double agirlik = random.Next(69, 121);
            meyve.Agirlik = agirlik;



            /// meyve görseli yanına meyveye ait olan özellikler yazılır
            label3.Text = meyve.MeyveAdi;
            label4.Text = meyve.Agirlik.ToString();
            label5.Text = meyve.VitaminADegeri.ToString();
            label6.Text = meyve.VitaminCDegeri.ToString();
            label7.Text = meyve.Verim.ToString();

        }

        public void MeyveSık()
        {// sıkma işleminden sonra   sıvı püre hallerinin değerleri

            double yeniAgirlik = meyve.Verim * meyve.Agirlik / 100;
            double yeniAVitaminiDegeri = yeniAgirlik * meyve.VitaminADegeri / meyve.Agirlik;
            double yeniCVitaminiDegeri = yeniAgirlik * meyve.VitaminCDegeri / meyve.Agirlik;



            //yeni vitamin değerleri güncelleniyor 
            _toplamVitaminA += yeniAVitaminiDegeri;

            _toplamVitaminC += yeniCVitaminiDegeri;


            //eğer narenciye ise sıvı miktarı 
            //katı meyve sıkacağıysa püre miktarında artış oluyor.
            if (SikacakBul() == true) _siviGram += yeniAgirlik;
            else _pureGram += yeniAgirlik;
            

            //yeni toplam miktarların güncel hali yazılıyor

            label10.Text = "A vitamini            :          " + _toplamVitaminA +
                "\n\n Sıvı                    :          " + _siviGram;
            label16.Text=" C vitamini               :           " + _toplamVitaminC +
                "\n\n Püre                        :          " + _pureGram;


            //geçmiş listbox ına başarılı olan sıkma işlemi detayları aktarılıyor
            gecmis.Items.Add(meyve.MeyveAdi+ "                  " + yeniAgirlik+ "                  " + yeniAVitaminiDegeri+ "                  " + yeniCVitaminiDegeri);


        }

        public void VitaminDeposuUygulama()
        {
        



            //Meyve nesnesi oluşturulur ve gerekli özellikleri atanır.
            MeyveOzellikAta();

           //Meyve sıkma işlemi ile yeni değerler hesaplanır
            MeyveSık();

            //Butonlardan yapılan seçim doğruysa 
            //bu fonksiyon çağrılır

            DogruYanlis(true);
 
    

  }



        //NARENCİYE İÇİN
        private void button1_Click(object sender, EventArgs e)
        {
            if (SikacakBul() == true)
            {
               

                VitaminDeposuUygulama();
               
            }
            else { DogruYanlis(false);
            }

        }
        //Katı Meyve Sıkacağı için
        private void button2_Click(object sender, EventArgs e)
        {
            if (SikacakBul() == false)
            {
                VitaminDeposuUygulama();

            }
            else {  DogruYanlis(false);
            }



        }  
        void DogruYanlis(bool cevap)

        {             
            zamanlayici.Enabled = true;

       
            //eğer doğru sıkacak seçildiyse doğru
            //yanlış seçildiyse yanlış mesajı görünürlüğü açılır
            if (cevap == true) { 
                label19.Visible = true;
                FotografDegis();
            }
            else if(cevap==false)
            { label20.Visible = true;  FotografDegis();  }




        } 

          private void zamanlayici_Tick(object sender, EventArgs e)
        {

            label20.Visible = false;
            label19.Visible = false;
            zamanlayici.Stop();
        }


        //60 _saniyeden geriye saymak için timer
        private void timer1_Tick(object sender, EventArgs e)
        {


            // _saniyenin 60 olma durumunu kontrol ediyor
            if (_saniye == 60)
            {
                // süre bitince zamanlayıcıyı durur.
                // butonlara erişim kapatılır.

                timer1.Stop();
                button1.Enabled = false;
                button2.Enabled = false;


                //tekrar oynamak isteyen kullanıcı içi mesaj verilir.
                tekrarOynama=MessageBox.Show("TEKRAR OYNAMAK İSTER MİSİNİZ?", "OYUN BİTTİ..", MessageBoxButtons.YesNo);

                //Yes cevabı alınırsa geçmiş listboxı temizlenir.
                //basla metodu çağrılır.
                //_saniye sıfırlanır
                // toplam değerler sıfırlanır
                if (tekrarOynama == DialogResult.Yes)
                {
                    button1.Enabled = true;
                    button2.Enabled = true;
                    label10.Text= "A vitamini            :          0 mg        \n\n Sıvı: 0 mg                ";
                    label16.Text = "C vitamini            :          0 mg           \n\nPure: 0 mg           ";
                    gecmis.Items.Clear();
                    _saniye = 0;
                    _toplamVitaminA = 0;
                    _toplamVitaminC = 0;
                    _siviGram = 0;
                    _pureGram = 0;
                    Basla();
                }
                else { this.Close(); }
            }
            else
            {
                label17.Text = Convert.ToString(60 - _saniye);
                _saniye++;
            }
            
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

      

        void Basla()
        {
            //TİMER BAŞLAT
            timer1.Interval = 1000;
            timer1.Enabled = true;
            //geçmiş için liste hazırla
            gecmis.Items.Add("  Meyve Adi          |          Agirlik          |          A vit.          |          C vit. ");
            gecmis.Items.Add("__________________________________________________________");
           //ilk fotoğrafı yükle
            FotografDegis();
            MeyveOzellikAta();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Basla();
        }






    }



    /// <summary>
    /// ////////////////////////////////////SINIFLAR 
    /// İNTERFACE-ABSTRACT-KALITIM VS..
    /// </summary>
    /// 



    public interface IMeyveSikacagi
    {
        public double VerimBul();
    }
    public abstract class MeyveSikacagi
    {
        public abstract ArrayList Meyveler { get; set; }
    }

    //kalıtım ve interface aynı anda kullanılsın diye 
    public class Narenciye : MeyveSikacagi, IMeyveSikacagi
    {

        private ArrayList _meyveler = new ArrayList() {
        "Greyfurt","Portakal", "Mandalina"
        };

        public Narenciye()
        {
        }

        public override ArrayList Meyveler
        {
            get { return _meyveler; }
            set { _meyveler.Add(value); }
        }


        public double VerimBul()
        {
            Random random = new Random();


            double verim = random.Next(29, 71);



            return verim;
        }


    }
    public class KatiMeyveSikacagi : MeyveSikacagi, IMeyveSikacagi
    {
        
        private ArrayList _meyveler = new ArrayList() {
        "Armut","Cilek", "Elma"
        };
        public KatiMeyveSikacagi()
        {
        }
        public override ArrayList Meyveler
        {
            get { return _meyveler; }
            set { _meyveler.Add(value); }
        }
        public double VerimBul()
        {
            Random random = new Random();


            double verim = random.Next(79, 96);


            return verim;
        }
    }


    //Vitamin A değerleri ıu dan mg ye çevirlmiştir.
    //Vitamin A ve C değerleri 100 gr meyveye göre verilmiştir
    class Portakal : Meyve
    {
        private string _meyveAdi = "Portakal";
        private double _vitaminADegeri = 0.067500068;
        private double _vitaminCDegeri = 45;
        public override string MeyveAdi { get { return _meyveAdi; } }
        public override double VitaminADegeri { get { return _vitaminADegeri; } set { _vitaminADegeri = value; } }
        public override double VitaminCDegeri { get { return _vitaminCDegeri; } set { _vitaminCDegeri = value; } }


    }
    class Elma : Meyve
    {
        private string _meyveAdi = "Elma";
        private double _vitaminADegeri = 0.016200016;
        private double _vitaminCDegeri = 5;
        public override string MeyveAdi { get { return _meyveAdi; } }
        public override double VitaminADegeri { get { return _vitaminADegeri; } set { _vitaminADegeri = value; } }
        public override double VitaminCDegeri { get { return _vitaminCDegeri; } set { _vitaminCDegeri = value; } }

    }
    class Armut : Meyve
    {
        private string _meyveAdi = "Armut";
        private double _vitaminADegeri = 0.007500008;
        private double _vitaminCDegeri = 5;
        public override string MeyveAdi { get { return _meyveAdi; } }
        public override double VitaminADegeri { get { return _vitaminADegeri; } set { _vitaminADegeri = value; } }
        public override double VitaminCDegeri { get { return _vitaminCDegeri; } set { _vitaminCDegeri = value; } }
    }
    class Cilek : Meyve
    {
        private string _meyveAdi = "Cilek";
        private double _vitaminADegeri = 0.003600004;
        private double _vitaminCDegeri = 60;
        public override string MeyveAdi { get { return _meyveAdi; } }
        public override double VitaminADegeri { get { return _vitaminADegeri; } set { _vitaminADegeri = value; } }
        public override double VitaminCDegeri { get { return _vitaminCDegeri; } set { _vitaminCDegeri = value; } }
    }
        class Greyfurt : Meyve
    {

        private string _meyveAdi = "Greyfurt";
        private double _vitaminADegeri = 0.000900001;
        private double _vitaminCDegeri = 44;
        public override string MeyveAdi { get { return _meyveAdi; } }
        public override double VitaminADegeri { get { return _vitaminADegeri; } set { _vitaminADegeri = value; } }
        public override double VitaminCDegeri { get { return _vitaminCDegeri; } set { _vitaminCDegeri = value; } }
    }
    class Mandalina : Meyve
    {
        private string _meyveAdi = "Mandalina";
        private double _vitaminADegeri = 0.204300204;
        private double _vitaminCDegeri = 26;
        public override string MeyveAdi { get { return _meyveAdi; } }
        public override double VitaminADegeri { get { return _vitaminADegeri; } set { _vitaminADegeri = value; } }
        public override double VitaminCDegeri { get { return _vitaminCDegeri; } set { _vitaminCDegeri = value; } }
    }



    //Kalıtım için sınıf
    public class Meyve
    {
        private double _agirlik=100;
        private double _verim;
        private double _vitaminADegeri;
        private double _vitaminCDegeri;
        private string _meyveAdi;


        //Virtual metotların türetilmiş sınıflarda geçersiz kılınmasını sağlar
        public virtual string MeyveAdi { get { return _meyveAdi; } }
        public virtual double VitaminADegeri { get { return _vitaminADegeri; } set { _vitaminADegeri = value; } }
        public virtual double VitaminCDegeri { get { return _vitaminCDegeri; } set { _vitaminCDegeri = value; } }
        public double Agirlik { get { return _agirlik; } set { _agirlik = value; } }
        public double Verim { get { return _verim; } set { _verim = value; } }
    }

}