namespace Minigames.DTOs;
// DTO (Data Transfer Object) used to transfer a user's guess safely to the game logic -  it is an input DTO

public record GuessDto(char Letter);
