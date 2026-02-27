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
            pnl_nova_jornada = new Panel();
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
            panel1 = new Panel();
            btn_novo = new Button();
            lbl_cadastrar_jornada = new Label();
            lbl_nome = new Label();
            panel3 = new Panel();
            txt_busca_cliente = new TextBox();
            btn_buscar = new Button();
            label4 = new Label();
            lbl_titulo = new Label();
            flp_clientes = new FlowLayoutPanel();
            txt_email = new TextBox();
            pnl_nova_jornada.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_nova_jornada
            // 
            pnl_nova_jornada.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnl_nova_jornada.BackColor = Color.White;
            pnl_nova_jornada.Controls.Add(txt_email);
            pnl_nova_jornada.Controls.Add(lbl_email);
            pnl_nova_jornada.Controls.Add(chk_status);
            pnl_nova_jornada.Controls.Add(btn_excluir);
            pnl_nova_jornada.Controls.Add(lbl_observacao);
            pnl_nova_jornada.Controls.Add(txt_observacao);
            pnl_nova_jornada.Controls.Add(lbl_data_nascimento);
            pnl_nova_jornada.Controls.Add(dtp_data_nascimento);
            pnl_nova_jornada.Controls.Add(btn_cadastrar);
            pnl_nova_jornada.Controls.Add(lbl_sexo);
            pnl_nova_jornada.Controls.Add(cb_sexo);
            pnl_nova_jornada.Controls.Add(txt_tel);
            pnl_nova_jornada.Controls.Add(txt_nome);
            pnl_nova_jornada.Controls.Add(lbl_telefone);
            pnl_nova_jornada.Controls.Add(panel1);
            pnl_nova_jornada.Controls.Add(btn_novo);
            pnl_nova_jornada.Controls.Add(lbl_cadastrar_jornada);
            pnl_nova_jornada.Controls.Add(lbl_nome);
            pnl_nova_jornada.Location = new Point(12, 12);
            pnl_nova_jornada.Name = "pnl_nova_jornada";
            pnl_nova_jornada.Size = new Size(347, 749);
            pnl_nova_jornada.TabIndex = 29;
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_email.ForeColor = SystemColors.ControlDarkDark;
            lbl_email.Location = new Point(26, 174);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(53, 21);
            lbl_email.TabIndex = 43;
            lbl_email.Text = "Email";
            // 
            // chk_status
            // 
            chk_status.AutoSize = true;
            chk_status.Location = new Point(276, 116);
            chk_status.Name = "chk_status";
            chk_status.Size = new Size(54, 19);
            chk_status.TabIndex = 42;
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
            btn_excluir.Location = new Point(26, 530);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(304, 27);
            btn_excluir.TabIndex = 41;
            btn_excluir.Text = "Excluir";
            btn_excluir.UseVisualStyleBackColor = false;
            btn_excluir.Visible = false;
            // 
            // lbl_observacao
            // 
            lbl_observacao.AutoSize = true;
            lbl_observacao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_observacao.ForeColor = SystemColors.ControlDarkDark;
            lbl_observacao.Location = new Point(30, 382);
            lbl_observacao.Name = "lbl_observacao";
            lbl_observacao.Size = new Size(104, 21);
            lbl_observacao.TabIndex = 40;
            lbl_observacao.Text = "Observação:";
            // 
            // txt_observacao
            // 
            txt_observacao.Location = new Point(30, 406);
            txt_observacao.Multiline = true;
            txt_observacao.Name = "txt_observacao";
            txt_observacao.PlaceholderText = "Ex: Cliente possui alguma alergia";
            txt_observacao.Size = new Size(304, 80);
            txt_observacao.TabIndex = 38;
            // 
            // lbl_data_nascimento
            // 
            lbl_data_nascimento.AutoSize = true;
            lbl_data_nascimento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_data_nascimento.ForeColor = SystemColors.ControlDarkDark;
            lbl_data_nascimento.Location = new Point(26, 278);
            lbl_data_nascimento.Name = "lbl_data_nascimento";
            lbl_data_nascimento.Size = new Size(146, 21);
            lbl_data_nascimento.TabIndex = 37;
            lbl_data_nascimento.Text = "Data Nascimento:";
            // 
            // dtp_data_nascimento
            // 
            dtp_data_nascimento.Font = new Font("Segoe UI", 10F);
            dtp_data_nascimento.Location = new Point(30, 302);
            dtp_data_nascimento.Name = "dtp_data_nascimento";
            dtp_data_nascimento.Size = new Size(300, 25);
            dtp_data_nascimento.TabIndex = 36;
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.BackColor = Color.ForestGreen;
            btn_cadastrar.FlatAppearance.BorderSize = 0;
            btn_cadastrar.FlatStyle = FlatStyle.Flat;
            btn_cadastrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cadastrar.ForeColor = SystemColors.ControlLightLight;
            btn_cadastrar.Location = new Point(26, 492);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(304, 27);
            btn_cadastrar.TabIndex = 35;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = false;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // lbl_sexo
            // 
            lbl_sexo.AutoSize = true;
            lbl_sexo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_sexo.ForeColor = SystemColors.ControlDarkDark;
            lbl_sexo.Location = new Point(26, 330);
            lbl_sexo.Name = "lbl_sexo";
            lbl_sexo.Size = new Size(51, 21);
            lbl_sexo.TabIndex = 34;
            lbl_sexo.Text = "Sexo:";
            // 
            // cb_sexo
            // 
            cb_sexo.Font = new Font("Segoe UI", 10F);
            cb_sexo.FormattingEnabled = true;
            cb_sexo.Location = new Point(30, 354);
            cb_sexo.Name = "cb_sexo";
            cb_sexo.Size = new Size(300, 25);
            cb_sexo.TabIndex = 33;
            // 
            // txt_tel
            // 
            txt_tel.Font = new Font("Segoe UI", 10F);
            txt_tel.Location = new Point(30, 250);
            txt_tel.Name = "txt_tel";
            txt_tel.Size = new Size(300, 25);
            txt_tel.TabIndex = 32;
            // 
            // txt_nome
            // 
            txt_nome.Font = new Font("Segoe UI", 10F);
            txt_nome.Location = new Point(30, 146);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(300, 25);
            txt_nome.TabIndex = 31;
            // 
            // lbl_telefone
            // 
            lbl_telefone.AutoSize = true;
            lbl_telefone.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_telefone.ForeColor = SystemColors.ControlDarkDark;
            lbl_telefone.Location = new Point(26, 226);
            lbl_telefone.Name = "lbl_telefone";
            lbl_telefone.Size = new Size(80, 21);
            lbl_telefone.TabIndex = 30;
            lbl_telefone.Text = "Telefone:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.Location = new Point(26, 107);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 3);
            panel1.TabIndex = 11;
            // 
            // btn_novo
            // 
            btn_novo.BackColor = Color.FromArgb(0, 123, 255);
            btn_novo.FlatAppearance.BorderSize = 0;
            btn_novo.FlatStyle = FlatStyle.Flat;
            btn_novo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_novo.ForeColor = SystemColors.ControlLightLight;
            btn_novo.Location = new Point(26, 32);
            btn_novo.Name = "btn_novo";
            btn_novo.Size = new Size(296, 27);
            btn_novo.TabIndex = 17;
            btn_novo.Text = "Cadastrar Cliente";
            btn_novo.UseVisualStyleBackColor = false;
            // 
            // lbl_cadastrar_jornada
            // 
            lbl_cadastrar_jornada.AutoSize = true;
            lbl_cadastrar_jornada.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbl_cadastrar_jornada.Location = new Point(26, 79);
            lbl_cadastrar_jornada.Name = "lbl_cadastrar_jornada";
            lbl_cadastrar_jornada.Size = new Size(174, 25);
            lbl_cadastrar_jornada.TabIndex = 10;
            lbl_cadastrar_jornada.Text = "Cadastrar Jornada";
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nome.ForeColor = SystemColors.ControlDarkDark;
            lbl_nome.Location = new Point(26, 122);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(61, 21);
            lbl_nome.TabIndex = 9;
            lbl_nome.Text = "Nome:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(txt_busca_cliente);
            panel3.Controls.Add(btn_buscar);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(374, 47);
            panel3.Name = "panel3";
            panel3.Size = new Size(830, 90);
            panel3.TabIndex = 31;
            // 
            // txt_busca_cliente
            // 
            txt_busca_cliente.Font = new Font("Segoe UI", 11F);
            txt_busca_cliente.Location = new Point(19, 32);
            txt_busca_cliente.Name = "txt_busca_cliente";
            txt_busca_cliente.Size = new Size(681, 27);
            txt_busca_cliente.TabIndex = 31;
            // 
            // btn_buscar
            // 
            btn_buscar.BackColor = SystemColors.ControlDark;
            btn_buscar.FlatAppearance.BorderSize = 0;
            btn_buscar.FlatStyle = FlatStyle.Flat;
            btn_buscar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_buscar.ForeColor = SystemColors.ControlLightLight;
            btn_buscar.Location = new Point(706, 32);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(121, 27);
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
            lbl_titulo.Location = new Point(374, 12);
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
            flp_clientes.Location = new Point(374, 143);
            flp_clientes.Name = "flp_clientes";
            flp_clientes.Size = new Size(827, 500);
            flp_clientes.TabIndex = 33;
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Segoe UI", 10F);
            txt_email.Location = new Point(30, 198);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(300, 25);
            txt_email.TabIndex = 44;
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1205, 700);
            Controls.Add(flp_clientes);
            Controls.Add(lbl_titulo);
            Controls.Add(panel3);
            Controls.Add(pnl_nova_jornada);
            Name = "FormCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCliente";
            Load += FormCliente_Load;
            pnl_nova_jornada.ResumeLayout(false);
            pnl_nova_jornada.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnl_nova_jornada;
        private Panel panel1;
        private Button btn_novo;
        private Label lbl_cadastrar_jornada;
        private Label lbl_nome;
        private Label lbl_telefone;
        private Label lbl_sexo;
        private ComboBox cb_sexo;
        private TextBox txt_tel;
        private TextBox txt_nome;
        private Button btn_cadastrar;
        private Label lbl_observacao;
        private TextBox txt_observacao;
        private Label lbl_data_nascimento;
        private DateTimePicker dtp_data_nascimento;
        private Panel panel3;
        private TextBox txt_busca_cliente;
        private Button btn_buscar;
        private Label label4;
        private Label lbl_titulo;
        private FlowLayoutPanel flp_clientes;
        private Button btn_excluir;
        private CheckBox chk_status;
        private TextBox textBox1;
        private Label lbl_email;
        private TextBox txt_email;
    }
}