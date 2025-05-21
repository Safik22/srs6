// AddEmployeeWindow.xaml.cs
using System.Windows;
using System.Xml.Linq;

namespace srs6
{
    public partial class AddEmployeeWindow : Window
    {
        public AddEmployeeWindow()
        {
            InitializeComponent();
        }

        private void btnAddEmployee_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            string position = txtPosition.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(position))
            {
                MessageBox.Show("All fields are required.");
                return;
            }


            MessageBox.Show("Employee added successfully!");
            this.Close();
        }
    }
}
