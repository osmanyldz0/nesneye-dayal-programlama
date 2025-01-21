
/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**			         BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				          PROGRAMLAMAYA GİRİŞİ DERSİ
**	
**				ÖDEV NUMARASI…...:2
**				ÖĞRENCİ ADI...............:OSMAN YILDIZ
**				ÖĞRENCİ NUMARASI.:B221210021     
**				DERS GRUBU…………:1B
****************************************************************************/





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.sekillerKlasörü;

namespace WinFormsApp1.CarpismaDenetimi
{
    public static class CarpismaDenetimi
    {
        public static bool NoktaDikdortgen(Nokta nokta, Dikdortgen dikdortgen)
        {

            if (nokta.X >= dikdortgen.Nokta.X + dikdortgen.En &&
                nokta.X <= dikdortgen.Nokta.X + dikdortgen.En &&
                nokta.Y >= dikdortgen.Nokta.Y + dikdortgen.Boy &&
                nokta.Y <= dikdortgen.Nokta.Y + dikdortgen.Boy)
            {
                return true;
            }



            return false;
        }



        public static bool NoktaCember(Nokta nokta, Cember cember)
        {

            if ((nokta.X - cember.Nokta.X) * (nokta.X - cember.Nokta.X) + (nokta.Y - cember.Nokta.Y) * (nokta.Y - cember.Nokta.Y) <= (cember.Yaricap) * (cember.Yaricap))
            {
                return true;
            }



            return false;
        }



        public static bool DikdortgenDikdortgen(Dikdortgen dikdortgen0, Dikdortgen dikdortgen1)
        {

            Nokta merkez0 = new Nokta();
            Nokta merkez1 = new Nokta();

            merkez0.X = dikdortgen0.Nokta.X + dikdortgen0.En / 2;
            merkez0.Y = dikdortgen0.Nokta.Y + dikdortgen0.Boy / 2;
            merkez1.X = dikdortgen0.Nokta.X + dikdortgen0.En / 2;
            merkez1.Y = dikdortgen0.Nokta.Y + dikdortgen0.Boy / 2;





            if ((merkez0.X - merkez1.X) <= (dikdortgen0.Boy / 2 + dikdortgen1.Boy / 2) && (merkez0.Y - merkez1.Y <= (dikdortgen0.En / 2 + dikdortgen1.En / 2)))
            {
                return true;
            }



            return false;
        }



        public static bool dikdortgenCember(Dikdortgen dikdortgen, Cember cember)
        {



            double dx = cember.Nokta.X - Math.Max(dikdortgen.Nokta.X, Math.Min(dikdortgen.Nokta.X, dikdortgen.En));

            double dy = cember.Nokta.Y - Math.Max(dikdortgen.Nokta.Y, Math.Min(dikdortgen.Nokta.Y, dikdortgen.Boy));


            if ((dx * dx + dy * dy) <= cember.Yaricap * cember.Yaricap)
            {
                return true;
            }



            return false;





        }




        public static bool CemberCember(Cember cember0, Cember cember1)
        {


            double dx = cember0.Nokta.X - cember1.Nokta.X;



            double dy = cember0.Nokta.Y - cember1.Nokta.Y;


            if ((dx * dx + dy * dy) <= (cember0.Yaricap * cember1.Yaricap) * (cember0.Yaricap * cember1.Yaricap))
            {
                return true;
            }



            return false;





        }

        public static bool NoktaKure(UcBoyutluNokta nokta3D, Kure kure)
        {



            if ((nokta3D.X <= kure.Nokta.X + kure.Yaricap) &&
                (nokta3D.X <= kure.Nokta.X - kure.Yaricap) &&
               (nokta3D.Y <= kure.Nokta.Y + kure.Yaricap) &&
               (nokta3D.Y <= kure.Nokta.Y - kure.Yaricap) &&
               (nokta3D.Z <= kure.Nokta.Z + kure.Yaricap) &&
               (nokta3D.Z <= kure.Nokta.Z - kure.Yaricap))
            {
                return true;
            }



            return false;





        }



        public static bool NoktaDikdortgenPrizma(UcBoyutluNokta nokta3D, DikdortgenPrizma dikdortgenPrizma)
        {



            if ((nokta3D.X <= dikdortgenPrizma.Nokta.X + dikdortgenPrizma.En) &&
                (nokta3D.X <= dikdortgenPrizma.Nokta.X - dikdortgenPrizma.En) &&
               (nokta3D.Y <= dikdortgenPrizma.Nokta.Y + dikdortgenPrizma.Boy) &&
               (nokta3D.Y <= dikdortgenPrizma.Nokta.Y - dikdortgenPrizma.Boy) &&
               (nokta3D.Z <= dikdortgenPrizma.Nokta.Z + dikdortgenPrizma.Derinlik) &&
               (nokta3D.Z <= dikdortgenPrizma.Nokta.Z - dikdortgenPrizma.Derinlik))
            {
                return true;
            }

            return false;


        }



        public static bool NoktaSilindir(UcBoyutluNokta nokta3D, Silindir silindir)
        {



            if ((nokta3D.X <= silindir.Nokta.X + silindir.Yaricap) &&
                (nokta3D.X <= silindir.Nokta.X - silindir.Yaricap) &&
               (nokta3D.Y <= silindir.Nokta.Y + silindir.Yukseklik / 2) &&
               (nokta3D.Y <= silindir.Nokta.Y - silindir.Yukseklik / 2) &&
               (nokta3D.Z <= silindir.Nokta.Z + silindir.Yaricap) &&
               (nokta3D.Z <= silindir.Nokta.Z - silindir.Yaricap))
            {
                return true;
            }

            return false;


        }


        public static bool SilindirSilindir(Silindir silindir0, Silindir silindir1)
        {
            // Silindirlerin merkezlerinin x ve y uzaklık karelerini hesapla
            double uzaklikXY = (silindir0.Nokta.X - silindir1.Nokta.X) * (silindir0.Nokta.X - silindir1.Nokta.X)
                             + (silindir0.Nokta.Y - silindir1.Nokta.Y) * (silindir0.Nokta.Y - silindir1.Nokta.Y);

            // Silindirlerin merkezlerinin z uzaklık karelerini hesapla
            double uzaklikZ = (silindir0.Nokta.Z - silindir1.Nokta.Z) * (silindir0.Nokta.Z - silindir1.Nokta.Z);

            // Silindirlerin yarıçaplarının toplamının karesini hesapla
            double yaricapToplamKare = (silindir0.Yaricap + silindir1.Yaricap) * (silindir0.Yaricap + silindir1.Yaricap);

            // İki silindirin çarpışma kontrolü
            if (uzaklikXY <= yaricapToplamKare
                && (silindir0.Nokta.Z <= silindir1.Nokta.Z + silindir1.Yukseklik)
                && (silindir0.Nokta.Z + silindir0.Yukseklik >= silindir1.Nokta.Z)
                && uzaklikZ <= silindir0.Yukseklik * silindir0.Yukseklik + silindir1.Yukseklik * silindir1.Yukseklik)
            {
                return true; // Çarpışma var
            }

            return false; // Çarpışma yok
        }










        public static bool KureKure(Kure kure0, Kure kure1)
        {


            double dx = kure0.Nokta.X - kure1.Nokta.X;



            double dy = kure0.Nokta.Y - kure1.Nokta.Y;
            double dz = kure0.Nokta.Z - kure1.Nokta.Z;


            if ((dx * dx + dy * dy) <= (kure0.Yaricap * kure1.Yaricap) * (kure0.Yaricap * kure1.Yaricap))
            {
                return true;
            }



            return false;





        }












        public static bool KureSilindir(Kure kure, Silindir silindir)
        {


            double uzaklik = (double)Math.Sqrt(Math.Pow(kure.Nokta.X - silindir.Nokta.X, 2)) + (Math.Pow(kure.Nokta.Y - silindir.Nokta.Y, 2));

            if (uzaklik <= silindir.Yaricap + kure.Yaricap && kure.Nokta.Z >= silindir.Nokta.Z && kure.Nokta.Z <= silindir.Nokta.Z + silindir.Yukseklik)
            {
                return true;
            }



            return false;





        }




        public static bool KureYuzey(Kure kure, Yuzey yuzey)
        {


            double yakinlikX = Math.Max(yuzey.Nokta.X, Math.Min(yuzey.Nokta.X, yuzey.Nokta.X + yuzey.En));
            double yakinlikY = Math.Max(yuzey.Nokta.Y, Math.Min(yuzey.Nokta.Y, yuzey.Nokta.Y + yuzey.Boy));
            double yakinlikZ = Math.Max(yuzey.Nokta.Z, Math.Min(yuzey.Nokta.Z, yuzey.Nokta.Z + yuzey.Derinlik));
            double uzaklık = (double)Math.Sqrt(Math.Pow(kure.Nokta.X * yakinlikX, 2) + Math.Pow(kure.Nokta.Y * yakinlikY, 2) + Math.Pow(kure.Nokta.Z * yakinlikZ, 2));


            if (uzaklık <= kure.Yaricap)
            {
                return true;
            }



            return false;





        }






        public static bool DikdortgenPrizmaYuzey(Yuzey yuzey, DikdortgenPrizma dikdortgenPrizma)
        {


            double yakinlikX = Math.Max(yuzey.Nokta.X, Math.Min(dikdortgenPrizma.Nokta.X, yuzey.Nokta.X + yuzey.En));
            double yakinlikY = Math.Max(yuzey.Nokta.Y, Math.Min(dikdortgenPrizma.Nokta.Y, yuzey.Nokta.Y + yuzey.Boy));
            double yakinlikZ = Math.Max(yuzey.Nokta.Z, Math.Min(dikdortgenPrizma.Nokta.Z, yuzey.Nokta.Z + yuzey.Derinlik));
            double uzaklıkX = yakinlikX - dikdortgenPrizma.Nokta.X;
            double uzaklıkY = yakinlikY - dikdortgenPrizma.Nokta.Y;
            double uzaklıkZ = yakinlikZ - dikdortgenPrizma.Nokta.Z;

            double uzaklik = (double)Math.Sqrt(Math.Pow(uzaklıkX, 2) + Math.Pow(uzaklıkY, 2) + Math.Pow(uzaklıkZ, 2));






            if (uzaklıkZ <= dikdortgenPrizma.Boy || uzaklıkZ <= dikdortgenPrizma.En || uzaklik < dikdortgenPrizma.Derinlik)
            {
                return true;
            }

            return false;


        }





        public static bool SilindirYuzey(Silindir silindir, Yuzey yuzey)
        {


            double yakinlikX = Math.Max(yuzey.Nokta.X, Math.Min(silindir.Nokta.X, yuzey.Nokta.X + yuzey.En));
            double yakinlikY = Math.Max(yuzey.Nokta.Y, Math.Min(silindir.Nokta.Y, yuzey.Nokta.Y + yuzey.Boy));
            double yakinlikZ = Math.Max(yuzey.Nokta.Z, Math.Min(silindir.Nokta.Z, yuzey.Nokta.Z + yuzey.Derinlik));

            double uzaklık = (double)Math.Sqrt(Math.Pow(silindir.Nokta.X * yakinlikX, 2) + Math.Pow(silindir.Nokta.Y * yakinlikY, 2) + Math.Pow(silindir.Nokta.Z * yakinlikZ, 2));


            if (uzaklık <= silindir.Yaricap && yakinlikZ <= silindir.Nokta.Z + silindir.Yukseklik && yakinlikZ >= silindir.Nokta.Z)
            {
                return true;
            }



            return false;





        }




        public static bool Dikdörtgenprizmasiküre(DikdortgenPrizma dikdortgenPrizma, Kure kure)
        {
            double yakinlikX = Math.Max(dikdortgenPrizma.Nokta.X, Math.Min(kure.Nokta.X, dikdortgenPrizma.Nokta.X + dikdortgenPrizma.Boy));
            double yakinlikY = Math.Max(dikdortgenPrizma.Nokta.X, Math.Min(kure.Nokta.Y, dikdortgenPrizma.Nokta.Y + dikdortgenPrizma.En));
            double yakinlikZ = Math.Max(dikdortgenPrizma.Nokta.X, Math.Min(kure.Nokta.Z, dikdortgenPrizma.Nokta.Z + dikdortgenPrizma.Derinlik));

            double uzaklikX = kure.Nokta.X - yakinlikX;

            double uzaklikY = kure.Nokta.Y - yakinlikY;
            double uzaklikZ = kure.Nokta.Z - yakinlikZ;
            double uzaklik = (double)Math.Sqrt(Math.Pow(uzaklikX, 2) + Math.Pow(uzaklikY, 2) + Math.Pow(uzaklikZ, 2));
            if (uzaklik <= kure.Yaricap || (yakinlikX == dikdortgenPrizma.Nokta.X || yakinlikX == dikdortgenPrizma.Nokta.X + dikdortgenPrizma.Boy) && uzaklikY <= kure.Yaricap &&
            uzaklikZ <= kure.Yaricap || (yakinlikY == dikdortgenPrizma.Nokta.Y || yakinlikY == dikdortgenPrizma.Nokta.Y + dikdortgenPrizma.En) && uzaklikX <= kure.Yaricap && uzaklikZ <= kure.Yaricap &&
            (yakinlikZ == dikdortgenPrizma.Nokta.Z || yakinlikZ == dikdortgenPrizma.Nokta.Z + dikdortgenPrizma.Derinlik) && uzaklikX <= kure.Yaricap && uzaklikY <= kure.Yaricap)
            {
                return true;
            }
            return false;
        }









        public static bool DikdörtgenprizmaDikdörtgenprizma(DikdortgenPrizma prizma0, DikdortgenPrizma prizma1)
        {
            if (prizma0.Nokta.X <= prizma1.Nokta.X + prizma1.Boy
                && prizma0.Nokta.X + prizma0.Boy >= prizma1.Nokta.X
                && prizma0.Nokta.Y <= prizma1.Nokta.Y + prizma1.En
                && prizma0.Nokta.Y + prizma0.En >= prizma1.Nokta.Y
                && prizma0.Nokta.Z <= prizma1.Nokta.Z + prizma1.Derinlik
                && prizma0.Nokta.Z + prizma0.Derinlik >= prizma1.Nokta.Z)
            {
                return true;
            }
            return false;





        }

























    }









}



