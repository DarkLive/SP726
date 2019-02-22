using System;

namespace Console11 {
    class Program {
        static void Main(string[] args) {
            //Console.WriteLine("Pi: "+Math.PI);
            //Console.WriteLine("E: " + Math.E);

            //Console.WriteLine("\nAbs: " + Math.Abs(-8));
            //Console.WriteLine("Cos: " + Math.Cos(45));
            //Console.WriteLine("Sin: " + Math.Sin(45));
            //Console.WriteLine("Tan: " + Math.Tan(45));

            //Console.WriteLine("\nMax: " + Math.Max(4,5));
            //Console.WriteLine("Min: " + Math.Min(4,5));
            //Console.WriteLine("Power: " + Math.Pow(2,5));

            //Console.WriteLine("\nSqrt: " + Math.Sqrt(25));

            //int[] FirstFIArray = new int[10];
            //for ( int i = 0; i < 10; i++ ) {
            //    Console.Write($"Please enter {i+1}. number: ");
            //    FirstFIArray[i] = int.Parse(Console.ReadLine());
            //}

            //FirstArray(ref FirstFIArray);
            //Console.WriteLine();

            //foreach ( var item in FirstFIArray ) {
            //    Console.WriteLine(item);
            //}

            //Random secondFRandom = new Random();

            //Console.Write("Please enter a number: ");
            //int secondFInt = int.Parse(Console.ReadLine());

            //int[] secondFIArray = new int[secondFInt];

            //for ( int i = 0; i < secondFIArray.Length; i++ ) {
            //    secondFIArray[i] = secondFRandom.Next(75, 126);
            //}

            //Console.WriteLine();

            //foreach ( var item in secondFIArray ) {
            //    Console.Write(item + " ");
            //}

            //Console.WriteLine("\n");
            //Console.WriteLine("Total of all number in array: "+NumberAdd(secondFIArray));
            //Console.WriteLine("Total of first 3 numbers in array: " + NumberAdd(secondFIArray[0], secondFIArray[1], secondFIArray[2]));
            //Console.WriteLine("Total of first 2 numbers in array + 4: " + NumberAdd(secondFIArray[0], secondFIArray[1]));

            //string str11 = "Smart", str12 = "Pro", str13 = "", str14 = "   SmartPro", str15 = "Hello User Usr Admin Root";
            //char[] chr = { 'o', 'P' };
            //string[] stra = str15.Split(' ');
            //string straj = string.Join(" ", stra);
            //str13 = string.Concat(str11, str12);
            //Console.WriteLine(str13);
            //Console.WriteLine(string.Compare(str11, str12));
            //Console.WriteLine();
            //Console.WriteLine(str13.IndexOf("r"));
            //Console.WriteLine(str13.LastIndexOf("r"));
            //Console.WriteLine(str13.StartsWith("S"));
            //Console.WriteLine(str13.StartsWith("P"));
            //Console.WriteLine(str13.EndsWith("t"));
            //Console.WriteLine(str13.EndsWith("o"));
            //Console.WriteLine(str13.EndsWith("Pro"));
            //Console.WriteLine();
            //Console.WriteLine(str14);
            //Console.WriteLine(str14.Trim());
            //Console.WriteLine(str14.Trim(chr));
            //Console.WriteLine();
            //Console.WriteLine(str12.PadLeft(5));
            //Console.WriteLine(str12.PadLeft(5,'+'));
            //Console.WriteLine(str12.PadRight(5,'+'));
            //Console.WriteLine();
            //Console.WriteLine(str15);
            //foreach ( var item in stra ) Console.WriteLine(item);
            //Console.WriteLine(straj);
            //Console.WriteLine();
            //Console.WriteLine(str13.ToLower());
            //Console.WriteLine(str13.ToUpper());
            //Console.WriteLine();
            //Console.WriteLine(str13.Remove(0,5));
            //Console.WriteLine(str13.Insert(8," Insert"));
            //Console.WriteLine(str13.Replace('P','B'));
            //Console.WriteLine();
            //Console.WriteLine(str15.Substring(8));
            //Console.WriteLine(str15.Substring(0, 7));
            //Console.WriteLine();
            //Console.WriteLine(str15.Contains("llo"));
            //Console.WriteLine(str15.Contains("do"));
            //Console.WriteLine();
            //Console.WriteLine(str15[8]);

            //Console.Write("Please enter a text: ");
            //string firstFString = Console.ReadLine();
            //firstFString = firstFString.Trim();
            //string[] firstFSArray = firstFString.Split(' ');
            //Console.WriteLine(string.Join(",",firstFSArray)); 

            //Console.Write("Please enter a text: ");
            //CountText(Console.ReadLine());

            //Console.Write("Please enter a text: ");
            //string secondFString = Console.ReadLine();
            //RemoveNBSP(ref secondFString);
            //Console.WriteLine(secondFString);

            //Console.Write("Please enter a text: ");
            //string thirdFString = Console.ReadLine();
            //string[] thirdFSArray = new string[thirdFString.Length];
            //char [] thirdFCArray = new char[thirdFString.Length];
            //for ( int i = 0; i < thirdFString.Length; i++ ) thirdFSArray[i] = thirdFString.Substring(i, 1);

            //thirdFCArray = CreateCharArray(thirdFSArray);

            //Console.WriteLine();
            //foreach ( var item in thirdFCArray ) Console.Write(item+"|");
            //Console.WriteLine("\n\n"+thirdFCArray[0].GetType());

            //Console.Write("Please enter a text: ");
            //WordCount(Console.ReadLine());

            //Console.Write("Please enter a text: ");
            //ReverseText(Console.ReadLine());

            Console.ReadKey();
        }

        //static void ReverseText(string a) {
        //    string[] b = new string[a.Length];
        //    for ( int i = 0; i < a.Length; i++ ) b[i] = a[i].ToString();
        //    Array.Reverse(b);
        //    foreach ( var item in b ) Console.Write(item);
        //}

        //static void WordCount(string a) {
        //    string[] b = a.Split(' ');
        //    Console.WriteLine(b.Length);
        //}

        //static char[] CreateCharArray(string[] a) {
        //    char[] achar = new char[a.Length];
        //    for ( int i = 0; i < a.Length; i++ ) achar[i] = Convert.ToChar(a[i]);
        //    return achar;
        //}

        //static void RemoveNBSP(ref string a) {
        //    for ( int i = 0; i < a.Length; i++ ) {
        //        if ( a.Substring(i, 1) == " " ) { a = a.Remove(i, 1); i--; } 
        //    }
        //}

        //static void CountText(string a) {
        //    int nbsp = 0, chara = 0;
        //    foreach ( var item in a ) {
        //        if ( item == ' ' ) nbsp++;
        //        else chara++;
        //    }
        //    Console.WriteLine("Character: " + chara + "\nWhitespace: " + nbsp);
        //}

        //static int NumberAdd(int[] first) {
        //    int total=0;
        //    foreach ( var item in first ) total += item;
        //    return total;
        //}
        //static int NumberAdd(int a, int b, int c = 4) {
        //    int total = 0;
        //    return total = a + b + c;
        //}

        //static void FirstArray(ref int[] IArray) {
        //    for ( int i = 0; i < IArray.Length ; i++ ) {
        //        IArray[i] = (int)(Math.Pow(IArray[i],2) * 2 + 5);
        //    }
        //}


    }
}
