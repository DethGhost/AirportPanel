using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitys
{
    [Table("Flight")]
    class Flight
    {
        public DateTime DepartTime { get; set; }
        public DateTime ArriveTime { get; set; }
        public Plane Plane { get; set; }
        public int Gate { get; set; }
        public string Terminal { get; set; }
        public Airline Airline { get; set; }

        public virtual Passenger Passenger { get; set; }
    }
}
