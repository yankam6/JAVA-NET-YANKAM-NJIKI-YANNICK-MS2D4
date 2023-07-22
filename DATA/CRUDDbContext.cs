using CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Data;

public class CRUDDbContext : DbContext
{

    public CRUDDbContext(DbContextOptions<CRUDDbContext> options): base(options)
    {
    }

    public Dbset<Produit> Produits => Set<Produit>();
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Produit>().HasKey(x => x.Identifiant);
        base.OnModelCreating(modelBuilder);
    }
    
}