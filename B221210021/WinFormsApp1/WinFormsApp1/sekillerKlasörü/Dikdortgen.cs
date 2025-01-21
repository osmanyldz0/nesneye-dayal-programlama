
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
    public class Dikdortgen :sekiller
    {
        private Nokta nokta;
        private int en;
        private int boy;


        public Nokta Nokta { get => nokta; set => nokta = value; }
        public int Boy { get => boy; set => boy = value; }

        public int En { get => en; set => en = value; }

        public Dikdortgen()
        {
            Random random = new Random();
            Nokta = new Nokta();

            Boy = random.Next(1, 200);
            En = random.Next(1, 200);
        }


        public Dikdortgen(Nokta nokta, int boy, int en)
        {
            Nokta = nokta;

            En = en;
            Boy = boy;


        }

        public string yazdir()
        {

            return $"Başlangıç noktsı Nokta (x,y) = {Nokta.X}, {Nokta.Y}olan, eni {en} olan ve boyu {boy} olan dikdörtgen";
        
        
        
        
        
        }
        public void DikdortgenCiz(Panel panel)
        {
            Graphics graphics = panel.CreateGraphics();
            Pen pen = new Pen(Color.DarkSlateGray);
            graphics.DrawRectangle(pen, nokta.X, nokta.Y + 50, en, boy);
        }

       
    }
}
