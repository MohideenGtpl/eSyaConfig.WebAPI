﻿using HCP.Config.DO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HCP.Config.IF
{
    public interface IParametersRepository
    {
        #region Parameter Header

        Task<List<DO_Parameters>> GetParametersHeaderInformation();

        Task<DO_ReturnParameter> InsertIntoParameterHeader(DO_Parameters obj);

        Task<DO_ReturnParameter> UpdateParameterHeader(DO_Parameters obj);

        Task<DO_ReturnParameter> ActiveOrDeActiveParameterHeader(bool status, int parm_type);
        #endregion Parameter Header

        #region eSya Parameter

        Task<List<DO_Parameters>> GetParametersInformationByParameterType(int parameterType);

        Task<DO_ReturnParameter> InsertIntoParameters(DO_Parameters obj);

        Task<DO_ReturnParameter> UpdateParameters(DO_Parameters obj);

        #endregion eSya Parameter
    }
}
