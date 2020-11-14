using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace Test22
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlDataAdapter adapter;
        DataTable nakladTable;
        public string str1 = "ewfweffewff";
       
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
           // MenuItem menuItem = (MenuItem)sender;
           // MessageBox.Show(menuItem.Header.ToString());
            Connection connectString = new Connection();
            string sql = $"SELECT * FROM waybills";
            SqlConnection connection = new SqlConnection(connectString.connSring);
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            //int number = command.ExecuteNonQuery();
            adapter = new SqlDataAdapter(command);
            nakladTable = new DataTable();
            adapter.Fill(nakladTable);
            GridNaklad.ItemsSource = nakladTable.DefaultView;

            connection.Close();

            SqlDataAdapter adapter1;
            DataTable table1;

            Connection conn1 = new Connection();
            SqlConnection connection1 = new SqlConnection(conn1.connSring);
            connection1.Open();
            string sql1 = "";
            SqlCommand command1 = new SqlCommand(sql1, connection1);
            adapter1 = new SqlDataAdapter(command1);
            table1 = new DataTable();
            adapter1.Fill(table1);
            GridNaklad.ItemsSource = table1.DefaultView;

//            SqlCommand command = new SqlCommand(sql, connection);
//            SqlDataReader reader = command.ExecuteReader();

//            if (reader.HasRows) // если есть данные
//            {


//                while (reader.Read()) // построчно считываем данные
//                {
//                    name_article = Convert.ToString(reader.GetValue(1));
//                    text_article = Convert.ToString(reader.GetValue(2));


//                    break;
//                }
//            }
//            reader.Close();



//        }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//            }
//            finally
//            {

//                if (connection != null)
//                    connection.Close();
//            }


//gridContentArticle.DataContext = this;

            //DataRowView row_selected = documentsGrid.SelectedItem as DataRowView;

//if (row_selected != null)
//{
//    Console.WriteLine(row_selected["name_doc"]);
//}
//char[] MyChar = { '"' };

//string id = Convert.ToString(row_selected["id_doc"]).TrimStart(MyChar).TrimEnd(MyChar);

//WindowSections sectionsWindow = new WindowSections(id);
//sectionsWindow.Show();





}

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Connection connectString = new Connection();
            string sql = $"SELECT * FROM products";
            SqlConnection connection = new SqlConnection(connectString.connSring);
            
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            //int number = command.ExecuteNonQuery();
            adapter = new SqlDataAdapter(command);
            nakladTable = new DataTable();
            adapter.Fill(nakladTable);
            GridNaklad.ItemsSource = nakladTable.DefaultView;

            connection.Close();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Connection connectString = new Connection();
            string sql = $"SELECT * FROM waybills_products";
            SqlConnection connection = null;
            connection = new SqlConnection(connectString.connSring);
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            //int number = command.ExecuteNonQuery();
            adapter = new SqlDataAdapter(command);
            nakladTable = new DataTable();
            adapter.Fill(nakladTable);
            GridNaklad.ItemsSource = nakladTable.DefaultView;

            connection.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //DataRowView row_selected = documentsGrid.SelectedItem as DataRowView;
            var tbx = textBox1 as TextBox;
            var tb = blocktext1 as TextBlock;
            
            tbx.Text = "seeqwddwed";
            tb.Text = "dqwdq";
            Connection connectString = new Connection();
            string sql = "SELECT * FROM products";
            nakladTable = new DataTable();
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(connectString.connSring);
                SqlCommand command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);

                // установка команды на добавление для вызова хранимой процедуры
               

                connection.Open();
                adapter.Fill(nakladTable);
                GridNaklad.ItemsSource = nakladTable.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {

        }
    }
    
}
