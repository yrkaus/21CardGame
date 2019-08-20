using System;
using System.Collections.Generic;
using System.Text;

namespace _21Card
{
    class Program
    {
        public class CardClass
        {

            string mastBubna = "БУБНА";
            string mastPica = "ПИКА";
            string mastChyrva = "ЧИРВА";
            string mastKhersta = "ХРЕСТА";
            public int weight2 = 2;
            public int weight3 = 3;
            public int weight4 = 4;
            public int weight5 = 5;
            public int weight6 = 6;
            public int weight7 = 7;
            public int weight8 = 8;
            public int weight9 = 9;
            public int weight10 = 10;
            public string ace = "11";
            string korol = "4";
            string dama = "3";
            string valet = "2";
            public int acePoint = Convert.ToInt32(ace);
            public int korolPoint = Convert.ToInt32(korol);
            public int damalPoint = Convert.ToInt32(dama);
            public int valetPoint = Convert.ToInt32(valet);
           
        }
        
        public class ClassColoda : CardClass
        {
            public ClassColoda()
            {
                int[] arrayColoda = new[] { weight2, weight3, weight4, weight5, weight6, weight7, weight8, weight9, weight10, acePoint, korolPoint, damalPoint, valetPoint };
            }
        
            
        }
                              
        
        
    }
}
