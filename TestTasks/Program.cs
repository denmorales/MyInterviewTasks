using System;
using System.Collections.Generic;
using System.Linq;

namespace TestTasks
{
    class Program
    {
        static void Main(string[] args)
        {

            MirrowString();// отзеркалить введенную строку двумя способами: с конца и по разделителю кусками 
            GetSum(1, 8);//найти сумму всех чисел между двумя введенными 
            FindDivisior(10);//найти делители введенного числа
            SongDecoder("WUBWUBLOVEWUBUWUB");//избавиться от помех "WUB" в строке 
            Narcissistic(153);//проверить, является ли число нарциссическим(цифры в степени размера числа в сумме дают его же)
        }
        public static void Narcissistic(int value)
        {
            bool IsNarcissistic = false;

            int SumOfproiz = 0;
            var massoffigure = value.ToString().Select(c => Int32.Parse(c.ToString()));
            int razmer = massoffigure.Count();
            foreach (var currentFigure in massoffigure)
            {

                double result = Math.Pow(Convert.ToDouble(currentFigure), Convert.ToDouble(razmer));
                SumOfproiz += Convert.ToInt32(result);
            }

            if (SumOfproiz == value)
            {
                IsNarcissistic = true;
            }

            Console.WriteLine(IsNarcissistic);

        }
        public static string SongDecoder(string inStroka)
        {
            string stroka = inStroka;
            string finalstring = inStroka.Replace("WUB", " ");
            Console.WriteLine(finalstring.Trim());
            return finalstring;
        }
        static void FindDivisior(int razmer)
        {


            List<int> ListOfDivisior = new List<int>();
            for (int i = 2; i < razmer; i++)
            {
                if (razmer % i == 0)
                {
                    ListOfDivisior.Add(i);
                }
            }
            for (int i = 0; i < ListOfDivisior.Count; i++)
            {
                Console.WriteLine(ListOfDivisior[i].ToString());
            }

        }

        public static int GetSum(int a, int b)
        {
            int startelem = Math.Min(a, b);
            int finalelem = Math.Max(a, b);
            int sumelem = 0;


            if (startelem == finalelem)
            {
                return (finalelem);
            }
            else
            {

                for (int i = startelem; i <= finalelem; i++)
                {


                    sumelem += i;

                }
                return (sumelem);
            }

        }

        public static void MirrowString()
        {
            int n;
            string stroka1, stroka2;
            string stroka1out = "";
            string stroka2out = "";
            string stroka1Vvod = Console.ReadLine();

            n = stroka1Vvod.Length;
            for (int i = 0; i < n; i++)
            {
                stroka1 = stroka1Vvod.Substring(n - i - 1, 1);
                stroka1out += stroka1;
            }
            Console.WriteLine(stroka1out);
            //part 2
            string stroka2Vvod = Console.ReadLine();
            string[] mass = stroka2Vvod.Split('/');
            int dlinamas = mass.Length;
            for (int j = 0; j < dlinamas; j++)
            {
                n = mass[j].Length;

                for (int i = 0; i < n; i++)
                {
                    stroka2 = mass[j].Substring(n - i - 1, 1);
                    stroka2out += stroka2;
                }
                if (j != (dlinamas - 1))
                {
                    stroka2out += "/";
                }
            }
            Console.WriteLine(stroka2out);
        }
    }
}
