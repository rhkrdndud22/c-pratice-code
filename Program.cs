using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratice_0610
{
    class Program
    {
        static void Main(string[] args)
        {
            //기본생성자
            Car car = new Car();
            car.printCarinfo();
            Console.WriteLine();
            
            Car car2 = new Car("현대","은색","G80","6천만");
            car2.setPrice("7천만원");
            car2.printCarinfo();
            Console.WriteLine("가격표:"+car2.getPrice());
            
            Car2 car3 = new Car2("쌍용","쥐색", "백만원","소울");
            car3.Price = "2천";
           
            Console.WriteLine();
            car3.printCarinfo();
            Console.WriteLine("가격표:" + car3.Price);
            Console.WriteLine(car3.ToString());

        }
    }
}
