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
        private List<Paciente> pacientes;
        private int proximoId;

        public RepositorioPaciente()
        {
            pacientes = new List<Paciente>();
            proximoId = 1;

            // Por questão de teste, vou inicializar com alguns pacientes:
            pacientes.Add(new Paciente { Id = proximoId++, CPF = "123456789-1", Nome = "Maria", Historico= "Intolerância a lactose." });
            pacientes.Add(new Paciente { Id = proximoId++, CPF = "321321321-2", Nome = "João", Historico = "" });
            pacientes.Add(new Paciente { Id = proximoId++, CPF = "475658765-3", Nome = "Marcos", Historico = "Alergia à penicilina" });
            pacientes.Add(new Paciente { Id = proximoId++, CPF = "878897888-4", Nome = "José"});
        }

        public Paciente ObterPaciente(int id)
        {
            return pacientes.First(c => c.Id == id);
        }

        public List<Paciente> ObterPacientes(string nome = null)
        {

            if (string.IsNullOrEmpty(nome))
            {
                return pacientes;
            }

            return pacientes
                .Where(c => c.Nome.Contains(nome))
                .ToList();
        }
        
        public Paciente Inserir(string nome, string cpf, string historico)
        {
            var paciente = new Paciente()
            {
                Id = proximoId++,
                CPF = cpf,
                Nome = nome,
                Historico = historico
            };

            pacientes.Add(paciente);
            return paciente;
        }

        public void Atualizar(int id, string nome, string cpf, string historico)
        {
            var paciente = pacientes.First(c => c.Id == id);
            paciente.Nome = nome;
            paciente.CPF = cpf;
            paciente.Historico = historico;
        }

        public void Excluir(int id)
        {
            var paciente = ObterPaciente(id);
            pacientes.Remove(paciente);
        }
    }
}
