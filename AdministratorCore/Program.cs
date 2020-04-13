using AdministratorCore.DataBaseHelper;
using System;
using System.Text.RegularExpressions;

namespace AdministratorCore
{
    class Program
    {
        private static string _version = "1.0.0";
        private static string _last_command;

        private static DB2ConnectionHelper _connection_db;

        static void Main(string[] args)
        {
            Console.Write("cmd: ");
#if (DEBUG)
            _last_command = "connect to vld user prvmarcelosr";
            //_last_command = "version";
#else
            _last_command = Console.ReadLine();
#endif

            int indexOf = _last_command.IndexOf(' ');
            string command = _last_command;

            if (indexOf > 0)
                command = _last_command.Substring(0, indexOf);

            switch (command)
            {
                case "connect":
                    connect();
                    break;

                case "version":
                    version();
                    break;

                case "help":
                    help();
                    break;

                default:
                    Console.WriteLine("unknown command.");
                    Main(null);
                    break;
            }
        }

        private static void connect()
        {
            string pattern_alias_db = @"\bto \w*\b";
            Match m = Regex.Match(_last_command, pattern_alias_db, RegexOptions.IgnoreCase);

            if (!m.Success)
            {
                Console.WriteLine("alias command error.");
                help();
                return;
            }

            string alias_db = m.Value.Substring(3);

            string pattern_user_db = @"\b user \w*";
            m = Regex.Match(_last_command, pattern_user_db, RegexOptions.IgnoreCase);

            if (!m.Success)
            {
                Console.WriteLine("user command error.");
                help();
                return;
            }

            string user = m.Value.Substring(5);

            ShowMessage("Password:");
            string password = GetPasswordConsole();

            try
            {
                _connection_db = new DB2ConnectionHelper(alias_db, user, password);
                string db_connection_status = _connection_db.IsOpen() ? "Open" : "Closed";
                ShowMessage($"Connection is {db_connection_status} in the database {alias_db}");
            }
            catch (Exception e)
            {
                ShowMessage(e.Message);
            }

            Main(null);
        }

        private static void version()
        {
            ShowMessage("version: {0}", _version);
            Main(null);
        }

        private static void help()
        {
            ShowMessage("version");
            ShowMessage("connect to <db> user <user>");
            Main(null);
        }

        private static string GetPasswordConsole()
        {
            string password = "";

            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Enter)
                    break;

                if (key.Key != ConsoleKey.Backspace)
                {
                    password += key.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    if (password.Length <= 0)
                        continue;

                    Console.Write("\b \b");
                    char[] pas = password.ToCharArray();
                    string temp = "";
                    for (int i = 0; i < password.Length - 1; i++)
                    {
                        temp += pas[i];
                    }
                    password = temp;

                }
            }
            while (key.Key != ConsoleKey.Enter);

            ShowMessage("");

            return password;
        }

        private static void ShowMessage(string message, params string[] parameter)
        {
            Console.WriteLine(message, string.Join(' ', parameter));
        }
    }
}
