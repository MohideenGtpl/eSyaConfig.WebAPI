using HCP.Config.DL.Repository;
using HCP.Config.DO;
using HCP.Config.IF;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HCP.Config.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HolidayMasterController : ControllerBase
    {
        private readonly IHolidayMasterRepository _HolidayMasterRepository;

        public HolidayMasterController(IHolidayMasterRepository holidayMasterRepository)
        {
            _HolidayMasterRepository = holidayMasterRepository;

        }

        [HttpGet]
        public async Task<IActionResult> GetHolidayByBusinessKey(int BusinessKey)
        {
            var hb = await _HolidayMasterRepository.GetHolidayByBusinessKey(BusinessKey);
            return Ok(hb);
        }

        [HttpPost]
        public async Task<IActionResult> InsertIntoHolidayMaster(DO_HolidayMaster obj)
        {
            var msg = await _HolidayMasterRepository.InsertIntoHolidayMaster(obj);
            return Ok(msg);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateHolidayMaster(DO_HolidayMaster obj)
        {
            var msg = await _HolidayMasterRepository.UpdateHolidayMaster(obj);
            return Ok(msg);

        }

        [HttpPost]
        public async Task<IActionResult> ActiveOrDeActiveHolidayMaster(DO_HolidayMaster obj)
        {
            var ac = await _HolidayMasterRepository.ActiveOrDeActiveHolidayMaster(obj);
            return Ok(ac);

        }

    }
}