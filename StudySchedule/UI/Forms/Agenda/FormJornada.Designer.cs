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
            dgv_profissional = new DataGridView();
            cb_especialidade = new ComboBox();
            lbl_especialidade = new Label();
            btn_limpar = new Button();
            btn_cancelar = new Button();
            btn_salvar = new Button();
            gpb_lista = new GroupBox();
            pnl_edicao = new Panel();
            dtp_data = new DateTimePicker();
            dtp_horario = new DateTimePicker();
            lbl_horaio = new Label();
            cb_profissional = new ComboBox();
            lbl_profissional = new Label();
            lbl_data = new Label();
            dtp_dia = new DateTimePicker();
            btn_buscar = new Button();
            btn_novo = new Button();
            txt_busca_profissional = new TextBox();
            lbl_titulo = new Label();
            cb_filtro = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgv_profissional).BeginInit();
            gpb_lista.SuspendLayout();
            pnl_edicao.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_profissional
            // 
            dgv_profissional.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_profissional.BackgroundColor = SystemColors.Control;
            dgv_profissional.BorderStyle = BorderStyle.None;
            dgv_profissional.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_profissional.Location = new Point(6, 22);
            dgv_profissional.Name = "dgv_profissional";
            dgv_profissional.ReadOnly = true;
            dgv_profissional.RowHeadersVisible = false;
            dgv_profissional.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_profissional.Size = new Size(908, 293);
            dgv_profissional.TabIndex = 3;
            // 
            // cb_especialidade
            // 
            cb_especialidade.Enabled = false;
            cb_especialidade.Font = new Font("Segoe UI", 11.25F);
            cb_especialidade.FormattingEnabled = true;
            cb_especialidade.Location = new Point(114, 134);
            cb_especialidade.Name = "cb_especialidade";
            cb_especialidade.Size = new Size(285, 28);
            cb_especialidade.TabIndex = 15;
            // 
            // lbl_especialidade
            // 
            lbl_especialidade.AutoSize = true;
            lbl_especialidade.Font = new Font("Segoe UI", 11.25F);
            lbl_especialidade.Location = new Point(114, 111);
            lbl_especialidade.Name = "lbl_especialidade";
            lbl_especialidade.Size = new Size(104, 20);
            lbl_especialidade.TabIndex = 14;
            lbl_especialidade.Text = "Especialidade:";
            // 
            // btn_limpar
            // 
            btn_limpar.BackColor = Color.FromArgb(64, 64, 64);
            btn_limpar.FlatAppearance.BorderSize = 0;
            btn_limpar.Font = new Font("Segoe UI", 11.25F);
            btn_limpar.ForeColor = SystemColors.ControlLightLight;
            btn_limpar.Location = new Point(321, 184);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(78, 31);
            btn_limpar.TabIndex = 12;
            btn_limpar.Text = "Limpar";
            btn_limpar.UseVisualStyleBackColor = false;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.Red;
            btn_cancelar.FlatAppearance.BorderSize = 0;
            btn_cancelar.Font = new Font("Segoe UI", 11.25F);
            btn_cancelar.ForeColor = SystemColors.ControlLightLight;
            btn_cancelar.Location = new Point(212, 184);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(103, 31);
            btn_cancelar.TabIndex = 11;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_salvar
            // 
            btn_salvar.BackColor = Color.MediumSeaGreen;
            btn_salvar.FlatAppearance.BorderSize = 0;
            btn_salvar.Font = new Font("Segoe UI", 11.25F);
            btn_salvar.ForeColor = SystemColors.ControlLightLight;
            btn_salvar.Location = new Point(122, 184);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(84, 31);
            btn_salvar.TabIndex = 10;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = false;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // gpb_lista
            // 
            gpb_lista.Controls.Add(pnl_edicao);
            gpb_lista.Controls.Add(dgv_profissional);
            gpb_lista.Location = new Point(12, 142);
            gpb_lista.Name = "gpb_lista";
            gpb_lista.Size = new Size(914, 321);
            gpb_lista.TabIndex = 18;
            gpb_lista.TabStop = false;
            gpb_lista.Text = "Jornadas:";
            // 
            // pnl_edicao
            // 
            pnl_edicao.Controls.Add(dtp_data);
            pnl_edicao.Controls.Add(dtp_horario);
            pnl_edicao.Controls.Add(lbl_horaio);
            pnl_edicao.Controls.Add(cb_profissional);
            pnl_edicao.Controls.Add(lbl_profissional);
            pnl_edicao.Controls.Add(cb_especialidade);
            pnl_edicao.Controls.Add(lbl_especialidade);
            pnl_edicao.Controls.Add(btn_limpar);
            pnl_edicao.Controls.Add(btn_cancelar);
            pnl_edicao.Controls.Add(btn_salvar);
            pnl_edicao.Controls.Add(lbl_data);
            pnl_edicao.Dock = DockStyle.Bottom;
            pnl_edicao.Location = new Point(3, 18);
            pnl_edicao.Name = "pnl_edicao";
            pnl_edicao.Size = new Size(908, 300);
            pnl_edicao.TabIndex = 4;
            pnl_edicao.Visible = false;
            pnl_edicao.Paint += pnl_edicao_Paint;
            // 
            // dtp_data
            // 
            dtp_data.Font = new Font("Segoe UI", 11.25F);
            dtp_data.Location = new Point(435, 81);
            dtp_data.Name = "dtp_data";
            dtp_data.Size = new Size(249, 27);
            dtp_data.TabIndex = 24;
            // 
            // dtp_horario
            // 
            dtp_horario.Font = new Font("Segoe UI", 11.25F);
            dtp_horario.Location = new Point(435, 135);
            dtp_horario.Name = "dtp_horario";
            dtp_horario.Size = new Size(249, 27);
            dtp_horario.TabIndex = 23;
            dtp_horario.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // lbl_horaio
            // 
            lbl_horaio.AutoSize = true;
            lbl_horaio.Font = new Font("Segoe UI", 11.25F);
            lbl_horaio.Location = new Point(435, 112);
            lbl_horaio.Name = "lbl_horaio";
            lbl_horaio.Size = new Size(60, 20);
            lbl_horaio.TabIndex = 21;
            lbl_horaio.Text = "Horário";
            // 
            // cb_profissional
            // 
            cb_profissional.Font = new Font("Segoe UI", 11.25F);
            cb_profissional.FormattingEnabled = true;
            cb_profissional.Location = new Point(114, 80);
            cb_profissional.Name = "cb_profissional";
            cb_profissional.Size = new Size(285, 28);
            cb_profissional.TabIndex = 18;
            cb_profissional.SelectedIndexChanged += cb_profissional_SelectedIndexChanged;
            // 
            // lbl_profissional
            // 
            lbl_profissional.AutoSize = true;
            lbl_profissional.Font = new Font("Segoe UI", 11.25F);
            lbl_profissional.Location = new Point(114, 57);
            lbl_profissional.Name = "lbl_profissional";
            lbl_profissional.Size = new Size(88, 20);
            lbl_profissional.TabIndex = 17;
            lbl_profissional.Text = "Profissional:";
            lbl_profissional.Click += lbl_profissional_Click;
            // 
            // lbl_data
            // 
            lbl_data.AutoSize = true;
            lbl_data.Font = new Font("Segoe UI", 11.25F);
            lbl_data.Location = new Point(435, 57);
            lbl_data.Name = "lbl_data";
            lbl_data.Size = new Size(44, 20);
            lbl_data.TabIndex = 2;
            lbl_data.Text = "Data:";
            // 
            // dtp_dia
            // 
            dtp_dia.Location = new Point(0, 0);
            dtp_dia.Name = "dtp_dia";
            dtp_dia.Size = new Size(200, 23);
            dtp_dia.TabIndex = 0;
            // 
            // btn_buscar
            // 
            btn_buscar.BackColor = Color.FromArgb(0, 0, 192);
            btn_buscar.FlatAppearance.BorderSize = 0;
            btn_buscar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_buscar.ForeColor = SystemColors.ControlLightLight;
            btn_buscar.Location = new Point(851, 89);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(75, 34);
            btn_buscar.TabIndex = 19;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = false;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // btn_novo
            // 
            btn_novo.BackColor = Color.MediumSeaGreen;
            btn_novo.FlatAppearance.BorderSize = 0;
            btn_novo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_novo.ForeColor = SystemColors.ControlLightLight;
            btn_novo.Location = new Point(736, 52);
            btn_novo.Name = "btn_novo";
            btn_novo.Size = new Size(190, 31);
            btn_novo.TabIndex = 17;
            btn_novo.Text = "Cadastrar Jornada";
            btn_novo.UseVisualStyleBackColor = false;
            btn_novo.Click += btn_novo_Click;
            // 
            // txt_busca_profissional
            // 
            txt_busca_profissional.Font = new Font("Segoe UI", 11.25F);
            txt_busca_profissional.Location = new Point(90, 96);
            txt_busca_profissional.Name = "txt_busca_profissional";
            txt_busca_profissional.PlaceholderText = "Digite o nome do profissional para busca";
            txt_busca_profissional.Size = new Size(755, 27);
            txt_busca_profissional.TabIndex = 16;
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_titulo.Location = new Point(12, 9);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(322, 32);
            lbl_titulo.TabIndex = 15;
            lbl_titulo.Text = "Gerenciamento de Jornada";
            lbl_titulo.UseMnemonic = false;
            // 
            // cb_filtro
            // 
            cb_filtro.FormattingEnabled = true;
            cb_filtro.Location = new Point(12, 100);
            cb_filtro.Name = "cb_filtro";
            cb_filtro.Size = new Size(72, 23);
            cb_filtro.TabIndex = 20;
            // 
            // FormJornada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 611);
            Controls.Add(cb_filtro);
            Controls.Add(gpb_lista);
            Controls.Add(btn_buscar);
            Controls.Add(btn_novo);
            Controls.Add(txt_busca_profissional);
            Controls.Add(lbl_titulo);
            Name = "FormJornada";
            Text = "FormJornada";
            Load += FormJornada_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_profissional).EndInit();
            gpb_lista.ResumeLayout(false);
            pnl_edicao.ResumeLayout(false);
            pnl_edicao.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_profissional;
        private ComboBox cb_especialidade;
        private Label lbl_especialidade;
        private Button btn_limpar;
        private Button btn_cancelar;
        private Button btn_salvar;
        private GroupBox gpb_lista;
        private Panel pnl_edicao;
        private Label lbl_horaio;
        private DateTimePicker dtp_dia;
        private ComboBox cb_profissional;
        private Label lbl_profissional;
        private Label lbl_data;
        private Button btn_buscar;
        private Button btn_novo;
        private TextBox txt_busca_profissional;
        private Label lbl_titulo;
        private DateTimePicker dtp_horario;
        private DateTimePicker dtp_data;
        private ComboBox cb_filtro;
    }
}