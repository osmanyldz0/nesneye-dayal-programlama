
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

namespace WinFormsApp1.sekillerKlasörü
{
    public class Yuzey : sekiller
    {
        private UcBoyutluNokta nokta;
        private int en;
        private int boy;
        private int derinlik;


        public UcBoyutluNokta Nokta { get => nokta; set => nokta = value; }
        public int Boy { get => boy; set => boy = value; }

        public int En { get => en; set => en = value; }
        public int Derinlik { get => derinlik; set => derinlik = value; }
        public Yuzey()
        {
            Random random = new Random();
            Nokta = new UcBoyutluNokta();

            Boy = random.Next(1, 200); ;
            En = random.Next(1, 200);
            Derinlik = 1;
        }


        public Yuzey(UcBoyutluNokta nokta, int boy, int en)
        {
            Nokta = nokta;

            En = en;
            Boy = boy;


        }

      public string yazdir()
        {

            return $"Başlangıç noktsı Nokta (x,y,z) = ({Nokta.X}, {Nokta.Y}, {Nokta.Z}) olan, eni {en}, boyu {boy} olan yuzey";


        }



        public void PrizmaCiz(Panel panel)
        {
            Graphics graphics = panel.CreateGraphics();


            int a = 0;


            Pen pen = new Pen(Color.DarkSlateGray);
            graphics.DrawRectangle(pen, Nokta.X, nokta.Y, en, Derinlik);
            graphics.DrawRectangle(pen, Nokta.X + boy, Nokta.Y + boy, en, Derinlik);



            graphics.DrawLine(pen, Nokta.X, Nokta.Y, Nokta.X + Boy, Nokta.Y + Boy);
            graphics.DrawLine(pen, Nokta.X + en, Nokta.Y, Nokta.X + en + boy, Nokta.Y + boy);
            graphics.DrawLine(pen, Nokta.X, Nokta.Y + derinlik, Nokta.X + boy, Nokta.Y + boy + derinlik);
            graphics.DrawLine(pen, Nokta.X + en, Nokta.Y + derinlik, Nokta.X + en + boy, Nokta.Y + boy + derinlik);

        }
    }
    
}
