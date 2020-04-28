using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MyAbpStudy.EntityFrameworkCore
{
    public static class MyAbpStudyDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MyAbpStudyDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MyAbpStudyDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
