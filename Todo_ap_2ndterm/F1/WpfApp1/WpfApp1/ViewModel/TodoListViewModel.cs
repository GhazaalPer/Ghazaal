using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Data;
using WpfApp1List.Model;
using WpfApp1Todo.Model;

namespace WpfApp1.ViewModel
{

    public class TodoListViewModel : ViewModelBase
    {


        private readonly TodoListDataProvider _todoListDataProvider;
        private TodoListItemViewModel? _selectedTodoList;

        public TodoListViewModel(TodoListDataProvider TodoListDataProvider)
        {
            _todoListDataProvider = TodoListDataProvider;
        }
        //observable-->=list
        public ObservableCollection<TodoListItemViewModel> OTodoLists { get; } = new();

        public TodoListItemViewModel? SelectedTodoList
        {
            get => _selectedTodoList;
            set
            {
                _selectedTodoList = value;
                RaisePropertyChanged();
            }
        }


        public async Task LoadAsync()
        {
            if (OTodoLists.Any())
            {
                return;
            }

            var TodoLists = await _todoListDataProvider.GetAllAsync();

            if (TodoLists is not null)
            {
                OTodoLists.Clear();
                foreach (var TodoList in TodoLists)
                {

                    OTodoLists.Add(new TodoListItemViewModel(TodoList));
                }
            }
        }


        public async Task Add()

        {
            // TodoDataProvider.addtask
            //  if موفق بود
            var newtodoasy = await _todoListDataProvider.CreateTaskAsync();

            var viewModel = new TodoListItemViewModel(newtodoasy);

            OTodoLists.Add(viewModel);//

            SelectedTodoList = viewModel;
        }
        public async Task  GetByIdList(int id)
        {

            var todoLists = await _todoListDataProvider.GetByIdListAsync(id);
            SelectedTodoList.Name = todoLists.Name;

        }
        public async Task Update(TodoListItemViewModel t)
        {
            var oldtodo = t;
            var newtodoasy = await _todoListDataProvider.UpdateTodoAsync(t);

        }

        public async Task Delete(int id)
        {
            var deletedtask_Id = await _todoListDataProvider.DeleteTodoAsync(id);
            var deletedTask = OTodoLists.FirstOrDefault(t => t.Id == id);
            if (deletedTask != null)
            {
                OTodoLists.Remove(deletedTask);
                SelectedTodoList = null; // یا هر اقدام دیگری که باید برای SelectedTodo انجام دهید
            }
        }



    }
}
