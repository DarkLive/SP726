using System;

namespace ClassRandom {
   public class Number {
      public Random Rnd = new Random();
      public int RNumber;

      public Number(){
         RNumber = Rnd.Next(1, 101);
      }
      public void Change() {
         RNumber = Rnd.Next(1, 101);
      }
   }
}
