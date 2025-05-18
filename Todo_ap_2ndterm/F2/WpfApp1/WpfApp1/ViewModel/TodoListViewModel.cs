using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Data;
using WpfApp1List.Model;
using WpfApp1Todo.Model;
using WpfApp1.ViewModel;
using WpfApp1.Model;


namespace WpfApp1.Todolist.ViewModel
{

    public class TodoListViewModel : ViewModelBase
    {

        private readonly TodoDataProvider _TodoDataProvider;
        private TodoItemViewModel? _selectedTodo;
        public TodoListDataProvider _todoListDataProvider;

        private TodoListItemViewModel? _selectedTodoList;

        public ObservableCollection<TodoItemViewModel> OGeneral { get; } = new();

        public ObservableCollection<TodoListItemViewModel> OTodoLists { get; } = new();
        private Todo2 _todo2;
        public ObservableCollection<TodoItemViewModel> OTodos { get; } = new();
        public ObservableCollection<TodoItemViewModel> OListPick{ get; } = new();


        public Todo2 Todo2
        {
            get => _todo2;
            set
            {
                _todo2 = value;
                RaisePropertyChanged(nameof(Todo2));
            }
        }
        public TodoListViewModel(TodoDataProvider TodoDataProvider, TodoListDataProvider todoListDataProvider)
        {
            _TodoDataProvider = TodoDataProvider;
            _todoListDataProvider = todoListDataProvider;
            _todo2 = new Todo2();


        }

        public TodoItemViewModel? SelectedTodo
        {
            get
            {

                return _selectedTodo;
            }
            set
            {
                _selectedTodo = value;
                RaisePropertyChanged();
                foreach (var l in OTodoLists)
                {
                    if(_selectedTodo != null)
                    {

                    if (_selectedTodo.ListId == l.Id)
                    {
                        Todo2.ListName = l.Name;
                        RaisePropertyChanged(nameof(Todo2));

                    }
                    }
                }

            }
        }

       

        public TodoListItemViewModel? SelectedTodoList
        {
            get => _selectedTodoList;
            set
            {
                _selectedTodoList = value;
                RaisePropertyChanged();
                  OListPick.Clear();
                foreach (var t in OTodos)
                {
                    if (_selectedTodoList != null)
                    {
                        if (_selectedTodoList.Id == t.ListId)
                        {
                            OListPick.Add(t);


                        }
                    }
                }
            }
        }


        public async Task LoadAsync()
        {

            if (OTodos.Any())
            {
                return;
            }
            var todos = await _TodoDataProvider.GetAllAsync();
            if (todos is not null)
            {
                OTodos.Clear();
                foreach (var T in todos)
                {
                    OTodos.Add(new TodoItemViewModel(T));
                }
            }
            if (OTodoLists.Any()) { return; }

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
        public async Task FilterChecked()
        {
            var fc = await _TodoDataProvider.GetFilteredAsync_Checked();

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

              //  SelectedTodoList = null; 
            }
        }
        public async Task AddT(int listid)

        {
          
            var newtodoasy = await _TodoDataProvider.CreateTaskAsync(listid);

            var viewModel = new TodoItemViewModel(newtodoasy) { ListId=listid};

            OTodos.Add(viewModel);
            OListPick.Add(viewModel);
            //

            SelectedTodo = viewModel;
        }
        public async Task UpdateT(TodoItemViewModel t)
        {
            var oldtodo = t;
            var newtodoasy = await _TodoDataProvider.UpdateTodoAsync(t);

        }

        public async Task DeleteT(int id)
        {
            var deletedtask_Id = await _TodoDataProvider.DeleteTodoAsync(id);
            var deletedTask = OTodos.FirstOrDefault(t => t.Id == id);
            var d = OListPick.FirstOrDefault(t => t.Id == id);
            if (deletedTask != null)
            {
                OTodos.Remove(deletedTask);
                OListPick.Remove(d);
               // SelectedTodo = null; 
            }
        }



    }
}
