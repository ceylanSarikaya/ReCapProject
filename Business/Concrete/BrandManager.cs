using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
   public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand band)
        {
            if (band.BrandName.Length<2)
            {
                return new ErrorResult(Messages.BrandNameInvalid);
            }
            _brandDal.Add(band);
            return new SuccessResult(Messages.BrandAdded);
        }

        public IResult Delete(Brand band)
        {
            _brandDal.Delete(band);
            return new SuccessResult(Messages.BrnadDeleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {

            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(), Messages.BrandsListed);
        }

        public IDataResult<Brand> GetById(int id)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(u => u.BrandId == id), Messages.BrandsListed);
        }

        public IResult Update(Brand band)
        {
            _brandDal.Delete(band);
            return new SuccessResult(Messages.BrandUpdated);
        }
    }
 }

