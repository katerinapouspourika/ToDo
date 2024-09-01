using Microsoft.EntityFrameworkCore;

namespace Todo.Data;

public class TodoDbContext(DbContextOptions<TodoDbContext> options) 
    : DbContext(options)
{
}