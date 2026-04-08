using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    class Empleado
    {
        private string nombre;
        private int edad;
        private double salario;

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        public int Edad
        {
            get=> edad;
            set => edad = value;
        }
        public double Salario
        {
            get => salario;
            set => salario = value;
        }

        public Empleado()
        {
            nombre = "Sin nombre";
            edad = 0;
            salario = 0;
        }
        public Empleado (string nombre, int edad, double salario)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.salario = salario;
        }

        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Nombre: {nombre}, Edad: {edad}, Salario: {salario}");
        }
    }
}
