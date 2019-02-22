using System;

namespace Console15 {
   class Program {
      //public static void MakeNoise(Animal anm) { anm.MakeNoise(); }
      //public static void CalcDiscountPrice(Electronics elec, double discount = 0) { elec.CalcDiscountPrice(discount); }
      //public static void ShowSpecs (Computer comp) { comp.ShowSpecs(); }
      static void Main(string[] args) {
         //Animal an = new Animal();
         //Cat cat = new Cat();
         //Chicken chick = new Chicken();

         //MakeNoise(an); MakeNoise(cat); MakeNoise(chick);
         //an.MakeNoise(); cat.MakeNoise(); chick.MakeNoise();

         //DishWashingMachine disher = new DishWashingMachine("LG",3,1500,EnergyClass.A,"Something",6);
         //Minioven mini = new Minioven("Samsung",3,2000,EnergyClass.A,"Mini2000",4);
         //CalcDiscountPrice(disher, 15);
         //CalcDiscountPrice(mini, 25);

         //Computer magicbox = new Computer("Dark","AMD FX8320","16GB");
         //Laptop magictablet = new Laptop("Microsoft","Intel i7 8700K","8GB",false,true);
         //ShowSpecs(magicbox); ShowSpecs(magictablet);

         //Tool tl = new Tool();
         //tl.SetBrand("Toyota");
         ////Console.WriteLine(tl.GetBrand());

         //tl.M_EngineCap = 2000;
         //Console.WriteLine(tl.M_EngineCap);

         //Worker wrk = new Worker();
         //wrk.Name = "Smart"; wrk.Age = 5;
         //wrk.WriteName();

         //Console.WriteLine();
         //Crow crw = new Crow();
         //crw.Breed = "Flores Crow"; crw.Color = "Black"; crw.WingLength = 10;
         //crw.BirdBreedName = "asd"; 
         //crw.CalcDistance(50, 100);
         //Goose gogs = new Goose();
         //gogs.Breed = "Emden Goose"; gogs.Color = "White"; gogs.WingLength = 10;
         //gogs.CalcDistance(20, 100);

         //Orange org = new Orange();
         //org.Color = "Orange"; org.Taste = "Sweet"; org.Weight = 5; org.Price = 10;
         //Console.WriteLine($"Color: {org.Color}\nTaste: {org.Taste}\nWeight: {org.Weight}\nPrice: {org.Price}");

         //Audi aud = new Audi();
         //aud.VehicleName = "Car"; aud.VehiceType = "Automobile";
         //aud.TypeWrite();

         //Toshiba tsh = new Toshiba();
         //tsh.ReviewProduct(5); tsh.ReviewProduct(2); tsh.ReviewProduct(3);
         //tsh.Brand = "Toshiba"; tsh.Resolution = "1920x1080"; tsh.ScreenSize = 32; tsh.Receiver = false; tsh.Price = 3000;
         //tsh.ShowSpecs();
         //Console.WriteLine();
         //tsh.ShowReviews();

         DateTime dTime = DateTime.Now;
         Console.WriteLine($"Day: {dTime.Day}\nMonth: {dTime.Month}\nYear: {dTime.Year}");


         Console.ReadKey();
      }
   }

   //interface IDisplayandSound {
   //   string Brand { get; set; }
   //   int Price { get; set; }
   //   int Reviews { get; set; }

   //   double TotalReview { get; set; }
   //   double TotalPoint { get; set; }

   //   void ReviewProduct(byte points);
   //   void ShowReviews();
   //   void ShowSpecs();
   //}
   //interface ITelevision: IDisplayandSound {
   //   string Resolution { get; set; }
   //   byte ScreenSize { get; set; }
   //   bool Receiver { get; set; } 
   //}

   //class Toshiba: ITelevision {
   //   private string TBrand, TResolution; private int TPrice, TReviews; private byte TScreenSize; private bool TReceiver;
   //   public string Brand { get { return TBrand; } set { TBrand = value; } }
   //   public int Price { get { return TPrice; } set { TPrice = value; } }
   //   public int Reviews { get { return TReviews; } set { TReviews = value; } }
   //   public string Resolution { get { return TResolution; } set { TResolution = value; } }
   //   public byte ScreenSize { get { return TScreenSize; } set { TScreenSize = value; } }
   //   public bool Receiver { get { return TReceiver; } set { TReceiver = value; } }

   //   private double TTotalReview, TTotalPoint;
   //   public double TotalReview { get { return TTotalReview; } set { TTotalReview = value; } }
   //   public double TotalPoint { get { return TTotalPoint; } set { TTotalPoint = value; } }

   //   public void ReviewProduct(byte point) {
   //      Reviews = point; TotalPoint += point; TotalReview++;
   //   }
   //   public void ShowReviews() {
   //      Console.WriteLine($"Rating: { Math.Round(TotalPoint / TotalReview, 1)}");
   //   }
   //   public void ShowSpecs() {
   //      Console.WriteLine($"Brand: {Brand}\nResoulution: {Resolution}\nScreen Size: {ScreenSize}\nReceiver: {Receiver}\nPrice: {Price}");
   //   }
   //}

   //interface IVehicle {
   //   string VehicleName { get; set; }
   //}

   //interface IWheels4 {
   //   string VehiceType { get; set; }

   //   void TypeWrite();
   //}

   //class Audi : IVehicle, IWheels4 {
   //   private string CCarName, CCarType;
   //   public string VehicleName { get { return CCarName; } set { CCarName = value; } }
   //   public string VehiceType { get { return CCarType; } set { CCarType = value; } }

   //   public void TypeWrite() {
   //      Console.WriteLine($"Car Name: {VehicleName}\nCar Type: {VehiceType}");
   //   }
   //}

   //interface ITemplate0 { string Color { get; set; } string Taste { get; set; } }
   //interface ITemplate1:ITemplate0 { int Weight { get; set; } int Price { get; set; } }

   //class Orange : /*ITemplate0,*/ ITemplate1 {
   //   private string OColor, OTaste; private int OWeight, OPrice;
   //   public string Color { get { return OColor; } set { OColor = value; } }
   //   public string Taste { get { return OTaste; } set { OTaste = value; } }
   //   public int Weight { get { return OWeight; } set { OWeight = value; } }
   //   public int Price { get { return OPrice; } set { OPrice = value; } }
   //}

   //abstract class Bird {
   //   public abstract string Breed { get; set; } public abstract string Color { get; set; }  public abstract int WingLength { get; set; }
   //   public string BirdBreedName = "Chicken";
   //   public abstract void CalcDistance(int speed, int distance);

   //}
   //class Crow : Bird {
   //   private string B_Breed, B_Color; private int B_WingLength; public new string BirdBreedName = "Crow";
   //   public override string Breed { get { return B_Breed; } set { B_Breed = value; } }

   //   public override string Color { get { return B_Color; } set { B_Color = value; } }

   //   public override int WingLength { get { return B_WingLength; } set { B_WingLength = value; } }

   //   public override void CalcDistance(int speed, int distance) { Console.WriteLine($"{BirdBreedName} {Color} {Breed} could fly {distance}km distance in {distance / speed} hours."); }
   //}
   //class Goose : Bird {
   //   private string B_Breed, B_Color; private int B_WingLength; public new string BirdBreedName = "Goose";
   //   public override string Breed { get { return B_Breed; } set { B_Breed = value; } }

   //   public override string Color { get { return B_Color; } set { B_Color = value; } }

   //   public override int WingLength { get { return B_WingLength; } set { B_WingLength = value; } }

   //   public override void CalcDistance(int speed, int distance) { Console.WriteLine($" {Color} {Breed} cant fly but it could walk {distance}km distance in {distance / speed} hours."); }
   //}

   //abstract class Person {
   //   public abstract string Name { get; set; }
   //   public int Age;
   //   public abstract void WriteName();
   //}

   //class Worker : Person {
   //   public override string Name { get { return W_Name; } set { W_Name = value; } }
   //   private string W_Name;
   //   public override void WriteName() {
   //      Console.WriteLine($"Worker Name: {W_Name}\nAge: {Age}");
   //   }
   //}

   //enum Brands : byte { Honda, Mazda, Toyota,Tesla,Audi }

   //class Tool {
   //   private string Brand;

   //   public string GetBrand() {
   //      return Brand;
   //   }

   //   public void SetBrand(string brand) {
   //      if ( Enum.IsDefined(typeof(Brands), brand) ) Brand = brand;
   //      else Brand = "Not Defined";
   //   }
   //   private int EngineCap;
   //   public int M_EngineCap { get { return EngineCap; } set { if ( value > 1400 ) EngineCap = value; else EngineCap = 1400; } }
   //   }

   //class Computer {
   //   public string Brand, CPU, RAM;

   //   public Computer(string brand, string cpu, string ram) {
   //      Brand = brand; CPU = cpu; RAM = ram;
   //   }

   //   public virtual void ShowSpecs() {
   //      Console.WriteLine($"Brand: {Brand}\nCPU: {CPU}\nRAM: {RAM}\n");
   //   }
   //}
   //class Laptop: Computer {
   //   public bool Bluetooth, WiFi;

   //   public Laptop(string brand, string cpu, string ram, bool bluetooth, bool wifi) : base(brand, cpu, ram) {
   //      Bluetooth = bluetooth; WiFi = wifi;
   //   }
   //   public override void ShowSpecs() {
   //      Console.WriteLine($"Brand: {Brand}\nCPU: {CPU}\nRAM: {RAM}\nBluetooth: {Bluetooth}\nWi-Fi: {WiFi}\n");
   //   }
   //}


   //enum EnergyClass : byte { A, B, C, D, E }
   //enum OvenTypes : byte { Microwave, MiniOven, DrumOven, StandardOven }

   //class Electronics {
   //   public string Brand; public int WarrantyTime, Price; EnergyClass EClass;

   //   public Electronics(string brand, int wartime, int price, EnergyClass eclass) {
   //      Brand = brand; WarrantyTime = wartime; Price = price; EClass = eclass;
   //   }

   //   public virtual void CalcDiscountPrice(double discount) {
   //      Console.WriteLine($"{Price} => {Price - ( Price * ( discount / 100 ) )}");
   //   }
   //}
   //class DishWashingMachine : Electronics {
   //   public string Model; public int Module;

   //   public DishWashingMachine(string brand, int wartime, int price, EnergyClass eclass, string model, int module) : base(brand, wartime, price, eclass) {
   //      Model = model; Module = module;
   //   }
   //   public override void CalcDiscountPrice(double discount) {
   //      Console.WriteLine($"{Price} => {Price - (Price * ( discount / 100 ))}");
   //   }
   //}
   //class Oven : Electronics {
   //   public Oven(string brand, int wartime, int price, EnergyClass eclass, string model, int module) : base(brand, wartime, price, eclass) {
   //   }

   //   public override void CalcDiscountPrice(double discount) {
   //      Console.WriteLine($"{Price} => {Price - ( Price * ( discount / 100 ) )}");
   //   }
   //}
   //class Minioven : Oven {
   //   public Minioven(string brand, int wartime, int price, EnergyClass eclass, string model, int module) : base(brand, wartime, price, eclass, model, module) {
   //   }

   //   public override void CalcDiscountPrice(double discount) {
   //      Console.WriteLine($"{Price} => {Price - ( Price * ( discount / 100 ) )}");
   //   }
   //}


   //class Animal {
   //   public virtual void MakeNoise() {
   //      Console.WriteLine("Animal sounds are diffirent.");
   //   }
   //}
   //class Cat : Animal {
   //   public override void MakeNoise() {
   //      Console.WriteLine("Meow Meow");
   //   }
   //}
   //class Chicken : Animal {
   //   public override void MakeNoise() {
   //      Console.WriteLine("Bwak Bwak Bwaaak");
   //   }
   //}
}
