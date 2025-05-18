using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model;
using WpfApp1.ViewModel;
using WpfApp1Todo.Model;

namespace WpfApp1.ViewModel
{

    public class TodoItemViewModel : ViewModelBase
    {



        private readonly Todo _model;
        private readonly Todo2 _model2;
    

        public TodoItemViewModel(Todo model)
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

  
        public int ListId
        {
            get => _model.ListId;
            set
            {
                _model.ListId = value;
                RaisePropertyChanged();
            }
        }

        private DateTime _duedate= DateTime.Now;
        public DateTime? DueDate
        {
            get => _duedate;
            set
            {
                _model.DueData = value;
                RaisePropertyChanged();
            }
        }

        public bool Checked
        {
            get => _model.Checked;
            set
            {
                _model.Checked = value;
                RaisePropertyChanged();
            }
        }
        public bool Starred
        {
            get => _model.Starred;
            set
            {
                _model.Starred = value;
                RaisePropertyChanged();
            }
        }
    }
}
