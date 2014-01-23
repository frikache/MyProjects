using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using System.Windows.Controls;

namespace TodoProject
{
    class ModelView
    {
        public int CountTodo;
        public List<StackPanel> ListStackPanels = new List<StackPanel>();
        public List<Todo> ListTodos = new List<Todo>();

        

        public void CreateTodo()
        {
            StackPanel newStackPanel = new StackPanel();
            ListTodos.Add(new Todo(CountTodo, TextBox1.Text));

            Label newLabel = new Label();
            newLabel.Name = "label" + CountTodo;
            newLabel.Width = 800;
            newLabel.Content = ListTodos[CountTodo].GetTodoStr;
            newStackPanel.Children.Add(newLabel);
          
            CheckBox newCheckBox = new CheckBox();
            newCheckBox.Name = "checkbox" + CountTodo;
            newCheckBox.Content = "Выполнено?";
            newCheckBox.IsChecked = false;
            newCheckBox.IsThreeState = false;
            newCheckBox.Checked += new RoutedEventHandler(ch1_check);
            newStackPanel.Children.Add(newCheckBox);
            
            CountTodo++;
        }

        public void ch1_check(object sender, RoutedEventArgs e)
        {
            RemoveTodo();
        }

        public void RemoveTodo()
        {
            int intCycle = 0;
            while (intCycle < CountTodo)
            {
              /*  if (ListCheckBoxs[intCycle].IsChecked.GetValueOrDefault())
                {
                    ListTodos[intCycle].GetDone = true;
                    wrap1.Children.RemoveAt(2 * intCycle);
                    wrap1.Children.RemoveAt(2 * intCycle);
                    ListTodos.Remove(ListTodos[intCycle]);
                    ListCheckBoxs.Remove(ListCheckBoxs[intCycle]);
                    CountTodo--;
                }
               */ intCycle++;
            }
        }




    }
}
