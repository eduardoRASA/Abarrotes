using Abarrotes.BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Abarrotes.DAL;

namespace Abarrotes.Controllers
{
    public class ProductosController : Controller
    {
        public IProductosBo _productosBo;
        public ProductosController(IProductosBo productosBo)
        {
            _productosBo = productosBo;
        }
        // GET: Productos
        public ActionResult Productos()
        {
            List<ProductosDto> productos = new List<ProductosDto>();
            productos = _productosBo.GetProductos();
            return View(productos);
        }
    }
}