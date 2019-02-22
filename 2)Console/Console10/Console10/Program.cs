using System;


namespace Console10 {
    class Program {
        static void Main(string[] args) {
            //Console.Write("Please enter your name: ");
            //GiveHello(Console.ReadLine());

            //Console.Write("Please enter first number: ");
            //int firstFInt = int.Parse(Console.ReadLine());
            //Console.Write("Please enter second number: ");
            //int firstSInt = int.Parse(Console.ReadLine());
            //Console.Write("Please enter operator: ( Add: + | Subtract: - | Multiply: * | Divide: / | Modulus: % ) ");
            //string firstFString = Console.ReadKey().KeyChar.ToString();
            //Console.WriteLine("\n");
            //Console.WriteLine(Calculate(firstFInt, firstSInt, firstFString));

            //Console.Write("Please enter a number: ");
            //Console.WriteLine(IsPrime(int.Parse(Console.ReadLine())));

            //float[] thirdFIArray = new float[10];
            //for ( int i = 0; i < 10; i++ ) {
            //    Console.Write($"Please enter {i + 1}. float number: ");
            //    thirdFIArray[i] = float.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("\n\nArithmetic Mean: " + WriteArray(thirdFIArray));

            //Random fourthFRandom = new Random();
            //int[] fourthFIArray = new int[20];

            //for ( int i = 0; i < fourthFIArray.Length; i++ ) fourthFIArray[i] = fourthFRandom.Next(20, 81);

            //foreach ( var item in fourthFIArray ) Console.Write(item + " ");
            //}

            //Console.WriteLine("\n\n---\n");
            //PowerArray(ref fourthFIArray);

            //foreach ( var item in fourthFIArray ) Console.Write(item+" ");

            //Optional("Root");
            //Optional("Usr","Linux",2);

            //Named(a: "Ege", b: 22, c: "b+");

            //Console.WriteLine(Recursive(3));

            //Console.Write("Please enter a number: ");
            //int fifthFInt = int.Parse(Console.ReadLine());
            //for ( int i = 0; i < fifthFInt; i++ ) {
            //    Console.WriteLine(RecursiveTwo(i));
            //}



            Console.ReadKey();
        }

        //static int RecursiveTwo(int a) {
        //    if ( a == 0 || a < 0 ) return 0;
        //    else if ( a == 1 ) return 1;
        //    return RecursiveTwo(a - 1) + RecursiveTwo(a - 2);
        //}
        
        //static int Recursive(int a) {
        //    if ( a == 0 ) return 1;
        //    return a * Recursive(a - 1);
        //}

        //static void Named(string a, int b, string c) {
        //    Console.WriteLine($"Name: {a} - Age: {b} - Blood Type: {c}");
        //}

        //static void Optional(string a, string b = "Hotel", int c = 150) {
        //    Console.WriteLine($"User: {a} - Workload: {b} - Number: {c}");
        //}

        //static void PowerArray(ref int[] first) {
        //    for ( int i = 0; i < first.Length; i++ ) {
        //        first[i] += 20;
        //    }
        //}

        //static float WriteArray(float[] firstarray) {
        //    Console.WriteLine("\n---\n");
        //    float total=0;
        //    foreach ( var item in firstarray ) {
        //        total += item;
        //        Console.Write(item+" ");
        //    }
        //    return total / 10;
        //}
        //static bool IsPrime(int first) {
        //    int counter = 0;

        //    if ( first > 1 ) {
        //        for ( int i = 1; i <= 10; i++ ) {
        //            if ( first % i == 0 ) counter++;
        //        }
        //        if ( counter == 2 || counter == 1 ) return true;
        //        else return false;
        //    }
        //    else return false;
        //}

        //static float Calculate(int first, int second, string operate) {
        //    switch ( operate ) {
        //        case "+":
        //            return first + second;
        //        case "-":
        //            return first - second;
        //        case "*":
        //            return first * second;
        //        case "/":
        //            return (float)first / second;
        //        case "%":
        //            return (float)first % second;
        //        default:
        //            Console.WriteLine("Wrong input..."); return 0;
        //    }
        //}

        //static void GiveHello(string a) {
        //    Console.WriteLine("Hello " + a);
        //}
    }
}
