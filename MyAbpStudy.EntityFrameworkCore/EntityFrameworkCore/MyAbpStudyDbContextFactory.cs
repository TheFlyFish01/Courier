using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MyAbpStudy.Configuration;
using MyAbpStudy.Web;

namespace MyAbpStudy.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MyAbpStudyDbContextFactory : IDesignTimeDbContextFactory<MyAbpStudyDbContext>
    {
        public MyAbpStudyDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MyAbpStudyDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MyAbpStudyDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MyAbpStudyConsts.ConnectionStringName));

            return new MyAbpStudyDbContext(builder.Options);
        }
    }
}
