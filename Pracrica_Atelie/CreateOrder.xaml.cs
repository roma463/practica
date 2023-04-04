using Pracrica_Atelie.Entitys;
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
using System.Windows.Shapes;

namespace Pracrica_Atelie
{

    /// <summary>
    /// Логика взаимодействия для CreateOrder.xaml
    /// </summary>
    public partial class CreateOrder : Window
    {
        private Grid _mainWindow;
        private int _currentEmployee;
        public CreateOrder(Grid mainWindow, int idEmployee)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
            _currentEmployee = idEmployee;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Order newOrder = new Order();
                newOrder.TimeOfOrder = DateTime.Parse(timeBegin.Text.ToString());
                newOrder.EndTime = DateTime.Parse(TimeEnd.Text.ToString());
                newOrder.IdEmployee = _currentEmployee;
                newOrder.IdClient = int.Parse(Client.Text);
                newOrder.IdTitleWork = Disain.IsChecked == true ? 4 : 1;
                newOrder.IdMaterials = int.Parse(Matetials.Text);
                _mainWindow.Create(newOrder);
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Вы ввели не корректные данные");
            }
        }
    }
}
