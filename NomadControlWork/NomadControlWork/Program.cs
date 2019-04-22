using NomadControlWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomadControlWork
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>
            {
                new User { FullName = "Azat", Subscribe = true, TimeSubscribe = 1, NumberCard = "9999 8888 7777 6666", Delivered = false},
                new User { FullName = "Timur", Subscribe = true, TimeSubscribe = 2, NumberCard = "9999 8888 7777 5555", Delivered = false}
            };
            
        }
    }
}
