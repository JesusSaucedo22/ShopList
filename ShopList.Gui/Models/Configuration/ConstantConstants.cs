//using Android.Database.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  ShopList.Gui.Models.Configuration
{
    public static class Constans
    {
        public static string DatabasePath =>
            Path.Combine(FileSystem.AppDataDirectory,
                FileSystem.AppDataDirectory,
                DatabaseFileName
            );

        public const string DatabaseFileName = "ShopList.db3";

        public const SQLite.SQLiteOpenFlags Flags =
            SQLite.SQLiteOpenFlags.ReadWrite |
            SQLite.SQLiteOpenFlags.Create |
            SQLite.SQLiteOpenFlags.SharedCache;
    }
    
}
