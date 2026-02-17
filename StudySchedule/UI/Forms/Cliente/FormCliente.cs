using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudySchedule.UI.Forms.Cliente
{
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            ExibirPainelEdicao(true);
        }
        
        private void ExibirPainelEdicao(bool mostrar)
        {
            pnl_edicao.Visible = mostrar;

            dgv_clientes.Visible = !mostrar;
        }
    }
}
