using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0610_pratice2.utill
{
    class Randdata
    {
        static string[] name = { "홍길동", "김길동", "박길동", "이길동", "최길동" };
        static int[] age = { 20, 30, 40, 50, 60 };
        static char[] gender = { '남', '여' };
        static string[] address = { "대구", "부산", "서울", "경주", "포항" };

        Random r = new Random();


        public string getName()
        {
            return name[r.Next(0, 5)];
        }

        public int getAge()
        {
            return age[r.Next(0, 5)];
        }

        public char getGender()
        {
            return gender[r.Next(0, 2)];
        }

        public string getAddress()
        {
            return address[r.Next(0, 5)];
        }
    }
}
