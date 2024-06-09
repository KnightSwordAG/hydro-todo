using System.ComponentModel.DataAnnotations;
using HydroTodo.Models;

namespace HydroTodo.ViewModels;

public record NewTodo([Required] string Content, Priority Priority = Priority.Normal);
