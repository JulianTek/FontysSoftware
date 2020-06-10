using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using container;

namespace container.Tests
{
    [TestClass]
    public class UnitTest1
    {
        Boat b = new Boat(Int32.MaxValue, 0);
        [TestMethod]
        public void Creating_Boat_Returns_Current_Weight_As_0()
        {
            // Arrange

            // Act

            // Assert
            Assert.AreEqual(0, b.CurrentWeight);
            Assert.AreEqual(0, b.WeightLeft);
            Assert.AreEqual(0, b.WeightRight);
        }

        [TestMethod]
        public void Empty_Container_On_Empty_Ship_Will_Always_Be_Added_To_The_Left()
        {
            //Arrage
            Container container = new Container(true, false, false, 30);

            // Act
           var actual = b.CheckPlacement(container, container.Weight, b.CurrentWeight, b.WeightLeft);

           // Assert
           Assert.AreEqual(ShipPosition.Left, actual);
        }

        [TestMethod]
        public void Adding_Container_Removes_Container_From_ContainersList()
        {
            //Arrange
            Container container = new Container(true, false, false, 30);
            List<Container> expected = new List<Container>();
            b.Containers.Add(container);

            //Act
            b.AddContainerToFrontLeft(container);

            //Assert
            CollectionAssert.AreEqual(expected, b.Containers);
        }

        [TestMethod]
        public void If_CurrentWeight_Is_Zero_Ship_Cannot_Leave()
        {
            // Arrange

            // Act
           var actual = b.CheckIfShipCanLeave(b.CurrentWeight, b.MaxWeight);

            // Assert
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void Container_Cannot_Be_Added_On_Stack_Of_Container_With_Valuable_Content()
        {
            // Arrange
            Container valuableContainer = new Container(false, false, true, 1);
            Container container = new Container(false, false, false, 1);
            b.ContainersInFrontLeft.Add(valuableContainer);

            // Act
            var actual = b.CheckIfContainerGoesOnTop(b.ContainersInFrontLeft, container.Weight);

            // Assert
            Assert.AreEqual(false, actual);
        }
    }
}
