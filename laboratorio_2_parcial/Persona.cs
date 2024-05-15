using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio_2_parcial
{
    public abstract class Persona
    {
        protected string apellido;
        protected string barrioRecidencia;
        protected DateTime nacimiento;
        protected string nombre;

        public Persona(string apellido, string nombre, DateTime nacimiento, string barrioRecidencia=null)
        {
            this.apellido = apellido;
            this.barrioRecidencia = barrioRecidencia;
            this.nacimiento = nacimiento;
            this.nombre = nombre;
        }

        public string NombreCompleto
        {
            get { return $"{apellido}, {nombre}"; }
        }

        public int Edad
        {
            get { return DateTime.Today.AddTicks(- this.nacimiento.Ticks).Year - 1; }
        }

        public override string ToString()
        {
            return  $"{apellido}, {nombre}"; 
        }

        public string FichaPersonal()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Apellido: {apellido}, Nombre: {nombre}");
            sb.AppendLine($"Edad: {Edad}");
            sb.AppendLine($"Nacimiento: {nacimiento}");

            return sb.ToString();
        }

        internal abstract string FichaExtra();

    }
}
