using NomadControlWork;
using NomadControlWork.Models;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    public partial class SubscribeWindow : Window
    {
        private int _year;
        public SubscribeWindow()
        {
            InitializeComponent();
        }

        private void SubscribeButtonForDatabase(object sender, RoutedEventArgs e)
        {
            string name;
            if (nameSub.Text.Length == 0)
            {
                MessageBox.Show("Норм введи");
                return;
            }
            else
                name = nameSub.Text;

            string adress;
            if (adressSub.Text.Length == 0)
            {
                MessageBox.Show("Норм введи");
                return;
            }
            else
                adress = adressSub.Text;

            
            if (yearSub.SelectedItem == null)
            {
                MessageBox.Show("норм введи");
                return;
            }
             
            using (var context = new NomadContext())
            {
                var user = new User
                {
                    FullName = name, Adress = adress, Subscribe = true, Delivered = false, TimeSubscribe = _year
                };
                context.Users.Add(user);
                context.SaveChanges();
            }

            MessageBox.Show("все подписался");

            Close();
        }


        private void SelectYearBox(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;

            _year = int.Parse(selectedItem.Content.ToString());
        }
    }
}
