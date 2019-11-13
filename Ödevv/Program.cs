using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ödevv
{
    class Program
    {
        static void Main(string[] args)
        {
            Hiz(80);
        }

        public static void Hiz(int i)
        {
            CargoVehicle kargo_aracı1 = new CargoVehicle("42AC123");
            kargo_aracı1.Marka = "Fiat";
            kargo_aracı1.SpeedExceeded += new CargoVehicle.SpeedHandler(Kargo_aracı_SpeedExceeded);

            CargoVehicle kargo_aracı2 = new CargoVehicle("06CD456");
            kargo_aracı2.Marka = "Peuegot";
            kargo_aracı2.SpeedExceeded += new CargoVehicle.SpeedHandler(Kargo_aracı_SpeedExceeded);

            int j = 0;
            for (; i < 130; i += 5)
            {
                kargo_aracı1.Speed = i;
                kargo_aracı2.Speed = (byte)(i + j);
                Console.WriteLine(kargo_aracı1.Plaka + " Plakalı aracın hızı : " + kargo_aracı1.Speed);
                Console.WriteLine(kargo_aracı2.Plaka + " Plakalı aracın hızı : " + kargo_aracı2.Speed + "\n");
                //Thread.Sleep(1000);
                Console.ReadLine();
                j += 3;
            }
        }

        public static void Kargo_aracı_SpeedExceeded(CargoVehicle vehicle)
        {
            Console.WriteLine("Alarm: " + vehicle.Plaka
                                        + " plakalı " + vehicle.Marka
                                        + " marka araç hız limitini aştı: "
                                        + DateTime.Now
                                        + " anındaki hızı: "
                                        + vehicle.Speed);
        }
    }
}