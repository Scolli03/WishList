using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WishList.Data;

public class WishListDBContext : DbContext
{
    public WishListDBContext(DbContextOptions<WishListDBContext> options)
            :base(options)
    {
        
    }

    public DbSet<Wish> Wish { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Wish>().HasData(GetProducts());
        base.OnModelCreating(modelBuilder);
    }

    private List<Wish> GetProducts()
    {
        return new List<Wish>
        {
            new Wish { WishID=1, UserID="5aa802fc-acbf-478f-9935-b7c1259dc6cf" ,Title="The Grinch",Year="2018",imdbID="tt2709692",Type="movie"},
            new Wish { WishID=2, UserID="732bc22c-8c1a-4cc2-a59e-0a1b20a335d3" ,Title="Mr. Robot",Year="2015-2019",imdbID="tt4158110",Type="series", Season="4"},
        };
    }
}