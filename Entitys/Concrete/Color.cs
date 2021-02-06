using Entitys.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entitys.Concrete
{
   public class Color:IEntity
    {
        public int ColorId { get; set; }
        public string ColorName { get; set; }

    }
}




