using BlazorBattles.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorBattles.Client.Services
{
    public interface IBattleService
    {
        public BattleResult LastBattle { get; set; }
        IList<BattleHistoryEntry> History { get; set; }
        Task<BattleResult> StartBattle(int opponentId);
        Task GetHistory();
    }
}
