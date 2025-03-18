using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstract
{
    public class EmpleadoTiempoCompleto : Empleado
    {
        private int bono;
        private DateTime horaInicio;
        private DateTime horasalida;
        public EmpleadoTiempoCompleto(string nombre, string apellido, Cargo cargo, short identificacion, string departamento, double salarioBase, string eps, string fondoDePensiones, int bono, DateTime horaInicio, DateTime horasalida) : base(nombre, apellido, cargo, identificacion, departamento, salarioBase, eps, fondoDePensiones)
        {
            this.bono = bono;
            this.horaInicio = horaInicio;
            this.horasalida = horasalida;
        }

        public int Bono { get => bono; set => bono = value; }
        public DateTime HoraInicio { get => horaInicio; set => horaInicio = value; }
        public DateTime Horasalida { get => horasalida; set => horasalida = value; }

        public override double calcularSalario()
        {
            double salario = this.SalarioBase - (this.SalarioBase * (PORCENTAJE_EPS + PORCENTAJE_PENSION));
            salario += bono;

            return salario;
        }
    }
}
