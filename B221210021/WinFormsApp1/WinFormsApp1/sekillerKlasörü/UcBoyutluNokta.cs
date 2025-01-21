
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
   public class UcBoyutluNokta:sekiller
    {


        private int x;
        private int y;
        private int z;
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public int Z { get => z; set => z = value; }

        public UcBoyutluNokta()
        {
            Random random = new Random();

            x = random.Next(0, 200);

            y = random.Next(0, 400);
            z = random.Next(0, 200);
        }
        public UcBoyutluNokta(int x, int y,int z)
        {

            X = x;
            Y = y;
            Z = z;



        }

        public string yazdir()
        {
            return $" kordinat duzleminde(x.y)=({x},{y},{z} olan nokta)";
        }


        public void NoktaCiz(Panel panel)
        {

            Graphics graphics = panel.CreateGraphics();


            Pen pen = new Pen(Color.Black);

            graphics.DrawEllipse(pen, X, Y, 1, 1);
        }

    }
}
