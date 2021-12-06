using Abarrotes.DAL;
using Abarrotes.BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Abarrotes.Controllers
{
    public class UsuariosController : Controller
    {
        public IUsuariosBo _usuariosBo;
        public UsuariosController(IUsuariosBo usuariosBo)
        {
            _usuariosBo = usuariosBo;
        }
        // GET: Usuarios
        public ActionResult Usuarios()
        {
            List<UsuariosDto> usuarios = new List<UsuariosDto>();
            usuarios = _usuariosBo.GetUsuarios();
            return View(usuarios);
        }

        [HttpGet]
        public ActionResult CreateUsuario()
        {
            UsuariosDto usuario = new UsuariosDto();
            return View(usuario);
        }

        [HttpPost]
        public ActionResult AddUsuario(UsuariosDto usuario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _usuariosBo.AddUsuario(usuario);
                    ViewBag.alerta = "El usuario fue guardado con éxito";
                    return RedirectToAction("Usuarios");
                }
            }
            catch(Exception ex)
            {
                ViewBag.alerta = "Ocurrió un error al guardar al usuario:" + ex.Message;
            }
            return View(usuario);
        }

        [HttpGet]
        public ActionResult EditUsuario(int id)
        {
            UsuariosDto usuario = _usuariosBo.GetUsuario(id);
            return View(usuario);
        }

        [HttpPost]
        public ActionResult UpdateUsuario(UsuariosDto usuario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _usuariosBo.UpdateUsuario(usuario);
                    ViewBag.alerta = "El usuario ha sido actualizado con éxito";
                    return RedirectToAction("Usuarios");
                }
            }
            catch(Exception ex)
            {
                ViewBag.alerta = "Ocurrió un error al actualizar el usuario: " + ex.Message; 
            }
            return View(usuario);
        }

        [HttpGet]
        public ActionResult DeleteUsuario(int id)
        {
            try
            {
                _usuariosBo.DeleteUsuario(id);
                ViewBag.alerta = "El usuario ha sido eliminado con éxito";
            }
            catch(Exception ex)
            {
                ViewBag.alerta = "Ocurrió un error al usuario: " + ex.Message;
            }
            return RedirectToAction("Usuarios");
        }
    }
}