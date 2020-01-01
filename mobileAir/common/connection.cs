using System.Data.SQLite;
using System.Configuration;

namespace mobileAir.common
{
    public class connection
    {
        const string connectionString = "Data Source=appData.db;Version=3;new=False;datetimeformat=CurrentCulture;Password=admin@123;";
        public SQLiteConnection mcon = new SQLiteConnection(ConfigurationManager.ConnectionStrings["cnn"].ConnectionString);
        public SQLiteCommand mcmd = new SQLiteCommand();
        public SQLiteDataAdapter madpt = null;
        public SQLiteDataReader mrede = null;
    }
}
