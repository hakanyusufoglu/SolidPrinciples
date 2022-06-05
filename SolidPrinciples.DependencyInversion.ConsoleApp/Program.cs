using System;

namespace SolidPrinciples.DependencyInversion.ConsoleApp
{
    //Olmaması gereken;
  /*  public class Hatirlatici
    {
        public void HatirlaticiDoldu()
        {
            //kodlar
        }
    }
    public class Sms
    {
        public void SmsGonder()
        {
            //kodlar
        }
    }
    public class Bildirim
    {
        Hatirlatici hatirlatici = new Hatirlatici();
        Sms sms = new Sms();
        public void BildirimGonder()
        {
            hatirlatici.HatirlaticiDoldu();
            sms.SmsGonder();//bağımlılık 
        }
    }

    */
    //Olması gereken,

    public interface IBildirim
    {
        public void BildirimGonder();

    }
    public class Hatirlatici : IBildirim
    {
        public void BildirimGonder()
        {
           //kodlar
        }

        public void HatirlaticiDoldu()
        {
            //kodlar
        }
    }
    public class Sms:IBildirim
    {
        public void BildirimGonder()
        {
            //kodlar
        }

        public void SmsGonder()
        {
            //kodlar
        }
    }
    public class Bildirim
    {
        IBildirim _bildirim;
        public Bildirim(IBildirim bildirim)
        {
            _bildirim = bildirim;
            
        }
        public void Gonder()
        {
            _bildirim.BildirimGonder();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bildirim bildirim = new Bildirim(new Hatirlatici());
            bildirim.Gonder();
        }
    }
}
