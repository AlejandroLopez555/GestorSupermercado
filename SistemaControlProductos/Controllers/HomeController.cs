using System;
using System.Linq;
using System.Web.Mvc;
using SistemaControlProductos.Models;

namespace SistemaControlProductos.Controllers
{
    public class HomeController : Controller
    {
        private SupermercadoContext db = new SupermercadoContext();

        public ActionResult Index()
        {
            //datos de los graficos
            ViewBag.TotalProductos = db.Productos.Count();
            ViewBag.TotalCategorias = db.Categorias.Count();
            ViewBag.TotalProveedores = db.Proveedores.Count();
            ViewBag.StockBajo = db.Productos.Where(p => p.Stock < 10).Count();

            //datos para los graficos de productos por categoria
            var productosPorCategoria = db.Productos
                .GroupBy(p => p.Categoria.Nombre)
                .Select(g => new { Categoria = g.Key, Cantidad = g.Count() })
                .ToList();
            ViewBag.ProductosPorCategoria = productosPorCategoria;

            // Datos para los graficos de productos stock
            var topProductos = db.Productos
                .OrderByDescending(p => p.Stock)
                .Take(10)
                .Select(p => new { Producto = p.Nombre, Stock = p.Stock })
                .ToList();
            ViewBag.TopProductos = topProductos;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}