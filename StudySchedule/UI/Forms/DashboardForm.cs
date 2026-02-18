using StudySchedule.UI.Forms.Especialidade;
using StudySchedule.UI.Forms.Profissiional;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudySchedule.UI.Forms
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }
        private void DashboardForm_Load(object sender, EventArgs e)
        {
            pnl_agenda.Height = 0;
            pnl_profissional.Height = 0;
            pnl_especialidade.Height = 0;
            pnl_cliente.Height = 0;
        }


        private void btn_agenda_Click(object sender, EventArgs e)
        {
            toggleSubMenu(pnl_agenda);
        }

        private void toggleSubMenu(Panel subMenu)
        {
            if (subMenu.Height == 0)
            {
                //subMenu.Height = 40;
                subMenu.Height = subMenu.Controls.Count * 40;
            }
            else
            {
                subMenu.Height = 0;
            }
        }

        private void btn_profissional_Click(object sender, EventArgs e)
        {
            toggleSubMenu(pnl_profissional);
        }

        private void abrirFormNoPainel(Form form)
        {
            pnl_content.Controls.Clear();

            pnl_content.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.AutoSize = true;
            form.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            pnl_content.Dock = DockStyle.None;
            pnl_content.Size = form.Size;

            pnl_content.Controls.Add(form);
            form.Show();
        }

        private void btn_especialidade_Click(object sender, EventArgs e)
        {
            toggleSubMenu(pnl_especialidade);
        }


        private void btn_agenda_jornada_Click(object sender, EventArgs e)
        {


            abrirFormNoPainel(new FormJornada());
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "Tem certeza que deseja sair do sistema?",
                "Sair",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes) { 
                System.Windows.Forms.Application.Exit();

            }
            else
            {
                return;
            }

            
        }

        private void btn_gerenciar_profissional_Click(object sender, EventArgs e)
        {
            abrirFormNoPainel(new FormProfissional());
        }

        private void btn_jornada_Click(object sender, EventArgs e)
        {
            abrirFormNoPainel(new FormJornada());
        }

        private void btn_gerenciar_especialidade_Click(object sender, EventArgs e)
        {
            abrirFormNoPainel(new FormEspecialidade());

        }

        private void pnl_agenda_sub_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            toggleSubMenu(pnl_cliente);
        }

        private void btn_gerenciar_cliente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em desenvolvimento!");
        }
    }
}
