using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ev_Tapsirigi_5
{
    internal class Phone
    {
        public int Id;
        public string Model;
        public string Producer;
        public int MainCamera;
        public int Ram;
        public int Memory;
        public int ProductionYear;
        public string OperatingSystem;
        public int BatteryCapacity;
        public double Price;
        static int counter = 0;

        public Phone()
        {
            counter++;
            Id = counter;
        }
        public override string ToString()
        {
            return $"Telefon: {Id}\n" +
                $"Model: {Model}\n" +
                $"Istehsalci: {Producer}\n" +
                $"Esas Kamera: {MainCamera}\n" +
                $"Ram: {Ram}\n" +
                $"Yaddas: {Memory}\n" +
                $"Buraxilis ili: {ProductionYear}\n" +
                $"Emeliyyat Sistemi: {OperatingSystem}\n" +
                $"Batareya Tutumu: {BatteryCapacity}\n" +
                $"Qiymet:{Price}";
        }
    }
}
