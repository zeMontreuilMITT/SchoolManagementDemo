using SchoolManagementDemo;

// spot doesn't have a vehicle parked, doesn't belong to a carpark
ParkingSpot newSpot = new ParkingSpot(6);
CarPark newPark = new CarPark(10);
Vehicle newVehicle = new Vehicle("A1A1A1");

// add the new parking spot to the new carpark
// currently, the carpark capacity has a value of int 10
// readonly = cannot reassign
// newPark.Capacity = 12; not allowed by compiler

// ParkingSpots is a single reference to a hashset
// because there is no set method on its property, it cannot be reassigned
// newPark.ParkingSpots = new HashSet<ParkingSpot>(); not allowed by the compiler

// not reassigning the field value
// invoking a method on the field value
// allowed by the get method
// newPark.ParkingSpots.Clear(); allowed by the compiler

// cannot access the parking spot list -- only add a new spot
newPark.AddParkingSpot(newSpot);

// count the number of spots to confirm that adding worked
Console.WriteLine(newPark.GetParkingSpots().Count);

newPark.GetParkingSpots().Clear();

Console.WriteLine(newPark.GetParkingSpots().Count);
