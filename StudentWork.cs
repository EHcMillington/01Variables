using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Variables
{
    public class Variables
    {
        public string PredictRun()
        {
            String greet = "Hello World";
            Console.WriteLine(greet);
            return greet;
        }

        public  String investigate1()
        {
            String one = "World";
            String two = "Hello";
            Console.WriteLine(two + one);
            return two + one;
        }

        public  String investigate2()
        {
            String one = "5";
            String two = "7";
            Console.WriteLine(two + one);
            return two + one;
        }

        public  String investigate3()
        {
            String one = "5";
            String two = "7";
            one = "Llama";
            Console.WriteLine(two + one);
            return two + one;
        }

        public  int investigate4()
        {
            int oneVariable = 5;
            int twoVariable = 7;
            Console.WriteLine("Investigate 4");
            Console.WriteLine(twoVariable + oneVariable);
            Console.WriteLine(twoVariable - twoVariable);
            Console.WriteLine(twoVariable * oneVariable);
            Console.WriteLine(twoVariable / oneVariable);
            return (oneVariable + twoVariable);

        }

        public  double investigate5()
        {
            double oneVariable = 5;
            double twoVariable = 7;
            Console.WriteLine("Investigate 5");
            Console.WriteLine(twoVariable + oneVariable);
            Console.WriteLine(twoVariable - twoVariable);
            Console.WriteLine(twoVariable * oneVariable);
            Console.WriteLine(twoVariable / oneVariable);
            return (oneVariable + twoVariable);
        }

        public  String investigate6()
        {
            double oneVariable = 5;
            double twoVariable = 7;
            Console.WriteLine("Investigate 6");
            Console.WriteLine(oneVariable + " Party in the USA");
            return (oneVariable + " Party in the USA");
        }

        public  String investigate7()
        {
            double oneVariable = 5;
            Console.WriteLine("Investigate 7");
            Console.WriteLine("What's your name ?");
            String someText = Console.ReadLine();
            Console.WriteLine(oneVariable + someText);
            return (oneVariable + someText);
        }

        public  int investigate8()
        {
            Console.WriteLine("Investigate 8");
            Console.WriteLine("Enter a number");
            int oneVariable = Console.Read();
            Console.WriteLine(oneVariable * 3);
            return oneVariable * 3;
        }

        public  int investigate9()
        {
            Console.WriteLine("Investigate 9");
            Console.WriteLine("Enter a number");
            int oneVariable = int.Parse(Console.ReadLine());
            Console.WriteLine(oneVariable * 3);
            return oneVariable * 3;
        }

        public  String modify1()
        {
            Console.WriteLine("Write a program to add 16 to any number entered");
            String num = Console.ReadLine();
            Console.WriteLine(num + 16);
            return num + 16;
        }

        public  String modify2()
        {
            Console.WriteLine("Whats your first name ?");
            String firstName = Console.ReadLine();
            String lastName = Console.ReadLine();
            Console.WriteLine(firstName + lastName);
            return firstName + lastName;
        }

        public  int modify3()
        {
            Console.WriteLine("Enter a Value");
            int one = Console.Read();
            Console.WriteLine("Enter a second value");
            int two = Console.Read();
            Console.WriteLine(one / two);
            return one / two;
        }
        public  String make1()
        {
            return "";
        }

        public  String make2()
        {
            return "";
        }

        public  String make3()
        {
            return "";
        }

        public  String extension1()
        {
            return "";
        }

        public  String extension2()
        {
            return "";
        }
    }
