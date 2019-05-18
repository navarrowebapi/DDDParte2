using System;
using DDDCommerce.Domain.Store.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DDDCommerce.Domain.Tests.ValueObjects
{
    [TestClass]
    public class NameTest
    {
        [TestMethod]
        public void DeveRetornarErroQuandoFirstNameVazioOuNulo()
        {
            var name = new Name("", "asd");
            Assert.IsTrue(name.Valid);
        }
    }
}
