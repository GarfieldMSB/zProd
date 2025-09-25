using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    public required DbSet<Activity> Activities { get; set; }

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    => modelBuilder.Entity<DASHusoCPUTotal>()
    //                   .ToTable("DASH_usoCPU_Total");   // nombre exacto de tu tabla    
}
