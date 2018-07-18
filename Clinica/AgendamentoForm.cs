using Clinica.Modelo;
using Clinica.Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica
{
    public partial class AgendamentoForm : Form
    {
        RepositorioMedico repoMedico;
        RepositorioConsulta repoConsulta;
        RepositorioPaciente repoPaciente;

        public AgendamentoForm()
        {
            InitializeComponent();
            repoMedico = new RepositorioMedico();
            repoConsulta = new RepositorioConsulta();
            repoPaciente = new RepositorioPaciente();
        }
        
        private void AgendamentoForm_Load(object sender, EventArgs e)
        {
            CarregarMedicos();
        }

        private void CarregarMedicos()
        {
            // Lista de médicos atualmente cadastrados
            var meds = repoMedico.ObterMedicos();

            // Necessário para atualizar as informações quando alteradas:
            BindingList<Medico> medicos = new BindingList<Medico>(meds);

            // Carrega os dados na lista:
            lstMedicos.DataSource = medicos;
            lstMedicos.DisplayMember = "Nome";
            lstMedicos.ValueMember = "Id";
        }

        private void CarregarConsultas(Medico medico)
        {
            // Lista de médicos atualmente cadastrados
            var cons = repoConsulta.ObterConsultasPorMedico(medico.Id);

            // Necessário para atualizar as informações quando alteradas:
            BindingList<Consulta> consultas = new BindingList<Consulta>(cons);

            // Carrega os dados na lista:
            lstConsultas.DataSource = consultas;
            lstConsultas.DisplayMember = "ResumoConsulta";
            lstConsultas.ValueMember = "Id";
        }

        private void CarregarPacientes()
        {
            // Lista de médicos atualmente cadastrados
            var pacs = repoPaciente.ObterPacientes();

            // Necessário para atualizar as informações quando alteradas:
            BindingList<Paciente> pacientes = new BindingList<Paciente>(pacs);

            // Carrega os dados na lista:
            lstPacientes.DataSource = pacientes;
            lstPacientes.DisplayMember = "Nome";
            lstPacientes.ValueMember = "Id";
        }

        private void lstMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var medicoSelecionado = (Medico)lstMedicos.SelectedItem;

            CarregarConsultas(medicoSelecionado);
        }

        private void lstConsultas_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnNovo.Visible = true;
            CarregarPacientes();

            // Carrega os dados da consulta selecionada
            var consulta = (Consulta)lstConsultas.SelectedItem;

            lblId.Text = consulta.Id.ToString();
            dtConsulta.Value = consulta.Data;
            hrConsulta.Value = consulta.Data;

            lstPacientes.SelectedValue = consulta.Paciente.Id;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            // informações pra salvar:
            var data = dtConsulta.Value;
            var hora = hrConsulta.Value;
            var dataHora = new DateTime(data.Year, data.Month, data.Day, hora.Hour, hora.Minute, hora.Second);
            var medico = (Medico)lstMedicos.SelectedItem;
            var paciente = (Paciente) lstPacientes.SelectedItem;

            // é pra atualizar ou criar um novo?
            if (lblId.Text != string.Empty)
            {
                // Atualizar
                var id = int.Parse(lblId.Text);
                repoConsulta.Atualizar(id, paciente, dataHora);
            }
            else
            {
                // Novo
                repoConsulta.Inserir(medico, paciente, dataHora);
            }
            // Atualiza a lista atual
            CarregarConsultas(medico);
        }
        
        private void btnNovaConsulta_Click(object sender, EventArgs e)
        {
            lblId.Text = string.Empty;
            lstPacientes.SelectedItem = null;
            dtConsulta.Value = DateTime.Now;
            hrConsulta.Value = DateTime.Now;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // Deve existir um médico selecionado:
            if (string.IsNullOrEmpty(lblId.Text))
            {
                MessageBox.Show("Selecione um agendamento para excluir");
                return;
            }
            // Confirma:
            var confirmacao = MessageBox.Show("Confirma a exclusão?", "Excluir Consulta", MessageBoxButtons.YesNo);

            if (confirmacao == DialogResult.Yes)
            {
                repoConsulta.Excluir(int.Parse(lblId.Text));
            }

            var medico = (Medico)lstMedicos.SelectedItem;
            CarregarConsultas(medico);
        }

        public void AbrirConsultasMedico(Medico medico)
        {
            lstMedicos.SelectedValue = medico.Id;
            btnNovaConsulta_Click(null, null);
        }
    }
}
