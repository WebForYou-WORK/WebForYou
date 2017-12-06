﻿using System.Collections.Generic;
using Domain.Entityes;

namespace Domain.Abstrac
{
   public interface ICalcSite
    {
        IEnumerable<CalcSite> CalcSites { get; }
        void SaveModule(CalcSite calcSite, int categoryId);
        void RemoveModule(int moduleId);
    }
}
