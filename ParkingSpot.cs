using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementDemo
{
    // ParkingSpot tracks the relationship between Vehicles and CarParks
    // many-to-many relationship
    // vehicles can be parked at many different carparks
    // carparks can store many different vehicles
    public class ParkingSpot
    {
        private int _number;
        private Vehicle _vehicle;
        private CarPark _carPark;

        public CarPark CarPark { 
            get { return _carPark; }
            set { _carPark = value; } 
        }

        public Vehicle Vehicle
        {
            get { return _vehicle; }
            set { _vehicle = value; }
        }

        public ParkingSpot(int number, CarPark carPark)
        {
            _number = number;
            _carPark = carPark;
        }

        public ParkingSpot(int number)
        {
            _number = number;
        }
    }
}
