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
using WorkerWPF.Contex;
using WorkerWPF.Model;

namespace WorkerWPF.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для ActionPage.xaml
    /// </summary>
    public partial class ActionPage : Page   
    {
        public Information Information { get; set; }
        public ActionPage(Information Information)
        {
            InitializeComponent();
            this.Information = Information;
            this.DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(Information.ID==0)
            {
                AppData.db.Information.Add(Information);    
            }
            AppData.db.SaveChanges();
            MessageBox.Show("Данные добавлены","Успешно",MessageBoxButton.OK,MessageBoxImage.Information);
            NavigationService.GoBack();
        }
    }
}
