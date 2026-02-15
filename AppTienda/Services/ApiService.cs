using System;
using System.Collections.Generic;
using System.Text;

using AppTienda.Models;
using System.Net.Http.Json;

namespace AppTienda.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:5001/")
            };
        }

        public async Task<List<Producto>> GetProductosAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Producto>>("api/productos") ?? new List<Producto>();
        }
    }
}
