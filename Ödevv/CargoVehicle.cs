using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödevv
{
    public class CargoVehicle
    {
        public int Hiz;

        public CargoVehicle()
        {
            Hiz = Speed;
        }

        public CargoVehicle(string plate)
        {
            this.Plaka = plate;
        }

        public delegate void SpeedHandler(CargoVehicle vehicle);
        public event SpeedHandler SpeedExceeded;

        public string Marka { get; set; }
        public string Plaka { get; set; }
        public int Speed
        {
            get { return Hiz; }
            set
            {
                Hiz = value;
                if (value >= 110 && SpeedExceeded != null)
                    SpeedExceeded(this);
            }
        }
    }
}