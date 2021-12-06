using Abarrotes.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abarrotes.BAL
{
    public class ProductosBo : IProductosBo
    {
        IProductosDao _productosDao;
        public ProductosBo(IProductosDao productosDao)
        {
            _productosDao = productosDao;
        }
        public List<ProductosDto> GetProductos()
        {
            List<ProductosDto> productos = new List<ProductosDto>();
            try
            {
                productos = _productosDao.GetProductos();
            }
            catch (Exception ex)
            {
                new Exception(ex.Message);
            }
            return productos;
        }
    }
}
