using System;
using System.Collections;

namespace Console14 {
   class Program {
      static void Main(string[] args) {
         //ClassRandom.Number n1 = new ClassRandom.Number();
         //Console.WriteLine(n1.RNumber);
         //n1.Change();
         //Console.WriteLine(n1.RNumber);

         //PersonalInformation pInfo = new PersonalInformation();
         //pInfo.Name = "Smart"; pInfo.Surname = "Pro"; pInfo._ageInfo.Age = 22;
         //pInfo.Write();

         //Teacher teach = new Teacher();
         //teach.WriteInfo();

         //ChildClass childClass = new ChildClass();
         //childClass.Number = 55; childClass.Text = "Merhaba"; childClass.ChildNumber = 44; childClass.ChildText = "Dünya";
         //childClass.Write(); childClass.ChildWrite();

         //Automative personal = new Automative(6,1,2,1400,3,"AE86",true,false);
         //Console.WriteLine();
         //Commertial commertial = new Commertial(10,3,1,2000,1500,50,true);

         //Admin admin = new Admin("Smart",Zones.Programming,22,10);

         //Flower flow = new Flower("Rose", true, Colors.Red, 15);
         //flow.InfoList();
         //Console.WriteLine();
         //Vegitable vegi = new Vegitable("Onion", true, ProductionPlace.Ankara);
         //vegi.InfoList();

         //SpecialCourse spcour = new SpecialCourse("SmartPro","Kadıköy",Types.Private,"Mehmet Demir",Subjects.Programming);
         //Console.WriteLine(spcour.FindTeacher(101));

         Residence res = new Residence("Adres1","Hall1",300,true,2,1,1);
         Merchant mer = new Merchant("Adres2", "Hall2", 500, true, false, 3);
         Console.WriteLine();
         Console.WriteLine();
         res.ListStuff(0);
         mer.ListStuff(0);

         Console.ReadKey();
      }
   }

   class Estate {
      public string EstateAdress, EstateCityHall, EstateType; public int EstateM2; public byte EstateTaxPerM2=0, a = 0; public bool EstateSelfContained;
      public ArrayList EstateList = new ArrayList();

      public Estate(string eadress, string ecityhall, int em2, bool eselfcont) {
         EstateAdress = eadress; EstateCityHall = ecityhall; EstateM2 = em2; EstateSelfContained = eselfcont;
      }

      public void ListStuff(int index) {
         for ( int i = 0; i < EstateList.Count; i++ ) {
            int temp = EstateList.IndexOf("Entry"+ index);

            if ( temp < 0 ) { Console.WriteLine("You shoudnt be here get out."); break; }
            else if ( EstateList[temp + 1].ToString() == "Residence" ) {
               Console.WriteLine("-------");
               Console.WriteLine($"Estate Features\nEstate Adress: {EstateList[temp + 2]}\nEstate City Hall: {EstateList[temp + 3]}\nEstate Self-Contained: {EstateList[temp + 4]}\nEstate M2: {EstateList[temp + 5]}");
               Console.WriteLine($"\nResidence Features\nResidence Room Count: {EstateList[temp + 6]}\nResidence Living Room: {EstateList[temp + 7]}\nResidence Bathroom: {EstateList[temp + 8]}");
               Console.WriteLine($"Tax Per Year: {Convert.ToInt32(EstateList[temp + 5]) * 5}TL");
               Console.WriteLine("-------");
               break;
            }
            else if ( EstateList[temp + 1].ToString() == "Merchant" ) {
               Console.WriteLine("-------");
               Console.WriteLine($"Estate Features\nEstate Adress: {EstateList[temp + 2]}\nEstate City Hall: {EstateList[temp + 3]}\nEstate Self-Contained: {EstateList[temp + 4]}\nEstate M2: {EstateList[temp + 5]}");
               Console.WriteLine($"\nMerchant Features\nMerchant Room Count: {EstateList[temp + 6]}\nMerchant Kitchen: {EstateList[temp + 7]}");
               Console.WriteLine($"Tax Per Year: {Convert.ToInt32(EstateList[temp + 5]) * 5}TL");
               Console.WriteLine("-------");
               break;
            }
            else {
            }
         }
      }
   }

   class Residence : Estate {
      int ResRoomNumber, ResLivingRoom, ResBathroomNumber;

      public Residence(string eadress, string ecityhall, int em2, bool eselfcont, int rroom, int rliving, int rbath) : base(eadress, ecityhall, em2, eselfcont) {
         ResRoomNumber = rroom; ResLivingRoom = rliving; ResBathroomNumber = rbath;
         EstateTaxPerM2 = 2; EstateType = "Residence";
         AddList();
      }

      public void AddList() {
         EstateList.Add("Entry"+a); EstateList.Add(EstateType);
         EstateList.Add(EstateAdress); EstateList.Add(EstateCityHall); EstateList.Add(EstateSelfContained); EstateList.Add(EstateM2);
         EstateList.Add(ResRoomNumber); EstateList.Add(ResLivingRoom); EstateList.Add(ResBathroomNumber);
         a++;
      }
   }
   class Merchant : Estate {
      bool MerKitchen; int MerRow;

      public Merchant(string eadress, string ecityhall, int em2, bool eselfcont, bool mkitch, int mrow) : base(eadress, ecityhall, em2, eselfcont) {
         MerKitchen = mkitch; MerRow = mrow;
         EstateTaxPerM2 = 5; EstateType = "Merchant";
         AddList();
      }
      public void AddList() {
         EstateList.Add("Entry"+a); EstateList.Add(EstateType);
         EstateList.Add(EstateAdress); EstateList.Add(EstateCityHall); EstateList.Add(EstateSelfContained); EstateList.Add(EstateM2);
         EstateList.Add(MerRow); EstateList.Add(MerKitchen);
         a++;
      }
   }

   //enum Types: byte { Goverment, Private}
   //enum Subjects: byte { ForeignLanguage, Swimming, Programming, Accounting, DriversLicence }

   //class EducationalInstutute {
   //   string InstututeName, InstututeAdress; Types InstututeType;

   //   public EducationalInstutute(string name, string adress, Types type) { InstututeName = name; InstututeAdress = adress; InstututeType = type; }
   //}
   //class SpecialCourse : EducationalInstutute {
   //   public string CourseOwner; Subjects CourseSubject; ArrayList CourseTeacherList = new ArrayList();

   //   public SpecialCourse(string name, string adress, Types type, string cowner, Subjects csubject) : base(name, adress, type) {
   //      CourseOwner = cowner; CourseSubject = csubject;
   //      AddTeacher();
   //   }
   //   public void AddTeacher() {
   //      Console.Write("How many teachers you want to add: "); int temp = int.Parse(Console.ReadLine());
   //      for ( int i = 0; i < temp; i++ ) {
   //         Console.Write("Teacher full name: "); CourseTeacherList.Add(Console.ReadLine());
   //         Console.Write("Teacher ID number: "); CourseTeacherList.Add(int.Parse(Console.ReadLine()));
   //      }
   //      ListTeacher();
   //   }
   //   public void ListTeacher() {
   //      Console.WriteLine();
   //      for ( int i = 0; i < CourseTeacherList.Count; i+=2 ) Console.WriteLine($"ID Number: {CourseTeacherList[i + 1]} | Name: {CourseTeacherList[i]}");
   //   } 
   //   public string FindTeacher(int idnumb) { return $"\nTeacher Searcing Results:\nID Number: {idnumb} | Name: {CourseTeacherList[CourseTeacherList.IndexOf(idnumb)-1]}"; }
   //}

   //enum ProductionPlace : byte { Antalya, Tekirdağ, Muğla, Mersin, Adana, Tokat, Çanakkale, Manisa, İzmir, Aydın, Ankara }
   //enum Colors: byte { Yellow, Red, Pink, Purple, Orange, Mixed, Blue, White }

   //class Plant {
   //   public string PlantName; public bool Unique;

   //   public Plant(string plantname, bool unique) {
   //      PlantName = plantname; Unique = unique;
   //   }
   //}

   //class Flower: Plant {
   //   public Colors FlowerColor; public int Price;
   //   ArrayList Traders = new ArrayList();

   //   public Flower(string plantname, bool unique, Colors flowercolor, int price) : base(plantname, unique) {
   //      FlowerColor = flowercolor; Price = price;
   //      Console.Write("How many traders are selling this product: ");
   //      int tcount = int.Parse(Console.ReadLine());
   //      TraderAdd(tcount);
   //   }

   //   public void TraderAdd(int tcount) {
   //      for ( int i = 0; i < tcount; i++ ) {
   //         Console.Write("Please enter the shop name: ");
   //         Traders.Add(Console.ReadLine());
   //         Console.Write("Please enter the shop adress: ");
   //         Traders.Add(Console.ReadLine());
   //      }
   //      Console.WriteLine();
   //   }

   //   public void TradersList() {
   //      Console.WriteLine();
   //      for ( int i = 0; i < Traders.Count; i+=2 ) {
   //         Console.WriteLine($"Shop Name: {Traders[i]}\nShop Adress: {Traders[i+1]}\n");
   //      }
   //   }

   //   public void InfoList() {
   //      Console.WriteLine($"Name: {PlantName}\nColor: {FlowerColor}\nIsUnique: {Unique}\nPrice: {Price}$");
   //      TradersList();
   //   }
   //}
   //class Vegitable: Plant {
   //   ProductionPlace PPlace;

   //   ArrayList Traders = new ArrayList();

   //   public Vegitable(string plantname, bool unique, ProductionPlace product) : base(plantname, unique) {
   //      PPlace = product;
   //      Console.Write("How many traders are selling this product: ");
   //      int tcount = int.Parse(Console.ReadLine());
   //      TraderAdd(tcount);
   //   }

   //   public void TraderAdd(int tcount) {
   //      for ( int i = 0; i < tcount; i++ ) {
   //         Console.Write("Please enter the shop name: ");
   //         Traders.Add(Console.ReadLine());
   //         Console.Write("Please enter the shop adress: ");
   //         Traders.Add(Console.ReadLine());
   //      }
   //      Console.WriteLine();
   //      TradersList();
   //   }

   //   public void TradersList() {
   //      Console.WriteLine($"Name: {PlantName}\nIsUnique: {Unique}\nProduction Place: {PPlace}");
   //      Console.WriteLine();
   //      for ( int i = 0; i < Traders.Count; i += 2 ) {
   //         Console.WriteLine($"Shop Name: {Traders[i]}\nShop Adress: {Traders[i + 1]}\n");
   //      }
   //   }
   //   public void InfoList() {
   //      Console.WriteLine($"Name: {PlantName}\nIsUnique: {Unique}\nProduction Place: {PPlace}");
   //      TradersList();
   //   }
   //}
   //enum Zones : byte { Programming, HumanRelationships, InformationTechnologies, Accounting, Law, Purchasing }

   //class StaffList {
   //   public string StaffName; public int StaffAge; Zones StaffZone;

   //   public StaffList(string stfname, Zones stfzone, int age) {
   //      StaffName = stfname; StaffZone = stfzone; StaffAge = age;
   //   }
   //}
   //class Admin : StaffList {
   //   public int StaffCount;

   //   public Admin(string stfname, Zones stfzone, int age, int stfcnt) : base(stfname, stfzone, age) {
   //      StaffCount = stfcnt;
   //   }
   //}

   //enum Models : byte { Honda = 1, Mazda, Ford, Mercedes, Renault, Toyota, Lamborghini, Ferrari, Scania, Volvo }
   //enum Gears : byte { Manual = 1, Automatic, SemiAutomatic }
   //enum Colors : byte { Black = 1, White, Red, Orange, Yellow, Purple, Green }

   //class CarX {
   //   public byte Brand, Gear, Color; protected int EngineCap;

   //   public CarX(byte brand, byte gear, byte color, int engineCap) {
   //      Brand = brand; Gear = gear; Color = color; EngineCap = engineCap;
   //   }
   //}

   //class Automative : CarX {
   //   public byte DoorCount; public string Model; public bool ParkingSensor, FourWD;

   //   public Automative(byte brand, byte gear, byte color, int engineCap, byte doorcount, string model, bool sensor, bool fwd) : base(brand, gear, color, engineCap) {
   //      DoorCount = doorcount; Model = model; ParkingSensor = sensor; FourWD = fwd;
   //      AutomativeAdd();
   //   }
   //   public void AutomativeAdd() {
   //      Console.WriteLine($"Brand: {Enum.GetName(typeof(Models), Brand)}\nModel: {Model}\nGear: {Enum.GetName(typeof(Gears), Gear)}\nColor: {Enum.GetName(typeof(Colors), Color)}\nEngine Cap: {EngineCap}\nDoor Count: {DoorCount}\nParking Sensor: {ParkingSensor}\nFour Wheel Drive: {FourWD}");
   //   }
   //}

   //class Commertial : CarX {
   //   public int CarryCap, PassengerCap; public bool FourWD;

   //   public Commertial(byte brand, byte gear, byte color, int engineCap, int carrycap, int passengercap, bool fwd) : base(brand, gear, color, engineCap) {
   //      CarryCap = carrycap; PassengerCap = passengercap; FourWD = fwd;
   //      CommertialAdd();
   //   }
   //   public void CommertialAdd() {
   //      Console.WriteLine($"Brand: {Enum.GetName(typeof(Models), Brand)}\nGear: {Enum.GetName(typeof(Gears), Gear)}\nColor: {Enum.GetName(typeof(Colors), Color)}\nEngine Cap: {EngineCap}\nCarry Cap: {CarryCap}\nPassenger Cap: {PassengerCap}\nFour Wheel Drive: {FourWD}");
   //   }
   //}

   //class ParentClass {
   //   public string Text; public int Number;

   //   public void Write() {
   //      Console.WriteLine($"Number: {Number} | Text: {Text}");
   //   }
   //}
   //class ChildClass : ParentClass {
   //   public int ChildNumber; public string ChildText;

   //   public void ChildWrite() {
   //      Console.WriteLine($"Number: {ChildNumber} | Text: {ChildText}");
   //   }
   //}

   //class Teacher {
   //   public string TeacherFullName; public byte TeacherAge;
   //   public Classes _Cls = new Classes();

   //   public void WriteInfo() {
   //      TeacherFullName = "Mehmet Demir"; TeacherAge = 30; _Cls.ClassNumber = 723726; _Cls.ClassroomNumber = 404; _Cls.ClassSubject = "Web ve Mobil Programlama";
   //      Console.WriteLine($"Teacher Name: {TeacherFullName}\nTeacher Age: {TeacherAge}\nClass Number: {_Cls.ClassNumber}\nClassroom Number: {_Cls.ClassroomNumber}\nClass Subject: {_Cls.ClassSubject}");
   //   }
   //}
   //class Classes {
   //   public int ClassNumber, ClassroomNumber; public string ClassSubject;
   //}


   //class PersonalInformation {
   //   public string Name, Surname;
   //   public static PersonalAgeInformation _ageInfo = new PersonalAgeInformation();

   //   public void Write() {
   //      Console.WriteLine($"{Name} {Surname} {_ageInfo.Age}");
   //   }
   //}
   //class PersonalAgeInformation {
   //   public int Age;
   //}
}
