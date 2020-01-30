using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkersServices
{
    public class CommentsDbContext : DbContext
    {
        #region Public Properties
        public DbSet<CommentModel> Comments { get; set; }
        #endregion

        public CommentsDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder ob)
        {
            base.OnConfiguring(ob);
            ob.UseSqlServer("Server=commentsserver.database.windows.net;Database=commentsDB;User ID=azure;Password=Parker123;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            //ob.UseSqlServer("Server=.;Database=Comments;Trusted_Connection=True;MultipleActiveResultSets=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
