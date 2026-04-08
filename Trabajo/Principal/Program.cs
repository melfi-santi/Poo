
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// IMPORTANTE: para saber si un empleado es gerente o es operario se utiliza objeto.getType() //
//1.Crear un gerente y 4 operarios
//2 . Averiguar cuantos operarios trabajan en turno mañana y cuantos en turno tarde
//3 . Informar quienes trabajan en turno mañana y quienes en el turno tarde
//4 . Cual es el nombre del gerente
//5 . Eliminar a los operarios de menos de 30 años
//6 . Cual es el sueldo promedio de los empleados
namespace Principal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> empleados = new List<Empleado>();

            empleados.Add(new Gerente("Pablo", 35, 900000, "RRHH"));

            empleados.Add(new Operario("Anastasia", 32, 800000, "Mañana"));
            empleados.Add(new Operario("Rodriga", 25, 700000, "Tarde"));
            empleados.Add(new Operario("Maximiliano", 40, 780000, "Mañana"));
            empleados.Add(new Operario("Eugenia", 20, 750000, "Tarde"));

            int mañana = 0;
            int tarde = 0;

            

            empleados.RemoveAll(e => e is Operario && e.Edad < 30);

            Console.WriteLine("Cantidad de operarios en turnos:");
            foreach (Empleado e in empleados) 
            {
                if (e.GetType() == typeof(Operario))
                {
                    Operario op = (Operario)e;
                    if (op.Turno == "Mañana")
                    {
                        mañana++;
                        Console.WriteLine($"El nombre es: {op.Nombre}");
                    }
                    else if (op.Turno == "Tarde")
                    {
                        tarde++;
                        Console.WriteLine($"El nombre es: {op.Nombre}");
                    }
                }
            }
            Console.WriteLine($"Mañana: {mañana}");
            Console.WriteLine($"Tarde: {tarde}");

            foreach (Empleado e in empleados)
            {
                if (e.GetType() == typeof(Gerente))
                {
                    Gerente g = (Gerente)e;
                    Console.WriteLine($"Nombre del gerente: {g.Nombre}");
                }
            }

            double total = 0;

            int cantidad = 0;
            foreach(Empleado e in empleados)
            {
                total += e.Salario;
                cantidad++;
            }
            double promedio = total / cantidad;

            Console.WriteLine($"El promedio de sueldos es: {promedio}");

        }
    }
}
