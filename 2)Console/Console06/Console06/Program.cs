using System;


namespace Console06
{
    class Program
    {
        static void Main(string[] args)
        {
            int firfirInt, firsecInt; object firfirObj;
            Console.Write("Please enter a number: ");
            firfirInt = int.Parse(Console.ReadLine());
            Console.Write("Please enter a char: ");
            firsecInt = (char)Console.Read();

            firfirObj = firfirInt + firsecInt;

            Console.WriteLine($"Int = {firfirObj} ({firfirObj.GetType()})");
            firfirObj = Convert.ToDouble(firfirObj);
            Console.WriteLine($"Double = {firfirObj} ({firfirObj.GetType()})");
            firfirObj = firfirObj.ToString();
            Console.WriteLine($"String = {firfirObj} ({firfirObj.GetType()})");

            Console.ReadKey();
        }
    }
}
