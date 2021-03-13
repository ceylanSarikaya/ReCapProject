using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{

    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarDatabaseContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetailDtos()
        {
            using (CarDatabaseContext context = new CarDatabaseContext())
            {
                var result = from r in context.Rentals
                             join c in context.Customers
                             on r.CustomerId equals c.CustomerId
                             join u in context.Users
                             on c.UserId equals u.Id

                             select new RentalDetailDto
                             {
                                 RentalId=r.RentalId,
                                 CompanyName=c.CompanyName,
                                 FirstName=u.FirstName,
                                 LastName=u.LastName,
                                 RentDate=r.RentDate,
                                 ReturnDate=r.ReturnDate,
                             };
                return result.ToList();
            }
        }
    }
}
