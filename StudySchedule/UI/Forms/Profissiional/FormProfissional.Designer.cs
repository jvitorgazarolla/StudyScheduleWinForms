namespace StudySchedule.UI.Forms.Profissiional
{
    partial class FormProfissional
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
            btn_buscar = new Button();
            btn_novo = new Button();
            txt_busca_profissional = new TextBox();
            btn_limpar = new Button();
            btn_cancelar = new Button();
            btn_salvar = new Button();
            lbl_titulo = new Label();
            txt_telefone = new TextBox();
            lbl_telefone = new Label();
            lbl_nome = new Label();
            txt_nome = new TextBox();
            pnl_edicao = new Panel();
            check_status = new CheckBox();
            cb_especialidade = new ComboBox();
            lbl_especialidade = new Label();
            gpb_lista = new GroupBox();
            dgv_profissional = new DataGridView();
            pnl_edicao.SuspendLayout();
            gpb_lista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_profissional).BeginInit();
            SuspendLayout();
            // 
            // btn_buscar
            // 
            btn_buscar.BackColor = Color.FromArgb(0, 0, 192);
            btn_buscar.FlatAppearance.BorderSize = 0;
            btn_buscar.ForeColor = SystemColors.ControlLightLight;
            btn_buscar.Location = new Point(848, 86);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(75, 23);
            btn_buscar.TabIndex = 14;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = false;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // btn_novo
            // 
            btn_novo.BackColor = Color.MediumSeaGreen;
            btn_novo.FlatAppearance.BorderSize = 0;
            btn_novo.ForeColor = SystemColors.ControlLightLight;
            btn_novo.Location = new Point(733, 57);
            btn_novo.Name = "btn_novo";
            btn_novo.Size = new Size(190, 23);
            btn_novo.TabIndex = 12;
            btn_novo.Text = "Cadastrar Profissional";
            btn_novo.UseVisualStyleBackColor = false;
            btn_novo.Click += btn_novo_Click;
            // 
            // txt_busca_profissional
            // 
            txt_busca_profissional.Location = new Point(22, 85);
            txt_busca_profissional.Name = "txt_busca_profissional";
            txt_busca_profissional.PlaceholderText = "Digite o nome do profissional para busca";
            txt_busca_profissional.Size = new Size(820, 23);
            txt_busca_profissional.TabIndex = 11;
            // 
            // btn_limpar
            // 
            btn_limpar.BackColor = Color.FromArgb(64, 64, 64);
            btn_limpar.FlatAppearance.BorderSize = 0;
            btn_limpar.ForeColor = SystemColors.ControlLightLight;
            btn_limpar.Location = new Point(556, 117);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(78, 31);
            btn_limpar.TabIndex = 12;
            btn_limpar.Text = "Limpar";
            btn_limpar.UseVisualStyleBackColor = false;
            btn_limpar.Click += btn_limpar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.Red;
            btn_cancelar.FlatAppearance.BorderSize = 0;
            btn_cancelar.ForeColor = SystemColors.ControlLightLight;
            btn_cancelar.Location = new Point(475, 117);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 31);
            btn_cancelar.TabIndex = 11;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_salvar
            // 
            btn_salvar.BackColor = Color.MediumSeaGreen;
            btn_salvar.FlatAppearance.BorderSize = 0;
            btn_salvar.ForeColor = SystemColors.ControlLightLight;
            btn_salvar.Location = new Point(385, 117);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(84, 31);
            btn_salvar.TabIndex = 10;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = false;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_titulo.Location = new Point(12, 9);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(284, 25);
            lbl_titulo.TabIndex = 10;
            lbl_titulo.Text = "Gerenciamento de Profissional";
            lbl_titulo.UseMnemonic = false;
            // 
            // txt_telefone
            // 
            txt_telefone.Location = new Point(385, 78);
            txt_telefone.Name = "txt_telefone";
            txt_telefone.Size = new Size(249, 23);
            txt_telefone.TabIndex = 3;
            // 
            // lbl_telefone
            // 
            lbl_telefone.AutoSize = true;
            lbl_telefone.Location = new Point(385, 60);
            lbl_telefone.Name = "lbl_telefone";
            lbl_telefone.Size = new Size(55, 15);
            lbl_telefone.TabIndex = 2;
            lbl_telefone.Text = "Telefone:";
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Location = new Point(72, 60);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(43, 15);
            lbl_nome.TabIndex = 1;
            lbl_nome.Text = "Nome:";
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(72, 78);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(285, 23);
            txt_nome.TabIndex = 0;
            // 
            // pnl_edicao
            // 
            pnl_edicao.Controls.Add(check_status);
            pnl_edicao.Controls.Add(cb_especialidade);
            pnl_edicao.Controls.Add(lbl_especialidade);
            pnl_edicao.Controls.Add(btn_limpar);
            pnl_edicao.Controls.Add(btn_cancelar);
            pnl_edicao.Controls.Add(btn_salvar);
            pnl_edicao.Controls.Add(txt_telefone);
            pnl_edicao.Controls.Add(lbl_telefone);
            pnl_edicao.Controls.Add(lbl_nome);
            pnl_edicao.Controls.Add(txt_nome);
            pnl_edicao.Dock = DockStyle.Bottom;
            pnl_edicao.Location = new Point(3, 22);
            pnl_edicao.Name = "pnl_edicao";
            pnl_edicao.Size = new Size(814, 289);
            pnl_edicao.TabIndex = 4;
            pnl_edicao.Visible = false;
            // 
            // check_status
            // 
            check_status.AutoSize = true;
            check_status.Location = new Point(649, 80);
            check_status.Name = "check_status";
            check_status.Size = new Size(54, 19);
            check_status.TabIndex = 16;
            check_status.Text = "Ativo";
            check_status.UseVisualStyleBackColor = true;
            // 
            // cb_especialidade
            // 
            cb_especialidade.FormattingEnabled = true;
            cb_especialidade.Location = new Point(72, 122);
            cb_especialidade.Name = "cb_especialidade";
            cb_especialidade.Size = new Size(285, 23);
            cb_especialidade.TabIndex = 15;
            // 
            // lbl_especialidade
            // 
            lbl_especialidade.AutoSize = true;
            lbl_especialidade.Location = new Point(72, 104);
            lbl_especialidade.Name = "lbl_especialidade";
            lbl_especialidade.Size = new Size(81, 15);
            lbl_especialidade.TabIndex = 14;
            lbl_especialidade.Text = "Especialidade:";
            // 
            // gpb_lista
            // 
            gpb_lista.Controls.Add(pnl_edicao);
            gpb_lista.Controls.Add(dgv_profissional);
            gpb_lista.Location = new Point(22, 133);
            gpb_lista.Name = "gpb_lista";
            gpb_lista.Size = new Size(820, 314);
            gpb_lista.TabIndex = 13;
            gpb_lista.TabStop = false;
            gpb_lista.Text = "Profissionais:";
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
            dgv_profissional.Size = new Size(808, 293);
            dgv_profissional.TabIndex = 3;
            dgv_profissional.CellContentClick += dgv_profissional_CellContentClick;
            // 
            // FormProfissional
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 611);
            Controls.Add(btn_buscar);
            Controls.Add(btn_novo);
            Controls.Add(txt_busca_profissional);
            Controls.Add(lbl_titulo);
            Controls.Add(gpb_lista);
            Name = "FormProfissional";
            Text = "Gerenciamento de Profissionais";
            Load += Profissional_Load;
            pnl_edicao.ResumeLayout(false);
            pnl_edicao.PerformLayout();
            gpb_lista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_profissional).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_buscar;
        private Button btn_novo;
        private TextBox txt_busca_profissional;
        private Button btn_limpar;
        private Button btn_cancelar;
        private Button btn_salvar;
        private Label lbl_titulo;
        private TextBox txt_telefone;
        private Label lbl_telefone;
        private Label lbl_nome;
        private TextBox txt_nome;
        private Panel pnl_edicao;
        private Label lbl_especialidade;
        private GroupBox gpb_lista;
        private DataGridView dgv_profissional;
        private ComboBox cb_especialidade;
        private CheckBox check_status;
    }
}