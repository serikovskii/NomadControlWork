using NomadControlWork;
using System.Linq;
using System.Windows;

namespace WpfApp1
{
    public partial class UnsubscribeWindow : Window
    {
        public UnsubscribeWindow()
        {
            InitializeComponent();
        }
        private void UnsubscribeButtonForDatabase(object sender, RoutedEventArgs e)
        {
            string name;
            if (nameText.Text.Length == 0)
            {
                MessageBox.Show("Норм введи");
                return;
            }
            else if (!CheckInName(nameText.Text))
            {
                MessageBox.Show("нету или уже отписан");
                return;
            }
            else
                name = nameText.Text;

            using(var context = new NomadContext())
            {
                var userUnsub = context.Users.Where(user => user.FullName == name).Where(user => user.Subscribe == true).FirstOrDefault();
                
                for(int i = 0; i < context.Users.Count(); i++)
                {
                    if (context.Users.ToList()[i].Id == userUnsub.Id)
                        context.Users.ToList()[i].Subscribe = false;
                }
                context.SaveChanges();
            }
            
            MessageBox.Show("отписался.. зряяя");

            Close();
        }

        private bool CheckInName(string name)
        {
            using(var context = new NomadContext())
            {
                foreach(var user in context.Users)
                {
                    if(user.FullName == name)
                        return true;
                }
                
            }
            return false;
        }
    }
}
