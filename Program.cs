using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratice_0609_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hi");
            Console.WriteLine("안녕하세요");
            //출력


            Console.Write("이름 입력");
            string name = Console.ReadLine();
            Console.Write("나이 입력");
            string age = Console.ReadLine();
            int ag = Convert.ToInt32(age);
            Console.WriteLine("나이: {0}", ag);

            String str = string.Format("이름:{0},나이:{1}", name, ag);
            Console.Write(str);
            //입력
        }
    }
}
