using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödevv
{

    public delegate void SpeedHandler();
    public class CargoVehicle
    {




       
        public int _hizz;

        public CargoVehicle()
        {
            _hizz = hiz;
            //void Hiiz()
            //{
                
            //}
            

        }

        public event SpeedHandler SpeedExceeded;
        public DateTime DateTime { get; set; }
        public string Marka { get; set; }
        public string plaka { get ; set  ; }
        public int hiz

        {
            get { return _hizz;}
            set
            {
                
                _hizz = value;
                if (value >= 110 && SpeedExceeded != null)
                {

                    SpeedExceeded();
                    

                }
                   
                
            }
        }
        

        
    }
}


/*
 get { return _hizz;}
            set
            {
                _hizz=value;
                if (value<=85 &&SpeedExceeded!=null)
                {
                    SpeedExceeded();
                }
            }
 */
