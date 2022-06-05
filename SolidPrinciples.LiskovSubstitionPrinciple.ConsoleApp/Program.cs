using System;

namespace SolidPrinciples.LiskovSubstitionPrinciple.ConsoleApp
{
    //Olmaması gereken;

  /*  public class Elma
    {
        public virtual string RenkGetir()
        {
            return "Yesil";
        }
    }
    public class Portakal
    {
        public virtual string RenkGetir()
        {
            return "Turuncu";
        }
    }*/

    //Olması gereken,
    public interface IMeyve
    {
        public string RenkGetir();

    }
    public class Elma : IMeyve
    {
        public string RenkGetir()
        {
            return "Yesil";
        }
    }
    public class Portakal:IMeyve
    {
        public string RenkGetir()
        {
            return "Turuncu";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Elma elma = new Portakal(); //hata verir
            //Console.WriteLine(apple.GetColor()); 

            IMeyve meyve = new Elma();
            Console.WriteLine(meyve.RenkGetir()); 

        }
    }
}
