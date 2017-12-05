using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Shop_Manager
{
    static class Program
    {
        private static Form formatka;
        private static SqlConnection cnn;
        private static string connetionString = null;

        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {        
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Run();
        }

        internal static void CloseProgram()
        {
            Application.Exit();
        }

        internal static void CloseConnection()
        {
            cnn.Close();
            cnn = null;
        }

        internal static string getPassword()
        {
            Panel Pnl = formatka.Controls.Find("PanelLogowania", true).FirstOrDefault() as Panel;
            TextBox txt1 = Pnl.Controls.Find("tbx_password", true).FirstOrDefault() as TextBox;
            return txt1.Text;
        }

        internal static string getLogin()
        {
            Panel Pnl = formatka.Controls.Find("PanelLogowania", true).FirstOrDefault() as Panel;
            TextBox txt1 = Pnl.Controls.Find("tbx_login", true).FirstOrDefault() as TextBox;
            return txt1.Text;
        }

        internal static bool Login(string login, string password)
        {
            connetionString = "Data Source=(LocalDb)\\LocalDBTest;Initial Catalog=MyDatabase;User ID="+login+";Password="+password;
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open ! ");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
            return false;
        }
        
        internal static void CloseForm()
        {
            formatka.Hide();
        }

        internal static void ChangeForm(Form f)
        {
            formatka = f;
            formatka.Show();
        }

        internal static void ReturnForm()
        {
            formatka = new Form1();
            formatka.Show();
        }

        public static void Run()
        {
            formatka = new Form1();
            Application.Run(formatka);
        }
    }
}
