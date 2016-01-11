using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;

namespace LinqToSQL
{
    class Program
    {
        static void Main()
        {
            LINQtoSQLDataContext database = new LINQtoSQLDataContext();
            Table<Friend> friendTable = database.Friends;
            
            List<Friend> friends = friendTable.ToList();
            foreach (Friend friend in friends)
            {
                var rowText = string.Format("{0} {1}", friend.Id, friend.FirstName);
                Console.WriteLine(rowText);
            }
        }
    }
}
