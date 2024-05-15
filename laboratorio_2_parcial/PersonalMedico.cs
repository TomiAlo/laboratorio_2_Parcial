using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio_2_parcial
{
    public class PersonalMedico:Persona
    {
        private List<Consultas> consultas;
        private bool esResidente;

        public PersonalMedico(string apellido, string nombre, DateTime nacimiento, bool esResidente, List<Consultas> consultas = null) : base(apellido, nombre, nacimiento)
        {
            this.consultas = consultas ?? new List<Consultas>();
            this.esResidente = esResidente;
        }

        internal override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();
            if (esResidente == false)
            {
                sb.AppendLine("Finalizo residencia? NO");
            }
            else
            {
                sb.AppendLine($"Finalizo residencia? SI");
            }
            
            sb.AppendLine($"ATENCIONES:");

            foreach (Consultas s in consultas)
            {
                if (s!=null)
                {
                    sb.AppendLine(s.ToString());
                }
            }
            return sb.ToString();
        }

        public static PersonalMedico operator +(PersonalMedico medico, Consultas consulta)
        {
            consulta.Fecha = DateTime.Now;
            medico.consultas.Add(consulta);
            return medico;
        }

        public string ObtenerFichaExtra()
        {
            return FichaExtra();
        }
    }
}
