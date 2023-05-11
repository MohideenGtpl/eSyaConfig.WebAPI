using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HCP.Config.DL;
using HCP.Config.DL.Entities;
using HCP.Config.DO;
using HCP.Config.IF;
using Microsoft.EntityFrameworkCore;

namespace HCP.Config.DL.Repository
{
    public class ApplicationCodesRepository : IApplicationCodesRepository
    {
        #region Code Types
        public async Task<List<DO_CodeTypes>> GetCodeTypes()
        {
            try
            {
                using (var db = new eSyaEnterprise())
                {
                    var ds = db.GtEcapct
                        .Select(r => new DO_CodeTypes
                        {
                            CodeType = r.CodeType,
                            CodeTypeDesc = r.CodeTyepDesc,
                            UsageStatus = r.UsageStatus,
                            CodeTypeControl = r.CodeTypeControl,
                            ActiveStatus = r.ActiveStatus
                        }).OrderBy(o => o.CodeTypeDesc).ToListAsync();

                    return await ds;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<DO_ReturnParameter> InsertIntoCodeType(DO_CodeTypes obj)
        {
            using (var db = new eSyaEnterprise())
            {
                using (var dbContext = db.Database.BeginTransaction())
                {
                    try
                    {
                        var ct_Exits = db.GtEcapct.Where(w => w.CodeType == obj.CodeType).Count();
                        if (ct_Exits > 0)
                        {
                            return new DO_ReturnParameter() { Status = false, Message = "Code Type is already Exists" };
                        }

                        bool is_CodeTypeExist = db.GtEcapct.Any(a => a.CodeTyepDesc.ToUpper().Replace(" ", "") == obj.CodeTypeDesc.ToUpper().Replace(" ", ""));
                        if (is_CodeTypeExist)
                        {
                            return new DO_ReturnParameter() { Status = false, Message = "Code Type Desc is already Exists" };
                        }

                        //int maxCodeTypeValue = db.GtEcapct.Select(c => c.CodeType).DefaultIfEmpty().Max();
                        //int codeType = maxCodeTypeValue + 1;

                        var ap_ct = new GtEcapct
                        {
                            CodeType = obj.CodeType,
                            CodeTyepDesc = obj.CodeTypeDesc.Trim(),
                            CodeTypeControl = obj.CodeTypeControl,
                            UsageStatus = obj.UsageStatus,
                            ActiveStatus = obj.ActiveStatus,
                            FormId = obj.FormID,
                            CreatedBy = obj.UserID,
                            CreatedOn = System.DateTime.Now,
                            CreatedTerminal = obj.TerminalID
                        };
                        db.GtEcapct.Add(ap_ct);

                        await db.SaveChangesAsync();
                        dbContext.Commit();

                        return new DO_ReturnParameter() { Status = true, Message = "Code Type Created Successfully" };
                    }
                    catch (DbUpdateException ex)
                    {
                        dbContext.Rollback();
                        throw new Exception(CommonMethod.GetValidationMessageFromException(ex));

                    }
                    catch (Exception ex)
                    {
                        dbContext.Rollback();
                        throw ex;
                    }
                }
            }
        }

        public async Task<DO_ReturnParameter> UpdateCodeType(DO_CodeTypes obj)
        {
            using (var db = new eSyaEnterprise())
            {
                using (var dbContext = db.Database.BeginTransaction())
                {
                    try
                    {
                        bool is_CodeTypeDescExist = db.GtEcapct.Any(a => a.CodeType != obj.CodeType && a.CodeTyepDesc.ToUpper().Trim().Replace(" ", "") == obj.CodeTypeDesc.ToUpper().Trim().Replace(" ", ""));
                        if (is_CodeTypeDescExist)
                        {
                            return new DO_ReturnParameter() { Status = false, Message = "Code Type is already Exists" };
                        }

                        GtEcapct ap_ct = db.GtEcapct.Where(w => w.CodeType == obj.CodeType).FirstOrDefault();
                        if (ap_ct == null)
                        {
                            return new DO_ReturnParameter() { Status = false, Message = "Code Type is not exist" };
                        }

                        ap_ct.CodeTyepDesc = obj.CodeTypeDesc;
                        ap_ct.CodeTypeControl = obj.CodeTypeControl;
                        ap_ct.ActiveStatus = obj.ActiveStatus;
                        ap_ct.ModifiedBy = obj.UserID;
                        ap_ct.ModifiedOn = System.DateTime.Now;
                        ap_ct.ModifiedTerminal = obj.TerminalID;
                        await db.SaveChangesAsync();
                        dbContext.Commit();

                        return new DO_ReturnParameter() { Status = true, Message = " Code Type Updated Successfully." };
                    }
                    catch (DbUpdateException ex)
                    {
                        dbContext.Rollback();
                        throw new Exception(CommonMethod.GetValidationMessageFromException(ex));
                    }
                    catch (Exception ex)
                    {
                        dbContext.Rollback();
                        throw ex;
                    }
                }
            }
        }

        public async Task<List<DO_CodeTypes>> GetActiveCodeTypes()
        {
            try
            {
                using (var db = new eSyaEnterprise())
                {
                    var ds = db.GtEcapct
                        .Where(w => w.ActiveStatus)
                        .Select(r => new DO_CodeTypes
                        {
                            CodeType = r.CodeType,
                            CodeTypeDesc = r.CodeTyepDesc
                        }).OrderBy(o => o.CodeTypeDesc).ToListAsync();

                    return await ds;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<DO_CodeTypes>> GetUserDefinedCodeTypesList()
        {
            try
            {
                using (var db = new eSyaEnterprise())
                {
                    var ds = db.GtEcapct
                        .Where(w => w.ActiveStatus && w.CodeTypeControl == "U")
                        .Select(r => new DO_CodeTypes
                        {
                            CodeType = r.CodeType,
                            CodeTypeDesc = r.CodeTyepDesc
                        }).OrderBy(o => o.CodeTypeDesc).ToListAsync();

                    return await ds;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<DO_CodeTypes>> GetSystemDefinedCodeTypesList()
        {
            try
            {
                using (var db = new eSyaEnterprise())
                {
                    var ds = db.GtEcapct
                        .Where(w => w.ActiveStatus && w.CodeTypeControl == "S")
                        .Select(r => new DO_CodeTypes
                        {
                            CodeType = r.CodeType,
                            CodeTypeDesc = r.CodeTyepDesc
                        }).OrderBy(o => o.CodeTypeDesc).ToListAsync();

                    return await ds;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<DO_ReturnParameter> ActiveOrDeActiveCodeTypes(bool status, int code_type)
        {
            using (var db = new eSyaEnterprise())
            {
                using (var dbContext = db.Database.BeginTransaction())
                {
                    try
                    {
                        GtEcapct ap_ct = db.GtEcapct.Where(w => w.CodeType == code_type).FirstOrDefault();
                        if (ap_ct == null)
                        {
                            return new DO_ReturnParameter() { Status = false, Message = "Code Type is not exist" };
                        }

                        ap_ct.ActiveStatus = status;
                        await db.SaveChangesAsync();
                        dbContext.Commit();

                        if (status == true)
                            return new DO_ReturnParameter() { Status = true, Message = " Code Type Activated Successfully." };
                        else
                            return new DO_ReturnParameter() { Status = true, Message = " Code Type De Activated Successfully." };
                    }
                    catch (DbUpdateException ex)
                    {
                        dbContext.Rollback();
                        throw new Exception(CommonMethod.GetValidationMessageFromException(ex));

                    }
                    catch (Exception ex)
                    {
                        dbContext.Rollback();
                        throw ex;
                    }
                }
            }
        }
        #endregion

        #region Application Codes
        public async Task<List<DO_ApplicationCodes>> GetApplicationCodes()
        {
            try
            {
                using (var db = new eSyaEnterprise())
                {
                    var ds = db.GtEcapcd
                        .Select(r => new DO_ApplicationCodes
                        {
                            CodeType = r.CodeType,
                            ApplicationCode = r.ApplicationCode,
                            CodeDesc = r.CodeDesc,
                            ShortCode=r.ShortCode,
                            UsageStatus = r.UsageStatus,
                            DefaultStatus = r.DefaultStatus,
                            ActiveStatus = r.ActiveStatus,
                            TerminalID = r.CodeTypeNavigation.CodeTyepDesc
                        }).OrderBy(o => o.CodeDesc).ToListAsync();

                    return await ds;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<DO_ApplicationCodes>> GetApplicationCodesByCodeType(int codeType)
        {
            try
            {
                using (var db = new eSyaEnterprise())
                {
                    if (codeType == 0)
                    {
                        var ds = db.GtEcapcd
                        .Select(r => new DO_ApplicationCodes
                        {
                            CodeType = r.CodeType,
                            ApplicationCode = r.ApplicationCode,
                            CodeDesc = r.CodeDesc,
                            ShortCode = r.ShortCode,
                            UsageStatus = r.UsageStatus,
                            DefaultStatus = r.DefaultStatus,
                            ActiveStatus = r.ActiveStatus,
                        }).OrderBy(o => o.CodeDesc).ToListAsync();
                        return await ds;
                    }
                    else
                    {
                      var ds = db.GtEcapcd
                     .Where(w => w.CodeType == codeType)
                     .Select(r => new DO_ApplicationCodes
                     {
                         CodeType = r.CodeType,
                         ApplicationCode = r.ApplicationCode,
                         CodeDesc = r.CodeDesc,
                         ShortCode = r.ShortCode,
                         UsageStatus = r.UsageStatus,
                         DefaultStatus = r.DefaultStatus,
                         ActiveStatus = r.ActiveStatus,
                     }).OrderBy(o => o.CodeDesc).ToListAsync();
                        return await ds;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<DO_ReturnParameter> InsertIntoApplicationCodes(DO_ApplicationCodes obj)
        {
            using (var db = new eSyaEnterprise())
            {
                using (var dbContext = db.Database.BeginTransaction())
                {
                    try
                    {
                        var is_CodeDescExist = db.GtEcapcd.Where(w => w.CodeType == obj.CodeType
                                && w.CodeDesc.ToUpper().Replace(" ", "") == obj.CodeDesc.ToUpper().Replace(" ", "")).Count();
                        if (is_CodeDescExist > 0)
                        {
                            return new DO_ReturnParameter() { Status = false, Message = "Application Code is already Exists" };
                        }

                        var is_DefaultStatusTrue = db.GtEcapcd.Where(w => w.DefaultStatus && w.CodeType == obj.CodeType && w.ActiveStatus).Count();
                        if (obj.DefaultStatus && is_DefaultStatusTrue > 0)
                        {
                            return new DO_ReturnParameter() { Status = false, Message = "Only one Application code can have Default Status true." };
                        }

                        GtEcapct ap_ct = db.GtEcapct.Where(w => w.CodeType == obj.CodeType).FirstOrDefault();
                        ap_ct.UsageStatus = true;
                        ap_ct.ModifiedBy = obj.UserID;
                        ap_ct.ModifiedOn = System.DateTime.Now;
                        ap_ct.ModifiedTerminal = obj.TerminalID;
                        await db.SaveChangesAsync();

                        int maxAppcode = db.GtEcapcd.Where(w=>w.CodeType == obj.CodeType).Select(c => c.ApplicationCode).DefaultIfEmpty().Max();
                        if (maxAppcode == 0)
                        {
                            maxAppcode = Convert.ToInt32(obj.CodeType.ToString() + "1".PadLeft(4, '0'));
                        }
                        else
                            maxAppcode = maxAppcode + 1;
                        if(!maxAppcode.ToString().StartsWith(obj.CodeType.ToString()))
                        {
                            return new DO_ReturnParameter() { Status = false, Message = "Check application code generation." };
                        }

                        var ap_cd = new GtEcapcd
                        {
                            ApplicationCode = maxAppcode,
                            CodeType = obj.CodeType,
                            CodeDesc = obj.CodeDesc.Trim(),
                            ShortCode=obj.ShortCode,
                            DefaultStatus = obj.DefaultStatus,
                            ActiveStatus = obj.ActiveStatus,
                            FormId = obj.FormID,
                            CreatedBy = obj.UserID,
                            CreatedOn = System.DateTime.Now,
                            CreatedTerminal =obj.TerminalID,
                          
                        };
                        db.GtEcapcd.Add(ap_cd);

                        await db.SaveChangesAsync();
                        dbContext.Commit();
                        return new DO_ReturnParameter() { Status = true, Message = "Application Code Created Successfully." };
                    }
                    catch (DbUpdateException ex)
                    {
                        dbContext.Rollback();
                        throw new Exception(CommonMethod.GetValidationMessageFromException(ex));
                    }
                    catch (Exception ex)
                    {
                        dbContext.Rollback();
                        throw ex;
                    }
                }
            }
        }

        public async Task<DO_ReturnParameter> UpdateApplicationCodes(DO_ApplicationCodes obj)
        {
            using (var db = new eSyaEnterprise())
            {
                using (var dbContext = db.Database.BeginTransaction())
                {
                    try
                    {
                        GtEcapcd ap_cd = db.GtEcapcd.Where(w => w.ApplicationCode == obj.ApplicationCode).FirstOrDefault();
                        if (ap_cd == null)
                        {
                            return new DO_ReturnParameter() { Status = false, Message = "Application Code is not exist." };
                        }

                        IEnumerable<GtEcapcd> ls_apct = db.GtEcapcd.Where(w => w.CodeType == obj.CodeType).ToList();
                        
                        var is_SameDescExists = ls_apct.Where(w => w.CodeDesc.ToUpper().Replace(" ", "") == obj.CodeDesc.ToUpper().Replace(" ", "")
                                && w.ApplicationCode != obj.ApplicationCode).Count();
                        if (is_SameDescExists > 0)
                        {
                            return new DO_ReturnParameter() { Status = false, Message = "Application Code is already Exists" };
                        }

                        var is_DefaultStatusAssign = ls_apct.Where(w => w.DefaultStatus && w.CodeType == obj.CodeType
                                && w.ApplicationCode != obj.ApplicationCode && w.ActiveStatus).Count();
                        if (obj.DefaultStatus && is_DefaultStatusAssign > 0)
                        {
                            return new DO_ReturnParameter() { Status = false, Message = "Only one Application code can have Default Status true." };
                        }

                        ap_cd.CodeDesc =obj.CodeDesc.Trim();
                        ap_cd.ShortCode = obj.ShortCode;
                        ap_cd.DefaultStatus = obj.DefaultStatus;
                        ap_cd.ActiveStatus = obj.ActiveStatus;
                        ap_cd.ModifiedBy = obj.UserID;
                        ap_cd.ModifiedOn = System.DateTime.Now;
                        ap_cd.ModifiedTerminal = obj.TerminalID;

                       await db.SaveChangesAsync();

                        List<GtEcapcd> ls_apcd = db.GtEcapcd.Where(w => w.CodeType == obj.CodeType).ToList();
                        bool isActive = false;
                        foreach (var f_apct in ls_apcd)
                        {
                            if (f_apct.ActiveStatus == true)
                            {
                                GtEcapct obj_CodeType = db.GtEcapct.Where(w => w.CodeType == obj.CodeType).FirstOrDefault();
                                obj_CodeType.UsageStatus = true;

                               await db.SaveChangesAsync();
                                isActive = true;
                                break;
                            }
                        }

                        if (!isActive)
                        {
                            GtEcapct obj_CodeType = db.GtEcapct.FirstOrDefault(x => x.CodeType == obj.CodeType);
                            obj_CodeType.UsageStatus = obj.ActiveStatus;

                            await db.SaveChangesAsync();
                        }

                        dbContext.Commit();
                        return new DO_ReturnParameter() { Status = true, Message = "Application Code Updated Successfully." };
                    }
                    catch (DbUpdateException ex)
                    {
                        dbContext.Rollback();
                        throw new Exception(CommonMethod.GetValidationMessageFromException(ex));
                    }
                    catch (Exception ex)
                    {
                        dbContext.Rollback();
                        throw ex;
                    }
                }
            }
        }

        public async Task<DO_ReturnParameter> ActiveOrDeActiveApplicationCode(bool status, int app_code)
        {
            using (var db = new eSyaEnterprise())
            {
                using (var dbContext = db.Database.BeginTransaction())
                {
                    try
                    {
                        GtEcapcd ap_code = db.GtEcapcd.Where(w => w.ApplicationCode == app_code).FirstOrDefault();
                        if (ap_code == null)
                        {
                            return new DO_ReturnParameter() { Status = false, Message = "Application code is not exist" };
                        }

                        ap_code.ActiveStatus = status;
                        await db.SaveChangesAsync();
                        dbContext.Commit();

                        if (status == true)
                            return new DO_ReturnParameter() { Status = true, Message = "Application code Activated Successfully." };
                        else
                            return new DO_ReturnParameter() { Status = true, Message = "Application code De Activated Successfully." };
                    }
                    catch (DbUpdateException ex)
                    {
                        dbContext.Rollback();
                        throw new Exception(CommonMethod.GetValidationMessageFromException(ex));

                    }
                    catch (Exception ex)
                    {
                        dbContext.Rollback();
                        throw ex;
                    }
                }
            }
        }
        #endregion
    }
}
