﻿using System.Data.Entity;

namespace EntityFrameworkCodeFirst
{
    public class FriendContext : DbContext
    {
        public DbSet<Friend> Friends { get; set; }

        public FriendContext() : base("Data Source=localhost;Initial Catalog=EntityFrameworkTest;")
        {
        }   
    }
}