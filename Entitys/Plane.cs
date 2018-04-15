using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitys
{
    class Plane
    {

        public Route Route { get; set; }
        public string DestCity { get; set; }
        public string DepartCity { get; set; }
        public int Seats { get; set; }
        public List<Passenger> Passengers { get; set; }

        public Plane()
        {

        }

        public Plane(Route route, string destCity, string departCity, int seats, List<Passenger> passengers)
        {
            Route = route;
            DestCity = destCity;
            DepartCity = departCity;
            Seats = seats;
            Passengers = passengers;
        }
    }
}
