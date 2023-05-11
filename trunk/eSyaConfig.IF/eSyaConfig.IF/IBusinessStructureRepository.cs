﻿using HCP.Config.DO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HCP.Config.IF
{
    public interface IBusinessStructureRepository
    {
        #region Business Entity

        Task<List<DO_BusinessEntity>> GetBusinessEntities();

        Task<DO_BusinessEntity> GetBusinessEntityInfo(int BusinessId);

        Task<DO_ReturnParameter> InsertBusinessEntity(DO_BusinessEntity businessentity);

        Task<DO_ReturnParameter> UpdateBusinessEntity(DO_BusinessEntity businessentity);

        Task<DO_ReturnParameter> DeleteBusinessEntity(int BusinessEntityId);

        Task<List<DO_BusinessEntity>> GetActiveBusinessEntities();

        #endregion  Business Entity

        #region Business Unit
        Task<List<DO_BusinessUnit>> GetBusinessUnitsbyBusinessId(int BusinessId);

        Task<List<DO_BusinessUnit>> GetBusinessSubUnits(int BusinessId); 

        Task<DO_ReturnParameter> InsertBusinessUnit(DO_BusinessUnit obj);

        Task<DO_ReturnParameter> UpdateBusinessUnit(DO_BusinessUnit obj);

        Task<DO_ReturnParameter> ActiveOrDeActiveBusinessUnit(bool status, int BusinessId, int BusinessUnitId);
        #endregion Business Unit

        #region  Business Segment

        Task<List<DO_BusinessSegment>> GetBusinessSegmentByBusinessId(int BusinessId);

        Task<DO_BusinessConfiguration> GetBusinessSegment();

        Task<DO_BusinessSegment> GetBusinessSegmentInfo(int BusinessId, int SegmentId);

        Task<DO_ReturnParameter> InsertBusinessSegment(DO_BusinessSegment BusinessSegment);

        Task<DO_ReturnParameter> UpdateBusinessSegment(DO_BusinessSegment BusinessSegment);

        Task<DO_ReturnParameter> DeleteBusinessSegment(int BusinessId, int SegmentId);

        Task<List<DO_BusinessSegment>> GetActiveBusinessSegmentbyBusinessId(int BusinessId);

        Task<bool> IsAllowMultiSegment(int BusinessId);

        #endregion Business Segment

        #region Business Location

        //Task<List<DO_BusinessLocation>> GetBusinessLocationByBusinessIdandSegmentId(int BusinessId, int SegmentId);

        //Task<DO_BusinessConfiguration> GetBusinessLocations();

        //Task<DO_BusinessLocation> GetBusinessLocationInfo(int BusinessId, int SegmentId, int LocationId);

        //Task<DO_ReturnParameter> InsertBusinessLocation(DO_BusinessLocation location);

        //Task<DO_ReturnParameter> UpdateBusinessLocation(DO_BusinessLocation location);

        //Task<DO_ReturnParameter> DeleteBusinessLocation(int BusinessId, int SegmentId, int LocationId);

        Task<List<DO_BusinessLocation>> GetBusinessKey();

        Task<List<DO_BusienssSegmentCurrency>> GetBSCurrency(int BusinessKey);

        Task<bool> IsAllowMultiLocation(int BusinessId, int SegmentId);

        #endregion Business Location

        #region Business Stores

        //Task <DO_ReturnParameter> InsertOrUpdateBusinessStores(DO_BusinessStores store);

        //Task <List<DO_BusinessStores>> GetBusinessStores(int Businesskey);

        #endregion Business Stores

        #region Business Statutory Details

        //Task <DO_ReturnParameter> InsertOrUpdateBusinessStatutoryDetails(DO_BusinessStatutoryDetails statutorydetails);

        //Task <List<DO_BusinessStatutoryDetails>> GetBusinessStatutoryDetails(int BusinessKey);

        #endregion Business Statutory Details

        #region Business Subscription

        Task<List<DO_BusinessSubscription>> GetBusinessSubscription(int BusinessKey);
       
        Task<DO_ReturnParameter> InsertOrUpdateBusinessSubscription(DO_BusinessSubscription businesssubs);

        #endregion  Business Subscription

        #region Business Statutory

        Task<List<DO_BusinessStatutoryDetails>> GetStatutoryInformation(int BusinessKey, int isdCode);

        Task<DO_ReturnParameter> InsertOrUpdateBusinessStatutory(List<DO_BusinessStatutoryDetails> sd);

        #endregion  Business Statutory

        #region New Business Location
        Task<List<DO_BusinessLocation>> GetBusinessLocationByBusinessId(int BusinessId);
        Task<DO_ReturnParameter> InsertBusinessLocation(DO_BusinessLocation obj);
        Task<DO_ReturnParameter> UpdateBusinessLocation(DO_BusinessLocation obj);
        Task<DO_ReturnParameter> ActiveOrDeActiveBusinessLocation(bool status, int BusinessId, int SegmentId);
        Task<List<DO_TaxIdentification>> GetTaxIdentificationByISDCode(int IsdCode);
        Task<List<DO_CountryCodes>> GetCurrencyListbyIsdCode(int IsdCode);
        Task<List<DO_BusinessLocation>> GetActiveLocationsAsSegments();
        Task<List<DO_Place>> GetCityListbyISDCode(int isdCode);
        Task<DO_TaxIdentification> GetStateCodeByISDCode(int isdCode, int TaxIdentificationId);
        Task<List<DO_BusienssSegmentCurrency>> GetCurrencybyBusinessKey(int BusinessKey);
        #endregion
    }
}
