using Microsoft.EntityFrameworkCore;

namespace TodoAPIClass
{
    public class TodoDBContext : DbContext
    {
        //constructor
        public TodoDBContext(DbContextOptions options) : base(options)
        {

       
        }
        //this methods get called by the runtime
        DbSet<Todo> JOYSs{get; set;} //this will call all the models in the Todo class

    }
}
