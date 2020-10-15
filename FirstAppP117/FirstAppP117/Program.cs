using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppP117
{
    class Program
    {
        static void Main(string[] args)
        {
            #region DataTypes,Variable
            //Variable - Pascal,Camel,snake,kebab
            //int age = 25;
            //age = 100;
            //age = 256;
            //string word = "Hello World";
            //char letter = '@';
            //int number = 8;
            //bool isMaried = true;

            //var -compile zamani ilk menimsedilen deyere gore tipi teyin edir
            //var x = "Kamran";
            //x = "Test";
            //var y = 10;
            //y = 1000;

            //dynimic - run time zamani menimsedilen deyere gore tipi teyin edir
            //dynamic x = 10;
            //x = "Test";
            //x = true;
            //Console.WriteLine(x);
            //float pi = 3.14F;
            //double t = 2.12;
            //decimal x = 1.111M;
            #endregion

            #region Condition
            //int age = 18;
            //string result = age > 18 ? "Xosh gelmisiz" : "Papani chagir";
            //Console.WriteLine(result);

            //if (age > 18)
            //{
            //    Console.WriteLine("Xosh gelmisiz");
            //}
            //else if(age == 18) 
            //{
            //    Console.WriteLine("Az qalib");
            //}
            //else
            //{
            //    Console.WriteLine("Papani chagir");
            //}
            #endregion

            #region Switch - case
            //int number = 2;
            //string word = "Kamran istedi";
            //switch (number)
            //{
            //    case 2:
            //        Console.WriteLine($"Eded: {number} - {word}");
            //        break;
            //    case 1:
            //        Console.WriteLine($"Eded: {number}");
            //        break;
            //    default:
            //        Console.WriteLine("Hech biri deyil");
            //        break;
            //}
            #endregion

            #region Loops
            //int[] numbers = { 10,20,30};
            //string[] students = new string[3] { "Vasif","Mehemmed","Camal"};

            //foreach (string item in students)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(students.Length);
            //for (int i = 0; i < students.Length; i++)
            //{
            //    Console.WriteLine(students[i]);
            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 10; i>0 ; i--)
            //{
            //    Console.WriteLine(i);
            //}
            //int i = 1;
            //while (i<10)
            //{

            //    Console.WriteLine(i);
            //    i++;
            //}

            //do
            //{
            //    Console.WriteLine(i);
            //} while (i > 1);

            //while (i > 1)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
        }
    }
}

