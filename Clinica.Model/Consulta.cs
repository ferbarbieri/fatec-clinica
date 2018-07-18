using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Modelo
{
    public class Consulta
    {
        public int Id { get; set; }
        public Paciente Paciente { get; set; }
        public Medico Medico { get; set; }
        public DateTime Data { get; set; }
        
        public string ResumoConsulta
        {
            get
            {
                return $"{Data.ToString("dd/MM - HH:mm")} - Paciente: {Paciente.Nome} - Tipo de Consulta {Medico.Especialidade}";
            }
        }

    }
}
