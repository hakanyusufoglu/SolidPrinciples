using System;

namespace SolidPrinciples.OpenClosedPrinciple.ConsoleApp
{
    //Olmaması gereken;
    /*public enum DosyaTipi
    {
        Word,
        Pdf,
        Txt
    }
    public class DosyaIslemleri
    {
        public void DosyaYarat(DosyaTipi dosyaTipi)
        {
            switch (dosyaTipi)
            {
                case DosyaTipi.Word:
                    //word
                    break;
                case DosyaTipi.Pdf:
                    //pdf
                    break;
                case DosyaTipi.Txt:
                    //txt
                    break;
            }
        }
    }*/

    public abstract class Dosya
    {
        public abstract void DosyaYarat();
       
    }
    public class Word : Dosya
    {
        public override void DosyaYarat()
        {
            //kodlar
        }
    }
    public class Pdf : Dosya
    {
        public override void DosyaYarat()
        {
            //kodlar
        }
    }
    public class Txt : Dosya
    {
        public override void DosyaYarat()
        {
            //kodlar
        }
    }
    public class Ppt : Dosya
    {
        public override void DosyaYarat()
        {
            //kodlar
        }
    }
    //Olması gereken,
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
