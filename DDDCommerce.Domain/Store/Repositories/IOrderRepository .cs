
using System;
using System.Collections.Generic;
using DDDCommerce.Domain.Store.Entities;

namespace DDDCommerce.Domain.Store.Repositories
{
    public interface IOrderRepository
    {
        void Save(Order order);
        IEnumerable<Order> GetOrders();
        Order GetOrderById(Guid orderId);
        IEnumerable<Order> GetOrdersByCustomer(Guid id); //Pedidos de um cliente

    }
}
