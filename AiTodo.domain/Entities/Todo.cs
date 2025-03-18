using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiTodo.domain.Entities
{
   
    internal class Todo
    {
        public required int Id { get; set; }
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
        public DateTime? DueDate { get; set; } = DateTime.UtcNow;
        public bool? IsComplete { get; set; }
        public int? Status { get; set; }
        public bool? Urgent { get; set; }
        public bool? Important { get; set; }
    }
}
