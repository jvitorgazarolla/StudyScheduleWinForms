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
        public CardCliente()
        {
            InitializeComponent();
            lbl_nome.AutoSize = true;
        }

        public void setNome(string nome)
        {
            lbl_nome.Text = nome;
        }



        private void txt_nome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
