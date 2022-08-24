using System;
using System.Threading;// sirve para controlar el tiempo de limpieza de un mensaje 

namespace ExpendedoraBase
{
    class Expendedora
    {
        string marca;
        byte temperatura;
        string codigo;
        float precio;


        public Expendedora()
        {

            Saludar();
            marca= "AMS";
            Console.WriteLine("Marca:"+marca);
            ControlarTiempoDisplay();
            temperatura = 14;
            Console.WriteLine("La temperatura es: " + temperatura+"°C");
            ControlarTiempoDisplay();
            codigo=MostrarCodigo();
            ControlarTiempoDisplay();
            MostrarPrecio(codigo);
        }
        void ControlarTiempoDisplay()
        {
            Thread.Sleep(2000);// tiempo que dura el mensaje 
            Console.Clear();// limpiar despues de cierto intervalo de tiempo dicho mensaje
        }
        void Saludar()
        {
            Console.WriteLine("Bienvenido");
        }
        string MostrarCodigo()
        {
            Console.WriteLine("A1: Kinder Delice \tB2:Takis \tC3:Donitas");
            Console.WriteLine("Ingresa el codigo del producto que quieres: ");
            string codigo = Console.ReadLine();// codigo es una variable local
            return codigo;
        }
        void MostrarPrecio(string codigo)
        {
            switch (codigo)
            {
                case "A1":
                    Console.WriteLine("el precio es: {0} ",precio);
                    break;
                case "B2":
                    Console.WriteLine("el precio es: {0} ", precio);
                    break;
                case "C3":
                    Console.WriteLine("el precio es: {0} ", precio);
                    break;
                default:
                    Console.WriteLine("producto no reconocido");
                    break;
            }
        }
    }
}
