using HCP.Config.DL.Repository;
using HCP.Config.DO;
using HCP.Config.IF;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HCP.Config.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BusinessAddressController : ControllerBase
    {
        private readonly IBusinessAddressRepository _businessAddressRepository;

        public BusinessAddressController(IBusinessAddressRepository businessAddressRepository)
        {
            _businessAddressRepository = businessAddressRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetStateList(int isdCode)
        {
            var hb = await _businessAddressRepository.GetStateList(isdCode);
            return Ok(hb);
        }
        [HttpGet]
        public async Task<IActionResult> GetCityList(int isdCode, int? stateCode)
        {
            var hb = await _businessAddressRepository.GetCityList(isdCode, stateCode);
            return Ok(hb);
        }
        [HttpGet]
        public async Task<IActionResult> GetAreaList(int isdCode, int? stateCode, int? cityCode, string pincode)
        {
            var hb = await _businessAddressRepository.GetAreaList(isdCode, stateCode, cityCode, pincode);
            return Ok(hb);
        }
        [HttpGet]
        public async Task<IActionResult> GetAreaDetailsbyPincode(int isdCode, string pincode)
        {
            var hb = await _businessAddressRepository.GetAreaDetailsbyPincode(isdCode, pincode);
            return Ok(hb);
        }
        [HttpGet]
        public async Task<IActionResult> GetPinCodebyAreaCode(int isdCode, int? stateCode, int? cityCode, int areacode)
        {
            var hb = await _businessAddressRepository.GetPinCodebyAreaCode(isdCode, stateCode, cityCode, areacode);
            return Ok(hb);
        }
        [HttpGet]
        public async Task<IActionResult> GetISDCodesbyBusinessKey(int businessKey)
        {
            var hb = await _businessAddressRepository.GetISDCodesbyBusinessKey(businessKey);
            return Ok(hb);
        }
        [HttpGet]
        public async Task<IActionResult> GetBusinessAddressbyBusinessKey(int businessKey, int isdCode)
        {
            var hb = await _businessAddressRepository.GetBusinessAddressbyBusinessKey(businessKey, isdCode);
            return Ok(hb);
        }
        [HttpPost]
        public async Task<IActionResult> InsertOrUpdateIntoBusinessAddress(DO_BusinessAddress obj)
        {
            var msg = await _businessAddressRepository.InsertOrUpdateIntoBusinessAddress(obj);
            return Ok(msg);
        }

       
    }
}