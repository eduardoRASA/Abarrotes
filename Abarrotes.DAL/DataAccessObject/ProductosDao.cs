using System;
using System.Collections.Generic;
using RestSharp;
using Abarrotes.Shared;
using Newtonsoft.Json;
using System.Net;

namespace Abarrotes.DAL
{
    public class ProductosDao : IProductosDao
    {
        public List<ProductosDto> GetProductos()
        {
            List<ProductosDto> productos = new List<ProductosDto>();
            try
            {
                var client = new RestClient(Constants.apiUrlProductos);
                var request = new RestRequest(Constants.getProductos, Method.GET);
                var response = client.Execute(request);
                if(response.Content != null && response.Content != string.Empty)
                {
                    productos = JsonConvert.DeserializeObject<List<ProductosDto>>(response.Content);
                }
            }
            catch(Exception ex)
            {
                new Exception(ex.Message);
            }
            return productos;
        }
    }
}
