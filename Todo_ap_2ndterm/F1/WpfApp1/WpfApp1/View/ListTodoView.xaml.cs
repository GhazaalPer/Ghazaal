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
using WpfApp1Todo.ViewModel;

namespace WpfApp1.View
{
    /// <summary>
    /// Interaction logic for ListTodoView.xaml
    /// </summary>
    public partial class ListTodoView : UserControl
    {
        private TodoListViewModel _viewModel;
               private async void TodoListView_Loaded(object sender, RoutedEventArgs e)//1:28
        {
            await _viewModel.LoadAsync();
        }


        public ListTodoView()
        {
            InitializeComponent();
            _viewModel = new TodoListViewModel(new TodoListDataProvider());
            DataContext = _viewModel;  //پیش فرض datacontext تعریف شده
            Loaded += TodoListView_Loaded;  //
        }
    

  
    
        private void ButtonCreatList_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.Add();

        }

        private void ButtonDeleteList_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                int id = (int)button.Tag;
                _viewModel.Delete(id);
            }
        }

        private void EditListbtn_click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                var t = (TodoListItemViewModel)button.Tag;
                _viewModel.Update(t);
            }

        }
    }
}
