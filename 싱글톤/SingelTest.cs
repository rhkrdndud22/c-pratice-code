using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0611_pratice
{
    class SingelTest
    {
        private static SingelTest inst;
        private int data;
        
        
        
        public SingelTest(Random r)
        {
            data = r.Next(1, 100);
        }

        public int getData()
        {
            return data;
        }

        public static SingelTest getinstance(Random r)
        {
            if (inst == null)
            {
                inst = new SingelTest(r);
            }
            return inst;
        }


    }
}
