namespace StudySchedule.UI.Forms.Profissiional
{
    partial class FormJornada
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
            dtp_dia = new DateTimePicker();
            lbl_titulo = new Label();
            lbl_busca_profissional = new Label();
            btn_salvar = new Button();
            lbl_profissiional = new Label();
            label1 = new Label();
            dtp_duracao = new DateTimePicker();
            lbl_hora_fim = new Label();
            lbl_hora_inicio = new Label();
            dtp_hora_fim = new DateTimePicker();
            dtp_hora_inicio = new DateTimePicker();
            dtp_data = new DateTimePicker();
            lbl_data = new Label();
            pnl_nova_jornada = new Panel();
            cb_profissional = new ComboBox();
            panel1 = new Panel();
            btn_novo = new Button();
            lbl_cadastrar_jornada = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            txt_busca_profissional = new TextBox();
            btn_buscar = new Button();
            dtp_busca_data = new DateTimePicker();
            label2 = new Label();
            label4 = new Label();
            dgv_jornada = new DataGridView();
            pnl_resultado_busca = new Panel();
            pnl_nova_jornada.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_jornada).BeginInit();
            pnl_resultado_busca.SuspendLayout();
            SuspendLayout();
            // 
            // dtp_dia
            // 
            dtp_dia.Location = new Point(0, 0);
            dtp_dia.Name = "dtp_dia";
            dtp_dia.Size = new Size(200, 23);
            dtp_dia.TabIndex = 0;
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_titulo.Location = new Point(343, 20);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(225, 32);
            lbl_titulo.TabIndex = 15;
            lbl_titulo.Text = "Busca de Jornadas";
            lbl_titulo.UseMnemonic = false;
            // 
            // lbl_busca_profissional
            // 
            lbl_busca_profissional.AutoSize = true;
            lbl_busca_profissional.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_busca_profissional.ForeColor = SystemColors.ControlDarkDark;
            lbl_busca_profissional.Location = new Point(3, 14);
            lbl_busca_profissional.Name = "lbl_busca_profissional";
            lbl_busca_profissional.Size = new Size(104, 21);
            lbl_busca_profissional.TabIndex = 26;
            lbl_busca_profissional.Text = "Profissional:";
            // 
            // btn_salvar
            // 
            btn_salvar.BackColor = Color.ForestGreen;
            btn_salvar.FlatAppearance.BorderSize = 0;
            btn_salvar.FlatStyle = FlatStyle.Flat;
            btn_salvar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_salvar.ForeColor = SystemColors.ControlLightLight;
            btn_salvar.Location = new Point(26, 430);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(296, 27);
            btn_salvar.TabIndex = 28;
            btn_salvar.Text = "+ Nova Jornada";
            btn_salvar.UseVisualStyleBackColor = false;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // lbl_profissiional
            // 
            lbl_profissiional.AutoSize = true;
            lbl_profissiional.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_profissiional.ForeColor = SystemColors.ControlDarkDark;
            lbl_profissiional.Location = new Point(26, 153);
            lbl_profissiional.Name = "lbl_profissiional";
            lbl_profissiional.Size = new Size(104, 21);
            lbl_profissiional.TabIndex = 9;
            lbl_profissiional.Text = "Profissional:";
            lbl_profissiional.Click += lbl_profissiional_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(26, 359);
            label1.Name = "label1";
            label1.Size = new Size(116, 21);
            label1.TabIndex = 8;
            label1.Text = "Duração(Min)";
            // 
            // dtp_duracao
            // 
            dtp_duracao.Font = new Font("Segoe UI", 10F);
            dtp_duracao.Location = new Point(26, 383);
            dtp_duracao.Name = "dtp_duracao";
            dtp_duracao.Size = new Size(296, 25);
            dtp_duracao.TabIndex = 7;
            // 
            // lbl_hora_fim
            // 
            lbl_hora_fim.AutoSize = true;
            lbl_hora_fim.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_hora_fim.ForeColor = SystemColors.ControlDarkDark;
            lbl_hora_fim.Location = new Point(185, 292);
            lbl_hora_fim.Name = "lbl_hora_fim";
            lbl_hora_fim.Size = new Size(83, 21);
            lbl_hora_fim.TabIndex = 6;
            lbl_hora_fim.Text = "Hora Fim:";
            // 
            // lbl_hora_inicio
            // 
            lbl_hora_inicio.AutoSize = true;
            lbl_hora_inicio.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_hora_inicio.ForeColor = SystemColors.ControlDarkDark;
            lbl_hora_inicio.Location = new Point(26, 291);
            lbl_hora_inicio.Name = "lbl_hora_inicio";
            lbl_hora_inicio.Size = new Size(98, 21);
            lbl_hora_inicio.TabIndex = 5;
            lbl_hora_inicio.Text = "Hora Inicio:";
            // 
            // dtp_hora_fim
            // 
            dtp_hora_fim.Font = new Font("Segoe UI", 10F);
            dtp_hora_fim.Location = new Point(185, 318);
            dtp_hora_fim.Name = "dtp_hora_fim";
            dtp_hora_fim.ShowUpDown = true;
            dtp_hora_fim.Size = new Size(137, 25);
            dtp_hora_fim.TabIndex = 4;
            dtp_hora_fim.ValueChanged += dtp_hora_fim_ValueChanged;
            // 
            // dtp_hora_inicio
            // 
            dtp_hora_inicio.Font = new Font("Segoe UI", 10F);
            dtp_hora_inicio.Location = new Point(26, 318);
            dtp_hora_inicio.Name = "dtp_hora_inicio";
            dtp_hora_inicio.ShowUpDown = true;
            dtp_hora_inicio.Size = new Size(142, 25);
            dtp_hora_inicio.TabIndex = 3;
            dtp_hora_inicio.ValueChanged += dtp_hora_inicio_ValueChanged;
            // 
            // dtp_data
            // 
            dtp_data.Font = new Font("Segoe UI", 10F);
            dtp_data.Location = new Point(26, 241);
            dtp_data.Name = "dtp_data";
            dtp_data.Size = new Size(296, 25);
            dtp_data.TabIndex = 2;
            // 
            // lbl_data
            // 
            lbl_data.AutoSize = true;
            lbl_data.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_data.ForeColor = SystemColors.ControlDarkDark;
            lbl_data.Location = new Point(26, 217);
            lbl_data.Name = "lbl_data";
            lbl_data.Size = new Size(50, 21);
            lbl_data.TabIndex = 1;
            lbl_data.Text = "Data:";
            // 
            // pnl_nova_jornada
            // 
            pnl_nova_jornada.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnl_nova_jornada.BackColor = SystemColors.Control;
            pnl_nova_jornada.Controls.Add(cb_profissional);
            pnl_nova_jornada.Controls.Add(label1);
            pnl_nova_jornada.Controls.Add(dtp_duracao);
            pnl_nova_jornada.Controls.Add(btn_salvar);
            pnl_nova_jornada.Controls.Add(lbl_hora_fim);
            pnl_nova_jornada.Controls.Add(panel1);
            pnl_nova_jornada.Controls.Add(lbl_hora_inicio);
            pnl_nova_jornada.Controls.Add(btn_novo);
            pnl_nova_jornada.Controls.Add(dtp_hora_fim);
            pnl_nova_jornada.Controls.Add(lbl_cadastrar_jornada);
            pnl_nova_jornada.Controls.Add(dtp_hora_inicio);
            pnl_nova_jornada.Controls.Add(lbl_profissiional);
            pnl_nova_jornada.Controls.Add(dtp_data);
            pnl_nova_jornada.Controls.Add(lbl_data);
            pnl_nova_jornada.Location = new Point(-14, -12);
            pnl_nova_jornada.Name = "pnl_nova_jornada";
            pnl_nova_jornada.Size = new Size(347, 749);
            pnl_nova_jornada.TabIndex = 28;
            pnl_nova_jornada.Paint += pnl_nova_jornada_Paint;
            // 
            // cb_profissional
            // 
            cb_profissional.Font = new Font("Segoe UI", 10F);
            cb_profissional.FormattingEnabled = true;
            cb_profissional.Location = new Point(26, 180);
            cb_profissional.Name = "cb_profissional";
            cb_profissional.Size = new Size(296, 25);
            cb_profissional.TabIndex = 29;
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
            btn_novo.Text = "Cadastrar Jornada";
            btn_novo.UseVisualStyleBackColor = false;
            btn_novo.Click += btn_novo_Click;
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
            lbl_cadastrar_jornada.Click += lbl_cadastrar_jornada_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Blue;
            panel2.Location = new Point(343, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(1216, 3);
            panel2.TabIndex = 29;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Controls.Add(txt_busca_profissional);
            panel3.Controls.Add(btn_buscar);
            panel3.Controls.Add(dtp_busca_data);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(353, 85);
            panel3.Name = "panel3";
            panel3.Size = new Size(835, 77);
            panel3.TabIndex = 30;
            // 
            // txt_busca_profissional
            // 
            txt_busca_profissional.Font = new Font("Segoe UI", 11F);
            txt_busca_profissional.Location = new Point(19, 32);
            txt_busca_profissional.Name = "txt_busca_profissional";
            txt_busca_profissional.Size = new Size(339, 27);
            txt_busca_profissional.TabIndex = 31;
            txt_busca_profissional.TextChanged += txt_busca_profissional_TextChanged;
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
            btn_buscar.Size = new Size(126, 27);
            btn_buscar.TabIndex = 30;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = false;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // dtp_busca_data
            // 
            dtp_busca_data.Font = new Font("Segoe UI", 11F);
            dtp_busca_data.Location = new Point(364, 32);
            dtp_busca_data.Name = "dtp_busca_data";
            dtp_busca_data.Size = new Size(336, 27);
            dtp_busca_data.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(364, 12);
            label2.Name = "label2";
            label2.Size = new Size(44, 19);
            label2.TabIndex = 12;
            label2.Text = "Data:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(19, 10);
            label4.Name = "label4";
            label4.Size = new Size(163, 19);
            label4.TabIndex = 10;
            label4.Text = "Filtrar por Profissional:";
            // 
            // dgv_jornada
            // 
            dgv_jornada.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_jornada.Location = new Point(3, 10);
            dgv_jornada.Name = "dgv_jornada";
            dgv_jornada.Size = new Size(837, 559);
            dgv_jornada.TabIndex = 31;
            // 
            // pnl_resultado_busca
            // 
            pnl_resultado_busca.BackColor = SystemColors.ButtonHighlight;
            pnl_resultado_busca.Controls.Add(dgv_jornada);
            pnl_resultado_busca.Location = new Point(353, 168);
            pnl_resultado_busca.Name = "pnl_resultado_busca";
            pnl_resultado_busca.Size = new Size(840, 520);
            pnl_resultado_busca.TabIndex = 32;
            // 
            // FormJornada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1205, 700);
            Controls.Add(pnl_resultado_busca);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pnl_nova_jornada);
            Controls.Add(lbl_titulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimumSize = new Size(900, 500);
            Name = "FormJornada";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormJornada";
            pnl_nova_jornada.ResumeLayout(false);
            pnl_nova_jornada.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_jornada).EndInit();
            pnl_resultado_busca.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dtp_dia;
        private Label lbl_titulo;
        private Label lbl_tipo_busca;
        private Label lbl_busca_profissional;
        private Panel pnl_edicao;
        private Label lbl_data;
        private DateTimePicker dtp_duracao;
        private Label lbl_hora_fim;
        private Label lbl_hora_inicio;
        private DateTimePicker dtp_hora_fim;
        private DateTimePicker dtp_hora_inicio;
        private DateTimePicker dtp_data;
        private Label label1;
        private Label lbl_profissiional;
        private Button btn_salvar;
        private Panel pnl_nova_jornada;
        private Label lbl_cadastrar_jornada;
        private Panel panel1;
        private Button btn_novo;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private Label label4;
        private Button btn_buscar;
        private DateTimePicker dtp_busca_data;
        private DataGridView dgv_jornada;
        private TextBox txt_busca_profissional;
        private Panel pnl_resultado_busca;
        private ComboBox cb_profissional;
    }
}