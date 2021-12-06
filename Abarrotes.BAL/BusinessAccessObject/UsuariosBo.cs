using Abarrotes.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abarrotes.BAL
{
    public class UsuariosBo : IUsuariosBo
    {
        IUsuariosDao _usuariosDao;
        public UsuariosBo(IUsuariosDao usuariosDao)
        {
            _usuariosDao = usuariosDao;
        }
        public List<UsuariosDto> GetUsuarios()
        {
            List<UsuariosDto> usuarios = new List<UsuariosDto>();
            try
            {
                usuarios = _usuariosDao.GetUsuarios();
            }
            catch(Exception ex)
            {
                new Exception(ex.Message);
            }
            return usuarios;
        }
        public UsuariosDto GetUsuario(int id) 
        {
            UsuariosDto usuario = new UsuariosDto();
            try
            {
                usuario = _usuariosDao.GetUsuario(id);
            }
            catch(Exception ex)
            {
                new Exception(ex.Message);
            }
            return usuario;
        }
        public void AddUsuario(UsuariosDto usuario)
        {
            try
            {
                _usuariosDao.AddUsuario(usuario);
            }
            catch(Exception ex)
            {
                new Exception(ex.Message);
            }
        }
        public void UpdateUsuario(UsuariosDto usuario)
        {
            try
            {
                _usuariosDao.UpdateUsuario(usuario);
            }
            catch (Exception ex)
            {
                new Exception(ex.Message);
            }
        }
        public void DeleteUsuario(int id)
        {
            try
            {
                _usuariosDao.DeleteUsuario(id);
            }
            catch (Exception ex)
            {
                new Exception(ex.Message);
            }
        }
    }
}
