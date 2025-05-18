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
using WpfApp1.Todolist.ViewModel;
using WpfApp1List.Model;

namespace WpfApp1.View
{
  
    public partial class ListTodoView : UserControl
    {
        private TodoListViewModel _viewModel;
               private async void TodoListView_Loaded(object sender, RoutedEventArgs e)
        {
            await _viewModel.LoadAsync();
        }


        public ListTodoView()
        {
            InitializeComponent();
            _viewModel = new TodoListViewModel(new TodoDataProvider(),new TodoListDataProvider());
            DataContext = _viewModel; 
            Loaded += TodoListView_Loaded;  
        }
    

  
    
        private void ButtonCreatList_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.Add();

        }
        private void TodoView_Loaded(object sender, RoutedEventArgs e)
        {

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
        private void View_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listview.Visibility == Visibility.Collapsed)
            {
                listview.Visibility = Visibility.Visible;
            }
        }
        private async void Edittaskbtn_click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                var t = (TodoItemViewModel)button.Tag;
                _viewModel.UpdateT(t);
            }


        }
        private void CreatNewTaskBtn_Click(object sender, RoutedEventArgs e)
        {
           
            var button = sender as Button;
            if (button != null)
            {
                int id = (int)button.Tag;
                _viewModel.AddT(id);
            }

        }

        private void Deletetaskbtn_click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                int id = (int)button.Tag;
                _viewModel.DeleteT(id);
            }
        }
       

        private void filtercheck_btn(object sender, RoutedEventArgs e)
        {
            _viewModel.FilterChecked();

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
