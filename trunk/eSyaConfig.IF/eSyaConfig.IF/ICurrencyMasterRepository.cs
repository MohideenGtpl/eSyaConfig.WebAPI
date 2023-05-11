﻿using HCP.Config.DO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HCP.Config.IF
{
   public interface ICurrencyMasterRepository
    {
        #region Currency Master

        Task<List<DO_CurrencyMaster>> GetCurrencyMaster();

        Task<List<DO_CurrencyMaster>> GetActiveCurrencyList();

        Task<List<DO_CurrencyMaster>> GetCurrencyListByCurrenyPrefix(string currencyPrefix);

        Task<DO_ReturnParameter> InsertIntoCurrencyMaster(DO_CurrencyMaster obj);

        Task<DO_ReturnParameter> UpdateCurrencyMaster(DO_CurrencyMaster obj);

        Task<DO_ReturnParameter> DeleteCurrencyMasterByCurrencyCode(string currencyCode);

        Task<DO_ReturnParameter> ActiveOrDeActiveCurrencyMaster(bool status, string currency_code);
        #endregion

        #region Currency Denomination Information

        Task<List<DO_CurrencyDenominationInformation>> GetCurrencyDenominationInfoByCurrencyCode(string currencyCode);

        Task<DO_ReturnParameter> InsertCurrencyDenominationInformation(DO_CurrencyDenominationInformation obj);

        Task<DO_ReturnParameter> UpdateCurrencyDenominationInformation(DO_CurrencyDenominationInformation obj);

        Task<DO_ReturnParameter> DeleteCurrencyDenominationInformation(string currencyCode, decimal DenomId, string BnorCNId);

        Task<DO_ReturnParameter> ActiveOrDeActiveCurrencyDenomination(bool status, string currencycode, int denomId);
        #endregion

        #region Currency Exchange Rate
        Task<DO_ExchangeRate> GetCurrencybyBusinesskey(int Businesskey);

        List<DO_ExchangeRate> GetCurrencyExchangeRate(string Currencycode,int Businesskey);

        Task<DO_ReturnParameter> InsertOrUpdateCurrencyExchangeRate(DO_ExchangeRate obj);

        #endregion
    }
}
