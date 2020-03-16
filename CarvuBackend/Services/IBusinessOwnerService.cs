using CarvuBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarvuBackend.Services
{
    public interface IBusinessOwnerService
    {
        BusinessOwner GetBusinessOwner(BusinessOwner credentials);
        BusinessOwner AddBusinessOwner(BusinessOwner businessOwner);
        bool UpdateBusinessOwner(BusinessOwner businessOwner);
        bool DeleteBusinessOwner(Guid id);
    }
}
