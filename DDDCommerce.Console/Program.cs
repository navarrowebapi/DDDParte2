
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDCommerce.Domain.Store.Entities;
using DDDCommerce.Domain.Store.Repositories;
using DDDCommerce.Domain.Store.ValueObjects;

namespace DDDCommerce.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Para gerar um pedido iremos precisar: Customer, Products...
            //Vamos supor que o usuário já esteja logado, temos portanto, pelo menos seu ID (Guid)
            //então, vamos pegar os dados do usuário, nome, e-mail, endereço fazendo uma consulta ao CustomerRepository
            //Devemos ainda pegar quais os Produtos que ele selecionou - simulando uma lista de produtos (json) vindos
            //da camada de apresentação.

            var fakeCustomerRepository = new FakeCustomerRepository();
            var fakeProductRepository = new FakeProductRepository();
            var prodQtd1 = new Dictionary<Guid, int>{{Guid.NewGuid(), 5}};
            var prodQtd2 = new Dictionary<Guid, int> { { Guid.NewGuid(), 2 } };
            var prodQtd3 = new Dictionary<Guid, int> { { Guid.NewGuid(), 3 } };
            var selectedProducts = new List<Dictionary<Guid,int>> {prodQtd1, prodQtd2, prodQtd3};
            GenerateOrder(fakeCustomerRepository, fakeProductRepository, selectedProducts, Guid.NewGuid());

        }


        public static void GenerateOrder(
            ICustomerRepository customerRepository, 
            IProductRepository productRepository,
            List<Dictionary<Guid, int>> productsGuids,
            Guid userId)
        {
            var customer = customerRepository.GetById(userId);
            var order = new Order(customer);

            foreach (var productGuid in productsGuids)
            {
                var product = productRepository.Get(productGuid.First().Key);
                var orderItem = new OrderItem(product, productGuid.First().Value);
                order.AddItem(orderItem);
            }

        }
    }

    public class FakeProductRepository : IProductRepository
    {
        public Product Get(Guid id)
        {
            //É somente um teste, portanto, retornaremos um mesmo produto e sem vínculo de Id(Guid)
            return new Product("Produto1", "description", "", 999, 1);
        }

        public IList<Product> GetProducts(List<Guid> ids)
        {
            throw new NotImplementedException();
        }
    }

    public class FakeCustomerRepository : ICustomerRepository
    {

        //Vamos criar um Customer Fake para fazermos testes
        public Customer GetById(Guid id)
        {
            var customerFake = new Customer
            (
                new Name("Fabio", "Navarro"), 
                "123456789",
                new Email("navarro@univem.edu.br"),
                "996691122"
            );
            return customerFake;
        }

        public void Save(Customer customer)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetCustomers()
        {
            throw new NotImplementedException();
        }
    }
}
