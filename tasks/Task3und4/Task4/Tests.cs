using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Task2._5;


namespace Task4
{
    [TestFixture]

    public class Tests
    {

        [Test] //Test 1
        public void CanCreateNewBoat()
        {
            Motorboat Titanic = new Motorboat("Titanic", 45000, 50);
            Assert.IsTrue(Titanic.Name == "Titanic" && Titanic.Price == 45000 && Titanic.Speed == 50);
        }

        [Test] //Test 2
        public void SpeedCannotBeNegative() 
        {
            Assert.Catch(() =>
            {
                Motorboat Baywatch = new Motorboat("Baywatch", 25000, -60);
            });
        }

        [Test] //Test 3
        public void CannotCreateBoatWithNegativeOars()
        {
            Assert.Catch(() =>
            {
                Rowboat Slowly = new Rowboat("Slowly", 1500, -2);
            });
        }

        [Test] //Test 4
        public void CannotCreateBoatWithNegativePrice() 
        {
            Assert.Catch(() =>
            {
                Motorboat Baywatch = new Motorboat("Baywatch", -25000, 60);
            });
        }

        [Test] //Test 5
        public void CanChangeSpeedAfterwards()
        {
            Motorboat Titanic = new Motorboat("Titanic", 45000, 60);
            Assert.IsTrue(Titanic.Speed == 60);
            Titanic.Speed = 100;
            Assert.IsTrue(Titanic.Speed == 100);
        }

        [Test] //Test 6
        public void CanChangePriceAfterwards()
        {
            Motorboat Baywatch = new Motorboat("Baywatch", 25000, 60);
            Assert.IsTrue(Baywatch.Price == 25000);
            Baywatch.Price = 26000;
            Assert.IsTrue(Baywatch.Price == 26000);
        }

        [Test] //Test 7
        public void EnhancedSpeedIsTwiceAsBig()
        {
            Motorboat Baywatch = new Motorboat("Baywatch", 25000, 60);
            Assert.IsTrue(Baywatch.Speed == 60);
            Baywatch.EnhanceSpeed();
            Assert.IsTrue(Baywatch.Speed == 120);
        }

        [Test] //Test 8
        public void CanDoubleOarsOnRowboat()
        {
            Rowboat Speedy = new Rowboat("Speedy", 1500, 2);
            Assert.IsTrue(Speedy.Number_oars == 2);
            Speedy.EnhanceSpeed();
            Assert.IsTrue(Speedy.Number_oars == 4);
        }


    }

} 

