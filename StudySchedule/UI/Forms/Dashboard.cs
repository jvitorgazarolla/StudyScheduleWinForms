using StudySchedule.UI.Forms.Agendamento;
using StudySchedule.UI.Forms.Cliente;
using StudySchedule.UI.Forms.Especialidade;
using StudySchedule.UI.Forms.Profissiional;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace StudySchedule.UI.Forms
{
    public partial class Dashboard : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public Dashboard()
        {
            InitializeComponent();

            btn_profissional.MouseEnter += btn_profissional_MouseEnter;
            btn_profissional.MouseLeave += btn_profissional_MouseLeave;

            cms_profissional.Closed += (s, e) => _menuAberto = false;

        
            gerenciarToolStripMenuItem.Click += (s, e) => AbrirFormGerenciar();
            jornadaToolStripMenuItem.Click += (s, e) => AbrirFormJornada();
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            FormCliente formCliente = new FormCliente();
            formCliente.Show();
        }

        private void btn_especialidade_Click(object sender, EventArgs e)
        {
            FormEspecialidade formEspecialidade = new FormEspecialidade();

            formEspecialidade.Show();
        }

        private void btn_profissional_Click(object sender, EventArgs e)
        {
            //FormProfissional formProfissional = new FormProfissional();
            //formProfissional.Show();
        }

        private void btn_agenda_Click(object sender, EventArgs e)
        {
            FormAgendamento formAgendamento = new FormAgendamento();
            formAgendamento.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btn_profissional_MouseLeave(object sender, EventArgs e)
        {
            var posTela = Cursor.Position;
            var menuReact = new Rectangle(
                 cms_profissional.Bounds.Location,
                cms_profissional.Bounds.Size
              );
        }
        private bool _menuAberto = false;
        private void btn_profissional_MouseEnter(object sender, EventArgs e)
        {
            if (_menuAberto) return;

            _menuAberto = true;

            // abre o menu logo abaixo do botão
            cms_profissional.Show(btn_profissional, new Point(0, btn_profissional.Height));
        }

        private void AbrirFormGerenciar()
        {
            FormProfissional formProfissional = new FormProfissional();
            formProfissional.Show();
        }
        private void AbrirFormJornada()
        {
            FormJornada formJornada = new FormJornada();
            formJornada.Show();
        }

    }
}
