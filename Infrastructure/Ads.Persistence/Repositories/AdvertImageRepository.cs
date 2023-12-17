﻿using Ads.Application.Repositories;
using Ads.Domain.Entities.Concrete;
using Ads.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Ads.Persistence.Repositories
{
    public class AdvertImageRepository : Repository<AdvertImage>, IAdvertImageRepository
    {
        public AdvertImageRepository(AppDbContext context) : base(context)
        {
        }
        public async Task<AdvertImage> GetCustomAdvertImage(int id)
        {
            return await _dbSet
              .Include(x => x.Advert)
              .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<List<AdvertImage>> GetCustomAdvertImageList()
        {
            return await _dbSet
                .Include(x => x.Advert)
                .ToListAsync();
        }

        public async Task<List<AdvertImage>> GetCustomAdvertImageList(Expression<Func<AdvertImage, bool>> expression)
        {
            return await _dbSet
               .Where(expression)
               .Include(x => x.Advert)
               .ToListAsync();
        }
    }
}