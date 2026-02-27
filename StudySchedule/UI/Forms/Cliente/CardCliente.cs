using StudySchedule.Application.DTOs.Cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudySchedule.UI.Forms.Cliente
{
    public partial class CardCliente : UserControl
    {
        public ClienteDto? Cliente { get; private set; }
        public event EventHandler? EditarClick;
        public CardCliente()
        {
            InitializeComponent();
            lbl_nome.AutoSize = true;
        }

        public void setNome(string nome)
        {
            lbl_nome.Text = nome;
        }

        public void setCliente(ClienteDto cliente)
        {
            Cliente = cliente;
            lbl_nome.Text = cliente.Nome;
            lbl_telefone.Text = cliente.Telefone;
            lbl_email.Text = cliente.Email;
        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            
            EditarClick?.Invoke(this, EventArgs.Empty);
        }

        private void pnl_cliente_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
