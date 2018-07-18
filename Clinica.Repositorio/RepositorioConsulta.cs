using Clinica.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Repositorio
{
    public class RepositorioConsulta
    {
        private List<Consulta> consultas;
        private int proximoId;

        public RepositorioConsulta()
        {
            consultas = new List<Consulta>();
            proximoId = 1;

            var repoMedico = new RepositorioMedico();
            var repoPaciente = new RepositorioPaciente();

            // Por questão de teste, vou inicializar com algumas consultas:
            consultas.Add(new Consulta { Id = proximoId++, Medico = repoMedico.ObterMedico(1), Paciente = repoPaciente.ObterPaciente(1), Data = new DateTime(2018, 08, 20, 10, 00, 0) });
            consultas.Add(new Consulta { Id = proximoId++, Medico = repoMedico.ObterMedico(1), Paciente = repoPaciente.ObterPaciente(2), Data = new DateTime(2018, 08, 20, 11, 00, 0) });
            consultas.Add(new Consulta { Id = proximoId++, Medico = repoMedico.ObterMedico(2), Paciente = repoPaciente.ObterPaciente(3), Data = new DateTime(2018, 08, 20, 11, 00, 0) });
            consultas.Add(new Consulta { Id = proximoId++, Medico = repoMedico.ObterMedico(2), Paciente = repoPaciente.ObterPaciente(4), Data = new DateTime(2018, 08, 21, 11, 00, 0) });
            consultas.Add(new Consulta { Id = proximoId++, Medico = repoMedico.ObterMedico(3), Paciente = repoPaciente.ObterPaciente(1), Data = new DateTime(2018, 09, 22, 14, 00, 0) });
            consultas.Add(new Consulta { Id = proximoId++, Medico = repoMedico.ObterMedico(4), Paciente = repoPaciente.ObterPaciente(2), Data = new DateTime(2018, 09, 23, 15, 00, 0) });
            consultas.Add(new Consulta { Id = proximoId++, Medico = repoMedico.ObterMedico(5), Paciente = repoPaciente.ObterPaciente(3), Data = new DateTime(2018, 09, 24, 16, 00, 0) });
        }

        public Consulta ObterConsulta(int id)
        {
            return consultas.First(c => c.Id == id);
        }

        public List<Consulta> ObterConsultasPorMedico(int idMedico)
        {
            return consultas
                .Where(c => c.Medico.Id == idMedico)
                .ToList();
        }

        public Consulta Inserir(Medico medico, Paciente paciente, DateTime data)
        {
            var consulta = new Consulta()
            {
                Id = proximoId++,
                Medico = medico,
                Paciente = paciente,
                Data = data
            };

            consultas.Add(consulta);
            return consulta;
        }

        public void Atualizar(int id, Paciente paciente, DateTime novaData)
        {
            var consulta = consultas.First(c => c.Id == id);
            consulta.Data = novaData;
            consulta.Paciente = paciente;
        }

        public void Excluir(int id)
        {
            var consulta = ObterConsulta(id);
            consultas.Remove(consulta);
        }


    }
}
