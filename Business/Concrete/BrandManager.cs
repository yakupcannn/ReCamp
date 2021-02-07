using Business.Abstract;
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

        public void Add(Brand entity)
        {
            _brand.Add(entity);
        }

        public void Delete(Brand entity)
        {
            _brand.Delete(entity);
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            return _brand.Get(filter);
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            return _brand.GetAll();
        }

        public void Update(Brand entity)
        {
            _brand.Update(entity);
        }
    }
}
