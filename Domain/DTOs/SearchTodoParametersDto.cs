namespace Domain.DTOs;

public class SearchTodoParametersDto
{
    public string? Username { get; }
    public int? UserId { get; }
    public bool? CompletedStatus { get; }
    public string? TitleContains { get; }

    public SearchTodoParametersDto(string? userName, int? userId, bool? completedStatus, string? titleContains)
    {
        Username = userName;
        UserId = userId;
        CompletedStatus = completedStatus;
        TitleContains = titleContains;
    }
}