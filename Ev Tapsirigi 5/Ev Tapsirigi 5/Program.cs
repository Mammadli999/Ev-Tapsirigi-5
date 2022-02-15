using System;
using ClassLibrary1;

namespace Ev_Tapsirigi_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Phones";

            int len;
            l1:
            len = Monitor.ReadInteger("Nece Telefon Olsun: ");
            if (len <= 0)
            {
                goto l1;
            }
            Phone[] phones = new Phone[len];

            for (int i = 0; i < len; i++)
            {
                Phone phone = new Phone();

                Console.WriteLine($"{i+1} Telefon Xususiyyetleri: ");

                phone.Model = Monitor.ReadString("Model: ");
                phone.Producer = Monitor.ReadString("Istehsalatci: ");
                phone.MainCamera = Monitor.ReadInteger("Esas Kamera: ");
                phone.Ram = Monitor.ReadInteger("Ram: ");
                phone.Memory = Monitor.ReadInteger("Yaddas: ");
                phone.ProductionYear = Monitor.ReadInteger("Buraxilis Ili: ");
                phone.OperatingSystem = Monitor.ReadString("Emeliyyat Sistemi: ");
                phone.BatteryCapacity = Monitor.ReadInteger("Batareya Tutumu: ");
                phone.Price = Monitor.ReadDouble("Qiymet: ");

                phones[i]=phone;

                Console.WriteLine("***************************");
            }

            Console.WriteLine("-------------List of Phones--------------");

            foreach (var item in phones)
            {
                Console.WriteLine(item);
                Console.WriteLine("++++++++++++++++++++++");
            }

            Console.ReadKey();
        }
    }
}
