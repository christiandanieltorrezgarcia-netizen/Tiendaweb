using System;
using System.Collections.Generic;
using System.Text;

using AppTienda.Models;
using AppTienda.Services;
using System.Collections.ObjectModel;

namespace AppTienda.ProductosModel
{
    public class ProductosPageModel
    {
        private readonly ApiService _apiService = new ApiService();

        public ObservableCollection<Producto> Productos { get; set; } = new ObservableCollection<Producto>();

        public async Task CargarProductosAsync()
        {
            var productos = await _apiService.GetProductosAsync();
            Productos.Clear();
            foreach (var p in productos)
            {
                Productos.Add(p);
            }
        }
    }
}
