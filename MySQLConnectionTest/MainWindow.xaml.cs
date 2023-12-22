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
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MySQLConnectionTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string username;
        string password;
        string database;
        string server;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void mysql_connection()
        {
            string connStr = $"server={server};user={username};database={database};password={password}";
            MySqlConnection conn = new MySqlConnection(connStr);
            MessageBox.Show("Connecting to MySQL...");
            conn.Open();
            MessageBox.Show("Connected to " + server + "/" + database + " as user (" + username + ")");
        }

        private void login_button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (server_box.Text != "" && password_box.Password != "" && database_box.Text != "" && username_box.Text != "")
                {
                    server = server_box.Text;
                    database = database_box.Text;
                    username = username_box.Text;
                    password = password_box.Password;
                    mysql_connection();
                    login_button.Content = "Close Connection";

                    // clear out code for security reasons
                    server = "";
                    database = "";
                    username = "";
                    password = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
