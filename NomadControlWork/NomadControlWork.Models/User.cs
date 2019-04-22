using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomadControlWork.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public bool Subscribe { get; set; }
        public int TimeSubscribe { get; set; }
        public bool Delivered { get; set; }
        public string NumberCard { get; set; }

        public User()
        {
            Id = Guid.NewGuid();
        }
    }
}
