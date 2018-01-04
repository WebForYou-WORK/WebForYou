using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Abstrac.Modules;
using Domain.Entityes.Modules;

namespace Domain.Concrete.Modules
{
     public class EfSiteCatalogCalc: ISiteCatalogCalc
    {
        readonly CalcSiteCatalogContext _context = new CalcSiteCatalogContext();
        public IEnumerable<SiteCatalogCalc> CalcCatalogSites => _context.CatalogCalcs;
        public void SaveModule(SiteCatalogCalc catalogCalc)
        {
            if (catalogCalc.ModuleId == 0)
            {
                _context.CatalogCalcs.Add(new SiteCatalogCalc
                {
                    ModuleName = catalogCalc.ModuleName,
                    ModuleDescription = catalogCalc.ModuleDescription,
                    ModulePrice = catalogCalc.ModulePrice,
                    ModuleCategory = catalogCalc.ModuleCategory
                });
                _context.SaveChanges();
            }
            else
            {
                SiteCatalogCalc editCatalogCalc =
                    _context.CatalogCalcs.FirstOrDefault(x => x.ModuleId == catalogCalc.ModuleId);
                if (editCatalogCalc!=null)
                {
                    editCatalogCalc.ModuleName = catalogCalc.ModuleName;
                    editCatalogCalc.ModuleCategory = catalogCalc.ModuleCategory;
                    editCatalogCalc.ModuleDescription = catalogCalc.ModuleDescription;
                    editCatalogCalc.ModulePrice = catalogCalc.ModulePrice;
                    _context.SaveChanges();
                }
                else
                    throw new Exception();
            }
        }

        public void RemoveModule(int moduleId)
        {
            SiteCatalogCalc removeCatalogCalc = _context.CatalogCalcs.FirstOrDefault(x => x.ModuleId == moduleId);
            if (removeCatalogCalc!=null)
            {
                _context.CatalogCalcs.Remove(removeCatalogCalc);
                _context.SaveChanges();
            }
            else
                throw new Exception();
        }
    }
}
