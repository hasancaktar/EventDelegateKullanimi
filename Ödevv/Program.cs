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

            Hiiiz(85);
        }

        public static void Hiiiz(int i)
        {
            CargoVehicle kargo_aracı1 = new CargoVehicle();
            kargo_aracı1.plaka = "42AC123";
            kargo_aracı1.SpeedExceeded += new SpeedHandler(Kargo_aracı1_SpeedExceeded);


            CargoVehicle kargo_aracı2 = new CargoVehicle();
            kargo_aracı2.plaka = "06CD456";
            kargo_aracı2.SpeedExceeded += new SpeedHandler(Kargo_aracı2_SpeedExceeded);

            int j = 0;
            for ( ; i < 130; i += 5)
            {
                kargo_aracı1._hizz = i;

                kargo_aracı1.hiz = i;
                kargo_aracı2.hiz = (byte)(i + j);
                Console.WriteLine(kargo_aracı1.plaka + " Plakalı aracın hızı : " + kargo_aracı1.hiz);
                Console.WriteLine(kargo_aracı2.plaka + " Plakalı aracın hızı : " + kargo_aracı2._hizz + "\n");
                //Thread.Sleep(1000);

                

                Console.ReadLine();
                j += 3;
            }
        }

        public static void Kargo_aracı1_SpeedExceeded()
        {
            CargoVehicle kargo_aracı1 = new CargoVehicle();
            kargo_aracı1.plaka = "42AC123";
            kargo_aracı1.Marka = "Peugeout";
            kargo_aracı1.DateTime = DateTime.Today;
            

            Console.WriteLine("Alarm: " + kargo_aracı1.plaka 
                                        + " plakalı " + kargo_aracı1.Marka 
                                        + " marka araç hız limitini aştı: " 
                                        + kargo_aracı1.DateTime 
                                        + " anındaki hızı: " 
                                        + kargo_aracı1.hiz);
        }


        private static void Kargo_aracı2_SpeedExceeded()
        {
            CargoVehicle kargo_aracı2 = new CargoVehicle();
            kargo_aracı2.plaka = "06CD456";
            kargo_aracı2.Marka = "Fiat";
            kargo_aracı2.DateTime = DateTime.Today;

            Console.WriteLine("Alarm: " + kargo_aracı2.plaka
                                        + " Plakalı " + kargo_aracı2.Marka
                                        + " marka araç hız limitini aştı: " 
                                        + kargo_aracı2.DateTime
                                        + " anındaki hızı: "
                                        + kargo_aracı2.hiz);
        }
    }
}