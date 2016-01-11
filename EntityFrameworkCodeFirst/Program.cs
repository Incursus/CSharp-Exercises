using System;
using System.Linq;

namespace EntityFrameworkCodeFirst
{
    class Program
    {
        static void Main()
        {
            using (var friendContext = new FriendContext())
            {
                var friends = friendContext.Friends.ToList();

                foreach (var friend in friends)
                {
                    var rowText = string.Format("{0} {1}", friend.Id, friend.Name);
                    Console.WriteLine(rowText);
                }
            }
            Console.ReadLine();
        }
    }
}

