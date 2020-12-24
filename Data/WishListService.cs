using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WishList.Data;

public class WishListService
{
    private WishListDBContext dbContext;

    public WishListService(WishListDBContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<List<Wish>> GetWishAsync()
    {
        return await dbContext.Wish.ToListAsync();
    }

    public async Task<Wish> AddWishAsync(Wish wish)
    {
        try
        {
            dbContext.Wish.Add(wish);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
        return wish;
    }

    public async Task<Wish> UpdateProductAsync(Wish wish)
    {
        try
        {
            var productExist = dbContext.Wish.FirstOrDefault(p => p.WishID == wish.WishID);
            if (productExist != null)
            {
                dbContext.Update(wish);
                await dbContext.SaveChangesAsync();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return wish;
    }

    public async Task DeleteProductAsync(Wish wish)
    {
        try
        {
            dbContext.Wish.Remove(wish);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }
}