using Core;
using Infrastructure.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ProductService : Interfaces.IProductService
    {
        private readonly OnlineShopDbcontext dbContext;

        public ProductService(Core.OnlineShopDbcontext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<ProductDto> Add(ProductDto model)
        {
            var product = new Core.Entities.Product
            {
                ProductName = model.ProductName,
                price = model.Price,
            };

            await dbContext.products.AddAsync(product);
            await dbContext.SaveChangesAsync();

            model.Id = product.ID;
            return model;   
        }

        public async Task<List<ProductDto>>  getAll()
        {
            var result = await dbContext.products.Select(product => new ProductDto
            {
                Id = product.ID,
                Price = product.price,
                ProductName = product.ProductName,
                PriceWithGama = product.price.ToString("###,###"),
            }).ToListAsync();
            return result;
        }

        public async Task<ProductDto> getById(int id)
        {
            var product = await dbContext.products.FindAsync(id);
            var model = new ProductDto
            {
                Id = product.ID,
                Price = product.price,
                ProductName = product.ProductName,
                PriceWithGama = product.price.ToString("###,###"),
            };
            return model;
        }
    }
}
