using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DDDCommerce.Domain.Store.Entities;
using DDDCommerce.Domain.Store.Enums;
using DDDCommerce.Shared.Entities;

namespace DDDCommerce.Domain.Store.Entities
{
    public class Order : Entity
    {
        private IList<OrderItem> _items { get; set; }

        public Order(Customer customer)
        {
            Customer = customer;
            CreateDate = DateTime.Now;
            Status = EOrderStatus.Created;
            _items = new List<OrderItem>();
        }

        public Customer Customer { get; private set; }
        public string Number { get; private set; }
        public DateTime CreateDate { get; private set; }
        public EOrderStatus Status { get; private set; }
        public ICollection<OrderItem> Items => _items.ToArray();

        public void AddItem(OrderItem orderItem)
        {
            if (orderItem.Valid)
            {
                _items.Add(orderItem);
            }

        }
    }
}
