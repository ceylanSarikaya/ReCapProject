using Business.Abstract;
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

        public void Add(Brand entity)
        {
            if(entity.BrandName.Length>2)
            {
                Console.WriteLine(" Ürün başarı ile eklendi ", entity.BrandName);
                _brandDal.Add(entity);
            }
            else
            {
                Console.WriteLine(" Ürün isimi iki karakterden uzun olmalı! ");
            }
        }

        public void Delete(Brand entity)
        {
            _brandDal.Delete(entity);
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand GetById(int id)
        {
            return _brandDal.Get(c => c.BrandId == id);
        }

        public void Update(Brand entity)
        {
            _brandDal.Update(entity);
        }
    }
 }

