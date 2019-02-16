using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebKalendarDesktopApp.UpravljanjeBazom
{
    class RadBazom
    {
        public static SqlConnection connection = new Konekcija().GetConnection();

        public RadBazom(){

        }

        /// <summary>
        /// Ova metoda služi za izvođenje SQL naredbi koje vračaju rezultat.
        /// Dakle SELECT
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public static SqlDataReader postaviUpit(String query)   //Možda dodati try-catch blokove
        {
            SqlCommand command;
            command = new SqlCommand(query, connection);
            return command.ExecuteReader();
        }

        /// <summary>
        /// Ova metoda služi za izvođenje SQL naredbi koje ne vračaju rezultat.
        /// To su dakle INSERT, UPDATE, DELETE
        /// </summary>
        /// <param name="query"></param>
        public static void izvediNaredbu(String query)  //Možda dodati try-catch blokove
        {
            SqlCommand command;
            command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
        }
    }
}
