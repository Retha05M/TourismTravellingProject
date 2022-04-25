using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using TourismProject.Authorization.Roles;
using TourismProject.Authorization.Users;
using TourismProject.MultiTenancy;
using TourismProject.Domain;

namespace TourismProject.EntityFrameworkCore
{
    public class TourismProjectDbContext : AbpZeroDbContext<Tenant, Role, User, TourismProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Province> Provinces{get;set;}
        public DbSet<City> Cities {get;set;}
        public DbSet<Attraction> Attractions { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<CategoryType> CategoryTypes{ get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Tourist> Tourists { get; set; }
        public DbSet<Employee> Employees { get; set; }

        





        public TourismProjectDbContext(DbContextOptions<TourismProjectDbContext> options)
            : base(options)
        {
        }
    }
}
