using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test22
{
    class Connection
    {
        string dataSource;
        string database;
        string username;
        string password;
        public string connSring;


        public Connection()
        {
            dataSource = @"DESKTOP-BU6FNLI\SQLEXPRESS";
            database = @"naklad";
            username = @"ws08";
            password = @"123";
            connSring = @"Data Source=" + dataSource + ";Initial Catalog="
                        + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;

        }
    }
}
