using BlazorBattles.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorBattles.Client.Services
{
    public interface IUnitService
    {
        IList<Unit> Units { get; set; }
        IList<UserUnit> MyUnits { get; set;}
        Task AddUnit(int unitId);
        Task LoadUnitsAsync();
        Task LoadUserUnitsAsync();
        Task ReviveArmy();
    }
}
