using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarImage : EfEntityRepositoryBase<CarImage, CarDatabaseContext>, ICarImageDal
    {
        public bool IsExist(int id)
        {
            using (CarDatabaseContext context=new CarDatabaseContext() )
            {
                return context.CarImages.Any(c => c.ImageId == id);
            }
        }
    }
}
