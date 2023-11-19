using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkL5
{
    internal static class DatabaseService
    {
        public static void RestoreDatabase(string backupFilePath)
        {
            string databaseName = "EfLesson3";
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=master;Trusted_Connection=True;";
            using (SqlConnection db = new SqlConnection(connectionString))
            {
                db.Open();
                using (SqlCommand command = new SqlCommand($"ALTER DATABASE [{databaseName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;", db))
                {
                    command.ExecuteNonQuery();
                }

                // Выполняем операцию восстановления
                using (SqlCommand command = new SqlCommand($"RESTORE DATABASE [{databaseName}] FROM DISK = '{backupFilePath}' WITH REPLACE;", db))
                {
                    command.ExecuteNonQuery();
                }

                // Переводим базу данных в многопользовательский режим
                using (SqlCommand command = new SqlCommand($"ALTER DATABASE [{databaseName}] SET MULTI_USER;", db))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
