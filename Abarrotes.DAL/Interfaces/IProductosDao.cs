using System.Collections.Generic;

namespace Abarrotes.DAL
{
    public interface IProductosDao
    {
        List<ProductosDto> GetProductos();
    }
}
