using System;
using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class MarsRoverTest
    {
        [TestMethod]
        public void RotateLeftTest()
        {
            Rover rover = new Rover(1,1,"N");
            rover.RotateLeft();

            Assert.AreEqual(rover.Orientation, Orientation.W); 
        }

        [TestMethod]
        public void RotateRightTest()
        {
            Rover rover = new Rover(1, 1, "E");
            rover.RotateRight();

            Assert.AreEqual(rover.Orientation, Orientation.S);
        }

        [TestMethod]
        public void ValidateCoordinatesTest()
        {
            Rover rover = new Rover(4, 4, "N");
            Plane plane = new Plane(3, 3);

            Assert.ThrowsException<Exception>(() => rover.ValidateCoordinates(plane));
        }

        [TestMethod]
        public void MoveTest()
        {
            Plane plane = new Plane(6, 6);
            Rover rover = new Rover(4, 4, "N");
            rover.Move(plane);

            Assert.AreEqual(rover.YCoordinate, 5);
        }

    }
}
