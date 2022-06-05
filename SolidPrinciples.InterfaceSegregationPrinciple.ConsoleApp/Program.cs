using System;

namespace SolidPrinciples.InterfaceSegregationPrinciple.ConsoleApp
{
    //Olmaması gereken;
  /*  public interface IFutbolcu
    {
        public void TopuTut();
        public void TopaVur();
    }
    public class KaleOyuncusu : IFutbolcu
    {
        
        public void TopaVur()
        {
            //Kodlar
        }

        public void TopuTut()
        {
            //Kodlar
        }
    }
    public class SahaOyuncusu : IFutbolcu
    {
        
        public void TopaVur()
        {
            //Kodlar
        }

        public void TopuTut()
        {
            //Kodlar
        }
    }*/
    //Olması gereken,

    public interface IKaleci
    {
        public void TopuTut();
        public void TopuVur();
    }
    public interface IFutbolcu
    {
        public void TopuVur();
    }
    public class Kaleci : IKaleci
    {
        public void TopuTut()
        {
            //kodlar
        }

        public void TopuVur()
        {
            //kodlar
        }
    }
    public class SahaOyuncusu : IFutbolcu
    {
        public void TopuVur()
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
