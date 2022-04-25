using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace TourismProject.EntityFrameworkCore
{
    public static class TourismProjectDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<TourismProjectDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<TourismProjectDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
