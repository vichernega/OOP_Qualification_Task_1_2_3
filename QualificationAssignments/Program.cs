using System;

namespace QualificationAssignments
{
    class Program
    {
        static void Main(string[] args)
        {
         //   QualificationAssignment1();
            //QualificationAssignment2();
            QualificationAssignment3();
        }
        
        public static void QualificationAssignment1()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Привіт ДонНУ");
        }

        public static void QualificationAssignment2()
        {
            try
            {
                Console.Write("Enter your int type variable: ");
                int intType = Convert.ToInt32(Console.ReadLine());

                Console.Write("Entre your double type variable: ");
                double doubleType = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter your long type variable: ");
                long longType = Convert.ToInt64(Console.ReadLine());

                Console.WriteLine($"a = {intType}, b = {doubleType}, c = {longType}");
            }
            catch (Exception k)
            {
                Console.WriteLine($"{k.Message} Try again.");
            }
        }

        public static void QualificationAssignment3()
        {
            int intType = 0;
            double doubleType = 0;
            long longType = 0;

            bool flag = true;
            while (flag)
            {
                try
                {
                    Console.Write("Enter your int type variable: ");
                    intType = Convert.ToInt32(Console.ReadLine());
                    flag = false;
                }
                catch (Exception k)
                {
                    Console.WriteLine($"{k.Message} INT type variable must be entered. Try again.");
                }
            }

            flag = true;
            while (flag)
            {
                try
                {
                    Console.Write("Enter your double type variable: ");
                    doubleType = Convert.ToDouble(Console.ReadLine());
                    flag = false;
                }
                catch (Exception k)
                {
                    Console.WriteLine($"{k.Message} DOUBLE type variable must be entered. Try again.");
                }
            }

            flag = true;
            while (flag)
            {
                try
                {
                    Console.Write("Enter your long type variable: ");
                    longType = Convert.ToInt64(Console.ReadLine());
                    flag = false;
                }
                catch (Exception k)
                {
                    Console.WriteLine($"{k.Message} LONG type variable must be entered. Try again.");
                }
            }

            Console.WriteLine($"a = {intType}, b = {doubleType}, c = {longType}");
        }
    }
}
