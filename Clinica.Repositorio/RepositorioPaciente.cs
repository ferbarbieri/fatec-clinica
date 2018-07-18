using Clinica.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Repositorio
{
    public class RepositorioPaciente
    {
        public Paciente ObterPaciente(int id)
        {
            return DbMock.Pacientes.First(c => c.Id == id);
        }

        public List<Paciente> ObterPacientes(string nome = null)
        {

            if (string.IsNullOrEmpty(nome))
            {
                return DbMock.Pacientes;
            }

            return DbMock.Pacientes
                .Where(c => c.Nome.Contains(nome))
                .ToList();
        }
        
        public Paciente Inserir(string nome, string cpf, string historico)
        {
            var paciente = new Paciente()
            {
                Id = DbMock.ProximoId,
                CPF = cpf,
                Nome = nome,
                Historico = historico
            };

            DbMock.Pacientes.Add(paciente);
            return paciente;
        }

        public void Atualizar(int id, string nome, string cpf, string historico)
        {
            var paciente = DbMock.Pacientes.First(c => c.Id == id);
            paciente.Nome = nome;
            paciente.CPF = cpf;
            paciente.Historico = historico;
        }

        public void Excluir(int id)
        {
            var paciente = ObterPaciente(id);
            DbMock.Pacientes.Remove(paciente);
        }
    }
}
