using System;

namespace SolidPrinciples.SingleResponsiblity.ConsoleApp
{
    //Olmaması gereken;
    /*  public class Matematik
      {
          public void Topla()
          {
              //kodlar
          }
          public void Cikar()
          {
              //kodlar
          }
          public void Carp()
          {
              //kodlar
          }
          public void CumleOlustur()
          {
              //problem
          }
      }*/
    //Olması gereken,
    public class Matematik
    {
        public void Topla()
        {
            //kodlar
        }
        public void Cikar()
        {
            //kodlar
        }
        public void Carp()
        {
            //kodlar
        }
       
    }
    public class Turkce
    {
        public void CumleOlustur()
        {
            //kodlar
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
