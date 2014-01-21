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

namespace Todo_v._2
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        public int CountTodo;
        public List<Todo> ListTodos = new List<Todo>();
        public List<CheckBox> ListCheckBoxs = new List<CheckBox>();

        private void TextBox_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                CreateTodo();
            }
        }

        public void CreateTodo()
        {
            ListTodos.Add(new Todo(CountTodo, TextBox1.Text));

            Label newLabel = new Label();
            newLabel.Name = "label" + CountTodo;
            newLabel.Width = 800;
            newLabel.Content = ListTodos[CountTodo].TodoStr;
            wrap1.Children.Add(newLabel);

            CheckBox newCheckBox = new CheckBox();
            newCheckBox.Name = "checkbox" + CountTodo;
            newCheckBox.Content = "Выполнено?";
            newCheckBox.IsChecked = false;
            newCheckBox.IsThreeState = false;
            newCheckBox.Checked += new RoutedEventHandler(ch1_check);
            wrap1.Children.Add(newCheckBox);

            ListCheckBoxs.Add(newCheckBox);
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
                if (ListCheckBoxs[intCycle].IsChecked.GetValueOrDefault())
                {
                    ListTodos[intCycle].Done = true;
                    wrap1.Children.RemoveAt(2 * intCycle + 2);
                    //2*q+2 WrapPanel начиная со 2-го, содержит 2 элемента для каждого члена списка
                    wrap1.Children.RemoveAt(2 * intCycle + 2);
                    ListTodos.Remove(ListTodos[intCycle]);
                    ListCheckBoxs.Remove(ListCheckBoxs[intCycle]);
                    CountTodo--;
                }
                intCycle++;
            }
        }




    }

}
