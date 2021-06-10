using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0610_pratice2.model
{
    class Student
    {
        public const string SCHOOL = "경북산업학교";
        private string name;
        private int age;
        private char gender;
        private string address;

         utill.Randdata Rdd = new utill.Randdata();
        public Student(string name, int age, char gender, string address)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.address = address;
            
        }

      
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public char Gender { get => gender; set => gender = value; }
        public string Address { get => address; set => address = value; }

        public void showStudentInfo()
        {
            Console.WriteLine(SCHOOL);
            Console.WriteLine("이름" + name);
            Console.WriteLine("나이" + age);
            Console.WriteLine("성별" + gender);
            Console.WriteLine("주소" + address);

        }

        public override string ToString()
        {
            string str = "이름" + name + "\n";
            str += "나이" + age + "\n";
            str += "성별" +gender + "\n";
            str += "주소" + address + "\n";
            return str;
        }
    }
}
