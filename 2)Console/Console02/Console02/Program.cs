using System;

namespace Console2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|| Implicit Conversions ||\n");

            int fInt = 255; float fFloat = fInt;
            Console.WriteLine(fFloat+"\n");

            byte fByte = 254; int sInt = fByte;
            Console.WriteLine(sInt.GetType() + "\n");

            float sFloat = 47.89F; double fDouble = sFloat;
            Console.WriteLine($"Double number type: {fDouble.GetType()} \n");

            char fChar = 'G'; decimal fDecimal = fChar;
            Console.WriteLine(fDecimal+" - "+fDecimal.GetType() + "\n");

            int tInt = 15; byte sByte = 25; short fShort = 45; double sDouble = tInt + sByte + fShort;
            Console.WriteLine(sDouble + "\n");

            Console.WriteLine("|| Explicit Conversions ||\n");


            byte tByte = 255; int foInt = (int)tByte;
            Console.WriteLine(foInt+" - "+foInt.GetType()+"\n");

            int ffInt = 10; byte foByte = (byte)ffInt;
            Console.WriteLine(foByte+"\n");

            checked
            {
                int fiInt = 10; byte ffByte = (byte)fiInt;
                Console.WriteLine(ffByte);
                unchecked
                {
                    int siInt = 256; byte siByte = (byte)siInt;
                    Console.WriteLine(siByte+"\n");
                }
            }

            int seInt = 789; string fString = seInt.ToString();
            Console.WriteLine($"String content: {fString} - String type: {fString.GetType()}\n");

            string sString = "456"; string tString = fString + sString;
            Console.WriteLine($"fString = {fString}\nsString = {sString}\nTotal: {tString}\n");

            float tFloat = 45.17f; string foString = tFloat.ToString();
            Console.WriteLine(foString+"\n");

            string ffString = "144886"; int eInt = int.Parse(ffString);
            Console.WriteLine(eInt.GetType()+"\n");

            Console.WriteLine("|| Implicit Boxing ||\n");

            int obifInt = 75; object onifObject = obifInt;
            Console.WriteLine(onifObject.GetType()+"\n");

            //int obisInt = (int)onifObject; Needs to be Explicit

            Console.WriteLine("|| Explicit Boxing ||\n");

            int obesInt = 75; object obesObject = (object)obesInt;
            Console.WriteLine(obesObject.GetType()+"\n");

            int snesInt = (int)obesObject;
            Console.WriteLine(snesInt.GetType()+"\n");

            Console.WriteLine("|| System.Convert ||\n");

            int scfInt = 55;

            string scfString = Convert.ToString(scfInt);
            double scfDouble = Convert.ToDouble(scfInt);
            bool scfBool = Convert.ToBoolean(scfInt);

            Console.WriteLine($"{scfString} {scfString.GetType()}\n{scfDouble} {scfDouble.GetType()}\n{scfBool} {scfBool.GetType()}\n");
            Console.WriteLine("End of the project...");

            Console.ReadKey();
        }
    }
}
