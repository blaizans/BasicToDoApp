using Domain.DTOs;
using Models;

namespace Application.LogicInterfaces;

public interface ITodoLogic
{
    Task<Todo> CreateAsync(TodoCreationDto dto);
}