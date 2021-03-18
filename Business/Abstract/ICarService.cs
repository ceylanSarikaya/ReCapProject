using Entities.DTOs;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface ICarService
    {
      IDataResult  <List<CarDetailDto>> GetCarsBrandIdDtos(int brandId);
        IDataResult<List<CarDetailDto>> GetCarsColorIdDtos(int colorId);
        IDataResult<List<CarDetailDto>> GetCarDetailDtos();
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetById(int id);
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
        IResult AddTransactionalTest(Car car);
        IDataResult <CarDetailDto> GetCarIdDto(int carId);
    }
}

