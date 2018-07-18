using Clinica.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Repositorio
{
    /// <summary>
    /// Essa classe faz um mock do banco de dados apenas para ter alguma persistência
    /// As informações não ficam disponíveis após fecha a aplicação.
    /// </summary>
    public static class DbMock
    {
        public static List<Medico> Medicos { get; set; }
        public static List<Consulta> Consultas { get; set; }
        public static List<Paciente> Pacientes { get; set; }

        private static int id;
        public static int ProximoId
        {
            get
            {
                return id++;
            }
        }

        static DbMock()
        {
            id = 1;

            Medicos = new List<Medico>
            {
                new Medico { Id = ProximoId, CPF = "123456789-1", CRM = 12345, Nome = "Magali", Especialidade = TipoEspecialidade.Cardiologista },
                new Medico { Id = ProximoId, CPF = "321321321-2", CRM = 32325, Nome = "Monica", Especialidade = TipoEspecialidade.ClinicoGeral },
                new Medico { Id = ProximoId, CPF = "475658765-3", CRM = 58847, Nome = "Cebolinha", Especialidade = TipoEspecialidade.Dermatologista },
                new Medico { Id = ProximoId, CPF = "878897888-4", CRM = 88655, Nome = "Cascão", Especialidade = TipoEspecialidade.Ortopedista },
                new Medico { Id = ProximoId, CPF = "995544111-5", CRM = 33557, Nome = "Franjinha", Especialidade = TipoEspecialidade.Pediatra }
            };

            Pacientes = new List<Paciente>
            {
                new Paciente { Id = ProximoId, CPF = "123456789-1", Nome = "Maria", Historico = "Intolerância a lactose." },
                new Paciente { Id = ProximoId, CPF = "321321321-2", Nome = "João", Historico = "" },
                new Paciente { Id = ProximoId, CPF = "475658765-3", Nome = "Marcos", Historico = "Alergia à penicilina" },
                new Paciente { Id = ProximoId, CPF = "878897888-4", Nome = "José" }
            };
            
            Consultas = new List<Consulta>
            {
                new Consulta { Id = ProximoId, Medico = Medicos[0], Paciente = Pacientes[0], Data = new DateTime(2018, 08, 20, 10, 00, 0) },
                new Consulta { Id = ProximoId, Medico = Medicos[0], Paciente = Pacientes[1], Data = new DateTime(2018, 08, 20, 11, 00, 0) },
                new Consulta { Id = ProximoId, Medico = Medicos[1], Paciente = Pacientes[1], Data = new DateTime(2018, 08, 20, 11, 00, 0) },
                new Consulta { Id = ProximoId, Medico = Medicos[1], Paciente = Pacientes[2], Data = new DateTime(2018, 08, 21, 11, 00, 0) },
                new Consulta { Id = ProximoId, Medico = Medicos[2], Paciente = Pacientes[3], Data = new DateTime(2018, 09, 22, 14, 00, 0) },
                new Consulta { Id = ProximoId, Medico = Medicos[3], Paciente = Pacientes[3], Data = new DateTime(2018, 09, 23, 15, 00, 0) },
                new Consulta { Id = ProximoId, Medico = Medicos[4], Paciente = Pacientes[2], Data = new DateTime(2018, 09, 24, 16, 00, 0) }
            };

        }

    }
}
