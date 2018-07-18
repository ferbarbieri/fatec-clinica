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
    public partial class PacientesForm : Form
    {
        private RepositorioPaciente repo;

        public PacientesForm()
        {
            InitializeComponent();

            // Inicializa o repositório:
            repo = new RepositorioPaciente();
        }

        private void PacientesForm_Load(object sender, EventArgs e)
        {
            CarregarPacientes();
        }

        private void CarregarPacientes()
        {
            // Lista de médicos atualmente cadastrados
            var pacs = repo.ObterPacientes();

            // Necessário para atualizar as informações quando alteradas:
            BindingList<Paciente> pacientes = new BindingList<Paciente>(pacs);

            // Carrega os dados na lista:
            lstPacientes.DataSource = pacientes;
            lstPacientes.DisplayMember = "Nome";
            lstPacientes.ValueMember = "Id";
        }

        private void lstPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Carrega os dados do médico no form:
            Paciente paciente = (Paciente)lstPacientes.SelectedItem;

            lblId.Text = paciente.Id.ToString();
            txtNome.Text = paciente.Nome;
            txtCPF.Text = paciente.CPF;
            txtHistorico.Text = paciente.Historico;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // validações:
            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtCPF.Text))
            {
                MessageBox.Show("Todas as informações devem ser preenchidas");
                return;
            }

            // informações pra salvar:
            var cpf = txtCPF.Text;
            var nome = txtNome.Text;
            var historico = txtHistorico.Text;

            // é pra atualizar ou criar um novo?
            if (lblId.Text != string.Empty)
            {
                // Atualizar
                var id = int.Parse(lblId.Text);
                repo.Atualizar(id, nome, cpf, historico);
            }
            else
            {
                // Novo
                repo.Inserir(nome, cpf, historico);
            }

            // Atualiza a lista atual
            CarregarPacientes();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // Deve existir um médico selecionado:
            if (string.IsNullOrEmpty(lblId.Text))
            {
                MessageBox.Show("Selecione um paciente para excluir");
                return;
            }
            // Confirma:
            var confirmacao = MessageBox.Show("Confirma a exclusão?", "Excluir Paciente", MessageBoxButtons.YesNo);

            if (confirmacao == DialogResult.Yes)
            {
                repo.Excluir(int.Parse(lblId.Text));
            }

            CarregarPacientes();

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            lblId.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtCPF.Text = string.Empty;
            txtHistorico.Text = string.Empty;
        }
    }
}
