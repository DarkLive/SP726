using System;

namespace Console01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World \n");
            
            int firstI = 2, secondI = 5, thirdI = 7;
            Console.WriteLine("3 Int = " + (firstI * secondI) + thirdI + "\n");

            byte firstB = 25, secondB = 50, thirdB = 150;
            int sonuc = 0;
            sonuc = firstB + secondB + thirdB;
            Console.WriteLine("3 Byte = " + sonuc + "\n");

            char firstC = 'C';
            Console.WriteLine(firstC+"\n");

            bool firstBl = true;
            Console.Write(firstBl);

            string firstS = " or", secondS = " not?", thirdS = firstS + secondS;
            Console.WriteLine(thirdS);

            Console.WriteLine($"{firstBl} {thirdS}");
            Console.WriteLine("{0} {1}\n", firstBl,thirdS);

            Console.WriteLine("C:\\\\Windows");
            Console.WriteLine($@"C:\\Windows");

            var firstVar = (dynamic)null; //Dynamic Var == Object
            firstVar = 60;
            Console.Write("\n{0} | ", firstVar.GetType());
            firstVar = "Test";
            Console.Write("{0} | ", firstVar.GetType());
            firstVar = true;
            Console.WriteLine("{0}", firstVar.GetType());

            object firstObj = 60, secondObj = "Hello World", thirdObj = true, forthObj = 50.32m;
            Console.WriteLine("\n{0} | {1} | {2} | {3}\n", firstObj.GetType(), secondObj.GetType(), thirdObj.GetType(), forthObj.GetType());

            Console.Write("Please enter something: ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("Number: {0} | Type: {1}",input,input.GetType());

            Console.ReadKey();
        }
    }
}
