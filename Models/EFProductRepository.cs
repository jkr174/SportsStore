using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class EFProductRepository : IProductRepository
    {
        private PageIngo context;
        public EFProductRepository(PageIngo ctx)
        {
            context = ctx;
        }
        public IQueryable<Product> Products => context.Products;
    }

}