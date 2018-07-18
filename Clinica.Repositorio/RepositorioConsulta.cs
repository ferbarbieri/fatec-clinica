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

        public Consulta ObterConsulta(int id)
        {
            return DbMock.Consultas.First(c => c.Id == id);
        }

        public List<Consulta> ObterConsultasPorMedico(int idMedico)
        {
            return DbMock.Consultas
                .Where(c => c.Medico.Id == idMedico)
                .ToList();
        }

        public Consulta Inserir(Medico medico, Paciente paciente, DateTime data)
        {
            var consulta = new Consulta()
            {
                Id = DbMock.ProximoId,
                Medico = medico,
                Paciente = paciente,
                Data = data
            };

            DbMock.Consultas.Add(consulta);
            return consulta;
        }

        public void Atualizar(int id, Paciente paciente, DateTime novaData)
        {
            var consulta = DbMock.Consultas.First(c => c.Id == id);
            consulta.Data = novaData;
            consulta.Paciente = paciente;
        }

        public void Excluir(int id)
        {
            var consulta = ObterConsulta(id);
            DbMock.Consultas.Remove(consulta);
        }


    }
}
