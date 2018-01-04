using System;
using System.Collections.Generic;
using Domain.Entityes.Modules;

namespace Domain.Abstrac.Modules
{
    public interface ILandingCalc
    {
        IEnumerable<LandingCalc> CalcLendingSites { get; }
        void SaveModule(LandingCalc lendingCalc);
        void RemoveModule(int moduleId);
    }
}
