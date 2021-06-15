using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0611_pratice
{
    class sinqgleton
    {
        static void Main(string[] args)
        {
             Random r = new Random();


            for (int i=0; i<5; i++)
            {
                SingelTest st1 = new SingelTest(r);
                Console.WriteLine("인스턴스:"+st1.getData());


                Console.WriteLine("싱글 톤:" + SingelTest.getinstance(r).getData());
            }

           


        }


    }
}
