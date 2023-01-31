using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementDemo
{
    public class Customer
    {
        private int _id;
        public int Id { get { return _id; } }


        private string _userName;
        public string UserName { get { return _userName; } }
        private void _setUserName(string userName)
        {
            if(userName.Length < 3)
            {
                throw new Exception("Username must be greater than two characters long.");
            }
            else if(!userName.All(c => Char.IsLetterOrDigit(c)))
            {
                throw new Exception("Username must contain all letters or digits");
            } else
            {
                _userName = userName;
            }
        }


        private HashSet<Order> _orders = new HashSet<Order>();
        public HashSet<Order> GetOrders()
        {
            return _orders.ToHashSet();
        }
        public void AddNewOrder(Order order)
        {
            _orders.Add(order);
        }
        public void RemoveOrder(Order order)
        {
            _orders.Remove(order);
        }

        public Customer(string userName, int id) {
            _id = id;
            _setUserName(userName);
        }
    }
}
