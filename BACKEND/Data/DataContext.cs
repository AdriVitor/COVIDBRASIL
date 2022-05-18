using COVID.Models;
using Microsoft.EntityFrameworkCore;

namespace COVID.DataContext;

public class AppDbContext : DbContext {
    public DbSet<DataCountryModel> DataCountryModels { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options)
     : base(options)
    {}

    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     optionsBuilder.UseSqlite("Filename=MyDatabaseCovid.db");
    //     // builder.Entity<DataCountryModel>().HasData(
    //     //     new DataCountryModel{}
    //     // )
    // }

    protected override void OnModelCreating(ModelBuilder builder)
    {    
        builder.Entity<DataCountryModel>().ToTable("DataCountryModels");
    }


}