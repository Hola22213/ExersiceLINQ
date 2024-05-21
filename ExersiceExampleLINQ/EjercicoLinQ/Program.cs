using DemoArraysLinq.Models;
using System;

namespace DemoArraysLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            DataArrayList dataArrayList = new DataArrayList();

            // Agregar elementos a la lista
            dataArrayList.AddItem("Elemento 1");
            dataArrayList.AddItem("Elemento 2");
            dataArrayList.AddItem(123); // También se pueden agregar tipos diferentes en ArrayList

            // Imprimir los elementos
            Console.WriteLine("Elementos en la lista:");
            dataArrayList.PrintItems();

            // Eliminar un elemento
            dataArrayList.RemoveItem("Elemento 1");

            // Imprimir los elementos nuevamente
            Console.WriteLine("\nElementos en la lista después de eliminar 'Elemento 1':");
            dataArrayList.PrintItems();
        }
    }
}
