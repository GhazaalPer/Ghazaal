using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1List.Model;
using WpfApp1Todo.Model;

namespace WpfApp1.ViewModel
{
      
    public class TodoListItemViewModel : ViewModelBase
    {

        public readonly TodoList _model;

        ObservableCollection<TodoItemViewModel> selectedlistoftask { get; set; } = new();
        public TodoListItemViewModel(TodoList model)
        {
            _model = model;
        }

        public int Id => _model.Id;

        public string? Name
        {
            get => _model.Name;
            set
            {
                _model.Name = value;
                RaisePropertyChanged();
            }
        }

      
    }
}
