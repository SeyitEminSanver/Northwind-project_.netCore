using Core.DataAcces;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //dal(data acces layer) oldugunu gösterir. 
    public interface IProductDal:IEntityRepository<Product>
    {
         
    }
}
