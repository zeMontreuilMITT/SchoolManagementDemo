using SchoolManagementDemo;

try
{
    Store.CreateCustomer("TestPerson");

    Store.CreateProduct("Toothbrush", 2000);
    Store.CreateProduct("Carrot", 5000);
    Store.CreateProduct("Rug", 12);

    Store.CreateOrder(1, 3, 30);
    Store.CreateOrder(1, 3, 2000);
    Store.CreateOrder(1, 2, 2);

    Store.DeleteOrdersOnCustomer(1, "Carrot");
    Console.Read();
} catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}