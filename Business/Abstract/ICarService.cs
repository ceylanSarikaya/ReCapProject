using Entitys.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService : IServiceRepository<Car>
    {
        List<Car> GetAllBrandId(int id);
        List<Car> GetAllColorId(int id);
    }
}
