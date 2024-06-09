namespace HydroTodo.ViewModels;

public enum Priority
{
    Low,
    Normal,
    High
}
public record NewTodo(string Content, Priority Priority = Priority.Normal);
