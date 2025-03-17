using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstract
{
    public class EmpleadoRemoto : Empleado

    {
        private double subsidioConectividad;

        public EmpleadoRemoto(string nombre, string apellido, Cargo cargo, short identificacion, string departamento, double salarioBase, string eps, string fondoDePensiones ,double subsidioConectividad):
            base(nombre, apellido, cargo, identificacion, departamento, salarioBase,eps, fondoDePensiones)
        {
            SubsidioConectividad = subsidioConectividad;
            
        }

        public double SubsidioConectividad { get => subsidioConectividad; set => subsidioConectividad = value; }

        public override double calcularSalario()
        {
            double salario = SalarioBase - (SalarioBase * (PORCENTAJE_EPS + PORCENTAJE_PENSION));
            salario += SubsidioConectividad;
            return salario;
        }   
    }
}
