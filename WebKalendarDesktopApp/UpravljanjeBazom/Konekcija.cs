using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebKalendarDesktopApp.UpravljanjeBazom
{
    class Konekcija
    {
        private readonly SqlConnection connection;

        public SqlConnection GetConnection()
        {
            return connection;
        }

        public Konekcija()
        {
            var conn = new SqlConnection();
            conn.ConnectionString =
                          //"Driver={SQL Server};" +
                          "Server=Tassadar;" +
                          "DataBase=WebKalendar;" +
                          "Trusted_Connection=Yes;";
            try
            {
                conn.Open();
                this.connection = conn;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                Console.Error.WriteLine("Nije uspjelo spajanje na bazu");
                throw new Exception("Spajanje na bazu nije uspjelo");
            }
        }
    }
}
