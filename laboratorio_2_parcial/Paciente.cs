using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio_2_parcial
{
    public class Paciente:Persona
    {
        public string diagnostico;

        public Paciente(string apellido, string nombre, DateTime nacimiento, string barrioRecidencia, string diagnostico=null):base(apellido, nombre, nacimiento, barrioRecidencia)
        {
            this.diagnostico = diagnostico;
        }

        internal override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Reside en: {barrioRecidencia}");
            sb.AppendLine($"{diagnostico}");

            return sb.ToString();
        }
    }
}
