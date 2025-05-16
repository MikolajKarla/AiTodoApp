using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiTodo.infrastructure.Persistance
{
    public class aitodoDBContext:DbContext
    {
        public aitodoDBContext(DbContextOptions<aitodoDBContext> options) :base(options) { 
        
        
        
        }

        public DbSet<domain.Entities.Todo> Todos { get; set; }

        //protected override void onTodoCreate(ModelBuilder modelBuilder){}



    }
}
