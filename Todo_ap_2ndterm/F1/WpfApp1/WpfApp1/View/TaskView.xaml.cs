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
using WpfApp1.Data;
using WpfApp1.ViewModel;
using WpfApp1Todo.Model;
using WpfApp1Todo.ViewModel;

namespace WpfApp1.View
{
    /// <summary>
    /// Interaction logic for TaskView.xaml
    /// </summary>
    public partial class TaskView : UserControl
    {
        private TodoViewModel _viewModel;

        private async void TodoView_Loaded(object sender, RoutedEventArgs e)//1:28
        {
            await _viewModel.LoadAsync();
        }
        public TaskView()
        {
            InitializeComponent();

            _viewModel = new TodoViewModel(new TodoDataProvider());
            DataContext = _viewModel;  //پیش فرض datacontext تعریف شده
            Loaded += TodoView_Loaded;  //Laoded=یه ایونته که پیشفرض تعذیف شده

        }


       

        private void CreatNewTaskBtn_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.Add();

        }

        private void Deletetaskbtn_click(object sender, RoutedEventArgs e)
        {
            // دریافت دکمه کلیک شده
            var button = sender as Button;
            if (button != null)
            {
                int id = (int)button.Tag;
                _viewModel.Delete(id);
            }
        }
        private async void Edittaskbtn_click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                var t = (TodoItemViewModel)button.Tag;
                _viewModel.Update(t);
            }


        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
                if (Tododetails.Visibility == Visibility.Collapsed)
                {
                    Tododetails.Visibility = Visibility.Visible;
                }
        }
    }
}
