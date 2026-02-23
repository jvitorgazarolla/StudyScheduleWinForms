using StudySchedule.Application.DTOs.Especialidade;
using StudySchedule.Application.Services.Especialidade;
using StudySchedule.Infrastructure.Repositories.Especialidade;
using StudySchedule.UI.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudySchedule.UI.Forms.Especialidade
{
    public partial class FormEspecialidade : Form
    {
        private readonly EspecialidadeService _service;
        private bool _edicao = false;
        private int _idSelecionado = 0;
        public FormEspecialidade()
        {
            InitializeComponent();
            _service = new EspecialidadeService();
        }
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_descricao.Text = null;
            cb_status.Checked = false;

        }
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            var descricao = txt_descricao.Text;
            var status = cb_status.Checked;

            if (_edicao)
            {
                var r = _service.Editar(_idSelecionado, descricao, status);
                if (!r.ok)
                {
                    MessageBox.Show(r.msg);
                    return;
                }
                MessageBox.Show(r.msg);
            }
            else
            {
                var result = _service.Inserir(descricao, status);

                if (!result.ok)
                {
                    MessageBox.Show(result.msg);
                }

                MessageBox.Show(result.msg);
            }

        }
        private void btn_novo_Click(object sender, EventArgs e)
        {
            ExibirPainelEdicao(true);
        }
        private void ExibirPainelEdicao(bool mostrar)
        {
            pnl_edicao.Visible = mostrar;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.ExibirPainelEdicao(false);
        }

        private void carregarEspecialidades()
        {
            var lista = _service.Listar();
            dgv_especialidade.AutoGenerateColumns = true;
            dgv_especialidade.DataSource = lista;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            var termo = txt_descricao_especialidade.Text;
            dgv_especialidade.DataSource = null;
            var lista = _service.Buscar(termo);

            if (lista != null)
            {
                dgv_especialidade.DataSource = lista;
            }
            dgv_especialidade.Refresh();
            dgv_especialidade.addButtons();
        }
        private static void RemoveIfExists(DataGridView dgv, string colName)
        {
            if (dgv.Columns.Contains(colName))
                dgv.Columns.Remove(colName);
        }

        private void dgv_especialidade_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colunaSelecionada = dgv_especialidade.Columns[e.ColumnIndex].Name;

            var selecionado = dgv_especialidade.Rows[e.RowIndex].DataBoundItem as EspecialidadeDto;

            if (selecionado != null)
            {
            switch (colunaSelecionada)
                {
                    case "btnEditar":
                        _edicao = true;
                        _idSelecionado = selecionado.Id;
                        ExibirPainelEdicao(true);
                        cb_status.Checked = selecionado.Status;
                        txt_descricao.Text = selecionado.Descricao;
                        btn_salvar.Text = "Atualizar";
                        break;
                    case "btnDesativar":
                        var r = _service.Editar(selecionado.Id, status: false, edit:true);
                        if (!r.ok)
                        {
                            MessageBox.Show(r.msg);
                            return;
                        }
                        MessageBox.Show(r.msg);
                        break;

                    case "btnExcluir":
                        var confirm = MessageBox.Show(
                            "Tem certeza que deseja excluir esta especialidade?",
                            "Confirmar exclusão",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning
                        );

                        if(confirm != DialogResult.Yes)
                        {
                            return;
                        }

                        var result = _service.Excluir(selecionado.Id);

                        if (!result.ok)
                        {
                            MessageBox.Show(result.msg);
                        }

                        MessageBox.Show(result.msg);
                        break;
                }
      
            }

        }
    }
}
