using StudySchedule.Application.DTOs.Profissional;
using StudySchedule.Application.DTOs.ProfissionalEspecialidade;
using StudySchedule.Application.Services.Agenda;
using StudySchedule.Application.Services.Especialidade;
using StudySchedule.Application.Services.Profissional;
using StudySchedule.Application.Services.ProfissionalEspecialidade;
using StudySchedule.Infrastructure.Repositories.Profissional;
using StudySchedule.Infrastructure.Repositories.ProfissionalEspecialidade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudySchedule.UI.Forms.Profissiional
{
    public partial class FormJornada : Form
    {
        private readonly ProfissionalService _profissionalService;
        private readonly ProfissionalEspecialidadeService _profissionalEspecialidadeService;
        private readonly JornadaService _jornadaService;



        public FormJornada()
        {
            InitializeComponent();
            dtp_horario.Format = DateTimePickerFormat.Custom;
            dtp_horario.CustomFormat = "HH:mm";
            dtp_horario.ShowUpDown = true;
            dtp_data.Format = DateTimePickerFormat.Custom;
            dtp_data.CustomFormat = "dd.MM.yyyy";
            dtp_data.ShowUpDown = false;

            var repositoryProfissionalEspecialidade = new ProfissionalEspecialidadeRepository();
            _jornadaService = new JornadaService();
            _profissionalService = new ProfissionalService();
            _profissionalEspecialidadeService = new ProfissionalEspecialidadeService(repositoryProfissionalEspecialidade);

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
        private void buscaEspecialidade(int profissionalId)
        {
            var lista = new List<ProfissionalEspecialidadeDto>();

            lista.Add(new ProfissionalEspecialidadeDto { Id = 0, Descricao = "Selecione" });

            if (profissionalId > 0)
            {
                var especialidade = _profissionalEspecialidadeService.Buscar(profissionalId: profissionalId);
                lista.AddRange(especialidade);
            }

            cb_especialidade.DataSource = null;
            cb_especialidade.DisplayMember = "Descricao";
            cb_especialidade.ValueMember = "Id";
            cb_especialidade.DataSource = lista;

            cb_especialidade.SelectedValue = 0;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dtp_horario.Format = DateTimePickerFormat.Custom;
            dtp_horario.CustomFormat = "HH:mm";
            dtp_horario.ShowUpDown = true;
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            pnl_edicao.Visible = true;
        }

        private void FormJornada_Load(object sender, EventArgs e)
        {
     


        }

        private void cb_profissional_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cb_profissional.SelectedValue == null)
                return;

            int profissionalId = (int)cb_profissional.SelectedValue;

            buscaEspecialidade(profissionalId);

            if (profissionalId != 0)
            {
                cb_especialidade.Enabled = true;
            }
            else
            {
                cb_especialidade.Enabled = false;

            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (cb_profissional.SelectedValue == null)
                return;

            if (cb_especialidade.SelectedValue == null)
                return;

            int profissionalId = (int)cb_profissional.SelectedValue;
            int profissionalEspecialidadeId = (int)cb_especialidade.SelectedValue;

            DateTime data = dtp_data.Value.Date;

            TimeSpan horario = new TimeSpan(
                 dtp_horario.Value.Hour,
                 dtp_horario.Value.Minute,
                 0
            );
            var resultInsert = _jornadaService.Inserir(profissionalId, profissionalEspecialidadeId, data, horario);


            if (!resultInsert.ok)
            {
                MessageBox.Show(resultInsert.msg);
            }

            MessageBox.Show(resultInsert.msg);
        }

        private void pnl_edicao_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            pnl_edicao.Visible = false;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            gpb_lista.Visible = true;
            var termo = txt_busca_profissional.Text;


        }

        private void lbl_profissional_Click(object sender, EventArgs e)
        {

        }
    }
}
