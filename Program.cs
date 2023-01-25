
using SchoolManagementDemo;
/// Create an OOP "Carpark" System
/// At its most basic, the static CarPark class will have a private HashSet of Vehicles, and a method: public static void Park (Vehicle vehicle) method.
/// Vehicles have a string LicenseNumber, and a string ParkingSpot
/// Both should be private and validated with public properties
/// 
/// When the Park method is invoked, it adds the vehicle to the CarPark HashSet,  counts the vehicles in the HashSet, and uses that number to assign a spot.
/// If 20 vehicles are parked, then the 21st vehicle parked is given spot 21.
/// 
/// It should prevent a vehicle from parking in more than one spot (if it already has a spot) or if the spots are over capacity.
/// 

CarPark.Park(new Vehicle("A1A1A1"));
CarPark.Park(new Vehicle("HONK"));