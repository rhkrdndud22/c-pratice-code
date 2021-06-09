using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratice_0609_
{
    class Class1
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("새로운 메인");

             //1차원 배열 초기화
             int[] arr = { 10, 20, 30, 40, 50 };
             for (int i = 0; i < arr.Length; i++)
             {

                 string str =
                     string.Format("1차원배열[{0}],{1}", i, arr[i]);
                 Console.WriteLine(str);
             }
             //1차원 배열 초기화
             char[] strr = new char[4]
             {
                     '박','김','이','최'
             };
             for (int i = 0; i < arr.Length; i++)
             {

                 string str1 =
                     string.Format("1차원배열[{0}],{1}", i, strr[i]);
                 Console.WriteLine(str1);
             }*/

            //2차원 배열 초기화
            /* int[,] twocha =
             {
               {1,2,3 },{4,5,6}
              };

             for (int i = 0; i < 2; i++)
             {
                 for (int j = 0; j < 3; j++)
                 {
                     Console.WriteLine(twocha[i, j] + " ");
                 }
                 Console.WriteLine();
             }

             string[][] arrstr = new string[2][];
             arrstr[0] = new string[]
             {
                   "홍길동","김길동","최길동"
             };

             arrstr[1] = new string[]
             {
                   "츰길동","참길동","당길동","홍홍이"
             };

             for (int i = 0; i < arrstr.Length; i++)
             {
                 for (int j = 0; j < arrstr[i].Length; j++)
                 {
                     Console.WriteLine(arrstr[i][j]);
                 }
                 Console.WriteLine();
             }

             //2차원 배열 초기화 3
             int[][] arrint1 = new int[3][];



             for (int i = 0; i < arrint1.Length; i++)
             {
                 arrint1[i] = new int[i + 1];
                 for (int j = 0; j < arrint1[i].Length; j++)
                 {
                     arrint1[i][j] = 10 + j;
                     Console.Write(arrint1[i][j] + " ");
                 }
                 Console.WriteLine();
             }

             //foreach 1번째
             int[] arrEach = { 10, 20, 30, 40, 50 };
             foreach(var i in arrEach)
             {
                 Console.WriteLine(i + " ");
             }

             string[,] arrEach2 =
             {
                 {"홍길동","김길동" },{"전우치","박우치"}
             };

             foreach(string i in arrEach2)
             {
                 Console.WriteLine(i);
             }
             Console.WriteLine();
             foreach (string s in arrEach2)
             {
                 Console.WriteLine(s);
             }*/

            //컬렉션 클래스=자료구조
            //List
            /*    List<string> list = new List<string>();
                list.Add("홍길동");
                list.Add("김길동");
                list.Add("박길동");

                for(int i=0; i<list.Count; i++)
                {
                    Console.Write(list[i] + " ");
                }
                Console.WriteLine();
                list.RemoveAt(0);//index 0번째 데이터 삭제
                list.Remove("박길동");
                list.Insert(0, "전우치");//index 0번째 "전우치" 추가
                for (int i = 0; i < list.Count; i++)
                {
                    Console.Write(list[i] + " ");
                }
                Console.WriteLine();*/

            //hash table (key,value)
            /*  
              Hashtable hTable = new Hashtable();
              hTable.Add(1, "홍길동");
              hTable.Add(2, "항길동");
              hTable.Add(3, "박길동");

              if(hTable.Contains(1))
              {
                  Console.WriteLine(hTable[1]);
              }*/

            //딕셔너리
            /*  Dictionary<string, string> dic = new Dictionary<string, string>();

              dic.Add("key1", "길동홍");
              dic.Add("key2", "길동항");
              dic.Add("key3", "길동박");
              Console.WriteLine("값:{0}", dic["key2"]);

              foreach(KeyValuePair<string,string>item in dic)
              {
                  Console.WriteLine("key:{0}-value:{1}", item.Key, item.Value);
              }

              foreach(string key in dic.Keys)
              {
                  Console.WriteLine(key);
              }
              foreach (string vay in dic.Values)
              {
                  Console.WriteLine(vay);
              }*/


            //배열 연습 문제 1번

            /* int[] array = { 20, 34, 22, 14, 36, 23, 67 };
             int sum=0;
             for (int i=0; i<array.Length; i++)
             {
                  sum += array[i];

             }
             Console.WriteLine("총합:"+sum);
             Console.WriteLine("평균:" + sum/7);*/

            //배열 연습 문제 2번

            /* int[] array1 = new int[101];

             for (int i = 1; i < array1.Length; i++)
             {
                 array1[i] = i;
                 if (array1[i] % 5 == 0)
                 {
                     Console.WriteLine(array1[i]);
                     if (array1[i] == 90)
                     {
                         break;
                     }
                 }
             }*/
            //배열 연습 문제 3번

            /* int[] num = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
             int[] num1 = new int[10];

             for (int i=9; i>=0; i--)
             {

                 for(int j=0; j<=0; j++)
                 {
                     num1[j] = num[i];
                     Console.WriteLine(num1[j]);
                 }

             }*/

            //배열 연습 문제 4번

           /* int[][] numarr = { new int[] { 1, 2 }, new int[] { 2, 4, 6 }, new int[] { 3, 6 }, new int[] { 4, 8, 10, 12 }, new int[] { 10 } };

            for (int i = 0; i < numarr.Length; i++)
            {
                for (int j = 0; j < numarr[i].Length; j++)
                {
                    Console.Write("arr[{0}][{1}]=", i, j); Console.Write(numarr[i][j] + " ");
                }
                Console.WriteLine(" ");
            }*/

            //배열 연습 문제 5번

            /* int[][] num0 = { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } };
             int[][] num10 = { new int[] { 10, 20, 30 }, new int[] { 40, 50, 60 }, new int[] { 70, 80, 90 } };
             int[,] numplus = new int[3,3];
             for(int i=0; i<3; i++)
             {
                 for (int j = 0; j < 3; j++)
                 {
                     numplus[i,j] = num0[i][j] + num10[i][j];
                     Console.Write(numplus[i, j]+" ");
                 }
                 Console.WriteLine(" ");
             }*/

            //배열 연습 6번

            /*int[,] gugu = new int[10, 10];

            for (int i = 2; i < 10; i++)
            {
                for(int j=1; j<10; j++)
                {
                    gugu[i,j]= i * j;
                    Console.Write("{0}x{1}=", i, j);Console.Write( gugu[i, j]+" ");
                }
                Console.WriteLine(" ");
            }*/


           /* while (true)
            { 

                Console.WriteLine("---------------------");
                Console.WriteLine("파일 제어 프로그램 v1.1");
                Console.WriteLine("---------------------");
                Console.WriteLine("1.이름 생성하여 파일에 저장하기");
                Console.WriteLine("2.파일에서 읽어오기");
                Console.WriteLine("3.종료");
                string[] first = new string[]{ "김", "박", "이", "최", "강" };
                string[] mid= new string[] { "바", "사", "아", "자", "차" };
                string[] last = new string[] { "가", "나", "다", "라", "마" };
                string[] name = new string[50];
                 
                Random r = new Random();
                String inpu = Console.ReadLine();
                int input = Convert.ToInt32(inpu);
                if (input==1)
                {
                    StreamWriter writer_;
                    String strFilePath = "C:\\test.txt";
                    writer_ = File.CreateText(strFilePath);
                    for (int i = 0; i < name.Length; i++)
                    {
                        int a = r.Next(first.Length);
                        int b = r.Next(mid.Length);
                        int c = r.Next(last.Length);
                        name[i] = first[a] + mid[b] + last[c];
                        Console.WriteLine(name[i]);
                      

                        
                        writer_.WriteLine(name[i]);
                        

                    }
                    writer_.Close();

                }
                if(input == 2)
                {
                    string path = @"C:\\test.txt";
                    string textValue = System.IO.File.ReadAllText(path);
                    Console.WriteLine(textValue);
                }
                if (input == 3)
                {
                    break;
                }
            }
            


        }
    }
}
