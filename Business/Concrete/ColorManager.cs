using Business.Abstract;
using Business.Messages;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _color;
        public ColorManager(IColorDal color)
        {
            _color = color;
        }

        public IResult Add(Color entity)
        {
            _color.Add(entity);
            return new SuccessResult(Message.ProductAdded);
        }

        public IResult Delete(Color entity)
        {
            _color.Delete(entity);
            return new SuccessResult(Message.ProductDeleted);
        }
        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_color.GetAll());
        }
        public IDataResult<Color> GetById(int colorId)
        {
            return new SuccessDataResult<Color>(_color.Get(c => c.ColorId == colorId));
        }

        public IResult Update(Color entity)
        {
            _color.Update(entity);
            return new SuccessResult(Message.ProductUpdated);
        }
    }
}
