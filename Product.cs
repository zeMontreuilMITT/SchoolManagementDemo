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
        private int _productId;
        private int _stock;

        private HashSet<Order> _orders = new HashSet<Order>();
    }
}
