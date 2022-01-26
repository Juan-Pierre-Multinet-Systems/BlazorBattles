using BlazorBattles.Shared;
using System.Collections.Generic;

namespace BlazorBattles.Client.Services
{
    public interface IUnitService
    {
        IList<Unit> Units { get;}
        IList<UserUnit> MyUniits { get; set;}
        void AddUnit(int unitId);
    }
}
