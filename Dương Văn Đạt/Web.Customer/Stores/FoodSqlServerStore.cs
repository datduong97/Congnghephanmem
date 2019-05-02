using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Customer.Data;

namespace Web.Customer.Stores
{
    public class FoodSqlServerStore : IFoodStore
    {
        private WebDbContext _dbContext;
        public FoodSqlServerStore(WebDbContext dbContext)
        {
            _dbContext = dbContext;

        }
        public async Task<Table> AddAsync(Table table)
        {
            var entry = _dbContext.Add(table);
            await _dbContext.SaveChangesAsync();
            var entity = entry.Entity;
            return entity;
        }

        public Task<Food> AddAsync(Food food)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Food> Query()
        {
            return _dbContext.Set<Food>();
        }


    }
}
