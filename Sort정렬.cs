using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratice_0612
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

         
            int[] arr = new int[50];
            for(int i=0; i<arr.Length; i++)
            {
                int a = r.Next(1, 50);
                arr[i] += a;
               

                
            }


            Sort(arr);
            

         

           


        }

        
        public static void Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {

                        int temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;


                        
                    }
                    
                }
                Console.WriteLine(arr[i]);


            }
        }
    }
}
