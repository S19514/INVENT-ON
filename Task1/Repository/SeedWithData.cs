using System;
using System.Collections.Generic;
using System.Text;
using Task1.Models;

namespace Task1.Repository
{
    internal class SeedWithData
    {
        #region seedWord 
        public static void SeedWords()
        {
            Word.AddWord("Apple");
            Word.AddWord("Anaconda");
            Word.AddWord("Bar");
            Word.AddWord("Bonus");
            Word.AddWord("Char");
            Word.AddWord("Cast");
            Word.AddWord("Double");
            Word.AddWord("Depression");
            Word.AddWord("Enumerator");
            Word.AddWord("Employment");
            Word.AddWord("Franchise");
            Word.AddWord("Fried");
            Word.AddWord("Game");
            Word.AddWord("Glue");
            Word.AddWord("Hoover");
            Word.AddWord("Hammer");
            Word.AddWord("Invert");
            Word.AddWord("Icon");
            Word.AddWord("Java");
            Word.AddWord("Jumper");
            Word.AddWord("Knock");
            Word.AddWord("Knee");
            Word.AddWord("Lounge");
            Word.AddWord("Lamp");
            Word.AddWord("Mind");
        }


        #endregion
        #region seedCar
        public static void SeedCars()
        {
            List<CarModel> BMWCarModels = new List<CarModel>();
            BMWCarModels.Add(new CarModel
            {
                name = "M1",
                price = 146000,
                discountRate = 5.2
            });
            BMWCarModels.Add(new CarModel
            {
                name = "M3",
                price = 196000,
                discountRate = 7.4
            });
            Car.AddCar("BMW", BMWCarModels);

            List<CarModel> KIACarModels = new List<CarModel>();
            KIACarModels.Add(new CarModel
            {
                name = "RIO",
                price = 52300,
                discountRate = 2.9
            });
            KIACarModels.Add(new CarModel
            {
                name = "CEED",
                price = 112480,
                discountRate = 3.3
            });
            Car.AddCar("KIA", KIACarModels);
        }
        #endregion
    }
}
