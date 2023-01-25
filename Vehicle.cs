using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementDemo
{
    public class Vehicle
    {
        private string _licenseNumber;
        public string LicenseNumber
        {
            get { return _licenseNumber; }
            set
            {
                if(value.Length < 3 || value.Length > 7 || value.Contains(" "))
                {
                    throw new Exception("Plate must be alphanumeric between 3 and 7 characters");
                }
                else
                {
                    _licenseNumber = value;
                }
            }
        }

        private string? _parkingSpot;
        public string? ParkingSpot { 
            get { return _parkingSpot; } 
            set { _parkingSpot = value; }
        }
        public Vehicle(string licenseNumber)
        {
            LicenseNumber = licenseNumber;
        }

    }
}
