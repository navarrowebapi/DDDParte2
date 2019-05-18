using System;
using DDDCommerce.Domain.Financial.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DDDCommerce.Domain.Tests.Financial
{
    [TestClass]
    public class SudentTest
    {

        [TestMethod]
        public void CriarEstudante()
        {
            //TODO 1: Assegurar as propriedades mínimas (construtor)
            //var student1 = new Student(); //já não vou conseguir.
            
            //TODO 2: Nome, sobrenome, email e documento devem ser não nulos ou vazios.
            var student = new Student("", "asd", "asd", "asd");

            //TODO 3: SOLID, Open/Close Principle - Como posso impedir a possibilidade de se setar algo de fora da classe 
            //Exemplo: 
            student.Active = true;
        }

        [TestMethod]
        public void AdicionarAssinatura()
        {
            //TODO 2: Assegurar que só pode ter 1 Assinatura ativa
            //Não devemos permitir isso:
            var student2 = new Student("Asdrubal", "Felisberto", "123123123", "asd@teste.com");
            var subscription1 = new Subscription(DateTime.Now);
            student2.Subscriptions.Add(subscription1);
            //Acabei de quebrar toda a regra de negócio, ou seja, por uma corrupção no código (List) 
            //deixamos que de fora da nossa classe Student e por meio da List, fosse possível adicionar 
            //mais de uma inscrição e esta se torna Ativa, por padrão do Construtor de Subscription.


        }
    }
}
