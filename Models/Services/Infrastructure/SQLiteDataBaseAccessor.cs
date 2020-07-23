using System.Data;
using Microsoft.Data.Sqlite;

namespace aspnet.Models.Services.Infrastructure
{
    public class SQLiteDataBaseAccessor : IDataBaseAccessor
    {
        public DataSet Query(string SQL)
        {
            using (var conn = new SqliteConnection("Data Source=Data/MyCourse.db"))
            {

                conn.Open();
                using (var cmd = new SqliteCommand(SQL, conn))
                {

                    using (var reader = cmd.ExecuteReader())
                    {
                        DataSet dataSet = new DataSet();
                        DataTable dataTable = new DataTable();
                        dataSet.Tables.Add(dataTable);
                        dataTable.Load(reader);
                        return dataSet;
                    }


                }

            }

           
        }
    }
}