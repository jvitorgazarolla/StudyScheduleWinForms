using StudySchedule.Application.DTOs.Especialidade;
using StudySchedule.Application.DTOs.Profissional;
using StudySchedule.Application.Services.Especialidade;
using StudySchedule.Application.Services.Profissional;
using StudySchedule.Infrastructure.Repositories.Especialidade;
using StudySchedule.Infrastructure.Repositories.Profissional;
using StudySchedule.UI.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Windows.Forms;

namespace StudySchedule.UI.Forms.Profissiional
{
    public partial class FormProfissional : Form
    {
        private readonly EspecialidadeService _especialidadeService;
        private readonly ProfissionalService _profissionalService;
        private bool _edicao = false;
        private int _idSelecionado = 0;

        public FormProfissional()
        {
            InitializeComponent();
      
            check_status.Checked = true;
            
            var repositoryEspecialidade = new EspecialidadeRepository();
            _especialidadeService = new EspecialidadeService();
            _profissionalService = new ProfissionalService();
            buscarEspecialidade();

        }

        private void Profissional_Load(object sender, EventArgs e)
        {
            //check_status.Checked = true;
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            ExibirPainelEdicao(true);
            txt_nome.Text = null;
            txt_telefone.Text = null;
            check_status.Checked = true;
            btn_salvar.Text = "Cadastrar";
            _edicao = false;
        }
        private void ExibirPainelEdicao(bool mostrar)
        {
            pnl_edicao.Visible = mostrar;
        }

        private void buscarEspecialidade()
        {

            var lista = _especialidadeService.Buscar(null, true);
            cb_especialidade.DataSource = null;
            cb_especialidade.DataSource = lista;

            cb_especialidade.DisplayMember = "Descricao";
            cb_especialidade.ValueMember = "Id";
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            //OBS-> Lembrar de criar função  para limpr campo após salvar -> 15/02
            var nome = txt_nome.Text;
            var telefone = txt_telefone.Text;
            var status = check_status.Checked;
            var especialidadeId = Convert.ToInt32(cb_especialidade.SelectedValue);

            if (_edicao)
            {
                var resultEdit = _profissionalService.Atualizar(_idSelecionado, nome, telefone, status, especialidadeId);

                if (!resultEdit.ok)
                {
                    MessageBox.Show(resultEdit.msg);
                    return;
                }

                MessageBox.Show(resultEdit.msg);
            }
            else
            {

            var resultInsert = _profissionalService.Inserir(nome, telefone, status, especialidadeId);

            if (!resultInsert.ok)
            {
                MessageBox.Show(resultInsert.msg);
            }

            MessageBox.Show(resultInsert.msg);
            txt_nome.Text = null;
            txt_telefone.Text = null;
            check_status.Checked = false;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            pnl_edicao.Visible = false;
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_nome.Text = null;
            txt_telefone.Text = null;
            check_status.Checked = false;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            ExibirPainelEdicao(false);
            var termo = txt_busca_profissional.Text;

            dgv_profissional.DataSource = null;

            var lista = _profissionalService.Buscar(termo);

            if (lista != null)
            {
                dgv_profissional.DataSource = lista;


                dgv_profissional.removeColumn("id");
                dgv_profissional.removeColumn("EspecialidadeId");
                dgv_profissional.setHeader("EspecialidadeNome", "Especialidade");
            }

            dgv_profissional.addButtons();
            dgv_profissional.Refresh();
        }


        private void dgv_profissional_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string colunaSelecionada = dgv_profissional.Columns[e.ColumnIndex].Name;
            var selecionado = dgv_profissional.Rows[e.RowIndex].DataBoundItem as ProfissionalDto;
            if (selecionado == null)
            {
                return;
            }

            switch (colunaSelecionada)
            {
                case "btnEditar":
                    _edicao = true;
                    _idSelecionado = selecionado.Id;
                    ExibirPainelEdicao(true);
                    txt_nome.Text = selecionado.Nome;
                    txt_telefone.Text = selecionado.Telefone;
                    check_status.Checked = selecionado.Status;
                    cb_especialidade.SelectedValue = selecionado.EspecialidadeId;
                    btn_salvar.Text = "Atualizar";
    
                    break;
                case "btnDesativar":
                    var r = _profissionalService.Atualizar(selecionado.Id, status: false, desativar: true);
                    if (!r.ok)
                    {
                        MessageBox.Show(r.msg);
                        return;
                    }
                    MessageBox.Show(r.msg);
                    break;

                case "btnExcluir":
                    var confirm = MessageBox.Show(
                        "Tem certeza que deseja excluir este profissional?",
                        "Confirmar exclusão",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );
                    if (confirm != DialogResult.Yes)
                    {
                        return;
                    }

                    r = _profissionalService.Excluir(selecionado.Id);
                    MessageBox.Show(r.msg);

                    break;
            }



      
        }
    }
}
