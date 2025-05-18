using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WpfApp1.Data;
using WpfApp1.ViewModel;
using WpfApp1Todo.Model;

namespace WpfApp1Todo.ViewModel
{

    public class TodoViewModel : ViewModelBase
    {


        private readonly TodoDataProvider _TodoDataProvider;
        private TodoItemViewModel? _selectedTodo;
        public ObservableCollection<TodoItemViewModel> OTodos { get; } = new();

        public TodoViewModel(TodoDataProvider TodoDataProvider)
        {
            _TodoDataProvider = TodoDataProvider;
        }
        //observable-->=list

        public TodoItemViewModel? SelectedTodo
        {
            get => _selectedTodo;
            set
            {
                _selectedTodo = value;
                RaisePropertyChanged();
            }
        }


        public async Task LoadAsync()
        {
            //otodo==Observa...

             if (OTodos.Any())
            {
                return;
            }
            //read from dataprovider and add to obser....
             var todos = await _TodoDataProvider.GetAllAsync();


            if (todos is not null )
            {
                OTodos.Clear();
                foreach (var T in todos)
                {

                    OTodos.Add(new TodoItemViewModel(T));
                }
            }
        }

        public async Task Add()

        {
            // TodoDataProvider.addtask
            //  if موفق بود
            var newtodoasy = await _TodoDataProvider.CreateTaskAsync();

            var viewModel = new TodoItemViewModel(newtodoasy);

            OTodos.Add(viewModel);//

            SelectedTodo = viewModel;
        }
        public async Task Update(TodoItemViewModel t)
        {
            var oldtodo = t;
            var newtodoasy = await _TodoDataProvider.UpdateTodoAsync(t);

        }

        public async Task Delete(int id)
        {
            var deletedtask_Id = await _TodoDataProvider.DeleteTodoAsync(id);
            var deletedTask = OTodos.FirstOrDefault(t => t.Id == id);
            if (deletedTask != null)
            {
                OTodos.Remove(deletedTask);
                SelectedTodo = null; // یا هر اقدام دیگری که باید برای SelectedTodo انجام دهید
            }
        }

       


    }
}
