using System;
using System.Collections.Generic;
using DDDCommerce.Domain.Store.ValueObjects;
using DDDCommerce.Shared.Entities;

namespace DDDCommerce.Domain.Store.Entities
{
    public class Customer : Entity
    {

        public Customer(
            Name name,
            string document,
            Email email,
            string phone)
        {
            Name = name;
            Document = document;
            Email = email;
            Phone = phone;
        }

        public Name Name { get; private set; }
        public string Document { get; private set; }
        public Email Email { get; private set; }
        public string Phone { get; private set; }

    }
}
