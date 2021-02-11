using Business.Abstract;
using Business.Messages;
using Core.DataAccess.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager:IBrandService
    {
        IBrandDal _brand;
        public BrandManager(IBrandDal Brand)
        {
            _brand = Brand;
        }

        public IResult Add(Brand entity)
        {
            _brand.Add(entity);
            return new SuccessResult(Message.ProductAdded);
        }

        public IResult Delete(Brand entity)
        {
            _brand.Delete(entity);
            return new SuccessResult(Message.ProductDeleted);
        }
        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brand.GetAll());
        }
        public IDataResult<Brand> GetById(int brandId)
        {
            return new SuccessDataResult<Brand>(_brand.Get(b => b.BrandId == brandId));
        }

        public IResult Update(Brand entity)
        {
            _brand.Update(entity);
            return new SuccessResult(Message.ProductUpdated);
        }
    }
}
