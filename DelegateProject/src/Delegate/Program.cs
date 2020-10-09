using System;

delegate int NumberChanger(int n);
namespace Delegate{
   class TestDelegate {
      static int num = 10;
      
      public static int AddNum(int p) {
         num += p;
         return num;
      }
      public static int MultNum(int q) {
         num *= q;
         return num;
      }
      public static int getNum() {
         return num;
      }
   }
class Program{
      static void Main(string[] args) {
         //create delegate instances
         NumberChanger nc;
         NumberChanger nc1 = new NumberChanger(TestDelegate.AddNum);
         NumberChanger nc2 = new NumberChanger(TestDelegate.MultNum);
         
         nc = nc1;
         nc += nc2;
         
         //calling multicast
         nc(5);
         Console.WriteLine("Value of Num: {0}", TestDelegate.getNum());
         Console.ReadKey();
      }
}

   
}