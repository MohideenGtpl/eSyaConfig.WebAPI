using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HCP.Config.DL;
using HCP.Config.DL.Entities;
using HCP.Config.DO;
using HCP.Config.IF;
using Microsoft.EntityFrameworkCore;



namespace HCP.Config.DL.Repository
{
    public class HolidayMasterRepository : IHolidayMasterRepository
    {
        public async Task<List<DO_HolidayMaster>> GetHolidayByBusinessKey(int BusinessKey)
        {
            try
            {
                using (var db = new eSyaEnterprise())
                {
                    var ds = db.GtEchlms
                    .Where(w => w.BusinessKey == BusinessKey).Select(r => new DO_HolidayMaster
                    {
                        BusinessKey = r.BusinessKey,
                        HolidayDate = r.HolidayDate,
                        HolidayDesc = r.HolidayDesc,
                        ActiveStatus = r.ActiveStatus

                    }).ToListAsync();

                    return await ds;
                }

            }

            catch (Exception ex)
            {

                throw ex;

            }
        }

        public async Task<DO_ReturnParameter> InsertIntoHolidayMaster(DO_HolidayMaster obj)
        {
            using (var db = new eSyaEnterprise())
            {
                using (var dbContext = db.Database.BeginTransaction())
                {
                    try
                    {
                        var _IsHolidayExits = db.GtEchlms.Where(w => w.BusinessKey == obj.BusinessKey && w.HolidayDate == obj.HolidayDate).FirstOrDefault();
                        if(_IsHolidayExits !=null)
                        {
                            return new DO_ReturnParameter() { Status=false , Message="already Exits" };
                        }
                        else
                        {
                            var hp = new GtEchlms
                            {
                                BusinessKey = obj.BusinessKey,
                                HolidayDate = obj.HolidayDate,
                                HolidayDesc = obj.HolidayDesc,
                                ActiveStatus = obj.ActiveStatus,
                                CreatedBy=obj.UserID,
                                CreatedOn=System.DateTime.Now,
                                CreatedTerminal=obj.TerminalID
                            };
                            db.GtEchlms.Add(hp);
                            await db.SaveChangesAsync();
                            dbContext.Commit();

                            return new DO_ReturnParameter() { Status = true, Message = "Holiday package Created Successfully" };


                        }
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

        public async Task<DO_ReturnParameter> UpdateHolidayMaster(DO_HolidayMaster obj)
        {
            using (var db = new eSyaEnterprise())
            {
                using (var dbContext = db.Database.BeginTransaction())
                {
                    try
                    {
                        var _HM = db.GtEchlms.Where(w => w.BusinessKey == obj.BusinessKey && w.HolidayDate == obj.HolidayDate).FirstOrDefault();

                        if (_HM == null)
                        {
                            return new DO_ReturnParameter() { Status = false, Message = "Holiday Master not Exists" };
                        }
                        else
                        { 
                            _HM.BusinessKey = obj.BusinessKey;
                            _HM.HolidayDate = obj.HolidayDate;
                            _HM.HolidayDesc = obj.HolidayDesc;
                            _HM.ActiveStatus = obj.ActiveStatus;
                            _HM.ModifiedBy = obj.UserID;
                            _HM.ModifiedOn = System.DateTime.Now;
                            _HM.ModifiedTerminal = obj.TerminalID;
                            await db.SaveChangesAsync();
                            dbContext.Commit();
                            return new DO_ReturnParameter() { Status = true, Message = "Holiday Master Updated Sucessfully" };
                        }


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

        public async Task<DO_ReturnParameter> ActiveOrDeActiveHolidayMaster(DO_HolidayMaster obj)
        {
            using (var db = new eSyaEnterprise())
            {
                using (var dbContext = db.Database.BeginTransaction())
                {
                    try
                    {
                        var _HM = db.GtEchlms.Where(w => w.BusinessKey == obj.BusinessKey && w.HolidayDate == obj.HolidayDate).FirstOrDefault();

                        if (_HM == null)
                        {
                            return new DO_ReturnParameter() { Status = false, Message = "Holiday Master not Exists" };
                        }
                        else
                        {
                            
                            _HM.ActiveStatus = obj._status;
                            await db.SaveChangesAsync();
                            dbContext.Commit();
                            if (obj._status == true)
                                return new DO_ReturnParameter() { Status = true, Message = "Holiday Master Activated Successfully." };
                            else
                                return new DO_ReturnParameter() { Status = true, Message = "Holiday Master De Activated Successfully." };
                        }


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
    }
}

