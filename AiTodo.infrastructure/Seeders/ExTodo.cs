using AiTodo.infrastructure.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiTodo.infrastructure.Seeders
{
    public class ExTodo
    {
        private readonly aitodoDBContext _context;
    
        public ExTodo(aitodoDBContext dBContext)
        {
            _context = dBContext;
        }
        public async Task Seed()
        {
            if (await _context.Database.CanConnectAsync())
            {
                if (!_context.Todos.Any())
                {
                    var todo = new domain.Entities.Todo()
                    {
                        Name = "Umyj naczynia",
                        Description = "umyj 10 talerzy",
                        IsComplete = false,
                        Status = 1,
                        Urgent = false,
                        Important = false
                    };
                    todo.EncodeTitle();
                    _context.Todos.Add(todo);
                    await _context.SaveChangesAsync();
                }
            }

        }
    }
}
