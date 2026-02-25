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
            pnl_nova_jornada.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_nova_jornada
            // 
            pnl_nova_jornada.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnl_nova_jornada.BackColor = SystemColors.Control;
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
            // lbl_observacao
            // 
            lbl_observacao.AutoSize = true;
            lbl_observacao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_observacao.ForeColor = SystemColors.ControlDarkDark;
            lbl_observacao.Location = new Point(26, 323);
            lbl_observacao.Name = "lbl_observacao";
            lbl_observacao.Size = new Size(104, 21);
            lbl_observacao.TabIndex = 40;
            lbl_observacao.Text = "Observação:";
            // 
            // txt_observacao
            // 
            txt_observacao.Location = new Point(26, 347);
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
            lbl_data_nascimento.Location = new Point(26, 224);
            lbl_data_nascimento.Name = "lbl_data_nascimento";
            lbl_data_nascimento.Size = new Size(146, 21);
            lbl_data_nascimento.TabIndex = 37;
            lbl_data_nascimento.Text = "Data Nascimento:";
            // 
            // dtp_data_nascimento
            // 
            dtp_data_nascimento.Font = new Font("Segoe UI", 10F);
            dtp_data_nascimento.Location = new Point(30, 247);
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
            btn_cadastrar.Location = new Point(26, 433);
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
            lbl_sexo.Location = new Point(26, 273);
            lbl_sexo.Name = "lbl_sexo";
            lbl_sexo.Size = new Size(51, 21);
            lbl_sexo.TabIndex = 34;
            lbl_sexo.Text = "Sexo:";
            // 
            // cb_sexo
            // 
            cb_sexo.Font = new Font("Segoe UI", 10F);
            cb_sexo.FormattingEnabled = true;
            cb_sexo.Location = new Point(30, 297);
            cb_sexo.Name = "cb_sexo";
            cb_sexo.Size = new Size(300, 25);
            cb_sexo.TabIndex = 33;
            // 
            // txt_tel
            // 
            txt_tel.Font = new Font("Segoe UI", 10F);
            txt_tel.Location = new Point(30, 196);
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
            lbl_telefone.Location = new Point(26, 172);
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
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1205, 700);
            Controls.Add(pnl_nova_jornada);
            Name = "FormCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCliente";
            Load += FormCliente_Load;
            pnl_nova_jornada.ResumeLayout(false);
            pnl_nova_jornada.PerformLayout();
            ResumeLayout(false);
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
    }
}