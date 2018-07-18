using Clinica.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Repositorio
{
    public class RepositorioMedico
    {
        private List<Medico> medicos;
        private int proximoId;

        public RepositorioMedico()
        {
            medicos = new List<Medico>();
            proximoId = 1;

            // Por questão de teste, vou inicializar com alguns médicos:
            medicos.Add(new Medico { Id = proximoId++, CPF = "123456789-1", CRM = 12345, Nome = "Magali", Especialidade = TipoEspecialidade.Cardiologista });
            medicos.Add(new Medico { Id = proximoId++, CPF = "321321321-2", CRM = 32325, Nome = "Monica", Especialidade = TipoEspecialidade.ClinicoGeral });
            medicos.Add(new Medico { Id = proximoId++, CPF = "475658765-3", CRM = 58847, Nome = "Cebolinha", Especialidade = TipoEspecialidade.Dermatologista});
            medicos.Add(new Medico { Id = proximoId++, CPF = "878897888-4", CRM = 88655, Nome = "Cascão", Especialidade = TipoEspecialidade.Ortopedista });
            medicos.Add(new Medico { Id = proximoId++, CPF = "995544111-5", CRM = 33557, Nome = "Franjinha", Especialidade = TipoEspecialidade.Pediatra });
        }
        
        public Medico ObterMedico(int id)
        {
            return medicos.First(c => c.Id == id);
        }

        public List<Medico> ObterMedicos(string nome = null)
        {

            if (string.IsNullOrEmpty(nome))
            {
                return medicos;
            }

            return medicos
                .Where(c => c.Nome.Contains(nome))
                .ToList();
        }

        public List<Medico> ObterMedicosPorEspecialidade(TipoEspecialidade especialidade)
        {
            return medicos
                .Where(c => c.Especialidade == especialidade)
                .ToList();
        }

        public Medico Inserir(string nome, int crm, string cpf, TipoEspecialidade tipo)
        {
            var medico = new Medico()
            {
                Id = proximoId++,
                CPF = cpf,
                CRM = crm,
                Nome = nome,
                Especialidade = tipo
            };

            medicos.Add(medico);
            return medico;
        }

        public void Atualizar(int id, string nome, int crm, string cpf, TipoEspecialidade tipo)
        {
            var medico = medicos.First(c=>c.Id == id);
            medico.Nome = nome;
            medico.CRM = crm;
            medico.CPF = cpf;
            medico.Especialidade = tipo;
        }

        public void Excluir(int id)
        {
            var medico = ObterMedico(id);
            medicos.Remove(medico);
        }

    }
}
