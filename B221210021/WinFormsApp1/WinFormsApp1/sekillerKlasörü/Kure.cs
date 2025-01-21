
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
    public class Kure : sekiller
    {
        private UcBoyutluNokta nokta;
        private int yaricap;

        public UcBoyutluNokta Nokta { get => nokta; set => nokta = value; }
        public int Yaricap { get => yaricap; set => yaricap = value; }



        public Kure()
        {
            Random random = new Random();
            Nokta = new UcBoyutluNokta();


            yaricap = random.Next(1, 200);
        }


        public Kure(UcBoyutluNokta nokta, int yaricap)
        {
            Nokta = nokta;

            Yaricap = yaricap;


        }

        public string yazdir()
        {
            return $" merkezi (x,y.z)=({Nokta.X},{Nokta.Y},{Nokta.Z} olan ve yaricapi {Yaricap} olan kure)";
        }


        public void KureCiz(Panel panel)
        {
            Graphics graphics = panel.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            graphics.DrawEllipse(pen, Nokta.X, Nokta.Y, yaricap, yaricap);


        }
    }
}
