using System.ComponentModel.DataAnnotations;

using HydroTodo.ViewModels;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HydroTodo.Models;

public class Database(DbContextOptions<Database> options) : DbContext(options)
{
    public DbSet<Todo> Todos => Set<Todo>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Todo>()
            .Property(todo => todo.Priority)
            .HasDefaultValue(Priority.Normal)
            .HasConversion<EnumToStringConverter<Priority>>();
    }
}

public enum Priority
{
    Low = -1,
    Normal = 0,
    High = 1
}

public class Todo
{
    public int Id { get; set; }
    [MaxLength(300)]
    public string Content { get; set; } = "";

    public Priority Priority { get;set; } = Priority.Normal;
    public bool Done { get; set; }
}