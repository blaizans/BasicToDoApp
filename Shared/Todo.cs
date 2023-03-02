namespace Shared;

public class Todo
{
    public int Id { get; set; }
    public User Owner {get;}
    public string Ttile { get; }
    public bool IsCompleted { get; }

    public Todo(User owner, string title)
    {
        Owner = owner;
        Title = title;
    }
}