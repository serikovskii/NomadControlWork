using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomadControlWork.Models
{
    public class Delivery
    {
        public Guid Id { get; set; }
        public int JournalId { get; set; }
        public int UserId { get; set; }
        public bool Status { get; set; }
        public Delivery()
        {
            Id = Guid.NewGuid();
        }
    }
}
