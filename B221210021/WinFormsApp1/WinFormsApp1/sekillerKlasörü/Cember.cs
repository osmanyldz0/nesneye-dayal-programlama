
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
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.sekillerKlasörü
{
    public class Cember:sekiller
    {
        private Nokta nokta;
        private int yaricap;

        public Nokta Nokta { get => nokta; set => nokta = value; }
        public int Yaricap { get => yaricap; set => yaricap = value; }

      

        public Cember()
        {
            Random random = new Random();
            Nokta = new Nokta();
 
             
            yaricap= random.Next(1, 200);
        }


        public Cember(Nokta nokta, int yaricap )
        {
            Nokta = nokta;
         
            Yaricap = yaricap;


        }

        public string yazdir()
        {
            return $"YARİCAPİ {Yaricap} olan ve merkezi (x,y)=({Nokta.X},{Nokta.Y} olan cember)";
        }


       public void CemberCiz(Panel panel)
        {
            Graphics graphics = panel.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            graphics.DrawEllipse(pen, Nokta.X, Nokta.Y, yaricap, yaricap);


        }




    }
}
