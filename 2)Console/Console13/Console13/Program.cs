using System;
using System.Collections;
 

namespace Console13 {
   class Program {
      static void Main(string[] args) {
         //FourKoma fourKoma = new FourKoma();
         //Console.WriteLine(fourKoma.firstInt);
         //fourKoma.Hello();
         //Console.WriteLine(fourKoma.Hello2());

         //course courseN = new course();
         //courseN.CourseOpen();

         //Car CarX = new Car();
         //CarX.Color = "Red";
         //CarX.ServiceInfo("Black");

         //CalculateThis Calc = new CalculateThis();
         //Console.Write("Please enter 1st number: ");
         //double number1 = double.Parse(Console.ReadLine());
         //Console.Write("Please enter 2nd number: ");
         //double number2 = double.Parse(Console.ReadLine());

         //Console.WriteLine(Calc.DoMath(number1, number2));

         //Triangle nTriangle = new Triangle();

         //Console.WriteLine($"Area: {nTriangle.EnterSide()}");

         //Company Comp = new Company();
         //Company Comp2 = new Company("Dark Corp", "Kadikoy/ISTANBUL", "00015", "Limited");
         //Comp2.WriteCompany

         

         Console.ReadKey();
      }
   }

   //class Company {
   //   public string CompanyName, TaxOffice, TaxNumber; public byte Type=2;
   //   public ArrayList CompanyTypes = new ArrayList { "Anonymous", "Limited", "Personal" };

   //   public Company() {
   //      CompanyName = "N/K"; TaxOffice = "N/K"; TaxNumber = "N/K"; Type = 2;
   //   }
   //   public Company(string companyName, string taxOffice, string taxNumber, string type) {
   //      CompanyName = companyName; TaxOffice = taxOffice; TaxNumber = taxNumber; Type = (byte)CompanyTypes.IndexOf(type);
   //   }
   //   public void WriteCompany() {
   //      Console.WriteLine($"Company Name: {CompanyName}\nTax Office: { TaxOffice}\nTax Number: {TaxNumber}\nCompany Type: {CompanyTypes[Type]}");
   //   }
   //}

   //class Triangle {
   //   private int Side1, Side2, Side3, Height;

   //   private int publicSide1
   //   {
   //      get { return Side1; }
   //      set {
   //         if ( value < 0 ) Side1 = 10;
   //         else Side1 = value;
   //      }
   //   }
   //   private int publicSide2
   //   {
   //      get { return Side2; } 
   //      set {
   //         if ( value < 0 ) Side2 = 10;
   //         else Side2 = value;
   //      }
   //   }
   //   private int publicSide3
   //   {
   //      get { return Side3; }
   //      set {
   //         if ( value < 0 || !(value < (Side1+Side2)) || !(value > (Side1-Side2)) ) { Console.Write($"Please enter 3rd line lenght: "); publicSide3 = int.Parse(Console.ReadLine()); }
   //         else Side3 = value;
   //      }
   //   }
   //   public int EnterSide() {
   //      Console.Write($"Please enter 1st line lenght: "); publicSide1 = int.Parse(Console.ReadLine());
   //      Console.Write($"Please enter 2nd line lenght: "); publicSide2 = int.Parse(Console.ReadLine());
   //      Console.Write($"Please enter 3rd line lenght: "); publicSide3 = int.Parse(Console.ReadLine());
   //      return CalculateArea();
   //   }
   //   private int CalculateArea() {
   //      Console.WriteLine($"Side 1: {Side1} | Side 2: {Side2} | Side 3: {Side3}");
   //      return (Side1 + Side2 + Side3) / 2;
   //   }
   //}

   //class CalculateThis {
   //   public char Operation; public double Number1, Number2; public string Total;

   //   public string DoMath(double number1, double number2) {
   //      Number1 = number1; Number2 = number2;
   //      backtofuture:
   //      Console.Write("Please enter a operator( + - * / ): ");
   //      Operation = Console.ReadKey().KeyChar;
   //      Console.WriteLine("\n");
   //      switch ( Operation ) {
   //         case '+':
   //            return Add();
   //         case '-':
   //            return Subtract();
   //         case '*':
   //            return Multiply();
   //         case '/':
   //            return Divide();
   //         default:
   //            Console.WriteLine("Wrong Input.");
   //            goto backtofuture;
   //      }

         
   //   }

   //   private string Add() {
   //      return $"{Number1} {Operation} {Number2} = {Number1 + Number2}";
   //   }
   //   private string Subtract() {
   //      return $"{Number1} {Operation} {Number2} = {Number1 - Number2}";
   //   }
   //   private string Divide() {
   //      if ( Number1 == 0 || Number2 == 0 ) { return "Cannot divide by 0"; }
   //      else { return $"{Number1} {Operation} {Number2} = {Number1 / Number2}"; }
   //   }
   //   private string Multiply() {
   //      return $"{Number1} {Operation} {Number2} = {Number1*Number2}";
   //   }

   //}

   //class Car {
   //   public string brand, Color;
   //   private int modelyear;

   //   public void ServiceInfo(string Color){
   //      Console.WriteLine(this.Color + " => " + Color);
   //   }
   //}

   //class course {
   //   public int course_no, course_size; public string teachername;
   //   private ArrayList traineeinfo = new ArrayList();

   //   private void TraineeRegister() {
   //      Console.WriteLine();
   //      for ( int i = 0; i < course_size; i++ ) {
   //         Console.Write("Trainee Name: ");
   //         traineeinfo.Add(Console.ReadLine());
   //      }
   //      TraineeList();
   //   }
   //   private void TraineeList() {
   //      Console.WriteLine();
   //      foreach ( var item in traineeinfo ) {
   //         Console.WriteLine($"Course No: {course_no} - Teacher Name: {teachername} - Trainee Name: {item}");
   //      }
   //   }
   //   public void CourseOpen() {
   //      Console.Write("Please enter course no: ");
   //      course_no = int.Parse(Console.ReadLine());
   //      Console.Write("Please enter teacher name: ");
   //      teachername = Console.ReadLine();
   //      Console.Write("Please enter course size: ");
   //      course_size = int.Parse(Console.ReadLine());

   //      TraineeRegister();
   //   }
   //}

   //class FourKoma {
   //   public int firstInt = 5; public string firstString; double firstDouble;

   //   public void Hello() {
   //      Console.WriteLine("Hello");
   //   }
   //   public string Hello2() {
   //      return "Hello 0_0";
   //   }
   //}
}
