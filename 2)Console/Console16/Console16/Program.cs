using System;
using System.IO;
using System.Text;

namespace Console16 {
   class Program {
      static void Main(string[] args) {

         //Console.WriteLine(Directory.GetCurrentDirectory());
         //string directoryName = "ProjectFolder";
         //string fileName = directoryName + "\\fileio.txt";
         //Directory.CreateDirectory(directoryName);

         //Console.WriteLine(Directory.GetCreationTime(directoryName));
         //Console.WriteLine(Directory.Exists(directoryName));
         //Directory.Delete(directoryName);

         //string[] directorylist = Directory.GetFiles(@"C:\xapps", "*.txt");
         //foreach ( var item in directorylist ) { Console.WriteLine(item); }

         //string[] fileanddirectorylist = Directory.GetFileSystemEntries(@"C:\");
         //foreach ( var item in fileanddirectorylist ) { Console.WriteLine(item); }

         //Console.WriteLine(Directory.GetDirectoryRoot(directoryName));
         //Console.WriteLine(Directory.GetLastAccessTime(directoryName));
         //Console.WriteLine(Directory.GetLastWriteTime(directoryName));

         //string[] logicalDrive = Directory.GetLogicalDrives();
         //foreach ( var item in logicalDrive ) { Console.WriteLine(item); }

         //Console.WriteLine(Directory.GetParent(Directory.GetCurrentDirectory()));

         //Directory.CreateDirectory(@"C:\Move");
         //Directory.Move(@"C:\Move", @"C:\xapps\Move");

         //Directory.SetLastAccessTime(directoryName, DateTime.Now.AddDays(2));
         //Console.WriteLine(Directory.GetLastAccessTime(directoryName));

         //Console.WriteLine(Directory.GetCurrentDirectory());
         //Directory.SetCurrentDirectory(@"C:\xapps\");
         //Console.WriteLine(Directory.GetCurrentDirectory());

         //if ( Directory.Exists(@"C:\" + DateTime.Now.ToShortDateString().Replace('.', '_')) ) Console.WriteLine("Directory Exits");
         //else { Directory.CreateDirectory(@"C:\" + DateTime.Now.ToShortDateString().Replace('.', '_')); Console.WriteLine("Directory Created"); }
         //Console.WriteLine(Directory.GetLastWriteTime(@"C:\" + DateTime.Now.ToShortDateString().Replace('.', '_')));

         //Console.WriteLine(File.Exists(fileName));

         //File.Move(fileName, @"C:\fileio.txt");
         //File.Copy(fileName, @"C:\fileio.txt", true);
         //File.Delete(fileName);
         //Console.WriteLine(File.GetAttributes(fileName));
         //File.SetAttributes(fileName, FileAttributes.Normal);
         //Console.WriteLine(File.GetAttributes(fileName));

         //FileStream fs = new FileStream(fileName, FileMode.Open);
         //StreamReader sr = new StreamReader(fs, Encoding.GetEncoding("windows-1254"));
         //string row; int i=1;
         //while ( ( row = sr.ReadLine() ) != null ) { Console.WriteLine($"Row {i}: {row}"); i++; }
         //sr.Close(); fs.Close();

         //FileStream fss = new FileStream(fileName, FileMode.Append, FileAccess.Write);
         //StreamWriter sw = new StreamWriter(fss, Encoding.Default);
         //sw.WriteLine("Hello"); sw.WriteLine("from"); sw.WriteLine("IDE");
         //sw.Flush(); sw.Close(); fss.Close;

         //FileStream fileStream1 = new FileStream("students.txt", FileMode.Append, FileAccess.Write);
         //StreamWriter streamWriter1 = new StreamWriter(fileStream1, Encoding.Default);

         //while ( true ) {
         //   Console.Write("Please enter name: "); string temp1 = Console.ReadLine();
         //   if ( temp1.ToLower() == "close" ) break;
         //   streamWriter1.Write("Student Name: "+temp1+"   ");
         //   Console.Write("Please enter ID: "); string temp2 = Console.ReadLine();
         //   if ( temp2.ToLower() == "close" ) break;
         //   streamWriter1.WriteLine("ID Number: "+temp2);
         //}
         //streamWriter1.Flush(); streamWriter1.Close(); fileStream1.Close();

         Console.ReadKey();
      }
   }
}
