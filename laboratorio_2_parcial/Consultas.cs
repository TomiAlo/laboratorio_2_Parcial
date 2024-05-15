using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio_2_parcial
{
    public class Consultas
    {
        private DateTime fecha;
        private Paciente paciente;

        public Consultas(DateTime fecha, Paciente paciente)
        {
            this.fecha = fecha;
            this.paciente = paciente;
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public Paciente Paciente
        {
            get { return paciente; }
        }

        public override string ToString()
        {
            return $"Fecha: {fecha} se ha atendido a {paciente.NombreCompleto}";
        }
    }
}
