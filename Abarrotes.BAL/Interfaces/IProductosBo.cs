using Abarrotes.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abarrotes.BAL
{
    public interface IProductosBo
    {
        List<ProductosDto> GetProductos();
    }
}
