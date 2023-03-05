using ETicaretAPI.Application.Abstractions;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence.Concretes
{
  public class ProductService : IProductService
  {
    List<Product> IProductService.GetProducts { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    






  }
}

   


