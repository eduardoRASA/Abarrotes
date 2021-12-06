using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using RestSharp;
using Abarrotes.Shared;
using System.Net;

namespace Abarrotes.DAL
{
    public class UsuariosDao : IUsuariosDao
    {
        public void AddUsuario(UsuariosDto usuario)
        {
            try
            {
                var client = new RestClient(Constants.apiUrlUsuarios);
                var request = new RestRequest(Constants.addUsuario, Method.POST);
                string jBody = JsonConvert.SerializeObject(usuario);
                request.AddJsonBody(jBody);
                var response = client.Execute(request);
                if(response.StatusCode != HttpStatusCode.OK)
                {
                    new Exception("Ocurrió un error al guardar al usuario en la base de datos. Se obtuvo un StatusCode: " + response.StatusCode.ToString());
                }
            }
            catch(Exception ex)
            {
                new Exception(ex.Message);
            }
        }

        public void DeleteUsuario(int id)
        {
            try
            {
                var client = new RestClient(Constants.apiUrlUsuarios);
                var request = new RestRequest(Constants.deleteUsuario + "?id=" + id, Method.DELETE);
                var response = client.Execute(request);
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    new Exception("Ocurrió un error al eliminar al usuario en la base de datos. Se obtuvo un StatusCode: " + response.StatusCode.ToString());
                }
            }
            catch (Exception ex)
            {
                new Exception(ex.Message);
            }
        }

        public UsuariosDto GetUsuario(int id)
        {
            UsuariosDto usuario = new UsuariosDto();
            try
            {
                var client = new RestClient(Constants.apiUrlUsuarios);
                var request = new RestRequest(Constants.getusuario + "?id=" + id, Method.GET);
                var response = client.Execute(request);
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    new Exception("Ocurrió un error al obtener al usuario en la base de datos. Se obtuvo un StatusCode: " + response.StatusCode.ToString());
                }
                usuario = JsonConvert.DeserializeObject<UsuariosDto>(response.Content);
            }
            catch (Exception ex)
            {
                new Exception(ex.Message);
            }
            return usuario;
        }

        public List<UsuariosDto> GetUsuarios()
        {
            List<UsuariosDto> usuarios = new List<UsuariosDto>();
            try
            {
                var client = new RestClient(Constants.apiUrlUsuarios);
                var request = new RestRequest(Constants.getUsuarios, Method.GET);
                var response = client.Execute(request);
                if (response.Content != null && response.Content != string.Empty)
                {
                    usuarios = JsonConvert.DeserializeObject<List<UsuariosDto>>(response.Content);
                }
            }
            catch (Exception ex)
            {
                new Exception(ex.Message);
            }
            return usuarios;
        }

        public void UpdateUsuario(UsuariosDto usuario)
        {
            try
            {
                var client = new RestClient(Constants.apiUrlUsuarios);
                var request = new RestRequest(Constants.updateusuario, Method.POST);
                string jBody = JsonConvert.SerializeObject(usuario);
                request.AddJsonBody(jBody);
                var response = client.Execute(request);
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    new Exception("Ocurrió un error al actualizar al usuario en la base de datos. Se obtuvo un StatusCode: " + response.StatusCode.ToString());
                }
            }
            catch (Exception ex)
            {
                new Exception(ex.Message);
            }
        }
    }
}
