namespace Minigames.DTOs;

/// <summary>
/// DTO used to transfer leaderboard data without exposing full User entity - output Dto
/// </summary>
public record LeaderboardDto(string Name, int Value, string Label);