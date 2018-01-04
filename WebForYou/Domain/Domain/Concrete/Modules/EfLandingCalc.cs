using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Abstrac.Modules;
using Domain.Entityes.Modules;

namespace Domain.Concrete.Modules
{
    public class EfLandingCalc:ILandingCalc
    {
        readonly CalcLendingContext _context = new CalcLendingContext();
        public IEnumerable<LandingCalc> CalcLendingSites => _context.LandingCalcs;
        public void SaveModule(LandingCalc lendingCalc)
        {
            if (lendingCalc.ModuleId==0)
            {
                _context.LandingCalcs.Add(new LandingCalc
                {
                    ModulePrice = lendingCalc.ModulePrice,
                    ModuleCategory = lendingCalc.ModuleCategory,
                    ModuleDescription = lendingCalc.ModuleDescription,
                    ModuleName = lendingCalc.ModuleName
                });
                _context.SaveChanges();
            }
            else
            {
                LandingCalc newLendingCalc =
                    _context.LandingCalcs.FirstOrDefault(x => x.ModuleId == lendingCalc.ModuleId);
                if (newLendingCalc!=null)
                {
                    newLendingCalc.ModulePrice = lendingCalc.ModulePrice;
                    newLendingCalc.ModuleCategory = lendingCalc.ModuleCategory;
                    newLendingCalc.ModuleDescription = lendingCalc.ModuleDescription;
                    newLendingCalc.ModuleName = lendingCalc.ModuleName;
                    _context.SaveChanges();
                }
                else
                throw new Exception();
            }
        }

        public void RemoveModule(int moduleId)
        {
            LandingCalc removeLendingCalc = _context.LandingCalcs.FirstOrDefault(x => x.ModuleId == moduleId);
            if (removeLendingCalc!=null)
            {
                _context.LandingCalcs.Remove(removeLendingCalc);
                _context.SaveChanges();
            }
            else
             throw new Exception();
        }
    }
}
