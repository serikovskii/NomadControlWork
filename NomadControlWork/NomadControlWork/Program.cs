﻿using NomadControlWork.Models;
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
                new User { FullName = "Timur", Subscribe = true, TimeSubscribe = 2, NumberCard = "9999 8888 7777 5555", Delivered = false},
                new User { FullName = "Alex", Subscribe = false, TimeSubscribe = 1, NumberCard = "9999 8888 4444 5555", Delivered = false}
            };

            List<Journal> journals = new List<Journal>
            {
                new Journal {FullName = "Январьский номер", NumberJournal = 101},
                new Journal {FullName = "Февральский номер", NumberJournal = 102},
                new Journal {FullName = "Мартовский номер", NumberJournal = 103},
                new Journal {FullName = "Апрельский номер", NumberJournal = 104},
                new Journal {FullName = "Майский номер", NumberJournal = 105}
            };

            var prints = new List<Print>();
            var deliveries = new List<Delivery>();

            using(var context = new NomadContext())
            {
                context.Users.AddRange(users);
                context.Journals.AddRange(journals);
                context.SaveChanges();

                var journalForPrint = journals.Where(journal => journal.FullName.Contains("Апрель")).FirstOrDefault();
                var countOfSubscribeUsers = users.Where(user => user.Subscribe = true).Where(user => user.Delivered = false).Count();

                prints.Add(new Print { JournalId = journalForPrint.Id, Edition = countOfSubscribeUsers });
                context.Prints.AddRange(prints);

                for (int i = 0; i < countOfSubscribeUsers; i++)
                {
                    deliveries.Add(new Delivery { JournalId = journalForPrint.Id, Status = true, UserId = context.Users.ToList()[i].Id });
                    context.Users.ToList()[i].Delivered = true;
                }
                context.Deliveries.AddRange(deliveries);
                context.SaveChanges();
            }

        }   
    }
}
