using System;
using DDDCommerce.Domain.Store.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DDDCommerce.Domain.Tests.ValueObjects
{
    [TestClass]
    public class EmailTest
    {
        [TestMethod]
        public void PodeCriarUmEmailVazio()
        {
            var email = new Email("");
          
            if (email.Valid)
            {
                foreach (var notification in email.Notifications)
                {
                    Console.WriteLine($"{notification.Property} - {notification.Message}");
                }
            }
        }
    }
}
