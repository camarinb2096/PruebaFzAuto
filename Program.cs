using System;
using AppAcceso;

namespace MiPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            AppAcceso.Controllers.UsuarioController vista = new AppAcceso.Controllers.UsuarioController();
            vista.Registro();

            Console.ReadLine();
        }
    }
}
