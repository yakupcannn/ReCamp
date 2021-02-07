using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _car;
        public CarManager(ICarDal car)
        {
            _car = car;
        }

        public void Add(Car entity)
        {
            _car.Add(entity);
        }

        public void Delete(Car entity)
        {
            _car.Delete(entity);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
           return _car.Get(filter);
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _car.GetAll();
        }

        public Car GetByBrandId(int brandId)
        {
           return _car.Get(c => c.BrandId == brandId);
        }

        public Car GetByColorId(int colorId)
        {
           return _car.Get(c => c.ColorId == colorId);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _car.GetCarDetails();
        }

        public void Update(Car entity)
        {
           _car.Update(entity);
        }
    }
}
