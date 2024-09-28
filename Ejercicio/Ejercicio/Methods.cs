using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    internal class Methods
    {
        static void Main(string[] args)
        {
            int InitialStock = 50;
            int quantityToAdd = 20;
            int adddedQuantity;

            UpdateStock(InitialStock, quantityToAdd, out int updatedStock, out adddedQuantity);
            Console.WriteLine($"Inventario Inicial: {InitialStock}");
            Console.WriteLine($"Cantidad Agregada: {quantityToAdd}");
            Console.WriteLine($"Inventario Actualizado: {updatedStock}");

            AdjustStock(ref updatedStock, 10);
            Console.WriteLine($"Ajuste de Entrada: {updatedStock}");

            AdjustStock(ref updatedStock, -20);
            Console.WriteLine($"Ajuste de Salida: {updatedStock}");

            //lectura de producto
            //var infoProduct = GetProductInfo("Laptop", 20);
            (string productName, int stock) = GetProductInfo("Laptop", 20);
            Console.WriteLine($"Nombre del Producto: {productName}");
            Console.WriteLine($"Inventario del Producto: {stock}");


            Console.ReadKey();
        }

        public static void UpdateStock(int InitialStock, int quantityToAdd, out int updateStock, out int addedQuantity)
        {
            //tenemo la variable de lo que añadira
            addedQuantity = quantityToAdd;
            //sumatoria del inventario inicial más lo añadido
            updateStock = InitialStock + addedQuantity;
        }

        public static void AdjustStock(ref int stock, int adjustment)
        {
            stock += adjustment;
        }

        //Ejemplo de Tupla
        public static (string, int) GetProductInfo(string productName, int stcok)
        {
            return (productName, stcok);
        }

    }
}
