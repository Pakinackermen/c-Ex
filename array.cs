using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1
{
    class Class
    {

        //EX.11-4 หาค่าเฉลี่ย
        /*static void Main() {
            int[] num = new int[5];
            int sum = 0;
            float avg;

            for (int i = 0; i < 5; i++ ) {
                Console.Write("Enter Value {0} : ",i+1);
                num[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++ ) {

                sum = sum + num[i];
            }
                avg = sum/5;
                Console.Write("Summation : {0} \nAverage : {1}\n",sum,avg);
  
        }*/

        //--------รับค่าธรรมดา-----------------------------------------------------
        // EX.11-5
       /* static void Main() {
            char[] message = new char[5];
            int i = 0;

            Console.Write("Press 5 Characters : ");
            for (i = 0; i < 5; i++ ) {
                Console.Write("--> ");
                message[i] = char.Parse(Console.ReadLine());

            }
            Console.WriteLine("Your Message : ");
            for (i = 0; i < 5;i++ ) {
                Console.Write(message[i]);
            }
            Console.ReadKey();
        }*/

        //---------------------EX11-6--กำหนดค่าในIndexให้อาแรย์--------------------------------------------
       /* static void Main() {

            string[] frindName = {"ming","mint","min" };
            int i;
            Console.WriteLine("There are {0} of my friends:",frindName.Length);

            for (i = 0; i < frindName.Length;i++ ) {
                Console.WriteLine(frindName[i]);
            }
        }*/

        //-----------EX.11-7 foreach ---------------------
      /*  static void Main() {
            int[] num = new int[10];


            int zero = 0, pos = 0, neg = 0;

            for (int i = 0; i < 10;i++ ) {
                Console.Write("Enter value{0} : ",i+1);
                num[i] = int.Parse(Console.ReadLine());

            }

            foreach(int g in num){
                if (g == 0) zero++;
                else if(g < 0) neg++;
                else if(g > 0) pos++;
            }
            Console.WriteLine("Total zero {0}",zero);
            Console.WriteLine("Total pos {0}", pos);
            Console.WriteLine("Total n {0}", neg);
        }*/

       //----------EX.11-8 -----------------------รับค่าตัวอักษร 3 แบบ ----------------------
       
        /*static void Main()
        {
            char[] ch = new char[10];

            int type_a = 0, type_A = 0, none = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter Charater[{0}] : ", i + 1);
                ch[i] = char.Parse(Console.ReadLine());

            }

            foreach (int c in ch)
            {
                if (c >= 'a' && c <= 'z') type_a++;
                else if (c >= 'A' && c <= 'Z') type_A++;
                else none++;
            }
            Console.WriteLine("A-Z: {0}", type_A);
            Console.WriteLine("a-z: {0}", type_a);
            Console.WriteLine("none character: {0}", none);
        }*/
        static void Main()
        {
            int[] ch = new int[5];
            int[] num = new int[5];


            int type_a = 0, type_A = 0, none = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter Charater[{0}] : ", i + 1);
                ch[i] = int.Parse(Console.ReadLine());

            }

            foreach (int c in ch)
            {
                if( c >= 0 && c <= 50){
                    

                          Console.WriteLine("Grade A have {0} ", type_A++);
                         Console.WriteLine("score {0} ", c);

                    
                }

            }
            

            Console.WriteLine("/nGrade A have {0} and detail score :", type_A);
            //Console.WriteLine("a-z: {0}", type_a);
            //Console.WriteLine("none character: {0}", none);
            Console.ReadLine();
        }
    }
}
