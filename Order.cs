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
        public int TrackingId { get { return _trackingId; } }


        private int _quantity;
        public int Quantity { get { return _quantity; } }
        private void _setQuantity(int quantity)
        {
            if (quantity < 1)
            {
                throw new Exception("Quantity must be greater than zero.");
            }
            else
            {
                _quantity = quantity;
            }
        }


        private DateTime _estimatedDelivery;
        public DateTime EstimatedDelivery { get { return _estimatedDelivery; } }

        private Product _product;
        public Product Product { get { return _product; } }

        private Customer _customer;
        public Customer Customer { get { return _customer;} }

        public Order(int trackingId, int quantity, DateTime estimatedDelivery, Product product, Customer customer)
        {
            _trackingId = trackingId;
            _estimatedDelivery = estimatedDelivery;
            _product = product;
            _customer = customer;

            _setQuantity(quantity);
        }
    }
}
