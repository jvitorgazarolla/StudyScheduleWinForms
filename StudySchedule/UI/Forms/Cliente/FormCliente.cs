using StudySchedule.Application.DTOs.Cliente;
using StudySchedule.Application.Services.Cliente;
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
        private readonly ClienteService _service;
        public FormCliente()
        {
            var service = new ClienteService();
            _service = service;

            InitializeComponent();
        }
        private void FormCliente_Load(object sender, EventArgs e)
        {
            carregaComboBoxSexo();
        }

        private void carregaComboBoxSexo()
        {
            var lista = new List<SexoDto>()
            {
                new SexoDto {Value ="M", Descricao = "Masculino"},
                new SexoDto {Value ="F", Descricao = "Feminino" }
            };

            cb_sexo.DataSource = lista;
            cb_sexo.DisplayMember = "Descricao";
            cb_sexo.ValueMember = "Value";
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            //var data_nascimento = dtp_data_nascimento.Value.ToString("yyyy,M,d");
            var data_nacimento = dtp_data_nascimento.Value.Date;
            var nome = txt_nome.Text;
            var sexo = cb_sexo.SelectedValue.ToString();
            var telefone = txt_tel.Text;
            var observacao = txt_observacao.Text;
            var inserir = _service.Inserir(nome, data_nacimento, telefone, sexo, observacao);
    

            if (!inserir.ok)
            {
                MessageBox.Show(inserir.msg);
            }
            MessageBox.Show(inserir.msg);

        }
    }
}
