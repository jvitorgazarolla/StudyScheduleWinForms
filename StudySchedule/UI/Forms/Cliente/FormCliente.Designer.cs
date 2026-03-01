namespace StudySchedule.UI.Forms.Cliente
{
    partial class FormCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnl_filtro = new Panel();
            txt_busca_cliente = new TextBox();
            btn_buscar = new Button();
            label4 = new Label();
            lbl_titulo = new Label();
            flp_clientes = new FlowLayoutPanel();
            panel2 = new Panel();
            pnl_cadastro_cliente = new Panel();
            txt_email = new TextBox();
            lbl_email = new Label();
            chk_status = new CheckBox();
            btn_excluir = new Button();
            lbl_observacao = new Label();
            txt_observacao = new TextBox();
            lbl_data_nascimento = new Label();
            dtp_data_nascimento = new DateTimePicker();
            btn_cadastrar = new Button();
            lbl_sexo = new Label();
            cb_sexo = new ComboBox();
            txt_tel = new TextBox();
            txt_nome = new TextBox();
            lbl_telefone = new Label();
            panel3 = new Panel();
            btn_novo = new Button();
            lbl_cadastrar_jornada = new Label();
            lbl_nome = new Label();
            pnl_filtro.SuspendLayout();
            pnl_cadastro_cliente.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_filtro
            // 
            pnl_filtro.BackColor = Color.White;
            pnl_filtro.Controls.Add(txt_busca_cliente);
            pnl_filtro.Controls.Add(btn_buscar);
            pnl_filtro.Controls.Add(label4);
            pnl_filtro.Location = new Point(366, 79);
            pnl_filtro.Name = "pnl_filtro";
            pnl_filtro.Size = new Size(830, 90);
            pnl_filtro.TabIndex = 31;
            // 
            // txt_busca_cliente
            // 
            txt_busca_cliente.Font = new Font("Segoe UI", 11F);
            txt_busca_cliente.Location = new Point(19, 32);
            txt_busca_cliente.Name = "txt_busca_cliente";
            txt_busca_cliente.Size = new Size(637, 27);
            txt_busca_cliente.TabIndex = 31;
            // 
            // btn_buscar
            // 
            btn_buscar.BackColor = SystemColors.ControlDark;
            btn_buscar.FlatAppearance.BorderSize = 0;
            btn_buscar.FlatStyle = FlatStyle.Flat;
            btn_buscar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_buscar.ForeColor = SystemColors.ControlLightLight;
            btn_buscar.Location = new Point(662, 32);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(147, 27);
            btn_buscar.TabIndex = 30;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = false;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(19, 10);
            label4.Name = "label4";
            label4.Size = new Size(131, 19);
            label4.TabIndex = 10;
            label4.Text = "Filtrar por Cliente:";
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_titulo.Location = new Point(365, 12);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(212, 32);
            lbl_titulo.TabIndex = 32;
            lbl_titulo.Text = "Busca de Clientes";
            lbl_titulo.UseMnemonic = false;
            // 
            // flp_clientes
            // 
            flp_clientes.AutoScroll = true;
            flp_clientes.BackColor = SystemColors.ButtonFace;
            flp_clientes.ForeColor = SystemColors.ControlDark;
            flp_clientes.Location = new Point(366, 186);
            flp_clientes.Name = "flp_clientes";
            flp_clientes.Size = new Size(827, 500);
            flp_clientes.TabIndex = 33;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Green;
            panel2.Location = new Point(366, 47);
            panel2.Name = "panel2";
            panel2.Size = new Size(829, 3);
            panel2.TabIndex = 12;
            // 
            // pnl_cadastro_cliente
            // 
            pnl_cadastro_cliente.BackColor = Color.White;
            pnl_cadastro_cliente.Controls.Add(txt_email);
            pnl_cadastro_cliente.Controls.Add(lbl_email);
            pnl_cadastro_cliente.Controls.Add(chk_status);
            pnl_cadastro_cliente.Controls.Add(btn_excluir);
            pnl_cadastro_cliente.Controls.Add(lbl_observacao);
            pnl_cadastro_cliente.Controls.Add(txt_observacao);
            pnl_cadastro_cliente.Controls.Add(lbl_data_nascimento);
            pnl_cadastro_cliente.Controls.Add(dtp_data_nascimento);
            pnl_cadastro_cliente.Controls.Add(btn_cadastrar);
            pnl_cadastro_cliente.Controls.Add(lbl_sexo);
            pnl_cadastro_cliente.Controls.Add(cb_sexo);
            pnl_cadastro_cliente.Controls.Add(txt_tel);
            pnl_cadastro_cliente.Controls.Add(txt_nome);
            pnl_cadastro_cliente.Controls.Add(lbl_telefone);
            pnl_cadastro_cliente.Controls.Add(panel3);
            pnl_cadastro_cliente.Controls.Add(btn_novo);
            pnl_cadastro_cliente.Controls.Add(lbl_cadastrar_jornada);
            pnl_cadastro_cliente.Controls.Add(lbl_nome);
            pnl_cadastro_cliente.Location = new Point(12, 12);
            pnl_cadastro_cliente.Name = "pnl_cadastro_cliente";
            pnl_cadastro_cliente.Size = new Size(338, 674);
            pnl_cadastro_cliente.TabIndex = 34;
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Segoe UI", 10F);
            txt_email.Location = new Point(23, 208);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(300, 25);
            txt_email.TabIndex = 62;
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_email.ForeColor = SystemColors.ControlDarkDark;
            lbl_email.Location = new Point(19, 184);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(53, 21);
            lbl_email.TabIndex = 61;
            lbl_email.Text = "Email";
            // 
            // chk_status
            // 
            chk_status.AutoSize = true;
            chk_status.Location = new Point(269, 134);
            chk_status.Name = "chk_status";
            chk_status.Size = new Size(54, 19);
            chk_status.TabIndex = 60;
            chk_status.Text = "Ativo";
            chk_status.UseVisualStyleBackColor = true;
            // 
            // btn_excluir
            // 
            btn_excluir.BackColor = Color.Red;
            btn_excluir.FlatAppearance.BorderSize = 0;
            btn_excluir.FlatStyle = FlatStyle.Flat;
            btn_excluir.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_excluir.ForeColor = SystemColors.ControlLightLight;
            btn_excluir.Location = new Point(19, 540);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(304, 27);
            btn_excluir.TabIndex = 59;
            btn_excluir.Text = "Excluir";
            btn_excluir.UseVisualStyleBackColor = false;
            btn_excluir.Visible = false;
            // 
            // lbl_observacao
            // 
            lbl_observacao.AutoSize = true;
            lbl_observacao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_observacao.ForeColor = SystemColors.ControlDarkDark;
            lbl_observacao.Location = new Point(23, 392);
            lbl_observacao.Name = "lbl_observacao";
            lbl_observacao.Size = new Size(104, 21);
            lbl_observacao.TabIndex = 58;
            lbl_observacao.Text = "Observação:";
            // 
            // txt_observacao
            // 
            txt_observacao.Location = new Point(23, 416);
            txt_observacao.Multiline = true;
            txt_observacao.Name = "txt_observacao";
            txt_observacao.PlaceholderText = "Ex: Cliente possui alguma alergia";
            txt_observacao.Size = new Size(304, 80);
            txt_observacao.TabIndex = 57;
            // 
            // lbl_data_nascimento
            // 
            lbl_data_nascimento.AutoSize = true;
            lbl_data_nascimento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_data_nascimento.ForeColor = SystemColors.ControlDarkDark;
            lbl_data_nascimento.Location = new Point(19, 288);
            lbl_data_nascimento.Name = "lbl_data_nascimento";
            lbl_data_nascimento.Size = new Size(146, 21);
            lbl_data_nascimento.TabIndex = 56;
            lbl_data_nascimento.Text = "Data Nascimento:";
            // 
            // dtp_data_nascimento
            // 
            dtp_data_nascimento.Font = new Font("Segoe UI", 10F);
            dtp_data_nascimento.Location = new Point(23, 312);
            dtp_data_nascimento.Name = "dtp_data_nascimento";
            dtp_data_nascimento.Size = new Size(300, 25);
            dtp_data_nascimento.TabIndex = 55;
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.BackColor = Color.ForestGreen;
            btn_cadastrar.FlatAppearance.BorderSize = 0;
            btn_cadastrar.FlatStyle = FlatStyle.Flat;
            btn_cadastrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cadastrar.ForeColor = SystemColors.ControlLightLight;
            btn_cadastrar.Location = new Point(19, 502);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(304, 27);
            btn_cadastrar.TabIndex = 54;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = false;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // lbl_sexo
            // 
            lbl_sexo.AutoSize = true;
            lbl_sexo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_sexo.ForeColor = SystemColors.ControlDarkDark;
            lbl_sexo.Location = new Point(19, 340);
            lbl_sexo.Name = "lbl_sexo";
            lbl_sexo.Size = new Size(51, 21);
            lbl_sexo.TabIndex = 53;
            lbl_sexo.Text = "Sexo:";
            // 
            // cb_sexo
            // 
            cb_sexo.Font = new Font("Segoe UI", 10F);
            cb_sexo.FormattingEnabled = true;
            cb_sexo.Location = new Point(23, 364);
            cb_sexo.Name = "cb_sexo";
            cb_sexo.Size = new Size(300, 25);
            cb_sexo.TabIndex = 52;
            // 
            // txt_tel
            // 
            txt_tel.Font = new Font("Segoe UI", 10F);
            txt_tel.Location = new Point(23, 260);
            txt_tel.Name = "txt_tel";
            txt_tel.Size = new Size(300, 25);
            txt_tel.TabIndex = 51;
            // 
            // txt_nome
            // 
            txt_nome.Font = new Font("Segoe UI", 10F);
            txt_nome.Location = new Point(23, 156);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(300, 25);
            txt_nome.TabIndex = 50;
            // 
            // lbl_telefone
            // 
            lbl_telefone.AutoSize = true;
            lbl_telefone.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_telefone.ForeColor = SystemColors.ControlDarkDark;
            lbl_telefone.Location = new Point(19, 236);
            lbl_telefone.Name = "lbl_telefone";
            lbl_telefone.Size = new Size(80, 21);
            lbl_telefone.TabIndex = 49;
            lbl_telefone.Text = "Telefone:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Green;
            panel3.Location = new Point(19, 117);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 3);
            panel3.TabIndex = 47;
            // 
            // btn_novo
            // 
            btn_novo.BackColor = Color.FromArgb(0, 123, 255);
            btn_novo.FlatAppearance.BorderSize = 0;
            btn_novo.FlatStyle = FlatStyle.Flat;
            btn_novo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_novo.ForeColor = SystemColors.ControlLightLight;
            btn_novo.Location = new Point(23, 35);
            btn_novo.Name = "btn_novo";
            btn_novo.Size = new Size(296, 27);
            btn_novo.TabIndex = 48;
            btn_novo.Text = "Cadastrar Cliente";
            btn_novo.UseVisualStyleBackColor = false;
            btn_novo.Click += btn_novo_Click;
            // 
            // lbl_cadastrar_jornada
            // 
            lbl_cadastrar_jornada.AutoSize = true;
            lbl_cadastrar_jornada.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbl_cadastrar_jornada.Location = new Point(19, 89);
            lbl_cadastrar_jornada.Name = "lbl_cadastrar_jornada";
            lbl_cadastrar_jornada.Size = new Size(163, 25);
            lbl_cadastrar_jornada.TabIndex = 46;
            lbl_cadastrar_jornada.Text = "Cadastrar Cliente";
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nome.ForeColor = SystemColors.ControlDarkDark;
            lbl_nome.Location = new Point(19, 132);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(61, 21);
            lbl_nome.TabIndex = 45;
            lbl_nome.Text = "Nome:";
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1205, 700);
            Controls.Add(pnl_cadastro_cliente);
            Controls.Add(panel2);
            Controls.Add(flp_clientes);
            Controls.Add(lbl_titulo);
            Controls.Add(pnl_filtro);
            Name = "FormCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCliente";
            Load += FormCliente_Load;
            pnl_filtro.ResumeLayout(false);
            pnl_filtro.PerformLayout();
            pnl_cadastro_cliente.ResumeLayout(false);
            pnl_cadastro_cliente.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnl_filtro;
        private TextBox txt_busca_cliente;
        private Button btn_buscar;
        private Label label4;
        private Label lbl_titulo;
        private FlowLayoutPanel flp_clientes;
        private TextBox textBox1;
        private Panel panel2;
        private Panel pnl_cadastro_cliente;
        private TextBox txt_email;
        private Label lbl_email;
        private CheckBox chk_status;
        private Button btn_excluir;
        private Label lbl_observacao;
        private TextBox txt_observacao;
        private Label lbl_data_nascimento;
        private DateTimePicker dtp_data_nascimento;
        private Button btn_cadastrar;
        private Label lbl_sexo;
        private ComboBox cb_sexo;
        private TextBox txt_tel;
        private TextBox txt_nome;
        private Label lbl_telefone;
        private Panel panel3;
        private Button btn_novo;
        private Label lbl_cadastrar_jornada;
        private Label lbl_nome;
    }
}