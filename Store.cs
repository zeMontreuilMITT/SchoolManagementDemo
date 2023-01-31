using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementDemo
{
    public static class Store
    {
        public static HashSet<Order> Orders { get; set; } = new HashSet<Order>();
        public static HashSet<Customer> Customers { get; set; } = new HashSet<Customer>();
        public static HashSet<Product> Products { get; set; } = new HashSet<Product>();

        private static int _idCounter = 1;

        public static void CreateCustomer(string name)
        {
            Customer newCustomer = new Customer(name, _idCounter);
            _idCounter++;

            Customers.Add(newCustomer);
        }
        public static void CreateProduct(string name, int stock)
        {
            Product newProduct = new Product(name, _idCounter, stock);
            _idCounter++;

            Products.Add(newProduct);
        }

        public static Customer? GetCustomer(int id)
        {
            Customer customer = null;

            foreach(Customer c in Customers)
            {
                if(c.Id == id)
                {
                    customer = c;
                    break;
                }
            }

            return customer;
        }
        public static Product? GetProduct(int id)
        {
            Product product = null;

            foreach (Product p in Products)
            {
                if (p.ProductId == id)
                {
                    product = p;
                    break;
                }
            }

            return product;
        }
        public static Order? GetOrder(int id)
        {
            Order order = null;

            foreach(Order o in Orders)
            {
                if(o.TrackingId == id)
                {
                    order = o;
                    break;
                }
            }

            return order;
        }


        // how do we get from our lists what produt we want, for which customer
        public static void CreateOrder(int customerId, int productId, int quantity)
        {
            Customer customer = GetCustomer(customerId);
            Product product = GetProduct(productId);
            
            if(customer == null || product == null)
            {
                throw new NullReferenceException();
            } else if (product.Stock < quantity)
            {
                throw new ArgumentException("Cannot order quantity greater than product stock.");
            }
            else
            {
                // create the order
                Order newOrder = new Order(_idCounter, quantity, DateTime.Now.AddDays(2), product, customer);

                product.Stock -= quantity;

                product.AddNewOrder(newOrder);
                customer.AddNewOrder(newOrder);
                Orders.Add(newOrder);
            }
        }

        public static void DeleteOrder(int id)
        {
            Order order = GetOrder(id);

            if(order == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                Orders.Remove(order);

                order.Product.Stock += order.Quantity;

                order.Product.RemoveOrder(order);
                order.Customer.RemoveOrder(order);
            }
        }

        public static void DeleteOrdersOnCustomer(int customerId, string productName)
        {
            Customer customer = GetCustomer(customerId);

            if(customer == null)
            {
                throw new NullReferenceException();
            }

            HashSet<Order> customerOrders = customer.GetOrders();

            foreach(Order o in customerOrders)
            {
                if(o.Product.Name == productName)
                {
                    Order toRemove = o;
                    Customer removingCustomer = o.Customer;
                    Product removingProduct = o.Product;

                    removingCustomer.RemoveOrder(toRemove);
                    removingProduct.RemoveOrder(toRemove);
                    Orders.Remove(o);
                }
            }

        }
    }
}
