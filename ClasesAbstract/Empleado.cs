using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstract
{
    public abstract class Empleado
    {
        public const double PORCENTAJE_EPS = 0.04;
        public const double PORCENTAJE_PENSION = 0.04;
        private string nombre;
        private string apellido;
        private Cargo cargo;
        private short identificacion;
        private string departamento;
        private double salarioBase;
        private string eps;
        private string fondoDePensiones;

        public Empleado(string nombre, string apellido, Cargo cargo, short identificacion, string departamento, double salarioBase, string eps, string fondoDePensiones)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.cargo = cargo;
            this.identificacion = identificacion;
            this.departamento = departamento;
            this.salarioBase = salarioBase;
            this.eps = eps;
            this.fondoDePensiones = fondoDePensiones;
        }

        public string Nombre { get ; set ; }
        public string Apellido { get ; set ; }
        public Cargo Cargo { get ; set ; }
        public string Identificacion { get ; set; }
        public string Departamento { get ; set ; }
        public double SalarioBase { get ; set ; }
        public string Eps { get; set; }
        public string FondoDePensiones { get;set; }


        public virtual double calcularSalario()
        {
            return salarioBase;
        }
    }

    public enum Cargo
    {
        Recepcionista = 0,
        Contador = 1,
        ASistenteAdministrativo = 2,
        Abogado = 3,
        Ingeniero = 4,
        Tecnico = 5,

    }
}
