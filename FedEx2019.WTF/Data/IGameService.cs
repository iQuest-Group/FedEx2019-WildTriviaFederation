using System;
using System.Collections.Generic;

namespace FedEx2019.WTF.Data
{
    public interface IGameService
    {
        bool RegisterPlayer(Guid gameId, string playerName);

        List<string> GetGamePlayers(Guid gameId);
    }
}
