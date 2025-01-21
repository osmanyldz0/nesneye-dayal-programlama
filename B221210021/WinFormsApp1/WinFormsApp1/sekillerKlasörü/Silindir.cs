
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WinFormsApp1.sekillerKlasörü
{
    public class Silindir : sekiller
    {
        private UcBoyutluNokta nokta;
        private int yaricap;
        private int yukseklik;
        public UcBoyutluNokta Nokta { get => nokta; set => nokta = value; }
        public int Yaricap { get => yaricap; set => yaricap = value; }

        public int Yukseklik { get => yukseklik; set => yukseklik = value; }

        public Silindir()
        {
            Random random = new Random();
            Nokta = new UcBoyutluNokta();


            yaricap = random.Next(1, 200);
            yukseklik = random.Next(1, 200);
        }


        public Silindir(UcBoyutluNokta nokta, int yaricap, int yukseklik)
        {
            Nokta = nokta;

            Yaricap = yaricap;

            Yukseklik = yukseklik;
        }

        public string yazdir()
        {
            return $" tabanin merkez noktası (x,y,z)=({nokta.X},{nokta.Y},{nokta.Z} )olan nokta,yaricapi {Yaricap} olan ve yuksekligi {yukseklik} olan nokta)";
        }

        public void SilindirCiz(Panel panel)
        {
            Graphics graphics = panel.CreateGraphics();

            Pen pen = new Pen(Color.DarkSlateGray);
            graphics.DrawEllipse(pen, Nokta.X, nokta.Y, yaricap, yaricap);
            graphics.DrawEllipse(pen, Nokta.X , Nokta.Y + yukseklik, yaricap, yaricap);


            graphics.DrawLine(pen, Nokta.X, Nokta.Y+yaricap/2, Nokta.X, Nokta.Y + yaricap / 2+yukseklik);
            graphics.DrawLine(pen, Nokta.X + Yaricap, Nokta.Y + yaricap / 2, Nokta.X + Yaricap , Nokta.Y+yaricap/2+yukseklik);
             

        }
    }









}

