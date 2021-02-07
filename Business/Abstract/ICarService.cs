using Core.DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService: IEntityRepository<Car>
    {
        Car GetByBrandId(int brandId);
        Car GetByColorId(int colorId);
        List<CarDetailDto> GetCarDetails();
    }
}
