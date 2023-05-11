using HCP.Config.DO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HCP.Config.IF
{
   public interface IHolidayMasterRepository
    {
        Task<List<DO_HolidayMaster>> GetHolidayByBusinessKey(int BusinessKey);

        Task<DO_ReturnParameter> InsertIntoHolidayMaster(DO_HolidayMaster obj);

        Task<DO_ReturnParameter> UpdateHolidayMaster(DO_HolidayMaster obj);

        Task<DO_ReturnParameter> ActiveOrDeActiveHolidayMaster(DO_HolidayMaster obj);
    }
}
