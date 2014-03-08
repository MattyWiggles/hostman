using System;
using System.Data.SQLite;
using System.Linq;

namespace HostLists
{
  internal class SqliteUtils
  {
    public static void CheckAndCreateDatabaseAndTables(string databaseFileName)
    {
      if(!DoesDatabaseFileExist(databaseFileName))
      {
        CreateDatabaseFile(databaseFileName);
      }

      SQLiteConnectionStringBuilder connStringBuilder = new SQLiteConnectionStringBuilder();
      connStringBuilder.DataSource = databaseFileName;
      using(SQLiteConnection thisDatabase = new SQLiteConnection(connStringBuilder.ConnectionString))
      {
        if( !DoesTableExist("profiles", thisDatabase) || !DoesTableExist("hostentrys", thisDatabase) )
        {
          CreateTables(thisDatabase);
        }
      }
    }

    private static bool DoesTableExist(string tablename, SQLiteConnection theDatabase)
    {
      bool result = false;

      if (theDatabase == null)
      {
        return false;
      }

      string sql = string.Format("SELECT name FROM sqlite_master WHERE name='{0}'", tablename);

      using (SQLiteCommand command = new SQLiteCommand(sql, theDatabase))
      {
        using (SQLiteDataReader dr = command.ExecuteReader())
        {
          if (dr.HasRows)
          {
            result = true;
          }
        }
      }

      return result;
    }

    private static bool DoesDatabaseFileExist(string databaseFileName)
    {
      // mocked up for now
      return true;
    }

    private static void CreateDatabaseFile(string databaseFileName)
    {
      // Create the physical file
    }

    private static void CreateTables(SQLiteConnection theDatabase)
    {
      CreateProfilesTable(theDatabase);
      CreateHostEntrysTable(theDatabase);
      CreateIndexes(theDatabase);
    }

    private static void CreateProfilesTable(SQLiteConnection theDatabase)
    {
      // Physically create the profiles table
    }

    private static void CreateHostEntrysTable(SQLiteConnection theDatabase)
    {
      // Physically create the host entrys table
    }

    private static void CreateIndexes(SQLiteConnection theDatabase)
    {
      // Index profiles table
      // Index host entrys table
    }

  }
}
