using System;

namespace Console08
{
    class Program
    {
        static void Main(string[] args)
        {
            //int firfirInt = 3;
            //switch (firfirInt)
            //{
            //    case 1:
            //        Console.WriteLine(firfirInt);
            //        break;
            //    case 2:
            //        Console.WriteLine(firfirInt);
            //        break;
            //    case 3:
            //        Console.WriteLine(firfirInt);
            //        break;
            //    default:
            //        Console.WriteLine("Default");
            //        break;
            //}

            //string secfirString = "KADIKÖY";
            //switch (secfirString)
            //{
            //    case "SARIYER":
            //        Console.WriteLine(secfirString);
            //        break;
            //    case "KARTAL":
            //        Console.WriteLine(secfirString);
            //        break;
            //    case "KADIKÖY":
            //        Console.WriteLine(secfirString);
            //        break;
            //    default:
            //        Console.WriteLine("Default");
            //        break;
            //}

            //int thifirInt, thisecInt; string thifirstring;
            //Console.Write("Please enter first number: ");
            //thifirInt = int.Parse(Console.ReadLine());
            //Console.Write("Please enter last number: ");
            //thisecInt = int.Parse(Console.ReadLine());
            //Console.Write("Please select your operation ( + - * / ): ");
            //thifirstring = Console.ReadKey().KeyChar.ToString();

            //switch (thifirstring)
            //{
            //    case "+":
            //        Console.WriteLine($"\n\n{thifirInt} + {thisecInt} = {thifirInt + thisecInt}");
            //        break;
            //    case "-":
            //        Console.WriteLine($"\n\n{thifirInt} - {thisecInt} = {thifirInt - thisecInt}");
            //        break;
            //    case "/":
            //        switch (thisecInt)
            //        {
            //            case 0:
            //                Console.WriteLine("\n\nCant divide by 0");
            //                break;
            //            default:
            //                Console.WriteLine($"\n\n{thifirInt} / {thisecInt} = {(double)thifirInt / thisecInt}");
            //                break;
            //        }
            //        break;
            //    case "*":
            //        Console.WriteLine($"\n\n{thifirInt} * {thisecInt} = {thifirInt * thisecInt}");
            //        break;
            //    default:
            //        Console.WriteLine("\n\nWrong operational input");
            //        break;
            //}

            //int foufouInt;
            //Console.Write("Please enter a number: ");
            //foufouInt = int.Parse(Console.ReadLine());

            //if (foufouInt > 99)
            //{
            //    switch (foufouInt % 3)
            //    {
            //        case 0: case 1: case 2: case 3:
            //            Console.WriteLine("\nWhats left from the divide is " + foufouInt % 3);
            //            break;
            //        default:
            //            Console.WriteLine("\nYou shouldn't be here.");
            //            break;
            //    }
            //}
            //else
            //{
            //    switch (foufouInt % 4)
            //    {
            //        case 0: case 1: case 2: case 3:
            //            Console.WriteLine("\nWhats left from the divide is " + foufouInt % 4);
            //            break;
            //        default:
            //            Console.WriteLine("\nYou shouldn't be here.");
            //            break;
            //    }
            //}

            //int fivfivInt; string fivfivString;
            //Console.Write("Please enter your name: ");
            //fivfivString = Console.ReadLine();
            //Console.Write("Please enter your age: ");
            //fivfivInt = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= fivfivInt; i++)
            //{
            //    Console.WriteLine($"Happy Birthday {fivfivString} --> Age: {i}");
            //}

            //int sixfirInt,sixsecInt; string sixfirString;
            //Console.Write("Please enter your total employee count: ");
            //sixfirInt = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= sixfirInt; i++)
            //{
            //    Console.Write($"\n{i}. employee's name: ");
            //    sixfirString = Console.ReadLine();
            //    Console.Write("How many kids do you have?: ");
            //    sixsecInt = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"{sixfirString} has {sixsecInt} kids.");
            //}

            //int sevfirInt, sevsecInt; string sixfirString;
            //Console.Write("Please enter your total employee count: ");
            //sevfirInt = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= sevfirInt; i++)
            //{
            //    int sevthiInt = 3000;
            //    Console.Write($"\n{i}. employee's name: ");
            //    sixfirString = Console.ReadLine();
            //    Console.Write("How many kids do you have?: ");
            //    sevsecInt = int.Parse(Console.ReadLine());
            //    if (sevsecInt == 0 || sevsecInt < 0) Console.WriteLine($"{sixfirString} has {sevsecInt} so he'll won't take any extra and his/her salary is {sevthiInt}.");
            //    else if (sevsecInt >= 3) Console.WriteLine($"{sixfirString} has {sevsecInt} so he'll take extra {sevsecInt * 75} for child support and his/her salary is {sevthiInt + (sevsecInt * 75)}.");
            //    else Console.WriteLine($"{sixfirString} has {sevsecInt} so he'll take extra {sevsecInt * 100} for child support and his/her salary is {sevthiInt + (sevsecInt * 100)}.");
            //}

            //int eigfirInt, eighsecInt=1;
            //Console.Write("Please enter a number: ");
            //eigfirInt = int.Parse(Console.ReadLine());

            //Console.WriteLine($"{eighsecInt} = {eigfirInt%10}");
            //for (; eigfirInt > 10;)
            //{
            //    eigfirInt /= 10;
            //    int eighthiInt = eigfirInt % 10;
            //    eighsecInt *= 10;
            //    Console.WriteLine($"{eighsecInt} = {eighthiInt}");
            //}

            //for (int i=1;i<=100;i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine("Double: "+i);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Single: " + i);
            //    }
            //}

            //for (int i = 100; i >= 1; i--)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine("Double: " + i);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Single: " + i);
            //    }
            //}

            //int ninfirInt=0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    ninfirInt = ninfirInt + (i * i);
            //    Console.WriteLine($"{i}'s square is {i*i}");
            //}
            //Console.WriteLine($"All squares total: {ninfirInt}");

            //int tenfirInt=0;
            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //        tenfirInt++;
            //    }
            //    Console.WriteLine();
            //    tenfirInt++;
            //}
            //Console.WriteLine($"Total asterisk count: {tenfirInt}");

            //int elefirInt, elesecInt, elethiInt=0;
            //Console.Write("Please enter your total employee count: ");
            //elefirInt = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= elefirInt; i++)
            //{
            //    Console.Write($"\nHow many kids does {i}. worker has?: ");
            //    elesecInt = int.Parse(Console.ReadLine());
            //    for (int j = 1; j <= elesecInt; j++)
            //    {
            //        elethiInt++;
            //        Console.Write($"\nPlease enter kids id no: ");
            //        string elefirString = Console.ReadLine();
            //        Console.WriteLine($"{j} kids ID NO: {elefirString}");
            //    }
            //}
            //Console.WriteLine("\n\nTotal kids: "+elethiInt);

            //for (int i = 1; i <= 45; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        if (i % 3 == 0) Console.Write("#");
            //        else Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 1; i <= 21; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        if (i % 9 == 0) Console.Write("*");
            //        else Console.Write(i);
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.WriteLine($"{i} * {j} = {i * j}");
            //    }
            //    Console.WriteLine();
            //}

            //int thtfirInt = 1;
            //while (thtfirInt <= 10)
            //{
            //    Console.WriteLine(thtfirInt);
            //    thtfirInt++;
            //}

            //string fotfirString = "";
            //while (fotfirString != "K")
            //{
            //    Console.Write("Program will close if u enter capital \"K\": ");
            //    fotfirString = Console.ReadLine();
            //}
            //Console.WriteLine("\nExiting program now. cya.");

            //Console.WriteLine();
            //object fiffirObj = 1;

            //while (Convert.ToInt32(fiffirObj) != 0)
            //{
            //    Console.Write("Please enter a number: ");
            //    fiffirObj = Console.ReadLine();

            //    if (Convert.ToInt32(fiffirObj) >= 1024)
            //    {
            //        fiffirObj = Convert.ToInt64(fiffirObj);
            //        Console.WriteLine("Converted type: "+fiffirObj.GetType());
            //    }
            //    else if (Convert.ToInt32(fiffirObj) < 1024 && Convert.ToInt32(fiffirObj) > 0)
            //    {
            //        fiffirObj = Convert.ToInt16(fiffirObj);
            //        Console.WriteLine("Converted type: "+fiffirObj.GetType());
            //    }
            //}
            //Console.WriteLine("\n\nClosing program now.");

            //int sitfirInt = 1;

            //do
            //{
            //    Console.WriteLine("Hello World." + sitfirInt);
            //    sitfirInt++;
            //} while (sitfirInt < 16);
            //Console.WriteLine("Loop End");

            //int setfirInt = 1;

            //do
            //{
            //    Console.WriteLine($"Square of {setfirInt} is {setfirInt*setfirInt}");
            //    setfirInt++;
            //} while (setfirInt<=100);

            //const string ceitfirString = "smartpro", ceitsecString = "SmartKD"; string eitfirString, eitsecString; int eitfirInt = 5;

            //do
            //{
            //    Console.Write("Username: ");
            //    eitfirString = Console.ReadLine();
            //    Console.Write("Password: ");
            //    eitsecString = Console.ReadLine();

            //    if (eitfirString == ceitfirString && eitsecString == ceitsecString)
            //    {
            //        Console.WriteLine("Login Successful");
            //        break;
            //    }
            //    else if (eitfirInt == 1)
            //    {
            //        Console.WriteLine("Too many wrong attempts");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Wrong credentials");
            //    }
            //    eitfirInt--;
            //} while (eitfirInt>0);



            Console.ReadKey();
        }
    }
}
