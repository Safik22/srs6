// LoginWindow.xaml.cs
using srs6;
using System.Windows;

namespace srs6
{
    public partial class loginWindow : Window
    {
        public loginWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Password;

            // Простая проверка учетных данных
            if (username == "admin" && password == "admin")
            {
                MessageBox.Show("Login successful!");
                // Открыть главное окно
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}
