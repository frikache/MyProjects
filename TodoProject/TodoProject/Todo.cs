using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace TodoProject
{
    public class Todo : INotifyPropertyChanged
    {
        private int Number;
        private string TodoStr;
        private bool Done;

        public event PropertyChangedEventHandler PropertyChanged;

        public Todo()
        {
        }

        public Todo(int num, string el)
        {
            Number = num;
            TodoStr = el;
            Done = false;
        }

        public override string ToString()
        {
            return TodoStr.ToString();
        }

        public int GetNumber
        {
            get { return Number; }
            set
            {
                Number = value;
                OnPropertyChanged("Number");
            }
        }

        public string GetTodoStr
        {
            get { return TodoStr; }
            set
            {
                TodoStr = value;
                OnPropertyChanged("TodoStr");
            }
        }

        public bool GetDone
        {
            get { return Done; }
            set
            {
                Done = value;
                OnPropertyChanged("Done");
            }
        }

        protected void OnPropertyChanged(string info)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(info));
            }
        }
        private void cmdDeleteTodo_Click(object sender, RoutedEventArgs e)
        {

        }

        
        
    }
    public class ListTodos : ObservableCollection<Todo>
    {
        public ListTodos() : base()
    {
      
    }


    }
}
