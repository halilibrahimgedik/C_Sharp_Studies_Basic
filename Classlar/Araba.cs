using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classlar
{

    public class Insan
    {
        int Kiilo;
        string Ad;
        double Boy;
        int Yas;
        public void Yazdır(int Kilo,string Ad,double Boy,int Yas)
        {
            this.Ad = Ad;
            this.Boy = Boy;
            this.Yas = Yas;
            this.Kiilo = Kilo;
            Console.WriteLine(this.Kiilo);
            Console.WriteLine(this.Ad);
            Console.WriteLine(this.Boy);
            Console.WriteLine(this.Yas);
        }
        //overloading
        public void Yazdır(int kilooo)
        {
            Kiilo= kilooo;
            Console.WriteLine(Kiilo);
        }

    }
    public class deneme
    {
        int Kilo;
        public int kilo
        {
            get { return Kilo; }
            set
            {
                if (value < 0)
                {
                    Kilo = 0;
                }
                else
                Kilo = value; 
                
            }
        }
    }

    class Kisiler
    {
        public void kisilistesi()
        {
      
          
            Console.WriteLine("Ad Giriniz: ");
            string ad=Console.ReadLine();
            Console.Write("Tekrar sayısını giriniz: ");

            int x=Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(ad);
            }
           
        }
    }


}
