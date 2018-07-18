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
        
        public Medico ObterMedico(int id)
        {
            return DbMock.Medicos.First(c => c.Id == id);
        }

        public List<Medico> ObterMedicos(string nome = null)
        {

            if (string.IsNullOrEmpty(nome))
            {
                return DbMock.Medicos;
            }

            return DbMock.Medicos
                .Where(c => c.Nome.Contains(nome))
                .ToList();
        }

        public List<Medico> ObterMedicosPorEspecialidade(TipoEspecialidade especialidade)
        {
            return DbMock.Medicos
                .Where(c => c.Especialidade == especialidade)
                .ToList();
        }

        public Medico Inserir(string nome, int crm, string cpf, TipoEspecialidade tipo)
        {
            var medico = new Medico()
            {
                Id = DbMock.ProximoId,
                CPF = cpf,
                CRM = crm,
                Nome = nome,
                Especialidade = tipo
            };

            DbMock.Medicos.Add(medico);
            return medico;
        }

        public void Atualizar(int id, string nome, int crm, string cpf, TipoEspecialidade tipo)
        {
            var medico = DbMock.Medicos.First(c=>c.Id == id);
            medico.Nome = nome;
            medico.CRM = crm;
            medico.CPF = cpf;
            medico.Especialidade = tipo;
        }

        public void Excluir(int id)
        {
            var medico = ObterMedico(id);
            DbMock.Medicos.Remove(medico);
        }

    }
}
