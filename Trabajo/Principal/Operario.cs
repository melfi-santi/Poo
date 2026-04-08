using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    class Operario : Empleado
    {
        private string turno;
        public string Turno
        {
            get => turno; 
            set => turno = value;
        }

        public Operario() : base()
        {
            turno = "Sin turno";
        }

        public Operario(string nombre, int edad, double salario, string turno) : base(nombre, edad, salario)
        {
            this.turno = turno;
        }

        public override void MostrarInfo()
        {
            Console.WriteLine($"Turno: {turno}");
        } 
    }
}
