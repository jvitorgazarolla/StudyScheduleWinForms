namespace StudySchedule.UI.Forms.Especialidade
{
    partial class FormEspecialidade
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
            components = new System.ComponentModel.Container();
            pnl_edicao = new Panel();
            cb_status = new CheckBox();
            btn_limpar = new Button();
            btn_cancelar = new Button();
            btn_salvar = new Button();
            lbl_descricao = new Label();
            txt_descricao = new TextBox();
            btn_buscar = new Button();
            btn_novo = new Button();
            txt_descricao_especialidade = new TextBox();
            lbl_titulo = new Label();
            gpb_lista = new GroupBox();
            dgv_especialidade = new DataGridView();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            pnl_edicao.SuspendLayout();
            gpb_lista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_especialidade).BeginInit();
            SuspendLayout();
            // 
            // pnl_edicao
            // 
            pnl_edicao.Controls.Add(cb_status);
            pnl_edicao.Controls.Add(btn_limpar);
            pnl_edicao.Controls.Add(btn_cancelar);
            pnl_edicao.Controls.Add(btn_salvar);
            pnl_edicao.Controls.Add(lbl_descricao);
            pnl_edicao.Controls.Add(txt_descricao);
            pnl_edicao.Dock = DockStyle.Bottom;
            pnl_edicao.Location = new Point(3, 22);
            pnl_edicao.Name = "pnl_edicao";
            pnl_edicao.Size = new Size(1037, 309);
            pnl_edicao.TabIndex = 4;
            pnl_edicao.Visible = false;
            // 
            // cb_status
            // 
            cb_status.AutoSize = true;
            cb_status.Location = new Point(662, 106);
            cb_status.Name = "cb_status";
            cb_status.Size = new Size(57, 19);
            cb_status.TabIndex = 16;
            cb_status.Text = "Ativo:";
            cb_status.UseVisualStyleBackColor = true;
            // 
            // btn_limpar
            // 
            btn_limpar.BackColor = Color.FromArgb(64, 64, 64);
            btn_limpar.FlatAppearance.BorderSize = 0;
            btn_limpar.ForeColor = SystemColors.ControlLightLight;
            btn_limpar.Location = new Point(544, 133);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(175, 31);
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
            btn_cancelar.Location = new Point(362, 133);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(176, 31);
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
            btn_salvar.Location = new Point(157, 133);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(199, 31);
            btn_salvar.TabIndex = 10;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = false;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // lbl_descricao
            // 
            lbl_descricao.AutoSize = true;
            lbl_descricao.Location = new Point(157, 86);
            lbl_descricao.Name = "lbl_descricao";
            lbl_descricao.Size = new Size(61, 15);
            lbl_descricao.TabIndex = 1;
            lbl_descricao.Text = "Descrição:";
            // 
            // txt_descricao
            // 
            txt_descricao.Location = new Point(157, 104);
            txt_descricao.Name = "txt_descricao";
            txt_descricao.Size = new Size(499, 23);
            txt_descricao.TabIndex = 0;
            // 
            // btn_buscar
            // 
            btn_buscar.BackColor = Color.FromArgb(0, 0, 192);
            btn_buscar.Enabled = false;
            btn_buscar.FlatAppearance.BorderSize = 0;
            btn_buscar.ForeColor = SystemColors.ControlLightLight;
            btn_buscar.Location = new Point(936, 89);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(119, 23);
            btn_buscar.TabIndex = 19;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = false;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // btn_novo
            // 
            btn_novo.BackColor = Color.MediumSeaGreen;
            btn_novo.FlatAppearance.BorderSize = 0;
            btn_novo.ForeColor = SystemColors.ControlLightLight;
            btn_novo.Location = new Point(904, 60);
            btn_novo.Name = "btn_novo";
            btn_novo.Size = new Size(151, 23);
            btn_novo.TabIndex = 17;
            btn_novo.Text = "Cadastrar Especialdiade";
            btn_novo.UseVisualStyleBackColor = false;
            btn_novo.Click += btn_novo_Click;
            // 
            // txt_descricao_especialidade
            // 
            txt_descricao_especialidade.Location = new Point(12, 89);
            txt_descricao_especialidade.Name = "txt_descricao_especialidade";
            txt_descricao_especialidade.PlaceholderText = "Digite o nome da especialidade para busca";
            txt_descricao_especialidade.Size = new Size(918, 23);
            txt_descricao_especialidade.TabIndex = 16;
            txt_descricao_especialidade.TextChanged += txt_descricao_especialidade_TextChanged;
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_titulo.Location = new Point(12, 9);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(306, 25);
            lbl_titulo.TabIndex = 15;
            lbl_titulo.Text = "Gerenciamento de Especialidades";
            lbl_titulo.UseMnemonic = false;
            // 
            // gpb_lista
            // 
            gpb_lista.Controls.Add(pnl_edicao);
            gpb_lista.Controls.Add(dgv_especialidade);
            gpb_lista.Location = new Point(12, 129);
            gpb_lista.Name = "gpb_lista";
            gpb_lista.Size = new Size(1043, 334);
            gpb_lista.TabIndex = 18;
            gpb_lista.TabStop = false;
            gpb_lista.Text = "Especialidades Cadastradas";
            // 
            // dgv_especialidade
            // 
            dgv_especialidade.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_especialidade.BackgroundColor = Color.White;
            dgv_especialidade.BorderStyle = BorderStyle.None;
            dgv_especialidade.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_especialidade.Location = new Point(6, 22);
            dgv_especialidade.Name = "dgv_especialidade";
            dgv_especialidade.ReadOnly = true;
            dgv_especialidade.RowHeadersVisible = false;
            dgv_especialidade.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_especialidade.Size = new Size(1007, 293);
            dgv_especialidade.TabIndex = 3;
            dgv_especialidade.CellContentClick += dgv_especialidade_CellContentClick;
            // 
            // FormEspecialidade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 611);
            Controls.Add(gpb_lista);
            Controls.Add(btn_buscar);
            Controls.Add(btn_novo);
            Controls.Add(txt_descricao_especialidade);
            Controls.Add(lbl_titulo);
            Name = "FormEspecialidade";
            Text = "FormEspecialidade";
            Load += FormEspecialidade_Load;
            pnl_edicao.ResumeLayout(false);
            pnl_edicao.PerformLayout();
            gpb_lista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_especialidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnl_edicao;
        private CheckBox cb_status;
        private Button btn_limpar;
        private Button btn_cancelar;
        private Button btn_salvar;
        private Label lbl_descricao;
        private TextBox txt_descricao;
        private Button btn_buscar;
        private Button btn_novo;
        private TextBox txt_descricao_especialidade;
        private Label lbl_titulo;
        private GroupBox gpb_lista;
        private DataGridView dgv_especialidade;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
    }
}