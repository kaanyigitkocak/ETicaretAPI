using ETicaretAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Abstractions
{
    public interface IProductService
    {

 
    public List<Product> GetProducts { get; set; }
    }
}
