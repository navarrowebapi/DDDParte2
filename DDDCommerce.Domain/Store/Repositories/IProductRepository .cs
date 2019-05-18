using System;
using System.Collections.Generic;
using DDDCommerce.Domain.Store.Entities;

namespace DDDCommerce.Domain.Store.Repositories
{
    public interface IProductRepository
    {
        Product Get(Guid id);
        IList<Product> GetProducts(List<Guid> ids);

    }
}
