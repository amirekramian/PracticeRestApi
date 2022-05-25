using Core.Entities;
using Infrastructure.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Application.Interfaces
{
    public interface IProductService
    {
       Task<List<ProductDto>> getAll();

       Task<ProductDto> getById(int id);

       Task<ProductDto> Add(ProductDto model);  


    }
}
