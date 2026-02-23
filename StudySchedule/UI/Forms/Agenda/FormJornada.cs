using StudySchedule.Application.DTOs.Agenda.Jornada;
using StudySchedule.Application.DTOs.Profissional;
using StudySchedule.Application.DTOs.ProfissionalEspecialidade;
using StudySchedule.Application.Services.Agenda;
using StudySchedule.Application.Services.Especialidade;
using StudySchedule.Application.Services.Profissional;
using StudySchedule.Application.Services.ProfissionalEspecialidade;
using StudySchedule.Infrastructure.Repositories.Profissional;
using StudySchedule.Infrastructure.Repositories.ProfissionalEspecialidade;
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
    public partial class FormJornada : Form
    {
        private readonly ProfissionalService _profissionalService;
        private readonly ProfissionalEspecialidadeService _profissionalEspecialidadeService;
        private readonly JornadaService _jornadaService;
        private string _filtroBusca;
        private bool _edicao = false;
        private int _jornadaId;

        public FormJornada()
        {
            InitializeComponent();

            _jornadaService = new JornadaService();
            _profissionalService = new ProfissionalService();
            _profissionalEspecialidadeService = new ProfissionalEspecialidadeService();

            dtp_busca_data.CustomFormat = "dd.MM.yyyy";
            dtp_busca_data.ShowUpDown = false;

            buscarProfissional();
        }

        private void buscarProfissional()
        {
            var lista = _profissionalService.Buscar(status: true);

            lista.Insert(0, new ProfissionalDto { Id = 0, Nome = "Selecione" });
            cb_profissional.DataSource = null;
            cb_profissional.DataSource = lista;

            cb_profissional.DisplayMember = "Nome";
            cb_profissional.ValueMember = "id";

        }
        private void btn_novo_Click(object sender, EventArgs e)
        {
            pnl_edicao.Visible = true;
            btn_salvar.Text = "Cadastar";
            _edicao = false;
            //cb_especialidade.SelectedValue = 0;
        }
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            int? profissionalId = cb_profissional.SelectedValue != null
                ? Convert.ToInt32(cb_profissional.SelectedValue)
                : (int?)null;

            DateTime data = dtp_data.Value.Date;
            TimeSpan horaInicio = new TimeSpan(
                 dtp_hora_inicio.Value.Hour,
                 dtp_hora_inicio.Value.Minute,
                 0
            );

            TimeSpan horaFim = new TimeSpan(
             dtp_hora_fim.Value.Hour,
             dtp_hora_fim.Value.Minute,
             0
            );

            if (profissionalId == 0 || profissionalId == null)
            {
                MessageBox.Show("Informe um profissional!");
                return;
            }

            var resultInsert = _jornadaService.Inserir(profissionalId.Value, data, horaInicio, horaFim);
            MessageBox.Show(resultInsert.msg);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            pnl_edicao.Visible = false;
        }

        private async void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                pb_loading.Visible = true;
                btn_buscar.Enabled = false;

                var nomeProfissional = txt_busca_profissional.Text;
                DateTime? data = null;
                if (dtp_busca_data.Checked)
                {
                    data = dtp_busca_data.Value.Date;
                }

                var lista = await Task.Run(() => _jornadaService.Buscar(nomeProfissional, data));


                if (lista != null)
                {
                    dgv_jornada.DataSource = lista;
                    dgv_jornada.addButtons();

                    dgv_jornada.removeColumn("Id");
                    dgv_jornada.removeColumn("ProfissionalId");

                    dgv_jornada.setHeader("NomeProfissional", "Profissional");
                    dgv_jornada.setHeader("HoraInicio", "Hora Inicio");
                    dgv_jornada.setHeader("HoraFim", "Hora Fim");
                }
                dgv_jornada.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                pb_loading.Visible = false;
                btn_buscar.Enabled = true;
            }
        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dtp_busca_data.Format = DateTimePickerFormat.Custom;
            dtp_busca_data.CustomFormat = "dd.MM.yyyy";
            dtp_busca_data.ShowUpDown = false;
        }
        private void dgv_jornada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var colunaSelecionada = dgv_jornada.Columns[e.ColumnIndex].Name;
            var selecionado = dgv_jornada.Rows[e.RowIndex].DataBoundItem as JornadaDto;

            if (selecionado != null)
            {
                if (colunaSelecionada == "btnEditar")
                {
                    _edicao = true;
                    _jornadaId = selecionado.Id;
                    btn_salvar.Text = "Atualizar";
                    cb_profissional.Text = selecionado.NomeProfissional;
                    dtp_data.Value = selecionado.Data;
                    dtp_hora_inicio.Value = DateTime.Today.Add(selecionado.HoraInicio);
                    dtp_hora_fim.Value = DateTime.Today.Add(selecionado.HoraFim);
                    //pnl_edicao.Visible = true;
                }
            }
        }

        private void dtp_hora_inicio_ValueChanged(object sender, EventArgs e)
        {
            dtp_hora_inicio.Format = DateTimePickerFormat.Custom;
            dtp_hora_inicio.CustomFormat = "HH:mm";
            dtp_hora_inicio.ShowUpDown = true;
        }

        private void dtp_hora_fim_ValueChanged(object sender, EventArgs e)
        {
            dtp_hora_fim.Format = DateTimePickerFormat.Custom;
            dtp_hora_fim.CustomFormat = "HH:mm";
            dtp_hora_fim.ShowUpDown = true;
        }

        private void FormJornada_Load(object sender, EventArgs e)
        {
            dtp_hora_inicio.Format = DateTimePickerFormat.Custom;
            dtp_hora_inicio.CustomFormat = "HH:mm";
            dtp_hora_inicio.ShowUpDown = true;

            dtp_hora_fim.Format = DateTimePickerFormat.Custom;
            dtp_hora_fim.CustomFormat = "HH:mm";
            dtp_hora_fim.ShowUpDown = true;

            pb_loading.Style = ProgressBarStyle.Marquee;
            pb_loading.MarqueeAnimationSpeed = 1;
            pb_loading.BringToFront();
        }

    }
}
