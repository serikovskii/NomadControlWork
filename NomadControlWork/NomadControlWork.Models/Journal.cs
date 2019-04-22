using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomadControlWork.Models
{
    public class Journal
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public int NumberJournal { get; set; }
        public Journal()
        {
            Id = Guid.NewGuid();
        }
    }
}
