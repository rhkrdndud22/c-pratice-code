using _0610_pratice2.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0610_pratice2.main
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] st = new Student[10];
            utill.Randdata Rdd = new utill.Randdata();
           
            
            

            for (int i=0; i<10; i++)
            {   Student su = new Student(Rdd.getName(),Rdd.getAge(),Rdd.getGender(),Rdd.getAddress());
                st[i] = su;
                st[i].showStudentInfo();
                Console.WriteLine();
            }

            st[9] =new Student("전우치", 24, '남', "조선 한양인근 두메산골");

            st[9].showStudentInfo();

           
            
        }
    }
}
