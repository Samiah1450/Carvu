using CarvuBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarvuBackend.Services
{
    public class BusinessOwnerService : IBusinessOwnerService
    {
        private readonly CarvuDbContext _carvuDbContext;

        public BusinessOwnerService(CarvuDbContext carvuDbContext)
        {
            _carvuDbContext = carvuDbContext;
        }

        public BusinessOwner GetBusinessOwner(BusinessOwner credentials)
        {
            if (String.IsNullOrEmpty(credentials.LoginId) || String.IsNullOrEmpty(credentials.Password))
            {
                throw new Exception("The login id and/or password cannot be empty.");
            }
            var businessOwner = _carvuDbContext.BusinessOwners.Where(x => x.LoginId == credentials.LoginId && x.Password == credentials.Password).FirstOrDefault();

            //var businessOwner = _carvuDbContext.BusinessOwners.Where(x => x.Id == id).FirstOrDefault();
            return businessOwner;
        }

        public BusinessOwner AddBusinessOwner(BusinessOwner businessOwner)
        {
            if (businessOwner == null)
            {
                throw new Exception("The new business owner could not be added to the database.");
            }
            _carvuDbContext.Add(businessOwner);
            _carvuDbContext.SaveChanges();
            return businessOwner;
        }

        // Not sure if this will be necessary to implement
        public bool UpdateBusinessOwner(BusinessOwner businessOwner)
        {
            throw new NotImplementedException();
        }

        public bool DeleteBusinessOwner(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
