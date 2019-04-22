using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomadControlWork.Models
{
    public class Print
    {
        public Guid Id { get; set; }
        public int JournalId { get; set; }
        public int Edition { get; set; }
        public Print()
        {
            Id = Guid.NewGuid();
        }
    }
}
