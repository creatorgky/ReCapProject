using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CarBrand:IEntity
    {
        public int BrandId { get; set; }
        public string Brand { get; set; }
    }
}
