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
            dgv_clientes = new DataGridView();
            gpb_lista = new GroupBox();
            pnl_edicao = new Panel();
            btn_limpar = new Button();
            btn_cancelar = new Button();
            btn_salvar = new Button();
            gp_observacao = new GroupBox();
            txt_produto_alergico = new TextBox();
            cb_alergico = new CheckBox();
            lbl_profissional = new Label();
            comboBox1 = new ComboBox();
            cb_genero = new ComboBox();
            lbl_sexo = new Label();
            textBox2 = new TextBox();
            lbl_telefone = new Label();
            lbl_nome = new Label();
            txt_nome = new TextBox();
            btn_novo = new Button();
            textBox1 = new TextBox();
            lbl_titulo = new Label();
            btn_buscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_clientes).BeginInit();
            gpb_lista.SuspendLayout();
            pnl_edicao.SuspendLayout();
            gp_observacao.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_clientes
            // 
            dgv_clientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_clientes.BackgroundColor = Color.White;
            dgv_clientes.BorderStyle = BorderStyle.None;
            dgv_clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_clientes.Location = new Point(6, 22);
            dgv_clientes.Name = "dgv_clientes";
            dgv_clientes.ReadOnly = true;
            dgv_clientes.RowHeadersVisible = false;
            dgv_clientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_clientes.Size = new Size(994, 293);
            dgv_clientes.TabIndex = 3;
            // 
            // gpb_lista
            // 
            gpb_lista.Controls.Add(pnl_edicao);
            gpb_lista.Controls.Add(dgv_clientes);
            gpb_lista.Location = new Point(33, 201);
            gpb_lista.Name = "gpb_lista";
            gpb_lista.Size = new Size(1019, 321);
            gpb_lista.TabIndex = 8;
            gpb_lista.TabStop = false;
            gpb_lista.Text = "Clientes";
            // 
            // pnl_edicao
            // 
            pnl_edicao.Controls.Add(btn_limpar);
            pnl_edicao.Controls.Add(btn_cancelar);
            pnl_edicao.Controls.Add(btn_salvar);
            pnl_edicao.Controls.Add(gp_observacao);
            pnl_edicao.Controls.Add(cb_alergico);
            pnl_edicao.Controls.Add(lbl_profissional);
            pnl_edicao.Controls.Add(comboBox1);
            pnl_edicao.Controls.Add(cb_genero);
            pnl_edicao.Controls.Add(lbl_sexo);
            pnl_edicao.Controls.Add(textBox2);
            pnl_edicao.Controls.Add(lbl_telefone);
            pnl_edicao.Controls.Add(lbl_nome);
            pnl_edicao.Controls.Add(txt_nome);
            pnl_edicao.Dock = DockStyle.Bottom;
            pnl_edicao.Location = new Point(3, 15);
            pnl_edicao.Name = "pnl_edicao";
            pnl_edicao.Size = new Size(1013, 303);
            pnl_edicao.TabIndex = 4;
            pnl_edicao.Visible = false;
            // 
            // btn_limpar
            // 
            btn_limpar.BackColor = Color.FromArgb(64, 64, 64);
            btn_limpar.FlatAppearance.BorderSize = 0;
            btn_limpar.ForeColor = SystemColors.ControlLightLight;
            btn_limpar.Location = new Point(600, 231);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(149, 42);
            btn_limpar.TabIndex = 12;
            btn_limpar.Text = "Limpar";
            btn_limpar.UseVisualStyleBackColor = false;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.Red;
            btn_cancelar.FlatAppearance.BorderSize = 0;
            btn_cancelar.ForeColor = SystemColors.ControlLightLight;
            btn_cancelar.Location = new Point(406, 231);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(149, 42);
            btn_cancelar.TabIndex = 11;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // btn_salvar
            // 
            btn_salvar.BackColor = Color.MediumSeaGreen;
            btn_salvar.FlatAppearance.BorderSize = 0;
            btn_salvar.ForeColor = SystemColors.ControlLightLight;
            btn_salvar.Location = new Point(187, 231);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(149, 42);
            btn_salvar.TabIndex = 10;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = false;
            // 
            // gp_observacao
            // 
            gp_observacao.Controls.Add(txt_produto_alergico);
            gp_observacao.Location = new Point(187, 167);
            gp_observacao.Name = "gp_observacao";
            gp_observacao.Size = new Size(570, 47);
            gp_observacao.TabIndex = 10;
            gp_observacao.TabStop = false;
            gp_observacao.Text = "Quais produtos?";
            // 
            // txt_produto_alergico
            // 
            txt_produto_alergico.Location = new Point(6, 22);
            txt_produto_alergico.Name = "txt_produto_alergico";
            txt_produto_alergico.Size = new Size(562, 23);
            txt_produto_alergico.TabIndex = 9;
            // 
            // cb_alergico
            // 
            cb_alergico.AutoSize = true;
            cb_alergico.Location = new Point(187, 142);
            cb_alergico.Name = "cb_alergico";
            cb_alergico.Size = new Size(135, 19);
            cb_alergico.TabIndex = 8;
            cb_alergico.Text = "Alérgico a produtos?";
            cb_alergico.UseVisualStyleBackColor = true;
            // 
            // lbl_profissional
            // 
            lbl_profissional.AutoSize = true;
            lbl_profissional.Location = new Point(500, 82);
            lbl_profissional.Name = "lbl_profissional";
            lbl_profissional.Size = new Size(71, 15);
            lbl_profissional.TabIndex = 7;
            lbl_profissional.Text = "Profissional:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(500, 100);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(249, 23);
            comboBox1.TabIndex = 6;
            // 
            // cb_genero
            // 
            cb_genero.FormattingEnabled = true;
            cb_genero.Location = new Point(187, 100);
            cb_genero.Name = "cb_genero";
            cb_genero.Size = new Size(285, 23);
            cb_genero.TabIndex = 5;
            // 
            // lbl_sexo
            // 
            lbl_sexo.AutoSize = true;
            lbl_sexo.Location = new Point(187, 82);
            lbl_sexo.Name = "lbl_sexo";
            lbl_sexo.Size = new Size(34, 15);
            lbl_sexo.TabIndex = 4;
            lbl_sexo.Text = "Sexo:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(500, 56);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(249, 23);
            textBox2.TabIndex = 3;
            // 
            // lbl_telefone
            // 
            lbl_telefone.AutoSize = true;
            lbl_telefone.Location = new Point(500, 38);
            lbl_telefone.Name = "lbl_telefone";
            lbl_telefone.Size = new Size(55, 15);
            lbl_telefone.TabIndex = 2;
            lbl_telefone.Text = "Telefone:";
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Location = new Point(187, 38);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(43, 15);
            lbl_nome.TabIndex = 1;
            lbl_nome.Text = "Nome:";
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(187, 56);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(285, 23);
            txt_nome.TabIndex = 0;
            // 
            // btn_novo
            // 
            btn_novo.BackColor = Color.MediumSeaGreen;
            btn_novo.FlatAppearance.BorderSize = 0;
            btn_novo.ForeColor = SystemColors.ControlLightLight;
            btn_novo.Location = new Point(985, 132);
            btn_novo.Name = "btn_novo";
            btn_novo.Size = new Size(75, 23);
            btn_novo.TabIndex = 7;
            btn_novo.Text = "Novo";
            btn_novo.UseVisualStyleBackColor = false;
            btn_novo.Click += button1_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(33, 161);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Digite o nome do cliente para busca";
            textBox1.Size = new Size(946, 23);
            textBox1.TabIndex = 6;
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_titulo.Location = new Point(460, 88);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(81, 25);
            lbl_titulo.TabIndex = 5;
            lbl_titulo.Text = "Clientes";
            lbl_titulo.UseMnemonic = false;
            // 
            // btn_buscar
            // 
            btn_buscar.BackColor = Color.FromArgb(0, 0, 192);
            btn_buscar.FlatAppearance.BorderSize = 0;
            btn_buscar.ForeColor = SystemColors.ControlLightLight;
            btn_buscar.Location = new Point(985, 161);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(75, 23);
            btn_buscar.TabIndex = 9;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = false;
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 611);
            Controls.Add(btn_buscar);
            Controls.Add(gpb_lista);
            Controls.Add(btn_novo);
            Controls.Add(textBox1);
            Controls.Add(lbl_titulo);
            Name = "FormCliente";
            Text = "FormCliente";
            ((System.ComponentModel.ISupportInitialize)dgv_clientes).EndInit();
            gpb_lista.ResumeLayout(false);
            pnl_edicao.ResumeLayout(false);
            pnl_edicao.PerformLayout();
            gp_observacao.ResumeLayout(false);
            gp_observacao.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_clientes;
        private GroupBox gpb_lista;
        private Panel pnl_edicao;
        private Button btn_novo;
        private TextBox textBox1;
        private Label lbl_titulo;
        private Label lbl_sexo;
        private TextBox textBox2;
        private Label lbl_telefone;
        private Label lbl_nome;
        private TextBox txt_nome;
        private ComboBox comboBox1;
        private ComboBox cb_genero;
        private CheckBox cb_alergico;
        private Label lbl_profissional;
        private GroupBox gp_observacao;
        private TextBox txt_produto_alergico;
        private Button btn_salvar;
        private Button btn_buscar;
        private Button btn_limpar;
        private Button btn_cancelar;
    }
}