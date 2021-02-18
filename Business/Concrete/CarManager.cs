using Business.Abstract;
using Business.Messages;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
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
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car entity)
        {
            _car.Add(entity);
            return new Result(true, Message.ProductAdded);
        }

        public IResult Delete(Car entity)
        {
            _car.Delete(entity);
            return new Result(true, Message.ProductDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return  new SuccessDataResult<List<Car>>(_car.GetAll());
        }

        public IDataResult<Car> GetCarsByBrandId(int brandId)
        {
           return new SuccessDataResult<Car>(_car.Get(c => c.BrandId == brandId));
        }

        public IDataResult<Car> GetCarsByColorId(int colorId)
        {
           return new SuccessDataResult<Car>(_car.Get(c => c.ColorId == colorId));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_car.GetCarDetails());
        }

        public IResult Update(Car entity)
        {
           _car.Update(entity);
            return new Result(true, Message.ProductUpdated);
        }
    }
}
