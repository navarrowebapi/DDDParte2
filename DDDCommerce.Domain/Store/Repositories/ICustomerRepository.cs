using System;
using System.Collections.Generic;
using DDDCommerce.Domain.Store.Entities;

namespace DDDCommerce.Domain.Store.Repositories
{

    //Aqui definimos as ações relacionadas à Entidade em relação a seu acesso a dados 
    public interface ICustomerRepository
    {
        Customer GetById(Guid id);
        void Save(Customer customer);
        IEnumerable<Customer> GetCustomers();

    }

}
