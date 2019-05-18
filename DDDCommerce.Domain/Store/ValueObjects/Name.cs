using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDCommerce.Shared.ValueObject;
using Flunt.Validations;

namespace DDDCommerce.Domain.Store.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            AddNotifications(
                new Contract()
                    .Requires()
                .IsTrue(Validate(), "firstName","nome não deve ser vazio")
                );
        }

        private bool Validate()
        {
            if (!String.IsNullOrEmpty(FirstName))
                return true;

            return false;

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return FirstName + " "+LastName;
        }
    }
}
