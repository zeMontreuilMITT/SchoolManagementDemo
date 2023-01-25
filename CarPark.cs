using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementDemo
{
    public static class CarPark
    {
        private static HashSet<Vehicle> Vehicles = new HashSet<Vehicle>();
        public static int Capacity { get; }

        // static class constructor is invoked when the program runs
        static CarPark()
        {
            Capacity = 300;
        }
    }
}
