using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja;

namespace RezervacijaUnitTest
{
    [TestClass]
    public class RezervacijaUnitTest
    {
        [TestMethod]
        public void AtsauktiRezervacija_UserIsAdmin_ReturnTrue()
        {
            //Arange
            Rezervacija rezervacija = new Rezervacija();
            //Act
            var result =
                rezervacija.AtsauktiRezervacija(new User() { IsAdmin = true });
            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AtsauktiRezervacija_AtsaukiaUzsakinetojas_ReturnTrue()
        {
            User user = new User();
            Rezervacija rezervacija = new Rezervacija() { KienoRezervacija = user };

            var result = rezervacija.AtsauktiRezervacija(user);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AtsauktiRezervacija_AtsaukiaNeUzsakinetojas_ReturnFalse()
        {
            Rezervacija rezervacija = new Rezervacija()
            { KienoRezervacija = new User() };

            var result =
                rezervacija.AtsauktiRezervacija(new User() { IsAdmin = false });

            Assert.IsFalse(result);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void KazkasNeTaip_ExpectedException()
        {
            Rezervacija rezervacija = new Rezervacija();

            rezervacija.KazkasNetinka();
        }
    }

    [TestClass]
    public class DuomenuParuosaUnitTest
    {
        [TestMethod]
        public void AutomatinisDuomenuPersiuntimias_Darbas_Tikiuosi()
        {
            DuomenuParuosa paruosa = new DuomenuParuosa(new FakeKomunikacija());
        }
    }

    internal class FakeKomunikacija : Komunikacija
    {
        public void Connect()
        {
            throw new NotImplementedException();
        }

        public void Receive()
        {
            throw new NotImplementedException();
        }

        public void Send()
        {
            throw new NotImplementedException();
        }
    }
}