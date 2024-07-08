using System;
using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;
using commmn;
namespace ConsoleApp5
{
    internal class Program
    {
 #region hadel exception
        static void Dosomeproticivecode()
        {
            int x, y, z;
            bool flag;
            do
            {
                Console.WriteLine("enter the number ");
                flag = int.TryParse(Console.ReadLine(), out x);
            }
            while (!flag);
            do
            {
                Console.WriteLine("enter the number ");
                flag = int.TryParse(Console.ReadLine(), out y);
            }
            while (!flag || y == 0);

            z = x / y;

            int[] arr = { 1, 2, 3 };
            if (arr.Length > 10)
            {
                arr[10] = 100;
            }

        }

        #endregion

        #region enum
        public enum days
        {
            saturday,
            sunday,
            monday,
            tuesday,
            wednesday,


        }
 public enum grades
        {A,B,C,F }  
        #endregion

        static void Main()
        {
            #region hadle 1 
            /*try
                {

                    Dosomeproticivecode();
                    throw new Exception();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                finally {


                    Console.WriteLine("finallyy");

                }
    */
            #endregion

            #region Enum
            days m = days.monday;  
            grades g = grades.A;

            if (g == grades.A)
            {
                Console.WriteLine("A");
            }
            else
            {
                Console.WriteLine(":(");
            }

            grades y = (grades)2;
            Console.WriteLine(y);   //c

            grades z = (grades) 10 ;    
            Console.WriteLine(z);// 10  



            Enum.TryParse(typeof(grades), Console.ReadLine(), out object x);
            Console.WriteLine($"YOUR grades {x}");
            



            #endregion







        }
    }
}




















