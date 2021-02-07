using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryDal : ICarDal
    {
        List<Car> _cars;
        List<Brand> _brands;
        List<Color> _colors;
        public InMemoryDal()
        {
            _colors = new List<Color> { new Color() {ColorId=1,ColorName="Mavi"},new Color() {ColorId=2,ColorName="Kırmızı"},
            new Color() {ColorId=3,ColorName="Yeşil"}};
            _brands = new List<Brand>() { new Brand() { BrandId = 1, BrandName = "Renault" }, new Brand() {BrandId=2,BrandName="Ford" } };
            _cars = new List<Car>() { new Car(){Id=1,BrandId=1,ColorId=1,ModelYear=2015,DailyPrice=260,Description="Renault Megane" }, new Car() { Id = 2, BrandId = 2, ColorId = 2, ModelYear = 2018, DailyPrice = 340, Description = "Ford Focus" },
             new Car() { Id = 3, BrandId = 3, ColorId = 3, ModelYear = 2020, DailyPrice = 900, Description = "Audi A5" },
             new Car() { Id = 4, BrandId = 2, ColorId = 1, ModelYear = 2020, DailyPrice = 432, Description = "Ford Fiesta" } };
    
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public List<Car> GetByID(int brandID)
        {
            return _cars.Where(p => p.BrandId == brandID).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
