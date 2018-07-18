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
    public partial class MedicosForm : Form
    {
        // Repositório que é usado pelo form pra acessar os dados:
        private RepositorioMedico repo;
        private RepositorioConsulta repoConsulta;

        public MedicosForm()
        {
            InitializeComponent();

            // Inicializa o repositório:
            repo = new RepositorioMedico();
            repoConsulta = new RepositorioConsulta();
        }

        private void MedicosForm_Load(object sender, EventArgs e)
        {
            CarregarMedicos();

            // Carrega a lista de especialidades do Enum:
            cmbEspecialidade.DataSource = Enum.GetValues(typeof(TipoEspecialidade));
        }

        private void CarregarMedicos()
        {
            // Lista de médicos atualmente cadastrados
            var meds = repo.ObterMedicos();
            
            // Necessário para atualizar as informações quando alteradas:
            BindingList<Medico> medicos = new BindingList<Medico>(meds);

            // Carrega os dados na lista:
            lstMedicos.DataSource = medicos;
            lstMedicos.DisplayMember = "ResumoMedico";
            lstMedicos.ValueMember = "Id";
        }

        private void lstMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Carrega os dados do médico no form:
            Medico medico = (Medico)lstMedicos.SelectedItem;

            lblId.Text = medico.Id.ToString();
            txtNome.Text = medico.Nome;
            txtCPF.Text = medico.CPF;
            txtCRM.Text = medico.CRM.ToString();
            cmbEspecialidade.SelectedItem = medico.Especialidade;
            
            CarregarConsultas(medico);
        }

        private void CarregarConsultas(Medico medico)
        {
            var consultas = repoConsulta.ObterConsultasPorMedico(medico.Id);

            lstConsultas.DataSource = consultas;
            lstConsultas.DisplayMember = "ResumoConsulta";
            lstConsultas.ValueMember = "Id";
            lstConsultas.SelectedItem = null;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // validações:
            if(string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtCPF.Text) || string.IsNullOrEmpty(txtCRM.Text))
            {
                MessageBox.Show("Todas as informações devem ser preenchidas");
                return;
            }

            // informações pra salvar:
            var cpf = txtCPF.Text;
            var nome = txtNome.Text;
            var crm = int.Parse(txtCRM.Text);
            var especialidade = (TipoEspecialidade) cmbEspecialidade.SelectedItem;


            // é pra atualizar ou criar um novo?
            if(lblId.Text != string.Empty)
            {
                // Atualizar
                var id = int.Parse(lblId.Text);
                repo.Atualizar(id, nome, crm, cpf, especialidade);
            }
            else
            {
                // Novo
                repo.Inserir(nome, crm, cpf, especialidade);
            }

            // Atualiza a lista atual
            CarregarMedicos();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // Deve existir um médico selecionado:
            if (string.IsNullOrEmpty(lblId.Text))
            {
                MessageBox.Show("Selecione um médico para excluir");
                return;
            }
            // Confirma:
            var confirmacao = MessageBox.Show("Confirma a exclusão?", "Excluir Médico", MessageBoxButtons.YesNo);

            if (confirmacao == DialogResult.Yes)
            {
                repo.Excluir(int.Parse(lblId.Text));
            }

            CarregarMedicos();

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            lblId.Text = string.Empty;
            txtCPF.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtCRM.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new AgendamentoForm();
            Medico medico = (Medico)lstMedicos.SelectedItem;

            frm.Show();
            frm.AbrirConsultasMedico(medico);
        }
    }
}
