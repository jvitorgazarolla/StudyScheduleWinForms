using StudySchedule.Application.Services.Cliente;
using StudySchedule.UI.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudySchedule.UI.Forms.Agenda
{
    public partial class FormAgenda : Form
    {
        private ClienteService _ClienteService;
        public FormAgenda()
        {
            InitializeComponent();
            var ClienteService = new ClienteService();
            _ClienteService = ClienteService;
            AutoComplete();

        }

        private void FormAgenda_Load(object sender, EventArgs e)
        {
            PanelExtensions.ApplyRoundedCorners(pnl_buscar_cliente, 4);
        }

        private void AutoComplete()
        {
            var result = _ClienteService.AutoComplete("");
            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
            autoComplete.AddRange(result.nomes
                .Select(c => c.Nome)
                .ToArray());

            txt_buscar_cliente.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_buscar_cliente.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt_buscar_cliente.AutoCompleteCustomSource = autoComplete;

        }

        private void txt_buscar_cliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_buscar_cliente_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Teste saiu da text box");
        }
    }
}
