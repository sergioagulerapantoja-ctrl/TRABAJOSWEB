using System;
using System.Collections.Generic;
using HeroesWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace HeroesWeb.Data;

public partial class HeroesContext : DbContext
{
    public HeroesContext(DbContextOptions<HeroesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Heroes> Heroes { get; set; }

    public virtual DbSet<SuperPoderes> SuperPoderes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Heroes>(entity =>
        {
            entity.HasOne(d => d.SuperPoder).WithMany(p => p.Heroes).HasConstraintName("FK_Heroes_SuperPoderes");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
