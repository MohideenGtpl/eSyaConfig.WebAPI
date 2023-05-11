﻿using HCP.Config.DL.Repository;
using HCP.Config.DO;
using HCP.Config.IF;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HCP.Config.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryRepository _CountryRepository;

        public CountryController(ICountryRepository CountryRepository)
        {
            _CountryRepository = CountryRepository;
        }

        #region Country Codes
        /// <summary>
        /// Getting  Country Codes List.
        /// UI Reffered - Country Codes Grid
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetAllCountryCodes()
        {
            var countries = await _CountryRepository.GetAllCountryCodesAsync();
            return Ok(countries);
        }
        /// <summary>
        /// Insert Country Codes.
        /// UI Reffered -Country Codes
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> InsertIntoCountryCode(DO_CountryCodes countrycode)
        {
            var msg = await _CountryRepository.InsertIntoCountryCode(countrycode);
            return Ok(msg);

        }
        /// <summary>
        /// Update Country Codes.
        /// UI Reffered -Country Codes
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> UpdateCountryCode(DO_CountryCodes countrycode)
        {
            var msg = await _CountryRepository.UpdateCountryCode(countrycode);
            return Ok(msg);

        }
        /// <summary>
        /// Get Currency Name by Isd Code.
        /// UI Reffered -Business Segment
        /// UI Param-IsdCode
        /// Business Segment
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetCurrencyNamebyIsdCode(int IsdCode)
        {
            var currencies = await _CountryRepository.GetCurrencyNamebyIsdCode(IsdCode);
            return Ok(currencies);

        }
        /// <summary>
        /// Active Or De Active Country code.
        /// UI Reffered - Country Master
        /// </summary>
        /// <param name="status-Isd_code"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> ActiveOrDeActiveCountryCode(bool status, int Isd_code)
        {
            var msg = await _CountryRepository.ActiveOrDeActiveCountryCode(status, Isd_code);
            return Ok(msg);

        }
        /// <summary>
        /// Get UID Patterns by Isd Code and UID Label.
        /// UI Reffered - Country Master
        /// </summary>
        /// <param name="Isdcode-Uidlabel"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetUIDPatternbyIsdcode(int Isdcode)
        {
            var msg = await _CountryRepository.GetUIDPatternbyIsdcode(Isdcode);
            return Ok(msg);

        }
        #endregion Country Codes

        #region Statutory Details

        /// <summary>
        /// Getting  Statutory Codes Parameter List by ISD Code and Statutory Code.
        /// UI Reffered - Statutory Codes 
        /// UI-Paramm -Isdcode & Statutory Code
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetStatutoryCodesParameterList(int IsdCode, int StatutoryCode)
        {
            var stat_params = await _CountryRepository.GetStatutoryCodesParameterList(IsdCode, StatutoryCode);
            return Ok(stat_params);

        }

        /// <summary>
        /// Getting  Statutory Codes by ISD Code.
        /// UI Reffered - Country 
        /// UI-Paramm -Isdcode
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetStatutoryCodesbyIsdcode(int Isdcode)
        {
            var stat_codes = await _CountryRepository.GetStatutoryCodesbyIsdcode(Isdcode);
            return Ok(stat_codes);

        }
        /// <summary>
        /// Insert OR Up date Statutory Codes.
        /// UI Reffered -Country
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> InsertOrUpdateStatutoryCodes(DO_CountryStatutoryDetails obj)
        {
            var msg = await _CountryRepository.InsertOrUpdateStatutoryCodes(obj);
            return Ok(msg);

        }


        /// <summary>
        /// Getting  Statutory Codes for dropdown.
        /// UI Reffered - Business Statutory Details 

        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetActiveStatutoryCodes()
        {
            var astat_codes = await _CountryRepository.GetActiveStatutoryCodes();
            return Ok(astat_codes);

        }

        /// <summary>
        /// Active Or De Active Statutory Codes.
        /// UI Reffered - Statutory Codes
        /// </summary>
        /// <param name="status-Isd_code-statutorycode"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> ActiveOrDeActiveStatutoryCode(bool status, int Isd_code, int statutorycode)
        {
            var msg = await _CountryRepository.ActiveOrDeActiveStatutoryCode(status, Isd_code, statutorycode);
            return Ok(msg);
        }
        #endregion Statutory Details
    }
}