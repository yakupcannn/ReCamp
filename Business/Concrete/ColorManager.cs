using Business.Abstract;
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

        public void Add(Color entity)
        {
            _color.Add(entity);
        }

        public void Delete(Color entity)
        {
            _color.Delete(entity);
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            return _color.Get(filter);
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            return _color.GetAll();
        }

        public void Update(Color entity)
        {
            _color.Update(entity);
        }
    }
}
