using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactory
{
    public class Inventario
    {
        private List<Producto> productos = new List<Producto>();

        // Crear nuevo producto
        public void CrearProducto(int id, string nombre, decimal precio, int cantidadStock)
        {
            productos.Add(new Producto { ID = id, Nombre = nombre, Precio = precio, CantidadStock = cantidadStock });
            Console.WriteLine("Producto añadido exitosamente.");
        }

        // Mostrar lista de productos
        public void MostrarProductos()
        {
            Console.WriteLine("Lista de Productos:");
            foreach (var producto in productos)
            {
                Console.WriteLine($"ID: {producto.ID}, Nombre: {producto.Nombre}, Precio: {producto.Precio}, Stock: {producto.CantidadStock}");
            }
        }

        // Buscar producto por nombre
        public Producto BuscarProductoPorNombre(string nombre)
        {
            return Buscar(nombre);
        }

        // Actualizar precio del producto
        public void ActualizarPrecioProducto(int id, decimal nuevoPrecio)
        {
            
            var producto = Buscar(id.ToString());
            if (producto != null)
            {
                producto.Precio = nuevoPrecio;
                Console.WriteLine($"El precio del producto con ID {producto.ID} ha sido actualizado a {nuevoPrecio:C}.");
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }
        }
        private  Producto Buscar(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                Console.WriteLine("El nombre del producto no puede estar vacío.");
                return null;
            }
            return productos.FirstOrDefault(p => p.Nombre.Contains(nombre, StringComparison.OrdinalIgnoreCase));
        }
         


    }
}

