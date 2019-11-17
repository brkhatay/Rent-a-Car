using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentAcar.DATA
{
    class Hire
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int hireID { get; set; }


        public int carID { get; set; }
        public virtual Car cars { get; set; }

        public int UserID { get; set; }
        public virtual User users { get; set; }

        public DateTime hireStart { get; set; }
        public DateTime hireEnd { get; set; }

        public int hireTime { get; set; }
        public double price { get; set; }

    }
}
