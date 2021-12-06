using Abarrotes.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abarrotes.DAL
{
    public interface IUsuariosDao
    {
        List<UsuariosDto> GetUsuarios();
        UsuariosDto GetUsuario(int id);
        void AddUsuario(UsuariosDto usuario);
        void UpdateUsuario(UsuariosDto usuario);
        void DeleteUsuario(int id);
    }
}
