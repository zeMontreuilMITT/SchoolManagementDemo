using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementDemo
{
    public class Product
    {
        private string _name;
        public string Name { get { return _name; } }
        private void _setName(string name) { 
            if(name.Length < 3)
            {
                throw new Exception("Product name must be three or more characters in length");
            }
            else
            {
                _name = name; 
            }
        }


        private int _productId;
        public int ProductId { get { return _productId; } }


        private int _stock;
        public int Stock { get { return _stock;}
            set
            {
                if(value < 0)
                {
                    throw new Exception("Stock cannot be less than 0");
                }
                else
                {
                    _stock = value;
                }
            }
        }

        private HashSet<Order> _orders = new HashSet<Order>();
        public void AddNewOrder(Order order)
        {
            _orders.Add(order);
        }

        public void RemoveOrder(Order order)
        {
            _orders.Remove(order);
        }

        public Product(string name, int productId, int initialStock)
        {
            _setName(name);
            _productId = productId;
            _stock = initialStock;
        }
        
    }
}
