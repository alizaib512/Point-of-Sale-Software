using System;

namespace project_1._2
{
    internal class DBConnection
    {
        public string MyConnection()
        {
            string sqlcon = @"Data Source=DESKTOP-4DB2DSO;Initial Catalog=Connection;Integrated Security=True";
            return sqlcon;
        }
    }
}