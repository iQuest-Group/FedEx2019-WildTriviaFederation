using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace FedEx2019.WTF.Data
{
    public class GameServiceMock : IGameService
    {
        private static ConcurrentDictionary<Guid, List<string>> games = new ConcurrentDictionary<Guid, List<string>>();

        public bool RegisterPlayer(Guid gameId, string playerName)
        {
            games.TryGetValue(gameId, out var players);

            if (players == null)
            {
                return games.TryAdd(gameId, new List<string> {playerName});
            }

            players.Add(playerName);
            return true;
        }

        public List<string> GetGamePlayers(Guid gameId)
        {
            games.TryGetValue(gameId, out var players);

            return players;
        }
    }
}
