//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinjs.UnitTests
{
    //[TestClass]
    [TestFixture]

    public class ReservationTests
    {
        //[TestMethod]
        [Test]
        //name of the test classes name of the class ____ scenario ____ expected behaviour
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //arrage
            var reservation = new Reservation();
            //act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin=true});
            //assert
            Assert.IsTrue(result);
            Assert.That(result, Is.True);
            Assert.That(result == true);
        }
        //[TestMethod]
        [Test]
        public void CanBeCancelledBy_SameUserCancellingTheReservation_ReturnTrue()
        {
            var user = new User();
            var reservation = new Reservation { MadeBy=user};
            var result = reservation.CanBeCancelledBy(user);
            Assert.IsTrue(result);
        }
        //[TestMethod]
        [Test]
        public void CanBeCancelledBy_AnotherUserCancellingReservation_ReturnFalse()
        {
            var reservation = new Reservation { MadeBy= new User()};
            var result = reservation.CanBeCancelledBy(new User());
            Assert.IsFalse(result);
        }
    }
}
