using System;
using System.Collections;

namespace ConsoleHomework01 {
    class Program {
        static void Main(string[] args) {

         Staff stf1 = new Staff(); Staff stf2 = new Staff(); Staff stf3 = new Staff();
         stf1.StaffRegister(); stf1.StaffRegister(); stf1.StaffRegister();
         stf1.StaffList();
         Console.WriteLine($"\n\nValue:{stf3.TotalDouble(12, 14, 18)} | Type:{stf3.TotalDouble(12,14,18).GetType()}");

         Console.ReadKey();
        }
    }

    class Staff {
      ArrayList ArrayStaffInfo = new ArrayList();

      private int StaffID = 0, StaffGrossSalary;
      private string StaffName, StaffSurname;

      public int StaffNetSalary {
            get {
                return StaffGrossSalary;
            }
            set {
                StaffGrossSalary = (int)( value + (value * 0.6 ));
            }
        }
        public void StaffRegister() {
            Console.Write("Please enter your full name: ");
            string[] temp = Console.ReadLine().Split();
            for ( int i = 0; i < temp.Length-1; i++ ) {
                StaffName += temp[i]+" ";
            }
            StaffSurname = temp[temp.Length-1];
            Console.Write("Please enter your net salary: ");
            StaffNetSalary = int.Parse(Console.ReadLine());
            Console.WriteLine();
            ArrayStaffInfo.Add(StaffID); ArrayStaffInfo.Add(StaffName); ArrayStaffInfo.Add(StaffSurname); ArrayStaffInfo.Add(StaffGrossSalary);
            StaffName = "";
            StaffID++;
        }
        public void StaffList() {
            Console.WriteLine("\nStaff ID".PadLeft(10)+"Staff Name".PadLeft(15) + "Staff Gross Salary(TL)".PadLeft(30));
            for ( int i = 0; i < ArrayStaffInfo.Count; i+=4 ) {
                Console.WriteLine((ArrayStaffInfo[i].ToString().PadLeft(3)).PadRight(15) + (ArrayStaffInfo[i + 1] + ArrayStaffInfo[i + 2].ToString().ToUpper()).PadRight(27) + ArrayStaffInfo[i + 3].ToString());
            }
        }
        public double TotalDouble(short a, short b, short c) {
            return (double) a + b + c;
        }
    }
}
