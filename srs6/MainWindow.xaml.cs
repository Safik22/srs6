
using System.Collections.Generic;
using System.Windows;

namespace srs6
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            // Пример данных
            var employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Иван Иванов", Position = "Преподаватель" },
                new Employee { Id = 2, Name = "Анна Смирнова", Position = "Администратор" }
            };

            dataGridEmployees.ItemsSource = employees;
        }

        private void btnAddEmployee_Click(object sender, RoutedEventArgs e)
        {
            AddEmployeeWindow addEmployeeWindow = new AddEmployeeWindow();
            addEmployeeWindow.ShowDialog();
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
    }
}
