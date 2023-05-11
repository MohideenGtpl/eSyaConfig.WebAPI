using HCP.Config.DO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HCP.Config.IF
{
   public interface IBusinessAddressRepository
    {
        Task<List<DO_Place>> GetStateList(int isdCode);

        Task<List<DO_Place>> GetCityList(int isdCode, int? stateCode);

        Task<List<DO_AddressIN>> GetAreaList(int isdCode, int? stateCode, int? cityCode, string pincode);

        Task<DO_AddressIN> GetAreaDetailsbyPincode(int isdCode, string pincode);

        Task<DO_AddressIN> GetPinCodebyAreaCode(int isdCode, int? stateCode, int? cityCode, int areacode);

        Task<List<DO_IsdCodes>> GetISDCodesbyBusinessKey(int businessKey);

        Task<DO_BusinessAddress> GetBusinessAddressbyBusinessKey(int businessKey, int isdCode);

        Task<DO_ReturnParameter> InsertOrUpdateIntoBusinessAddress(DO_BusinessAddress obj);

    }
}
