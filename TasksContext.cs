using Microsoft.EntityFrameworkCore;
using projectEf.Models;

namespace projectEf;


public class TasksContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Models.Task> Tasks { get; set; }

    public TasksContext(DbContextOptions<TasksContext> options) : base(options)
    {

    }

}