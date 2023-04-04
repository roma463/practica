using Pracrica_Atelie.Entitys;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Логика взаимодействия для Grid.xaml
    /// </summary>
    public partial class Grid : Window
    {
        Entities db = Entities.GetContext();
        private int _currentMaster = 3;
        public Grid()
        {
            refresh();
        }

        private void btn_delete_Click(object sender, RoutedEventArgs e)
        {
            // получаем выбранный элемент
            Order selectedItem = dtg_orders.SelectedItem as Order;

            if (selectedItem != null)
            {

                // получаем DbSet для таблицы, содержащей элементы
                DbSet<Order> items = db.Order;

                // удаляем элемент из DbSet
                items.Remove(selectedItem);

                // сохраняем изменения в базе данных
                db.SaveChanges();
                refresh();
            }
        }
        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            CreateOrder create = new CreateOrder(this, _currentMaster);
            create.Show();
        }

        public void Create(Order Order)
        {
            db.Order.Add(Order);
            db.SaveChanges();
            refresh();
        }

        private void btn_red_Click(object sender, RoutedEventArgs e)
        {
            // получаем выбранный элемент
            Order selectedItem = dtg_orders.SelectedItem as Order;

            if (selectedItem != null)
            {
                db.Entry(selectedItem).State = EntityState.Modified;
                // сохраняем изменения в базе данных
                db.SaveChanges();
                refresh();
            }
        }
        public void refresh()
        {
            InitializeComponent();
            var querry = db.Order;
            dtg_orders.ItemsSource = querry.ToList();
        }
    }
}