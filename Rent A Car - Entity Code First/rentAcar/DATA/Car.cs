using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentAcar.DATA
{
    class Car
    {

        public int CarID { get; set; }
        public string carBrand { get; set; }
        public string carModel { get; set; }
        public string licensePlate { get; set; }
        public string carType { get; set; }
        public string gear { get; set; }
        public string fuel { get; set; }
        public string carPic { get; set; }
        public DateTime hireStart { get; set; }
        public DateTime hireEnd { get; set; }
        public int priceClass { get; set; }
    }
}
