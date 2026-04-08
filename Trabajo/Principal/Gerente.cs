using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    class Gerente : Empleado
    {
        private string depto;
        public string Depto
        {
            get => depto;
            set => depto = value;
        }

        public Gerente() : base()
        {
            depto = "Sin departamento";
        }

        public Gerente(string nombre, int edad, double salario, string depto) : base (nombre, edad, salario)
        {
            this.depto = depto;
        }

        public override void MostrarInfo()
        {
            Console.WriteLine($"El departamento es: {depto}");
        }
    }
}
