using StudySchedule.Application.DTOs.Cliente;
using StudySchedule.Application.Services.Cliente;
using StudySchedule.Domain.Entities.Cliente;
using StudySchedule.UI.Extensions;
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
        private int _clienteId;
        private bool isEdicao => _clienteId > 0;
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
            redimensionarBordas();
        }
        private void redimensionarBordas()
        {
            //Panel
            PanelExtensions.ApplyRoundedCorners(pnl_filtro, 7);
            PanelExtensions.ApplyRoundedCorners(pnl_cadastro_cliente, 7);

            //Button
            ButtonExtensions.ApplyRoundedCorners(btn_buscar, 7);
            ButtonExtensions.ApplyRoundedCorners(btn_cadastrar, 7);
            ButtonExtensions.ApplyRoundedCorners(btn_novo, 7);
            ButtonExtensions.ApplyRoundedCorners(btn_cadastrar, 7);

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


            if (isEdicao)

            {
                var atualizar = _service.Atualizar(_clienteId, nome, email, data_nacimento, telefone, observacao, sexo);

                if (!atualizar.ok)
                {
                    MessageBox.Show(atualizar.msg);
                    return;
                }
                else
                {
                    MessageBox.Show(atualizar.msg);
                }

            }
            else
            {
                var inserir = _service.Inserir(nome, email, data_nacimento, telefone, sexo, observacao);
                if (!inserir.ok)
                {
                    MessageBox.Show(inserir.msg);
                    return;
                }
                MessageBox.Show(inserir.msg);
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            var nome = txt_busca_cliente.Text;

            var results = _service.Buscar(nome);



            flp_clientes.Controls.Clear();
            foreach (var result in results)
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
            pnl_cadastro_cliente.BackColor = Color.WhiteSmoke;

            var card = (CardCliente)sender!;

            var cliente = card.Cliente;
            _clienteId = cliente.Id;
            txt_nome.Text = cliente.Nome;
            txt_email.Text = cliente.Email;
            txt_tel.Text = cliente.Telefone;
            dtp_data_nascimento.Text = cliente.DataNascimento.ToString();
            txt_observacao.Text = cliente.Observacao;
            cb_sexo.Text = cliente.Sexo;
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void limparCampos()
        {
            _clienteId = 0;
            txt_nome.Text = null;
            txt_email.Text = null;
            txt_observacao.Text = null;
            txt_tel.Text = null;
            dtp_data_nascimento.Text = null;
            cb_sexo.Text = null;
            chk_status.Checked = true;
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            var confrm = MessageBox.Show("Deseja Excluir esse paciente?", 
                            "Sim!",
                             MessageBoxButtons.YesNo, 
                             MessageBoxIcon.Warning
            );

            if(confrm == DialogResult.Yes)
            {
                var resultExcluir = _service.Excluir(_clienteId);
                if (!resultExcluir.ok)
                {
                    MessageBox.Show(resultExcluir.msg);
                }
                else
                {
                    MessageBox.Show(resultExcluir.msg);
                    btn_buscar_Click(btn_buscar, EventArgs.Empty);

                }
            }

              
        }
    }
}
