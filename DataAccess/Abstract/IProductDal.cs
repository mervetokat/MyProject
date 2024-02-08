
using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //dal= data access layer/object
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetailDto> ProductDetails();
        
    }
}
