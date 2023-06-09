﻿using Microsoft.EntityFrameworkCore;

namespace SolidSample.Model;

public class AppDbContext : DbContext
{
    public DbSet<AudioBook> AudioBooks { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("SolidSample");
    }
}