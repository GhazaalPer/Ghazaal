using System.Text;
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
//using WpfApp1Todo.ViewModel;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>آ
    /// 

    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();


        }
        private void TodoView_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void TodoListView_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}







//namespace WpfApp1.View
//{

//    public partial class TaskView : UserControl
//    {
//        private TaskViewModel _viewModel;

//        public TaskView()
//        {
//            InitializeComponent();
//            _viewModel = new TaskViewModel(new TaskDataProvider());
//            DataContext = _viewModel;
//            //Loaded += TasksView_Loaded;

//        }

//        //private async void TasksView_Loaded(object sender, RoutedEventArgs e)
//        //{
//        //    await _viewModel.LoadAsync();
//        //}

//        private void ButtonMoveNavigation_Click(object sender, RoutedEventArgs e)
//        {
//            _viewModel.MoveNavigation();
//        }

//        private void ButtonCreat_Click(object sender, RoutedEventArgs e)
//        {
//            _viewModel.Creat();
//        }

       

//        private void ButtonMinimizeEdit(object sender, RoutedEventArgs e)
//        {
//            _viewModel.SelectedTask = null;
//            smals.Visibility = Visibility.Collapsed;

//        }
//    }
//}
