using Business.Abstract;
using Business.Constants;
using Business.ValidationRules;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Business.FileManager;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        List<CarDetailDto> carDetailDtos = new List<CarDetailDto>();
        CarDetailDto carDetail = new CarDetailDto();

        ICarImageDal _carImageDal;
        ICarService _carService;
        public CarImageManager(ICarImageDal carImageDal,ICarService carService)
        {
            _carImageDal = carImageDal;
            _carService = carService;
        }
        [ValidationAspect(typeof(CarImageValidator))]
        public IResult Add(CarImage carImage, IFormFile file)
        {
            IResult result = BusinessRules.Run(CheckIfImageLimitExpired(carImage.CarId), CheckIfImageExtensionValid(file));
            if (result != null)
            {
                return result;
            }
            carImage.ImagePath = CarImagesFileHelper.Add(file);
            carImage.Date = DateTime.Now;
            _carImageDal.Add(carImage);
            return new SuccessResult();
        }

        public IResult Delete(CarImage carImage)
        {
            IResult result = BusinessRules.Run(CheckIfImageExists(carImage.ImageId));
            if (result != null)
            {
                return result;
            }
            string path = GetById(carImage.ImageId).Data.ImagePath;
            CarImagesFileHelper.Delete(path);
            return new SuccessResult();
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }

        public IDataResult<List<CarImage>> GetAllByCarId(int carId)
        {
            return new SuccessDataResult<List<CarImage>>(CheckIfCarHaveNoImage(carId));
        }

        public IDataResult<CarImage> GetById(int id)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(c => c.ImageId == id));
        }

        public IResult Update(CarImage carImage, IFormFile file)
        {
            IResult result = BusinessRules.Run(CheckIfImageLimitExpired(carImage.CarId),
                CheckIfImageExtensionValid(file),
                CheckIfImageExists(carImage.ImageId));
            if (result != null)
            {
                return result;
            }
            carImage.Date = DateTime.Now;
            string OldPath = GetById(carImage.ImageId).Data.ImagePath;
            _carImageDal.Update(carImage);
            return new SuccessResult();
        }
        private IResult CheckIfImageLimitExpired(int carId)
        {
            int result = _carImageDal.GetAll(c => c.CarId == carId).Count;
            if (result >= 5)
                return new ErrorResult(Messages.CarImageAddingLimit);
            return new SuccessResult();
        }
        private IResult CheckIfImageExtensionValid(IFormFile file)
        {
            bool isValidFileExtension = Messages.ValidImageFileTypes.Any(i => i == Path.GetExtension(file.FileName).ToUpper());
            if (!isValidFileExtension)
                return new ErrorResult(Messages.CarImageAdded);
            return new SuccessResult();

        }

        private List<CarImage> CheckIfCarHaveNoImage(int carId)
        {
            string path = "/Images/default.jpg";
            var result = _carImageDal.GetAll(c => c.CarId == carId);
            if (!result.Any())
                return new List<CarImage> { new CarImage { CarId = carId, ImagePath = path } };
            return result;
        }
        private IResult CheckIfImageExists(int id)
        {
            if (_carImageDal.IsExist(id))
                return new SuccessResult();
            return new ErrorResult(Messages.CarImageAddingLimit);
        }
        public IDataResult<List<CarDetailDto>> CarDtoImageList(List<CarDetailDto> carDetailList) {
            carDetailDtos.Clear();
        
            foreach (var item in carDetailList)
            {
                carDetail = item;
                var resultImage = _carImageDal.GetAll(p => p.CarId == item.CarId);
                if (resultImage.Count != 0)
                {
                    foreach (var item2 in resultImage)
                    {
                        carDetail.ImagePath = item2.ImagePath;
                        break;
                    }
                }
                else
                {

                    carDetail.ImagePath = "/Images/default.jpg";


                }
                carDetailDtos.Add(carDetail);
            }
            return new SuccessDataResult<List<CarDetailDto>>(carDetailDtos);
        }
    }
    }

