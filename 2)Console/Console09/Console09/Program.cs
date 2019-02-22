using System;

namespace Console09 {
    class Program {
        static void Main( string[] args ) {
            //int firstFInt, firstSInt = 0;
            //Console.WriteLine( "Please enter a number: " );
            //firstFInt = int.Parse( Console.ReadLine() );

            //do {
            //    firstSInt++;
            //    Console.Write( "\nSmart" );
            //    if ( firstSInt == firstFInt / 2 ) {
            //        continue;
            //    }
            //    Console.Write( "Pro" );

            //} while ( firstSInt < firstFInt );

            //Random secondFRInt = new Random();

            //for ( int i = 1; i <= 10; i++ ) {
            //    Console.WriteLine( secondFRInt.Next( 10, 20 ) );
            //}

            //Random thirdFRInt = new Random();
            //int thirdFInt = 0, thirdSInt = 0, thirdTInt = thirdFRInt.Next( 1, 41 );

            //do {
            //    Console.Write( "\nPlease enter a number between 1 and 40: " );
            //    thirdSInt = int.Parse( Console.ReadLine() );
            //    if ( thirdSInt >= 1 && thirdSInt <= 40 ) thirdFInt++;
            //    else continue;

            //    if ( thirdSInt == thirdTInt ) { Console.WriteLine( "Congratz." ); break; }
            //    else if ( thirdFInt == 10 ) Console.WriteLine( "Too many wrong attempts. Random number was: " + thirdTInt );
            //    else if ( thirdSInt > thirdTInt ) Console.WriteLine( "Entered number is higher than random number." );
            //    else Console.WriteLine( "Entered number is lesser than random number." );
            //} while ( thirdFInt < 10 );

            //Random fourthRInt = new Random();
            //int fourthFInt = 1, fourthSInt, fourthTInt, fourthFoInt = 1, fourthFiInt = 101;

            //do {
            //    Console.Write( "Please enter a number between 1 and 100: " );
            //    fourthSInt = int.Parse( Console.ReadLine() );
            //} while ( !( fourthSInt >= 1 && fourthSInt <= 100 ) );

            //do {
            //    fourthTInt = fourthRInt.Next( fourthFoInt, fourthFiInt );
            //    if ( fourthSInt == fourthTInt ) { Console.WriteLine( $"{fourthFInt} try is successful." ); break; }
            //    else {
            //        Console.WriteLine( $"{fourthFInt} try is unsuccessful." );
            //        //Console.WriteLine("\n\n"+ fourthTInt + "\n"+fourthFoInt+" "+ fourthFiInt); //DEBUG
            //        if ( fourthSInt > fourthTInt ) fourthFoInt = fourthTInt;
            //        else fourthFiInt = fourthTInt;
            //    }

            //    fourthFInt++;
            //} while ( fourthFInt <= 15 );

            //Random fifthFRandom = new Random();
            //int fifthFInt;

            //do {
            //    fifthFInt = fifthFRandom.Next( 1, 21 );
            //    Console.WriteLine( fifthFInt );

            //    if ( fifthFInt == 11 ) break;
            //} while ( true );

            //Random sixthFRandom = new Random();
            //int[] sixthFInt = new int[10];

            //for ( int i = 0; i < sixthFInt.Length; i++ ) {
            //    sixthFInt[i] = sixthFRandom.Next( 1, 101 );
            //}

            //foreach ( int a in sixthFInt ) {
            //    Console.WriteLine( a );
            //}

            //int[] seventhFInt = new int[20];

            //for ( int i = 0; i < seventhFInt.Length; i++ ) {
            //    Console.WriteLine( "Please enter a number: " );
            //    seventhFInt[i] = int.Parse( Console.ReadLine() );
            //}

            //foreach ( int item in seventhFInt ) {
            //    if ( item % 2 == 0 ) Console.WriteLine( item );
            //}

            //Console.Write( "How many names you want to enter to array: " );
            //int eightFInt = int.Parse( Console.ReadLine() );

            //string[] eightFString = new string[eightFInt];


            //for ( int i = 0; i < eightFInt; i++ ) {
            //    Console.Write( "Please enter a name: " );
            //    eightFString[i] = Console.ReadLine();
            //}

            //Array.Sort( eightFString );
            //Console.WriteLine( "\nWriting Names after Sort:\n" );

            //foreach ( var item in eightFString ) {
            //    Console.WriteLine( item );
            //}

            //if ( !( eightFString.Length % 2 == 0 ) ) Array.Clear( eightFString, eightFString.Length / 2, 1 );
            //Console.WriteLine( "\nWriting Names after Clear:\n" );

            //foreach ( var item in eightFString ) {
            //    Console.WriteLine( item );
            //}

            //Console.Write( "How many numbers you want to enter to array: " );
            //int ninthInt = int.Parse( Console.ReadLine() );

            //Console.WriteLine();

            //int ninthFSInt = 0, ninthFTInt = 0;
            //int[] ninthSInt = new int[ninthInt];
            //int[] ninthTInt = new int[ninthInt];

            //for ( int i = 0; i < ninthInt; i++ ) {
            //    Console.Write( "Please enter a number: " );
            //    int ninthFFInt = int.Parse( Console.ReadLine() );
            //    if ( ninthFFInt % 2 == 0 ) { ninthSInt[ninthFSInt] = ninthFFInt; ninthFSInt++; }
            //    else { ninthTInt[ninthFTInt] = ninthFFInt; ninthFTInt++; }
            //}

            //Array.Sort( ninthSInt ); Array.Sort( ninthTInt );

            //Console.WriteLine( "\nSingle Numbers:" );
            //foreach ( var item in ninthTInt ) {
            //    if ( !( item == 0 ) ) Console.WriteLine( item );
            //}

            //Console.WriteLine( "\nDouble Numbers:" );
            //foreach ( var item in ninthSInt ) {
            //    if ( !( item == 0 ) ) Console.WriteLine( item );
            //}

            //Console.Write( "How many numbers you want to enter to array: " );
            //int tenthInt = int.Parse( Console.ReadLine() );

            //Console.WriteLine();

            //int tenthFSInt = 0, tenthFTInt = 0;
            //int[] tenthSInt = new int[tenthInt];
            //int[] tenthTInt = new int[tenthInt];

            //for ( int i = 0; i < tenthInt; i++ ) {
            //    Console.Write( "Please enter a number: " );
            //    int tenthFFInt = int.Parse( Console.ReadLine() );
            //    if ( tenthFFInt >= 50 ) { tenthSInt[tenthFSInt] = tenthFFInt; tenthFSInt++; }
            //    else { tenthTInt[tenthFTInt] = tenthFFInt; tenthFTInt++; }
            //}

            //Array.Sort( tenthSInt ); Array.Sort( tenthTInt ); tenthFSInt = 0; tenthFTInt = 0;

            //Console.WriteLine( "\nSingle Numbers:" );
            //foreach ( var item in tenthTInt ) {
            //    if ( !( item == 0 ) ) Console.WriteLine( item );
            //    tenthFTInt += item;
            //}

            //Console.WriteLine( "\nDouble Numbers:" );
            //foreach ( var item in tenthSInt ) {
            //    if ( !( item == 0 ) ) Console.WriteLine( item );
            //    tenthFSInt += item;
            //}

            //Console.WriteLine( $"\nTotal of all numbers less than 50: {tenthFTInt}\nTotal of numbers bigger than 50: {tenthFSInt}\nTotal of all numbers entered: {tenthFTInt + tenthFSInt}" );

            //string[] eleventhFiArray = { "101", "102", "103", "104", "105" }, eleventhSeArray = { "ahmet", "recep", "mustafa", "kenan", "ayşe" }, eleventhThArray = { "5255255", "2525252", "1424351", "12316451", "14572341" }, eleventhFoArray = { "ahmet@hotmail.com", "recep@gmail.com", "mustafa@yahoo.com", "kenan@myspace.com", "ayse@live.com" };

            //backtothefuture:
            //Console.Write( "How you want to search your employee list\nPersonal Number(pn), Full Name(fn), Phone(ph), Email(em): " );
            //string elevenFString = Console.ReadLine().ToLower();
            //Console.Write( "Input: " );
            //string elevenSString = Console.ReadLine().ToLower();

            //int elevenFInt = 0;

            //switch ( elevenFString ) {
            //    case "pn":
            //        if ( Array.IndexOf( eleventhFiArray, elevenSString ) >= 0 ) {
            //            elevenFInt = Array.IndexOf( eleventhFiArray, elevenSString );
            //            Console.WriteLine();
            //            Console.WriteLine( eleventhFiArray[elevenFInt] );
            //            Console.WriteLine( eleventhSeArray[elevenFInt] );
            //            Console.WriteLine( eleventhThArray[elevenFInt] );
            //            Console.WriteLine( eleventhFoArray[elevenFInt] );
            //        }
            //        break;
            //    case "fn":
            //        if ( Array.IndexOf( eleventhSeArray, elevenSString ) >= 0 ) {
            //            elevenFInt = Array.IndexOf( eleventhSeArray, elevenSString );
            //            Console.WriteLine();
            //            Console.WriteLine( eleventhFiArray[elevenFInt] );
            //            Console.WriteLine( eleventhSeArray[elevenFInt] );
            //            Console.WriteLine( eleventhThArray[elevenFInt] );
            //            Console.WriteLine( eleventhFoArray[elevenFInt] );
            //        }
            //        break;
            //    case "ph":
            //        if ( Array.IndexOf( eleventhThArray, elevenSString ) >= 0 ) {
            //            elevenFInt = Array.IndexOf( eleventhThArray, elevenSString );
            //            Console.WriteLine();
            //            Console.WriteLine( eleventhFiArray[elevenFInt] );
            //            Console.WriteLine( eleventhSeArray[elevenFInt] );
            //            Console.WriteLine( eleventhThArray[elevenFInt] );
            //            Console.WriteLine( eleventhFoArray[elevenFInt] );
            //        }
            //        break;
            //    case "em":
            //        if ( Array.IndexOf( eleventhFoArray, elevenSString ) >= 0 ) {
            //            elevenFInt = Array.IndexOf( eleventhFoArray, elevenSString );
            //            Console.WriteLine();
            //            Console.WriteLine( eleventhFiArray[elevenFInt] );
            //            Console.WriteLine( eleventhSeArray[elevenFInt] );
            //            Console.WriteLine( eleventhThArray[elevenFInt] );
            //            Console.WriteLine( eleventhFoArray[elevenFInt] );
            //        }
            //        break;
            //    default:
            //        Console.WriteLine( "Wrong input turning back.\n\n" ); goto backtothefuture;
            //        break;
            //}

            //int twelveSInt = 0;
            //int[,] twelveFInt = new int[3, 2];
            //Random twelveFRandom = new Random();
            //object obj = "";

            //for ( int i = 0; i < 3; i++ ) {
            //    for ( int a = 0; a < 2; a++ ) {
            //        twelveFInt[i, a] = twelveFRandom.Next( 10, 29 );
            //        Console.Write( twelveFInt[i, a] + " " );
            //        if ( i == 1 ) twelveSInt += twelveFInt[i, a];
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine( "\n" + twelveSInt );

            //int[] thirteenFInt = new int[3];
            //int thirteenTInt = 0;
            //Random thirteenFRandom = new Random();
            //for ( int i = 0; i < 3; i++ ) {
            //    Console.Write( "Please enter a number: " );
            //    thirteenFInt[i] = int.Parse( Console.ReadLine() );
            //}
            //int[,,] thirteenSInt = new int[thirteenFInt[0], thirteenFInt[1], thirteenFInt[2]];

            //for ( int i = 0; i < thirteenFInt[0]; i++ ) {
            //    Console.Write( "( " );
            //    for ( int a = 0; a < thirteenFInt[1]; a++ ) {
            //        for ( int j = 0; j < thirteenFInt[2]; j++ ) {
            //            thirteenSInt[i, a, j] = thirteenFRandom.Next( 10, 91 );
            //            Console.Write( thirteenSInt[i, a, j] + " " );
            //            if ( a == 0 && j == 0 ) thirteenTInt += thirteenSInt[i, a, j];
            //        }
            //    }
            //    Console.Write( ")" );
            //    Console.WriteLine();
            //}
            //Console.WriteLine( "\nTotal: " + thirteenTInt );

            //Console.Write( "Number of students: " );
            //int fourteenFInt = int.Parse( Console.ReadLine() );
            //object[,] fourteenFObj = new object[fourteenFInt, 3];
            //for ( int i = 0; i < fourteenFInt; i++ ) {
            //    Console.Write( "Student Name: " );
            //    fourteenFObj[i, 0] = Console.ReadLine();
            //    Console.Write( "Grade: " );
            //    fourteenFObj[i, 1] = Console.ReadLine();

            //    if ( Convert.ToInt16( fourteenFObj[i, 1] ) >= 0 && Convert.ToInt16( fourteenFObj[i, 1] ) <= 29 ) fourteenFObj[i, 2] = "Very Weak";
            //    else if ( Convert.ToInt16( fourteenFObj[i, 1] ) >= 30 && Convert.ToInt16( fourteenFObj[i, 1] ) <= 54 ) fourteenFObj[i, 2] = "Weak";
            //    else if ( Convert.ToInt16( fourteenFObj[i, 1] ) >= 55 && Convert.ToInt16( fourteenFObj[i, 1] ) <= 69 ) fourteenFObj[i, 2] = "Moderate";
            //    else if ( Convert.ToInt16( fourteenFObj[i, 1] ) >= 70 && Convert.ToInt16( fourteenFObj[i, 1] ) <= 84 ) fourteenFObj[i, 2] = "Good";
            //    else if ( Convert.ToInt16( fourteenFObj[i, 1] ) >= 85 && Convert.ToInt16( fourteenFObj[i, 1] ) <= 100 ) fourteenFObj[i, 2] = "Very Good";
            //    else Console.WriteLine( "\nWrong Input" );
            //}

            //Console.WriteLine();

            //for ( int i = 0; i < fourteenFInt; i++ ) {
            //    Console.WriteLine( $"{fourteenFObj[i, 0]} - {fourteenFObj[i, 1]} - {fourteenFObj[i, 2]}" );
            //}



            Console.ReadKey();
        }
    }
}
