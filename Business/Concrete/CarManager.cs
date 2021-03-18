using Business.Abstract;
using DataAccess.Abstract;
using Entities.DTOs;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Business.Constants;
using Core.CrossCuttingConcerns.Validation;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Businees.BusinessAspects.Autofac;
using Core.Aspects.Autofac.Caching;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        [SecuredOperation("car.add,admin")]
        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Add(Car car)
        {
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }
        [CacheAspect]
        public IDataResult<List<Car>> GetAll()
        {
           
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.CarsListed);
        }

        public IDataResult<List<CarDetailDto>> GetCarsBrandIdDtos(int brandId)
        {
            return new SuccessDataResult<List<CarDetailDto>> (_carDal.GetCarsBrandIdDtos(brandId));
        }

        public IDataResult<List<CarDetailDto>> GetCarsColorIdDtos(int colorId)
        {
            return new SuccessDataResult<List<CarDetailDto>> ( _carDal.GetCarsColorIdDtos(colorId));
        }

        public IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>( _carDal.GetAll(c=> c.DailyPrice >= min && c.DailyPrice <= max));
        }
        [CacheAspect]
        public IDataResult< Car >GetById(int id)
        {
            return new SuccessDataResult<Car>( _carDal.Get(c => c.CarId == id));
        }

        public IDataResult<List<CarDetailDto>>GetCarDetailDtos()
        {
            return new SuccessDataResult<List<CarDetailDto>>( _carDal.GetCarDetailDtos());
        }
        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }

        public IResult AddTransactionalTest(Car car)
        {
            Add(car);
            if (car.DailyPrice < 10)
            {
                throw new Exception("");
            }

            Add(car);

            return null;
        }

        public IDataResult<CarDetailDto> GetCarIdDto(int carId)
        {
            return new SuccessDataResult<CarDetailDto>(_carDal.GetCarIdDto( carId));
        }
    }
 
}
