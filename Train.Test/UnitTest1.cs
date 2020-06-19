using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Train;
using Train.Classes;

namespace Train.Test
{
    [TestClass]
    public class UnitTest1
    {
        Wagon w = new Wagon();
        [TestMethod]
        public void New_Wagon_Has_No_Animals()
        {
            // Arrange
            List<Animal> expected = new List<Animal>();

            // Act

            // Assert
            CollectionAssert.AreEqual(expected, w.animalsInWagon);
            CollectionAssert.AreEqual(expected, w.animals);
        }

        public void New_Wagon_Has_No_WagonPoints()
        {
            // Assert
            Assert.AreEqual(0, w.wagonPoints);
        }

        [TestMethod]
        public void New_Wagon_Has_False_Carnivore_Bools()
        {
            // Assert
            Assert.AreEqual(false, w.hasCarnivoreS);
            Assert.AreEqual(false, w.hasCarnivoreM);
            Assert.AreEqual(false, w.hasCarnivoreL);
        }

        [TestMethod]
        public void Wagon_With_Carnivore_Wont_Add_New_S_Animal()
        {
            // Arrange
            w.AddAnimalL(new Animal(size.large, "Bean Man", true), w);

            // Act
            bool actual = w.CheckIfSmallAnimalIsSafe(w);

            // Assert
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void Wagon_With_2_L_Animals_Is_Full()
        {
            w.AddAnimalL(new Animal(size.large, "nice", false), w);
            w.AddAnimalL(new Animal(size.large, "nice", false), w);

            // Act

            // Assert
            Assert.AreEqual(10, w.wagonPoints);
        }

        [TestMethod]
        public void Wagon_With_New_S_Animal_Increases_Points_By_1()
        {
            // Arrange
            w.AddAnimalS(new Animal(size.small, "beans", false), w);

            // Act

            // Assert
            Assert.AreEqual(1, w.wagonPoints);
        }

        [TestMethod]
        public void Wagon_With_New_M_Animal_Increases_Points_By_3()
        {
            // Arrange
            w.AddAnimalM(new Animal(size.medium, "beans", false), w);

            // Act

            // Assert
            Assert.AreEqual(3, w.wagonPoints);
        }

        [TestMethod]
        public void Wagon_With_New_L_Animal_Increases_Points_By_5()
        {
            // Arrange
            w.AddAnimalL(new Animal(size.large, "beans", false), w);

            // Act

            // Assert
            Assert.AreEqual(5, w.wagonPoints);
        }

        [TestMethod]
        public void Small_Animal_Does_Not_Fit_In_Full_Wagon()
        {
            // Arrange
            w.wagonPoints = 10;
            
            // Act
            var actual = w.CheckIfSmallAnimalFits(w.wagonPoints);

            // Assert
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void Med_Animal_Does_Not_Fit_In_Full_Wagon()
        {
            // Arrange
            w.wagonPoints = 10;

            // Act
            var actual = w.CheckIfMediumAnimalFits(w.wagonPoints);

            // Assert
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void Large_Animal_Does_Not_Fit_In_Full_Wagon()
        {
            // Arrange
            w.wagonPoints = 10;

            // Act
            var actual = w.CheckIfLargeAnimalFits(w.wagonPoints);

            // Assert
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void Large_Herb_Not_Safe_With_L_Carn()
        {
            // Arrange
            w.AddAnimalL(new Animal(size.large, "Cacodemon", true), w);

            // Act
            var actual = w.CheckIfLargeAnimalIsSafe(w);

            // Assert
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void Large_Herb_Is_Safe_With_S_And_M_Carn()
        {
            // Arrange
            w.AddAnimalM(new Animal(size.medium, "Tom Nook", true), w);
            w.AddAnimalS(new Animal(size.small, "bitch", true), w);

            // Act
            var actual = w.CheckIfLargeAnimalIsSafe(w);

            // Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void Large_Animal_Fits_In_Wagon_With_S_And_M_Anim()
        {
            // Arrange
            w.AddAnimalM(new Animal(size.medium, "Tom Nook", true), w);
            w.AddAnimalS(new Animal(size.small, "bitch", true), w);

            // Act
            var actual = w.CheckIfLargeAnimalFits(w.wagonPoints);

            // Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void Medium_Animal_Is_Safe_With_Small_Carn()
        {
            // Arrange
            w.AddAnimalS(new Animal(size.small, "Baby", true), w);

            // Act
            var actual = w.CheckIfMedAnimalIsSafe(w);

            // Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void Medium_Animal_Is_Not_Safe_With_M_Carn()
        {
            // Arrange
            w.AddAnimalM(new Animal(size.medium, "Chimp", true), w);

            // Act
            var actual= w.CheckIfMedAnimalIsSafe(w);

            // Assert
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void Medium_Animal_Is_Not_Safe_With_L_Carn()
        {
            // Arrange
            w.AddAnimalL(new Animal(size.large, "Champ", true), w);

            // Act
            var actual = w.CheckIfMedAnimalIsSafe(w);

            // Assert
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void Small_Animal_Is_Safe_With_S_Herb()
        {
            w.AddAnimalS(new Animal(size.small, "leprechaun", false), w);

            var actual = w.CheckIfSmallAnimalIsSafe(w);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void Small_Animal_Is_Safe_With_M_Herb()
        {
            w.AddAnimalM(new Animal(size.medium, "Human", false), w);

            var actual = w.CheckIfSmallAnimalIsSafe(w);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void Small_Animal_Is_Safe_With_L_Herb()
        {
            w.AddAnimalL(new Animal(size.large, "giant", false), w);

            var actual = w.CheckIfSmallAnimalIsSafe(w);

            Assert.AreEqual(true, actual);
        }
    }
}
