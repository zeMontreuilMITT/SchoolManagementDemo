using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementDemo
{
    public class Order
    {
        private int _trackingId;
        private int _quantity;
        private DateTime _estimatedDelivery;

        private Product _product;
        private Customer _customer;
    }
}
