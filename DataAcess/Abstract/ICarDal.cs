using Core.DataAccess;
using Entities.DTOs;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        List<CarDetailDto> GetCarDetailDtos();
        List<CarDetailDto> GetCarsBrandIdDtos(int brandId);
        List<CarDetailDto> GetCarsColorIdDtos(int colorId);
        CarDetailDto GetCarIdDto(int carId);
    }
}
