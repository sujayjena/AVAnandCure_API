using AVAnandCure.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVAnandCure.Application.Interfaces
{
    public interface IAddressDetailsRepository
    {
        Task<int> SaveAddressDetails(AddressDetails_Request parameters);
        Task<IEnumerable<AddressDetails_Response>> GetAddressDetailsList(AddressDetails_Search parameters);
        Task<AddressDetails_Response?> GetAddressDetailsById(long Id);
    }
}
