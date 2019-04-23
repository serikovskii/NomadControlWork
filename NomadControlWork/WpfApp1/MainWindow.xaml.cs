using NomadControlWork;
using NomadControlWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void UnsubscribeButton(object sender, RoutedEventArgs e)
        {
            var unsubscribeWindow = new UnsubscribeWindow();
            unsubscribeWindow.Show();
        }
        private void SubscribeButton(object sender, RoutedEventArgs e)
        {
            var subscribeWindow = new SubscribeWindow();
            subscribeWindow.Show();
        }
        private void SendButton(object sender, RoutedEventArgs e)
        {
            var prints = new List<Print>();
            var deliveries = new List<Delivery>();
            using (var context = new NomadContext())
            {
                var journalForPrint = context.Journals.Where(journal => journal.FullName.Contains("Апрель")).FirstOrDefault();
                var subscribeUsers = context.Users.Where(user => user.Subscribe == true).Where(user => user.Delivered == false).ToList();

                prints.Add(new Print { JournalId = journalForPrint.Id, Edition = subscribeUsers.Count() });
                context.Prints.AddRange(prints);

                foreach (var idUsers in subscribeUsers)
                {
                    deliveries.Add(new Delivery { JournalId = journalForPrint.Id, Status = true, UserId = idUsers.Id });
                    for (int i = 0; i < context.Users.ToList().Count; i++)
                    {
                        if (context.Users.ToList()[i].Id == idUsers.Id)
                            context.Users.ToList()[i].Delivered = true;
                    }
                }
                context.Deliveries.AddRange(deliveries);
                context.SaveChanges();
            }
        }
    }
}
