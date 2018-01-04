using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Abstrac.Modules;
using Domain.Entityes.Modules;

namespace Domain.Concrete.Modules
{
    public class EfCorporateWebsiteCalc : ICorporateWebsiteCalc
    {
        readonly CalcCorporateWebsiteContext _context = new CalcCorporateWebsiteContext();
        public IEnumerable<CorporateWebsiteCalc> CalcCorporateSites => _context.CorporateWebsiteCalcs;

        public void SaveModule(CorporateWebsiteCalc corporateWebsiteCalc)
        {
            if (corporateWebsiteCalc.ModuleId == 0)
            {
                _context.CorporateWebsiteCalcs.Add(new CorporateWebsiteCalc
                {
                    ModuleCategory = corporateWebsiteCalc.ModuleCategory,
                    ModuleDescription = corporateWebsiteCalc.ModuleDescription,
                    ModuleName = corporateWebsiteCalc.ModuleName,
                    ModulePrice = corporateWebsiteCalc.ModulePrice
                });
                _context.SaveChanges();
            }
            else
            {
                CorporateWebsiteCalc editCorporateWebsiteCalc =
                    _context.CorporateWebsiteCalcs.FirstOrDefault(x => x.ModuleId == corporateWebsiteCalc.ModuleId);
                if (editCorporateWebsiteCalc!=null)
                {
                    editCorporateWebsiteCalc.ModuleCategory = corporateWebsiteCalc.ModuleCategory;
                    editCorporateWebsiteCalc.ModuleDescription = corporateWebsiteCalc.ModuleDescription;
                    editCorporateWebsiteCalc.ModuleName = corporateWebsiteCalc.ModuleName;
                    editCorporateWebsiteCalc.ModulePrice = corporateWebsiteCalc.ModulePrice;
                    _context.SaveChanges();
                }
                else
                 throw new Exception();
            }
        }

        public void RemoveModule(int moduleId)
        {
            CorporateWebsiteCalc removeCorporateWebsiteCalc =
                    _context.CorporateWebsiteCalcs.FirstOrDefault(x => x.ModuleId == moduleId);
            if (removeCorporateWebsiteCalc!=null)
            {
                _context.CorporateWebsiteCalcs.Remove(removeCorporateWebsiteCalc);
                _context.SaveChanges();
            }
            else
             throw new Exception();
        }
    }
}
