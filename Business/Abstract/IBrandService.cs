﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IBrandService 

    {
        IDataResult<List<Brand>>GetAll();
        IDataResult<Brand> GetById(int id);
        IResult Add(Brand band);
        IResult Update(Brand band);
        IResult Delete(Brand band);
    }
}

