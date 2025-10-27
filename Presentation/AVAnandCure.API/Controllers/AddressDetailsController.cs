using AVAnandCure.Application.Enums;
using AVAnandCure.Application.Helpers;
using AVAnandCure.Application.Interfaces;
using AVAnandCure.Application.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AVAnandCure.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressDetailsController : CustomBaseController
    {
        private ResponseModel _response;
        private readonly IAddressDetailsRepository _addressDetailsRepository;
        private IFileManager _fileManager;

        public AddressDetailsController(IAddressDetailsRepository addressDetailsRepository, IFileManager fileManager)
        {
            _addressDetailsRepository = addressDetailsRepository;
            _fileManager = fileManager;

            _response = new ResponseModel();
            _response.IsSuccess = true;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> SaveAddressDetails(AddressDetails_Request parameters)
        {
            int result = await _addressDetailsRepository.SaveAddressDetails(parameters);

            if (result == (int)SaveOperationEnums.NoRecordExists)
            {
                _response.Message = "No record exists";
            }
            else if (result == (int)SaveOperationEnums.ReocrdExists)
            {
                _response.Message = "Record is already exists";
            }
            else if (result == (int)SaveOperationEnums.NoResult)
            {
                _response.Message = "Something went wrong, please try again";
            }
            else
            {
                _response.Message = "Record details saved sucessfully";
            }
            return _response;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetAddressDetailsList(AddressDetails_Search parameters)
        {
            IEnumerable<AddressDetails_Response> lstCustomers = await _addressDetailsRepository.GetAddressDetailsList(parameters);
            _response.Data = lstCustomers.ToList();
            _response.Total = parameters.Total;
            return _response;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetAddressDetailsById(long Id)
        {
            if (Id <= 0)
            {
                _response.Message = "Id is required";
            }
            else
            {
                var vResultObj = await _addressDetailsRepository.GetAddressDetailsById(Id);
                _response.Data = vResultObj;
            }
            return _response;
        }
    }
}
