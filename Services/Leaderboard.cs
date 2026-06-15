using Minigames.Models;
using Minigames.DTOs;
using System.Linq;

namespace Minigames.Services;

public class Leaderboard
{
    private List<User> users;

    public Leaderboard(List<User> users)
    {
        this.users = users;
    }

    public List<LeaderboardDto> GetTopPlayersDto(int count)
    {
        return users
            .OrderByDescending(u => u.Stats.TimesWon)
            .Take(count)
            .Select(u => new LeaderboardDto(u.Name, u.Stats.TimesWon))
            .ToList();
    }
}