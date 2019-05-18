using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDCommerce.Domain.Financial.Entities
{
    public class Student
    {

        //private IList<Subscription> _subscriptions;

        public Student(string firstName, string lastName, string document, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Document = document;
            Email = email;

            //Momento1: criando uma regra de negócio na qual nenhum Student 
            //poderá ter nome, sobrenome, documento e email VAZIOS
            if(string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(document) || string.IsNullOrEmpty(email))
                throw new Exception("Nome, sobrenome, email e documento não devem ser nulos ou vazios");

            //Momento2: Iremos criar classes separadas para isso.


            //_subscriptions = new List<Subscription>();
        }

        public String FirstName { get; private set; }
        public String LastName { get; private set; }
        public String Document { get; private set; }
        public String Email { get; private set; }
        public String Address { get; private set; }
        public bool Active  { get; set; }
        public List<Subscription> Subscriptions { get; set; }

        //public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray(); } }

        //inicialmente assim, vai dar pau, pois nao temos Add para IReadl
        //public void AddSubscription(Subscription subscription)
        //{
        //    foreach (var item in Subscriptions)
        //    {
        //        item.Active = false;
        //    }
        //    _subscriptions.Add(subscription);
        //}
    }
}
