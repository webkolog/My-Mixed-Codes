using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;


namespace HastaneKuyrugu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int SayacOda1, SayacOda2, SayacOda3, bekleOda1, bekleOda2, bekleOda3, SayacGold, NumlarNormal = 0, NumlarGold = 400, NumlarPlatinium = 700, NumSayac;
        Random rnd = new Random();
        AliList Liste = new AliList();

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Hastane - Numarator = Pasif";
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            NumaraAl(sender, NumlarNormal, 401);
        }

        private void NumaraAl(object sender, int Numara, int Kapasite)
        {
            Button btn = (Button)sender;
            Numara++;
            if (Numara < Kapasite)
            {
                Liste.Add(Numara);
                switch (btn.Text)
                {
                    case "Normal":
                        NumlarNormal++;
                        lblNormalTakip.Text = "Normal İçin Sıradaki No: " + NumlarNormal;
                        break;
                    case "Gold":
                        NumlarGold++;
                        lblGoldTakip.Text = "Gold İçin Sıradaki No: " + NumlarGold;
                        break;
                    default:
                        NumlarPlatinium++;
                        lblPlatiniumTakip.Text = "Platinium İçin Sıradaki No: " + NumlarPlatinium;
                        break;
                }

                //Gösterge Listesi Güncelleniyor
                GorunenListeyiGuncelle();
                if (lblOda1Numarator.Text == "" & lblOda2Numarator.Text == "" & lblOda3Numarator.Text == "")
                {
                    this.Text = "Hastane - Numarator = Aktif";
                    timer1.Start();
                }
            }
            else
            {
                MessageBox.Show(btn.Text + " için numara kalmadı!");
            }
        }

        private void GorunenListeyiGuncelle()
        {
            listBox1.Items.Clear();
            for (int i = 0; i < 5; i++)
            {
                if (Liste.Count == i)
                    break;
                listBox1.Items.Add(Liste.Dizi[i]);
            }
        }

        private void btnGold_Click(object sender, EventArgs e)
        {
            NumaraAl(sender, NumlarGold, 701);
        }

        private void btnPlatinium_Click(object sender, EventArgs e)
        {

            NumaraAl(sender, NumlarPlatinium, 1000);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            #region 1.Oda Islemleri
            if (lblOda1Numarator.Text == "")
            {
                if (Liste.Count > 0)
                {
                    lblOda1Numarator.Text = Liste.RemoveFirst().ToString();
                    bekleOda1 = rnd.Next(2, 10);
                    SayacOda1 = 0;
                    GorunenListeyiGuncelle();
                }
            }
            else
            {
                SayacOda1++;
            }
            #endregion

            #region 2.Oda Islemleri
            if (lblOda2Numarator.Text == "")
            {
                if (Liste.Count > 0)
                {
                    lblOda2Numarator.Text = Liste.RemoveFirst().ToString();
                    bekleOda2 = rnd.Next(2, 10);
                    SayacOda2 = 0;
                    GorunenListeyiGuncelle();
                }
            }
            else
            {
                SayacOda2++;
            }
            #endregion

            #region 3.Oda Islemleri
            if (lblOda3Numarator.Text == "")
            {
                if (Liste.Count > 0)
                {
                    lblOda3Numarator.Text = Liste.RemoveFirst().ToString();
                    bekleOda3 = rnd.Next(2, 10);
                    SayacOda3 = 0;
                    GorunenListeyiGuncelle();
                }
            }
            else
            {
                SayacOda3++;
            }
            #endregion

            #region OdaSureliDoluncaBosalt
            if (SayacOda1 == bekleOda1)
                lblOda1Numarator.Text = "";
            if (SayacOda2 == bekleOda2)
                lblOda2Numarator.Text = "";
            if (SayacOda3 == bekleOda3)
                lblOda3Numarator.Text = "";
            
            #endregion

            #region GoldIslemleri
            if (SayacGold == 5)
            {
                Liste.MoveAGold();
                SayacGold = 0;
                GorunenListeyiGuncelle();
            }
            else
            {
                SayacGold++;
            } 
            #endregion

            NumSayac++;

            #region TimerDurdurulmaIslemleri
            if (listBox1.Items.Count == 0 & lblOda1Numarator.Text == "" & lblOda2Numarator.Text == "" & lblOda3Numarator.Text == "")
            {
                timer1.Stop();
                NumSayac = 0;
                this.Text = "Hastane - Numarator = Pasif";
            } 
            #endregion

            lblNumaratorDak.Text = "Numarator Aktif Dakika: " + NumSayac.ToString();
        }


        class AliList //benim kendi Liste classım
        {
            public ArrayList Dizi = new ArrayList();
            private int sabitGoldSayisi = 0;

            public int Count //benim neyim eksik? :p
            {
                get
                {
                    return Dizi.Count;
                }
            }

            public int CountGold
            {
                get
                {
                    int i = 0;
                    foreach (int sayi in Dizi)
                    {
                        if (sayi >= 401 & sayi <= 700)
                        {
                            i++;
                        }
                    }
                    return i;
                }
            }

            public void Add(int no)
            {
                ArrayList tutucuDizi = new ArrayList();
                int Toplam = Dizi.Count;

                if (Toplam > 0)
                {

                    if (no >= 1 & no <= 400)
                    {
                        //normal ekle
                        bool siraNormallerdeMi = false, eklendiMi = false;
                        //siraNormallerdeMi: siramizi bulmak için (çünkü gold sayılar normalin önüne geçebilecek)
                        //eklendiMi: goldlardan önce eklenip eklenmediğine bakmak için (çünkü her zaman sonlarda goldlar olmayabilir)
                        foreach (int i in Dizi)
                        {
                            if (i >= 1 & i <= 400)
                                siraNormallerdeMi = true;
                            if (siraNormallerdeMi)
                            {
                                if (i >= 401 & i <= 700)
                                {
                                    //burada normal listekilerden sonra golda geçiş yaptığımızı anlıyor ve gold'an önce normali ekliyor. böylece normali doğru sıraya eklemiş oldum
                                    if (!eklendiMi) //tekrar tekrar eklemesin
                                    {
                                        tutucuDizi.Add(no);
                                        eklendiMi = true;
                                    }
                                }
                            }
                            //zaten eklenecek
                            tutucuDizi.Add(i);
                        }
                        if (!eklendiMi) //eklenmediyse: bunun anlamı sonlarda gold yok. o zaman sonuna direk ekliycez
                            tutucuDizi.Add(no);
                        Dizi = tutucuDizi;
                    }
                    else if (no >= 401 & no <= 700)
                    {
                        //gold ekle
                        Dizi.Add(no); //direk ekliyorum. çünkü zaten gold listenin en sonunda yer alıp 5 saniyede 1 giriş yapacaklar
                    }
                    else
                    {
                        //platinium ekle
                        bool eklendiMi = false;
                        foreach (int i in Dizi)
                        {
                            if (i >= 1 & i <= 700) //normal ve goldlar'dan ise
                            {
                                if (!eklendiMi) //tekrar tekrar eklemesin
                                {
                                    tutucuDizi.Add(no);
                                    eklendiMi = true;
                                }
                            }
                            tutucuDizi.Add(i);
                        }
                        Dizi = tutucuDizi;
                    }
                }
                else
                {
                    //eğer diziye daha önce hiç sayı eklenmemiş ise:
                    Dizi.Add(no);
                }
            }

            public void MoveAGold()
            {
                ArrayList tutucuDizi = new ArrayList();
                bool goldEklendiMi = false, goldBulduMu = false;
                int seciliGold = 0, sabitGoldSayac = 0;

                //gold yoksa hiç buralara giriş yapmayacak
                if (this.CountGold > 0)
                {

                    //taşınması için önce taşınacak gold'u bulmalı
                    foreach (int i in Dizi)
                    {
                        if (i >= 401 & i <= 700) //gold ise
                        {
                            sabitGoldSayac++;
                            if (sabitGoldSayac > sabitGoldSayisi) //büyük olmaması demek yeni bir sabit gold olmaması demek (sabit gold 5 sn. doldurmuş olan goldlar ve normallerin önüne geçiyorlar)
                            {
                                if (!goldBulduMu) //sadece gold bulmadı false ise seciliGold'a numara atayacak
                                {
                                    seciliGold = i; //seçili goldu buldu
                                    goldBulduMu = true; //böylecek diğer goldları görmekten kurtardım
                                    break;
                                }
                            }
                        }
                    }

                    //goldbuldu mu true ise çalışacak ve sabit gold sayisi +1 aratacak
                    if (goldBulduMu)
                    {
                        foreach (int i in Dizi)
                        {
                            if (!goldEklendiMi) //gold eklenmediyse bu işlemleri kontrol et
                            {
                                if (i >= 1 & i <= 400)
                                {
                                    tutucuDizi.Add(seciliGold); //seciliGold sabitlere kaydırıldı
                                    goldEklendiMi = true;
                                    sabitGoldSayisi++; //sabit gold sayısını artırdım
                                }
                            }
                            if (i != seciliGold) //seçiliGold hariç tümü eklensin
                            {
                                tutucuDizi.Add(i);
                            }
                        }
                        Dizi = tutucuDizi;
                    }
                }
            }

            public int RemoveFirst()
            {
                if (Dizi.Count > 0)
                {
                    int ilkDeger = (Int32)this.Dizi[0]; //cast ettim (objeden cast etmek unboxing idi B-) )
                    Dizi.RemoveAt(0); //ilk değeri sildik

                    if (ilkDeger >= 401 & ilkDeger <= 700) //bunun anlamı gold ise
                    {
                        if (sabitGoldSayisi > 0) //zaten sıfırsa niye azaltıyım?
                            sabitGoldSayisi--;
                    }

                    return ilkDeger; //ilk değeri verdik
                }
                else
                {
                    return 0;
                }
            }
        }

    }
}
