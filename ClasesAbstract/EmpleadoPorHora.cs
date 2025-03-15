using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstract
{
    internal class EmpleadoPorHora : Empleado
    {
        private string arl;
        private double horasTrabajadas;
        private double valorHora;
        public EmpleadoPorHora(string nombre, string apellido, Cargo cargo, short identificacion, string departamento, double salarioBase, string eps, string fondoDePensiones, string arl, double horasTrabajadas, double valorHora) : base(nombre, apellido, cargo, identificacion, departamento, salarioBase, eps, fondoDePensiones)
        {
            this.arl = arl;
            this.horasTrabajadas = horasTrabajadas;
            this.valorHora = valorHora;
        }

        public string Arl { get => arl; set => arl = value; }
        public double HorasTrabajadas { get => horasTrabajadas; set => horasTrabajadas = value; }
        public double ValorHora { get => valorHora; set => valorHora = value; }
    }
}
