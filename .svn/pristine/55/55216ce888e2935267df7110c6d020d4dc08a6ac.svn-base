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
   public class BusinessAddressRepository:IBusinessAddressRepository
    {
        
        public async Task<List<DO_Place>> GetStateList(int isdCode)
        {
            using (var db = new eSyaEnterprise())
            {
                var pf = db.GtEccnpl
               .Where(w => w.ActiveStatus && w.PlaceType == PlaceTypeValues.State && w.Isdcode == isdCode)
               .Select(s => new DO_Place
               {
                   IsdCode = s.Isdcode,
                   PlaceId = s.PlaceId,
                   PlaceName = s.PlaceName
               })
               .ToListAsync();
                return await pf;
            }
        }

        public async Task<List<DO_Place>> GetCityList(int isdCode, int? stateCode)
        {
            using (var db = new eSyaEnterprise())
            {
                var pf = db.GtAddrin
                .Join(db.GtEccnpl.Where(w => w.PlaceType == PlaceTypeValues.City && w.ActiveStatus),
                    a => new { a.CityCode },
                    c => new { CityCode = c.PlaceId },
                    (a, c) => new { a, c })
               .Where(w => w.a.ActiveStatus && (w.a.StateCode == stateCode || stateCode == null))
               .Select(s => new DO_Place
               {
                   IsdCode = s.a.Isdcode,
                   PlaceId = s.c.PlaceId,
                   PlaceName = s.c.PlaceName
               })
               .Distinct()
               .ToListAsync();
                return await pf;
            }
        }

        public async Task<List<DO_AddressIN>> GetAreaList(int isdCode, int? stateCode, int? cityCode, string pincode)
        {
            using (var db = new eSyaEnterprise())
            {
                var pf = db.GtAddrin
               .Where(w => w.ActiveStatus
                    && w.Isdcode == isdCode
                    && (w.StateCode == stateCode || stateCode == null)
                    && (w.CityCode == cityCode || cityCode == null)
                    && (w.Pincode == pincode || pincode == null))
               .Select(s => new DO_AddressIN
               {
                   IsdCode = s.Isdcode,
                   AreaCode = s.AreaCode,
                   AreaName = s.AreaName,
                   StateCode = s.StateCode,
                   CityCode = s.CityCode,
                   District = s.District,
                   Pincode = s.Pincode
               })
               .ToListAsync();
                return await pf;
            }
        }

        public async Task<DO_AddressIN> GetAreaDetailsbyPincode(int isdCode, string pincode)
        {
            using (var db = new eSyaEnterprise())
            {
                var pf = db.GtAddrin
               .Where(w => w.ActiveStatus
                    && w.Isdcode == isdCode && w.Pincode == pincode)
               .Select(s => new DO_AddressIN
               {
                   IsdCode = s.Isdcode,
                   AreaCode = s.AreaCode,
                   AreaName = s.AreaName,
                   StateCode = s.StateCode,
                   CityCode = s.CityCode,
                   District = s.District,
                   Pincode = s.Pincode
               })
               .FirstOrDefaultAsync();
                return await pf;
            }
        }

        public async Task<DO_AddressIN> GetPinCodebyAreaCode(int isdCode, int? stateCode, int? cityCode, int areacode)
        {
            using (var db = new eSyaEnterprise())
            {
                var pf = db.GtAddrin
               .Where(w => w.ActiveStatus
                    && w.Isdcode == isdCode && w.StateCode == stateCode && w.CityCode == cityCode && w.AreaCode == areacode)
               .Select(s => new DO_AddressIN
               {
                   IsdCode = s.Isdcode,
                   AreaCode = s.AreaCode,
                   AreaName = s.AreaName,
                   StateCode = s.StateCode,
                   CityCode = s.CityCode,
                   District = s.District,
                   Pincode = s.Pincode
               })
               .FirstOrDefaultAsync();
                return await pf;
            }
        }

        public async Task<List<DO_IsdCodes>> GetISDCodesbyBusinessKey(int businessKey)
        {
            using (var db = new eSyaEnterprise())
            {
                try
                {
                    var do_cl = db.GtEcbsln
                        .Join(db.GtEcbssg.Where(w => w.ActiveStatus),
                        l => new { l.SegmentId },
                        c => new { c.SegmentId },
                        (l, c) => new { l, c })
                        .Join(db.GtEccncd.Where(w => w.ActiveStatus),
                        lc => new { lc.c.Isdcode },
                        o => new { o.Isdcode },
                        (lc, o) => new { lc, o })
                        .Where(w => w.lc.l.BusinessKey == businessKey && w.lc.l.ActiveStatus)
                       .AsNoTracking()
                       .Select(r => new DO_IsdCodes
                       {
                           IsdCode = r.lc.c.Isdcode,
                           CountryName = r.o.CountryName
                       }).ToListAsync();

                    return await do_cl;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public async Task<DO_BusinessAddress> GetBusinessAddressbyBusinessKey(int businessKey, int isdCode)
        {
            using (var db = new eSyaEnterprise())
            {
                try
                {
                    var do_cl = db.GtEcbsla
                        .Join(db.GtEccnpl.Where(w => w.PlaceType == PlaceTypeValues.State && w.ActiveStatus && w.Isdcode == isdCode),
                        l => new { l.StateCode },
                        c => new { StateCode = c.PlaceId },
                        (l, c) => new { l, c })
                        .Join(db.GtEccnpl.Where(w => w.PlaceType == PlaceTypeValues.City && w.ActiveStatus && w.Isdcode == isdCode),
                        lc => new { lc.l.CityCode },
                        o => new { CityCode = o.PlaceId },
                        (lc, o) => new { lc, o })
                        .Join(db.GtAddrin.Where(w => w.ActiveStatus && w.Isdcode == isdCode),
                        lco => new { lco.lc.l.AreaCode },
                        d => new { d.AreaCode },
                        (lco, d) => new { lco, d })
                        .Where(w => w.lco.lc.l.BusinessKey == businessKey)
                       .AsNoTracking()
                       .Select(r => new DO_BusinessAddress
                       {
                           BusinessKey = r.lco.lc.l.BusinessKey,
                           AreaCode = r.lco.lc.l.AreaCode,
                           CityCode = r.lco.lc.l.CityCode,
                           StateCode = r.lco.lc.l.StateCode,
                           Address = r.lco.lc.l.Address,
                           Pincode = r.lco.lc.l.Pincode,
                           EMailId = r.lco.lc.l.EMailId,
                           WebSite = r.lco.lc.l.WebSite,
                           PhoneNumber = r.lco.lc.l.PhoneNumber,
                           EmergencyNumber = r.lco.lc.l.EmergencyNumber,
                           AreaName = r.d.AreaName,
                           CityName = r.lco.o.PlaceName,
                           StateName = r.lco.lc.c.PlaceName,
                           IsdCode = isdCode
                       }).FirstOrDefaultAsync();

                    return await do_cl;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public async Task<DO_ReturnParameter> InsertOrUpdateIntoBusinessAddress(DO_BusinessAddress obj)
        {
            using (var db = new eSyaEnterprise())
            {
                using (var dbContext = db.Database.BeginTransaction())
                {
                    try
                    {
                        var _ba = db.GtEcbsla.Where(w => w.BusinessKey == obj.BusinessKey).FirstOrDefault();
                        if (_ba != null)
                        {
                            _ba.AreaCode = obj.AreaCode;
                            _ba.CityCode = obj.CityCode;
                            _ba.StateCode = obj.StateCode;
                            _ba.Address = obj.Address;
                            _ba.Pincode = obj.Pincode;
                            _ba.EMailId = obj.EMailId;
                            _ba.WebSite = obj.WebSite;
                            _ba.PhoneNumber = obj.PhoneNumber;
                            _ba.EmergencyNumber = obj.EmergencyNumber;
                            _ba.ModifiedBy = obj.UserID;
                            _ba.ModifiedOn = System.DateTime.Now;
                            _ba.ModifiedTerminal = obj.TerminalID;
                            await db.SaveChangesAsync();
                            dbContext.Commit();
                            return new DO_ReturnParameter() { Status = true, Message = "Business Address Updated Sucessfully" };
                        }
                        else
                        {
                            var _bdress = new GtEcbsla
                            {
                                BusinessKey = obj.BusinessKey,
                                AreaCode = obj.AreaCode,
                                CityCode = obj.CityCode,
                                StateCode = obj.StateCode,
                                Address = obj.Address,
                                Pincode = obj.Pincode,
                                EMailId = obj.EMailId,
                                WebSite = obj.WebSite,
                                PhoneNumber = obj.PhoneNumber,
                                EmergencyNumber = obj.EmergencyNumber,
                                FormId = obj.FormId,
                                CreatedBy = obj.UserID,
                                CreatedOn = System.DateTime.Now,
                                CreatedTerminal = obj.TerminalID
                            };
                            db.GtEcbsla.Add(_bdress);
                            await db.SaveChangesAsync();
                            dbContext.Commit();

                            return new DO_ReturnParameter() { Status = true, Message = "Business Address Created Successfully" };
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
