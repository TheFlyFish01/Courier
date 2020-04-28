using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MyAbpStudy.Authorization.Roles;
using MyAbpStudy.Authorization.Users;
using MyAbpStudy.MultiTenancy;
using MyAbpStudy.CourierCompanys;

namespace MyAbpStudy.EntityFrameworkCore
{
    public class MyAbpStudyDbContext : AbpZeroDbContext<Tenant, Role, User, MyAbpStudyDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<CourierCompanyEntity> CourierCompanys { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.SetSimpleUnderscoreTableNameConvention();

        }
        public MyAbpStudyDbContext(DbContextOptions<MyAbpStudyDbContext> options)
            : base(options)
        {
        }
    }
}
