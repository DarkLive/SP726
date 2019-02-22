using System;

namespace Console04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arithmetic Operators  + - * /
            //int fifiInt, fiseInt, fithInt, fifoInt, fifivInt=10, fisiInt = 10, fisevInt = 10, fieiInt = 10;
            //fifiInt = 25 + 75;
            //fiseInt = 75 - 25;
            //fithInt = 75 / 25;
            //fifoInt = 75 * 25;
            //Console.Write($"+ {fifiInt} | - {fiseInt} | / {fithInt} | * {fifoInt}");

            //Assignment Operators = += -= /= *= %=
            //fifivInt += 20;
            //fisiInt -= 5;
            //fisevInt /= 5;
            //fieiInt *= 10;
            //finiInt %= 2;
            //Console.Write($"+= {fifivInt} | -= {fisiInt} | /= {fisevInt} | *= {fieiInt} | %= {fieiInt}");

            //Process Priority ()
            //int sefiInt = 10 * 4 - 10 / 3 + 15;
            //int seseInt = 10 * 4 / 2 * 8;
            //int sethInt = 10 * 4 / (2 * 8);
            //Console.WriteLine(sefiInt + seseInt + sethInt);

            //Arithmetic Operators %
            //int thfiInt = 10 % 3;
            //Console.WriteLine(thfiInt);

            //float thseFloat = 45.5F;
            //thseFloat++;
            //++thseFloat;
            //Console.WriteLine(thseFloat);

            //double thfiDouble = 25.0D;
            //thfiDouble--;
            //--thfiDouble;
            //Console.WriteLine(thfiDouble);

            //int thseInt = 100, ththInt = thseInt++, thfoInt = 100, thfivInt = ++thfoInt;
            //Console.WriteLine($"Before: {thseInt} After: {ththInt} | Before: {thfoInt} After: {thfivInt}");

            //Relational Operators < > <= >= == !=
            //bool fofiBool = 34 > 24;//T
            //bool foseBool = 34 < 24;//F
            //bool fothBool = 74.7f > 74.6f;//T
            //bool fofoBool = 34 <= 33;//F
            //bool fofivBool = 34 >= 35;//F
            //bool fosiBool = 34 <= 34;//T
            //bool fosevBool = 34 == 34;//T
            //bool foniBool = 34 != 34;//F

            //Console.WriteLine($"{fofiBool} | {foseBool} | {fothBool} |  {fofoBool} |  {fofivBool} |  {fosiBool} |  {fosevBool} |  {foniBool} ");

            //as - is 
            //int fivfiInt = 55;
            //string fivfiString = "Merhaba";
            //object fivfiObject = "785";
            //bool fivfiBool = fivfiInt is double;//F
            //bool fivseBool = fivfiInt is int;//T
            //bool fivthBool = fivfiInt is object;//T
            //bool fivfoBool = fivfiString is object;//   
            //string fivseString = fivfiObject as string;

            ////as can be used with data types can take null like object and string
            //Console.WriteLine($"{fivfiBool} | {fivseBool} | {fivthBool} | {fivfoBool} | {fivseString}");

            //Logical Operators && || !
            //bool sifiBool = (8 < 9) && (5 == 5); //T
            //bool siseBool = (8 > 9) && (5 == 5); //F
            //bool sithBool = (8 > 9) && (5 != 5);//F
            //bool sifoBool = (8 < 9) && (5 != 5);//F
            //bool sifivBool = (8 < 9) || (5 != 5);//T
            //bool sisiBool = (8 > 9) || (4 == 5);//F
            //bool sisevBool = !((8 > 9) && (5 == 5));//T
            //bool sieiBool = !((8 < 9) || (5 != 5));//F

            //Console.WriteLine($"{sifiBool} | {siseBool} | {sithBool} | {sifoBool} | {sifivBool} | {sisiBool} | {sisevBool} | {sieiBool}");

            //Bitwise Operators & | ^ >> <<
            //byte sevfiByte = 5, sevseByte = 12, sevthByte = 64;

            //int sevfiInt = sevfiByte & sevseByte;
            //Console.WriteLine(sevfiInt);

            //int sevseInt = sevfiByte | sevseByte;
            //Console.WriteLine(sevseInt);

            //int sevthInt = sevfiByte ^ sevseByte;
            //Console.WriteLine(sevthInt);

            //byte sevfoByte = (byte)(sevthByte>>1);
            //Console.WriteLine(sevfoByte);

            //byte sevfivByte = (byte)(sevthByte<<1);
            //Console.WriteLine(sevfivByte);

            Console.ReadKey();
        }
    }
}
