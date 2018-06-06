using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            // Arrange
            var reservation = new Reservation();
            // Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });
            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void CanBeCancelledBy_TheSameUserCancel_ReturnsTrue()
        {
            // Arrange
            var reservation = new Reservation();
            var user = new User();
            // Act
            reservation.MadeBy = user;
            var result = reservation.CanBeCancelledBy(user);
            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_DifferentUserCancel_ReturnsFalse() 
        {
            // Arrange
            var reservation = new Reservation { MadeBy = new User() };
            // Act
            var result = reservation.CanBeCancelledBy(new User());
            // Assert
            Assert.IsFalse(result);
        }
    }
}
