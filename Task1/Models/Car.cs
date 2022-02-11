using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task1.Models
{
    public class Car
    {
        public String Make { get; private set; }   
        public List<CarModel> Models { get; private set; } = new List<CarModel>();        
        private static List<Car> _listOfCars = new List<Car>();

        private Car(string pMake, List<CarModel> pModel)
        {
            Make = pMake;
            Models.AddRange(pModel);
            _listOfCars.Add(this);
        }
        public static Car AddCar(string pMake, List<CarModel> pCarModel)
        {
            if (String.IsNullOrEmpty(pMake.Trim()))
                throw new Exception("Make cannot be empty or whitespaced.");
            
            if(pCarModel == null)
                throw new Exception("Model data cannot be empty");

            Car _car = new Car(pMake,pCarModel);

            return _car;
        }
        public static Car GetCarWithModels(string pMake)
        {
            if (String.IsNullOrWhiteSpace(pMake))
                throw new Exception("Make cannot be empty or whitespace");

            Car _carWithModels = _listOfCars.Where(c => c.Make.ToUpper() == pMake.ToUpper()).SingleOrDefault();
             //   (from cars in _listOfCars where cars.Make.ToUpper() == pMake.ToUpper() select cars).SingleOrDefault();

            return _carWithModels;
        }
    }
}
