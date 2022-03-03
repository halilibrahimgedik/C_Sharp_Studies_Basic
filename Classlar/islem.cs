using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classlar
{
    internal class islem
    {

        public int _Topla (int s1,int s2)
        {
         
            int s3= s1 + s2;
            Console.WriteLine("sonuc: "+ s3);
            return s3;
        }
        public int _Cıkart(int s1, int s2)
        {
            int s3 = s1 - s2;
            Console.WriteLine("sonuc: " + s3);
            return s3;
        }
        public int _Böl(int s1, int s2)
        {
            int s3 = s1 / s2;
            Console.WriteLine("sonuc: " + s3);
            return s3;
        }
        public int _Carp(int s1, int s2)
        {
            int s3 = s1 * s2;
            Console.WriteLine("sonuc: " + s3);
            return s3;
        }
    }
}
