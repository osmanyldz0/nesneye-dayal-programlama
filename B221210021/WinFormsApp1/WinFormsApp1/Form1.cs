


/****************************************************************************
**					SAKARYA ÜNÝVERSÝTESÝ
**			         BÝLGÝSAYAR VE BÝLÝÞÝM BÝLÝMLERÝ FAKÜLTESÝ
**				    BÝLGÝSAYAR MÜHENDÝSLÝÐÝ BÖLÜMÜ
**				          PROGRAMLAMAYA GÝRÝÞÝ DERSÝ
**	
**				ÖDEV NUMARASI…...:2
**				ÖÐRENCÝ ADI...............:OSMAN YILDIZ
**				ÖÐRENCÝ NUMARASI.:B221210021    
**				DERS GRUBU…………:1B
****************************************************************************/





























using WinFormsApp1.CarpismaDenetimi;
using WinFormsApp1.sekillerKlasörü;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            secenek = 10;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            sonuc.Clear();
            Nokta nokta = new Nokta();
            UcBoyutluNokta nokta3d = new UcBoyutluNokta();
            Dikdortgen dikdortgen0 = new Dikdortgen();
            Dikdortgen dikdortgen1 = new Dikdortgen();

            Cember cember0 = new Cember();
            Cember cember1 = new Cember();

            DikdortgenPrizma prizma0 = new DikdortgenPrizma();
            DikdortgenPrizma prizma1 = new DikdortgenPrizma();
            DikdortgenPrizma prizma2 = new DikdortgenPrizma();
            Kure kure0 = new Kure();
            Kure kure1 = new Kure();

            Silindir silindir0 = new Silindir();
            Silindir silindir1 = new Silindir();

            Yuzey yuzey = new Yuzey();



            if (secenek == 1)

            {
                panel1.Invalidate();
                panel1.Refresh();

                if (CarpismaDenetimi.CarpismaDenetimi.NoktaDikdortgen(nokta, dikdortgen0))
                {
                    sonuc.AppendText($"dikdortgen=({dikdortgen0.yazdir()}\n + nokta=({nokta.yazdir()}\n cisimler carpisiyor)");

                }

                else
                {
                    sonuc.AppendText($"dikdortgen=({dikdortgen0.yazdir()}\n + nokta=({nokta.yazdir()}\n cisimler carpismiyor)");
                }
                nokta.NoktaCiz(panel1);
                dikdortgen0.DikdortgenCiz(panel1);

                if (checkBox1.Checked == false)
                {




                    secenek = 0;
                    panel1.Refresh();
                    sonuc.Clear();


                }

            }



            if (secenek == 2)

            {
                panel1.Invalidate();
                panel1.Refresh();

                if (CarpismaDenetimi.CarpismaDenetimi.NoktaCember(nokta, cember0))
                {
                    sonuc.AppendText($"cember=({cember0.yazdir()}\n + nokta=({nokta.yazdir()}\n cisimler carpisiyor)");

                }

                else
                {
                    sonuc.AppendText($"cember=({cember0.yazdir()}\n + nokta=({nokta.yazdir()}\n cisimler carpismiyor)");
                }
                nokta.NoktaCiz(panel1);
                cember0.CemberCiz(panel1);

                if (checkBox2.Checked == false)
                {




                    secenek = 0;
                    panel1.Refresh();
                    sonuc.Clear();


                }


            }


            if (secenek == 3)

            {
                panel1.Invalidate();
                panel1.Refresh();

                if (CarpismaDenetimi.CarpismaDenetimi.DikdortgenDikdortgen(dikdortgen0, dikdortgen1))
                {
                    sonuc.AppendText($"dikdortgen=({dikdortgen0.yazdir()}\n + nokta=({dikdortgen1.yazdir()}\n cisimler carpisiyor)");

                }

                else
                {
                    sonuc.AppendText($"dikdortgen=({dikdortgen0.yazdir()}\n + nokta=({dikdortgen1.yazdir()}\n cisimler carpismiyor)");
                }
                dikdortgen0.DikdortgenCiz(panel1);
                dikdortgen1.DikdortgenCiz(panel1);

                if (checkBox3.Checked == false)
                {




                    secenek = 0;
                    panel1.Refresh();
                    sonuc.Clear();


                }

            }


            if (secenek == 4)

            {
                panel1.Invalidate();
                panel1.Refresh();

                if (CarpismaDenetimi.CarpismaDenetimi.dikdortgenCember(dikdortgen0, cember0))
                {
                    sonuc.AppendText($"dikdortgen=({dikdortgen0.yazdir()}\n + cember=({cember0.yazdir()}\n cisimler carpisiyor)");

                }

                else
                {
                    sonuc.AppendText($"dikdortgen=({dikdortgen0.yazdir()}\n + cember=({cember0.yazdir()}\n cisimler carpismiyor)");
                }
                dikdortgen0.DikdortgenCiz(panel1);
                cember0.CemberCiz(panel1);

                if (checkBox4.Checked == false)
                {




                    secenek = 0;
                    panel1.Refresh();
                    sonuc.Clear();


                }


            }


            if (secenek == 5)

            {
                panel1.Invalidate();
                panel1.Refresh();

                if (CarpismaDenetimi.CarpismaDenetimi.CemberCember(cember0, cember1))
                {
                    sonuc.AppendText($"cember=({cember0.yazdir()}\n + cember=({cember1.yazdir()}\n cisimler carpisiyor)");

                }

                else
                {
                    sonuc.AppendText($"cember=({cember0.yazdir()}\n + cember=({cember1.yazdir()}\n cisimler carpismiyor)");
                }
                cember0.CemberCiz(panel1);
                cember1.CemberCiz(panel1);
                if (checkBox5.Checked == false)
                {




                    secenek = 0;
                    panel1.Refresh();

                    sonuc.Clear();

                }


            }


            if (secenek == 6)

            {
                panel1.Invalidate();
                panel1.Refresh();

                if (CarpismaDenetimi.CarpismaDenetimi.NoktaKure(nokta3d, kure0))
                {
                    sonuc.AppendText($"nokta=({nokta3d.yazdir()}\n + kure=({kure0.yazdir()}\n cisimler carpisiyor)");

                }

                else
                {
                    sonuc.AppendText($"nokta=({nokta3d.yazdir()}\n + kure=({kure0.yazdir()}\n cisimler carpismiyor)");
                }
                nokta3d.NoktaCiz(panel1);
                kure0.KureCiz(panel1);

                if (checkBox6.Checked == false)
                {




                    secenek = 0;
                    panel1.Refresh();
                    sonuc.Clear();


                }


            }


            if (secenek == 7)

            {
                panel1.Invalidate();
                panel1.Refresh();

                if (CarpismaDenetimi.CarpismaDenetimi.NoktaDikdortgenPrizma(nokta3d, prizma0))
                {
                    sonuc.AppendText($"dikdortgen prizma=({prizma0.yazdir()}\n + nokta=({nokta3d.yazdir()}\n cisimler carpisiyor)");


                }

                else
                {
                    sonuc.AppendText($"dikdortgen prizma=({prizma0.yazdir()}\n + nokta=({nokta3d.yazdir()}\n cisimler carpismiyor)");
                }
                nokta3d.NoktaCiz(panel1);
                prizma0.PrizmaCiz(panel1);

                if (checkBox7.Checked == false)
                {




                    secenek = 0;
                    panel1.Refresh();

                    sonuc.Clear();

                }


            }


            if (secenek == 8)

            {
                panel1.Invalidate();
                panel1.Refresh();

                if (CarpismaDenetimi.CarpismaDenetimi.NoktaSilindir(nokta3d, silindir0))
                {
                    sonuc.AppendText($"silindir=({silindir0.yazdir()}\n + nokta=({nokta3d.yazdir()}\n cisimler carpisiyor)");

                }

                else
                {
                    sonuc.AppendText($"silindir=({silindir0.yazdir()}\n + nokta=({nokta3d.yazdir()}\n cisimler carpismiyor)");
                }
                nokta3d.NoktaCiz(panel1);
                silindir0.SilindirCiz(panel1);

                if (checkBox8.Checked == false)
                {




                    secenek = 0;
                    panel1.Refresh();

                    sonuc.Clear();

                }

            }


            if (secenek == 9)

            {
                panel1.Invalidate();
                panel1.Refresh();

                if (CarpismaDenetimi.CarpismaDenetimi.SilindirSilindir(silindir0, silindir1))
                {
                    sonuc.AppendText($"silindir=({silindir0.yazdir()}\n + silindir=({silindir1.yazdir()}\n cisimler carpisiyor)");

                }

                else
                {
                    sonuc.AppendText($"silindir=({silindir0.yazdir()}\n + silindir=({silindir1.yazdir()}\n cisimler carpismiyor)");
                }
               

                silindir0.SilindirCiz(panel1);
                silindir1.SilindirCiz(panel1);

                if (checkBox16.Checked == false)
                {




                    secenek = 0;
                    panel1.Refresh();

                    sonuc.Clear();

                }


            }


            if (secenek == 10)

            {
                panel1.Invalidate();
                panel1.Refresh();

                if (CarpismaDenetimi.CarpismaDenetimi.KureKure(kure0, kure1))
                {
                    sonuc.AppendText($"kure=({kure0.yazdir()}\n + kure=({kure1.yazdir()}\n cisimler carpisiyor)");

                }

                else
                {
                    sonuc.AppendText($"kure=({kure0.yazdir()}\n + kure=({kure1.yazdir()}\n cisimler carpismiyor)");
                }

                kure0.KureCiz(panel1);
                kure1.KureCiz(panel1);

                if (checkBox15.Checked == false)
                {




                    secenek = 0;
                    panel1.Refresh();

                    sonuc.Clear();

                }

            }


            if (secenek == 11)

            {
                panel1.Invalidate();
                panel1.Refresh();

                if (CarpismaDenetimi.CarpismaDenetimi.KureSilindir(kure0, silindir0))
                {
                    sonuc.AppendText($"kure=({kure0.yazdir()}\n + silindir=({silindir0.yazdir()}\n cisimler carpisiyor)");

                }

                else
                {
                    sonuc.AppendText($"kure=({kure0.yazdir()}\n + silindir=({silindir0.yazdir()}\n cisimler carpismiyor)");
                }
                kure0.KureCiz(panel1);
                silindir0.SilindirCiz(panel1);
                if (checkBox14.Checked == false)
                {




                    secenek = 0;
                    panel1.Refresh();

                    sonuc.Clear();

                }


            }


            if (secenek == 12)

            {
                panel1.Invalidate();
                panel1.Refresh();

                if (CarpismaDenetimi.CarpismaDenetimi.KureYuzey(kure0, yuzey))
                {
                    sonuc.AppendText($"kure=({kure0.yazdir()}\n + yuzey=({yuzey.yazdir()}\n cisimler carpisiyor)");

                }

                else
                {
                    sonuc.AppendText($"kure=({kure0.yazdir()}\n + yuzey=({yuzey.yazdir()}\n cisimler carpismiyor)");
                }
                kure0.KureCiz(panel1);

                yuzey.PrizmaCiz(panel1);

                if (checkBox13.Checked == false)
                {




                    secenek = 0;
                    panel1.Refresh();

                    sonuc.Clear();

                }
            }


            if (secenek == 13)

            {
                panel1.Invalidate();
                panel1.Refresh();

                if (CarpismaDenetimi.CarpismaDenetimi.DikdortgenPrizmaYuzey(yuzey, prizma0))
                {
                    sonuc.AppendText($"yuzey=({yuzey.yazdir()}\n + dikdortgen prizma=({prizma0.yazdir()}\n cisimler carpisiyor)");

                }

                else
                {
                    sonuc.AppendText($"yuzey=({yuzey.yazdir()}\n + dikdortgen prizma=({prizma0.yazdir()}\n cisimler carpismiyor)");
                }
                nokta.NoktaCiz(panel1);

                yuzey.PrizmaCiz(panel1);
                prizma0.PrizmaCiz(panel1);
                if (checkBox12.Checked == false)
                {




                    secenek = 0;
                    panel1.Refresh();
                    sonuc.Clear();


                }

            }


            if (secenek == 14)

            {
                panel1.Invalidate();
                panel1.Refresh();

                if (CarpismaDenetimi.CarpismaDenetimi.SilindirYuzey(silindir0, yuzey))
                {
                    sonuc.AppendText($"silindir=({silindir0.yazdir()}\n + yuzey=({yuzey.yazdir()}\n cisimler carpisiyor)");

                }

                else
                {
                    sonuc.AppendText($"silindir=({silindir0.yazdir()}\n + yuzey=({yuzey.yazdir()}\n cisimler carpismiyor)");
                }
                yuzey.PrizmaCiz(panel1);
                silindir0.SilindirCiz(panel1);
                if (checkBox11.Checked == false)
                {




                    secenek = 0;
                    if (checkBox11.Checked == false)
                    {




                        secenek = 0;
                        panel1.Refresh();
                        sonuc.Clear();


                    }



                }
            }


            if (secenek == 15)

            {
                panel1.Invalidate();
                panel1.Refresh();

                if (CarpismaDenetimi.CarpismaDenetimi.Dikdörtgenprizmasiküre(prizma0, kure0))
                {
                    sonuc.AppendText($"dikdortgen prizma=({prizma0.yazdir()}\n + kure=({kure0.yazdir()}\n cisimler carpisiyor)");

                }

                else
                {
                    sonuc.AppendText($"dikdortgen prizma=({prizma0.yazdir()}\n + kure=({kure0.yazdir()}\n cisimler carpismiyor)");
                }
                kure0.KureCiz(panel1);
                prizma0.PrizmaCiz(panel1);

                if (checkBox10.Checked == false)
                {




                    secenek = 0;
                    panel1.Refresh();

                    sonuc.Clear();

                }


            }


            if (secenek == 16)

            {
                panel1.Invalidate();
                panel1.Refresh();

                if (CarpismaDenetimi.CarpismaDenetimi.DikdörtgenprizmaDikdörtgenprizma(prizma0, prizma1))
                {
                    sonuc.AppendText($"dikdortgen prizma=({prizma0.yazdir()}\n + dikdortgen prizma=({prizma1.yazdir()}\n cisimler carpisiyor)");

                }

                else
                {
                    sonuc.AppendText($"dikdortgen prizma=({prizma0.yazdir()}\n + dikdortgen prizma=({prizma1.yazdir()}\n cisimler carpismiyor)");
                }
                prizma0.PrizmaCiz(panel1);
                prizma1.PrizmaCiz(panel1);
                if (checkBox9.Checked == false)
                {




                    secenek = 0;
                    panel1.Refresh();
                    sonuc.Clear();


                }


            }





        }



        int secenek = 0;

        private void sonuc_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            secenek = 2;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            secenek = 3;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            secenek = 4;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            secenek = 5;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            secenek = 6;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            secenek = 7;
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            secenek = 8;
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            secenek = 9;
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            secenek = 11;
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            secenek = 12;
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            secenek = 13;
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            secenek = 14;
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            secenek = 15;
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            secenek = 16;
        }


        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            secenek = 1;

        }
    }
}