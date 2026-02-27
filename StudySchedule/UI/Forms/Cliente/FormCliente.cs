using StudySchedule.Application.DTOs.Cliente;
using StudySchedule.Application.Services.Cliente;
using StudySchedule.Domain.Entities.Cliente;
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
            var nome = txt_nome.Text;
            var email = txt_email.Text;
      
            var data_nacimento = dtp_data_nascimento.Value.Date;
            var sexo = cb_sexo.SelectedValue.ToString();
            var telefone = txt_tel.Text;
            var observacao = txt_observacao.Text;
            var inserir = _service.Inserir(nome, email, data_nacimento, telefone, sexo, observacao);


            if (!inserir.ok)
            {
                MessageBox.Show(inserir.msg);
                return;
            }
            MessageBox.Show(inserir.msg);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            var nome = txt_busca_cliente.Text;

            var results = _service.Buscar(nome);



            flp_clientes.Controls.Clear();
            foreach(var result in results)
            {
                var card = new CardCliente();


                card.setCliente(result);

                card.Width = 246;
                card.Height = 140;
                card.Margin = new Padding(10);
                card.EditarClick += Card_EditarClick;
                flp_clientes.Controls.Add(card);
            }

        }

        private void Card_EditarClick(object? sender, EventArgs e)
        {
            btn_excluir.Visible = true;
            btn_cadastrar.Text = "Atualizar";
            pnl_nova_jornada.BackColor = Color.WhiteSmoke;

            var card = (CardCliente)sender!;

            var cliente = card.Cliente;

            txt_nome.Text = cliente.Nome;
            txt_email.Text = cliente.Email;
            txt_tel.Text = cliente.Telefone;
            dtp_data_nascimento.Text = cliente.DataNascimento.ToString();
            txt_observacao.Text = cliente.Observacao;
            cb_sexo.Text = cliente.Sexo;    
        }
    }
}
